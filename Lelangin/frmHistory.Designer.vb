<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistory))
        Me.lv_barang = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_back = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lv_barang
        '
        Me.lv_barang.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.lv_barang.AllowColumnReorder = True
        Me.lv_barang.AllowDrop = True
        Me.lv_barang.CheckBoxes = True
        Me.lv_barang.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lv_barang.FullRowSelect = True
        Me.lv_barang.GridLines = True
        Me.lv_barang.Location = New System.Drawing.Point(80, 115)
        Me.lv_barang.Margin = New System.Windows.Forms.Padding(0)
        Me.lv_barang.MinimumSize = New System.Drawing.Size(775, 312)
        Me.lv_barang.Name = "lv_barang"
        Me.lv_barang.RightToLeftLayout = True
        Me.lv_barang.Size = New System.Drawing.Size(815, 312)
        Me.lv_barang.TabIndex = 103
        Me.lv_barang.TileSize = New System.Drawing.Size(775, 312)
        Me.lv_barang.UseCompatibleStateImageBehavior = False
        Me.lv_barang.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Id Barang"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Penawaran Harga"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Viga", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(361, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 43)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "History Lelang"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Navy
        Me.PictureBox3.Image = Global.Lelangin.My.Resources.Resources.back_arrow_icon_icons_com_72866
        Me.PictureBox3.Location = New System.Drawing.Point(26, 449)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 43)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 123
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
        Me.btn_back.Location = New System.Drawing.Point(15, 435)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(179, 71)
        Me.btn_back.TabIndex = 122
        Me.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(992, 519)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lv_barang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lv_barang As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_back As Bunifu.Framework.UI.BunifuThinButton2
End Class
