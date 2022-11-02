
Imports System.Data.SqlClient
Imports System.IO
Imports System.Transactions

Public Class product

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\saura\OneDrive\Documents\InventorySysVbDb.mdf;Integrated Security=True;Connect Timeout=30")


    Public Sub populate()
        con.Open()
        Dim sql = "Select * from  Product_Table "
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ProductDGV.DataSource = ds.Tables(0)
        con.Close()

    End Sub

    'ADD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Enter The Product Information")

        Try
            con.Open()
            Dim query As String
            query = "insert into Product_Table (ProductId,ProductName,Quantity,Price,Discription,category) values (" & productid.Text & ",'" & productname.Text & "'," & qty.Text & ",'" & productprice.Text & "','" & productdesc.Text & "','" & productcat.SelectedItem.ToString() & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Product Added Successfully!!!")
            con.Close()
            populate()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FillCategory()
        con.Open()
        Dim sql = "select * from Category_Table"
        Dim cmd As New SqlCommand(sql, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl = New DataTable()
        adapter.Fill(tbl)
        productcat.DataSource = tbl
        productcat.DisplayMember = "CategoryName"
        productcat.ValueMember = "CategoryName"
        con.Close()
    End Sub


    'EDIT/UPDATE

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If productid.Text = "" Or productname.Text = "" Or qty.Text = "" Or productprice.Text = "" Or productdesc.Text = "" Or productcat.Text = "" Then
            MsgBox("Enter Product Name Or Any Data To Update/Edit")
        Else
            con.Open()
            Dim sql = "update Product_Table set ProductName='" & productname.Text & "',Quantity=" & qty.Text & ",Price=" & productprice.Text & ",Discription='" & productdesc.Text & "',category='" & productcat.SelectedItem.ToString() & "' where ProductId = " & productid.Text & ""
            Dim cmd As New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Product Edited Successfully!!!")
            con.Close()
            populate()
            FillCategory()
        End If

    End Sub

    'DELETE

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If productid.Text = "" Then
            MsgBox("Enter The Product You Want To Delete")
        Else
            con.Open()
            Dim query As String
            query = "delete from Product_Table where productid=" & productid.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Product Deleted Successfully!!!")
            con.Close()
            populate()
            FillCategory()
        End If
    End Sub

    'CLEAR

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        productid.Text = ""
        productname.Text = ""
        qty.Text = ""
        productprice.Text = ""
        productdesc.Text = ""
        productcat.Text = ""

    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim home = New Home
        home.Show()
    End Sub
End Class


