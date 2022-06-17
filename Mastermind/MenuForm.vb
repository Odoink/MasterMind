Public Class MenuForm
    Private form1 As Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        form1 = New Form1(CheckBox2.Checked)
        form1.Show()
        Hide()

    End Sub
End Class