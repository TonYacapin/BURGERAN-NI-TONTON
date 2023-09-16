<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_ADMINLOGOUT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_ADMINLOGOUT
        '
        Me.btn_ADMINLOGOUT.Location = New System.Drawing.Point(940, 15)
        Me.btn_ADMINLOGOUT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_ADMINLOGOUT.Name = "btn_ADMINLOGOUT"
        Me.btn_ADMINLOGOUT.Size = New System.Drawing.Size(111, 47)
        Me.btn_ADMINLOGOUT.TabIndex = 0
        Me.btn_ADMINLOGOUT.Text = "LOGOUT"
        Me.btn_ADMINLOGOUT.UseVisualStyleBackColor = True
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btn_ADMINLOGOUT)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_ADMINLOGOUT As Button
End Class
