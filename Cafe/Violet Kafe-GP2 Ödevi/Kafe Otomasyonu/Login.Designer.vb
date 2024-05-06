<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Panel1 = New Panel()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        UnameTb = New TextBox()
        Label7 = New Label()
        PasswordTb = New TextBox()
        SatıcıLabel = New Label()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(424, 566)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Himalaya", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.BlueViolet
        Label2.Location = New Point(90, 430)
        Label2.Name = "Label2"
        Label2.Size = New Size(213, 64)
        Label2.TabIndex = 4
        Label2.Text = "Rose Kafe"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-56, 73)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(518, 328)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Constantia", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(60, 516)
        Label1.Name = "Label1"
        Label1.Size = New Size(243, 45)
        Label1.TabIndex = 0
        Label1.Text = "Mavi Ay Kafe"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Ebrima", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(576, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(263, 50)
        Label4.TabIndex = 1
        Label4.Text = "Yönetici Girişi"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Constantia", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(451, 146)
        Label5.Name = "Label5"
        Label5.Size = New Size(181, 33)
        Label5.TabIndex = 2
        Label5.Text = "Kullanıcı Adı"
        ' 
        ' UnameTb
        ' 
        UnameTb.Font = New Font("Lato", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        UnameTb.ForeColor = SystemColors.WindowText
        UnameTb.Location = New Point(638, 146)
        UnameTb.Multiline = True
        UnameTb.Name = "UnameTb"
        UnameTb.Size = New Size(261, 33)
        UnameTb.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Constantia", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(557, 198)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 33)
        Label7.TabIndex = 6
        Label7.Text = "Şifre"
        ' 
        ' PasswordTb
        ' 
        PasswordTb.Font = New Font("Lato", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        PasswordTb.ForeColor = SystemColors.WindowText
        PasswordTb.Location = New Point(638, 198)
        PasswordTb.Multiline = True
        PasswordTb.Name = "PasswordTb"
        PasswordTb.Size = New Size(261, 33)
        PasswordTb.TabIndex = 7
        ' 
        ' SatıcıLabel
        ' 
        SatıcıLabel.AutoSize = True
        SatıcıLabel.Font = New Font("Montserrat", 27.7499962F, FontStyle.Underline, GraphicsUnit.Point)
        SatıcıLabel.ForeColor = Color.White
        SatıcıLabel.Location = New Point(468, 394)
        SatıcıLabel.Name = "SatıcıLabel"
        SatıcıLabel.Size = New Size(453, 45)
        SatıcıLabel.TabIndex = 8
        SatıcıLabel.Text = "Satış ekranı için tıklayın"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.BlueViolet
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(716, 250)
        Button1.Name = "Button1"
        Button1.Size = New Size(183, 54)
        Button1.TabIndex = 9
        Button1.Text = "Giriş"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.WhiteSmoke
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(897, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(34, 34)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BlueViolet
        ClientSize = New Size(943, 566)
        Controls.Add(PictureBox2)
        Controls.Add(Button1)
        Controls.Add(SatıcıLabel)
        Controls.Add(PasswordTb)
        Controls.Add(Label7)
        Controls.Add(UnameTb)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents UnameTb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents SatıcıLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
End Class
