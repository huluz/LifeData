Module DataGridViewRightClick
    Public Sub DGVRightClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs, ByRef objDataGridView As DataGridView, ByRef objContextMenuStrip As ContextMenuStrip, ByVal objMousePosiont As Object)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
                If objDataGridView.Rows(e.RowIndex).Selected = False Then   '选中行
                    objDataGridView.ClearSelection()
                    objDataGridView.Rows(e.RowIndex).Selected = True
                End If

                If objDataGridView.SelectedRows.Count = 1 Then
                    objDataGridView.CurrentCell = objDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex)
                End If

                objContextMenuStrip.Show(objMousePosiont.X, objMousePosiont.Y)
            End If
        End If
    End Sub
End Module
