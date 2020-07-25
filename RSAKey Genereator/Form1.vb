Imports System.Security.Cryptography

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RSA As New RSACryptoServiceProvider(1024)

        Dim PrivateKeyContent As String = RSA.ToXmlString(includePrivateParameters:=True)
        Dim PublicKeyContent As String = RSA.ToXmlString(includePrivateParameters:=False)

        Clipboard.SetText(PrivateKeyContent & vbCrLf & vbCrLf & PublicKeyContent)
        MsgBox("Keys sent to clipboard", MsgBoxStyle.Information)
        Me.Close()
    End Sub

End Class
