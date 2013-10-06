Imports System.Data
Imports System.Data.SqlClient

Module ExeSQL
    REM-操作SQL数据库用类-
    Dim ConnectionString As String = "Data Source=.;Initial Catalog=LifeData;Persist Security Info=True;User ID=sa;Password=06e1953509ff7a451971a3522ec99851"   '连接用字符串
    Public objConnection As New SqlConnection(ConnectionString)    '数据库链接
    Public objCommand As New SqlCommand
    Public objDataAdapter As SqlDataAdapter

    Public Sub ExexuteSQL(ByVal cmdString As String)
        '操作SQL数据库
        Try
            objConnection.Open()
            objCommand.Connection = objConnection
            objCommand.CommandText = cmdString
            objCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("数据库操作错误：" & vbCrLf & ex.Message)
        Finally
            objConnection.Close()
        End Try
    End Sub

    Public Function QuerySQL(ByVal queryString As String) As SqlDataAdapter
        Try
            objConnection.Open()
            objCommand.Connection = objConnection
            objCommand.CommandText = queryString
            objDataAdapter = New SqlDataAdapter(objCommand)
            Return objDataAdapter
        Catch ex As Exception
            MsgBox("查询数据库出错：" & vbCrLf & ex.Message)
            Exit Function
        Finally
            objConnection.Close()
        End Try
    End Function
End Module
