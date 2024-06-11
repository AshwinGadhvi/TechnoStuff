Imports System.Data.SqlClient
Public Class Sub_Category_Master
    Dim ds As DataSet
    Dim flag As Integer = 0
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcompany.KeyPress, btnsave.KeyPress, txtproduct.KeyPress
        If e.KeyChar.GetHashCode = 851981 Then
            combocategory.Focus()
            If sender.name = combocategory.Name Then
                txtcompany.Focus()
            ElseIf sender.name = txtcompany.Name Then
                txtproduct.Focus()
            ElseIf sender.name = txtproduct.Name Then
                btnsave.Focus()
            End If
        End If
        Dim d As New DAO
        If sender.name = txtcompany.Name Then
            e.Handled = d.isalpha_validate(e.KeyChar, e.KeyChar.GetHashCode)
        End If
        If sender.name = txtproduct.Name Then
            e.Handled = d.isalphanumeric_validate(e.KeyChar, e.KeyChar.GetHashCode)
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim d As New DAO
        If combocategory.Text <> "" Then
            If txtcompany.Text <> "" Then
                If txtproduct.Text <> "" Then

                    Dim dao As New DAO
                    If flag = 0 Then
                        dao.ModifyData("insert into sub_category_master (category_name,company_name,product_type) values ('" & combocategory.Text & "','" & txtcompany.Text & "','" & txtproduct.Text & "')")

                        MessageBox.Show("Data Entered Succssefully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        btnnew_Click(sender, e)
                    Else
                        'update

                        dao.ModifyData("update sub_category_master set category_name='" & combocategory.Text & "',company_name='" & txtcompany.Text & "',product_type='" & txtproduct.Text & "' where sc_id=" & txtid.Text & "")
                        MessageBox.Show("Data Updated Succssefully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        btnnew_Click(sender, e)
                    End If
                Else
                    MessageBox.Show("Enter Valid Product Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            Else
                MessageBox.Show("Enter Valid Company Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        Else
            MessageBox.Show("Enter Valid Category Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
        loaddata()
    End Sub



    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        combocategory.Text = ""
        txtcompany.Text = ""
        txtproduct.Text = ""
        txtid.Text = ""
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim c As New Integer
        c = MessageBox.Show("Do you want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If c = 6 Then
            Dim d As New DAO
            d.ModifyData("delete from sub_category_master where sc_id =" & txtid.Text & "")
        End If
        loaddata()
        btndelete.Enabled = False
        btndelete_Click(sender, e)
    End Sub
    Public Sub loaddata()
        Dim ds As New Data.DataSet
        Dim d As New DAO
        ds = d.loaddata("select * from sub_category_master")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Sub_Category_Master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        combocategory.Focus()
        Dim d As New DAO
        d.enable_design(DataGridView1)


        Dim obj As SqlDataReader

        obj = d.getdata("select distinct(ct_name) from category_master")
        While obj.Read
            combocategory.Items.Add(obj.Item(0))
        End While
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Rows.Count > 0 Then
            combocategory.Text = DataGridView1.Item("category_name", DataGridView1.CurrentCell.RowIndex).Value.ToString
            txtcompany.Text = DataGridView1.Item("company_name", DataGridView1.CurrentCell.RowIndex).Value
            txtproduct.Text = DataGridView1.Item("product_type", DataGridView1.CurrentCell.RowIndex).Value
            txtid.Text = DataGridView1.Item("sc_id", DataGridView1.CurrentCell.RowIndex).Value

            flag = 1
            btndelete.Enabled = True
        End If
    End Sub
End Class
