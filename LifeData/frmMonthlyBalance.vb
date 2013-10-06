Imports System.Data
Imports System.Data.SqlClient

Public Class frmMonthlyandYearlyBalance
    Dim Expenditure As Single, Income As Single, Balance As Single

    Private Sub frmMonthlyandYearlyBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FilldgvMonthlyBalance()
            FilldgvYearlyBalance()
            'TODO: 填充cmbYear数据
            cmbYear.Items.Add("全部")
            For kk = 2013 To Now.Year
                cmbYear.Items.Add(kk)
            Next
            'TODO: 加载本月收支数据
            cmbYear.Text = Now.Year
            cmbMonth.Text = Now.Month
            cmbDirec.Text = "全部"
            btnQuery_Click(sender, e)
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
        If strDirec = "全部" Then
            CalBalance(dtResults)
        Else
            ssMonthlyBalanceLabel.Text = ""
        End If

        'TODO: 调整外观
        dgvDailyBalance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvDailyBalance.Sort(dgvDailyBalance.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        dgvDailyBalance.Columns(0).Visible = False
        dgvDailyBalance.Columns(1).HeaderText = "日期"
        dgvDailyBalance.Columns(2).HeaderText = "收入/支出"
        dgvDailyBalance.Columns(3).HeaderText = "金额"
        dgvDailyBalance.Columns(4).HeaderText = "类别"
        dgvDailyBalance.Columns(5).HeaderText = "备注"
        btnWrite.Enabled = True
    End Sub

    Private Sub dgvMonthlyBalance_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvMonthlyBalance.CellMouseDown
        DGVRightClick(sender, e, dgvMonthlyBalance, cmsDGVMonthly, MousePosition)
    End Sub

    Private Sub dgvYearlyBalance_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvYearlyBalance.CellMouseDown
        DGVRightClick(sender, e, dgvYearlyBalance, cmsDGVYearly, MousePosition)
    End Sub

    Private Sub CalBalance(ByVal dtBalance As DataTable)
        'TODO: 计算月收支平衡
        Expenditure = 0 : Income = 0 : Balance = 0
        For kk = 1 To dtBalance.Rows.Count
            If dtBalance.Rows(kk - 1).Item("Direction") = "收入" Then
                Income += dtBalance.Rows(kk - 1).Item("Money")
            Else
                Expenditure += dtBalance.Rows(kk - 1).Item("Money")
            End If
        Next
        Balance = Income - Expenditure
        ssMonthlyBalanceLabel.Text = "月支出：" & Format(Expenditure, ".00") & "    月收入：" & Format(Income, ".00") & "    月收支平衡：" & Format(Balance, ".00")
        If Balance < 0 Then
            ssMonthlyBalanceLabel.ForeColor = Color.Red
        Else
            ssMonthlyBalanceLabel.ForeColor = Color.Green
        End If
    End Sub

    Private Sub 删除ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除ToolStripMenuItem.Click
        Dim strMonth As String, SelectedRowNum As Integer, cmdString As String

        If MsgBox("确定删除所选行数据？", vbYesNo) = vbYes Then
            SelectedRowNum = dgvMonthlyBalance.CurrentCell.RowIndex   '获取参数
            Try
                strMonth = dgvMonthlyBalance.Rows(SelectedRowNum).Cells(0).Value
                cmdString = "DELETE FROM [LifeData].[dbo].[MonthlyBalance] Where Month='" & strMonth & "'"
                ExexuteSQL(cmdString)
                FilldgvMonthlyBalance()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub 删除ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 删除ToolStripMenuItem1.Click
        Dim strYear As String, SelectedRowNum As Integer, cmdString As String

        If MsgBox("确定删除所选行数据？", vbYesNo) = vbYes Then
            SelectedRowNum = dgvYearlyBalance.CurrentCell.RowIndex   '获取参数
            Try
                strYear = dgvYearlyBalance.Rows(SelectedRowNum).Cells(0).Value
                cmdString = "DELETE FROM [LifeData].[dbo].[AnnualyBalance] Where Year='" & strYear & "'"
                ExexuteSQL(cmdString)
                FilldgvYearlyBalance()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        Dim objSQLADapter As SqlDataAdapter, cmdString As String, dtResults As New DataTable
        Dim strMonth As String, strYear As String

        strMonth = cmbMonth.Text
        strYear = cmbYear.Text
        If strYear = "全部" Then  '不写入数据库
            Exit Sub
        ElseIf strMonth = "全部" Then '写入AnnualyBalance表
            cmdString = "SELECT * FROM [LifeData].[dbo].[AnnualyBalance] WHERE Year='" & strYear & "'"
            objSQLADapter = QuerySQL(cmdString)
            objSQLADapter.Fill(dtResults)
            If dtResults.Rows.Count = 0 Then    '新加数据
                cmdString = "INSERT INTO [LifeData].[dbo].[AnnualyBalance] (Year, Expenditure, Income, Balance) VALUES ('" & strYear & "'," & Expenditure & "," & Income & "," & Balance & ")"
            Else    '更新数据
                cmdString = "UPDATE [LifeData].[dbo].[AnnualyBalance] SET Expenditure=" & Expenditure & ",Income=" & Income & ",Balance=" & Balance & " WHERE Year='" & strYear & "'"
            End If
            ExexuteSQL(cmdString)
            FilldgvYearlyBalance()
        Else    '写入MonthlyBalance表
            cmdString = "SELECT * FROM [LifeData].[dbo].[MonthlyBalance] WHERE Month='" & strYear & "-" & strMonth & "'"
            objSQLADapter = QuerySQL(cmdString)
            objSQLADapter.Fill(dtResults)
            If dtResults.Rows.Count = 0 Then
                cmdString = "INSERT INTO [LifeData].[dbo].[MonthlyBalance] (Month, Expenditure, Income, Balance) VALUES ('" & strYear & "-" & strMonth & "'," & Expenditure & "," & Income & "," & Balance & ")"
            Else
                cmdString = "UPDATE [LifeData].[dbo].[MonthlyBalance] SET Expenditure=" & Expenditure & ",Income=" & Income & ",Balance=" & Balance & " WHERE Month='" & strYear & "-" & strMonth & "'"
            End If
            ExexuteSQL(cmdString)
            FilldgvMonthlyBalance()
        End If
        btnWrite.Enabled = False
    End Sub

    Private Sub FilldgvMonthlyBalance()
        'TODO: 这行代码将数据加载到表“LifeDataDataSet.MonthlyBalance”中。您可以根据需要移动或删除它。
        Me.MonthlyBalanceTableAdapter.Fill(Me.LifeDataDataSet.MonthlyBalance)
        'TODO: 调整表格外观
        dgvMonthlyBalance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvMonthlyBalance.Sort(dgvMonthlyBalance.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        dgvMonthlyBalance.Columns(0).HeaderText = "月份"
        dgvMonthlyBalance.Columns(1).HeaderText = "支出"
        dgvMonthlyBalance.Columns(2).HeaderText = "收入"
        dgvMonthlyBalance.Columns(3).HeaderText = "收支平衡"
    End Sub

    Private Sub FilldgvYearlyBalance()
        'TODO: 这行代码将数据加载到表“LifeDataDataSet.YearlyBalance”中。您可以根据需要移动或删除它。
        Me.AnnualyBalanceTableAdapter.Fill(Me.LifeDataDataSet.AnnualyBalance)
        'TODO: 调整表格外观
        dgvYearlyBalance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvYearlyBalance.Sort(dgvYearlyBalance.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        dgvYearlyBalance.Columns(0).HeaderText = "年份"
        dgvYearlyBalance.Columns(1).HeaderText = "支出"
        dgvYearlyBalance.Columns(2).HeaderText = "收入"
        dgvYearlyBalance.Columns(3).HeaderText = "收支平衡"
    End Sub
End Class