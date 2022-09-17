<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_admin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_data = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_logout = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btn_lapor = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 644)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Viga", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(90, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(452, 54)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Selamat datang Admin !"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lelangin.My.Resources.Resources.Saly_11
        Me.PictureBox1.Location = New System.Drawing.Point(81, 193)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(461, 459)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn_admin
        '
        Me.btn_admin.ActiveBorderThickness = 1
        Me.btn_admin.ActiveCornerRadius = 20
        Me.btn_admin.ActiveFillColor = System.Drawing.Color.Blue
        Me.btn_admin.ActiveForecolor = System.Drawing.Color.White
        Me.btn_admin.ActiveLineColor = System.Drawing.Color.Blue
        Me.btn_admin.BackColor = System.Drawing.Color.White
        Me.btn_admin.BackgroundImage = CType(resources.GetObject("btn_admin.BackgroundImage"), System.Drawing.Image)
        Me.btn_admin.ButtonText = "Tambah Admin"
        Me.btn_admin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_admin.Font = New System.Drawing.Font("Viga", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_admin.ForeColor = System.Drawing.Color.White
        Me.btn_admin.IdleBorderThickness = 1
        Me.btn_admin.IdleCornerRadius = 20
        Me.btn_admin.IdleFillColor = System.Drawing.Color.Blue
        Me.btn_admin.IdleForecolor = System.Drawing.Color.White
        Me.btn_admin.IdleLineColor = System.Drawing.Color.Blue
        Me.btn_admin.Location = New System.Drawing.Point(749, 166)
        Me.btn_admin.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(354, 86)
        Me.btn_admin.TabIndex = 81
        Me.btn_admin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_data
        '
        Me.btn_data.ActiveBorderThickness = 1
        Me.btn_data.ActiveCornerRadius = 20
        Me.btn_data.ActiveFillColor = System.Drawing.Color.Blue
        Me.btn_data.ActiveForecolor = System.Drawing.Color.White
        Me.btn_data.ActiveLineColor = System.Drawing.Color.Blue
        Me.btn_data.BackColor = System.Drawing.Color.White
        Me.btn_data.BackgroundImage = CType(resources.GetObject("btn_data.BackgroundImage"), System.Drawing.Image)
        Me.btn_data.ButtonText = "Data barang lelang"
        Me.btn_data.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_data.Font = New System.Drawing.Font("Viga", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_data.ForeColor = System.Drawing.Color.White
        Me.btn_data.IdleBorderThickness = 1
        Me.btn_data.IdleCornerRadius = 20
        Me.btn_data.IdleFillColor = System.Drawing.Color.Blue
        Me.btn_data.IdleForecolor = System.Drawing.Color.White
        Me.btn_data.IdleLineColor = System.Drawing.Color.Blue
        Me.btn_data.Location = New System.Drawing.Point(749, 305)
        Me.btn_data.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_data.Name = "btn_data"
        Me.btn_data.Size = New System.Drawing.Size(354, 86)
        Me.btn_data.TabIndex = 80
        Me.btn_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Navy
        Me.PictureBox3.Image = Global.Lelangin.My.Resources.Resources.logout
        Me.PictureBox3.Location = New System.Drawing.Point(950, 31)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 43)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 109
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
        Me.btn_logout.TabIndex = 108
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_lapor.Location = New System.Drawing.Point(749, 445)
        Me.btn_lapor.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_lapor.Name = "btn_lapor"
        Me.btn_lapor.Size = New System.Drawing.Size(354, 86)
        Me.btn_lapor.TabIndex = 110
        Me.btn_lapor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1177, 641)
        Me.Controls.Add(Me.btn_lapor)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_admin)
        Me.Controls.Add(Me.btn_data)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Landing"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_admin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_data As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_logout As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btn_lapor As Bunifu.Framework.UI.BunifuThinButton2
End Class
