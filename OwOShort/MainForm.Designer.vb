<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.OwOLabel = New System.Windows.Forms.Label()
        Me.ShortLabel = New System.Windows.Forms.Label()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.OutputLinkTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CopyButton = New System.Windows.Forms.Button()
        Me.InfoButton = New System.Windows.Forms.Button()
        Me.InputGroupBox.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'OwOLabel
        '
        Me.OwOLabel.AutoSize = True
        Me.OwOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OwOLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.OwOLabel.Location = New System.Drawing.Point(19, 9)
        Me.OwOLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.OwOLabel.Name = "OwOLabel"
        Me.OwOLabel.Size = New System.Drawing.Size(122, 51)
        Me.OwOLabel.TabIndex = 0
        Me.OwOLabel.Text = "OwO"
        '
        'ShortLabel
        '
        Me.ShortLabel.AutoSize = True
        Me.ShortLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShortLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ShortLabel.Location = New System.Drawing.Point(135, 9)
        Me.ShortLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ShortLabel.Name = "ShortLabel"
        Me.ShortLabel.Size = New System.Drawing.Size(130, 51)
        Me.ShortLabel.TabIndex = 1
        Me.ShortLabel.Text = "Short"
        '
        'SettingsButton
        '
        Me.SettingsButton.BackgroundImage = CType(resources.GetObject("SettingsButton.BackgroundImage"), System.Drawing.Image)
        Me.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SettingsButton.Location = New System.Drawing.Point(12, 204)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(23, 23)
        Me.SettingsButton.TabIndex = 2
        Me.SettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.Label1)
        Me.InputGroupBox.Controls.Add(Me.LinkTextBox)
        Me.InputGroupBox.Controls.Add(Me.GroupBox1)
        Me.InputGroupBox.Location = New System.Drawing.Point(12, 63)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Size = New System.Drawing.Size(260, 51)
        Me.InputGroupBox.TabIndex = 3
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Input"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Link"
        '
        'LinkTextBox
        '
        Me.LinkTextBox.Location = New System.Drawing.Point(42, 19)
        Me.LinkTextBox.Name = "LinkTextBox"
        Me.LinkTextBox.Size = New System.Drawing.Size(211, 20)
        Me.LinkTextBox.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(0, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 79)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.CopyButton)
        Me.OutputGroupBox.Controls.Add(Me.Label2)
        Me.OutputGroupBox.Controls.Add(Me.OutputLinkTextBox)
        Me.OutputGroupBox.Location = New System.Drawing.Point(12, 120)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Size = New System.Drawing.Size(260, 79)
        Me.OutputGroupBox.TabIndex = 5
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Output"
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(197, 204)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(75, 23)
        Me.GoButton.TabIndex = 6
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'OutputLinkTextBox
        '
        Me.OutputLinkTextBox.Enabled = False
        Me.OutputLinkTextBox.Location = New System.Drawing.Point(42, 19)
        Me.OutputLinkTextBox.Name = "OutputLinkTextBox"
        Me.OutputLinkTextBox.Size = New System.Drawing.Size(211, 20)
        Me.OutputLinkTextBox.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Link"
        '
        'CopyButton
        '
        Me.CopyButton.Location = New System.Drawing.Point(179, 45)
        Me.CopyButton.Name = "CopyButton"
        Me.CopyButton.Size = New System.Drawing.Size(75, 23)
        Me.CopyButton.TabIndex = 8
        Me.CopyButton.Text = "Copy"
        Me.CopyButton.UseVisualStyleBackColor = True
        '
        'InfoButton
        '
        Me.InfoButton.BackgroundImage = CType(resources.GetObject("InfoButton.BackgroundImage"), System.Drawing.Image)
        Me.InfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.InfoButton.Location = New System.Drawing.Point(41, 204)
        Me.InfoButton.Name = "InfoButton"
        Me.InfoButton.Size = New System.Drawing.Size(23, 23)
        Me.InfoButton.TabIndex = 7
        Me.InfoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.InfoButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.GoButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 236)
        Me.Controls.Add(Me.InfoButton)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Controls.Add(Me.SettingsButton)
        Me.Controls.Add(Me.ShortLabel)
        Me.Controls.Add(Me.OwOLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "OwOShort"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        Me.OutputGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OwOLabel As Label
    Friend WithEvents ShortLabel As Label
    Friend WithEvents SettingsButton As Button
    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents GoButton As Button
    Friend WithEvents CopyButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents OutputLinkTextBox As TextBox
    Friend WithEvents InfoButton As Button
End Class
