<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.CheckBoxPass = New System.Windows.Forms.CheckBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Humnst777 Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(446, 225)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Humnst777 Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(446, 279)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'TxtUsername
        '
        Me.TxtUsername.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtUsername.Font = New System.Drawing.Font("Humnst777 Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.Location = New System.Drawing.Point(590, 225)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(390, 31)
        Me.TxtUsername.TabIndex = 2
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtPassword.Font = New System.Drawing.Font("Humnst777 Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(590, 281)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(390, 31)
        Me.TxtPassword.TabIndex = 3
        '
        'CheckBoxPass
        '
        Me.CheckBoxPass.AutoSize = True
        Me.CheckBoxPass.Font = New System.Drawing.Font("Humnst777 Lt BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxPass.Location = New System.Drawing.Point(590, 337)
        Me.CheckBoxPass.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxPass.Name = "CheckBoxPass"
        Me.CheckBoxPass.Size = New System.Drawing.Size(138, 24)
        Me.CheckBoxPass.TabIndex = 4
        Me.CheckBoxPass.Text = "Lihat Password"
        Me.CheckBoxPass.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.PeachPuff
        Me.btnlogin.Font = New System.Drawing.Font("Humnst777 Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(590, 388)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(390, 37)
        Me.btnlogin.TabIndex = 5
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.PeachPuff
        Me.btncancel.Font = New System.Drawing.Font("Humnst777 Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(590, 449)
        Me.btncancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(390, 37)
        Me.btncancel.TabIndex = 6
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(413, 557)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Geometr415 Blk BT", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(630, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 72)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "LOGIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Humnst777 Lt BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(514, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(433, 48)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Silahkan masukan username dan password untuk" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "untuk melakukan login!"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.CheckBoxPass)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents CheckBoxPass As CheckBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
