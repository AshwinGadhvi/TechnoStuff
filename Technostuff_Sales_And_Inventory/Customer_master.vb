Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class Customer_master
    Dim flag As Integer = 0
    Dim d As New DAO
    Private Sub Customer_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        txtname.Focus()
        'DataGridView1.BorderStyle = BorderStyle.None
        'DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(127, 181, 255)
        'DataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        'DataGridView1.DefaultCellStyle.Font = New Font("calibri", 14)
        'DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(196, 221, 255)
        'DataGridView1.EnableHeadersVisualStyles = False
        'DataGridView1.BorderStyle = BorderStyle.None
        'DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("calibri", 16)
        'DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(19, 59, 92)
        'DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        d.enable_design(DataGridView1)
    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress, txtemail.KeyPress, txtaddress.KeyPress, txtgst.KeyPress, txtcontact.KeyPress
        If e.KeyChar.GetHashCode = 851981 Then
            If sender.name = txtname.Name Then
                txtcontact.Focus()
            ElseIf sender.name = txtcontact.Name Then
                txtemail.Focus()
            ElseIf sender.name = txtemail.Name Then
                txtaddress.Focus()
            ElseIf sender.name = txtaddress.Name Then
                txtgst.Focus()
            ElseIf sender.name = txtgst.Name Then
                btnnew.Focus()
            End If
        End If
        Dim d As New DAO
        If sender.name = txtgst.Name Then
            e.Handled = d.isalphanumeric_validate(e.KeyChar, e.KeyChar.GetHashCode)
        End If
        If sender.name = txtname.Name Then
            e.Handled = d.isalpha_validate(e.KeyChar, e.KeyChar.GetHashCode)
        End If
        If sender.name = txtcontact.Name Then
            e.Handled = d.number_validate(e.KeyChar, e.KeyChar.GetHashCode)
        End If
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click

        txtid.Text = ""
        txtname.Text = ""
        txtcontact.Text = ""
        txtaddress.Text = ""
        txtemail.Text = ""
        txtgst.Text = ""
        btndelete.Enabled = False
        txtname.Focus()

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim dao As New DAO

        If txtname.Text <> "" Then
            If txtcontact.Text <> "" And txtcontact.TextLength = 10 And IsNumeric(txtcontact.Text) Then
                If txtemail.Text <> "" Then
                    If txtaddress.Text <> "" Then
                        If txtgst.Text <> "" And txtgst.TextLength = 15 Then ' 
                            If flag = 0 Then
                                'insert
                                Dim check As Integer
                                check = dao.validate("select c_name from customer_master where c_name='" & txtname.Text & "'")
                                If check = 1 Then
                                    MessageBox.Show("Customer is already created", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                                    txtname.Focus()

                                Else
                                    dao.ModifyData("insert into customer_master(c_name,c_contact,c_email,c_address,c_gst) values ('" & txtname.Text & "'," & txtcontact.Text & ",'" & txtemail.Text & "','" & txtaddress.Text & "','" & txtgst.Text & "')")

                                    MessageBox.Show("Customer is created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                    btnnew_Click(sender, e)

                                End If

                            Else
                                'update
                                dao.ModifyData("update customer_master set c_name='" & txtname.Text & "' , c_contact=" & txtcontact.Text & " , c_email='" & txtemail.Text & "', c_address='" & txtaddress.Text & "', c_gst='" & txtgst.Text & "' where c_id=" & txtid.Text & " ")
                                MessageBox.Show("Customer is updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                            End If
                        Else
                            MessageBox.Show("Enter valid GST number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                            txtgst.Focus()

                        End If
                    Else
                        MessageBox.Show("Enter valid address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        txtaddress.Focus()
                    End If
                Else
                    MessageBox.Show("Enter valid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    txtemail.Focus()
                End If
            Else
                MessageBox.Show("Enter valid contact number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1)
                txtcontact.Focus()
            End If
        Else
            MessageBox.Show("Enter valid name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            txtname.Focus()
        End If
        loaddata()

    End Sub
    Public Sub loaddata()
        Dim ds As New Data.DataSet
        ds = d.loaddata("select * from customer_master")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Rows.Count > 0 Then
            txtid.Text = DataGridView1.Item("c_id", DataGridView1.CurrentCell.RowIndex).Value
            txtname.Text = DataGridView1.Item("c_name", DataGridView1.CurrentCell.RowIndex).Value
            txtcontact.Text = DataGridView1.Item("c_contact", DataGridView1.CurrentCell.RowIndex).Value
            txtemail.Text = DataGridView1.Item("c_email", DataGridView1.CurrentCell.RowIndex).Value
            txtaddress.Text = DataGridView1.Item("c_address", DataGridView1.CurrentCell.RowIndex).Value
            txtgst.Text = DataGridView1.Item("c_gst", DataGridView1.CurrentCell.RowIndex).Value
            flag = 1
            btndelete.Enabled = True
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim c As Integer
        c = MessageBox.Show("Do you want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If c = 6 Then
            Dim d As New DAO
            d.ModifyData("delete from customer_master where c_id=" & txtid.Text & " ")
            loaddata()
            btndelete.Enabled = False
            btnnew_Click(sender, e)
        End If
    End Sub
    'Public Function valid_email(ByVal str As String) As Integer
    '    Dim flag As Integer = 0
    '    Dim p As String
    '    p = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
    '    If Regex.IsMatch(str, p) Then
    '        flag = 1
    '    Else
    '        flag = 0
    '    End If
    '    Return flag
    'End Function


End Class
