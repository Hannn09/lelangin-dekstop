<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTawar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTawar))
        Me.lv_barang = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_tawar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_tgl = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_id_barang = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.cb_barang = New System.Windows.Forms.ComboBox()
        Me.nmric_harga = New System.Windows.Forms.NumericUpDown()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_back = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmric_harga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lv_barang
        '
        Me.lv_barang.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.lv_barang.AllowColumnReorder = True
        Me.lv_barang.AllowDrop = True
        Me.lv_barang.CheckBoxes = True
        Me.lv_barang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6})
        Me.lv_barang.FullRowSelect = True
        Me.lv_barang.GridLines = True
        Me.lv_barang.Location = New System.Drawing.Point(27, 123)
        Me.lv_barang.Margin = New System.Windows.Forms.Padding(0)
        Me.lv_barang.MinimumSize = New System.Drawing.Size(775, 312)
        Me.lv_barang.Name = "lv_barang"
        Me.lv_barang.RightToLeftLayout = True
        Me.lv_barang.Size = New System.Drawing.Size(775, 312)
        Me.lv_barang.TabIndex = 101
        Me.lv_barang.TileSize = New System.Drawing.Size(775, 312)
        Me.lv_barang.UseCompatibleStateImageBehavior = False
        Me.lv_barang.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama barang"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tanggal"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Harga Awal"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Deskripsi"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 90
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(829, 123)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(314, 312)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Viga", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(432, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 43)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Daftar barang lelang"
        '
        'btn_tawar
        '
        Me.btn_tawar.ActiveBorderThickness = 1
        Me.btn_tawar.ActiveCornerRadius = 20
        Me.btn_tawar.ActiveFillColor = System.Drawing.Color.Blue
        Me.btn_tawar.ActiveForecolor = System.Drawing.Color.White
        Me.btn_tawar.ActiveLineColor = System.Drawing.Color.Blue
        Me.btn_tawar.BackColor = System.Drawing.Color.White
        Me.btn_tawar.BackgroundImage = CType(resources.GetObject("btn_tawar.BackgroundImage"), System.Drawing.Image)
        Me.btn_tawar.ButtonText = "Masukkan Tawaran"
        Me.btn_tawar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_tawar.Font = New System.Drawing.Font("Viga", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tawar.ForeColor = System.Drawing.Color.White
        Me.btn_tawar.IdleBorderThickness = 1
        Me.btn_tawar.IdleCornerRadius = 20
        Me.btn_tawar.IdleFillColor = System.Drawing.Color.Blue
        Me.btn_tawar.IdleForecolor = System.Drawing.Color.White
        Me.btn_tawar.IdleLineColor = System.Drawing.Color.Blue
        Me.btn_tawar.Location = New System.Drawing.Point(563, 594)
        Me.btn_tawar.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_tawar.Name = "btn_tawar"
        Me.btn_tawar.Size = New System.Drawing.Size(328, 70)
        Me.btn_tawar.TabIndex = 113
        Me.btn_tawar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sora", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 623)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 30)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "Rp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sora", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 544)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 30)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Tanggal Lelang :"
        '
        'dtp_tgl
        '
        Me.dtp_tgl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_tgl.Location = New System.Drawing.Point(250, 552)
        Me.dtp_tgl.Name = "dtp_tgl"
        Me.dtp_tgl.Size = New System.Drawing.Size(256, 26)
        Me.dtp_tgl.TabIndex = 110
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sora", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 623)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 30)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Harga Akhir :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sora", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 474)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 30)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Nama Barang :"
        '
        'txt_id_barang
        '
        Me.txt_id_barang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id_barang.Enabled = False
        Me.txt_id_barang.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_id_barang.ForeColor = System.Drawing.Color.Black
        Me.txt_id_barang.HintForeColor = System.Drawing.Color.Black
        Me.txt_id_barang.HintText = ""
        Me.txt_id_barang.isPassword = False
        Me.txt_id_barang.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_id_barang.LineIdleColor = System.Drawing.Color.Navy
        Me.txt_id_barang.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_id_barang.LineThickness = 3
        Me.txt_id_barang.Location = New System.Drawing.Point(538, 462)
        Me.txt_id_barang.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_id_barang.Name = "txt_id_barang"
        Me.txt_id_barang.Size = New System.Drawing.Size(91, 42)
        Me.txt_id_barang.TabIndex = 116
        Me.txt_id_barang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cb_barang
        '
        Me.cb_barang.FormattingEnabled = True
        Me.cb_barang.Location = New System.Drawing.Point(250, 476)
        Me.cb_barang.Name = "cb_barang"
        Me.cb_barang.Size = New System.Drawing.Size(256, 28)
        Me.cb_barang.TabIndex = 117
        '
        'nmric_harga
        '
        Me.nmric_harga.Location = New System.Drawing.Point(250, 629)
        Me.nmric_harga.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.nmric_harga.Minimum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nmric_harga.Name = "nmric_harga"
        Me.nmric_harga.Size = New System.Drawing.Size(256, 26)
        Me.nmric_harga.TabIndex = 118
        Me.nmric_harga.Value = New Decimal(New Integer() {10000, 0, 0, 0})
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Navy
        Me.PictureBox3.Image = Global.Lelangin.My.Resources.Resources.back_arrow_icon_icons_com_72866
        Me.PictureBox3.Location = New System.Drawing.Point(1022, 647)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 43)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 121
        Me.PictureBox3.TabStop = False
        '
        'btn_back
        '
        Me.btn_back.ActiveBorderThickness = 1
        Me.btn_back.ActiveCornerRadius = 20
        Me.btn_back.ActiveFillColor = System.Drawing.Color.Navy
        Me.btn_back.ActiveForecolor = System.Drawing.Color.White
        Me.btn_back.ActiveLineColor = System.Drawing.Color.Navy
        Me.btn_back.BackColor = System.Drawing.Color.White
        Me.btn_back.BackgroundImage = CType(resources.GetObject("btn_back.BackgroundImage"), System.Drawing.Image)
        Me.btn_back.ButtonText = "Back"
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back.Font = New System.Drawing.Font("Viga", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.IdleBorderThickness = 1
        Me.btn_back.IdleCornerRadius = 20
        Me.btn_back.IdleFillColor = System.Drawing.Color.Navy
        Me.btn_back.IdleForecolor = System.Drawing.Color.White
        Me.btn_back.IdleLineColor = System.Drawing.Color.Navy
        Me.btn_back.Location = New System.Drawing.Point(1011, 633)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(179, 71)
        Me.btn_back.TabIndex = 120
        Me.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTawar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1212, 737)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.nmric_harga)
        Me.Controls.Add(Me.cb_barang)
        Me.Controls.Add(Me.txt_id_barang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_tawar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_tgl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lv_barang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTawar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tawarbarang"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmric_harga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lv_barang As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_tawar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_tgl As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_id_barang As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents cb_barang As ComboBox
    Friend WithEvents nmric_harga As NumericUpDown
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_back As Bunifu.Framework.UI.BunifuThinButton2
End Class
