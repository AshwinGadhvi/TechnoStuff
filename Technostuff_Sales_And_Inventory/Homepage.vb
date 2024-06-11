Public Class Homepage
    Private Sub closeall()
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Public flag As Boolean = 0

    Private Sub Homepage_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        End
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        closeall()

        Dim d As New User_Master
        d.MdiParent = Me
        d.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        closeall()

        Dim d As New Customer_master
        d.MdiParent = Me
        d.Show()

    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        closeall()

        Dim d As New supplier_master
        d.MdiParent = Me
        d.Show()
    End Sub

    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        closeall()

        Dim d As New Product_Master
        d.MdiParent = Me
        d.Show()

    End Sub



    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        closeall()

        Dim d As New Category_Master
        d.MdiParent = Me
        d.Show()

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        closeall()
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        closeall()

        Dim d As New Unit_master
        d.MdiParent = Me
        d.Show()
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        closeall()

        Dim d As New Sub_Category_Master
        d.MdiParent = Me
        d.Show()
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        Dim d As New Sales_master
        d.MdiParent = Me
        d.Show()
    End Sub
End Class
