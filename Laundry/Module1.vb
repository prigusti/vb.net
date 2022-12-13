Imports System.Data.SqlClient

Module Module1
    Public conn As SqlConnection
    Public data As SqlDataAdapter
    Public datas As DataSet
    Public read As SqlDataReader
    Public Cmd As SqlCommand
    Public DB As String

    Public Sub koneksi()
        DB = "Data Source = DESKTOP-E19J5GQ; initial catalog = DB_Laundry;integrated security =true"
        conn = New SqlConnection(DB)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

End Module
