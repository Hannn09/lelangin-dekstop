<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMasyarakat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMasyarakat))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_start = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_logout = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.lbl_user)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 644)
        Me.Panel1.TabIndex = 2
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Viga", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.Color.White
        Me.lbl_user.Location = New System.Drawing.Point(335, 97)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(252, 54)
        Me.lbl_user.TabIndex = 5
        Me.lbl_user.Text = "[Nama User]"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lelangin.My.Resources.Resources.Saly_7
        Me.PictureBox1.Location = New System.Drawing.Point(34, 179)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(553, 465)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Viga", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(44, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 54)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Selamat datang  "
        '
        'btn_start
        '
        Me.btn_start.ActiveBorderThickness = 1
        Me.btn_start.ActiveCornerRadius = 20
        Me.btn_start.ActiveFillColor = System.Drawing.Color.Blue
        Me.btn_start.ActiveForecolor = System.Drawing.Color.White
        Me.btn_start.ActiveLineColor = System.Drawing.Color.Blue
        Me.btn_start.BackColor = System.Drawing.Color.White
        Me.btn_start.BackgroundImage = CType(resources.GetObject("btn_start.BackgroundImage"), System.Drawing.Image)
        Me.btn_start.ButtonText = "Mulai tawar barang"
        Me.btn_start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_start.Font = New System.Drawing.Font("Viga", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start.ForeColor = System.Drawing.Color.White
        Me.btn_start.IdleBorderThickness = 1
        Me.btn_start.IdleCornerRadius = 20
        Me.btn_start.IdleFillColor = System.Drawing.Color.Blue
        Me.btn_start.IdleForecolor = System.Drawing.Color.White
        Me.btn_start.IdleLineColor = System.Drawing.Color.Blue
        Me.btn_start.Location = New System.Drawing.Point(740, 225)
        Me.btn_start.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(354, 86)
        Me.btn_start.TabIndex = 78
        Me.btn_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.Blue
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.Blue
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.White
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "History Lelang"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Viga", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.Blue
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.Blue
        Me.BunifuThinButton21.Location = New System.Drawing.Point(740, 385)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(354, 86)
        Me.BunifuThinButton21.TabIndex = 79
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Navy
        Me.PictureBox3.Image = Global.Lelangin.My.Resources.Resources.logout
        Me.PictureBox3.Location = New System.Drawing.Point(937, 31)
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
        Me.btn_logout.Location = New System.Drawing.Point(931, 17)
        Me.btn_logout.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(218, 70)
        Me.btn_logout.TabIndex = 108
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMasyarakat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1177, 641)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMasyarakat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Masyarakat"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_start As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_logout As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents lbl_user As Label
End Class
