
Public Class Form1
    Dim URLsVisited As New Collection()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        URLsVisited.Add(TextBox1.Text)
        System.Diagnostics.Process.Start(TextBox1.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim URLName As String = "", AllURLs As String = ""
        For Each URLName In URLsVisited
            AllURLs = AllURLs & URLName & vbCrLf
        Next URLName
        MsgBox(AllURLs, MsgBoxStyle.Information, "Web sites visited")
    End Sub
End Class
