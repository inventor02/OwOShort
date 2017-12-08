<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SettingsLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TokenLabel = New System.Windows.Forms.Label()
        Me.TokenTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BehaviourGroupBox = New System.Windows.Forms.GroupBox()
        Me.AutomaticLinkCopyTextBox = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.BehaviourGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(30, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'SettingsLabel
        '
        Me.SettingsLabel.AutoSize = True
        Me.SettingsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsLabel.Location = New System.Drawing.Point(76, 9)
        Me.SettingsLabel.Name = "SettingsLabel"
        Me.SettingsLabel.Size = New System.Drawing.Size(179, 51)
        Me.SettingsLabel.TabIndex = 1
        Me.SettingsLabel.Text = "Settings"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TokenTextBox)
        Me.GroupBox1.Controls.Add(Me.TokenLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 54)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Credentials"
        '
        'TokenLabel
        '
        Me.TokenLabel.AutoSize = True
        Me.TokenLabel.Location = New System.Drawing.Point(5, 23)
        Me.TokenLabel.Name = "TokenLabel"
        Me.TokenLabel.Size = New System.Drawing.Size(38, 13)
        Me.TokenLabel.TabIndex = 0
        Me.TokenLabel.Text = "Token"
        '
        'TokenTextBox
        '
        Me.TokenTextBox.Location = New System.Drawing.Point(49, 20)
        Me.TokenTextBox.Name = "TokenTextBox"
        Me.TokenTextBox.Size = New System.Drawing.Size(204, 20)
        Me.TokenTextBox.TabIndex = 1
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(197, 175)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 3
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'BehaviourGroupBox
        '
        Me.BehaviourGroupBox.Controls.Add(Me.AutomaticLinkCopyTextBox)
        Me.BehaviourGroupBox.Location = New System.Drawing.Point(13, 123)
        Me.BehaviourGroupBox.Name = "BehaviourGroupBox"
        Me.BehaviourGroupBox.Size = New System.Drawing.Size(259, 46)
        Me.BehaviourGroupBox.TabIndex = 3
        Me.BehaviourGroupBox.TabStop = False
        Me.BehaviourGroupBox.Text = "Behaviour"
        '
        'AutomaticLinkCopyTextBox
        '
        Me.AutomaticLinkCopyTextBox.AutoSize = True
        Me.AutomaticLinkCopyTextBox.Location = New System.Drawing.Point(17, 20)
        Me.AutomaticLinkCopyTextBox.Name = "AutomaticLinkCopyTextBox"
        Me.AutomaticLinkCopyTextBox.Size = New System.Drawing.Size(183, 17)
        Me.AutomaticLinkCopyTextBox.TabIndex = 0
        Me.AutomaticLinkCopyTextBox.Text = "Automatically copy shortened link"
        Me.AutomaticLinkCopyTextBox.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 206)
        Me.Controls.Add(Me.BehaviourGroupBox)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SettingsLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsForm"
        Me.Text = "Settings"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.BehaviourGroupBox.ResumeLayout(False)
        Me.BehaviourGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SettingsLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TokenTextBox As TextBox
    Friend WithEvents TokenLabel As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents BehaviourGroupBox As GroupBox
    Friend WithEvents AutomaticLinkCopyTextBox As CheckBox
End Class
