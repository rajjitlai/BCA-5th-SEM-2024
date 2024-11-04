Public Class Form1
    Private Sub Input_Click(sender As Object, e As EventArgs) Handles Input.Click

    End Sub

    Private Sub SquareSeries_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Generate_Click(sender As Object, e As EventArgs) Handles Generate.Click
        ResultBox.Items.Clear()
        For i As Integer = 1 To Val(InputBox.Text)
            ResultBox.Items.Add(i * i)
        Next
    End Sub

    Private Sub InputBox_TextChanged(sender As Object, e As EventArgs) Handles InputBox.TextChanged

    End Sub

    Private Sub ResultBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ResultBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ResultBox.SelectedIndexChanged

    End Sub
End Class
