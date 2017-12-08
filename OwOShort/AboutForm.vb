Public Class AboutForm
    Private Sub AttributionLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AttributionLinkLabel.LinkClicked
        Process.Start("https://georgepeppard.me/")
    End Sub

    Private Sub RepoLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RepoLinkLabel.LinkClicked
        Process.Start("https://github.com/inventor02/OwOShort")
    End Sub
End Class