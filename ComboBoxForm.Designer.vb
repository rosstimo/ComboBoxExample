<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComboBoxForm
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
        Me.components = New System.ComponentModel.Container()
        Me.MainComboBox = New System.Windows.Forms.ComboBox()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainComboBox
        '
        Me.MainComboBox.FormattingEnabled = True
        Me.MainComboBox.Location = New System.Drawing.Point(390, 43)
        Me.MainComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MainComboBox.Name = "MainComboBox"
        Me.MainComboBox.Size = New System.Drawing.Size(338, 28)
        Me.MainComboBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.MainComboBox, "Select an item to crash the program!")
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(22, 144)
        Me.GoButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(200, 145)
        Me.GoButton.TabIndex = 1
        Me.GoButton.Text = "Go"
        Me.ToolTip1.SetToolTip(Me.GoButton, "Click here todo stuff!!!")
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(128, 45)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(242, 26)
        Me.NameTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.NameTextBox, "Enter fake text here!")
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(128, 85)
        Me.AgeTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(242, 26)
        Me.AgeTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.AgeTextBox, "and also here.....")
        '
        'NameLabel
        '
        Me.NameLabel.Location = New System.Drawing.Point(18, 43)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(60, 32)
        Me.NameLabel.TabIndex = 4
        Me.NameLabel.Text = "Name"
        '
        'AgeLabel
        '
        Me.AgeLabel.Location = New System.Drawing.Point(18, 85)
        Me.AgeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(60, 31)
        Me.AgeLabel.TabIndex = 5
        Me.AgeLabel.Text = "Age"
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(230, 144)
        Me.RemoveButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(171, 145)
        Me.RemoveButton.TabIndex = 6
        Me.RemoveButton.Text = "Remove"
        Me.ToolTip1.SetToolTip(Me.RemoveButton, "Click here to see how buggy the really is!")
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(33, 33)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(488, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(199, 193)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(33, 63)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(33, 94)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(133, 24)
        Me.RadioButton3.TabIndex = 1
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'ComboBoxForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 303)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.AgeLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.MainComboBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ComboBoxForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Combo Box!"
        Me.ToolTip1.SetToolTip(Me, "This is the Form!!!")
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainComboBox As ComboBox
    Friend WithEvents GoButton As Button
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents AgeLabel As Label
    Friend WithEvents RemoveButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
