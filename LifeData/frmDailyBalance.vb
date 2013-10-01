Imports System.Data
Imports System.Data.SqlClient

Public Class frmDailyBalance
    REM-操作SQL数据库用类-
    Dim ConnectionString As String = "Data Source=.;Initial Catalog=LifeData;Persist Security Info=True;User ID=sa;Password=06e1953509ff7a451971a3522ec99851"   '连接用字符串
    Dim objConnection As New SqlConnection(ConnectionString)    '数据库链接
    Dim objCommand As New SqlCommand
    Dim RefreshID As Integer = 0    '用于更新的数据组ID
    Dim strDate As String, strDirec As String, strCate As String, strRemark As String   '日期、收支方向、类别、备注
    Dim Money As Single '金额

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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim cmdString As String

        If RefreshID > 0 Then
            MsgBox("请点击更新按钮")
            Exit Sub
        End If

        CollectInputs()
        If strDate = "" Or strDirec = "" Or strCate = "" Or strRemark = "" Or Money <= 0 Then
            MsgBox("输入不完整")
            Exit Sub
        End If

        cmdString = "INSERT INTO [LifeData].[dbo].[DailyBalance] (Date,Direction,Money,Category,Remark) VALUES ('" & strDate & "','" & strDirec & "'," & Money.ToString & ",'" & strCate & "','" & strRemark & "')"
        ExexuteSQL(cmdString)
        frmDailyBalance_Load(sender, e)
    End Sub

    Private Sub dgvDailyBalance_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvDailyBalance.CellMouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
                If dgvDailyBalance.Rows(e.RowIndex).Selected = False Then   '选中行
                    dgvDailyBalance.ClearSelection()
                    dgvDailyBalance.Rows(e.RowIndex).Selected = True
                End If

                If dgvDailyBalance.SelectedRows.Count = 1 Then
                    dgvDailyBalance.CurrentCell = dgvDailyBalance.Rows(e.RowIndex).Cells(e.ColumnIndex)
                End If

                Me.cmsDGV.Show(MousePosition.X, MousePosition.Y)
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Dim cmdString As String

        CollectInputs()
        If strDate = "" Or strDirec = "" Or strCate = "" Or strRemark = "" Or Money <= 0 Then
            MsgBox("输入不完整")
            Exit Sub
        End If

        cmdString = "UPDATE [LifeData].[dbo].[DailyBalance] SET Date = '" & strDate & "',Direction = '" & strDirec & "',Money = " & Money.ToString & ",Category = '" & strCate & "',Remark = '" & strRemark & "' WHERE ID = " & RefreshID
        ExexuteSQL(cmdString)
        frmDailyBalance_Load(sender, e)

        RefreshID = 0
        cmbType.Text = ""
        txtCat.Text = ""
        txtMoney.Text = ""
        txtRemark.Text = ""
        btnRefresh.Enabled = False
    End Sub

    Private Sub 修改ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 修改ToolStripMenuItem.Click
        Dim SelectedRowNum As Integer

        btnRefresh.Enabled = True
        SelectedRowNum = dgvDailyBalance.CurrentCell.RowIndex   '获取参数
        RefreshID = dgvDailyBalance.Rows(SelectedRowNum).Cells(0).Value
        dtpDate.Value = dgvDailyBalance.Rows(SelectedRowNum).Cells(1).Value '日期
        cmbType.Text = dgvDailyBalance.Rows(SelectedRowNum).Cells(2).Value  '收支方向
        txtMoney.Text = dgvDailyBalance.Rows(SelectedRowNum).Cells(3).Value  '金额
        txtCat.Text = dgvDailyBalance.Rows(SelectedRowNum).Cells(4).Value   '类别
        Try
            txtRemark.Text = dgvDailyBalance.Rows(SelectedRowNum).Cells(5).Value
        Catch ex As Exception
            txtRemark.Text = ""
        End Try
    End Sub

    Private Sub 删除ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除ToolStripMenuItem.Click
        Dim ID As Integer, SelectedRowNum As Integer, cmdString As String

        If MsgBox("确定删除所选行数据？", vbYesNo) = vbYes Then
            SelectedRowNum = dgvDailyBalance.CurrentCell.RowIndex   '获取参数
            ID = dgvDailyBalance.Rows(SelectedRowNum).Cells(0).Value

            cmdString = "DELETE FROM [LifeData].[dbo].[DailyBalance] Where ID = " & ID
            ExexuteSQL(cmdString)
            frmDailyBalance_Load(sender, e)
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

    Private Sub ExexuteSQL(ByVal cmdString As String)
        Try
            objConnection.Open()
            objCommand.Connection = objConnection
            objCommand.CommandText = cmdString
            objCommand.ExecuteNonQuery()
            objConnection.Close()
        Catch ex As Exception
            MsgBox("数据库操作错误：" & vbCrLf & ex.Message)
        End Try
    End Sub
End Class