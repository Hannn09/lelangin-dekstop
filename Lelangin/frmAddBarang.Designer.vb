<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddBarang))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_back = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_namabrg = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_harga = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_tgl = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_deskripsi = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_id = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lv_barang = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuThinButton24 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_delete = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_edit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_add = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_browse = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.open_foto = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(196, 790)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Lelangin.My.Resources.Resources.back_arrow_icon_icons_com_72866
        Me.PictureBox3.Location = New System.Drawing.Point(12, 385)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 43)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 105
        Me.PictureBox3.TabStop = False
        '
        'btn_back
        '
        Me.btn_back.ActiveBorderThickness = 1
        Me.btn_back.ActiveCornerRadius = 20
        Me.btn_back.ActiveFillColor = System.Drawing.Color.Navy
        Me.btn_back.ActiveForecolor = System.Drawing.Color.White
        Me.btn_back.ActiveLineColor = System.Drawing.Color.Navy
        Me.btn_back.BackColor = System.Drawing.Color.Navy
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
        Me.btn_back.Location = New System.Drawing.Point(6, 371)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(184, 70)
        Me.btn_back.TabIndex = 104
        Me.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sora", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Barang :"
        '
        'txt_namabrg
        '
        Me.txt_namabrg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_namabrg.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_namabrg.ForeColor = System.Drawing.Color.Black
        Me.txt_namabrg.HintForeColor = System.Drawing.Color.Black
        Me.txt_namabrg.HintText = ""
        Me.txt_namabrg.isPassword = False
        Me.txt_namabrg.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_namabrg.LineIdleColor = System.Drawing.Color.Navy
        Me.txt_namabrg.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_namabrg.LineThickness = 3
        Me.txt_namabrg.Location = New System.Drawing.Point(374, 37)
        Me.txt_namabrg.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_namabrg.Name = "txt_namabrg"
        Me.txt_namabrg.Size = New System.Drawing.Size(350, 42)
        Me.txt_namabrg.TabIndex = 2
        Me.txt_namabrg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_harga
        '
        Me.txt_harga.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_harga.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_harga.ForeColor = System.Drawing.Color.Black
        Me.txt_harga.HintForeColor = System.Drawing.Color.Black
        Me.txt_harga.HintText = ""
        Me.txt_harga.isPassword = False
        Me.txt_harga.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_harga.LineIdleColor = System.Drawing.Color.Navy
        Me.txt_harga.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_harga.LineThickness = 3
        Me.txt_harga.Location = New System.Drawing.Point(427, 176)
        Me.txt_harga.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(297, 42)
        Me.txt_harga.TabIndex = 4
        Me.txt_harga.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sora", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(212, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Harga Awal :"
        '
        'dtp_tgl
        '
        Me.dtp_tgl.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_tgl.Location = New System.Drawing.Point(374, 112)
        Me.dtp_tgl.Name = "dtp_tgl"
        Me.dtp_tgl.Size = New System.Drawing.Size(149, 26)
        Me.dtp_tgl.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sora", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(212, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 30)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tanggal :"
        '
        'txt_deskripsi
        '
        Me.txt_deskripsi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_deskripsi.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_deskripsi.ForeColor = System.Drawing.Color.Black
        Me.txt_deskripsi.HintForeColor = System.Drawing.Color.Black
        Me.txt_deskripsi.HintText = ""
        Me.txt_deskripsi.isPassword = False
        Me.txt_deskripsi.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_deskripsi.LineIdleColor = System.Drawing.Color.Navy
        Me.txt_deskripsi.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_deskripsi.LineThickness = 3
        Me.txt_deskripsi.Location = New System.Drawing.Point(374, 256)
        Me.txt_deskripsi.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_deskripsi.Name = "txt_deskripsi"
        Me.txt_deskripsi.Size = New System.Drawing.Size(350, 42)
        Me.txt_deskripsi.TabIndex = 8
        Me.txt_deskripsi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sora", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(212, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 30)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Deskripsi :"
        '
        'txt_id
        '
        Me.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id.Enabled = False
        Me.txt_id.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_id.ForeColor = System.Drawing.Color.Black
        Me.txt_id.HintForeColor = System.Drawing.Color.Black
        Me.txt_id.HintText = ""
        Me.txt_id.isPassword = False
        Me.txt_id.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_id.LineIdleColor = System.Drawing.Color.Navy
        Me.txt_id.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_id.LineThickness = 3
        Me.txt_id.Location = New System.Drawing.Point(855, 109)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(123, 51)
        Me.txt_id.TabIndex = 82
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sora", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(693, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 30)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Id Barang :"
        '
        'lv_barang
        '
        Me.lv_barang.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.lv_barang.AllowColumnReorder = True
        Me.lv_barang.AllowDrop = True
        Me.lv_barang.CheckBoxes = True
        Me.lv_barang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lv_barang.FullRowSelect = True
        Me.lv_barang.GridLines = True
        Me.lv_barang.Location = New System.Drawing.Point(217, 420)
        Me.lv_barang.Margin = New System.Windows.Forms.Padding(0)
        Me.lv_barang.MinimumSize = New System.Drawing.Size(775, 312)
        Me.lv_barang.Name = "lv_barang"
        Me.lv_barang.RightToLeftLayout = True
        Me.lv_barang.Size = New System.Drawing.Size(775, 312)
        Me.lv_barang.TabIndex = 100
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
        Me.ColumnHeader2.Text = "Nama Barang"
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
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Deskripsi"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 80
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sora", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(369, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 30)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Rp"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(1018, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(356, 286)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 102
        Me.PictureBox1.TabStop = False
        '
        'BunifuThinButton24
        '
        Me.BunifuThinButton24.ActiveBorderThickness = 1
        Me.BunifuThinButton24.ActiveCornerRadius = 20
        Me.BunifuThinButton24.ActiveFillColor = System.Drawing.Color.Orange
        Me.BunifuThinButton24.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.ActiveLineColor = System.Drawing.Color.Orange
        Me.BunifuThinButton24.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton24.BackgroundImage = CType(resources.GetObject("BunifuThinButton24.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton24.ButtonText = "Clear All"
        Me.BunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton24.Font = New System.Drawing.Font("Viga", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton24.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton24.IdleBorderThickness = 1
        Me.BunifuThinButton24.IdleCornerRadius = 20
        Me.BunifuThinButton24.IdleFillColor = System.Drawing.Color.Orange
        Me.BunifuThinButton24.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton24.IdleLineColor = System.Drawing.Color.Orange
        Me.BunifuThinButton24.Location = New System.Drawing.Point(767, 333)
        Me.BunifuThinButton24.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.BunifuThinButton24.Name = "BunifuThinButton24"
        Me.BunifuThinButton24.Size = New System.Drawing.Size(156, 70)
        Me.BunifuThinButton24.TabIndex = 79
        Me.BunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_delete
        '
        Me.btn_delete.ActiveBorderThickness = 1
        Me.btn_delete.ActiveCornerRadius = 20
        Me.btn_delete.ActiveFillColor = System.Drawing.Color.Red
        Me.btn_delete.ActiveForecolor = System.Drawing.Color.White
        Me.btn_delete.ActiveLineColor = System.Drawing.Color.Red
        Me.btn_delete.BackColor = System.Drawing.Color.White
        Me.btn_delete.BackgroundImage = CType(resources.GetObject("btn_delete.BackgroundImage"), System.Drawing.Image)
        Me.btn_delete.ButtonText = "Delete"
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.Font = New System.Drawing.Font("Viga", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.IdleBorderThickness = 1
        Me.btn_delete.IdleCornerRadius = 20
        Me.btn_delete.IdleFillColor = System.Drawing.Color.Red
        Me.btn_delete.IdleForecolor = System.Drawing.Color.White
        Me.btn_delete.IdleLineColor = System.Drawing.Color.Red
        Me.btn_delete.Location = New System.Drawing.Point(585, 333)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(156, 70)
        Me.btn_delete.TabIndex = 77
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_edit
        '
        Me.btn_edit.ActiveBorderThickness = 1
        Me.btn_edit.ActiveCornerRadius = 20
        Me.btn_edit.ActiveFillColor = System.Drawing.Color.Blue
        Me.btn_edit.ActiveForecolor = System.Drawing.Color.White
        Me.btn_edit.ActiveLineColor = System.Drawing.Color.Blue
        Me.btn_edit.BackColor = System.Drawing.Color.White
        Me.btn_edit.BackgroundImage = CType(resources.GetObject("btn_edit.BackgroundImage"), System.Drawing.Image)
        Me.btn_edit.ButtonText = "Edit"
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.Font = New System.Drawing.Font("Viga", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.White
        Me.btn_edit.IdleBorderThickness = 1
        Me.btn_edit.IdleCornerRadius = 20
        Me.btn_edit.IdleFillColor = System.Drawing.Color.Blue
        Me.btn_edit.IdleForecolor = System.Drawing.Color.White
        Me.btn_edit.IdleLineColor = System.Drawing.Color.Blue
        Me.btn_edit.Location = New System.Drawing.Point(401, 333)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(156, 70)
        Me.btn_edit.TabIndex = 76
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_add
        '
        Me.btn_add.ActiveBorderThickness = 1
        Me.btn_add.ActiveCornerRadius = 20
        Me.btn_add.ActiveFillColor = System.Drawing.Color.Green
        Me.btn_add.ActiveForecolor = System.Drawing.Color.White
        Me.btn_add.ActiveLineColor = System.Drawing.Color.Green
        Me.btn_add.BackColor = System.Drawing.Color.White
        Me.btn_add.BackgroundImage = CType(resources.GetObject("btn_add.BackgroundImage"), System.Drawing.Image)
        Me.btn_add.ButtonText = "Save"
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.Font = New System.Drawing.Font("Viga", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.IdleBorderThickness = 1
        Me.btn_add.IdleCornerRadius = 20
        Me.btn_add.IdleFillColor = System.Drawing.Color.Green
        Me.btn_add.IdleForecolor = System.Drawing.Color.White
        Me.btn_add.IdleLineColor = System.Drawing.Color.Green
        Me.btn_add.Location = New System.Drawing.Point(217, 333)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(156, 70)
        Me.btn_add.TabIndex = 75
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_browse
        '
        Me.btn_browse.ActiveBorderThickness = 1
        Me.btn_browse.ActiveCornerRadius = 20
        Me.btn_browse.ActiveFillColor = System.Drawing.Color.Yellow
        Me.btn_browse.ActiveForecolor = System.Drawing.Color.White
        Me.btn_browse.ActiveLineColor = System.Drawing.Color.Yellow
        Me.btn_browse.BackColor = System.Drawing.Color.White
        Me.btn_browse.BackgroundImage = CType(resources.GetObject("btn_browse.BackgroundImage"), System.Drawing.Image)
        Me.btn_browse.ButtonText = "Browse"
        Me.btn_browse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_browse.Font = New System.Drawing.Font("Viga", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.ForeColor = System.Drawing.Color.White
        Me.btn_browse.IdleBorderThickness = 1
        Me.btn_browse.IdleCornerRadius = 20
        Me.btn_browse.IdleFillColor = System.Drawing.Color.Yellow
        Me.btn_browse.IdleForecolor = System.Drawing.Color.White
        Me.btn_browse.IdleLineColor = System.Drawing.Color.Yellow
        Me.btn_browse.Location = New System.Drawing.Point(1018, 339)
        Me.btn_browse.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(356, 70)
        Me.btn_browse.TabIndex = 104
        Me.btn_browse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'open_foto
        '
        Me.open_foto.FileName = "OpenFileDialog1"
        '
        'frmAddBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1422, 762)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lv_barang)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BunifuThinButton24)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txt_deskripsi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_tgl)
        Me.Controls.Add(Me.txt_harga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_namabrg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_namabrg As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_harga As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_tgl As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_deskripsi As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_add As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_edit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_delete As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton24 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txt_id As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents lv_barang As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_back As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_browse As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents open_foto As OpenFileDialog
End Class
