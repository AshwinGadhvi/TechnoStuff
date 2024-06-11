Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class supplier_master
    Dim ds As DataSet
    Dim flag As Integer = 0
    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcity.KeyPress, txtcontact.KeyPress, combocategory.KeyPress, combocompany.KeyPress, btnsave.KeyPress, txtgst.KeyPress, txtname.KeyPress
        If e.KeyChar.GetHashCode = 851981 Then
            txtname.Focus()
            If sender.name = txtname.Name Then
                combocategory.Focus()
            ElseIf sender.name = combocategory.Name Then
                combocompany.Focus()
            ElseIf sender.name = combocompany.Name Then
                txtgst.Focus()
            ElseIf sender.name = txtgst.Name Then
                txtcity.Focus()
            ElseIf sender.name = txtcity.Name Then
                txtcontact.Focus()
            ElseIf sender.name = txtcontact.Name Then
                btnsave.Focus()

            End If
        End If
        Dim d As New DAO
        If sender.name = txtcontact.Name Then
            e.Handled = d.number_validate(e.KeyChar, e.KeyChar.GetHashCode)
        End If
        If sender.name = txtcity.Name Or sender.name = txtname.Name Then
            e.Handled = d.isalpha_validate(e.KeyChar, e.KeyChar.GetHashCode)
        End If
        If sender.name = txtgst.Name Then
            e.Handled = d.isalphanumeric_validate(e.KeyChar, e.KeyChar.GetHashCode)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim d As New DAO
        If combocompany.Text <> "" Then
            If txtname.Text <> "" Then


                If txtcontact.Text <> "" And txtcontact.TextLength = 10 And IsNumeric(txtcontact.Text) Then
                    If txtcity.Text <> "" Then
                        If combocategory.Text <> "" Then
                            If txtgst.Text <> "" And txtgst.TextLength = 15 Then ' valid_gst(txtgst.Text) 
                                Dim dao As New DAO
                                If flag = 0 Then
                                    'insert

                                    dao.ModifyData("insert into supplier_master (s_name,s_company,s_contact,s_city,s_category,gst_number) values ('" & txtname.Text & "','" & combocompany.Text & "'," & txtcontact.Text & ",'" & txtcity.Text & "','" & combocategory.Text & "','" & txtgst.Text & "')")
                                    MessageBox.Show("Supplier is created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                    Button2_Click(sender, e)
                                Else
                                    'update

                                    dao.ModifyData("update supplier_master set s_name ='" & txtname.Text & "',s_company='" & combocompany.Text & "' , s_contact=" & txtcontact.Text & " , s_city='" & txtcity.Text & "',s_category='" & combocategory.Text & "', gst_number='" & txtgst.Text & "'where s_id=" & txtid.Text & "")
                                    MessageBox.Show("Supplier is updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                    Button2_Click(sender, e)
                                End If

                            Else

                                MessageBox.Show("Enter Valid GST Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                                txtgst.Focus()

                            End If
                        Else
                            MessageBox.Show("Enter Valid Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                            combocategory.Focus()
                        End If
                    Else
                        MessageBox.Show("Enter Valid City", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        txtcity.Focus()

                    End If
                Else
                    MessageBox.Show("Enter Valid Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    txtcontact.Focus()
                End If
            Else
                MessageBox.Show("Enter Valid Supplier Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                txtname.Focus()
            End If
        Else
            MessageBox.Show("Enter Valid User Company Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            combocategory.Focus()
        End If
        loaddata()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtid.Text = ""
        txtname.Text = ""
        combocompany.Text = ""
        txtcontact.Text = ""
        txtcity.Text = ""
        combocategory.Text = ""
        txtgst.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim c As New Integer
        c = MessageBox.Show("Do you want to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If c = 6 Then
            Dim d As New DAO
            d.ModifyData("delete from supplier_master where s_id=" & txtid.Text & " ")
        End If
        loaddata()
        btndelete.Enabled = False
        Button2_Click(sender, e)
    End Sub

    Public Sub loaddata()
        Dim ds As New Data.DataSet
        Dim d As New DAO
        ds = d.loaddata("select * from supplier_master")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
    Dim d As New DAO
    Private Sub supplier_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        d.enable_design(DataGridView1)
        Dim obj As SqlDataReader
        obj = d.getdata("select distinct(ct_name) from category_master")
        While obj.Read
            combocategory.Items.Add(obj.Item(0))
        End While
    End Sub

    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If DataGridView1.Rows.Count > 0 Then
            txtid.Text = DataGridView1.Item("s_id", DataGridView1.CurrentCell.RowIndex).Value
            txtname.Text = DataGridView1.Item("s_name", DataGridView1.CurrentCell.RowIndex).Value
            combocompany.Text = DataGridView1.Item("s_company", DataGridView1.CurrentCell.RowIndex).Value
            txtcontact.Text = DataGridView1.Item("s_contact", DataGridView1.CurrentCell.RowIndex).Value
            txtcity.Text = DataGridView1.Item("s_city", DataGridView1.CurrentCell.RowIndex).Value
            combocategory.Text = DataGridView1.Item("s_category", DataGridView1.CurrentCell.RowIndex).Value
            txtgst.Text = DataGridView1.Item("gst_number", DataGridView1.CurrentCell.RowIndex).Value
            flag = 1
            btndelete.Enabled = True
        End If
    End Sub



    Private Sub combocategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combocategory.SelectedIndexChanged
        Dim obj As SqlDataReader
        Dim d As New DAO
        combocompany.Items.Clear()

        obj = d.getdata("select distinct(company_name) from sub_category_master where category_name='" & combocategory.Text & "'")
        While obj.Read
            combocompany.Items.Add(obj.Item(0))
        End While
    End Sub





    'Public Function valid_gst(ByVal str As String) As Integer
    '    Dim flag As Integer = 0
    '    Dim p As String
    '    p = "([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." +
    '    ")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})"
    '    If Regex.IsMatch(str, p) Then
    '        flag = 1
    '    Else
    '        flag = 0
    '    End If
    '    Return flag
    'End Function

End Class