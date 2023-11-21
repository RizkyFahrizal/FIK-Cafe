<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Minuman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Minuman))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvMenuMinuman = New System.Windows.Forms.DataGridView()
        Me.kode_minuman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_minuman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMenuMinuman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(780, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'dgvMenuMinuman
        '
        Me.dgvMenuMinuman.BackgroundColor = System.Drawing.Color.PapayaWhip
        Me.dgvMenuMinuman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenuMinuman.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kode_minuman, Me.kategori, Me.nama_minuman, Me.harga, Me.stock})
        Me.dgvMenuMinuman.Location = New System.Drawing.Point(12, 136)
        Me.dgvMenuMinuman.Name = "dgvMenuMinuman"
        Me.dgvMenuMinuman.RowHeadersWidth = 51
        Me.dgvMenuMinuman.RowTemplate.Height = 24
        Me.dgvMenuMinuman.Size = New System.Drawing.Size(758, 404)
        Me.dgvMenuMinuman.TabIndex = 2
        '
        'kode_minuman
        '
        Me.kode_minuman.HeaderText = "Kode"
        Me.kode_minuman.MinimumWidth = 6
        Me.kode_minuman.Name = "kode_minuman"
        Me.kode_minuman.Width = 125
        '
        'kategori
        '
        Me.kategori.HeaderText = "Kategori"
        Me.kategori.MinimumWidth = 6
        Me.kategori.Name = "kategori"
        Me.kategori.Width = 125
        '
        'nama_minuman
        '
        Me.nama_minuman.HeaderText = "Nama Minuman"
        Me.nama_minuman.MinimumWidth = 6
        Me.nama_minuman.Name = "nama_minuman"
        Me.nama_minuman.Width = 125
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.MinimumWidth = 6
        Me.harga.Name = "harga"
        Me.harga.Width = 125
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.MinimumWidth = 6
        Me.stock.Name = "stock"
        Me.stock.Width = 125
        '
        'Menu_Minuman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.dgvMenuMinuman)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Menu_Minuman"
        Me.Text = "Menu_Minuman"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMenuMinuman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvMenuMinuman As DataGridView
    Friend WithEvents kode_minuman As DataGridViewTextBoxColumn
    Friend WithEvents kategori As DataGridViewTextBoxColumn
    Friend WithEvents nama_minuman As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
End Class
