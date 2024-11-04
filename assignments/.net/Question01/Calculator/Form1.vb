Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles FirstInp.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles ResultLabel.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles ResultBox.TextChanged

    End Sub

    Private Sub SecInp_TextChanged(sender As Object, e As EventArgs) Handles SecInp.TextChanged

    End Sub

    Private Sub Sum_Click(sender As Object, e As EventArgs) Handles Sum.Click
        ResultBox.Text = Val(FirstInp.Text) + Val(SecInp.Text)
    End Sub

    Private Sub Diff_Click(sender As Object, e As EventArgs) Handles Diff.Click
        ResultBox.Text = Val(FirstInp.Text) - Val(SecInp.Text)
    End Sub

    Private Sub Mul_Click(sender As Object, e As EventArgs) Handles Mul.Click
        ResultBox.Text = Val(FirstInp.Text) * Val(SecInp.Text)
    End Sub

    Private Sub Div_Click(sender As Object, e As EventArgs) Handles Div.Click
        ResultBox.Text = Val(FirstInp.Text) / Val(SecInp.Text)
    End Sub

    Private Sub Pow_Click(sender As Object, e As EventArgs) Handles Pow.Click
        ResultBox.Text = Val(FirstInp.Text) ^ Val(SecInp.Text)
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        ResultBox.Clear()
        FirstInp.Clear()
        SecInp.Clear()
    End Sub
End Class
