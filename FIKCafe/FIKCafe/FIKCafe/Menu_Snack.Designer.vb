<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Snack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Snack))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvMenuSnack = New System.Windows.Forms.DataGridView()
        Me.kode_snack = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_snack = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMenuSnack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(780, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'dgvMenuSnack
        '
        Me.dgvMenuSnack.BackgroundColor = System.Drawing.Color.PapayaWhip
        Me.dgvMenuSnack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenuSnack.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kode_snack, Me.kategori, Me.nama_snack, Me.harga, Me.stock})
        Me.dgvMenuSnack.Location = New System.Drawing.Point(12, 136)
        Me.dgvMenuSnack.Name = "dgvMenuSnack"
        Me.dgvMenuSnack.RowHeadersWidth = 51
        Me.dgvMenuSnack.RowTemplate.Height = 24
        Me.dgvMenuSnack.Size = New System.Drawing.Size(758, 404)
        Me.dgvMenuSnack.TabIndex = 3
        '
        'kode_snack
        '
        Me.kode_snack.HeaderText = "Kode"
        Me.kode_snack.MinimumWidth = 6
        Me.kode_snack.Name = "kode_snack"
        Me.kode_snack.Width = 125
        '
        'kategori
        '
        Me.kategori.HeaderText = "Kategori"
        Me.kategori.MinimumWidth = 6
        Me.kategori.Name = "kategori"
        Me.kategori.Width = 125
        '
        'nama_snack
        '
        Me.nama_snack.HeaderText = "Nama Snack"
        Me.nama_snack.MinimumWidth = 6
        Me.nama_snack.Name = "nama_snack"
        Me.nama_snack.Width = 125
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
        'Menu_Snack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.dgvMenuSnack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Menu_Snack"
        Me.Text = "Menu_Snack"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMenuSnack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvMenuSnack As DataGridView
    Friend WithEvents kode_snack As DataGridViewTextBoxColumn
    Friend WithEvents kategori As DataGridViewTextBoxColumn
    Friend WithEvents nama_snack As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
End Class
