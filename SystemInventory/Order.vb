Imports System.Data.SqlClient
Public Class Order
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\saura\OneDrive\Documents\InventorySysVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Fillproduct()
        con.Open()
        Dim sql = "select * from Product_Table"
        Dim cmd As New SqlCommand(sql, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl = New DataTable()
        adapter.Fill(tbl)
        ProductIdCb.DataSource = tbl
        ProductIdCb.DisplayMember = "productId"
        ProductIdCb.ValueMember = "productId"
        con.Close()
    End Sub

    Private Sub FillCustomer()
        con.Open()
        Dim sql = "select * from Customer_Table"
        Dim cmd As New SqlCommand(sql, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim tbl = New DataTable()
        adapter.Fill(tbl)
        CustomerIdCb.DataSource = tbl
        CustomerIdCb.DisplayMember = "CustomereId"
        CustomerIdCb.ValueMember = "CustomerId"
        con.Close()
    End Sub

    Private Sub FetchName()
        con.Open()
        Dim query = "select * from Customer_Table where CustomerId = " & CustomerIdCb.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(query, con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            CustomerNameTb.Text = reader(1).ToString()
        End While
        con.Close()
    End Sub

    Dim prodname As String
    Dim prodprice As Integer
    Dim Availprodqty As Integer

    Private Sub DataFetch()
        con.Open()
        Dim query = "select * from Product_Table where ProductId = " & ProductIdCb.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(query, con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            'CustomerNameTb.Text = reader(1).ToString()
            prodname = reader(1).ToString()
            prodprice = Convert.ToUInt32(reader(3).ToString())
            Availprodqty = Convert.ToUInt32(reader(2).ToString())
            ProductNameTb.Text = prodname
        End While
        con.Close()
    End Sub



    Private Sub Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fillproduct()
        FillCustomer()
        populate()
    End Sub

    Private Sub CustomerIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CustomerIdCb.SelectionChangeCommitted
        FetchName()
    End Sub

    Private Sub ProductNameCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ProductIdCb.SelectionChangeCommitted
        DataFetch()
    End Sub
    Dim NewQty
    Private Sub UpdateProd()
        NewQty = Availprodqty - Convert.ToUInt32(QtyTb.Text)

        con.Open()
        Dim sql = "update Product_Table set Quantity=" & NewQty & " where ProductId = " & ProductIdCb.SelectedItem.ToString() & ""
        Dim cmd As New SqlCommand(sql, con)
        cmd.ExecuteNonQuery()

        con.Close()
        'populate()

    End Sub

    Dim Grtot = 0, i = 0, Total = 0

    Public Sub populate()
        con.Open()
        Dim sql = "Select * from  Order_Table "
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(sql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        OrderDGV.DataSource = ds.Tables(0)
        con.Close()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("*******IVRNSYS*******", New Font("Century Gothic", 25), Brushes.BlueViolet, 250, 40)
        e.Graphics.DrawString("*******YOUR ORDER*********", New Font("Century Gothic", 15), Brushes.BlueViolet, 250, 80)
        Dim bm As New Bitmap(Me.BillDGV.Width, Me.BillDGV.Height)
        BillDGV.DrawToBitmap(bm, New Rectangle(0, 0, Me.BillDGV.Width, Me.BillDGV.Height))
        e.Graphics.DrawImage(bm, 110, 130)
        e.Graphics.DrawString("*****SERVER MONKS****", New Font("Century Gothic", 16), Brushes.DarkViolet, 250, 450)
        InsertOrder()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        If CustomerNameTb.Text = "" Then
            MsgBox("Select Customer Name")
        Else
            Try
                con.Open()
                Dim query As String
                query = "insert into Order_Table (OrderId,custId,CustName,TotalAmount) values (" & OrderId.Text & "," & CustomerIdCb.SelectedValue.ToString() & ",'" & CustomerNameTb.Text & "'," & Amtbill.Text & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Order Added Successfully!!!")
                con.Close()
                populate()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        Try
            con.Open()
            Dim query As String
            query = "insert into Order_Table (OrderId,custId,CustName,TotalAmount) values (" & OrderId.Text & "," & CustomerIdCb.SelectedValue.ToString() & ",'" & CustomerNameTb.Text & "'," & Amtbill.Text & ")"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Order Added Successfully!!!")
            con.Close()
            populate()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles OrderButton.Click
        Me.Hide()
        Dim home = New Home
        home.Show()
    End Sub

    Private Sub Amtbill_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub



    Private Sub InsertOrder()
        If CustomerNameTb.Text = "" Then
            MsgBox("Select Customer Name")
        Else
            Try
                con.Open()
                Dim query As String
                query = "insert into Order_Table (OrderId,custId,CustName,TotalAmount) values (" & OrderId.Text & "," & CustomerIdCb.SelectedValue.ToString() & ",'" & CustomerNameTb.Text & "'," & Amtbill.Text & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Order Added Successfully!!!")
                con.Close()
                populate()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If QtyTb.Text = "" Then
            MsgBox("Enter The Product Quantity")
        Else
            Dim rnum As Integer = BillDGV.Rows.Add()
            i = i + 1
            Total = prodprice * Convert.ToInt32(QtyTb.Text)
            BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillDGV.Rows.Item(rnum).Cells("column2").Value = ProductNameTb.Text
            BillDGV.Rows.Item(rnum).Cells("column3").Value = prodprice
            BillDGV.Rows.Item(rnum).Cells("column4").Value = QtyTb.Text
            BillDGV.Rows.Item(rnum).Cells("column5").Value = Total
            Grtot = Grtot + Total
            Amtbill.Text = Grtot
        End If
    End Sub
End Class