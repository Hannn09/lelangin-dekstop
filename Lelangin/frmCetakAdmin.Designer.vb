<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCetakAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCetakAdmin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lv_petugas = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_back = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_print = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Viga", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(526, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 43)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Form Laporan"
        '
        'lv_petugas
        '
        Me.lv_petugas.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.lv_petugas.AllowColumnReorder = True
        Me.lv_petugas.AllowDrop = True
        Me.lv_petugas.CheckBoxes = True
        Me.lv_petugas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lv_petugas.FullRowSelect = True
        Me.lv_petugas.GridLines = True
        Me.lv_petugas.Location = New System.Drawing.Point(68, 89)
        Me.lv_petugas.Margin = New System.Windows.Forms.Padding(0)
        Me.lv_petugas.MinimumSize = New System.Drawing.Size(775, 312)
        Me.lv_petugas.Name = "lv_petugas"
        Me.lv_petugas.RightToLeftLayout = True
        Me.lv_petugas.Scrollable = False
        Me.lv_petugas.Size = New System.Drawing.Size(1172, 502)
        Me.lv_petugas.TabIndex = 115
        Me.lv_petugas.TileSize = New System.Drawing.Size(775, 312)
        Me.lv_petugas.UseCompatibleStateImageBehavior = False
        Me.lv_petugas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id Barang"
        Me.ColumnHeader1.Width = 90
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama Barang"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tanggal Upload"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 110
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Harga Awal"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 115
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Deskripsi"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Tanggal lelang"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 110
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Harga Akhir"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 120
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Navy
        Me.PictureBox3.Image = Global.Lelangin.My.Resources.Resources.back_arrow_icon_icons_com_72866
        Me.PictureBox3.Location = New System.Drawing.Point(24, 634)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 43)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 119
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
        Me.btn_back.Location = New System.Drawing.Point(13, 620)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(179, 71)
        Me.btn_back.TabIndex = 118
        Me.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_print
        '
        Me.btn_print.ActiveBorderThickness = 1
        Me.btn_print.ActiveCornerRadius = 20
        Me.btn_print.ActiveFillColor = System.Drawing.Color.Navy
        Me.btn_print.ActiveForecolor = System.Drawing.Color.White
        Me.btn_print.ActiveLineColor = System.Drawing.Color.Navy
        Me.btn_print.BackColor = System.Drawing.Color.White
        Me.btn_print.BackgroundImage = CType(resources.GetObject("btn_print.BackgroundImage"), System.Drawing.Image)
        Me.btn_print.ButtonText = "Print"
        Me.btn_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_print.Font = New System.Drawing.Font("Viga", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.White
        Me.btn_print.IdleBorderThickness = 1
        Me.btn_print.IdleCornerRadius = 20
        Me.btn_print.IdleFillColor = System.Drawing.Color.Navy
        Me.btn_print.IdleForecolor = System.Drawing.Color.White
        Me.btn_print.IdleLineColor = System.Drawing.Color.Navy
        Me.btn_print.Location = New System.Drawing.Point(574, 620)
        Me.btn_print.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(171, 70)
        Me.btn_print.TabIndex = 117
        Me.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmCetakAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1317, 711)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lv_petugas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCetakAdmin"
        Me.Text = "frmCetakAdmin"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_back As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_print As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As Label
    Friend WithEvents lv_petugas As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
