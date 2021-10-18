Imports System.Data.SqlClient

Module SQLServerConnection
    Public StringConnection As String = "Data Source =DESKTOP-2VS00LB;Initial Catalog=UserData;Integrated Security=True"

    Function ExecuteSQL(sql As String) As DataTable

        Try

            Dim connection As New SqlConnection
            Dim adapter As SqlDataAdapter
            Dim dt As New DataTable

            connection.ConnectionString = StringConnection
            connection.Open()

            adapter = New SqlDataAdapter(sql, connection)
            adapter.Fill(dt)

            connection.Close()
            connection = Nothing

            Return dt

        Catch ex As Exception
            MsgBox("An error occured!")
        End Try
    End Function
End Module

