Imports Oracle.DataAccess.Client
Imports System.Configuration

Public Class ConnectionFactory


    Public Shared Function GetConnection() As OracleConnection
        Try
            Dim connectionstring As String = ConfigurationManager.ConnectionStrings.Item("OdriaOraDB").ConnectionString
            Dim connection As OracleConnection = New OracleConnection(connectionstring)
            Return connection
        Catch ex As Exception
            MsgBox("Chyba " + ex.Message, , "Chyba")
        End Try
    End Function
End Class
