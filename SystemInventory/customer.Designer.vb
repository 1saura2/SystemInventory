<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class customer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.custid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.custname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.custphone = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CustomerDGV = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CustHomeBtn = New System.Windows.Forms.Button()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OrderCountLbl = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MaxOrderLbl = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel3 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CustCountLbl = New System.Windows.Forms.Label()
        CType(Me.CustomerDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2GradientPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(150, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CustomerId"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(382, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Customer Management"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(314, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Inventory Management System"
        '
        'custid
        '
        Me.custid.Location = New System.Drawing.Point(247, 117)
        Me.custid.Name = "custid"
        Me.custid.Size = New System.Drawing.Size(61, 23)
        Me.custid.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(314, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Customer Name"
        '
        'custname
        '
        Me.custname.Location = New System.Drawing.Point(443, 117)
        Me.custname.Name = "custname"
        Me.custname.Size = New System.Drawing.Size(100, 23)
        Me.custname.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(549, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Phone"
        '
        'custphone
        '
        Me.custphone.Location = New System.Drawing.Point(608, 117)
        Me.custphone.Name = "custphone"
        Me.custphone.Size = New System.Drawing.Size(100, 23)
        Me.custphone.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkViolet
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(230, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 35)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkViolet
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(566, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 35)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkViolet
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(454, 178)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 35)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkViolet
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(342, 178)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(106, 35)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Edit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'CustomerDGV
        '
        Me.CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDGV.Location = New System.Drawing.Point(73, 410)
        Me.CustomerDGV.Name = "CustomerDGV"
        Me.CustomerDGV.RowTemplate.Height = 25
        Me.CustomerDGV.Size = New System.Drawing.Size(675, 153)
        Me.CustomerDGV.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(370, 387)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Customer List"
        '
        'CustHomeBtn
        '
        Me.CustHomeBtn.BackColor = System.Drawing.Color.DarkViolet
        Me.CustHomeBtn.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CustHomeBtn.ForeColor = System.Drawing.Color.White
        Me.CustHomeBtn.Location = New System.Drawing.Point(382, 569)
        Me.CustHomeBtn.Name = "CustHomeBtn"
        Me.CustHomeBtn.Size = New System.Drawing.Size(106, 35)
        Me.CustHomeBtn.TabIndex = 23
        Me.CustHomeBtn.Text = "Home"
        Me.CustHomeBtn.UseVisualStyleBackColor = False
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Controls.Add(Me.Label7)
        Me.Guna2GradientPanel2.Controls.Add(Me.OrderCountLbl)
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.SlateGray
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(118, 258)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(166, 100)
        Me.Guna2GradientPanel2.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.SlateGray
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(39, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 17)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Order Count"
        '
        'OrderCountLbl
        '
        Me.OrderCountLbl.AutoSize = True
        Me.OrderCountLbl.BackColor = System.Drawing.Color.SlateGray
        Me.OrderCountLbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.OrderCountLbl.ForeColor = System.Drawing.Color.White
        Me.OrderCountLbl.Location = New System.Drawing.Point(39, 49)
        Me.OrderCountLbl.Name = "OrderCountLbl"
        Me.OrderCountLbl.Size = New System.Drawing.Size(67, 20)
        Me.OrderCountLbl.TabIndex = 29
        Me.OrderCountLbl.Text = "Number"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Label8)
        Me.Guna2GradientPanel1.Controls.Add(Me.MaxOrderLbl)
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.SlateGray
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(312, 258)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(166, 100)
        Me.Guna2GradientPanel1.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.SlateGray
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(27, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 17)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Maximum Order"
        '
        'MaxOrderLbl
        '
        Me.MaxOrderLbl.AutoSize = True
        Me.MaxOrderLbl.BackColor = System.Drawing.Color.SlateGray
        Me.MaxOrderLbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MaxOrderLbl.ForeColor = System.Drawing.Color.White
        Me.MaxOrderLbl.Location = New System.Drawing.Point(41, 56)
        Me.MaxOrderLbl.Name = "MaxOrderLbl"
        Me.MaxOrderLbl.Size = New System.Drawing.Size(75, 20)
        Me.MaxOrderLbl.TabIndex = 31
        Me.MaxOrderLbl.Text = "Maximun"
        '
        'Guna2GradientPanel3
        '
        Me.Guna2GradientPanel3.Controls.Add(Me.Label10)
        Me.Guna2GradientPanel3.Controls.Add(Me.CustCountLbl)
        Me.Guna2GradientPanel3.FillColor = System.Drawing.Color.SlateGray
        Me.Guna2GradientPanel3.Location = New System.Drawing.Point(505, 258)
        Me.Guna2GradientPanel3.Name = "Guna2GradientPanel3"
        Me.Guna2GradientPanel3.Size = New System.Drawing.Size(166, 100)
        Me.Guna2GradientPanel3.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.SlateGray
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(27, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 17)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Customers Count"
        '
        'CustCountLbl
        '
        Me.CustCountLbl.AutoSize = True
        Me.CustCountLbl.BackColor = System.Drawing.Color.SlateGray
        Me.CustCountLbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CustCountLbl.ForeColor = System.Drawing.Color.White
        Me.CustCountLbl.Location = New System.Drawing.Point(44, 49)
        Me.CustCountLbl.Name = "CustCountLbl"
        Me.CustCountLbl.Size = New System.Drawing.Size(67, 20)
        Me.CustCountLbl.TabIndex = 28
        Me.CustCountLbl.Text = "Number"
        '
        'customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(875, 616)
        Me.Controls.Add(Me.Guna2GradientPanel3)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.CustHomeBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CustomerDGV)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.custphone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.custname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.custid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.CustomerDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.Guna2GradientPanel3.ResumeLayout(False)
        Me.Guna2GradientPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents custid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents custname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents custphone As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents CustomerDGV As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents CustHomeBtn As Button
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel3 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents CustCountLbl As Label
    Friend WithEvents OrderCountLbl As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MaxOrderLbl As Label
End Class
