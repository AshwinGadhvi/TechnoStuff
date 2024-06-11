Imports System.Data
Imports System.Data.SqlClient
Public Class Reset_Password
    Dim username As String = Enter_Email.ToUser
    Dim dao As New DAO



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If txtnewpass.Text = txtverifypass.Text Then

            dao.ModifyData("UPDATE [data_stu6].[login_master]
            SET  [u_pass] = '" + txtverifypass.Text + "'
            WHERE [u_name] ='" + u_name + "'")


            MessageBox.Show("Password Reseted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Login_Master.Show()
            Me.Close()


        Else
            MessageBox.Show("Password is not Verified", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            txtnewpass.Focus()

        End If
    End Sub

    Private Sub Reset_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnewpass.UseSystemPasswordChar = True
        txtverifypass.UseSystemPasswordChar = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtnewpass.UseSystemPasswordChar = False
            txtverifypass.UseSystemPasswordChar = False
        Else
            txtnewpass.UseSystemPasswordChar = True
            txtverifypass.UseSystemPasswordChar = True
        End If
    End Sub
End Class