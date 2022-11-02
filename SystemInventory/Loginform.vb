Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader

Public Class loginform
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\saura\OneDrive\Documents\InventorySysVbDb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim sql As String = ""
            sql = "select * from User_Table where UserName='" & useridbox.Text & "' and UserPassword='" & passwordbox.Text & "'"
            con.Open()

            Dim da As New SqlDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Home.Show()
                Me.Close()
            Else
                MsgBox("invalid user or password")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        useridbox.Text = ""
        passwordbox.Text = ""
    End Sub

    Private Sub Ctrl_KeyUp(sender As Object, e As KeyEventArgs) Handles useridbox.KeyUp, passwordbox.KeyUp, Button2.KeyUp, Button1.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(sender, True, True, True, False)
        End If
    End Sub

    Private Sub showhide_Click(sender As Object, e As EventArgs) Handles showhide.Click
        If passwordbox.UseSystemPasswordChar = True Then

            passwordbox.UseSystemPasswordChar = False

        Else
            passwordbox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub passwordbox_TextChanged(sender As Object, e As EventArgs) Handles passwordbox.TextChanged

    End Sub
End Class

