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
        Me.cmsDGV = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.修改ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyBalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LifeDataDataSet = New LifeData.LifeDataDataSet()
        Me.DailyBalanceTableAdapter = New LifeData.LifeDataDataSetTableAdapters.DailyBalanceTableAdapter()
        Me.ssTotalyBalance = New System.Windows.Forms.StatusStrip()
        Me.ssTotalBalanceLable = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnDataCollection = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMoney = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.dgvDailyBalance = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoneyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ssCurrentMonthBalanceLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmsDGV.SuspendLayout()
        CType(Me.DailyBalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LifeDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ssTotalyBalance.SuspendLayout()
        CType(Me.dgvDailyBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmsDGV
        '
        Me.cmsDGV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.修改ToolStripMenuItem, Me.删除ToolStripMenuItem})
        Me.cmsDGV.Name = "cmsDGV"
        Me.cmsDGV.Size = New System.Drawing.Size(109, 52)
        '
        '修改ToolStripMenuItem
        '
        Me.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem"
        Me.修改ToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.修改ToolStripMenuItem.Text = "修改"
        '
        '删除ToolStripMenuItem
        '
        Me.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem"
        Me.删除ToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.删除ToolStripMenuItem.Text = "删除"
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
        'DailyBalanceTableAdapter
        '
        Me.DailyBalanceTableAdapter.ClearBeforeFill = True
        '
        'ssTotalyBalance
        '
        Me.ssTotalyBalance.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ssTotalBalanceLable, Me.ssCurrentMonthBalanceLabel})
        Me.ssTotalyBalance.Location = New System.Drawing.Point(0, 612)
        Me.ssTotalyBalance.Name = "ssTotalyBalance"
        Me.ssTotalyBalance.Size = New System.Drawing.Size(817, 25)
        Me.ssTotalyBalance.TabIndex = 18
        Me.ssTotalyBalance.Tag = ""
        '
        'ssTotalBalanceLable
        '
        Me.ssTotalBalanceLable.Name = "ssTotalBalanceLable"
        Me.ssTotalBalanceLable.Size = New System.Drawing.Size(154, 20)
        Me.ssTotalBalanceLable.Text = "ssTotalBalanceLabel"
        '
        'btnDataCollection
        '
        Me.btnDataCollection.Location = New System.Drawing.Point(514, 86)
        Me.btnDataCollection.Name = "btnDataCollection"
        Me.btnDataCollection.Size = New System.Drawing.Size(280, 48)
        Me.btnDataCollection.TabIndex = 58
        Me.btnDataCollection.Text = "财务报表"
        Me.btnDataCollection.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Enabled = False
        Me.btnRefresh.Location = New System.Drawing.Point(667, 16)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(127, 48)
        Me.btnRefresh.TabIndex = 57
        Me.btnRefresh.Text = "更新"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(514, 16)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(127, 48)
        Me.btnAdd.TabIndex = 56
        Me.btnAdd.Text = "添加"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(261, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 19)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "方向"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 19)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "日期"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(65, 106)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(426, 28)
        Me.txtRemark.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "备注"
        '
        'txtCat
        '
        Me.txtCat.Location = New System.Drawing.Point(316, 64)
        Me.txtCat.Name = "txtCat"
        Me.txtCat.Size = New System.Drawing.Size(175, 28)
        Me.txtCat.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "类别"
        '
        'txtMoney
        '
        Me.txtMoney.Location = New System.Drawing.Point(67, 64)
        Me.txtMoney.Name = "txtMoney"
        Me.txtMoney.Size = New System.Drawing.Size(177, 28)
        Me.txtMoney.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "金额"
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"支出", "收入"})
        Me.cmbType.Location = New System.Drawing.Point(316, 20)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(175, 26)
        Me.cmbType.TabIndex = 47
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(67, 16)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(177, 28)
        Me.dtpDate.TabIndex = 46
        '
        'dgvDailyBalance
        '
        Me.dgvDailyBalance.AutoGenerateColumns = False
        Me.dgvDailyBalance.BackgroundColor = System.Drawing.Color.White
        Me.dgvDailyBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDailyBalance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.DirectionDataGridViewTextBoxColumn, Me.MoneyDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.RemarkDataGridViewTextBoxColumn})
        Me.dgvDailyBalance.ContextMenuStrip = Me.cmsDGV
        Me.dgvDailyBalance.Cursor = System.Windows.Forms.Cursors.Default
        Me.dgvDailyBalance.DataSource = Me.DailyBalanceBindingSource
        Me.dgvDailyBalance.Location = New System.Drawing.Point(16, 155)
        Me.dgvDailyBalance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvDailyBalance.Name = "dgvDailyBalance"
        Me.dgvDailyBalance.ReadOnly = True
        Me.dgvDailyBalance.RowTemplate.Height = 27
        Me.dgvDailyBalance.Size = New System.Drawing.Size(778, 439)
        Me.dgvDailyBalance.TabIndex = 45
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DirectionDataGridViewTextBoxColumn
        '
        Me.DirectionDataGridViewTextBoxColumn.DataPropertyName = "Direction"
        Me.DirectionDataGridViewTextBoxColumn.HeaderText = "Direction"
        Me.DirectionDataGridViewTextBoxColumn.Name = "DirectionDataGridViewTextBoxColumn"
        Me.DirectionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MoneyDataGridViewTextBoxColumn
        '
        Me.MoneyDataGridViewTextBoxColumn.DataPropertyName = "Money"
        Me.MoneyDataGridViewTextBoxColumn.HeaderText = "Money"
        Me.MoneyDataGridViewTextBoxColumn.Name = "MoneyDataGridViewTextBoxColumn"
        Me.MoneyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemarkDataGridViewTextBoxColumn
        '
        Me.RemarkDataGridViewTextBoxColumn.DataPropertyName = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.HeaderText = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.Name = "RemarkDataGridViewTextBoxColumn"
        Me.RemarkDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ssCurrentMonthBalanceLabel
        '
        Me.ssCurrentMonthBalanceLabel.Name = "ssCurrentMonthBalanceLabel"
        Me.ssCurrentMonthBalanceLabel.Size = New System.Drawing.Size(221, 20)
        Me.ssCurrentMonthBalanceLabel.Text = "ssCurrentMonthBalanceLabel"
        '
        'frmDailyBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 637)
        Me.Controls.Add(Me.btnDataCollection)
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
        Me.Controls.Add(Me.ssTotalyBalance)
        Me.Font = New System.Drawing.Font("楷体", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmDailyBalance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "日常收支数据"
        Me.cmsDGV.ResumeLayout(False)
        CType(Me.DailyBalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LifeDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ssTotalyBalance.ResumeLayout(False)
        Me.ssTotalyBalance.PerformLayout()
        CType(Me.dgvDailyBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LifeDataDataSet As LifeData.LifeDataDataSet
    Friend WithEvents DailyBalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DailyBalanceTableAdapter As LifeData.LifeDataDataSetTableAdapters.DailyBalanceTableAdapter
    Friend WithEvents ssTotalyBalance As System.Windows.Forms.StatusStrip
    Friend WithEvents cmsDGV As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 修改ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ssTotalBalanceLable As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents 删除ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDataCollection As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMoney As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvDailyBalance As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirectionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MoneyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ssCurrentMonthBalanceLabel As System.Windows.Forms.ToolStripStatusLabel
End Class
