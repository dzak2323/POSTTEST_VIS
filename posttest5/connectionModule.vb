Imports MySqlConnector

Module ConnectionModule
    ' Sesuaikan dengan setting default Laragon (User: root, Password kosong)
    Public ReadOnly ConnectionString As String = "Server=localhost; Port=3306; Database=hunter; User ID=root; Password=;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function
End Module