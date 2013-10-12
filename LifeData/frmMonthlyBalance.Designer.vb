<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonthlyandYearlyBalance
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MonthlyBalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LifeDataDataSet = New LifeData.LifeDataDataSet()
        Me.AnnualyBalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MonthlyBalanceTableAdapter = New LifeData.LifeDataDataSetTableAdapters.MonthlyBalanceTableAdapter()
        Me.AnnualyBalanceTableAdapter = New LifeData.LifeDataDataSetTableAdapters.AnnualyBalanceTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvYearlyBalance = New System.Windows.Forms.DataGridView()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpenditureDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncomeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvMonthlyBalance = New System.Windows.Forms.DataGridView()
        Me.MonthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpenditureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbDirec = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvDailyBalance = New System.Windows.Forms.DataGridView()
        Me.ssMonthlyBalance = New System.Windows.Forms.StatusStrip()
        Me.ssMonthlyBalanceLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmsDGVMonthly = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.删除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsDGVYearly = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.删除ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.MonthlyBalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LifeDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnnualyBalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvYearlyBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMonthlyBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDailyBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ssMonthlyBalance.SuspendLayout()
        Me.cmsDGVMonthly.SuspendLayout()
        Me.cmsDGVYearly.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonthlyBalanceBindingSource
        '
        Me.MonthlyBalanceBindingSource.DataMember = "MonthlyBalance"
        Me.MonthlyBalanceBindingSource.DataSource = Me.LifeDataDataSet
        '
        'LifeDataDataSet
        '
        Me.LifeDataDataSet.DataSetName = "LifeDataDataSet"
        Me.LifeDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnnualyBalanceBindingSource
        '
        Me.AnnualyBalanceBindingSource.DataMember = "AnnualyBalance"
        Me.AnnualyBalanceBindingSource.DataSource = Me.LifeDataDataSet
        '
        'MonthlyBalanceTableAdapter
        '
        Me.MonthlyBalanceTableAdapter.ClearBeforeFill = True
        '
        'AnnualyBalanceTableAdapter
        '
        Me.AnnualyBalanceTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dgvYearlyBalance)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dgvMonthlyBalance)
        Me.GroupBox1.Location = New System.Drawing.Point(940, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 799)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "日常收支统计数据"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(189, 407)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "年收支平衡"
        '
        'dgvYearlyBalance
        '
        Me.dgvYearlyBalance.AutoGenerateColumns = False
        Me.dgvYearlyBalance.BackgroundColor = System.Drawing.Color.White
        Me.dgvYearlyBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvYearlyBalance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.YearDataGridViewTextBoxColumn, Me.ExpenditureDataGridViewTextBoxColumn1, Me.IncomeDataGridViewTextBoxColumn1, Me.BalanceDataGridViewTextBoxColumn1})
        Me.dgvYearlyBalance.DataSource = Me.AnnualyBalanceBindingSource
        Me.dgvYearlyBalance.Location = New System.Drawing.Point(7, 436)
        Me.dgvYearlyBalance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvYearlyBalance.Name = "dgvYearlyBalance"
        Me.dgvYearlyBalance.ReadOnly = True
        Me.dgvYearlyBalance.RowTemplate.Height = 27
        Me.dgvYearlyBalance.Size = New System.Drawing.Size(462, 350)
        Me.dgvYearlyBalance.TabIndex = 5
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        Me.YearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExpenditureDataGridViewTextBoxColumn1
        '
        Me.ExpenditureDataGridViewTextBoxColumn1.DataPropertyName = "Expenditure"
        Me.ExpenditureDataGridViewTextBoxColumn1.HeaderText = "Expenditure"
        Me.ExpenditureDataGridViewTextBoxColumn1.Name = "ExpenditureDataGridViewTextBoxColumn1"
        Me.ExpenditureDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'IncomeDataGridViewTextBoxColumn1
        '
        Me.IncomeDataGridViewTextBoxColumn1.DataPropertyName = "Income"
        Me.IncomeDataGridViewTextBoxColumn1.HeaderText = "Income"
        Me.IncomeDataGridViewTextBoxColumn1.Name = "IncomeDataGridViewTextBoxColumn1"
        Me.IncomeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'BalanceDataGridViewTextBoxColumn1
        '
        Me.BalanceDataGridViewTextBoxColumn1.DataPropertyName = "Balance"
        Me.BalanceDataGridViewTextBoxColumn1.HeaderText = "Balance"
        Me.BalanceDataGridViewTextBoxColumn1.Name = "BalanceDataGridViewTextBoxColumn1"
        Me.BalanceDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "月收支平衡"
        '
        'dgvMonthlyBalance
        '
        Me.dgvMonthlyBalance.AutoGenerateColumns = False
        Me.dgvMonthlyBalance.BackgroundColor = System.Drawing.Color.White
        Me.dgvMonthlyBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMonthlyBalance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MonthDataGridViewTextBoxColumn, Me.ExpenditureDataGridViewTextBoxColumn, Me.IncomeDataGridViewTextBoxColumn, Me.BalanceDataGridViewTextBoxColumn})
        Me.dgvMonthlyBalance.DataSource = Me.MonthlyBalanceBindingSource
        Me.dgvMonthlyBalance.Location = New System.Drawing.Point(6, 53)
        Me.dgvMonthlyBalance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvMonthlyBalance.Name = "dgvMonthlyBalance"
        Me.dgvMonthlyBalance.ReadOnly = True
        Me.dgvMonthlyBalance.RowTemplate.Height = 27
        Me.dgvMonthlyBalance.Size = New System.Drawing.Size(462, 350)
        Me.dgvMonthlyBalance.TabIndex = 3
        '
        'MonthDataGridViewTextBoxColumn
        '
        Me.MonthDataGridViewTextBoxColumn.DataPropertyName = "Month"
        Me.MonthDataGridViewTextBoxColumn.HeaderText = "Month"
        Me.MonthDataGridViewTextBoxColumn.Name = "MonthDataGridViewTextBoxColumn"
        Me.MonthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExpenditureDataGridViewTextBoxColumn
        '
        Me.ExpenditureDataGridViewTextBoxColumn.DataPropertyName = "Expenditure"
        Me.ExpenditureDataGridViewTextBoxColumn.HeaderText = "Expenditure"
        Me.ExpenditureDataGridViewTextBoxColumn.Name = "ExpenditureDataGridViewTextBoxColumn"
        Me.ExpenditureDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IncomeDataGridViewTextBoxColumn
        '
        Me.IncomeDataGridViewTextBoxColumn.DataPropertyName = "Income"
        Me.IncomeDataGridViewTextBoxColumn.HeaderText = "Income"
        Me.IncomeDataGridViewTextBoxColumn.Name = "IncomeDataGridViewTextBoxColumn"
        Me.IncomeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "Balance"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        Me.BalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbDirec)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnWrite)
        Me.GroupBox2.Controls.Add(Me.btnQuery)
        Me.GroupBox2.Controls.Add(Me.cmbMonth)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbYear)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dgvDailyBalance)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(922, 799)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "日常收支数据查询"
        '
        'cmbDirec
        '
        Me.cmbDirec.FormattingEnabled = True
        Me.cmbDirec.Items.AddRange(New Object() {"全部", "收入", "支出"})
        Me.cmbDirec.Location = New System.Drawing.Point(845, 91)
        Me.cmbDirec.Name = "cmbDirec"
        Me.cmbDirec.Size = New System.Drawing.Size(68, 26)
        Me.cmbDirec.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(790, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 19)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "收支"
        '
        'btnWrite
        '
        Me.btnWrite.Enabled = False
        Me.btnWrite.Location = New System.Drawing.Point(794, 175)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(119, 46)
        Me.btnWrite.TabIndex = 52
        Me.btnWrite.Text = "写入数据库"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(794, 123)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(119, 46)
        Me.btnQuery.TabIndex = 51
        Me.btnQuery.Text = "查询"
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"全部", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbMonth.Location = New System.Drawing.Point(845, 59)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(68, 26)
        Me.cmbMonth.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(790, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "月份"
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(845, 27)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(68, 26)
        Me.cmbYear.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(790, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "年份"
        '
        'dgvDailyBalance
        '
        Me.dgvDailyBalance.BackgroundColor = System.Drawing.Color.White
        Me.dgvDailyBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDailyBalance.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvDailyBalance.Location = New System.Drawing.Point(6, 28)
        Me.dgvDailyBalance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvDailyBalance.Name = "dgvDailyBalance"
        Me.dgvDailyBalance.ReadOnly = True
        Me.dgvDailyBalance.RowTemplate.Height = 27
        Me.dgvDailyBalance.Size = New System.Drawing.Size(778, 758)
        Me.dgvDailyBalance.TabIndex = 46
        '
        'ssMonthlyBalance
        '
        Me.ssMonthlyBalance.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ssMonthlyBalanceLabel})
        Me.ssMonthlyBalance.Location = New System.Drawing.Point(0, 821)
        Me.ssMonthlyBalance.Name = "ssMonthlyBalance"
        Me.ssMonthlyBalance.Size = New System.Drawing.Size(1431, 25)
        Me.ssMonthlyBalance.TabIndex = 6
        '
        'ssMonthlyBalanceLabel
        '
        Me.ssMonthlyBalanceLabel.Name = "ssMonthlyBalanceLabel"
        Me.ssMonthlyBalanceLabel.Size = New System.Drawing.Size(178, 20)
        Me.ssMonthlyBalanceLabel.Text = "ssMonthlyBalanceLabel"
        '
        'cmsDGVMonthly
        '
        Me.cmsDGVMonthly.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.删除ToolStripMenuItem})
        Me.cmsDGVMonthly.Name = "cmsDGV"
        Me.cmsDGVMonthly.Size = New System.Drawing.Size(109, 28)
        '
        '删除ToolStripMenuItem
        '
        Me.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem"
        Me.删除ToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.删除ToolStripMenuItem.Text = "删除"
        '
        'cmsDGVYearly
        '
        Me.cmsDGVYearly.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.删除ToolStripMenuItem1})
        Me.cmsDGVYearly.Name = "cmsDGVYearly"
        Me.cmsDGVYearly.Size = New System.Drawing.Size(109, 28)
        '
        '删除ToolStripMenuItem1
        '
        Me.删除ToolStripMenuItem1.Name = "删除ToolStripMenuItem1"
        Me.删除ToolStripMenuItem1.Size = New System.Drawing.Size(108, 24)
        Me.删除ToolStripMenuItem1.Text = "删除"
        '
        'frmMonthlyandYearlyBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1431, 846)
        Me.Controls.Add(Me.ssMonthlyBalance)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("楷体", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMonthlyandYearlyBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "月/年收支数据汇总"
        CType(Me.MonthlyBalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LifeDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnnualyBalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvYearlyBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMonthlyBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvDailyBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ssMonthlyBalance.ResumeLayout(False)
        Me.ssMonthlyBalance.PerformLayout()
        Me.cmsDGVMonthly.ResumeLayout(False)
        Me.cmsDGVYearly.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LifeDataDataSet As LifeData.LifeDataDataSet
    Friend WithEvents MonthlyBalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MonthlyBalanceTableAdapter As LifeData.LifeDataDataSetTableAdapters.MonthlyBalanceTableAdapter
    Friend WithEvents AnnualyBalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnnualyBalanceTableAdapter As LifeData.LifeDataDataSetTableAdapters.AnnualyBalanceTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvYearlyBalance As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvMonthlyBalance As System.Windows.Forms.DataGridView
    Friend WithEvents YearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpenditureDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IncomeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpenditureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IncomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvDailyBalance As System.Windows.Forms.DataGridView
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnWrite As System.Windows.Forms.Button
    Friend WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbDirec As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ssMonthlyBalance As System.Windows.Forms.StatusStrip
    Friend WithEvents ssMonthlyBalanceLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmsDGVMonthly As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 删除ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsDGVYearly As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 删除ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
