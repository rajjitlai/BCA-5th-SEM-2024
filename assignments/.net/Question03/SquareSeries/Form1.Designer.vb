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
        Input = New Label()
        InputBox = New TextBox()
        Generate = New Button()
        ResultLabel = New Label()
        ResultBox = New ListBox()
        SuspendLayout()
        ' 
        ' Input
        ' 
        Input.AutoSize = True
        Input.Location = New Point(393, 169)
        Input.Name = "Input"
        Input.Size = New Size(190, 25)
        Input.TabIndex = 0
        Input.Text = "Enter a number below:"
        ' 
        ' InputBox
        ' 
        InputBox.Location = New Point(393, 208)
        InputBox.Name = "InputBox"
        InputBox.Size = New Size(190, 31)
        InputBox.TabIndex = 1
        ' 
        ' Generate
        ' 
        Generate.Location = New Point(481, 260)
        Generate.Name = "Generate"
        Generate.Size = New Size(102, 36)
        Generate.TabIndex = 2
        Generate.Text = "Result"
        Generate.UseVisualStyleBackColor = True
        ' 
        ' ResultLabel
        ' 
        ResultLabel.AutoSize = True
        ResultLabel.Location = New Point(393, 325)
        ResultLabel.Name = "ResultLabel"
        ResultLabel.Size = New Size(195, 25)
        ResultLabel.TabIndex = 4
        ResultLabel.Text = "The generated series is:"
        ' 
        ' ResultBox
        ' 
        ResultBox.FormattingEnabled = True
        ResultBox.ItemHeight = 23
        ResultBox.Location = New Point(393, 364)
        ResultBox.Name = "ResultBox"
        ResultBox.Size = New Size(190, 211)
        ResultBox.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1029, 690)
        Controls.Add(ResultBox)
        Controls.Add(ResultLabel)
        Controls.Add(Generate)
        Controls.Add(InputBox)
        Controls.Add(Input)
        Font = New Font("Segoe UI", 13F)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Square Series"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Input As Label
    Friend WithEvents InputBox As TextBox
    Friend WithEvents Generate As Button
    Friend WithEvents ResultLabel As Label
    Friend WithEvents ResultBox As ListBox

End Class
