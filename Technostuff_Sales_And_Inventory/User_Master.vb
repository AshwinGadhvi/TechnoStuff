Public Class User_Master

    Dim dao As New DAO
    Dim ds As DataSet
    Dim flag As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim flag As Integer = 0
        txtid.Text = ""
        txtname.Text = ""
        txtpass.Text = ""
        Button3.Enabled = False
        txtname.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim d As New DAO
        If txtname.Text <> "" Then
            If txtpass.Text <> "" Then
                If flag = 0 Then

                    Dim f As Integer = 0
                    Dim dao As New DAO
                    f = dao.validate("select u_name from login_master where u_name='" & txtname.Text & "'")
                    If f = 1 Then
                        MessageBox.Show("Unable to create user it is already Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        txtname.Focus()
                    Else
                        'insert
                        dao.ModifyData("insert into login_master (u_name,u_pass) values ('" & txtname.Text & "','" & txtpass.Text & "')")
                        MessageBox.Show("User is Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Button1_Click(sender, e)
                    End If
                Else
                    'update
                    Dim dao As New DAO
                    dao.ModifyData("update login_master set u_name='" & txtname.Text & "',u_pass='" & txtpass.Text & "' where u_id=" & txtid.Text & " ")
                    MessageBox.Show("User is updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Button1_Click(sender, e)

                End If

            Else
                MessageBox.Show("Enter Valid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                txtpass.Focus()
            End If
        Else
            MessageBox.Show("Enter Valid User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            txtname.Focus()
        End If
        loaddata()
    End Sub

    Private Sub Textbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpass.KeyPress, txtname.KeyPress, Button3.KeyPress, Button2.KeyPress, Button1.KeyPress
        If e.KeyChar.GetHashCode = 851981 Then
            If sender.name = txtname.Name Then
                txtpass.Focus()
            ElseIf sender.name = txtpass.Name Then
                Button1.Focus()
            End If
        End If
        Dim d As New DAO
        If sender.name = txtname.Name Then
            e.Handled = d.isalpha_validate(e.KeyChar, e.KeyChar.GetHashCode)
        End If
        If sender.name = txtpass.Name Then
            e.Handled = d.number_validate(e.KeyChar, e.KeyChar.GetHashCode)
        End If
    End Sub

    Private Sub User_Master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        txtname.Focus()
        txtpass.UseSystemPasswordChar = True
        Dim d As New DAO
        d.enable_design(DataGridView1)


    End Sub
    Public Sub loaddata()
        Dim ds As New Data.DataSet
        Dim d As New DAO
        ds = d.loaddata("select * from login_master")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Rows.Count > 0 Then
            txtid.Text = DataGridView1.Item("u_id", DataGridView1.CurrentCell.RowIndex).Value
            txtname.Text = DataGridView1.Item("u_name", DataGridView1.CurrentCell.RowIndex).Value
            txtpass.Text = DataGridView1.Item("u_pass", DataGridView1.CurrentCell.RowIndex).Value
            flag = 1
            Button3.Enabled = True
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim c As Integer
        c = MessageBox.Show("Do you want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If c = 6 Then
            Dim d As New DAO
            d.ModifyData("delete from login_master where u_id=" & txtid.Text & " ")
            loaddata()
            Button3.Enabled = False
            Button1_Click(sender, e)
        End If
    End Sub
End Class