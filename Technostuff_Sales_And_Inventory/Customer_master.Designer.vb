<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customer_master
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer_master))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.c_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c_gst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtgst = New System.Windows.Forms.TextBox()
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
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1800, 121)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(610, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(727, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(461, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Master"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtgst)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtcontact)
        Me.Panel4.Controls.Add(Me.btnnew)
        Me.Panel4.Controls.Add(Me.btndelete)
        Me.Panel4.Controls.Add(Me.btnsave)
        Me.Panel4.Controls.Add(Me.txtaddress)
        Me.Panel4.Controls.Add(Me.txtemail)
        Me.Panel4.Controls.Add(Me.txtname)
        Me.Panel4.Controls.Add(Me.txtid)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(12, 178)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1800, 281)
        Me.Panel4.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(886, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 35)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "GST No:"
        '
        'txtcontact
        '
        Me.txtcontact.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontact.Location = New System.Drawing.Point(209, 136)
        Me.txtcontact.MaxLength = 10
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(555, 40)
        Me.txtcontact.TabIndex = 1
        '
        'btnnew
        '
        Me.btnnew.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnnew.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Location = New System.Drawing.Point(209, 206)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(129, 46)
        Me.btnnew.TabIndex = 5
        Me.btnnew.Text = "&New"
        Me.btnnew.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btndelete.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(503, 206)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(129, 46)
        Me.btndelete.TabIndex = 7
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnsave.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(356, 206)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(129, 46)
        Me.btnsave.TabIndex = 6
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(1007, 82)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(652, 103)
        Me.txtaddress.TabIndex = 3
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(1007, 28)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(652, 40)
        Me.txtemail.TabIndex = 2
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(209, 83)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(555, 40)
        Me.txtname.TabIndex = 0
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(209, 28)
        Me.txtid.Name = "txtid"
        Me.txtid.ReadOnly = True
        Me.txtid.Size = New System.Drawing.Size(555, 40)
        Me.txtid.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(871, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 35)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Address :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(897, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 35)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Email :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(78, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 35)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Contact :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(95, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 35)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(33, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 35)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Customer Id :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(12, 465)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1800, 398)
        Me.Panel1.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c_id, Me.c_name, Me.c_contact, Me.c_email, Me.c_address, Me.c_gst})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1800, 398)
        Me.DataGridView1.TabIndex = 0
        '
        'c_id
        '
        Me.c_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.c_id.DataPropertyName = "c_id"
        Me.c_id.HeaderText = "ID"
        Me.c_id.Name = "c_id"
        Me.c_id.ReadOnly = True
        '
        'c_name
        '
        Me.c_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.c_name.DataPropertyName = "c_name"
        Me.c_name.HeaderText = "Customer Name"
        Me.c_name.Name = "c_name"
        Me.c_name.ReadOnly = True
        '
        'c_contact
        '
        Me.c_contact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.c_contact.DataPropertyName = "c_contact"
        Me.c_contact.HeaderText = "Contact No"
        Me.c_contact.Name = "c_contact"
        Me.c_contact.ReadOnly = True
        '
        'c_email
        '
        Me.c_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.c_email.DataPropertyName = "c_email"
        Me.c_email.HeaderText = "Email ID"
        Me.c_email.Name = "c_email"
        Me.c_email.ReadOnly = True
        '
        'c_address
        '
        Me.c_address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.c_address.DataPropertyName = "c_address"
        Me.c_address.HeaderText = "Address"
        Me.c_address.Name = "c_address"
        Me.c_address.ReadOnly = True
        '
        'c_gst
        '
        Me.c_gst.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.c_gst.DataPropertyName = "c_gst"
        Me.c_gst.HeaderText = "GST Number"
        Me.c_gst.Name = "c_gst"
        Me.c_gst.ReadOnly = True
        '
        'txtgst
        '
        Me.txtgst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtgst.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgst.Location = New System.Drawing.Point(1007, 204)
        Me.txtgst.MaxLength = 15
        Me.txtgst.Name = "txtgst"
        Me.txtgst.Size = New System.Drawing.Size(652, 40)
        Me.txtgst.TabIndex = 24
        '
        'Customer_master
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
        Me.Name = "Customer_master"
        Me.Text = "Form1"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnnew As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents c_id As DataGridViewTextBoxColumn
    Friend WithEvents c_name As DataGridViewTextBoxColumn
    Friend WithEvents c_contact As DataGridViewTextBoxColumn
    Friend WithEvents c_email As DataGridViewTextBoxColumn
    Friend WithEvents c_address As DataGridViewTextBoxColumn
    Friend WithEvents c_gst As DataGridViewTextBoxColumn
    Friend WithEvents txtgst As TextBox
End Class
