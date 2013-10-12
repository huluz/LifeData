Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmDailyBalance
    Dim RefreshID As Integer = 0    '用于更新的数据组ID
    Dim strDate As String, strDirec As String, strCate As String, strRemark As String   '日期、收支方向、类别、备注
    Dim Money As Single '金额

    Private Sub frmDailyBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: 这行代码将数据加载到表“LifeDataDataSet.DailyBalance”中。您可以根据需要移动或删除它。
        Me.DailyBalanceTableAdapter.Fill(Me.LifeDataDataSet.DailyBalance)
        'TODO: 调整DataGridView外观
        dgvDailyBalance.Columns(0).Visible = False
        dgvDailyBalance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvDailyBalance.Sort(dgvDailyBalance.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        dgvDailyBalance.Columns(1).HeaderText = "日期"
        dgvDailyBalance.Columns(2).HeaderText = "收入/支出"
        dgvDailyBalance.Columns(3).HeaderText = "金额"
        dgvDailyBalance.Columns(4).HeaderText = "类别"
        dgvDailyBalance.Columns(5).HeaderText = "备注"
        
        DrawDailyBalanceChart()
        DrawMonthlyBalanceChart()
        DrawTotalBalanceChart()
        ssTotalBalance.Text = ""

        'ssTotalBalance.Text = "总支出：" & Format(Expenditure, ".00") & "    总收入：" & Format(Income, ".00") & "    总收支平衡：" & Format(Balance, ".00")
        'If Balance >= 0 Then
        '    ssTotalBalance.ForeColor = Color.Green
        'Else
        '    ssTotalBalance.ForeColor = Color.Red
        'End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim cmdString As String

        If RefreshID > 0 Then
            MsgBox("请点击更新按钮")
            Exit Sub
        End If

        CollectInputs()
        If strDate = "" Or strDirec = "" Or strCate = "" Or Money <= 0 Then
            MsgBox("输入不完整")
            Exit Sub
        End If

        cmdString = "INSERT INTO [LifeData].[dbo].[DailyBalance] (Date,Direction,Money,Category,Remark) VALUES ('" & strDate & "','" & strDirec & "'," & Money.ToString & ",'" & strCate & "','" & strRemark & "')"
        ExexuteSQL(cmdString)
        ClearInputs()
        frmDailyBalance_Load(sender, e)
    End Sub

    Private Sub dgvDailyBalance_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvDailyBalance.CellMouseDown
        DGVRightClick(sender, e, dgvDailyBalance, cmsDGV, MousePosition)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim cmdString As String

        CollectInputs()
        If strDate = "" Or strDirec = "" Or strCate = "" Or Money <= 0 Then
            MsgBox("输入不完整")
            Exit Sub
        End If

        cmdString = "UPDATE [LifeData].[dbo].[DailyBalance] SET Date = '" & strDate & "',Direction = '" & strDirec & "',Money = " & Money.ToString & ",Category = '" & strCate & "',Remark = '" & strRemark & "' WHERE ID = " & RefreshID
        ExexuteSQL(cmdString)
        frmDailyBalance_Load(sender, e)

        RefreshID = 0
        ClearInputs()
        btnRefresh.Enabled = False
        btnAdd.Enabled = True
    End Sub

    Private Sub 修改ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 修改ToolStripMenuItem.Click
        Dim SelectedRowNum As Integer

        SelectedRowNum = dgvDailyBalance.CurrentCell.RowIndex   '获取参数
        RefreshID = dgvDailyBalance.Rows(SelectedRowNum).Cells(0).Value
        If RefreshID <> -1 Then
            btnAdd.Enabled = False
            btnRefresh.Enabled = True
            dtpDate.Value = dgvDailyBalance.Rows(SelectedRowNum).Cells(1).Value '日期
            cmbType.Text = dgvDailyBalance.Rows(SelectedRowNum).Cells(2).Value  '收支方向
            txtMoney.Text = dgvDailyBalance.Rows(SelectedRowNum).Cells(3).Value  '金额
            txtCat.Text = dgvDailyBalance.Rows(SelectedRowNum).Cells(4).Value   '类别
            Try
                txtRemark.Text = dgvDailyBalance.Rows(SelectedRowNum).Cells(5).Value
            Catch ex As Exception
                txtRemark.Text = ""
            End Try
        Else
            RefreshID = 0
        End If
    End Sub

    Private Sub 删除ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除ToolStripMenuItem.Click
        Dim ID As Integer, SelectedRowNum As Integer, cmdString As String

        If MsgBox("确定删除所选行数据？", vbYesNo) = vbYes Then
            SelectedRowNum = dgvDailyBalance.CurrentCell.RowIndex   '获取参数
            ID = dgvDailyBalance.Rows(SelectedRowNum).Cells(0).Value

            If ID <> -1 Then
                cmdString = "DELETE FROM [LifeData].[dbo].[DailyBalance] Where ID = " & ID
                ExexuteSQL(cmdString)
                frmDailyBalance_Load(sender, e)
            End If
        End If
    End Sub

    Private Sub CollectInputs()
        Try
            strDate = dtpDate.Value.Date '日期
            strDirec = cmbType.Text    '收支方向
            strCate = txtCat.Text   '类别
            strRemark = txtRemark.Text  '备注
            Money = txtMoney.Text    '金额
        Catch ex As Exception
            MsgBox("输入错误：" & vbCrLf & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub ClearInputs()
        cmbType.Text = ""
        txtCat.Text = ""
        txtMoney.Text = ""
        txtRemark.Text = ""
    End Sub

    Private Sub DrawTotalBalanceChart()
        'TODO: 计算总收支平衡
        Dim Expenditure As Single = 0, Income As Single = 0, Balance As Single = 0
        Try
            Dim dtDailyBalance As DataTable = LifeDataDataSet.Tables("DailyBalance")
            For kk = 0 To dtDailyBalance.Rows.Count - 1
                If dtDailyBalance.Rows(kk).Item("Direction") = "支出" Then
                    Expenditure += dtDailyBalance.Rows(kk).Item("Money")
                Else
                    Income += dtDailyBalance.Rows(kk).Item("Money")
                End If
            Next
            Balance = Income - Expenditure
        Catch ex As Exception
            MsgBox("计算总收支平衡错误：" & vbCrLf & ex.Message)
        End Try

        'TODO: 绘制总收支平衡图
        Try
            With chartTotalBalance
                .ChartAreas.Clear() '添加图表区域
                Dim caTotalyBalance As New ChartArea("TotalyBalance")
                .ChartAreas.Add(caTotalyBalance)
                AdjustChartView(.ChartAreas("TotalyBalance"))

                .Series.Clear()
                Dim seriesTotalyBalance As New Series("总收支平衡")
                seriesTotalyBalance.ChartType = SeriesChartType.Column
                .Series.Add(seriesTotalyBalance)
                .Series("总收支平衡").Points.AddXY("支出", Format(Expenditure, ".00"))
                .Series("总收支平衡").Points.AddXY("收入", Format(Income, ".00"))
                .Series("总收支平衡").Points.AddXY("收支平衡", Format(Balance, ".00"))
                .Series("总收支平衡").IsValueShownAsLabel = True
                If Balance >= 0 Then
                    .Series("总收支平衡").Color = Color.FromArgb(0, 228, 0)
                Else

                    .Series("总收支平衡").Color = Color.Red
                End If
                'TODO: 调整图例显示效果
                .Legends(0).Docking = Docking.Top
                .Legends(0).BackColor = Color.FromArgb(240, 240, 240)
            End With
        Catch ex As Exception
            MsgBox("绘制总收支平衡图标出错：" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub DrawMonthlyBalanceChart()
        'TODO: 计算当月收支平衡
        Dim objAdapter As SqlDataAdapter, dtResults As New DataTable
        Dim strYear As String, strMonth As String, cmdString As String
        Dim Expenditure As Single = 0, Income As Single = 0, Balance As Single = 0

        strYear = Now.Year
        strMonth = Now.Month
        cmdString = "SELECT * FROM [LifeData].[dbo].[DailyBalance] WHERE Month(Date)='" & strMonth & "' and YEAR(Date)='" & strYear & "'"
        objAdapter = QuerySQL(cmdString)
        objAdapter.Fill(dtResults)
        Expenditure = 0 : Income = 0
        For kk = 1 To dtResults.Rows.Count
            If dtResults.Rows(kk - 1).Item("Direction") = "收入" Then
                Income += dtResults.Rows(kk - 1).Item("Money")
            Else
                Expenditure += dtResults.Rows(kk - 1).Item("Money")
            End If
        Next
        Balance = Income - Expenditure

        'TODO: 绘制月收支平衡图
        Try
            With chartMonthlyBalance
                .ChartAreas.Clear() '添加图表区域
                Dim caMonthlyBanalce As New ChartArea("MonthlyBalance")
                .ChartAreas.Add(caMonthlyBanalce)
                AdjustChartView(.ChartAreas("MonthlyBalance"))

                .Series.Clear()
                Dim seriesMonthlyBalance As New Series("当月收支平衡")
                seriesMonthlyBalance.ChartType = SeriesChartType.Column
                .Series.Add(seriesMonthlyBalance)
                .Series("当月收支平衡").Points.AddXY("支出", Format(Expenditure, ".00"))
                .Series("当月收支平衡").Points.AddXY("收入", Format(Income, ".00"))
                .Series("当月收支平衡").Points.AddXY("收支平衡", Format(Balance, ".00"))
                .Series("当月收支平衡").IsValueShownAsLabel = True
                If Balance >= 0 Then
                    .Series("当月收支平衡").Color = Color.FromArgb(0, 228, 0)
                Else
                    .Series("当月收支平衡").Color = Color.Red
                End If
                'TODO: 调整图例显示效果
                .Legends(0).Docking = Docking.Top
                .Legends(0).BackColor = Color.FromArgb(240, 240, 240)
            End With
        Catch ex As Exception
            MsgBox("绘制月收支平衡图标出错：" & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub DrawDailyBalanceChart()
        'TODO: 获取当月收支平衡数据
        Dim objAdapter As SqlDataAdapter, dtResults As New DataTable
        Dim strYear As String, strMonth As String, cmdString As String

        strYear = Now.Year
        strMonth = Now.Month
        cmdString = "SELECT * FROM [LifeData].[dbo].[DailyBalance] WHERE Month(Date)='" & strMonth & "' and YEAR(Date)='" & strYear & "'"
        objAdapter = QuerySQL(cmdString)
        objAdapter.Fill(dtResults)

        'TODO: 绘制当月日收支折线图
        Try
            With chartDailyBalance
                .ChartAreas.Clear()
                Dim caDailyBalance As New ChartArea("DailyBalance")
                .ChartAreas.Add(caDailyBalance)
                AdjustChartView(.ChartAreas("DailyBalance"))
                .ChartAreas("DailyBalance").AxisY.IsLogarithmic = True
                .ChartAreas("DailyBalance").AxisY.MajorGrid.Enabled = True
                .ChartAreas("DailyBalance").AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot
                .ChartAreas("DailyBalance").AxisY.LabelStyle.Enabled = True
                .ChartAreas("DailyBalance").AxisX.Interval = 7
                .ChartAreas("DailyBalance").AxisX.MajorGrid.Enabled = True
                .ChartAreas("DailyBalance").AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot

                .Series.Clear()
                Dim seriesDailyExpendture As New Series("当月支出数据")   '月支出数据
                seriesDailyExpendture.ChartType = SeriesChartType.Point
                .Series.Add(seriesDailyExpendture)
                For kk = 1 To dtResults.Rows.Count
                    If dtResults.Rows(kk - 1).Item("Direction") = "支出" Then
                        .Series("当月支出数据").Points.AddXY(dtResults.Rows(kk - 1).Item("Date"), dtResults.Rows(kk - 1).Item("Money"))
                    End If
                Next
                AdjustSeries(.Series("当月支出数据"))
                .Series("当月支出数据").MarkerStyle = MarkerStyle.Circle
                .Series("当月支出数据").Color = Color.Red

                Dim seriesDailyIncome As New Series("当月收入数据")   '月收入数据
                seriesDailyIncome.ChartType = SeriesChartType.Point
                .Series.Add(seriesDailyIncome)
                For kk = 1 To dtResults.Rows.Count
                    If dtResults.Rows(kk - 1).Item("Direction") = "收入" Then
                        .Series("当月收入数据").Points.AddXY(dtResults.Rows(kk - 1).Item("Date"), dtResults.Rows(kk - 1).Item("Money"))
                    End If
                Next
                AdjustSeries(.Series("当月收入数据"))
                .Series("当月收入数据").MarkerStyle = MarkerStyle.Diamond
                .Series("当月收入数据").Color = Color.FromArgb(0, 228, 0)

                .Legends(0).Docking = Docking.Top
                .Legends(0).BackColor = Color.FromArgb(240, 240, 240)
            End With
        Catch ex As Exception
            MsgBox("绘制当月收支数据出错" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub AdjustChartView(ByRef objChartArea As ChartArea)   '调整图表外形
        With objChartArea
            'TODO: 调整X轴外形
            .AxisX.ArrowStyle = AxisArrowStyle.Triangle
            .AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont
            .AxisX.MajorGrid.Enabled = False
            .AxisX.MinorGrid.Enabled = False
            .AxisX.MajorTickMark.Enabled = False
            .AxisX.MinorTickMark.Enabled = False

            'TODO: 调整Y轴外形
            .AxisY.ArrowStyle = AxisArrowStyle.Triangle
            .AxisY.Crossing = 0
            .AxisY.LabelStyle.Enabled = False
            .AxisY.MajorGrid.Enabled = False
            .AxisY.MinorGrid.Enabled = False
            .AxisY.MajorTickMark.Enabled = False
            .AxisY.MinorTickMark.Enabled = False

            'TODO: 调整背景色
            .BackColor = Color.FromArgb(240, 240, 240)
        End With
    End Sub

    Private Sub AdjustSeries(ByRef objSeries As Series)
        With objSeries
            .IsValueShownAsLabel = True
            .MarkerSize = 10
        End With
    End Sub

    Private Sub btnDataCollection_Click(sender As Object, e As EventArgs) Handles btnDataCollection.Click
        frmMonthlyandYearlyBalance.Show()
    End Sub
End Class