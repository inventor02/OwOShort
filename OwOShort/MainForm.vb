Imports RestSharp
Imports System.Net
Imports Squirrel
Imports System.Reflection

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActiveControl = LinkTextBox
        UpdateApp()
    End Sub

    Private Async Sub UpdateApp()
        Dim versionNumber As Version = Assembly.GetExecutingAssembly().GetName().Version
        Dim mgr As UpdateManager = New UpdateManager("https://nuts.owoshort.georgepeppard.me/update/win32/" & versionNumber.ToString())
        Await mgr.UpdateApp()
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        If My.Settings.Token = "" Then
            MessageBox.Show("You don't have a token set. Please enter it in settings.", "No token set!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            Console.WriteLine("Token: " & My.Settings.Token)
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(LinkTextBox.Text, "https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)") Then
            MessageBox.Show("This doesn't look like a valid URL.", "Invalid URL", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Shorten()
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        Dim settingsForm As SettingsForm = New SettingsForm()
        settingsForm.Show()
    End Sub

    Sub Shorten()
        Dim client As RestClient = New RestClient("https://api.awau.moe")

        Dim token As String = WebUtility.UrlEncode(My.Settings.Token)
        Dim url As String = WebUtility.UrlEncode(LinkTextBox.Text)

        Dim request As RestRequest = New RestRequest("shorten/polr?action=shorten&apikey={token}&url={url}", Method.GET)
        request.AddUrlSegment("token", token)
        request.AddUrlSegment("url", LinkTextBox.Text)

        Console.WriteLine("Request URL: " & request.Resource)

        Dim response As IRestResponse = client.Execute(request)

        Console.WriteLine("Response: " & response.Content)

        If Not response.StatusCode = 200 Then
            Console.WriteLine(response.Content)
        Else
            OutputLinkTextBox.Text = response.Content
        End If

        If My.Settings.AutomaticallyCopyLink Then
            CopyLinkFromTextBox()
        End If
    End Sub

    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        CopyLinkFromTextBox()
    End Sub

    Private Sub InfoButton_Click(sender As Object, e As EventArgs) Handles InfoButton.Click
        Dim aboutForm As AboutForm = New AboutForm()
        aboutForm.Show()
    End Sub

    Sub CopyLinkFromTextBox()
        Clipboard.SetText(OutputLinkTextBox.Text)
    End Sub
End Class
