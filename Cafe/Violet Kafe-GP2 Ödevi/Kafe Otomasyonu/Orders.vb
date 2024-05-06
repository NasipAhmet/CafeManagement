Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Orders
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nasip\Documents\CafeVBDT.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DisplayItem()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

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

    Private Sub SiparisGoster()
        Con.Open()
        Dim query = "Select * from SiparisTABLO "
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        BillDGV.DataSource = ds.Tables(0)
        Con.close()
    End Sub

    Private Sub FilterbyCategory()
        Con.Open()
        Dim query = "Select * from ItematTBL where Itemcat='" & CatCB.SelectedValue.ToString() & "' "
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        Con.close()
    End Sub
    Private Sub fillCategory()
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
    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
        fillCategory()
        fillMasaCMBX1()
        fillMasaCMBX2()
    End Sub
    Private Sub fillMasaCMBX1() 'Form yuklendııgnde masa numaralarıın getirir.
        Con.open()
        Dim cmd = New SqlCommand("select*from MasaNO", Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim tbl = New DataTable()
        adapter.Fill(tbl)
        MasaCMBX.DataSource = tbl
        MasaCMBX.DisplayMember = "MasaNO"
        MasaCMBX.ValueMember = "MasaNO"
        Con.close()
    End Sub
    Private Sub fillMasaCMBX2() 'Form yuklendıgnde Sipariş kısmı  masa numaralarıın getirir.
        Con.open()
        Dim cmd = New SqlCommand("select*from MasaNO", Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim tbl = New DataTable()
        adapter.Fill(tbl)
        MasaSiparisCMBX.DataSource = tbl
        MasaSiparisCMBX.DisplayMember = "MasaNO"
        MasaSiparisCMBX.ValueMember = "MasaNO"
        Con.close()
    End Sub

    Private Sub FilterbyMASANO() 'Masa numarası seçildiğinde masaya göre filtereme yapar.
        Con.Open()
        Dim query = "Select * from SiparisTABLO where MasaNO='" & MasaSiparisCMBX.SelectedValue.ToString() & "' "
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        BillDGV.DataSource = ds.Tables(0)
        Con.close()
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CatCB.SelectedIndexChanged

    End Sub

    Private Sub CatCB_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CatCB.SelectionChangeCommitted
        FilterbyCategory()
    End Sub

    Dim ProdName As String
    Dim i = 0, price, qty

    Private Sub butunodemeal()
        Dim odemebasarılımesajı As Boolean = False ' Başarı mesajının yalnızca bir kez gösterilmesini sağlamak için 

        For Each row As DataGridViewRow In BillDGV.Rows
            ' DataGridView'deki her satır için işlemleri yapın
            If Not row.IsNewRow Then
                ' Satırın verilerini alın
                'veri1 yok çunku o primary key.
                Dim veri2 As String = row.Cells("MasaNO").Value.ToString()
                Dim veri3 As String = row.Cells("Urun").Value.ToString()
                Dim veri4 As String = row.Cells("adet").Value.ToString()
                Dim veri5 As String = row.Cells("OrderDate").Value.ToString()
                Dim veri6 As String = row.Cells("OrderAMT").Value.ToString()
                ' Daha fazla sütun varsa, onları da burada alabilirsiniz.

                ' Alınan verileri bir tabloya ekleyin veya veritabanına gönderin
                Try
                    ' Veritabanına bağlanın
                    Con.Open()

                    ' Verileri eklemek için SQL sorgusunu oluşturun
                    Dim query As String = "INSERT INTO OrderTbl (MasaNO,Urun,adet,OrderDate,OrderAMT) VALUES (@Veri2,@Veri3,@Veri4,@Veri5,@Veri6)"

                    ' SqlCommand'u oluşturun
                    Dim cmd As New SqlCommand(query, Con)

                    cmd.Parameters.AddWithValue("@Veri2", veri2)
                    cmd.Parameters.AddWithValue("@Veri3", veri3)
                    cmd.Parameters.AddWithValue("@Veri4", veri4)
                    cmd.Parameters.AddWithValue("@Veri5", veri5)
                    cmd.Parameters.AddWithValue("@Veri6", veri6)
                    cmd.ExecuteNonQuery()

                    ' Başarı mesajını sadece bir kez göstermezsem sürekli erkrana basıyor.
                    If Not odemebasarılımesajı Then
                        MessageBox.Show("Ödeme Başarılı.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        MessageBox.Show("Sipariş Kaydedildi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        odemebasarılımesajı = True '  böylece mesaj yalnızca bir kez gösterilir
                    End If
                Catch ex As Exception
                    ' Hata durumunda kullanıcıya bilgi verin
                    MessageBox.Show("Ödeme alınırken eklenirken bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    ' Bağlantıyı kapatın
                    Con.Close()
                End Try
            End If
        Next
    End Sub

    Private odemeBasariliGosterildi As Boolean = False ' Başlangıçta ödeme başarılı mesajının gösterilmediğini belirtmek için

    Private Sub butunodemesonrasıtemızleme()
        Dim secilendeger As Integer = Convert.ToInt32(MasaSiparisCMBX.SelectedValue) ' ComboBox'ten seçilen değeri int olarak alınır
        Dim odemeBasarili As Boolean = False ' Ödemenin başarılı olup olmadığını kontrol etmek için bir değişken

        Try
            Con.Open()
            Dim deleteQuery As String = "DELETE FROM SiparisTABLO WHERE MasaNO = @secilendeger"
            Dim deleteCmd As New SqlCommand(deleteQuery, Con)
            deleteCmd.Parameters.AddWithValue("@secilendeger", secilendeger)
            deleteCmd.ExecuteNonQuery()
            odemeBasarili = True ' Ödeme başarılı olduğunda değişkeni true yapın
        Catch ex As Exception
            MessageBox.Show("Satırlar silinirken bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Con.Close()
        End Try

        ' Ödeme başarılıysa ve mesaj daha önce gösterilmediyse mesajı göster
        If odemeBasarili AndAlso Not odemeBasariliGosterildi Then
            MessageBox.Show("Ödeme Başarılı.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            odemeBasariliGosterildi = True ' Mesajın gösterildiğini işaretleyin
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        butunodemeal()
        butunodemesonrasıtemızleme()
    End Sub
    Private Function sütündakitoplamdeger() As Decimal 'sütündakı toplam degerı hesaplayın gerı donuş yapan bir method (print ekranı için)
        Dim sutuntoplam As Decimal = 0
        ' DataGridView'daki 6. sütundaki belirli bir satırdaki toplam değeri hesaplamak için bir döngü kullanıdım.
        For Each row As DataGridViewRow In BillDGV.Rows
            If Not row.IsNewRow Then
                Dim hucredeger As Decimal = 0
                If Decimal.TryParse(row.Cells(5).Value.ToString(), hucredeger) Then
                    ' Hücre değerini toplam değere ekleyin
                    sutuntoplam += hucredeger
                End If
            End If
        Next
        Return sutuntoplam
    End Function

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ' Bağlantıyı açın
        Con.Open()

        ' Tablodaki tüm verileri silmek için SQL sorgusu
        Dim Query As String = "DELETE FROM siparisTABLO"
        Dim cmd As New SqlCommand(Query, Con)
        cmd.ExecuteNonQuery()
        ' Kullanıcı oturumunu sonlandır
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Obj = New ViewOrders
        Obj.Show()
        Me.Hide()
    End Sub



    Private Sub UpdateItem()
        Try
            Dim newQty = stock - Convert.ToInt32(QuantityTB.Text)
            Con.Open()
            Dim Query = "Update ItematTBL set IntQty=" & newQty & "where ItemID=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(Query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Ürün hesaba eklendi")
            Con.Close()
            'Reset()
            DisplayItem()
        Catch ax As Exception
            MsgBox(ax.Message)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Bağlantıyı açın
        Con.Open()

        ' Tablodaki tüm verileri silmek için SQL sorgusu
        Dim Query As String = "DELETE FROM siparisTABLO"
        Dim cmd As New SqlCommand(Query, Con)
        cmd.ExecuteNonQuery()
        ' Kullanıcı oturumunu sonlandır
        Dim obj = New Login
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub AddtoBillBTN_Click(sender As Object, e As EventArgs) Handles AddtoBillBTN.Click
        Dim currentDate As Date = Date.Today
        If key = 0 Then
            MsgBox("Lütfen bir ürün seçimi yapın")
        ElseIf MasaCMBX.SelectedIndex = -1 Or UrunTXB.Text = "" Or QuantityTB.Text = "" Then
            MsgBox("Eksik bilgi girdiniz")
        ElseIf Convert.ToInt32(QuantityTB.Text) > stock Then
            MsgBox("Bu üründen yeteri kadar bulunmamaktadır")
        Else
            ' Fiyatı hesaplayın
            Dim OrderAMT As Integer = Convert.ToInt32(QuantityTB.Text) * Convert.ToInt32(FiyatTXBX.Text)

            Try
                ' Bağlantıyı açın
                Con.Open()

                ' SQL sorgusunu oluşturun ve çalıştırın
                Dim Query As String = "INSERT INTO siparisTABLO (MasaNO, Urun, adet,OrderDate, OrderAMT) VALUES (@MasaNO, @Urun, @adet,@OrderDate, @OrderAMT)"
                Dim cmd As New SqlCommand(Query, Con)
                cmd.Parameters.AddWithValue("@MasaNO", MasaCMBX.SelectedValue.ToString())
                cmd.Parameters.AddWithValue("@Urun", UrunTXB.Text)
                cmd.Parameters.AddWithValue("@adet", QuantityTB.Text)
                cmd.Parameters.AddWithValue("@OrderAMT", OrderAMT)
                cmd.Parameters.AddWithValue("@OrderDate", currentDate)
                cmd.ExecuteNonQuery()
                ' Başarılı mesajı gösterin
                MsgBox("Ürün Eklendi")
            Catch ex As Exception
                ' Hata durumunda hata mesajını gösterin
                MsgBox("Hata: " & ex.Message)
            Finally
                ' Bağlantıyı kapatın
                Con.Close()
            End Try

            ' Formu sıfırlayın ve ürünleri yeniden gösterin
            Reset()
            DisplayItem()
            SiparisGoster()
            key = 0
        End If

    End Sub




    Dim key = 0, stock
    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ProdName = row.Cells(1).Value.ToString
        UrunTXB.Text = row.Cells(1).Value.ToString
        FiyatTXBX.Text = row.Cells(3).Value.ToString

        If ProdName = "" Then
            key = 0
            stock = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            stock = Convert.ToInt32(row.Cells(4).Value.ToString)
            price = (row.Cells(3).Value.ToString)
        End If


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' DataGridView'e sütun başlıklarını ayarlamak için bir liste kullanın
        'Dim columnHeaders As New List(Of String) From {"NO", "Ürün", "Kategori", "fiyat", "Miktar"}
        ' Sütun başlıklarını DataGridView'e ekle
        'For i As Integer = 0 To columnHeaders.Count - 1
        'If i < ItemDGV.Columns.Count Then ' Sütun başlıklarını kontrol etmek için
        'ItemDGV.Columns(i).HeaderText = columnHeaders(i)
        'End If
        'Next
    End Sub

    Private Sub MasaYenileBTN_Click(sender As Object, e As EventArgs) Handles MasaYenileBTN.Click
        SiparisGoster()
    End Sub

    Private Sub MasaSiparisCMBX_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles MasaSiparisCMBX.SelectionChangeCommitted
        FilterbyMASANO()
    End Sub

    Private Sub BillDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles BillDGV.CellMouseClick




    End Sub

    Private Sub parcalıodemeBTN_Click(sender As Object, e As EventArgs) Handles parcalıodemeBTN.Click
        ' Seçilen satırı kontrol et
        If BillDGV.SelectedCells.Count > 0 Then
            ' Seçilen satırın endeksini alın
            Dim selectedRowIndex As Integer = BillDGV.SelectedCells(0).RowIndex

            ' Eğer bir satır seçildiyse devam edin
            If selectedRowIndex >= 0 Then
                ' DataGridView'deki seçili satırı alın
                Dim selectedRow As DataGridViewRow = BillDGV.Rows(selectedRowIndex)

                ' Verileri alın
                Dim veri1 As String = selectedRow.Cells("Urun").Value.ToString()
                Dim veri2 As String = selectedRow.Cells("adet").Value.ToString()
                Dim veri3 As Integer = Convert.ToInt32(selectedRow.Cells("OrderAMT").Value)
                Dim veri4 As Integer = Convert.ToInt32(selectedRow.Cells("adet").Value)
                Dim veri5 As Integer = Convert.ToInt32(selectedRow.Cells("MasaNO").Value)
                Dim veri6 As Integer = Convert.ToInt32(selectedRow.Cells("OrderID").Value)

                ' Yeni formu oluşturun ve verileri aktarın
                Dim odemeal As New odemeal()
                odemeal.UrunisimTB.Text = veri1
                odemeal.siparisadetTB.Text = veri2
                odemeal.toplamfiyat = veri3
                odemeal.adetfiyat = veri4
                odemeal.MasanoTB.Text = veri5
                odemeal.SiparisNOTB.Text = veri6

                odemeal.Show()
            End If
        Else
            MessageBox.Show("Lütfen bir satır seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ' Bağlantıyı açın
            Con.Open

            ' ComboBox'tan seçilen masa numarasını alın
            Dim masaNo = MasaSiparisCMBX.Text

            ' Siparişleri getirmek için sorguyu oluşturun
            Dim query = "SELECT * FROM SiparisTABLO WHERE MasaNO = @MasaNO"

            ' SqlCommand'u oluşturun
            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@MasaNO", masaNo)

            ' SqlDataAdapter ve DataSet'i kullanarak verileri alın
            Dim adapter As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            adapter.Fill(ds)

            ' DataGridView'e verileri bağlayın
            BillDGV.DataSource = ds.Tables(0)
        Catch ex As Exception
            ' Hata durumunda kullanıcıya bilgi verin
            MsgBox("Verileri getirirken bir hata oluştu: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            ' Bağlantıyı kapatın
            Con.Close
        End Try
    End Sub
End Class