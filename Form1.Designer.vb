<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim PictureBox1 As System.Windows.Forms.PictureBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim PictureBox2 As System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tb_Username = New System.Windows.Forms.TextBox()
        Me.Tb_Password = New System.Windows.Forms.TextBox()
        Me.btn_login_Cashier = New System.Windows.Forms.Button()
        Me.lbl_CaplockIndi = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Admin_Panel = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_capslockindi_admin = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_admin_username = New System.Windows.Forms.TextBox()
        Me.btn_login_admin = New System.Windows.Forms.Button()
        Me.tb_admin_password = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Admin_Panel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        PictureBox1.Location = New System.Drawing.Point(0, 0)
        PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(391, 436)
        PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        PictureBox2.Location = New System.Drawing.Point(0, 0)
        PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New System.Drawing.Size(391, 436)
        PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ObelixPro", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 110)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ObelixPro", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 158)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Tb_Username
        '
        Me.Tb_Username.Location = New System.Drawing.Point(43, 129)
        Me.Tb_Username.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_Username.Name = "Tb_Username"
        Me.Tb_Username.Size = New System.Drawing.Size(221, 22)
        Me.Tb_Username.TabIndex = 2
        '
        'Tb_Password
        '
        Me.Tb_Password.Location = New System.Drawing.Point(43, 177)
        Me.Tb_Password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tb_Password.Name = "Tb_Password"
        Me.Tb_Password.Size = New System.Drawing.Size(221, 22)
        Me.Tb_Password.TabIndex = 3
        '
        'btn_login_Cashier
        '
        Me.btn_login_Cashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_login_Cashier.Font = New System.Drawing.Font("ObelixPro", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login_Cashier.Location = New System.Drawing.Point(100, 317)
        Me.btn_login_Cashier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_login_Cashier.Name = "btn_login_Cashier"
        Me.btn_login_Cashier.Size = New System.Drawing.Size(100, 28)
        Me.btn_login_Cashier.TabIndex = 4
        Me.btn_login_Cashier.Text = "LOGIN"
        Me.btn_login_Cashier.UseVisualStyleBackColor = True
        '
        'lbl_CaplockIndi
        '
        Me.lbl_CaplockIndi.AutoSize = True
        Me.lbl_CaplockIndi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_CaplockIndi.Font = New System.Drawing.Font("ObelixPro", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CaplockIndi.Location = New System.Drawing.Point(39, 246)
        Me.lbl_CaplockIndi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_CaplockIndi.Name = "lbl_CaplockIndi"
        Me.lbl_CaplockIndi.Size = New System.Drawing.Size(64, 18)
        Me.lbl_CaplockIndi.TabIndex = 6
        Me.lbl_CaplockIndi.Text = "Label3"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_CaplockIndi)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Tb_Username)
        Me.Panel1.Controls.Add(Me.btn_login_Cashier)
        Me.Panel1.Controls.Add(Me.Tb_Password)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(30, 135)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(691, 435)
        Me.Panel1.TabIndex = 7
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("ObelixPro", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(192, 401)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 28)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "ADMIN"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("ObelixPro", 18.15652!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(76, 55)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 35)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "LOGIN"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("ObelixPro", 20.03478!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(46, 12)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(187, 39)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Cashier"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(300, -1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(391, 436)
        Me.Panel2.TabIndex = 8
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("ObelixPro", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(43, 209)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(156, 20)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Admin_Panel
        '
        Me.Admin_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Admin_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Admin_Panel.Controls.Add(Me.Label5)
        Me.Admin_Panel.Controls.Add(Me.lbl_capslockindi_admin)
        Me.Admin_Panel.Controls.Add(Me.Button2)
        Me.Admin_Panel.Controls.Add(Me.Panel4)
        Me.Admin_Panel.Controls.Add(Me.CheckBox2)
        Me.Admin_Panel.Controls.Add(Me.Label4)
        Me.Admin_Panel.Controls.Add(Me.Label10)
        Me.Admin_Panel.Controls.Add(Me.Label6)
        Me.Admin_Panel.Controls.Add(Me.tb_admin_username)
        Me.Admin_Panel.Controls.Add(Me.btn_login_admin)
        Me.Admin_Panel.Controls.Add(Me.tb_admin_password)
        Me.Admin_Panel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Admin_Panel.Location = New System.Drawing.Point(30, 135)
        Me.Admin_Panel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Admin_Panel.Name = "Admin_Panel"
        Me.Admin_Panel.Size = New System.Drawing.Size(691, 435)
        Me.Admin_Panel.TabIndex = 11
        Me.Admin_Panel.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("ObelixPro", 18.15652!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(85, 55)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 35)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "LOGIN"
        '
        'lbl_capslockindi_admin
        '
        Me.lbl_capslockindi_admin.AutoSize = True
        Me.lbl_capslockindi_admin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_capslockindi_admin.Font = New System.Drawing.Font("ObelixPro", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_capslockindi_admin.Location = New System.Drawing.Point(39, 246)
        Me.lbl_capslockindi_admin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_capslockindi_admin.Name = "lbl_capslockindi_admin"
        Me.lbl_capslockindi_admin.Size = New System.Drawing.Size(64, 18)
        Me.lbl_capslockindi_admin.TabIndex = 6
        Me.lbl_capslockindi_admin.Text = "Label3"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("ObelixPro", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(192, 401)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "CASHIER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(PictureBox2)
        Me.Panel4.Location = New System.Drawing.Point(300, -1)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(391, 436)
        Me.Panel4.TabIndex = 8
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("ObelixPro", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(43, 209)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(156, 20)
        Me.CheckBox2.TabIndex = 7
        Me.CheckBox2.Text = "Show Password"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("ObelixPro", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 110)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Username"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("ObelixPro", 20.03478!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(75, 12)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 39)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Admin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("ObelixPro", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 158)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Password"
        '
        'tb_admin_username
        '
        Me.tb_admin_username.Location = New System.Drawing.Point(43, 129)
        Me.tb_admin_username.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_admin_username.Name = "tb_admin_username"
        Me.tb_admin_username.Size = New System.Drawing.Size(221, 22)
        Me.tb_admin_username.TabIndex = 2
        '
        'btn_login_admin
        '
        Me.btn_login_admin.Font = New System.Drawing.Font("ObelixPro", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login_admin.Location = New System.Drawing.Point(85, 304)
        Me.btn_login_admin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_login_admin.Name = "btn_login_admin"
        Me.btn_login_admin.Size = New System.Drawing.Size(100, 28)
        Me.btn_login_admin.TabIndex = 4
        Me.btn_login_admin.Text = "LOGIN"
        Me.btn_login_admin.UseVisualStyleBackColor = True
        '
        'tb_admin_password
        '
        Me.tb_admin_password.Location = New System.Drawing.Point(43, 177)
        Me.tb_admin_password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tb_admin_password.Name = "tb_admin_password"
        Me.tb_admin_password.Size = New System.Drawing.Size(221, 22)
        Me.tb_admin_password.TabIndex = 3
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(223, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(321, 104)
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(759, 583)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Admin_Panel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ISCP-LMS"
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Admin_Panel.ResumeLayout(False)
        Me.Admin_Panel.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tb_Username As TextBox
    Friend WithEvents Tb_Password As TextBox
    Friend WithEvents btn_login_Cashier As Button
    Friend WithEvents lbl_CaplockIndi As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Admin_Panel As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_capslockindi_admin As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tb_admin_username As TextBox
    Friend WithEvents btn_login_admin As Button
    Friend WithEvents tb_admin_password As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
