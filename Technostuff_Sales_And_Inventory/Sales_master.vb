
Imports System.Data.SqlClient
Public Class Sales_master
    Private Sub Sales_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_customer()
        txtcid.Text = ""
        txtccontact.Text = ""
        txtcgst.Text = ""
        txtcadd.Text = ""
        txtphsn.Text = ""
        Dim d As New DAO
        d.enable_design(DataGridView1)

        Dim obj As SqlDataReader = d.getdata("Select MAX(invoice_id) from configure_master")
        If obj.Read Then
            count = Val(obj.Item(0))
        End If
        load_product()
        load_invoice()
    End Sub


    Private Sub txtinvno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttotamt.KeyPress, txtpsunit.KeyPress, txtpsrate.KeyPress, txtpsgst.KeyPress, txtphsn.KeyPress, txtpcgst.KeyPress, txtinvno.KeyPress, txtcid.KeyPress, txtcgst.KeyPress, txtccontact.KeyPress, dtp1.KeyPress, btnsave.KeyPress, btnnew.KeyPress
        If e.KeyChar.GetHashCode = 851981 Then
            txtinvno.Focus()
            If sender.name = txtinvno.Name Then
                dtp1.Focus()
            ElseIf sender.name = dtp1.Name Then
                txtcid.Focus()
            ElseIf sender.name = txtcid.Name Then
                combocname.Focus()
            ElseIf sender.name = combocname.Name Then
                txtccontact.Focus()
            ElseIf sender.name = txtccontact.Name Then
                txtcgst.Focus()
            ElseIf sender.name = txtcgst.Name Then
                txtpid.Focus()
            ElseIf sender.name = txtpid.Name Then
                combocategory.Focus()
            ElseIf sender.name = combocategory.Name Then
                combocompany.Focus()
            ElseIf sender.name = combocompany.Name Then
                combotype.Focus()
            ElseIf sender.name = combotype.Name Then
                txtphsn.Focus()
            ElseIf sender.name = txtphsn.Name Then
                txtpsrate.Focus()
            ElseIf sender.name = txtpsrate.Name Then
                txtpsunit.Focus()
            ElseIf sender.name = txtpsunit.Name Then
                txtpcgst.Focus()
            ElseIf sender.name = txtpcgst.Name Then
                txtpsgst.Focus()
            ElseIf sender.name = txtpsgst.Name Then
                txttotamt.Focus()
            ElseIf sender.name = txttotamt.Name Then
                btnsave.Focus()
            ElseIf sender.name = btnsave.Name Then
                btnnew.Focus()
            End If
        End If
    End Sub
    Dim count As Integer
    Private Sub load_category()
        Try
            Dim d As New DAO
            Dim ds As New Data.DataSet
            ds = d.loaddata("select distinct(ct_name),ct_id from category_master")
            combocategory.DisplayMember = "ct_name"
            combocategory.ValueMember = "ct_id"
            combocategory.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub


    Public Sub AutoSearch(ByRef xcb As ComboBox, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal blnLimitToList As Boolean)

        Dim strFindStr As String = ""

        If e.KeyChar = ChrW(8) Then

            If (xcb.SelectionStart <= 1) Then

                xcb.Text = ""
                Exit Sub
            End If

            If (xcb.SelectionLength = 0) Then

                strFindStr = xcb.Text.Substring(0, xcb.Text.Length - 1)

            Else

                strFindStr = xcb.Text.Substring(0, xcb.SelectionStart - 1)
            End If

        Else

            If (xcb.SelectionLength = 0) Then

                strFindStr = xcb.Text + e.KeyChar

            Else

                strFindStr = xcb.Text.Substring(0, xcb.SelectionStart) + e.KeyChar
            End If

            Dim intIdx As Integer = -1
            ' Search the string in the ComboBox list.  

            intIdx = xcb.FindString(strFindStr)
            If (intIdx <> -1) Then

                xcb.SelectedText = ""
                xcb.SelectedIndex = intIdx
                xcb.SelectionStart = strFindStr.Length
                xcb.SelectionLength = xcb.Text.Length
                e.Handled = True

            Else

                e.Handled = blnLimitToList

            End If
        End If
    End Sub
    Private Sub load_invoice()

        Try
            Dim d As New DAO
            Dim c_year As Integer = 0
            Dim ds As New Data.DataSet

            d.ModifyData("insert into configure_master (invoice_num) values (" & count & ")")
            ds = d.loaddata("select * from configure_master")
            If ds.Tables(0).Rows.Count > 0 Then
                txtinvno.Text = "TC-" & set_zero(ds.Tables(0).Rows(count).Item(0))
            End If
            count += 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Function set_zero(v As String) As String
        Dim d As Integer = v.Length
        Dim s As String = ""
        For i = d To 3
            s &= "0"
        Next
        s &= v
        Return s
    End Function
    Private Sub load_customer()
        Try
            Dim d As New DAO
            Dim ds As New Data.DataSet
            ds = d.loaddata("select distinct(c_name) from customer_master")
            combocname.DisplayMember = "c_name"
            combocname.ValueMember = "c_name"
            combocname.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub combocname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combocname.SelectedIndexChanged
        If combocname.Text <> "" Then
            Dim ds As New Data.DataSet
            Dim d As New DAO
            ds = d.loaddata("select c_id,c_contact,c_gst,c_address from customer_master where c_name =  '" & combocname.Text & "'")

            If ds.Tables(0).Rows.Count > 0 Then
                txtcid.Text = ds.Tables(0).Rows(0).Item("c_id")
                txtccontact.Text = ds.Tables(0).Rows(0).Item("c_contact")
                txtcgst.Text = ds.Tables(0).Rows(0).Item("c_gst")
                txtcadd.Text = ds.Tables(0).Rows(0).Item("c_address")
            End If
        End If
    End Sub

    Private Sub combocname_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles combotype.KeyPress, combocompany.KeyPress, combocname.KeyPress, combocategory.KeyPress
        If sender.name = combocname.Name Then
            AutoSearch(sender, e, True)
        ElseIf sender.name = combotype.Name Then
            AutoSearch(sender, e, True)
        ElseIf sender.name = combocompany.Name Then
            AutoSearch(sender, e, True)
        ElseIf sender.name = combocategory.Name Then
            AutoSearch(sender, e, True)
        End If
    End Sub
    Private Sub load_product()
        Try
            Dim d As New DAO
            Dim ds As New Data.DataSet

            ds = d.loaddata("select distinct(p_category) from product_master")
            combocategory.DisplayMember = "p_category"
            combocategory.ValueMember = "p_id"
            combocategory.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub combocategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combocategory.SelectedIndexChanged
        Try
            If combocategory.Text <> "" Then
                combocompany.Text = ""
                Dim ds As New Data.DataSet
                Dim d As New DAO

                ds = d.loaddata("select p_company from product_master where p_category='" & combocategory.Text & "'")
                combocompany.DisplayMember = "p_company"
                combocompany.ValueMember = "p_id"
                combocompany.DataSource = ds.Tables(0)

            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub combocompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combocompany.SelectedIndexChanged
        Try
            If combocompany.Text <> "" Then
                combotype.Text = ""
                Dim ds As New Data.DataSet
                Dim d As New DAO
                ds = d.loaddata("select p_type from product_master where p_company='" & combocompany.Text & "'")
                combotype.DisplayMember = "p_type"
                combotype.ValueMember = "p_id"
                combotype.DataSource = ds.Tables(0)

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub combotype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combotype.SelectedIndexChanged
        If combotype.Text <> "" Then
            Try
                Dim d As New DAO
                Dim ds As New Data.DataSet
                ds = d.loaddata("select p_hsn,p_sales_rate,p_sales_unit,p_cgst,p_sgst,p_id from product_master where p_type='" & combotype.Text & "'")
                If ds.Tables(0).Rows.Count > 0 Then
                    txtpcgst.Text = ds.Tables(0).Rows(0).Item(3)
                    txtpsgst.Text = ds.Tables(0).Rows(0).Item(4)
                    txtpid.Text = ds.Tables(0).Rows(0).Item(5)
                    txtphsn.Text = ds.Tables(0).Rows(0).Item(0)
                    txtpsrate.Text = ds.Tables(0).Rows(0).Item(1)
                    txtpsunit.Text = ds.Tables(0).Rows(0).Item(2)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        load_invoice()
    End Sub



    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If combocname.Text <> "" Then
            If txtccontact.Text <> "" Then
                If combocategory.Text <> "" Then
                    If combocompany.Text <> "" Then
                        If combotype.Text <> "" Then
                            If txtphsn.Text <> "" Then
                                If txtqty.Text <> "0" Then
                                    If txtpsrate.Text <> "0" Then
                                        If txtpsunit.Text <> "" Then
                                            If txtpcgst.Text <> "0" Then
                                                If txtpsgst.Text <> "0" Then
                                                    If combopay.Text <> "" Then


                                                        Dim d As New DAO


                                                        'PRODUCT ENTRY 

                                                        d.ModifyData("insert into sales_detail (in_no,p_cat,p_com,p_type,p_qty,p_unit,p_rate,p_cgst,p_sgst,p_hsn,p_tot,p_gst_amt) values ('" & txtinvno.Text & "','" & combocategory.Text & "','" & combocompany.Text & "','" & combotype.Text & "'," & txtqty.Text & ",'" & txtpsunit.Text & "'," & txtpsrate.Text & "," & txtpcgst.Text & "," & txtpsgst.Text & "," & txtphsn.Text & "," & txttotamt.Text & "," & txtamtgst.Text & ")")



                                                        'LOAD DATA & CALCULATE TOTALS 


                                                        load_invoice_data()


                                                            'ONE ENTRY IN SALES SUMMARY
                                                            If DataGridView1.Rows.Count = 1 Then
                                                            d.ModifyData("insert into sales_summary (c_name,c_contact,in_date,in_no,pay_mode,in_tot,gst_tot,p_qty,lab_char,r_off) values ('" & combocname.Text & "'," & txtccontact.Text & ",'" & dtp1.Value.ToString("yyyy-MM-dd") & "','" & txtinvno.Text & "','" & combopay.Text & "'," & txtgrandtot.Text & "," & txtgsttotamt.Text & "," & txtqty.Text & "," & txtlabour.Text & "," & txtround.Text & ")")

                                                        Else
                                                                'UPDATE TOTALS
                                                            End If


                                                    Else
                                                        MessageBox.Show("Enter Valid Mode Of Payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                                                    End If
                                                Else
                                                    MessageBox.Show("Enter Valid SGST(%)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

                                                End If
                                            Else
                                                MessageBox.Show("Enter Valid CGST(%)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

                                            End If
                                        Else
                                            MessageBox.Show("Enter Valid Sales Unit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

                                        End If
                                    Else
                                        MessageBox.Show("Enter Valid Sales Rate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

                                    End If
                                Else
                                    MessageBox.Show("Enter Valid Product Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

                                End If
                            Else
                                MessageBox.Show("Enter Valid HSN Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

                            End If
                        Else
                            MessageBox.Show("Enter Valid Product Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)

                        End If
                    Else
                        MessageBox.Show("Enter Valid Product Company", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    End If
                Else
                    MessageBox.Show("Enter Valid Product Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If

            Else
                MessageBox.Show("Enter Valid Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        Else
            MessageBox.Show("Enter Valid Customer Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub load_invoice_data()
        Try
            Dim d As New DAO
            Dim dd As New Data.DataSet
            dd = d.loaddata("SELECT * FROM sales_summary WHERE in_no='" & txtinvno.Text & "'")
            If dd.Tables(0).Rows.Count > 0 Then
                combocname.Text = dd.Tables(0).Rows(0).Item("c_name")
                dtp1.Value = dd.Tables(0).Rows(0).Item("in_date")
                combopay.Text = dd.Tables(0).Rows(0).Item("pay_mode")
                txtround.Text = dd.Tables(0).Rows(0).Item("r_off")
            End If


            Dim ds As New Data.DataSet
            ds = d.loaddata("select * from sales_detail where in_no='" & txtinvno.Text & "'")
            DataGridView1.DataSource = ds.Tables(0)

            'calculate total


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtqty_textchanged(sender As Object, e As EventArgs) Handles txtqty.TextChanged, combotype.SelectedIndexChanged

        Dim basic As Integer = Val(txtqty.Text) * Val(txtpsrate.Text)
        Dim cgst_amt As Integer = Math.Round((basic * Val(txtpcgst.Text) / 100), 2)
        Dim sgst_amt As Integer = Math.Round((basic * Val(txtpsgst.Text) / 100), 2)

        Dim basic_gst As Integer
        txtgsttotper.Text = Val(txtpcgst.Text) + Val(txtpsgst.Text)
        txtamtgst.Text = cgst_amt + sgst_amt
        basic_gst = basic + cgst_amt + sgst_amt
        txttotamt.Text = basic


    End Sub


End Class

