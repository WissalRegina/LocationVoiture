Imports System
Imports System.Data.SqlClient
Imports System.Data.Common.DbCommand
Public Class Returns
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrateur\Documents\CarRentalVbDb.mdf;Integrated Security=True;Connect Timeout=30
")

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
        rentalsDgv.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub populateReturn()
        con.Open()
        Dim sql = "select * from ReturnTbl"
        Dim cmd = New SqlCommand(sql, con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        returnsDgv.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub CalculateDelay()
        Dim diff As System.TimeSpan = DateTime.Today.Date.Subtract(Convert.ToDateTime(ReturnDate.Text))
        Dim days = diff.TotalDays
        If days < 0 Then
            days = 0
            DelayTb.Text = "no delay"
        Else
            DelayTb.Text = days
        End If
        Dim Fine = days * 500
    End Sub

    Private Sub CalculateFine()

        If DelayTb.Text = "no delay" Then

            FineTb.Text = "no fine"
        Else
            Dim days = Convert.ToInt32(DelayTb.Text)
            Dim Fine = days * 500
            '"Rs" + Convert.ToString(Fine)
            FineTb.Text = Fine
        End If

    End Sub

    Private Sub Returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        populateReturn()


    End Sub
    Dim MyReturn As DateTime
    Dim key = 0
    Private Sub rentalsDgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles rentalsDgv.CellMouseClick
        Dim row As DataGridViewRow = rentalsDgv.Rows(e.RowIndex)
        RegNumTb.Text = row.Cells(1).Value.ToString
        CustName.Text = row.Cells(3).Value.ToString
        ReturnDate.Text = row.Cells(5).Value.ToString


        MyReturn = row.Cells(5).Value
        If RegNumTb.Text = "" Then
            key = 0
        Else
            key = row.Cells(0).Value.ToString
        End If

    End Sub

    Private Sub ReturnDate_TextChanged(sender As Object, e As EventArgs) Handles ReturnDate.TextChanged
        CalculateDelay()

    End Sub

    Private Sub DelayTb_TextChanged(sender As Object, e As EventArgs) Handles DelayTb.TextChanged
        CalculateFine()

    End Sub

    Private Sub clear()
        RegNumTb.Text = ""
        CustName.Text = ""
        ReturnDate.Text = ""
        DelayTb.Text = ""
        FineTb.Text = ""
        key = 0
    End Sub

    Private Sub UpdateCar()
        Dim status = "yes"
        Try
            con.Open()
            Dim query = "update CarTbl set Available='" & status & "'where RegNo='" & key & "'"

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CustName.Text = "" Or DelayTb.Text = "" Then
            MsgBox("Select the car to return ")
        Else
            Dim delay, fine
            If DelayTb.Text = "no delay" Then
                delay = 0
            Else
                delay = DelayTb.Text
            End If
            If FineTb.Text = "no fine" Then
                fine = 0
            Else
                fine = FineTb.Text
            End If

            Try
                con.Open()
                Dim query = "insert into ReturnTbl values('" & RegNumTb.Text & "','" & CustName.Text & "','" & MyReturn & "'," & delay & "," & fine & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("car Sucessfully returned")
                con.Close()
                UpdateCar()
                'fillregistration()

                clear()
                populateReturn()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim cr = New Cars
        cr.Show()
        Me.Hide()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim cust = New Customers
        cust.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim re = New Rent
        re.Show()
        Me.Hide()
    End Sub
End Class