﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterPembelian))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbCustomer = New System.Windows.Forms.TextBox()
        Me.tbMenu = New System.Windows.Forms.TextBox()
        Me.tbHarga = New System.Windows.Forms.TextBox()
        Me.tbJumlah = New System.Windows.Forms.TextBox()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.tbKodeTransaksi = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnMenuMakanan = New System.Windows.Forms.Button()
        Me.btnMenuMinuman = New System.Windows.Forms.Button()
        Me.btnMenuSnack = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dgvPembelian = New System.Windows.Forms.DataGridView()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.waktu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(985, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Humnst777 BT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(549, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Humnst777 BT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(549, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama Menu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Humnst777 BT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(549, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Humnst777 BT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(549, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Jumlah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Humnst777 BT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(549, 388)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Total"
        '
        'tbCustomer
        '
        Me.tbCustomer.BackColor = System.Drawing.Color.FloralWhite
        Me.tbCustomer.Font = New System.Drawing.Font("Humnst777 Lt BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomer.Location = New System.Drawing.Point(672, 180)
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.Size = New System.Drawing.Size(152, 28)
        Me.tbCustomer.TabIndex = 7
        '
        'tbMenu
        '
        Me.tbMenu.BackColor = System.Drawing.Color.Linen
        Me.tbMenu.Font = New System.Drawing.Font("Humnst777 Lt BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMenu.Location = New System.Drawing.Point(672, 228)
        Me.tbMenu.Name = "tbMenu"
        Me.tbMenu.ReadOnly = True
        Me.tbMenu.Size = New System.Drawing.Size(288, 28)
        Me.tbMenu.TabIndex = 8
        '
        'tbHarga
        '
        Me.tbHarga.BackColor = System.Drawing.Color.Linen
        Me.tbHarga.Font = New System.Drawing.Font("Humnst777 Lt BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHarga.Location = New System.Drawing.Point(672, 281)
        Me.tbHarga.Name = "tbHarga"
        Me.tbHarga.ReadOnly = True
        Me.tbHarga.Size = New System.Drawing.Size(152, 28)
        Me.tbHarga.TabIndex = 9
        '
        'tbJumlah
        '
        Me.tbJumlah.BackColor = System.Drawing.Color.FloralWhite
        Me.tbJumlah.Font = New System.Drawing.Font("Humnst777 Lt BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbJumlah.Location = New System.Drawing.Point(672, 332)
        Me.tbJumlah.Name = "tbJumlah"
        Me.tbJumlah.Size = New System.Drawing.Size(152, 28)
        Me.tbJumlah.TabIndex = 10
        '
        'tbTotal
        '
        Me.tbTotal.BackColor = System.Drawing.Color.Linen
        Me.tbTotal.Font = New System.Drawing.Font("Humnst777 Lt BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotal.Location = New System.Drawing.Point(672, 388)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.Size = New System.Drawing.Size(152, 28)
        Me.tbTotal.TabIndex = 11
        '
        'tbKodeTransaksi
        '
        Me.tbKodeTransaksi.BackColor = System.Drawing.Color.Linen
        Me.tbKodeTransaksi.Font = New System.Drawing.Font("Humnst777 Lt BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbKodeTransaksi.Location = New System.Drawing.Point(830, 180)
        Me.tbKodeTransaksi.Name = "tbKodeTransaksi"
        Me.tbKodeTransaksi.ReadOnly = True
        Me.tbKodeTransaksi.Size = New System.Drawing.Size(130, 28)
        Me.tbKodeTransaksi.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(24, 180)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(500, 230)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(50, 210)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(212, 210)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(374, 210)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(120, 120)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'btnMenuMakanan
        '
        Me.btnMenuMakanan.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnMenuMakanan.Font = New System.Drawing.Font("Humnst777 Cn BT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuMakanan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMenuMakanan.Location = New System.Drawing.Point(50, 345)
        Me.btnMenuMakanan.Name = "btnMenuMakanan"
        Me.btnMenuMakanan.Size = New System.Drawing.Size(120, 33)
        Me.btnMenuMakanan.TabIndex = 17
        Me.btnMenuMakanan.Text = "Makanan"
        Me.btnMenuMakanan.UseVisualStyleBackColor = False
        '
        'btnMenuMinuman
        '
        Me.btnMenuMinuman.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnMenuMinuman.Font = New System.Drawing.Font("Humnst777 Cn BT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuMinuman.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMenuMinuman.Location = New System.Drawing.Point(212, 345)
        Me.btnMenuMinuman.Name = "btnMenuMinuman"
        Me.btnMenuMinuman.Size = New System.Drawing.Size(120, 33)
        Me.btnMenuMinuman.TabIndex = 18
        Me.btnMenuMinuman.Text = "Minuman"
        Me.btnMenuMinuman.UseVisualStyleBackColor = False
        '
        'btnMenuSnack
        '
        Me.btnMenuSnack.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnMenuSnack.Font = New System.Drawing.Font("Humnst777 Cn BT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuSnack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMenuSnack.Location = New System.Drawing.Point(374, 345)
        Me.btnMenuSnack.Name = "btnMenuSnack"
        Me.btnMenuSnack.Size = New System.Drawing.Size(120, 33)
        Me.btnMenuSnack.TabIndex = 19
        Me.btnMenuSnack.Text = "Snack"
        Me.btnMenuSnack.UseVisualStyleBackColor = False
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnTambah.Font = New System.Drawing.Font("Humnst777 Cn BT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTambah.Location = New System.Drawing.Point(840, 386)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(120, 33)
        Me.btnTambah.TabIndex = 20
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'dgvPembelian
        '
        Me.dgvPembelian.BackgroundColor = System.Drawing.Color.Bisque
        Me.dgvPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPembelian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.waktu, Me.kode, Me.customer, Me.menu, Me.harga, Me.jumlah, Me.subtotal})
        Me.dgvPembelian.Location = New System.Drawing.Point(24, 456)
        Me.dgvPembelian.Name = "dgvPembelian"
        Me.dgvPembelian.RowHeadersWidth = 51
        Me.dgvPembelian.RowTemplate.Height = 24
        Me.dgvPembelian.Size = New System.Drawing.Size(936, 207)
        Me.dgvPembelian.TabIndex = 21
        '
        'btnBayar
        '
        Me.btnBayar.BackColor = System.Drawing.Color.PaleGreen
        Me.btnBayar.Font = New System.Drawing.Font("Humnst777 Cn BT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBayar.Location = New System.Drawing.Point(796, 759)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(120, 33)
        Me.btnBayar.TabIndex = 22
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Linen
        Me.TextBox1.Font = New System.Drawing.Font("Humnst777 Lt BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(759, 805)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(192, 28)
        Me.TextBox1.TabIndex = 23
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FloralWhite
        Me.TextBox2.Font = New System.Drawing.Font("Humnst777 Lt BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(759, 717)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(192, 28)
        Me.TextBox2.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Humnst777 BT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(633, 720)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Bayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Humnst777 BT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(633, 805)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 20)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Kembalian"
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.Color.Pink
        Me.btnKembali.Font = New System.Drawing.Font("Humnst777 Cn BT", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnKembali.Location = New System.Drawing.Point(24, 808)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(120, 33)
        Me.btnKembali.TabIndex = 28
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Humnst777 BT", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(633, 677)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 20)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Total Harga"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Linen
        Me.TextBox3.Font = New System.Drawing.Font("Humnst777 Lt BT", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(759, 674)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(194, 28)
        Me.TextBox3.TabIndex = 29
        '
        'waktu
        '
        Me.waktu.HeaderText = "Waktu"
        Me.waktu.MinimumWidth = 6
        Me.waktu.Name = "waktu"
        Me.waktu.Width = 125
        '
        'kode
        '
        Me.kode.HeaderText = "Kode Transaksi"
        Me.kode.MinimumWidth = 6
        Me.kode.Name = "kode"
        Me.kode.Width = 125
        '
        'customer
        '
        Me.customer.HeaderText = "Customer"
        Me.customer.MinimumWidth = 6
        Me.customer.Name = "customer"
        Me.customer.Width = 125
        '
        'menu
        '
        Me.menu.HeaderText = "Nama Menu"
        Me.menu.MinimumWidth = 6
        Me.menu.Name = "menu"
        Me.menu.Width = 125
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.MinimumWidth = 6
        Me.harga.Name = "harga"
        Me.harga.Width = 125
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.MinimumWidth = 6
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Width = 125
        '
        'subtotal
        '
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.MinimumWidth = 6
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Width = 125
        '
        'MasterPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(982, 853)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnBayar)
        Me.Controls.Add(Me.dgvPembelian)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnMenuSnack)
        Me.Controls.Add(Me.btnMenuMinuman)
        Me.Controls.Add(Me.btnMenuMakanan)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.tbKodeTransaksi)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.tbJumlah)
        Me.Controls.Add(Me.tbHarga)
        Me.Controls.Add(Me.tbMenu)
        Me.Controls.Add(Me.tbCustomer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MasterPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterPembelian"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbCustomer As TextBox
    Friend WithEvents tbMenu As TextBox
    Friend WithEvents tbHarga As TextBox
    Friend WithEvents tbJumlah As TextBox
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents tbKodeTransaksi As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnMenuMakanan As Button
    Friend WithEvents btnMenuMinuman As Button
    Friend WithEvents btnMenuSnack As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvPembelian As DataGridView
    Friend WithEvents btnBayar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents waktu As DataGridViewTextBoxColumn
    Friend WithEvents kode As DataGridViewTextBoxColumn
    Friend WithEvents customer As DataGridViewTextBoxColumn
    Friend WithEvents menu As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
End Class
