<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMaster))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BerandaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnMasterPembelian = New System.Windows.Forms.Button()
        Me.btnMasterProduk = New System.Windows.Forms.Button()
        Me.btnMasterTransaksi = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(381, 630)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BerandaToolStripMenuItem, Me.MasterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(990, 28)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BerandaToolStripMenuItem
        '
        Me.BerandaToolStripMenuItem.Image = CType(resources.GetObject("BerandaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BerandaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BerandaToolStripMenuItem.Name = "BerandaToolStripMenuItem"
        Me.BerandaToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.BerandaToolStripMenuItem.Text = "Beranda"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.Image = CType(resources.GetObject("MasterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MasterToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'btnMasterPembelian
        '
        Me.btnMasterPembelian.BackColor = System.Drawing.Color.PeachPuff
        Me.btnMasterPembelian.Font = New System.Drawing.Font("Humnst777 BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasterPembelian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMasterPembelian.Location = New System.Drawing.Point(544, 215)
        Me.btnMasterPembelian.Name = "btnMasterPembelian"
        Me.btnMasterPembelian.Size = New System.Drawing.Size(313, 48)
        Me.btnMasterPembelian.TabIndex = 11
        Me.btnMasterPembelian.Text = "Master Pembelian"
        Me.btnMasterPembelian.UseVisualStyleBackColor = False
        '
        'btnMasterProduk
        '
        Me.btnMasterProduk.BackColor = System.Drawing.Color.PeachPuff
        Me.btnMasterProduk.Font = New System.Drawing.Font("Humnst777 BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasterProduk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMasterProduk.Location = New System.Drawing.Point(544, 312)
        Me.btnMasterProduk.Name = "btnMasterProduk"
        Me.btnMasterProduk.Size = New System.Drawing.Size(313, 48)
        Me.btnMasterProduk.TabIndex = 12
        Me.btnMasterProduk.Text = "Master Produk"
        Me.btnMasterProduk.UseVisualStyleBackColor = False
        '
        'btnMasterTransaksi
        '
        Me.btnMasterTransaksi.BackColor = System.Drawing.Color.PeachPuff
        Me.btnMasterTransaksi.Font = New System.Drawing.Font("Humnst777 BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasterTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMasterTransaksi.Location = New System.Drawing.Point(544, 405)
        Me.btnMasterTransaksi.Name = "btnMasterTransaksi"
        Me.btnMasterTransaksi.Size = New System.Drawing.Size(313, 48)
        Me.btnMasterTransaksi.TabIndex = 13
        Me.btnMasterTransaksi.Text = "Master Transaksi"
        Me.btnMasterTransaksi.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(488, 213)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(488, 310)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(488, 403)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Humnst777 BlkCn BT", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(556, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 46)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Pilihan Master"
        '
        'FormMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(990, 642)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnMasterTransaksi)
        Me.Controls.Add(Me.btnMasterProduk)
        Me.Controls.Add(Me.btnMasterPembelian)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMaster"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BerandaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnMasterPembelian As Button
    Friend WithEvents btnMasterProduk As Button
    Friend WithEvents btnMasterTransaksi As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
End Class
