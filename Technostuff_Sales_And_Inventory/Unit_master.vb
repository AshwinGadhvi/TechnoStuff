Public Class Unit_master
    Dim d As New DAO
    Dim ds As DataSet
    Dim flag As Integer = 0
    Public Sub loaddata()
        Dim ds As New Data.DataSet
        ds = d.loaddata("select * from unit_master")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
    Private Sub Unit_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        txtid.Focus()
        d.enable_design(DataGridView1)
    End Sub

    Private Sub txtid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtunit.KeyPress, txtid.KeyPress, btnsave.KeyPress
        If e.KeyChar.GetHashCode = 851981 Then
            txtid.Focus()
            If sender.name = txtid.Name Then
                txtunit.Focus()
            ElseIf sender.name = txtunit.Name Then
                btnsave.Focus()
            End If
        End If

        If sender.name = txtunit.Name Then
            e.Handled = d.isalpha_validate(e.KeyChar, e.KeyChar.GetHashCode)
        End If

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click


        Dim dao As New DAO
            If flag = 0 Then
                'insert

                dao.ModifyData("insert into unit_master (u_name) values('" & txtunit.Text & "')")
                MessageBox.Show("Unit is created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                btnnew_Click(sender, e)
            Else
            'update

            dao.ModifyData("update unit_master set u_name='" & txtunit.Text & "' where u_id=" & txtid.Text & "")
            MessageBox.Show("Unit is updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            btnnew_Click(sender, e)
        End If
        loaddata()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Rows.Count > 0 Then
            txtid.Text = DataGridView1.Item("u_id", DataGridView1.CurrentCell.RowIndex).Value
            txtunit.Text = DataGridView1.Item("u_name", DataGridView1.CurrentCell.RowIndex).Value
            flag = 1
            btndelete.Enabled = True
        End If
    End Sub
    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtid.Text = ""
        txtunit.Text = ""
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim c As New Integer
        c = MessageBox.Show("Do you want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If c = 6 Then
            Dim d As New DAO
            d.ModifyData("delete from unit_master where u_id=" & txtid.Text & " ")
        End If
        loaddata()
        btndelete.Enabled = False
        btnnew_Click(sender, e)
    End Sub
End Class