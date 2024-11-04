<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        FirstLabel = New Label()
        SecLabel = New Label()
        FirstInp = New TextBox()
        SecInp = New TextBox()
        OpLabel = New Label()
        Sum = New Button()
        Diff = New Button()
        Mul = New Button()
        Div = New Button()
        Pow = New Button()
        ResultLabel = New Label()
        ResultBox = New TextBox()
        Clear = New Button()
        SuspendLayout()
        ' 
        ' FirstLabel
        ' 
        FirstLabel.AutoSize = True
        FirstLabel.Location = New Point(119, 230)
        FirstLabel.Name = "FirstLabel"
        FirstLabel.Size = New Size(119, 25)
        FirstLabel.TabIndex = 0
        FirstLabel.Text = "First Number:"
        ' 
        ' SecLabel
        ' 
        SecLabel.AutoSize = True
        SecLabel.Location = New Point(508, 230)
        SecLabel.Name = "SecLabel"
        SecLabel.Size = New Size(145, 25)
        SecLabel.TabIndex = 1
        SecLabel.Text = "Second Number:"
        ' 
        ' FirstInp
        ' 
        FirstInp.Location = New Point(244, 230)
        FirstInp.Name = "FirstInp"
        FirstInp.Size = New Size(211, 31)
        FirstInp.TabIndex = 2
        ' 
        ' SecInp
        ' 
        SecInp.Location = New Point(659, 230)
        SecInp.Name = "SecInp"
        SecInp.Size = New Size(211, 31)
        SecInp.TabIndex = 3
        ' 
        ' OpLabel
        ' 
        OpLabel.AutoSize = True
        OpLabel.Location = New Point(119, 315)
        OpLabel.Name = "OpLabel"
        OpLabel.Size = New Size(168, 25)
        OpLabel.TabIndex = 4
        OpLabel.Text = "Select an operation:"
        ' 
        ' Sum
        ' 
        Sum.Font = New Font("Segoe UI", 10F)
        Sum.Location = New Point(306, 314)
        Sum.Name = "Sum"
        Sum.Size = New Size(65, 31)
        Sum.TabIndex = 5
        Sum.Text = "+"
        Sum.UseVisualStyleBackColor = True
        ' 
        ' Diff
        ' 
        Diff.Font = New Font("Segoe UI", 10F)
        Diff.Location = New Point(403, 315)
        Diff.Name = "Diff"
        Diff.Size = New Size(65, 31)
        Diff.TabIndex = 6
        Diff.Text = "-"
        Diff.UseVisualStyleBackColor = True
        ' 
        ' Mul
        ' 
        Mul.Font = New Font("Segoe UI", 10F)
        Mul.Location = New Point(504, 315)
        Mul.Name = "Mul"
        Mul.Size = New Size(65, 31)
        Mul.TabIndex = 7
        Mul.Text = "*"
        Mul.UseVisualStyleBackColor = True
        ' 
        ' Div
        ' 
        Div.Font = New Font("Segoe UI", 10F)
        Div.Location = New Point(608, 314)
        Div.Name = "Div"
        Div.Size = New Size(65, 31)
        Div.TabIndex = 8
        Div.Text = "/"
        Div.UseVisualStyleBackColor = True
        ' 
        ' Pow
        ' 
        Pow.Font = New Font("Segoe UI", 10F)
        Pow.Location = New Point(706, 315)
        Pow.Name = "Pow"
        Pow.Size = New Size(65, 31)
        Pow.TabIndex = 9
        Pow.Text = "^"
        Pow.UseVisualStyleBackColor = True
        ' 
        ' ResultLabel
        ' 
        ResultLabel.AutoSize = True
        ResultLabel.Location = New Point(287, 404)
        ResultLabel.Name = "ResultLabel"
        ResultLabel.Size = New Size(63, 25)
        ResultLabel.TabIndex = 10
        ResultLabel.Text = "Result:"
        ' 
        ' ResultBox
        ' 
        ResultBox.Location = New Point(356, 401)
        ResultBox.Name = "ResultBox"
        ResultBox.Size = New Size(267, 31)
        ResultBox.TabIndex = 11
        ' 
        ' Clear
        ' 
        Clear.Font = New Font("Segoe UI", 10F)
        Clear.Location = New Point(657, 401)
        Clear.Name = "Clear"
        Clear.Size = New Size(75, 31)
        Clear.TabIndex = 12
        Clear.Text = "Clear"
        Clear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(1029, 690)
        Controls.Add(Clear)
        Controls.Add(ResultBox)
        Controls.Add(ResultLabel)
        Controls.Add(Pow)
        Controls.Add(Div)
        Controls.Add(Mul)
        Controls.Add(Diff)
        Controls.Add(Sum)
        Controls.Add(OpLabel)
        Controls.Add(SecInp)
        Controls.Add(FirstInp)
        Controls.Add(SecLabel)
        Controls.Add(FirstLabel)
        Font = New Font("Segoe UI", 13F)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents FirstLabel As Label
    Friend WithEvents SecLabel As Label
    Friend WithEvents FirstInp As TextBox
    Friend WithEvents SecInp As TextBox
    Friend WithEvents OpLabel As Label
    Friend WithEvents Sum As Button
    Friend WithEvents Diff As Button
    Friend WithEvents Mul As Button
    Friend WithEvents Div As Button
    Friend WithEvents Pow As Button
    Friend WithEvents ResultLabel As Label
    Friend WithEvents ResultBox As TextBox
    Friend WithEvents Clear As Button

End Class
