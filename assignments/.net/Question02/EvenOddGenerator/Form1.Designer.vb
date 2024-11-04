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
        InputLabel = New Label()
        InputBox = New TextBox()
        EvenRes = New ListBox()
        EvenGen = New Button()
        OddRes = New ListBox()
        OddGen = New Button()
        SuspendLayout()
        ' 
        ' InputLabel
        ' 
        InputLabel.AutoSize = True
        InputLabel.Location = New Point(337, 120)
        InputLabel.Name = "InputLabel"
        InputLabel.Size = New Size(140, 25)
        InputLabel.TabIndex = 0
        InputLabel.Text = "Enter a Number:"
        ' 
        ' InputBox
        ' 
        InputBox.Location = New Point(483, 117)
        InputBox.Name = "InputBox"
        InputBox.Size = New Size(236, 31)
        InputBox.TabIndex = 1
        ' 
        ' EvenRes
        ' 
        EvenRes.FormattingEnabled = True
        EvenRes.ItemHeight = 23
        EvenRes.Location = New Point(337, 268)
        EvenRes.Name = "EvenRes"
        EvenRes.Size = New Size(181, 234)
        EvenRes.TabIndex = 2
        ' 
        ' EvenGen
        ' 
        EvenGen.Location = New Point(337, 185)
        EvenGen.Name = "EvenGen"
        EvenGen.Size = New Size(181, 39)
        EvenGen.TabIndex = 4
        EvenGen.Text = "Generate Even Nos."
        EvenGen.UseVisualStyleBackColor = True
        ' 
        ' OddRes
        ' 
        OddRes.FormattingEnabled = True
        OddRes.ItemHeight = 23
        OddRes.Location = New Point(538, 268)
        OddRes.Name = "OddRes"
        OddRes.Size = New Size(181, 234)
        OddRes.TabIndex = 5
        ' 
        ' OddGen
        ' 
        OddGen.Location = New Point(538, 185)
        OddGen.Name = "OddGen"
        OddGen.Size = New Size(181, 39)
        OddGen.TabIndex = 6
        OddGen.Text = "Generate Odd Nos."
        OddGen.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1029, 690)
        Controls.Add(OddGen)
        Controls.Add(OddRes)
        Controls.Add(EvenGen)
        Controls.Add(EvenRes)
        Controls.Add(InputBox)
        Controls.Add(InputLabel)
        Font = New Font("Segoe UI", 13F)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Even Odd Generator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents InputLabel As Label
    Friend WithEvents InputBox As TextBox
    Friend WithEvents EvenRes As ListBox
    Friend WithEvents EvenGen As Button
    Friend WithEvents OddRes As ListBox
    Friend WithEvents OddGen As Button

End Class
