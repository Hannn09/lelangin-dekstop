<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPetugas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPetugas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_logout = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_lapor = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_edit = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(627, 650)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lelangin.My.Resources.Resources.Saly_10
        Me.PictureBox1.Location = New System.Drawing.Point(26, 176)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(553, 465)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Viga", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(66, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(482, 54)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selamat datang Petugas !"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Navy
        Me.PictureBox3.Image = Global.Lelangin.My.Resources.Resources.logout
        Me.PictureBox3.Location = New System.Drawing.Point(950, 31)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 43)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 107
        Me.PictureBox3.TabStop = False
        '
        'btn_logout
        '
        Me.btn_logout.ActiveBorderThickness = 1
        Me.btn_logout.ActiveCornerRadius = 20
        Me.btn_logout.ActiveFillColor = System.Drawing.Color.Navy
        Me.btn_logout.ActiveForecolor = System.Drawing.Color.White
        Me.btn_logout.ActiveLineColor = System.Drawing.Color.Navy
        Me.btn_logout.BackColor = System.Drawing.Color.White
        Me.btn_logout.BackgroundImage = CType(resources.GetObject("btn_logout.BackgroundImage"), System.Drawing.Image)
        Me.btn_logout.ButtonText = "Logout"
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.Font = New System.Drawing.Font("Viga", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.IdleBorderThickness = 1
        Me.btn_logout.IdleCornerRadius = 20
        Me.btn_logout.IdleFillColor = System.Drawing.Color.Navy
        Me.btn_logout.IdleForecolor = System.Drawing.Color.White
        Me.btn_logout.IdleLineColor = System.Drawing.Color.Navy
        Me.btn_logout.Location = New System.Drawing.Point(944, 17)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(218, 70)
        Me.btn_logout.TabIndex = 106
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.Blue
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.Blue
        Me.BunifuThinButton22.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "Data barang lelang"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Viga", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.Blue
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.Blue
        Me.BunifuThinButton22.Location = New System.Drawing.Point(738, 282)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(354, 86)
        Me.BunifuThinButton22.TabIndex = 79
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_lapor
        '
        Me.btn_lapor.ActiveBorderThickness = 1
        Me.btn_lapor.ActiveCornerRadius = 20
        Me.btn_lapor.ActiveFillColor = System.Drawing.Color.Blue
        Me.btn_lapor.ActiveForecolor = System.Drawing.Color.White
        Me.btn_lapor.ActiveLineColor = System.Drawing.Color.Blue
        Me.btn_lapor.BackColor = System.Drawing.Color.White
        Me.btn_lapor.BackgroundImage = CType(resources.GetObject("btn_lapor.BackgroundImage"), System.Drawing.Image)
        Me.btn_lapor.ButtonText = "Laporan lelang"
        Me.btn_lapor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_lapor.Font = New System.Drawing.Font("Viga", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lapor.ForeColor = System.Drawing.Color.White
        Me.btn_lapor.IdleBorderThickness = 1
        Me.btn_lapor.IdleCornerRadius = 20
        Me.btn_lapor.IdleFillColor = System.Drawing.Color.Blue
        Me.btn_lapor.IdleForecolor = System.Drawing.Color.White
        Me.btn_lapor.IdleLineColor = System.Drawing.Color.Blue
        Me.btn_lapor.Location = New System.Drawing.Point(738, 439)
        Me.btn_lapor.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_lapor.Name = "btn_lapor"
        Me.btn_lapor.Size = New System.Drawing.Size(354, 86)
        Me.btn_lapor.TabIndex = 78
        Me.btn_lapor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_edit.ButtonText = "Tambah barang lelang"
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.Font = New System.Drawing.Font("Viga", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.White
        Me.btn_edit.IdleBorderThickness = 1
        Me.btn_edit.IdleCornerRadius = 20
        Me.btn_edit.IdleFillColor = System.Drawing.Color.Blue
        Me.btn_edit.IdleForecolor = System.Drawing.Color.White
        Me.btn_edit.IdleLineColor = System.Drawing.Color.Blue
        Me.btn_edit.Location = New System.Drawing.Point(738, 138)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(354, 86)
        Me.btn_edit.TabIndex = 77
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1177, 641)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.BunifuThinButton22)
        Me.Controls.Add(Me.btn_lapor)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPetugas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_edit As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_lapor As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_logout As Bunifu.Framework.UI.BunifuThinButton2
End Class
