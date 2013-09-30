Imports System.Data
Imports System.Data.SqlClient

Public Class frmDailyBalance
    Private Sub frmDailyBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“LifeDataDataSet.DailyBalance”中。您可以根据需要移动或删除它。
        Me.DailyBalanceTableAdapter.Fill(Me.LifeDataDataSet.DailyBalance)
        'TODO: 调整DataGridView外观
        dgvDailyBalance.Columns(0).Visible = False
        dgvDailyBalance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvDailyBalance.Sort(dgvDailyBalance.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        'TODO: 计算总收支平衡
        Dim Expenditure As Single = 0
        Dim Income As Single = 0
        Try
            Dim dtDailyBalance As DataTable = LifeDataDataSet.Tables("DailyBalance")
            For kk = 0 To dtDailyBalance.Rows.Count - 1
                If dtDailyBalance.Rows(kk).Item("Direction") = "支出" Then
                    Expenditure += dtDailyBalance.Rows(kk).Item("Money")
                Else
                    Income += dtDailyBalance.Rows(kk).Item("Money")
                End If
            Next
        Catch ex As Exception
            MsgBox("计算总收支平衡错误：" & vbCrLf & ex.Message)
        End Try
        ssTotalBalanceLable.Text = "总支出：" & Expenditure & "     " & "总收入：" & Income & "    " & "总收支平衡：" & Income - Expenditure
        If Income - Expenditure < 0 Then
            ssTotalBalanceLable.ForeColor = Color.Red
        Else
            ssTotalBalanceLable.ForeColor = Color.Green
        End If
    End Sub

    Private Function LoadDailyBalance() As DataTable
        '加载日常数据

        REM-操作SQL数据库用类-
        Dim ConnectionString As String = "Data Source=.;Initial Catalog=LifeData;Persist Security Info=True;User ID=sa;Password=06e1953509ff7a451971a3522ec99851"   '连接用字符串
        Dim objConnection As New SqlConnection(ConnectionString)    '数据库链接
        Dim objCommand As New SqlCommand
        Dim objDataAdapter As New SqlDataAdapter
        Dim objDataSet As New DataSet
        Dim objDataTable As New DataTable



        Return objDataTable
    End Function

    Private Sub 修改ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 修改ToolStripMenuItem.Click

    End Sub
End Class