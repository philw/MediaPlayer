Public Class MainForm
    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click

        AxWindowsMediaPlayer1.URL = "C:\Users\Phil\Dropbox\strode\_A_LEVEL_CS\A2Projects\midi\teddybear.mid"

    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click

        AxWindowsMediaPlayer1.Ctlcontrols.stop()

    End Sub
End Class
