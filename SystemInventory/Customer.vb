Imports System.Data.SqlClient


Public Class customer

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\saura\OneDrive\Documents\InventorySysVbDb.mdf;Integrated Security=True;Connect Timeout=30")

    Public Sub populate()
        con.Open()
        Dim sql = "Select * from Customer_Table "
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        CustomerDGV .DataSource = ds.Tables(0)
        con.Close()

    End Sub

    'ADD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Customer Information Is Added")

        Try
            con.Open()
            Dim query As String
            query = "insert into Customer_Table(CustomerId,CustomerName,CustomerPhone) values (" & custid.Text & ",'" & custname.Text & "'," & custphone.Text & ")"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Customer Added Successfully!!!")
            con.Close()
            populate()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'EDIT/UPDATE

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If custid.Text = "" Or custname.Text = "" Or custphone.Text = "" Then
            MsgBox("Enter Customer Name Or Any Data To Update/Edit")
        Else
            con.Open()
            Dim sql = "update Customer_Table set CustomerName = '" & custname.Text & "',CustomerPhone = " & custphone.Text & " where CustomerId = " & custid.Text & ""
            Dim cmd As New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Customer Edited Successfully!!!")
            con.Close()
            populate()
        End If
    End Sub

    'DELETE

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If custid.Text = "" Then
            MsgBox("Enter The Customer Information You Want To Delete")
        Else
            con.Open()
            Dim query As String
            query = "delete from Customer_Table where CustomerId = " & custid.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Customer Information  Deleted Successfully!!!")
            con.Close()
            populate()
        End If
    End Sub

    'clear

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        custid.Text = ""
        custname.Text = ""
        custphone.Text = ""
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles CustCountLbl.Click

    End Sub

    Private Sub customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        Dim query = "Select Count(*) from Customer_Table"
        Dim query1 = "Select Count(*) from Order_Table"
        Dim query2 = "Select Max(TotalAmount) from Order_Table"
        Dim cmd As SqlCommand
        Dim cmd1 As SqlCommand
        Dim cmd2 As SqlCommand

        con.Open()

        cmd = New SqlCommand(query, con)
        Dim count As Int16 = Convert.ToInt16(cmd.ExecuteScalar())
        CustCountLbl.Text = count.ToString()

        cmd1 = New SqlCommand(query1, con)
        Dim count1 As Int16 = Convert.ToInt16(cmd1.ExecuteScalar())
        OrderCountLbl.Text = count1.ToString()

        cmd2 = New SqlCommand(query2, con)
        Dim count2 As Integer = Convert.ToInt64(cmd2.ExecuteScalar())
        MaxOrderLbl.Text = count2.ToString()
        con.Close()
    End Sub

    Private Sub Guna2GradientPanel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel2.Paint

    End Sub

    Private Sub CustHomeBtn_Click(sender As Object, e As EventArgs) Handles CustHomeBtn.Click
        Me.Hide()
        Dim home = New Home
        home.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub MaxOrderLbl_Click(sender As Object, e As EventArgs) Handles MaxOrderLbl.Click

    End Sub
End Class