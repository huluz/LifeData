Imports System.Data
Imports System.Data.SqlClient

Public Class frmMonthlyandYearlyBalance

    Private Sub frmMonthlyandYearlyBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: 这行代码将数据加载到表“LifeDataDataSet.MonthlyBalance”中。您可以根据需要移动或删除它。
            Me.MonthlyBalanceTableAdapter.Fill(Me.LifeDataDataSet.MonthlyBalance)
            'TODO: 这行代码将数据加载到表“LifeDataDataSet.YearlyBalance”中。您可以根据需要移动或删除它。
            Me.AnnualyBalanceTableAdapter.Fill(Me.LifeDataDataSet.AnnualyBalance)
            'TODO: 调整表格外观
            dgvMonthlyBalance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvMonthlyBalance.Sort(dgvMonthlyBalance.Columns(0), System.ComponentModel.ListSortDirection.Descending)
            dgvMonthlyBalance.Columns(0).HeaderText = "月份"
            dgvMonthlyBalance.Columns(1).HeaderText = "支出"
            dgvMonthlyBalance.Columns(2).HeaderText = "收入"
            dgvMonthlyBalance.Columns(3).HeaderText = "收支平衡"
            dgvYearlyBalance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvYearlyBalance.Sort(dgvYearlyBalance.Columns(0), System.ComponentModel.ListSortDirection.Descending)
            dgvYearlyBalance.Columns(0).HeaderText = "年份"
            dgvYearlyBalance.Columns(1).HeaderText = "支出"
            dgvYearlyBalance.Columns(2).HeaderText = "收入"
            dgvYearlyBalance.Columns(3).HeaderText = "收支平衡"
            'TODO: 填充cmbYear数据
            cmbYear.Items.Add("全部")
            For kk = 2013 To Now.Year
                cmbYear.Items.Add(kk)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        Dim queryString As String, objDataAdapter As New SqlDataAdapter
        Dim dtResults As New DataTable
        Dim strYear As String, strMonth As String, strDirec As String

        'TODO: 获取查询参数
        If cmbYear.Text = "" Then
            MsgBox("请选择年份")
            Exit Sub
        Else
            strYear = cmbYear.Text
        End If

        If cmbMonth.Text = "" Then
            MsgBox("请选择月份")
            Exit Sub
        Else
            strMonth = cmbMonth.Text
        End If

        If cmbDirec.Text = "" Then
            MsgBox("请选择收支方向")
            Exit Sub
        Else
            strDirec = cmbDirec.Text
        End If

        'TODO: 查询数据库
        If strDirec = "全部" And strYear = "全部" And strMonth = "全部" Then
            queryString = "SELECT * FROM [LifeData].[dbo].[DailyBalance]"
        ElseIf strDirec = "全部" And strYear = "全部" And strMonth <> "全部" Then
            queryString = "SELECT * FROM [LifeData].[dbo].[DailyBalance] WHERE MONTH(Date) = '" & strMonth & "'"
        ElseIf strDirec = "全部" And strYear <> "全部" And strMonth = "全部" Then
            queryString = "SELECT * FROM [LifeData].[dbo].[DailyBalance] WHERE YEAR(Date) = '" & strYear & "'"
        ElseIf strDirec <> "全部" And strYear = "全部" And strMonth = "全部" Then
            queryString = "SELECT * FROM [LifeData].[dbo].[DailyBalance] WHERE Direction = '" & strDirec & "'"
        ElseIf strDirec <> "全部" And strYear <> "全部" And strMonth = "全部" Then
            queryString = "SELECT * FROM [LifeData].[dbo].[DailyBalance] WHERE Direction = '" & strDirec & "' and YEAR(Date)='" & strYear & "'"
        ElseIf strDirec <> "全部" And strYear = "全部" And strMonth <> "全部" Then
            queryString = "SELECT * FROM [LifeData].[dbo].[DailyBalance] WHERE Direction = '" & strDirec & "' and MONTH(Date)='" & strMonth & "'"
        ElseIf strDirec = "全部" And strYear <> "全部" And strMonth <> "全部" Then
            queryString = "SELECT * FROM [LifeData].[dbo].[DailyBalance] WHERE YEAR(Date)='" & strYear & "' and MONTH(Date)='" & strMonth & "'"
        Else
            queryString = "SELECT * FROM [LifeData].[dbo].[DailyBalance] WHERE Direction='" & strDirec & "' and YEAR(Date)='" & strYear & "' and MONTH(Date)='" & strMonth & "'"
        End If
        objDataAdapter = QuerySQL(queryString)
        objDataAdapter.Fill(dtResults)
        dgvDailyBalance.DataSource = dtResults

        'TODO: 调整外观
        dgvDailyBalance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvDailyBalance.Sort(dgvDailyBalance.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        dgvDailyBalance.Columns(0).Visible = False
        dgvDailyBalance.Columns(1).HeaderText = "日期"
        dgvDailyBalance.Columns(2).HeaderText = "收入/支出"
        dgvDailyBalance.Columns(3).HeaderText = "金额"
        dgvDailyBalance.Columns(4).HeaderText = "类别"
        dgvDailyBalance.Columns(5).HeaderText = "备注"
    End Sub
End Class