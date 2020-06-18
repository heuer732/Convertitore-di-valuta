Public Class Cconverter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub B1_Risultato_Click(sender As Object, e As EventArgs) Handles B1_Result.Click
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)

    End Sub

    Private Sub B2_Cancellare_Click(sender As Object, e As EventArgs) Handles B2_Clear.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
End Class