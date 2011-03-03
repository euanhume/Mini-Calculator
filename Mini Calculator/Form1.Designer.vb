<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mini_Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_FirstNumber = New System.Windows.Forms.TextBox()
        Me.txt_SecondNumber = New System.Windows.Forms.TextBox()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Btn_Subtract = New System.Windows.Forms.Button()
        Me.Btn_Multiplied = New System.Windows.Forms.Button()
        Me.Btn_Divded = New System.Windows.Forms.Button()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.lbl_Operator = New System.Windows.Forms.Label()
        Me.Equals = New System.Windows.Forms.Label()
        Me.lbl_Result = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter two whole numbers."
        '
        'txt_FirstNumber
        '
        Me.txt_FirstNumber.Location = New System.Drawing.Point(22, 43)
        Me.txt_FirstNumber.Name = "txt_FirstNumber"
        Me.txt_FirstNumber.Size = New System.Drawing.Size(102, 20)
        Me.txt_FirstNumber.TabIndex = 1
        '
        'txt_SecondNumber
        '
        Me.txt_SecondNumber.Location = New System.Drawing.Point(169, 43)
        Me.txt_SecondNumber.Name = "txt_SecondNumber"
        Me.txt_SecondNumber.Size = New System.Drawing.Size(102, 20)
        Me.txt_SecondNumber.TabIndex = 2
        '
        'Btn_Add
        '
        Me.Btn_Add.Location = New System.Drawing.Point(23, 79)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(74, 27)
        Me.Btn_Add.TabIndex = 3
        Me.Btn_Add.Text = "+"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Btn_Subtract
        '
        Me.Btn_Subtract.Location = New System.Drawing.Point(104, 79)
        Me.Btn_Subtract.Name = "Btn_Subtract"
        Me.Btn_Subtract.Size = New System.Drawing.Size(74, 27)
        Me.Btn_Subtract.TabIndex = 4
        Me.Btn_Subtract.Text = "-"
        Me.Btn_Subtract.UseVisualStyleBackColor = True
        '
        'Btn_Multiplied
        '
        Me.Btn_Multiplied.Location = New System.Drawing.Point(184, 79)
        Me.Btn_Multiplied.Name = "Btn_Multiplied"
        Me.Btn_Multiplied.Size = New System.Drawing.Size(74, 27)
        Me.Btn_Multiplied.TabIndex = 5
        Me.Btn_Multiplied.Text = "x"
        Me.Btn_Multiplied.UseVisualStyleBackColor = True
        '
        'Btn_Divded
        '
        Me.Btn_Divded.Location = New System.Drawing.Point(264, 79)
        Me.Btn_Divded.Name = "Btn_Divded"
        Me.Btn_Divded.Size = New System.Drawing.Size(74, 27)
        Me.Btn_Divded.TabIndex = 6
        Me.Btn_Divded.Text = "%"
        Me.Btn_Divded.UseVisualStyleBackColor = True
        '
        'Btn_Clear
        '
        Me.Btn_Clear.Location = New System.Drawing.Point(104, 112)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(154, 27)
        Me.Btn_Clear.TabIndex = 7
        Me.Btn_Clear.Text = "Clear"
        Me.Btn_Clear.UseVisualStyleBackColor = True
        '
        'lbl_Operator
        '
        Me.lbl_Operator.AutoSize = True
        Me.lbl_Operator.Location = New System.Drawing.Point(142, 46)
        Me.lbl_Operator.Name = "lbl_Operator"
        Me.lbl_Operator.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Operator.TabIndex = 8
        '
        'Equals
        '
        Me.Equals.AutoSize = True
        Me.Equals.Location = New System.Drawing.Point(281, 46)
        Me.Equals.Name = "Equals"
        Me.Equals.Size = New System.Drawing.Size(13, 13)
        Me.Equals.TabIndex = 9
        Me.Equals.Text = "="
        '
        'lbl_Result
        '
        Me.lbl_Result.AutoSize = True
        Me.lbl_Result.Location = New System.Drawing.Point(299, 44)
        Me.lbl_Result.Name = "lbl_Result"
        Me.lbl_Result.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Result.TabIndex = 10
        '
        'Mini_Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 260)
        Me.Controls.Add(Me.lbl_Result)
        Me.Controls.Add(Me.Equals)
        Me.Controls.Add(Me.lbl_Operator)
        Me.Controls.Add(Me.Btn_Clear)
        Me.Controls.Add(Me.Btn_Divded)
        Me.Controls.Add(Me.Btn_Multiplied)
        Me.Controls.Add(Me.Btn_Subtract)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.txt_SecondNumber)
        Me.Controls.Add(Me.txt_FirstNumber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Mini_Calculator"
        Me.Text = "Mini Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_FirstNumber As System.Windows.Forms.TextBox
    Friend WithEvents txt_SecondNumber As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Add As System.Windows.Forms.Button
    Friend WithEvents Btn_Subtract As System.Windows.Forms.Button
    Friend WithEvents Btn_Multiplied As System.Windows.Forms.Button
    Friend WithEvents Btn_Divded As System.Windows.Forms.Button
    Friend WithEvents Btn_Clear As System.Windows.Forms.Button
    Friend WithEvents lbl_Operator As System.Windows.Forms.Label
    Friend WithEvents Equals As System.Windows.Forms.Label
    Friend WithEvents lbl_Result As System.Windows.Forms.Label

End Class
