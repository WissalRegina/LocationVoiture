Imports System
Imports System.Data.SqlClient
Imports System.Data.Common.DbCommand

Public Class Rent
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrateur\Documents\CarRentalVbDb.mdf;Integrated Security=True;Connect Timeout=30
")
    Private Sub fillCustomer()
        con.Open()
        Dim sql = "select * from CustomerTbl"
        Dim cmd As New SqlCommand(sql, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        CustIdCb.DataSource = tbl
        CustIdCb.DisplayMember = "CustId"
        CustIdCb.ValueMember = "CustId"
        con.Close()
    End Sub
    Private Sub fillregistration()
        Dim status = "yes"
        con.Open()
        Dim sql = "select * from CarTbl where Available='" & status & "'"
        Dim cmd As New SqlCommand(sql, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable()
        adapter.Fill(tbl)
        RegNumCb.DataSource = tbl
        RegNumCb.DisplayMember = "RegNo"
        RegNumCb.ValueMember = "RegNo"
        con.Close()
    End Sub
    Private Sub GetCustName()
        con.Open()
        Dim sql = "select * from CustomerTbl where CustId=" & CustIdCb.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(sql, con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            CustnameTb.Text = reader(1).ToString()

        End While
        con.Close()

    End Sub
    Dim cost = 0
    Private Sub GetCarRate()
        con.Open()
        Dim sql = "select * from CarTbl where RegNo='" & RegNumCb.SelectedValue.ToString() & "'"
        Dim cmd As New SqlCommand(sql, con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            'CustnameTb.Text = reader(1).ToString()
            cost = Convert.ToInt32(reader(4).ToString())
        End While
        con.Close()

    End Sub

    Private Sub UpdateCar()
        Dim status = "no"
        Try
            con.Open()
            Dim query = "update CarTbl set Available='" & status & "'where RegNo='" & RegNumCb.SelectedValue.ToString() & "'"

            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            'MsgBox("car successfully updated")
            con.Close()
            'clear()
            'populate()

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Rent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillCustomer()
        fillregistration()
        populate()

    End Sub

    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CustIdCb.SelectionChangeCommitted
        GetCustName()
    End Sub

    Private Sub clear()
        CustnameTb.Text = ""
        FeesTb.Text = ""

    End Sub
    Private Sub populate()
        con.Open()
        Dim sql = "select * from RentTbl"
        Dim cmd = New SqlCommand(sql, con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        rentDgv.DataSource = ds.Tables(0)
        con.Close()
    End Sub
    Private Sub CalculateFees()
        Dim diff As System.TimeSpan = ReturnDate.Value.Date.Subtract(RentDate.Value.Date)
        Dim days = diff.TotalDays
        Dim fees = days * cost
        FeesTb.Text = fees
    End Sub
    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        If CustnameTb.Text = "" Or RegNumCb.SelectedIndex = -1 Or FeesTb.Text = "" Then
            MsgBox("missing Data")
        Else
            Try
                con.Open()
                Dim query = "insert into RentTbl values('" & RegNumCb.SelectedValue.ToString() & "','" & CustIdCb.SelectedValue.ToString() & "','" & CustnameTb.Text & "','" & RentDate.Value.Date & "','" & ReturnDate.Value.Date & "'," & FeesTb.Text & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("car Sucessfully rented")
                con.Close()
                UpdateCar()
                fillregistration()

                clear()
                populate()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ReturnDate_ValueChanged(sender As Object, e As EventArgs) Handles ReturnDate.ValueChanged
        CalculateFees()

    End Sub

    Private Sub RegNumCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles RegNumCb.SelectionChangeCommitted
        GetCarRate()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clear()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim c = New Cars
        c.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim cust = New Customers
        cust.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim ret = New Returns
        ret.Show()
        Me.Hide()
    End Sub
End Class