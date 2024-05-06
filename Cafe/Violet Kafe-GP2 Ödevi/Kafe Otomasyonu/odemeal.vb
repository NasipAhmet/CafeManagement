Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class odemeal
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nasip\Documents\CafeVBDT.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
    End Sub

    Public birimfiyat As Integer
    Public adetfiyat As Integer
    Public toplamfiyat As Integer 'parçalı odeme formundan erişmek için seçilen satırdakı OrdermAMT'Ye burdan eriştik

    Sub HesaplaBirimFiyat() 'bir ürünün birim fiyatını hesapladık.
        ' Eğer adet sıfırdan farklı ise, birim fiyatı hesapladık.
        If adetfiyat <> 0 Then
            birimfiyat = toplamfiyat / adetfiyat
        Else
            ' Adet sıfır ise, birim fiyatı sıfır olarak hesapladık.
            birimfiyat = 0
        End If
    End Sub


    Private Sub odemeadetTB_TextChanged(sender As Object, e As EventArgs) Handles odemeadetTB.TextChanged
        ' Eğer odemeadetTB boşsa, HesaplaVeYazdir metodunu çağırmayın
        If odemeadetTB.Text <> "" Then
            HesaplaBirimFiyat()
            Dim siparisadet As Integer
            If Integer.TryParse(siparisadetTB.Text, siparisadet) Then
                Dim girilenDeger As Integer
                If Integer.TryParse(odemeadetTB.Text, girilenDeger) Then
                    If girilenDeger > siparisadet Then
                        MessageBox.Show("Sipariş adetinden büyük bir sayı girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        odemeadetTB.Clear()
                        odemeFiyatTB.Clear()
                    Else
                        ' Birim fiyatı ve girilen adet değerini çarpıp odemeFiyatTB'ye yazdır
                        odemeFiyatTB.Text = (girilenDeger * birimfiyat).ToString()
                    End If
                Else
                    MessageBox.Show("Lütfen geçerli bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    odemeadetTB.Clear()
                    odemeFiyatTB.Clear()
                End If
            End If
        End If
    End Sub



    Private Sub odemeFiyatTB_TextChanged(sender As Object, e As EventArgs) Handles odemeFiyatTB.TextChanged

    End Sub

    Private Sub odemeal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub odemeyapBTN_Click(sender As Object, e As EventArgs) Handles odemeyapBTN.Click
        Dim currentDate As Date = Date.Today

        Try
            If UrunisimTB.Text = "" Or odemeFiyatTB.Text = "" Or odemeadetTB.Text = "" Then
                MsgBox("Eksik bilgi girdiniz")
            Else
                Con.Open()

                Dim Query As String = "INSERT INTO OrderTbl (MasaNO, Urun, adet, OrderDate, OrderAMT) VALUES (@MasaNO, @Urun, @adet, @OrderDate, @OrderAMT);"
                Dim cmd As New SqlCommand(Query, Con)
                cmd.Parameters.AddWithValue("@MasaNO", MasanoTB.Text)
                cmd.Parameters.AddWithValue("@Urun", UrunisimTB.Text)
                cmd.Parameters.AddWithValue("@adet", odemeadetTB.Text)
                cmd.Parameters.AddWithValue("@OrderAMT", odemeFiyatTB.Text)
                cmd.Parameters.AddWithValue("@OrderDate", currentDate)
                cmd.ExecuteNonQuery()

                MsgBox("Sipariş başarıyla ödendi.", MsgBoxStyle.Information)

                ' Sipariş tablosuna eklenen siparişin adet değerini azalt
                Dim updateQuery As String = "UPDATE siparisTABLO SET adet = adet - @adet WHERE OrderID = @OrderID"
                Dim updateCmd As New SqlCommand(updateQuery, Con)
                updateCmd.Parameters.AddWithValue("@adet", Convert.ToInt32(odemeadetTB.Text))
                updateCmd.Parameters.AddWithValue("@OrderID", Convert.ToInt32(SiparisNOTB.Text))
                updateCmd.ExecuteNonQuery()
                ' Sipariş tablosundaki adet değeri sıfır olan satırları sil
                Dim deleteQuery As String = "DELETE FROM siparisTABLO WHERE adet = 0"
                Dim deleteCmd As New SqlCommand(deleteQuery, Con)
                deleteCmd.ExecuteNonQuery()

                odemeadetTB.Clear()
                odemeFiyatTB.Clear()
            End If
        Catch ex As Exception
            MsgBox("Sipariş eklenirken bir hata oluştu: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Con.Close()
        End Try


    End Sub


End Class
