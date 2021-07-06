Public Class Encrypter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = TripleDES_Encrypt(TextBox1.Text, TextBox2.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox3.Text = TripleDES_Decrypt(TextBox1.Text, TextBox2.Text)

    End Sub

    Private Sub Encrypter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class