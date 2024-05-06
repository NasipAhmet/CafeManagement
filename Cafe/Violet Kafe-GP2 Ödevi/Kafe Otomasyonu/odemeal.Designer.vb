<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class odemeal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(odemeal))
        PictureBox5 = New PictureBox()
        odemeyapBTN = New Button()
        Label11 = New Label()
        odemeadetTB = New TextBox()
        Label1 = New Label()
        odemeFiyatTB = New TextBox()
        Label2 = New Label()
        UrunisimTB = New TextBox()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        siparisadetTB = New TextBox()
        Label4 = New Label()
        MasanoTB = New TextBox()
        Label5 = New Label()
        SiparisNOTB = New TextBox()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.BlueViolet
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(161, 406)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(63, 61)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 38
        PictureBox5.TabStop = False
        ' 
        ' odemeyapBTN
        ' 
        odemeyapBTN.BackColor = Color.BlueViolet
        odemeyapBTN.FlatAppearance.BorderSize = 0
        odemeyapBTN.FlatStyle = FlatStyle.Flat
        odemeyapBTN.Font = New Font("Ebrima", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        odemeyapBTN.ForeColor = Color.White
        odemeyapBTN.ImageAlign = ContentAlignment.MiddleLeft
        odemeyapBTN.Location = New Point(161, 406)
        odemeyapBTN.Name = "odemeyapBTN"
        odemeyapBTN.Size = New Size(299, 63)
        odemeyapBTN.TabIndex = 37
        odemeyapBTN.Text = "Odeme Al"
        odemeyapBTN.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Constantia", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.ForeColor = Color.BlueViolet
        Label11.Location = New Point(62, 339)
        Label11.Name = "Label11"
        Label11.Size = New Size(195, 33)
        Label11.TabIndex = 35
        Label11.Text = "Ödenecek Adet"
        ' 
        ' odemeadetTB
        ' 
        odemeadetTB.Font = New Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point)
        odemeadetTB.ForeColor = SystemColors.WindowText
        odemeadetTB.Location = New Point(272, 339)
        odemeadetTB.Multiline = True
        odemeadetTB.Name = "odemeadetTB"
        odemeadetTB.Size = New Size(244, 33)
        odemeadetTB.TabIndex = 36
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Constantia", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.BlueViolet
        Label1.Location = New Point(78, 202)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 33)
        Label1.TabIndex = 39
        Label1.Text = "Fiyat"
        ' 
        ' odemeFiyatTB
        ' 
        odemeFiyatTB.Font = New Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point)
        odemeFiyatTB.ForeColor = Color.Black
        odemeFiyatTB.Location = New Point(272, 202)
        odemeFiyatTB.Multiline = True
        odemeFiyatTB.Name = "odemeFiyatTB"
        odemeFiyatTB.ReadOnly = True
        odemeFiyatTB.Size = New Size(244, 33)
        odemeFiyatTB.TabIndex = 40
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Constantia", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.BlueViolet
        Label2.Location = New Point(78, 144)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 33)
        Label2.TabIndex = 41
        Label2.Text = "Ürün"
        ' 
        ' UrunisimTB
        ' 
        UrunisimTB.Font = New Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point)
        UrunisimTB.ForeColor = SystemColors.WindowText
        UrunisimTB.Location = New Point(272, 144)
        UrunisimTB.Multiline = True
        UrunisimTB.Name = "UrunisimTB"
        UrunisimTB.ReadOnly = True
        UrunisimTB.Size = New Size(244, 33)
        UrunisimTB.TabIndex = 42
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(534, -3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(67, 54)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 43
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Constantia", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.BlueViolet
        Label3.Location = New Point(78, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 33)
        Label3.TabIndex = 44
        Label3.Text = "Sipariş Adeti"
        ' 
        ' siparisadetTB
        ' 
        siparisadetTB.Font = New Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point)
        siparisadetTB.ForeColor = SystemColors.WindowText
        siparisadetTB.Location = New Point(272, 95)
        siparisadetTB.Multiline = True
        siparisadetTB.Name = "siparisadetTB"
        siparisadetTB.ReadOnly = True
        siparisadetTB.Size = New Size(244, 33)
        siparisadetTB.TabIndex = 45
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Constantia", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.BlueViolet
        Label4.Location = New Point(78, 36)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 33)
        Label4.TabIndex = 46
        Label4.Text = "Masa NO"
        ' 
        ' MasanoTB
        ' 
        MasanoTB.Font = New Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MasanoTB.ForeColor = SystemColors.WindowText
        MasanoTB.Location = New Point(272, 36)
        MasanoTB.Multiline = True
        MasanoTB.Name = "MasanoTB"
        MasanoTB.ReadOnly = True
        MasanoTB.Size = New Size(244, 33)
        MasanoTB.TabIndex = 47
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Constantia", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.BlueViolet
        Label5.Location = New Point(78, 256)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 33)
        Label5.TabIndex = 48
        Label5.Text = "Sipariş NO"
        ' 
        ' SiparisNOTB
        ' 
        SiparisNOTB.Font = New Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SiparisNOTB.ForeColor = Color.Black
        SiparisNOTB.Location = New Point(272, 256)
        SiparisNOTB.Multiline = True
        SiparisNOTB.Name = "SiparisNOTB"
        SiparisNOTB.ReadOnly = True
        SiparisNOTB.Size = New Size(244, 33)
        SiparisNOTB.TabIndex = 49
        ' 
        ' odemeal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(599, 501)
        ControlBox = False
        Controls.Add(Label5)
        Controls.Add(SiparisNOTB)
        Controls.Add(Label4)
        Controls.Add(MasanoTB)
        Controls.Add(Label3)
        Controls.Add(siparisadetTB)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(UrunisimTB)
        Controls.Add(Label1)
        Controls.Add(odemeFiyatTB)
        Controls.Add(PictureBox5)
        Controls.Add(odemeyapBTN)
        Controls.Add(Label11)
        Controls.Add(odemeadetTB)
        FormBorderStyle = FormBorderStyle.None
        Name = "odemeal"
        StartPosition = FormStartPosition.CenterScreen
        Text = "odemeal"
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents odemeyapBTN As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents odemeadetTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents odemeFiyatTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents UrunisimTB As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents siparisadetTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MasanoTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SiparisNOTB As TextBox
End Class
