<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_Master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product_Master))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.combosunit = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtsrate = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtprate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.combopunit = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.combotype = New System.Windows.Forms.ComboBox()
        Me.combocompany = New System.Windows.Forms.ComboBox()
        Me.txthsn = New System.Windows.Forms.TextBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.combocategory = New System.Windows.Forms.ComboBox()
        Me.numsgst = New System.Windows.Forms.NumericUpDown()
        Me.numcgst = New System.Windows.Forms.NumericUpDown()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.p_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_cgst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_sgst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_hsn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_purch_unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_sales_unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_purch_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_sales_rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numsgst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numcgst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(12, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1800, 121)
        Me.Panel2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1800, 121)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(627, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(111, 94)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(744, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 73)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Master"
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
        Me.Label8.Size = New System.Drawing.Size(416, 73)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Product Master"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.combotype)
        Me.Panel4.Controls.Add(Me.combocompany)
        Me.Panel4.Controls.Add(Me.txthsn)
        Me.Panel4.Controls.Add(Me.btndelete)
        Me.Panel4.Controls.Add(Me.btnsave)
        Me.Panel4.Controls.Add(Me.btnnew)
        Me.Panel4.Controls.Add(Me.combocategory)
        Me.Panel4.Controls.Add(Me.numsgst)
        Me.Panel4.Controls.Add(Me.numcgst)
        Me.Panel4.Controls.Add(Me.txtid)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Font = New System.Drawing.Font("NSimSun", 8.25!)
        Me.Panel4.Location = New System.Drawing.Point(12, 178)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1800, 355)
        Me.Panel4.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.combosunit)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtsrate)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(720, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(589, 154)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sales"
        '
        'combosunit
        '
        Me.combosunit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combosunit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combosunit.FormattingEnabled = True
        Me.combosunit.Location = New System.Drawing.Point(177, 36)
        Me.combosunit.Name = "combosunit"
        Me.combosunit.Size = New System.Drawing.Size(356, 32)
        Me.combosunit.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(56, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 24)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Sales Unit:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(52, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 24)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Sales Rate:"
        '
        'txtsrate
        '
        Me.txtsrate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsrate.Location = New System.Drawing.Point(177, 85)
        Me.txtsrate.Name = "txtsrate"
        Me.txtsrate.Size = New System.Drawing.Size(354, 32)
        Me.txtsrate.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtprate)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.combopunit)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(720, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(589, 157)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Purchase"
        '
        'txtprate
        '
        Me.txtprate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprate.Location = New System.Drawing.Point(179, 93)
        Me.txtprate.Name = "txtprate"
        Me.txtprate.Size = New System.Drawing.Size(354, 32)
        Me.txtprate.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(22, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 24)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Purchase Unit:"
        '
        'combopunit
        '
        Me.combopunit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combopunit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combopunit.FormattingEnabled = True
        Me.combopunit.Location = New System.Drawing.Point(177, 47)
        Me.combopunit.Name = "combopunit"
        Me.combopunit.Size = New System.Drawing.Size(356, 32)
        Me.combopunit.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(20, 93)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 24)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Purchase Rate:"
        '
        'combotype
        '
        Me.combotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combotype.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combotype.FormattingEnabled = True
        Me.combotype.Location = New System.Drawing.Point(196, 151)
        Me.combotype.Name = "combotype"
        Me.combotype.Size = New System.Drawing.Size(441, 32)
        Me.combotype.TabIndex = 33
        '
        'combocompany
        '
        Me.combocompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combocompany.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combocompany.FormattingEnabled = True
        Me.combocompany.Items.AddRange(New Object() {"ambuja"})
        Me.combocompany.Location = New System.Drawing.Point(195, 111)
        Me.combocompany.Name = "combocompany"
        Me.combocompany.Size = New System.Drawing.Size(441, 32)
        Me.combocompany.TabIndex = 32
        '
        'txthsn
        '
        Me.txthsn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthsn.Location = New System.Drawing.Point(195, 273)
        Me.txthsn.MaxLength = 8
        Me.txthsn.Name = "txthsn"
        Me.txthsn.Size = New System.Drawing.Size(441, 32)
        Me.txthsn.TabIndex = 31
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btndelete.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(1382, 221)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(114, 45)
        Me.btndelete.TabIndex = 10
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnsave.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(1382, 145)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(114, 45)
        Me.btnsave.TabIndex = 9
        Me.btnsave.Text = " &Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnnew
        '
        Me.btnnew.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnnew.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Location = New System.Drawing.Point(1382, 69)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(114, 45)
        Me.btnnew.TabIndex = 8
        Me.btnnew.Text = "&New"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'combocategory
        '
        Me.combocategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combocategory.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combocategory.FormattingEnabled = True
        Me.combocategory.Location = New System.Drawing.Point(196, 71)
        Me.combocategory.Name = "combocategory"
        Me.combocategory.Size = New System.Drawing.Size(441, 32)
        Me.combocategory.TabIndex = 1
        '
        'numsgst
        '
        Me.numsgst.DecimalPlaces = 2
        Me.numsgst.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numsgst.Location = New System.Drawing.Point(196, 232)
        Me.numsgst.Name = "numsgst"
        Me.numsgst.Size = New System.Drawing.Size(441, 32)
        Me.numsgst.TabIndex = 6
        '
        'numcgst
        '
        Me.numcgst.DecimalPlaces = 2
        Me.numcgst.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numcgst.Location = New System.Drawing.Point(196, 192)
        Me.numcgst.Name = "numcgst"
        Me.numcgst.Size = New System.Drawing.Size(441, 32)
        Me.numcgst.TabIndex = 5
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(196, 29)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(441, 32)
        Me.txtid.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(83, 279)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 24)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "HSN Code :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(99, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 24)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "SGST(%) :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(97, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 24)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "CGST(%) :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(89, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 24)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Company :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(129, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 24)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Type :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(94, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Category :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(81, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Product Id :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Location = New System.Drawing.Point(12, 539)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1800, 324)
        Me.Panel3.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.p_id, Me.p_category, Me.p_company, Me.p_type, Me.p_cgst, Me.p_sgst, Me.p_hsn, Me.p_purch_unit, Me.p_sales_unit, Me.p_purch_rate, Me.p_sales_rate})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1798, 322)
        Me.DataGridView1.TabIndex = 0
        '
        'p_id
        '
        Me.p_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.p_id.DataPropertyName = "p_id"
        Me.p_id.HeaderText = "ID"
        Me.p_id.Name = "p_id"
        Me.p_id.ReadOnly = True
        Me.p_id.Visible = False
        '
        'p_category
        '
        Me.p_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.p_category.DataPropertyName = "p_category"
        Me.p_category.HeaderText = "Category"
        Me.p_category.Name = "p_category"
        Me.p_category.ReadOnly = True
        '
        'p_company
        '
        Me.p_company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.p_company.DataPropertyName = "p_company"
        Me.p_company.HeaderText = "Company"
        Me.p_company.Name = "p_company"
        Me.p_company.ReadOnly = True
        '
        'p_type
        '
        Me.p_type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.p_type.DataPropertyName = "p_type"
        Me.p_type.HeaderText = "Type"
        Me.p_type.Name = "p_type"
        Me.p_type.ReadOnly = True
        '
        'p_cgst
        '
        Me.p_cgst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.p_cgst.DataPropertyName = "p_cgst"
        Me.p_cgst.HeaderText = "CGST(%)"
        Me.p_cgst.Name = "p_cgst"
        Me.p_cgst.ReadOnly = True
        '
        'p_sgst
        '
        Me.p_sgst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.p_sgst.DataPropertyName = "p_sgst"
        Me.p_sgst.HeaderText = "SGST(%)"
        Me.p_sgst.Name = "p_sgst"
        Me.p_sgst.ReadOnly = True
        '
        'p_hsn
        '
        Me.p_hsn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.p_hsn.DataPropertyName = "p_hsn"
        Me.p_hsn.HeaderText = "HSN Code"
        Me.p_hsn.Name = "p_hsn"
        Me.p_hsn.ReadOnly = True
        '
        'p_purch_unit
        '
        Me.p_purch_unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.p_purch_unit.DataPropertyName = "p_purch_unit"
        Me.p_purch_unit.HeaderText = "Purchase Unit"
        Me.p_purch_unit.Name = "p_purch_unit"
        Me.p_purch_unit.ReadOnly = True
        '
        'p_sales_unit
        '
        Me.p_sales_unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.p_sales_unit.DataPropertyName = "p_sales_unit"
        Me.p_sales_unit.HeaderText = "Sales Unit"
        Me.p_sales_unit.Name = "p_sales_unit"
        Me.p_sales_unit.ReadOnly = True
        '
        'p_purch_rate
        '
        Me.p_purch_rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.p_purch_rate.DataPropertyName = "p_purch_rate"
        Me.p_purch_rate.HeaderText = "Purchase Rate"
        Me.p_purch_rate.Name = "p_purch_rate"
        Me.p_purch_rate.ReadOnly = True
        '
        'p_sales_rate
        '
        Me.p_sales_rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.p_sales_rate.DataPropertyName = "p_sales_rate"
        Me.p_sales_rate.HeaderText = "Sales Rate"
        Me.p_sales_rate.Name = "p_sales_rate"
        Me.p_sales_rate.ReadOnly = True
        '
        'Product_Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(95, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1837, 875)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Product_Master"
        Me.Text = "Product_Master"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numsgst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numcgst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents combopunit As ComboBox
    Friend WithEvents combocategory As ComboBox
    Friend WithEvents numsgst As NumericUpDown
    Friend WithEvents numcgst As NumericUpDown
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnnew As Button
    Friend WithEvents combotype As ComboBox
    Friend WithEvents combocompany As ComboBox
    Friend WithEvents txthsn As TextBox
    Friend WithEvents txtsrate As TextBox
    Friend WithEvents txtprate As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents combosunit As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents p_id As DataGridViewTextBoxColumn
    Friend WithEvents p_category As DataGridViewTextBoxColumn
    Friend WithEvents p_company As DataGridViewTextBoxColumn
    Friend WithEvents p_type As DataGridViewTextBoxColumn
    Friend WithEvents p_cgst As DataGridViewTextBoxColumn
    Friend WithEvents p_sgst As DataGridViewTextBoxColumn
    Friend WithEvents p_hsn As DataGridViewTextBoxColumn
    Friend WithEvents p_purch_unit As DataGridViewTextBoxColumn
    Friend WithEvents p_sales_unit As DataGridViewTextBoxColumn
    Friend WithEvents p_purch_rate As DataGridViewTextBoxColumn
    Friend WithEvents p_sales_rate As DataGridViewTextBoxColumn
End Class
