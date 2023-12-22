Imports System
Imports System.Data.SqlClient
Imports System.Data.Common.DbCommand

Public Class Customers
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrateur\Documents\CarRentalVbDb.mdf;Integrated Security=True;Connect Timeout=30
")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CustPhoneTb.Text = "" Or CustAdressTb.Text = "" Or CustNameTb.Text = "" Then
            MsgBox("missing Data")
        Else
            Try
                con.Open()
                Dim query = "insert into CustomerTbl values('" & CustNameTb.Text & "','" & CustAdressTb.Text & "','" & CustPhoneTb.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("customer Sucessfully Saved")

                con.Close()
                Clear()
                populate()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub populate()

        con.Open()
        Dim sql = "select * from CustomerTbl"
        Dim cmd = New SqlCommand(sql, con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        CustumorDgv.DataSource = ds.Tables(0)
        con.Close()

    End Sub

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()

    End Sub

    Private Sub Clear()
        CustAdressTb.Text = ""
        CustNameTb.Text = ""
        CustPhoneTb.Text = ""
        key = 0
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        Clear()

    End Sub
    Dim key = 0
    Private Sub CustumorDgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CustumorDgv.CellMouseClick
        Dim row As DataGridViewRow = CustumorDgv.Rows(e.RowIndex)
        CustNameTb.Text = row.Cells(1).Value.ToString
        CustAdressTb.Text = row.Cells(2).Value.ToString
        CustPhoneTb.Text = row.Cells(3).Value.ToString
        If CustNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        If key = 0 Then
            MsgBox("select the customer")
        Else
            Try
                con.Open()
                Dim query = "delete from CustomerTbl where CustId=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("customer successfully deleted")
                con.Close()
                Clear()
                populate()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub edit_btn_Click(sender As Object, e As EventArgs) Handles edit_btn.Click
        If CustNameTb.Text = "" Or CustAdressTb.Text = "" Or CustPhoneTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                con.Open()
                Dim query = "update CustomerTbl set CustName='" & CustNameTb.Text & "',CustAdd='" & CustAdressTb.Text &
                    "',CustPhone='" & CustPhoneTb.Text & "' where CustId =" & key & ""

                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("customer successfully updated")
                con.Close()
                Clear()
                populate()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim c = New Cars
        c.Show()
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