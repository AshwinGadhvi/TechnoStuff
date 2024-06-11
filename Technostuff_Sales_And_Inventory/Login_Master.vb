Public Class Login_Master
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As New DAO
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As New DAO
        Dim obj As SqlClient.SqlDataReader
        Dim flag As Boolean = False

        obj = d.getdata("select * from login_master where u_name= '" & TextBox1.Text & "' and u_pass='" & TextBox2.Text & "'")
        While obj.Read
            flag = True
        End While

        If flag Then

            Me.Hide()
            Homepage.Show()
            MessageBox.Show("Welcome " & TextBox1.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            MessageBox.Show("Enter Valid Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            TextBox2.Text = ""
            TextBox1.Focus()
        End If

        d.closeconnection()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, Button1.KeyPress, CheckBox1.KeyPress

        If e.KeyChar.GetHashCode = 851981 Then
            If sender.name = TextBox1.Name Then
                TextBox2.Focus()
            ElseIf sender.name = TextBox2.Name Then
                CheckBox1.Focus()
            ElseIf sender.name = CheckBox1.Name Then
                Button1.Focus()
            ElseIf sender.name = Button1.Name Then

            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()

        If TextBox1.Text <> "" Then
            u_name = TextBox1.Text
            Dim sc As Enter_Email = New Enter_Email()
            sc.Show()
            Dim l As Login_Master = New Login_Master()
            l.Hide()
        Else
            MessageBox.Show("Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub



    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub
End Class