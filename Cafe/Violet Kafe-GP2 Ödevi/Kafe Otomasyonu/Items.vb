Imports System.Data.SqlClient
Public Class Items

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nasip\Documents\CafeVBDT.mdf;Integrated Security=True;Connect Timeout=30")




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles MasaEkleBTN.Click, Button2.Click
        If MasaEkleTB.Text = "" Then
            MsgBox("Lütfen bir kategori girin")
        Else
            Con.Open
            Dim Query = "insert into CategoryDT values('" & MasaEkleTB.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Kategori Eklendi")
            Con.Close
            MasaEkleTB.Text = ""
            kategoridoldur()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()

    End Sub
    Private Sub Reset()
        ItnameTB.Text() = ""
        CatCB.SelectedIndex = 0
        QuantityTB.Text = ""
        ItPriceTB.Text = ""

    End Sub
    Private Sub kategoridoldur() ' form yuklendıgınde kateogırı doldurur.
        Con.open()
        Dim cmd = New SqlCommand("select*from CategoryDT", Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim tbl = New DataTable()

        adapter.Fill(tbl)
        CatCB.DataSource = tbl
        CatCB.DisplayMember = "CatName"
        CatCB.ValueMember = "CatName"
        Con.close()
    End Sub

    Private Sub ResetBTN_Click(sender As Object, e As EventArgs) Handles ResetBTN.Click
        Reset()
    End Sub

    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kategoridoldur()
        DisplayItem()
    End Sub
    Private Sub DisplayItem()
        Con.Open()
        Dim query = "Select * from ItematTBL "
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.close()
    End Sub

    Private Sub AddBTN_Click(sender As Object, e As EventArgs) Handles AddBTN.Click
        If CatCB.SelectedIndex = -1 Or ItnameTB.Text = "" Or ItPriceTB.Text = "" Or QuantityTB.Text = "" Then
            MsgBox("Eksik bilgi girdiniz")
        Else
            Con.Open()
            Dim Query = "insert into ItematTBL values('" & ItnameTB.Text & "','" & CatCB.SelectedValue.ToString() & "'," & ItPriceTB.Text & "," & QuantityTB.Text & ")"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Ürün Eklendi")
            Con.Close()
            Reset()
            DisplayItem()
        End If
    End Sub
    Dim key = 0
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ItnameTB.Text = row.Cells(1).Value.ToString
        CatCB.SelectedValue = row.Cells(2).Value.ToString
        ItPriceTB.Text = row.Cells(3).Value.ToString
        QuantityTB.Text = row.Cells(4).Value.ToString
        If ItnameTB.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub DeleteBTN_Click(sender As Object, e As EventArgs) Handles DeleteBTN.Click
        If key = 0 Then
            MsgBox("Öncelikle silmek istediğiniz ürünü seçin ")
        Else
            Con.Open()
            Dim Query = "Delete from ItematTBL Where ItemID=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Ürün başarıyla silindi")
            Con.Close()
            Reset()
            DisplayItem()
        End If
    End Sub

    Private Sub EditBTN_Click(sender As Object, e As EventArgs) Handles EditBTN.Click
        If CatCB.SelectedIndex = -1 Or ItnameTB.Text = "" Or ItPriceTB.Text = "" Or QuantityTB.Text = "" Then
            MsgBox("Eksik bilgi girdiniz")
        Else
            Try
                Con.Open()
                Dim Query = "Update ItematTBL set ItemName='" & ItnameTB.Text & "', ItemCat='" & CatCB.SelectedValue.ToString() & "', ItemPrice=" & ItPriceTB.Text & ",IntQty=" & QuantityTB.Text & "where ItemID=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Ürün Düzenlendi")
                Con.Close()
                Reset()
                DisplayItem()
            Catch ax As Exception
                MsgBox(ax.Message)
            End Try
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton2.Click
        Dim obj = New Login
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub ItemDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemDGV.CellContentClick

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' DataGridView'e sütun başlıklarını ayarlamak için bir liste kullanın
        Dim columnHeaders As New List(Of String) From {"NO", "Ürün", "Kategori", "fiyat", "Miktar"}
        ' Sütun başlıklarını DataGridView'e ekle
        For i As Integer = 0 To columnHeaders.Count - 1
            If i < ItemDGV.Columns.Count Then ' Sütun başlıklarını kontrol etmek için
                ItemDGV.Columns(i).HeaderText = columnHeaders(i)
            End If
        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles MasaEkleTXBX.TextChanged

    End Sub

    Private Sub MasaEkle_Click(sender As Object, e As EventArgs) Handles MasaEkle.Click ' Masa ekleme kısmı
        If MasaEkleTXBX.Text = "" Then
            MsgBox("Lütfen bir Masa NO girin")
            Exit Sub
        End If

        Try
            Con.Open()
            Dim queryCheck As String = "SELECT COUNT(*) FROM MasaNO WHERE MasaNo = @MasaNo"
            Dim cmdCheck As New SqlCommand(queryCheck, Con)
            cmdCheck.Parameters.AddWithValue("@MasaNo", MasaEkleTXBX.Text)
            Dim rowCount As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())

            If rowCount > 0 Then
                MsgBox("Bu masa zaten mevcut!")
            Else
                Dim queryInsert As String = "INSERT INTO MasaNO VALUES (@MasaNo)"
                Dim cmdInsert As New SqlCommand(queryInsert, Con)
                cmdInsert.Parameters.AddWithValue("@MasaNo", MasaEkleTXBX.Text)
                cmdInsert.ExecuteNonQuery()
                MsgBox("Masa Eklendi")
                MasaEkleTXBX.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Con.Close()
        End Try
    End Sub
    Private Sub urunarama() 'tabloda ürün arama
        Con.Open()
        Dim urunarama As String = "Select * from ItematTBL where ItemName ='" & urunaramaTB.Text & "'"
        Dim sda As New SqlDataAdapter(urunarama, CType(Con, SqlConnection)) ' Con değişkenini SqlConnection türüne dönüştür
        Dim builder As New SqlCommandBuilder(sda)
        Dim ds As New DataSet()
        sda.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub urunlerınhepsinigöster() 'urunlerın hepisin göstermek için gerekli method.
        Con.Open()
        Dim query = "Select * from ItematTBL "
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.close()




    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        urunarama()
    End Sub

    Private Sub MasaYenileBTN_Click(sender As Object, e As EventArgs) Handles MasaYenileBTN.Click
        urunlerınhepsinigöster()
    End Sub



End Class
