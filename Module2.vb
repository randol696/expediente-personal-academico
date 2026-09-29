Imports System.Data
Imports System.Data.OleDb
Module Module2
    Public conexion As New OleDbConnection
    Public estado As String
    Public comando As New OleDbCommand

    Sub enlace()
        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath & "\BASE DE DATOS SISTEMA DE EXPEDIENTE PERSONAL Y ACADEMICO.accdb"
            conexion.Open()
            estado = "conectado "
        Catch ex As Exception
            estado = "desconectado "
        End Try
    End Sub
End Module
