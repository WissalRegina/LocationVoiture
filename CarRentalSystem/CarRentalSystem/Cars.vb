Imports System
Imports System.Data.SqlClient
Imports System.Data.Common.DbCommand

Public Class Cars
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrateur\Documents\CarRentalVbDb.mdf;Integrated Security=True;Connect Timeout=30
")
    'Public Property Uname As String
    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        Try
            con.Open()
            Dim query = "insert into CarTbl values('" & RegNumTb.Text & "','" & BrandCb.SelectedItem.ToString() & "','" & ModelTb.Text & "'," & PriceTb.Text & ",'" & ColorTb.Text & "','" & Availablecb.SelectedItem.ToString() & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("car Sucessfully Saved")

            con.Close()
            Clear()
            populate()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Clear()
        RegNumTb.Text = ""
        BrandCb.SelectedIndex = -1
        ModelTb.Text = ""
        PriceTb.Text = ""
        ColorTb.Text = ""
        Availablecb.SelectedIndex = -1
        key = 0

    End Sub

    Private Sub populate()

        con.Open()
        Dim sql = "select * from CarTbl"
        Dim cmd = New SqlCommand(sql, con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        CarDgv.DataSource = ds.Tables(0)
        con.Close()

    End Sub

    Private Sub Guna2DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CarDgv.CellMouseClick
        Dim row As DataGridViewRow = CarDgv.Rows(e.RowIndex)
        RegNumTb.Text = row.Cells(1).Value.ToString
        BrandCb.SelectedItem = row.Cells(2).Value.ToString
        ModelTb.Text = row.Cells(3).Value.ToString
        PriceTb.Text = row.Cells(4).Value.ToString
        ColorTb.Text = row.Cells(5).Value.ToString
        Availablecb.SelectedItem = row.Cells(6).Value.ToString
        If RegNumTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clear()
    End Sub

    Private Sub Cars_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        populate()
    End Sub
    Dim key = 0
    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        If key = 0 Then
            MsgBox("select the car")
        Else
            Try
                con.Open()
                Dim query = "delete from CarTbl where CId=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("car successfully deleted")
                con.Close()
                Clear()
                populate()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub edit_btn_Click(sender As Object, e As EventArgs) Handles edit_btn.Click
        If RegNumTb.Text = "" Or BrandCb.SelectedIndex = -1 Or ModelTb.Text = "" Or PriceTb.Text = "" Or ColorTb.Text = "" Or Availablecb.SelectedIndex = -1 Then
            MsgBox("Missing Information")
        Else
            Try
                con.Open()
                Dim query = "update CarTbl set RegNo='" & RegNumTb.Text & "',Brand='" & BrandCb.SelectedItem.ToString() & "',Model='" & ModelTb.Text & "',Price=" & PriceTb.Text & ",Color='" & ColorTb.Text & "',Available='" & Availablecb.SelectedItem.ToString() & "' where CId =" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("car successfully updated")
                con.Close()
                Clear()
                populate()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim ret = New Returns
        ret.Show()
        Me.Hide()
    End Sub
End Class