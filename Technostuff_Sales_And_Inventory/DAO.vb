Imports System.Data.SqlClient 'namespace to work with sql server database

Public Class DAO
    Private conn As SqlConnection  'to connect with your database/datasource
    Public Sub New() 'constructor
        Try ' displays error
            conn = New SqlConnection("Data Source=103.212.121.67;Initial Catalog=data_stu6;Persist Security Info=True;User ID=data_stu6;Password=Lovecoding@6750")
            'established connection 
            'connection string from property of table
            conn.Open()

            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Check Your Connectivity")
        End Try

    End Sub
    Public Sub closeconnection() ' to close connection with the database
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
    Public Function getdata(ByVal str As String) As SqlDataReader 'used to execute any select query
        Try

            Dim obj As SqlDataReader ' connected data object to fetch data from database,need live connection
            Dim cmd As New SqlCommand(str, conn) ' need 2 parameter,str for query and conn for connection
            conn.Close()
            conn.Open() ' opened connection
            obj = cmd.ExecuteReader 'to execute the query
            Return obj
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    'execute reader = read select query
    'execute non query = execute dml query
    'execute scalar = works with dual table
    Public Sub adddata(ByVal str As String) ' pass query in str to execute
        Dim cmd As New SqlCommand(str, conn)
        conn.Open()
        cmd.ExecuteNonQuery() ' to execute query except select
        conn.Close()

    End Sub
    Public Function loaddata(ByVal str As String) As Data.DataSet 'dataset = disconnceted data model
        Dim ds As New Data.DataSet 'dataset = keep more than 1 table in dataset and its discription
        Dim da As New SqlClient.SqlDataAdapter(str, conn) 'need conn=connection and str=query
        conn.Close()
        conn.Open()
        da.SelectCommand.ExecuteReader()
        'after data is fetched into data adapter close connection
        conn.Close()
        da.Fill(ds) ' fills dataset with data from object of database
        Return ds ' returns the dataset
    End Function
    Public Function number_validate(ByVal c As Char, ByVal hc As Integer) As Boolean
        Dim f As Boolean = True
        If (c <> "" And IsNumeric(c)) Or hc = 524296 Or hc = 3014702 Then
            f = False
        End If
        Return f
    End Function
    Public Function isalphanumeric_validate(ByVal c As Char, ByVal hc As Integer) As Boolean
        Dim f As Boolean = True
        If (UCase(c) >= "A" And UCase(c) <= "Z") Or IsNumeric(c) Or hc = 524296 Or hc = 3014702 Then
            f = False
        End If
        Return f
    End Function
    Public Function isalpha_validate(ByVal c As Char, ByVal hc As Integer) As Boolean
        Dim f As Boolean = True
        If (UCase(c) >= "A" And UCase(c) <= "Z") Or hc = 524296 Or hc = 3014702 Or c = " " Then
            f = False
        End If
        Return f
    End Function


    Public Function validate(ByVal str As String) As Integer
        Dim f As Integer = 0
        Dim obj As SqlDataReader
        conn.Open()
        obj = getdata(str)
        While obj.Read
            f = 1
        End While
        closeconnection()
        Return f
    End Function
    Public Sub ModifyData(ByVal str As String)
        conn.Open()
        Dim cmd As New SqlCommand(str, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub

    Public Sub combo_select(e As KeyEventArgs)
        If e.KeyCode = Keys.Up And e.KeyCode = Keys.Down Then
            e.SuppressKeyPress = True
        Else
            e.SuppressKeyPress = False
        End If
    End Sub
    Public Sub enable_design(datagridview1 As DataGridView)
        datagridview1.BorderStyle = BorderStyle.None
        datagridview1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(127, 181, 255)
        datagridview1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black
        datagridview1.DefaultCellStyle.Font = New Font("calibri", 14)
        datagridview1.DefaultCellStyle.BackColor = Color.FromArgb(196, 221, 255)
        datagridview1.EnableHeadersVisualStyles = False
        datagridview1.BorderStyle = BorderStyle.None
        datagridview1.ColumnHeadersDefaultCellStyle.Font = New Font("calibri", 16)
        datagridview1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(19, 59, 92)
        datagridview1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        datagridview1.AllowUserToAddRows = False
        datagridview1.AllowUserToDeleteRows = False
        datagridview1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
End Class

