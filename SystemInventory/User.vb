Imports System.Data.SqlClient

Public Class user
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\saura\OneDrive\Documents\InventorySysVbDb.mdf;Integrated Security=True;Connect Timeout=30")


    Public Sub populate()
        con.Open()
        Dim sql = "Select * from  User_Table "
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        UserDGV.DataSource = ds.Tables(0)
        con.Close()

    End Sub

    'ADD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox("User Information Has been Entered")

        Try
            con.Open()
            Dim query As String
            query = "insert into User_Table (UserId,UserName,UserPassword,UserPhone) values (" & userid.Text & ",'" & username.Text & "','" & userpassword.Text & "'," & userphone.Text & ")"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("User Added Successfully!!!")
            con.Close()
            populate()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'EDIT/UPDATE

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If userid.Text = "" Or username.Text = "" Or userpassword.Text = "" Or userphone.Text = "" Then
            MsgBox("Enter User Name Or Any Data To Update/Edit")
        Else
            con.Open()
            Dim sql = "update User_Table set UserName = '" & username.Text & "',UserPassword = '" & userpassword.Text & "',UserPhone=" & userphone.Text & " where UserId = " & userid.Text & " "
            Dim cmd As New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("User List Edited Successfully!!!")
            con.Close()
            populate()
        End If

    End Sub

    'DELETE

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If userid.Text = "" Then
            MsgBox("Enter The User You Want To Delete")
        Else
            con.Open()
            Dim query As String
            query = "delete from User_Table where Userid=" & userid.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("User Deleted Successfully!!!")
            con.Close()
            populate()
        End If
    End Sub

    'CLEAR

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        username.Text = ""
        userpassword.Text = ""
        userphone.Text = ""
    End Sub

    Private Sub UseHmBtn_Click(sender As Object, e As EventArgs) Handles UseHmBtn.Click
        Me.Hide()
        Dim home = New Home
        home.Show()
    End Sub


End Class
