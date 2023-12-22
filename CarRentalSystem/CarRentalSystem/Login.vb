Imports System.Data.SqlClient
Public Class Login
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrateur\Documents\CarRentalVbDb.mdf;Integrated Security=True;Connect Timeout=30
")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UnameTb.Text = "" Then
            MsgBox("enter the username")
        ElseIf passwordTb.Text = "" Then
            MsgBox("enter the Password")
        Else
            con.Open()
            Dim query = "select * from EmployeeTbl where EmpName='" & UnameTb.Text & "' and EmpPass='" & passwordTb.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("wrong UserNAme or Password")
            Else
                Dim cr = New Cars
                cr.Show()
                Me.Hide()

            End If
            con.Close()

        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim emp = New Employee
        emp.Show()
        Me.Hide()
    End Sub
End Class