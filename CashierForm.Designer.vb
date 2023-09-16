<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CashierForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CashierForm))
        Me.BTN_ALLITEMS = New System.Windows.Forms.Button()
        Me.BTN_FOOD = New System.Windows.Forms.Button()
        Me.BTN_DRINKS = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_DESSERT = New System.Windows.Forms.Button()
        Me.btn_CASHIERLOGOUT = New System.Windows.Forms.Button()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.Panel_ALLITEMS = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.panel_FOOD = New System.Windows.Forms.Panel()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Panel_DRINKS = New System.Windows.Forms.Panel()
        Me.Button39 = New System.Windows.Forms.Button()
        Me.Button38 = New System.Windows.Forms.Button()
        Me.Button37 = New System.Windows.Forms.Button()
        Me.panel_DESSERT = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UserActivity = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_ALLITEMS.SuspendLayout()
        Me.panel_FOOD.SuspendLayout()
        Me.Panel_DRINKS.SuspendLayout()
        Me.panel_DESSERT.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_ALLITEMS
        '
        Me.BTN_ALLITEMS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTN_ALLITEMS.BackgroundImage = CType(resources.GetObject("BTN_ALLITEMS.BackgroundImage"), System.Drawing.Image)
        Me.BTN_ALLITEMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_ALLITEMS.Location = New System.Drawing.Point(35, 156)
        Me.BTN_ALLITEMS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_ALLITEMS.Name = "BTN_ALLITEMS"
        Me.BTN_ALLITEMS.Size = New System.Drawing.Size(168, 85)
        Me.BTN_ALLITEMS.TabIndex = 1
        Me.BTN_ALLITEMS.UseVisualStyleBackColor = False
        '
        'BTN_FOOD
        '
        Me.BTN_FOOD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTN_FOOD.BackgroundImage = CType(resources.GetObject("BTN_FOOD.BackgroundImage"), System.Drawing.Image)
        Me.BTN_FOOD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_FOOD.Location = New System.Drawing.Point(35, 249)
        Me.BTN_FOOD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_FOOD.Name = "BTN_FOOD"
        Me.BTN_FOOD.Size = New System.Drawing.Size(168, 85)
        Me.BTN_FOOD.TabIndex = 2
        Me.BTN_FOOD.UseVisualStyleBackColor = False
        '
        'BTN_DRINKS
        '
        Me.BTN_DRINKS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTN_DRINKS.BackgroundImage = CType(resources.GetObject("BTN_DRINKS.BackgroundImage"), System.Drawing.Image)
        Me.BTN_DRINKS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_DRINKS.Location = New System.Drawing.Point(35, 342)
        Me.BTN_DRINKS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_DRINKS.Name = "BTN_DRINKS"
        Me.BTN_DRINKS.Size = New System.Drawing.Size(168, 85)
        Me.BTN_DRINKS.TabIndex = 3
        Me.BTN_DRINKS.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ObelixPro", 18.15652!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(491, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 35)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "MENU"
        '
        'BTN_DESSERT
        '
        Me.BTN_DESSERT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTN_DESSERT.BackgroundImage = CType(resources.GetObject("BTN_DESSERT.BackgroundImage"), System.Drawing.Image)
        Me.BTN_DESSERT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTN_DESSERT.Location = New System.Drawing.Point(35, 433)
        Me.BTN_DESSERT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_DESSERT.Name = "BTN_DESSERT"
        Me.BTN_DESSERT.Size = New System.Drawing.Size(168, 85)
        Me.BTN_DESSERT.TabIndex = 5
        Me.BTN_DESSERT.UseVisualStyleBackColor = False
        '
        'btn_CASHIERLOGOUT
        '
        Me.btn_CASHIERLOGOUT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_CASHIERLOGOUT.Font = New System.Drawing.Font("ObelixPro", 8.139131!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CASHIERLOGOUT.Location = New System.Drawing.Point(940, 15)
        Me.btn_CASHIERLOGOUT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_CASHIERLOGOUT.Name = "btn_CASHIERLOGOUT"
        Me.btn_CASHIERLOGOUT.Size = New System.Drawing.Size(111, 47)
        Me.btn_CASHIERLOGOUT.TabIndex = 6
        Me.btn_CASHIERLOGOUT.Text = "LOGOUT"
        Me.btn_CASHIERLOGOUT.UseVisualStyleBackColor = False
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("ObelixPro", 10.01739!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(285, 43)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(73, 19)
        Me.lbl_user.TabIndex = 7
        Me.lbl_user.Text = "Label3"
        '
        'Panel_ALLITEMS
        '
        Me.Panel_ALLITEMS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel_ALLITEMS.Controls.Add(Me.Button10)
        Me.Panel_ALLITEMS.Controls.Add(Me.Button11)
        Me.Panel_ALLITEMS.Controls.Add(Me.Button12)
        Me.Panel_ALLITEMS.Controls.Add(Me.Button8)
        Me.Panel_ALLITEMS.Controls.Add(Me.Button9)
        Me.Panel_ALLITEMS.Controls.Add(Me.Button6)
        Me.Panel_ALLITEMS.Controls.Add(Me.Button5)
        Me.Panel_ALLITEMS.Controls.Add(Me.Button3)
        Me.Panel_ALLITEMS.Location = New System.Drawing.Point(260, 156)
        Me.Panel_ALLITEMS.Name = "Panel_ALLITEMS"
        Me.Panel_ALLITEMS.Size = New System.Drawing.Size(552, 362)
        Me.Panel_ALLITEMS.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(13, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(134, 86)
        Me.Button3.TabIndex = 0
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Location = New System.Drawing.Point(206, 14)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(134, 86)
        Me.Button5.TabIndex = 1
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.Location = New System.Drawing.Point(391, 14)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(134, 86)
        Me.Button6.TabIndex = 2
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Location = New System.Drawing.Point(125, 123)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(134, 86)
        Me.Button9.TabIndex = 3
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Location = New System.Drawing.Point(299, 123)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(134, 86)
        Me.Button8.TabIndex = 4
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.BackgroundImage = CType(resources.GetObject("Button12.BackgroundImage"), System.Drawing.Image)
        Me.Button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button12.Location = New System.Drawing.Point(29, 243)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(134, 86)
        Me.Button12.TabIndex = 6
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button11.Location = New System.Drawing.Point(207, 243)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(134, 86)
        Me.Button11.TabIndex = 7
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.Location = New System.Drawing.Point(391, 243)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(134, 86)
        Me.Button10.TabIndex = 8
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.BackgroundImage = CType(resources.GetObject("Button21.BackgroundImage"), System.Drawing.Image)
        Me.Button21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button21.Location = New System.Drawing.Point(29, 31)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(134, 86)
        Me.Button21.TabIndex = 0
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.BackgroundImage = CType(resources.GetObject("Button20.BackgroundImage"), System.Drawing.Image)
        Me.Button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button20.Location = New System.Drawing.Point(207, 31)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(134, 86)
        Me.Button20.TabIndex = 1
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.BackgroundImage = CType(resources.GetObject("Button19.BackgroundImage"), System.Drawing.Image)
        Me.Button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button19.Location = New System.Drawing.Point(391, 31)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(134, 86)
        Me.Button19.TabIndex = 2
        Me.Button19.UseVisualStyleBackColor = True
        '
        'panel_FOOD
        '
        Me.panel_FOOD.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panel_FOOD.Controls.Add(Me.Button19)
        Me.panel_FOOD.Controls.Add(Me.Button20)
        Me.panel_FOOD.Controls.Add(Me.Button21)
        Me.panel_FOOD.Location = New System.Drawing.Point(259, 156)
        Me.panel_FOOD.Name = "panel_FOOD"
        Me.panel_FOOD.Size = New System.Drawing.Size(552, 362)
        Me.panel_FOOD.TabIndex = 9
        '
        'Button30
        '
        Me.Button30.BackgroundImage = CType(resources.GetObject("Button30.BackgroundImage"), System.Drawing.Image)
        Me.Button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button30.Location = New System.Drawing.Point(126, 31)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(134, 86)
        Me.Button30.TabIndex = 0
        Me.Button30.UseVisualStyleBackColor = True
        '
        'Button29
        '
        Me.Button29.BackgroundImage = CType(resources.GetObject("Button29.BackgroundImage"), System.Drawing.Image)
        Me.Button29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button29.Location = New System.Drawing.Point(300, 31)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(134, 86)
        Me.Button29.TabIndex = 1
        Me.Button29.UseVisualStyleBackColor = True
        '
        'Panel_DRINKS
        '
        Me.Panel_DRINKS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel_DRINKS.Controls.Add(Me.Button29)
        Me.Panel_DRINKS.Controls.Add(Me.Button30)
        Me.Panel_DRINKS.Location = New System.Drawing.Point(259, 156)
        Me.Panel_DRINKS.Name = "Panel_DRINKS"
        Me.Panel_DRINKS.Size = New System.Drawing.Size(552, 362)
        Me.Panel_DRINKS.TabIndex = 10
        '
        'Button39
        '
        Me.Button39.BackgroundImage = CType(resources.GetObject("Button39.BackgroundImage"), System.Drawing.Image)
        Me.Button39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button39.Location = New System.Drawing.Point(29, 31)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(134, 86)
        Me.Button39.TabIndex = 0
        Me.Button39.UseVisualStyleBackColor = True
        '
        'Button38
        '
        Me.Button38.BackgroundImage = CType(resources.GetObject("Button38.BackgroundImage"), System.Drawing.Image)
        Me.Button38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button38.Location = New System.Drawing.Point(207, 31)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(134, 86)
        Me.Button38.TabIndex = 1
        Me.Button38.UseVisualStyleBackColor = True
        '
        'Button37
        '
        Me.Button37.BackgroundImage = CType(resources.GetObject("Button37.BackgroundImage"), System.Drawing.Image)
        Me.Button37.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button37.Location = New System.Drawing.Point(391, 31)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(134, 86)
        Me.Button37.TabIndex = 2
        Me.Button37.UseVisualStyleBackColor = True
        '
        'panel_DESSERT
        '
        Me.panel_DESSERT.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panel_DESSERT.Controls.Add(Me.Button37)
        Me.panel_DESSERT.Controls.Add(Me.Button38)
        Me.panel_DESSERT.Controls.Add(Me.Button39)
        Me.panel_DESSERT.Location = New System.Drawing.Point(259, 156)
        Me.panel_DESSERT.Name = "panel_DESSERT"
        Me.panel_DESSERT.Size = New System.Drawing.Size(552, 362)
        Me.panel_DESSERT.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(41, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 76)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 540)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1085, 26)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'UserActivity
        '
        Me.UserActivity.Interval = 60000
        '
        'CashierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1085, 566)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_user)
        Me.Controls.Add(Me.btn_CASHIERLOGOUT)
        Me.Controls.Add(Me.BTN_DESSERT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_DRINKS)
        Me.Controls.Add(Me.BTN_FOOD)
        Me.Controls.Add(Me.BTN_ALLITEMS)
        Me.Controls.Add(Me.panel_FOOD)
        Me.Controls.Add(Me.Panel_ALLITEMS)
        Me.Controls.Add(Me.panel_DESSERT)
        Me.Controls.Add(Me.Panel_DRINKS)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CashierForm"
        Me.Text = "CashierForm"
        Me.Panel_ALLITEMS.ResumeLayout(False)
        Me.panel_FOOD.ResumeLayout(False)
        Me.Panel_DRINKS.ResumeLayout(False)
        Me.panel_DESSERT.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_ALLITEMS As Button
    Friend WithEvents BTN_FOOD As Button
    Friend WithEvents BTN_DRINKS As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_DESSERT As Button
    Friend WithEvents btn_CASHIERLOGOUT As Button
    Friend WithEvents lbl_user As Label
    Friend WithEvents Panel_ALLITEMS As Panel
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents panel_FOOD As Panel
    Friend WithEvents Button30 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents Panel_DRINKS As Panel
    Friend WithEvents Button39 As Button
    Friend WithEvents Button38 As Button
    Friend WithEvents Button37 As Button
    Friend WithEvents panel_DESSERT As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents UserActivity As Timer
End Class
