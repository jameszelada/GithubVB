Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim variable As String = "Jaime"
        MessageBox.Show("I'm just trying this shit "+variable)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim variable As String = "Jaime"
        MessageBox.Show("Another Change " + variable)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        Dim variable As String = "Jaime"
        MessageBox.Show("The last change " + variable)
    End Sub
End Class
