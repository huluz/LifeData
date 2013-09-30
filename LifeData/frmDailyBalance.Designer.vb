<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyBalance
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
        Me.dgvDailyBalance = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoneyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsDGV = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.修改ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyBalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LifeDataDataSet = New LifeData.LifeDataDataSet()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMoney = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.DailyBalanceTableAdapter = New LifeData.LifeDataDataSetTableAdapters.DailyBalanceTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnMonthlyBalance = New System.Windows.Forms.Button()
        Me.btnYearlyBalance = New System.Windows.Forms.Button()
        Me.ssTotalyBalance = New System.Windows.Forms.StatusStrip()
        Me.ssTotalBalanceLable = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.dgvDailyBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsDGV.SuspendLayout()
        CType(Me.DailyBalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LifeDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ssTotalyBalance.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvDailyBalance
        '
        Me.dgvDailyBalance.AutoGenerateColumns = False
        Me.dgvDailyBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDailyBalance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.DirectionDataGridViewTextBoxColumn, Me.MoneyDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.RemarkDataGridViewTextBoxColumn})
        Me.dgvDailyBalance.ContextMenuStrip = Me.cmsDGV
        Me.dgvDailyBalance.DataSource = Me.DailyBalanceBindingSource
        Me.dgvDailyBalance.Location = New System.Drawing.Point(29, 167)
        Me.dgvDailyBalance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvDailyBalance.Name = "dgvDailyBalance"
        Me.dgvDailyBalance.RowTemplate.Height = 27
        Me.dgvDailyBalance.Size = New System.Drawing.Size(778, 404)
        Me.dgvDailyBalance.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "日期"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DirectionDataGridViewTextBoxColumn
        '
        Me.DirectionDataGridViewTextBoxColumn.DataPropertyName = "Direction"
        Me.DirectionDataGridViewTextBoxColumn.HeaderText = "支出/收入"
        Me.DirectionDataGridViewTextBoxColumn.Name = "DirectionDataGridViewTextBoxColumn"
        Me.DirectionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'MoneyDataGridViewTextBoxColumn
        '
        Me.MoneyDataGridViewTextBoxColumn.DataPropertyName = "Money"
        Me.MoneyDataGridViewTextBoxColumn.HeaderText = "金额"
        Me.MoneyDataGridViewTextBoxColumn.Name = "MoneyDataGridViewTextBoxColumn"
        Me.MoneyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "类别"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'RemarkDataGridViewTextBoxColumn
        '
        Me.RemarkDataGridViewTextBoxColumn.DataPropertyName = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.HeaderText = "备注"
        Me.RemarkDataGridViewTextBoxColumn.Name = "RemarkDataGridViewTextBoxColumn"
        Me.RemarkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'cmsDGV
        '
        Me.cmsDGV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.修改ToolStripMenuItem})
        Me.cmsDGV.Name = "cmsDGV"
        Me.cmsDGV.Size = New System.Drawing.Size(109, 28)
        '
        '修改ToolStripMenuItem
        '
        Me.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem"
        Me.修改ToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.修改ToolStripMenuItem.Text = "修改"
        '
        'DailyBalanceBindingSource
        '
        Me.DailyBalanceBindingSource.DataMember = "DailyBalance"
        Me.DailyBalanceBindingSource.DataSource = Me.LifeDataDataSet
        '
        'LifeDataDataSet
        '
        Me.LifeDataDataSet.DataSetName = "LifeDataDataSet"
        Me.LifeDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(80, 28)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(177, 28)
        Me.dtpDate.TabIndex = 2
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"支出", "收入"})
        Me.cmbType.Location = New System.Drawing.Point(329, 32)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(175, 26)
        Me.cmbType.TabIndex = 4
        Me.cmbType.Text = "支出/收入"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "金额"
        '
        'txtMoney
        '
        Me.txtMoney.Location = New System.Drawing.Point(80, 76)
        Me.txtMoney.Name = "txtMoney"
        Me.txtMoney.Size = New System.Drawing.Size(177, 28)
        Me.txtMoney.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "类别"
        '
        'txtCat
        '
        Me.txtCat.Location = New System.Drawing.Point(329, 76)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(175, 28)
        Me.txtCat.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "备注"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(78, 118)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(426, 28)
        Me.txtRemark.TabIndex = 10
        '
        'DailyBalanceTableAdapter
        '
        Me.DailyBalanceTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "日期"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "方向"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(527, 28)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(127, 48)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "添加"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(680, 28)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(127, 48)
        Me.btnRefresh.TabIndex = 15
        Me.btnRefresh.Text = "更新"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnMonthlyBalance
        '
        Me.btnMonthlyBalance.Location = New System.Drawing.Point(527, 98)
        Me.btnMonthlyBalance.Name = "btnMonthlyBalance"
        Me.btnMonthlyBalance.Size = New System.Drawing.Size(127, 48)
        Me.btnMonthlyBalance.TabIndex = 16
        Me.btnMonthlyBalance.Text = "月收支平衡"
        Me.btnMonthlyBalance.UseVisualStyleBackColor = True
        '
        'btnYearlyBalance
        '
        Me.btnYearlyBalance.Location = New System.Drawing.Point(680, 98)
        Me.btnYearlyBalance.Name = "btnYearlyBalance"
        Me.btnYearlyBalance.Size = New System.Drawing.Size(127, 48)
        Me.btnYearlyBalance.TabIndex = 17
        Me.btnYearlyBalance.Text = "年收支平衡"
        Me.btnYearlyBalance.UseVisualStyleBackColor = True
        '
        'ssTotalyBalance
        '
        Me.ssTotalyBalance.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ssTotalBalanceLable})
        Me.ssTotalyBalance.Location = New System.Drawing.Point(0, 597)
        Me.ssTotalyBalance.Name = "ssTotalyBalance"
        Me.ssTotalyBalance.Size = New System.Drawing.Size(845, 25)
        Me.ssTotalyBalance.TabIndex = 18
        Me.ssTotalyBalance.Tag = ""
        '
        'ssTotalBalanceLable
        '
        Me.ssTotalBalanceLable.Name = "ssTotalBalanceLable"
        Me.ssTotalBalanceLable.Size = New System.Drawing.Size(170, 20)
        Me.ssTotalBalanceLable.Text = "ToolStripStatusLabel1"
        '
        'frmDailyBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 622)
        Me.Controls.Add(Me.ssTotalyBalance)
        Me.Controls.Add(Me.btnYearlyBalance)
        Me.Controls.Add(Me.btnMonthlyBalance)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMoney)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.dgvDailyBalance)
        Me.Font = New System.Drawing.Font("楷体", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmDailyBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "日常收支数据"
        CType(Me.dgvDailyBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsDGV.ResumeLayout(False)
        CType(Me.DailyBalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LifeDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ssTotalyBalance.ResumeLayout(False)
        Me.ssTotalyBalance.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDailyBalance As System.Windows.Forms.DataGridView
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMoney As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents LifeDataDataSet As LifeData.LifeDataDataSet
    Friend WithEvents DailyBalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DailyBalanceTableAdapter As LifeData.LifeDataDataSetTableAdapters.DailyBalanceTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirectionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MoneyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnMonthlyBalance As System.Windows.Forms.Button
    Friend WithEvents btnYearlyBalance As System.Windows.Forms.Button
    Friend WithEvents ssTotalyBalance As System.Windows.Forms.StatusStrip
    Friend WithEvents cmsDGV As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 修改ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ssTotalBalanceLable As System.Windows.Forms.ToolStripStatusLabel
End Class
