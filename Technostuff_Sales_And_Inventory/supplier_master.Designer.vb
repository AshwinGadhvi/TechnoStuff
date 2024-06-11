<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class supplier_master
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(supplier_master))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtgst = New System.Windows.Forms.TextBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.combocategory = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.combocompany = New System.Windows.Forms.ComboBox()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.s_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.s_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.s_company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.s_contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.s_city = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.s_category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gst_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(12, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1800, 121)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(627, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(744, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(427, 73)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Supplier Master"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtname)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.txtgst)
        Me.Panel4.Controls.Add(Me.btndelete)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.combocategory)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.combocompany)
        Me.Panel4.Controls.Add(Me.btnnew)
        Me.Panel4.Controls.Add(Me.btnsave)
        Me.Panel4.Controls.Add(Me.txtcity)
        Me.Panel4.Controls.Add(Me.txtcontact)
        Me.Panel4.Controls.Add(Me.txtid)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(12, 178)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1800, 281)
        Me.Panel4.TabIndex = 16
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(281, 79)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(558, 40)
        Me.txtname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(72, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 35)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Supplier Name:"
        '
        'txtgst
        '
        Me.txtgst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtgst.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgst.Location = New System.Drawing.Point(1086, 80)
        Me.txtgst.MaxLength = 15
        Me.txtgst.Name = "txtgst"
        Me.txtgst.Size = New System.Drawing.Size(558, 40)
        Me.txtgst.TabIndex = 4
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(571, 200)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(129, 46)
        Me.btndelete.TabIndex = 9
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(894, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 35)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "GST Number :"
        '
        'combocategory
        '
        Me.combocategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combocategory.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combocategory.FormattingEnabled = True
        Me.combocategory.Location = New System.Drawing.Point(281, 129)
        Me.combocategory.Name = "combocategory"
        Me.combocategory.Size = New System.Drawing.Size(558, 41)
        Me.combocategory.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(133, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 35)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Category :"
        '
        'combocompany
        '
        Me.combocompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combocompany.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combocompany.FormattingEnabled = True
        Me.combocompany.Items.AddRange(New Object() {"sindhu", "abunja", "sanghvi", "ultra tech"})
        Me.combocompany.Location = New System.Drawing.Point(1086, 22)
        Me.combocompany.Name = "combocompany"
        Me.combocompany.Size = New System.Drawing.Size(555, 41)
        Me.combocompany.TabIndex = 3
        '
        'btnnew
        '
        Me.btnnew.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnnew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Location = New System.Drawing.Point(425, 200)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(129, 46)
        Me.btnnew.TabIndex = 8
        Me.btnnew.Text = "&New"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(281, 200)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(129, 46)
        Me.btnsave.TabIndex = 7
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'txtcity
        '
        Me.txtcity.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcity.Location = New System.Drawing.Point(1086, 137)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(558, 40)
        Me.txtcity.TabIndex = 5
        '
        'txtcontact
        '
        Me.txtcontact.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontact.Location = New System.Drawing.Point(1086, 194)
        Me.txtcontact.MaxLength = 10
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(555, 40)
        Me.txtcontact.TabIndex = 6
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(281, 29)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(555, 40)
        Me.txtid.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(995, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 35)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "City :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(847, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(222, 35)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Supplier Contact :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(931, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 35)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Company :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(107, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 35)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Supplier Id : "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(12, 465)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1800, 398)
        Me.Panel1.TabIndex = 17
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.s_id, Me.s_name, Me.s_company, Me.s_contact, Me.s_city, Me.s_category, Me.gst_number})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1800, 398)
        Me.DataGridView1.TabIndex = 0
        '
        's_id
        '
        Me.s_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.s_id.DataPropertyName = "s_id"
        Me.s_id.HeaderText = "ID"
        Me.s_id.Name = "s_id"
        Me.s_id.ReadOnly = True
        '
        's_name
        '
        Me.s_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.s_name.DataPropertyName = "s_name"
        Me.s_name.HeaderText = "Name"
        Me.s_name.Name = "s_name"
        Me.s_name.ReadOnly = True
        '
        's_company
        '
        Me.s_company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.s_company.DataPropertyName = "s_company"
        Me.s_company.HeaderText = "Company"
        Me.s_company.Name = "s_company"
        Me.s_company.ReadOnly = True
        '
        's_contact
        '
        Me.s_contact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.s_contact.DataPropertyName = "s_contact"
        Me.s_contact.HeaderText = "Contact"
        Me.s_contact.Name = "s_contact"
        Me.s_contact.ReadOnly = True
        '
        's_city
        '
        Me.s_city.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.s_city.DataPropertyName = "s_city"
        Me.s_city.HeaderText = "City"
        Me.s_city.Name = "s_city"
        Me.s_city.ReadOnly = True
        '
        's_category
        '
        Me.s_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.s_category.DataPropertyName = "s_category"
        Me.s_category.HeaderText = "Category"
        Me.s_category.Name = "s_category"
        Me.s_category.ReadOnly = True
        '
        'gst_number
        '
        Me.gst_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.gst_number.DataPropertyName = "gst_number"
        Me.gst_number.HeaderText = "GST Number"
        Me.gst_number.Name = "gst_number"
        Me.gst_number.ReadOnly = True
        '
        'supplier_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1837, 875)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "supplier_master"
        Me.Text = "supplier_master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnnew As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents txtcity As TextBox
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents combocategory As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents combocompany As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btndelete As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtgst As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents s_id As DataGridViewTextBoxColumn
    Friend WithEvents s_name As DataGridViewTextBoxColumn
    Friend WithEvents s_company As DataGridViewTextBoxColumn
    Friend WithEvents s_contact As DataGridViewTextBoxColumn
    Friend WithEvents s_city As DataGridViewTextBoxColumn
    Friend WithEvents s_category As DataGridViewTextBoxColumn
    Friend WithEvents gst_number As DataGridViewTextBoxColumn
End Class
