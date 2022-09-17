<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddAdmin))
        Me.lv_petugas = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_level = New System.Windows.Forms.ComboBox()
        Me.txt_id_level = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_id_petugas = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nama = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_add = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_back = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lv_petugas
        '
        Me.lv_petugas.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.lv_petugas.AllowColumnReorder = True
        Me.lv_petugas.AllowDrop = True
        Me.lv_petugas.CheckBoxes = True
        Me.lv_petugas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lv_petugas.FullRowSelect = True
        Me.lv_petugas.GridLines = True
        Me.lv_petugas.Location = New System.Drawing.Point(81, 90)
        Me.lv_petugas.Margin = New System.Windows.Forms.Padding(0)
        Me.lv_petugas.MinimumSize = New System.Drawing.Size(775, 312)
        Me.lv_petugas.Name = "lv_petugas"
        Me.lv_petugas.RightToLeftLayout = True
        Me.lv_petugas.Size = New System.Drawing.Size(989, 366)
        Me.lv_petugas.TabIndex = 102
        Me.lv_petugas.TileSize = New System.Drawing.Size(775, 312)
        Me.lv_petugas.UseCompatibleStateImageBehavior = False
        Me.lv_petugas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Id"
        Me.ColumnHeader1.Width = 130
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama petugas"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Username"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 180
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Level"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 145
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Viga", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(478, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 43)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Manage Admin"
        '
        'cb_level
        '
        Me.cb_level.FormattingEnabled = True
        Me.cb_level.Location = New System.Drawing.Point(262, 710)
        Me.cb_level.Name = "cb_level"
        Me.cb_level.Size = New System.Drawing.Size(256, 28)
        Me.cb_level.TabIndex = 120
        '
        'txt_id_level
        '
        Me.txt_id_level.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id_level.Enabled = False
        Me.txt_id_level.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_id_level.ForeColor = System.Drawing.Color.Black
        Me.txt_id_level.HintForeColor = System.Drawing.Color.Black
        Me.txt_id_level.HintText = ""
        Me.txt_id_level.isPassword = False
        Me.txt_id_level.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_id_level.LineIdleColor = System.Drawing.Color.Navy
        Me.txt_id_level.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_id_level.LineThickness = 3
        Me.txt_id_level.Location = New System.Drawing.Point(570, 696)
        Me.txt_id_level.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_id_level.Name = "txt_id_level"
        Me.txt_id_level.Size = New System.Drawing.Size(91, 42)
        Me.txt_id_level.TabIndex = 119
        Me.txt_id_level.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sora", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(83, 710)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 30)
        Me.Label6.TabIndex = 118
        Me.Label6.Text = "Level :"
        '
        'txt_id_petugas
        '
        Me.txt_id_petugas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id_petugas.Enabled = False
        Me.txt_id_petugas.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_id_petugas.ForeColor = System.Drawing.Color.Black
        Me.txt_id_petugas.HintForeColor = System.Drawing.Color.Black
        Me.txt_id_petugas.HintText = ""
        Me.txt_id_petugas.isPassword = False
        Me.txt_id_petugas.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_id_petugas.LineIdleColor = System.Drawing.Color.Navy
        Me.txt_id_petugas.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_id_petugas.LineThickness = 3
        Me.txt_id_petugas.Location = New System.Drawing.Point(261, 460)
        Me.txt_id_petugas.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_id_petugas.Name = "txt_id_petugas"
        Me.txt_id_petugas.Size = New System.Drawing.Size(80, 42)
        Me.txt_id_petugas.TabIndex = 122
        Me.txt_id_petugas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sora", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 472)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 30)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Id Petugas :"
        '
        'txt_nama
        '
        Me.txt_nama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nama.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_nama.ForeColor = System.Drawing.Color.Black
        Me.txt_nama.HintForeColor = System.Drawing.Color.Black
        Me.txt_nama.HintText = ""
        Me.txt_nama.isPassword = False
        Me.txt_nama.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_nama.LineIdleColor = System.Drawing.Color.Navy
        Me.txt_nama.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_nama.LineThickness = 3
        Me.txt_nama.Location = New System.Drawing.Point(261, 510)
        Me.txt_nama.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(256, 42)
        Me.txt_nama.TabIndex = 124
        Me.txt_nama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sora", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(82, 522)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 30)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "Nama Petugas :"
        '
        'txt_username
        '
        Me.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_username.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_username.ForeColor = System.Drawing.Color.Black
        Me.txt_username.HintForeColor = System.Drawing.Color.Black
        Me.txt_username.HintText = ""
        Me.txt_username.isPassword = False
        Me.txt_username.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_username.LineIdleColor = System.Drawing.Color.Navy
        Me.txt_username.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_username.LineThickness = 3
        Me.txt_username.Location = New System.Drawing.Point(261, 573)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(256, 42)
        Me.txt_username.TabIndex = 126
        Me.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sora", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 585)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 30)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Username :"
        '
        'txt_password
        '
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txt_password.ForeColor = System.Drawing.Color.Black
        Me.txt_password.HintForeColor = System.Drawing.Color.Black
        Me.txt_password.HintText = ""
        Me.txt_password.isPassword = True
        Me.txt_password.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_password.LineIdleColor = System.Drawing.Color.Navy
        Me.txt_password.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_password.LineThickness = 3
        Me.txt_password.Location = New System.Drawing.Point(261, 638)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(256, 42)
        Me.txt_password.TabIndex = 128
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sora", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(82, 650)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 30)
        Me.Label5.TabIndex = 127
        Me.Label5.Text = "Password :"
        '
        'btn_add
        '
        Me.btn_add.ActiveBorderThickness = 1
        Me.btn_add.ActiveCornerRadius = 20
        Me.btn_add.ActiveFillColor = System.Drawing.Color.Blue
        Me.btn_add.ActiveForecolor = System.Drawing.Color.White
        Me.btn_add.ActiveLineColor = System.Drawing.Color.Blue
        Me.btn_add.BackColor = System.Drawing.Color.White
        Me.btn_add.BackgroundImage = CType(resources.GetObject("btn_add.BackgroundImage"), System.Drawing.Image)
        Me.btn_add.ButtonText = "Submit"
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.Font = New System.Drawing.Font("Viga", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.IdleBorderThickness = 1
        Me.btn_add.IdleCornerRadius = 20
        Me.btn_add.IdleFillColor = System.Drawing.Color.Blue
        Me.btn_add.IdleForecolor = System.Drawing.Color.White
        Me.btn_add.IdleLineColor = System.Drawing.Color.Blue
        Me.btn_add.Location = New System.Drawing.Point(632, 570)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(224, 70)
        Me.btn_add.TabIndex = 129
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Navy
        Me.PictureBox3.Image = Global.Lelangin.My.Resources.Resources.back_arrow_icon_icons_com_72866
        Me.PictureBox3.Location = New System.Drawing.Point(951, 726)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 43)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 131
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
        Me.btn_back.Location = New System.Drawing.Point(945, 712)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(184, 70)
        Me.btn_back.TabIndex = 130
        Me.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAddAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1144, 799)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_id_petugas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cb_level)
        Me.Controls.Add(Me.txt_id_level)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lv_petugas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddAdmin"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lv_petugas As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents cb_level As ComboBox
    Friend WithEvents txt_id_level As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_id_petugas As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nama As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_add As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_back As Bunifu.Framework.UI.BunifuThinButton2
End Class
