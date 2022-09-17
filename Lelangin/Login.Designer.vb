<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txt_username = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_password = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btn_login = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cb_log = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(625, 542)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Viga", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(46, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(283, 43)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "online di Lelangin!"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Viga", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Permudah lelangmu secara"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lelangin.My.Resources.Resources.Saly_19
        Me.PictureBox1.Location = New System.Drawing.Point(13, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(545, 441)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Viga", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(792, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(307, 43)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hai, Selamat datang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Viga", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(814, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Baru di Lelangin?"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Viga", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(960, 101)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(102, 21)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Daftar gratis"
        '
        'txt_username
        '
        Me.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_username.Font = New System.Drawing.Font("Open Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.ForeColor = System.Drawing.Color.Black
        Me.txt_username.HintForeColor = System.Drawing.Color.Gray
        Me.txt_username.HintText = "Username"
        Me.txt_username.isPassword = False
        Me.txt_username.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_username.LineIdleColor = System.Drawing.Color.Navy
        Me.txt_username.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_username.LineThickness = 4
        Me.txt_username.Location = New System.Drawing.Point(721, 150)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(466, 47)
        Me.txt_username.TabIndex = 6
        Me.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_password
        '
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.Font = New System.Drawing.Font("Open Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.ForeColor = System.Drawing.Color.Black
        Me.txt_password.HintForeColor = System.Drawing.Color.Gray
        Me.txt_password.HintText = "Password"
        Me.txt_password.isPassword = True
        Me.txt_password.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_password.LineIdleColor = System.Drawing.Color.Navy
        Me.txt_password.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_password.LineThickness = 4
        Me.txt_password.Location = New System.Drawing.Point(721, 250)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(466, 47)
        Me.txt_password.TabIndex = 7
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btn_login
        '
        Me.btn_login.Activecolor = System.Drawing.Color.Navy
        Me.btn_login.BackColor = System.Drawing.Color.Navy
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_login.BorderRadius = 0
        Me.btn_login.ButtonText = "Masuk"
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.DisabledColor = System.Drawing.Color.Gray
        Me.btn_login.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_login.Iconimage = Nothing
        Me.btn_login.Iconimage_right = Nothing
        Me.btn_login.Iconimage_right_Selected = Nothing
        Me.btn_login.Iconimage_Selected = Nothing
        Me.btn_login.IconMarginLeft = 0
        Me.btn_login.IconMarginRight = 0
        Me.btn_login.IconRightVisible = True
        Me.btn_login.IconRightZoom = 0R
        Me.btn_login.IconVisible = True
        Me.btn_login.IconZoom = 90.0R
        Me.btn_login.IsTab = False
        Me.btn_login.Location = New System.Drawing.Point(721, 415)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Normalcolor = System.Drawing.Color.Navy
        Me.btn_login.OnHovercolor = System.Drawing.Color.Navy
        Me.btn_login.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_login.selected = False
        Me.btn_login.Size = New System.Drawing.Size(466, 55)
        Me.btn_login.TabIndex = 8
        Me.btn_login.Text = "Masuk"
        Me.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_login.Textcolor = System.Drawing.Color.White
        Me.btn_login.TextFont = New System.Drawing.Font("Viga", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cb_log
        '
        Me.cb_log.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_log.FormattingEnabled = True
        Me.cb_log.Location = New System.Drawing.Point(721, 346)
        Me.cb_log.Name = "cb_log"
        Me.cb_log.Size = New System.Drawing.Size(466, 34)
        Me.cb_log.TabIndex = 9
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1278, 542)
        Me.Controls.Add(Me.cb_log)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txt_username As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_password As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btn_login As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cb_log As ComboBox
End Class
