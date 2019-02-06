Imports System.IO

Public Class Form1
    Dim path As String
    Dim sw As StreamWriter
    Private Sub FlatStatusBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatStatusBar1.Click

    End Sub

    Private Sub FlatLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatLabel1.Click

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click
        path = "C:\Windows\System32\drivers\etc\hosts"
        sw = New StreamWriter(path, True)
        Dim sitetoblock As String = (Environment.NewLine & "127.0.0.1 " & "adclick.g.doublecklick.net") 'has to be www.google.com | NOT: http://www.google.com/
        Dim sitetoblock1 As String = (Environment.NewLine & "127.0.0.1 " & "adeventtracker.spotify.com") 'has to be www.google.com | NOT: http://www.google.com/
        sw.Write(sitetoblock)
        sw.Write(sitetoblock1)
        sw.Close()
        MessageBox.Show("Site Blocked")
    End Sub
End Class
