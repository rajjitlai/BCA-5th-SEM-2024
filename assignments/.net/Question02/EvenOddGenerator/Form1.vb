Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles EvenGen.Click
        EvenRes.Items.Clear()
        Dim a As Integer
        a = 2
        For x As Integer = 1 To Val(InputBox.Text)
            EvenRes.Items.Add(a)
            a = a + 2
        Next
    End Sub

    Private Sub InputBox_TextChanged(sender As Object, e As EventArgs) Handles InputBox.TextChanged

    End Sub

    Private Sub OddGen_Click(sender As Object, e As EventArgs) Handles OddGen.Click
        OddRes.Items.Clear()
        Dim b As Integer
        b = 1
        For y As Integer = 1 To Val(InputBox.Text)
            OddRes.Items.Add(b)
            b = b + 2
        Next
    End Sub
End Class
