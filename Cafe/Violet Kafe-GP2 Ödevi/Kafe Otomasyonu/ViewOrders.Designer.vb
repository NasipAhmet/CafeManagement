<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewOrders
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewOrders))
        Label4 = New Label()
        Button1 = New Button()
        OrderDGV = New DataGridView()
        PictureBox2 = New PictureBox()
        CType(OrderDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Constantia", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(697, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(263, 45)
        Label4.TabIndex = 3
        Label4.Text = "Sipariş Geçmişi"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Tahoma", 27.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.BlueViolet
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(772, 986)
        Button1.Name = "Button1"
        Button1.Size = New Size(261, 73)
        Button1.TabIndex = 19
        Button1.Text = "Geri"
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = False
        ' 
        ' OrderDGV
        ' 
        OrderDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        OrderDGV.BackgroundColor = Color.White
        OrderDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        OrderDGV.DefaultCellStyle = DataGridViewCellStyle1
        OrderDGV.Location = New Point(41, 79)
        OrderDGV.Name = "OrderDGV"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        OrderDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        OrderDGV.RowHeadersVisible = False
        OrderDGV.RowHeadersWidth = 30
        OrderDGV.RowTemplate.Height = 25
        OrderDGV.Size = New Size(1645, 878)
        OrderDGV.TabIndex = 32
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(772, 986)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(85, 73)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 33
        PictureBox2.TabStop = False
        ' 
        ' ViewOrders
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BlueViolet
        ClientSize = New Size(1752, 1071)
        Controls.Add(PictureBox2)
        Controls.Add(OrderDGV)
        Controls.Add(Button1)
        Controls.Add(Label4)
        FormBorderStyle = FormBorderStyle.None
        Name = "ViewOrders"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(OrderDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents OrderDGV As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
End Class
