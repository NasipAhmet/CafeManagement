Public Class Login



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UnameTb.Text = "" Or PasswordTb.Text = "" Then
            MsgBox("Kullanıcı Adı ve şifre giriniz")
        ElseIf UnameTb.Text = "Admin" And PasswordTb.Text = "123" Then
            Dim obj = New Items
            obj.Show()
            Me.Hide()

        Else
            MsgBox("Yanlış Kullanıcı adı veya şifre girdiniz")
            UnameTb.Text = ""
            PasswordTb.Text = ""
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles SatıcıLabel.Click
        Dim obj = New Orders
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()


    End Sub

    Private Sub UnameTb_TextChanged(sender As Object, e As EventArgs) Handles UnameTb.TextChanged

    End Sub
End Class
