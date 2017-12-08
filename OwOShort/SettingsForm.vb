Public Class SettingsForm
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If Not System.Text.RegularExpressions.Regex.IsMatch(TokenTextBox.Text, "[a-f0-9]{8}-?[a-f0-9]{4}-?[1-5][a-f0-9]{3}-?[89ab][a-f0-9]{3}-?[a-f0-9]{12}") Then
            MessageBox.Show("This doesn't look like a valid token.", "Invalid token", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        My.Settings.Token = TokenTextBox.Text
        My.Settings.AutomaticallyCopyLink = AutomaticLinkCopyTextBox.Checked
        My.Settings.Save()

        Close()
    End Sub

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TokenTextBox.Text = My.Settings.Token
        AutomaticLinkCopyTextBox.Checked = My.Settings.AutomaticallyCopyLink
    End Sub
End Class