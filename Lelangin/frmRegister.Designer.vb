<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_register = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txt_pass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_user = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txt_nama = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btn_back = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txt_telp = New Bunifu.Framework.UI.BunifuMaterialTextbox()
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
        Me.Panel1.Location = New System.Drawing.Point(662, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(618, 543)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Viga", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(121, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Daftarin akun di Lelangin!"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lelangin.My.Resources.Resources.Saly_14
        Me.PictureBox1.Location = New System.Drawing.Point(117, 116)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(404, 424)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btn_register
        '
        Me.btn_register.Activecolor = System.Drawing.Color.Navy
        Me.btn_register.BackColor = System.Drawing.Color.Navy
        Me.btn_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_register.BorderRadius = 0
        Me.btn_register.ButtonText = "Daftar"
        Me.btn_register.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_register.DisabledColor = System.Drawing.Color.Gray
        Me.btn_register.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_register.Iconimage = Nothing
        Me.btn_register.Iconimage_right = Nothing
        Me.btn_register.Iconimage_right_Selected = Nothing
        Me.btn_register.Iconimage_Selected = Nothing
        Me.btn_register.IconMarginLeft = 0
        Me.btn_register.IconMarginRight = 0
        Me.btn_register.IconRightVisible = True
        Me.btn_register.IconRightZoom = 0R
        Me.btn_register.IconVisible = True
        Me.btn_register.IconZoom = 90.0R
        Me.btn_register.IsTab = False
        Me.btn_register.Location = New System.Drawing.Point(86, 378)
        Me.btn_register.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Normalcolor = System.Drawing.Color.Navy
        Me.btn_register.OnHovercolor = System.Drawing.Color.Navy
        Me.btn_register.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_register.selected = False
        Me.btn_register.Size = New System.Drawing.Size(466, 55)
        Me.btn_register.TabIndex = 14
        Me.btn_register.Text = "Daftar"
        Me.btn_register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_register.Textcolor = System.Drawing.Color.White
        Me.btn_register.TextFont = New System.Drawing.Font("Viga", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txt_pass
        '
        Me.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pass.Font = New System.Drawing.Font("Open Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.ForeColor = System.Drawing.Color.Black
        Me.txt_pass.HintForeColor = System.Drawing.Color.Gray
        Me.txt_pass.HintText = "Password"
        Me.txt_pass.isPassword = True
        Me.txt_pass.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_pass.LineIdleColor = System.Drawing.Color.Navy
        Me.txt_pass.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_pass.LineThickness = 4
        Me.txt_pass.Location = New System.Drawing.Point(86, 229)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(466, 47)
        Me.txt_pass.TabIndex = 13
        Me.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_user
        '
        Me.txt_user.BackColor = System.Drawing.Color.White
        Me.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_user.Font = New System.Drawing.Font("Open Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.ForeColor = System.Drawing.Color.Black
        Me.txt_user.HintForeColor = System.Drawing.Color.Gray
        Me.txt_user.HintText = "Username"
        Me.txt_user.isPassword = False
        Me.txt_user.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_user.LineIdleColor = System.Drawing.Color.Navy
        Me.txt_user.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_user.LineThickness = 4
        Me.txt_user.Location = New System.Drawing.Point(86, 148)
        Me.txt_user.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(466, 47)
        Me.txt_user.TabIndex = 12
        Me.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txt_nama
        '
        Me.txt_nama.BackColor = System.Drawing.Color.White
        Me.txt_nama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nama.Font = New System.Drawing.Font("Open Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nama.ForeColor = System.Drawing.Color.Black
        Me.txt_nama.HintForeColor = System.Drawing.Color.Gray
        Me.txt_nama.HintText = "Nama lengkap"
        Me.txt_nama.isPassword = False
        Me.txt_nama.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_nama.LineIdleColor = System.Drawing.Color.Navy
        Me.txt_nama.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_nama.LineThickness = 4
        Me.txt_nama.Location = New System.Drawing.Point(86, 66)
        Me.txt_nama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(466, 47)
        Me.txt_nama.TabIndex = 15
        Me.txt_nama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Navy
        Me.PictureBox3.Image = Global.Lelangin.My.Resources.Resources.back_arrow_icon_icons_com_72866
        Me.PictureBox3.Location = New System.Drawing.Point(21, 469)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 43)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 114
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
        Me.btn_back.Location = New System.Drawing.Point(15, 455)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(171, 70)
        Me.btn_back.TabIndex = 113
        Me.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_telp
        '
        Me.txt_telp.BackColor = System.Drawing.Color.White
        Me.txt_telp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_telp.Font = New System.Drawing.Font("Open Sans", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_telp.ForeColor = System.Drawing.Color.Black
        Me.txt_telp.HintForeColor = System.Drawing.Color.Gray
        Me.txt_telp.HintText = "No . Telpon"
        Me.txt_telp.isPassword = False
        Me.txt_telp.LineFocusedColor = System.Drawing.Color.Blue
        Me.txt_telp.LineIdleColor = System.Drawing.Color.Navy
        Me.txt_telp.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txt_telp.LineThickness = 3
        Me.txt_telp.Location = New System.Drawing.Point(86, 304)
        Me.txt_telp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_telp.Name = "txt_telp"
        Me.txt_telp.Size = New System.Drawing.Size(466, 47)
        Me.txt_telp.TabIndex = 16
        Me.txt_telp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1278, 542)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.txt_telp)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.btn_register)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_register As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txt_pass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_user As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txt_nama As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_back As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txt_telp As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
