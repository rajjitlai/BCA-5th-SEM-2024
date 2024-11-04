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
        TypeInfo = New Label()
        Number = New TextBox()
        ResultBox = New TextBox()
        Result = New Label()
        StepsBox = New RichTextBox()
        StepLabel = New Label()
        Calculate = New Button()
        SuspendLayout()
        ' 
        ' TypeInfo
        ' 
        TypeInfo.AutoSize = True
        TypeInfo.Location = New Point(154, 263)
        TypeInfo.Margin = New Padding(4, 0, 4, 0)
        TypeInfo.Name = "TypeInfo"
        TypeInfo.Size = New Size(376, 25)
        TypeInfo.TabIndex = 0
        TypeInfo.Text = "Type a number below to compute its factorial:"
        ' 
        ' Number
        ' 
        Number.Location = New Point(154, 315)
        Number.Margin = New Padding(4, 5, 4, 5)
        Number.Name = "Number"
        Number.Size = New Size(252, 31)
        Number.TabIndex = 1
        ' 
        ' ResultBox
        ' 
        ResultBox.Location = New Point(241, 376)
        ResultBox.Margin = New Padding(4, 5, 4, 5)
        ResultBox.Name = "ResultBox"
        ResultBox.Size = New Size(289, 31)
        ResultBox.TabIndex = 3
        ' 
        ' Result
        ' 
        Result.AutoSize = True
        Result.Location = New Point(152, 379)
        Result.Margin = New Padding(4, 0, 4, 0)
        Result.Name = "Result"
        Result.Size = New Size(81, 25)
        Result.TabIndex = 2
        Result.Text = "Factorial:"
        ' 
        ' StepsBox
        ' 
        StepsBox.Location = New Point(612, 185)
        StepsBox.Name = "StepsBox"
        StepsBox.Size = New Size(264, 325)
        StepsBox.TabIndex = 4
        StepsBox.Text = ""
        ' 
        ' StepLabel
        ' 
        StepLabel.AutoSize = True
        StepLabel.Location = New Point(612, 157)
        StepLabel.Name = "StepLabel"
        StepLabel.Size = New Size(59, 25)
        StepLabel.TabIndex = 5
        StepLabel.Text = "Steps:"
        ' 
        ' Calculate
        ' 
        Calculate.Font = New Font("Segoe UI", 13F)
        Calculate.ForeColor = SystemColors.InactiveCaptionText
        Calculate.Location = New Point(413, 308)
        Calculate.Name = "Calculate"
        Calculate.Size = New Size(119, 44)
        Calculate.TabIndex = 6
        Calculate.Text = "Calculate"
        Calculate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlText
        ClientSize = New Size(1028, 690)
        Controls.Add(Calculate)
        Controls.Add(StepLabel)
        Controls.Add(StepsBox)
        Controls.Add(ResultBox)
        Controls.Add(Result)
        Controls.Add(Number)
        Controls.Add(TypeInfo)
        Font = New Font("Segoe UI", 13F)
        ForeColor = SystemColors.ButtonHighlight
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Factorial"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TypeInfo As Label
    Friend WithEvents Number As TextBox
    Friend WithEvents ResultBox As TextBox
    Friend WithEvents Result As Label
    Friend WithEvents StepsBox As RichTextBox
    Friend WithEvents StepLabel As Label
    Friend WithEvents Calculate As Button

End Class
