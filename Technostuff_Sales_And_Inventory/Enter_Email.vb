Imports System.Net
Imports System.Net.Mail
Public Class Enter_Email
    Dim RandomCode As String
    Public Shared ToUser As String



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox2.Text.Equals(RandomCode)) Then
            ToUser = "hemgajjaris007@gmail.com"
            Dim reset As Reset_Password = New Reset_Password()
            Reset_Password.Show()
            Dim sc As Enter_Email = New Enter_Email()
            sc.Hide()
        Else
            MessageBox.Show("Incorrect Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub Enter_Email_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim from, pass, messageBody As String
        Dim rand As Random = New Random()
        RandomCode = (rand.Next(999999)).ToString
        Dim message As MailMessage = New MailMessage()
        ToUser = "hemgajjaris007@gmail.com"
        from = "technostuffpass@gmail.com"
        pass = "oqiwzvvivtobarzm"

        messageBody = "your reset code is " + RandomCode
        message.To.Add(ToUser)
        message.From = New MailAddress(from)
        message.Body = messageBody
        message.Subject = "password resetting code"
        Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
        smtp.EnableSsl = True
        smtp.Port = 587
        smtp.DeliveryMethod = smtp.DeliveryMethod.Network
        smtp.Credentials = New NetworkCredential(from, pass)
        Try
            smtp.Send(message)
            MessageBox.Show("Please check your email and enter code", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub
End Class