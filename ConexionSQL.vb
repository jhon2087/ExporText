Imports System.Data
Imports System.Data.SqlClient

Public Class ConexionSQL

    Public Function conectar() As SqlConnection

        Dim cn As New SqlConnection("server=172.14.1.4;database=dbDocument;Uid=devegdn;Password=devegogdn;")
        Return cn

    End Function

End Class
