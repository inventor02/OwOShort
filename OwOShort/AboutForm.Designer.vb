<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Me.ShortLabel = New System.Windows.Forms.Label()
        Me.OwOLabel = New System.Windows.Forms.Label()
        Me.AttributionLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.LicenseLabel = New System.Windows.Forms.Label()
        Me.RepoLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'ShortLabel
        '
        Me.ShortLabel.AutoSize = True
        Me.ShortLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShortLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ShortLabel.Location = New System.Drawing.Point(135, 10)
        Me.ShortLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ShortLabel.Name = "ShortLabel"
        Me.ShortLabel.Size = New System.Drawing.Size(130, 51)
        Me.ShortLabel.TabIndex = 3
        Me.ShortLabel.Text = "Short"
        '
        'OwOLabel
        '
        Me.OwOLabel.AutoSize = True
        Me.OwOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OwOLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.OwOLabel.Location = New System.Drawing.Point(19, 10)
        Me.OwOLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.OwOLabel.Name = "OwOLabel"
        Me.OwOLabel.Size = New System.Drawing.Size(122, 51)
        Me.OwOLabel.TabIndex = 2
        Me.OwOLabel.Text = "OwO"
        '
        'AttributionLinkLabel
        '
        Me.AttributionLinkLabel.AutoSize = True
        Me.AttributionLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.AttributionLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.AttributionLinkLabel.Location = New System.Drawing.Point(93, 61)
        Me.AttributionLinkLabel.Name = "AttributionLinkLabel"
        Me.AttributionLinkLabel.Size = New System.Drawing.Size(99, 13)
        Me.AttributionLinkLabel.TabIndex = 4
        Me.AttributionLinkLabel.TabStop = True
        Me.AttributionLinkLabel.Text = "by George Peppard"
        Me.AttributionLinkLabel.VisitedLinkColor = System.Drawing.Color.Black
        '
        'LicenseLabel
        '
        Me.LicenseLabel.AutoSize = True
        Me.LicenseLabel.Location = New System.Drawing.Point(59, 84)
        Me.LicenseLabel.Name = "LicenseLabel"
        Me.LicenseLabel.Size = New System.Drawing.Size(167, 13)
        Me.LicenseLabel.TabIndex = 5
        Me.LicenseLabel.Text = "Licensed under the GNU GPL-3.0"
        '
        'RepoLinkLabel
        '
        Me.RepoLinkLabel.AutoSize = True
        Me.RepoLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.RepoLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.RepoLinkLabel.Location = New System.Drawing.Point(122, 107)
        Me.RepoLinkLabel.Name = "RepoLinkLabel"
        Me.RepoLinkLabel.Size = New System.Drawing.Size(40, 13)
        Me.RepoLinkLabel.TabIndex = 6
        Me.RepoLinkLabel.TabStop = True
        Me.RepoLinkLabel.Text = "GitHub"
        Me.RepoLinkLabel.VisitedLinkColor = System.Drawing.Color.Black
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 130)
        Me.Controls.Add(Me.RepoLinkLabel)
        Me.Controls.Add(Me.LicenseLabel)
        Me.Controls.Add(Me.AttributionLinkLabel)
        Me.Controls.Add(Me.ShortLabel)
        Me.Controls.Add(Me.OwOLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutForm"
        Me.Text = "About OwOShort"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ShortLabel As Label
    Friend WithEvents OwOLabel As Label
    Friend WithEvents AttributionLinkLabel As LinkLabel
    Friend WithEvents LicenseLabel As Label
    Friend WithEvents RepoLinkLabel As LinkLabel
End Class
