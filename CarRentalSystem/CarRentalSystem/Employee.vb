Imports System
Imports System.Data.SqlClient
Imports System.Data.Common.DbCommand

Public Class Employee
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrateur\Documents\CarRentalVbDb.mdf;Integrated Security=True;Connect Timeout=30
")
    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        If Empp.Text = "" Or password.Text = "" Then
            MsgBox("missing Data")
        Else
            Try
                con.Open()
                Dim query = "insert into EmployeeTbl values('" & Empp.Text & "','" & password.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("employee Sucessfully Saved")

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
        Dim sql = "select * from EmployeeTbl"
        Dim cmd = New SqlCommand(sql, con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        empDgv.DataSource = ds.Tables(0)
        con.Close()

    End Sub
    Private Sub Clear()
        Empp.Text = ""
        password.Text = ""
        key = 0

    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clear()

    End Sub
    Dim key = 0
    Private Sub empDgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles empDgv.CellMouseClick
        Dim row As DataGridViewRow = empDgv.Rows(e.RowIndex)
        Empp.Text = row.Cells(1).Value.ToString
        password.Text = row.Cells(2).Value.ToString

        If Empp.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If key = 0 Then
            MsgBox("select the employee")
        Else
            Try
                con.Open()
                Dim query = "delete from EmployeeTbl where EmpId=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("employee successfully deleted")
                con.Close()
                Clear()
                populate()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Empp.Text = "" Or password.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                con.Open()
                Dim query = "update EmployeeTbl set EmpName='" & Empp.Text & "',EmpPass='" & password.Text & "' where EmpId =" & key & ""

                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("employee successfully updated")
                con.Close()
                Clear()
                populate()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim log = New Login
        log.Show()
        Me.Hide()

    End Sub
End Class