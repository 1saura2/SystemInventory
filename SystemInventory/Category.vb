Imports System.Data.SqlClient

Public Class category
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\saura\OneDrive\Documents\InventorySysVbDb.mdf;Integrated Security=True;Connect Timeout=30")

    Public Sub populate()
        con.Open()
        Dim sql = "Select * from  Category_Table "
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub


    'ADD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con.Open()
            Dim query As String
            query = "insert into Category_Table (CategoryId,CategoryName) values (" & categoryid.Text & ",'" & categoryname.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Category Added Successfully!!!")
            con.Close()
            populate()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'DELETE

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If categoryid.Text = "" Then
            MsgBox("Enter The Category You Want To Delete ")
        Else
            con.Open()
            Dim query As String
            query = "delete from Category_Table where CategoryID = " & categoryid.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Category Deleted Successfully!!!")
            con.Close()
            populate()
        End If
    End Sub

    'CLEAR

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        categoryid.Text = ""
        categoryname.Text = ""
    End Sub

    'EDIT/UPDATE

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If categoryid.Text = "" Or categoryname.Text = "" Then
            MsgBox("Enter Category To Update")
        Else
            con.Open()
            Dim sql = "update Category_Table set CategoryName='" & categoryname.Text & "' where CategoryId = " & categoryid.Text & ""
            Dim cmd As New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Peoduct Edited Successfully!!!")
            con.Close()
            populate()

        End If
    End Sub

    Private Sub CatHomeBtn_Click(sender As Object, e As EventArgs) Handles CatHomeBtn.Click
        Me.Hide()
        Dim home = New Home
        home.Show()
    End Sub
End Class