Imports MySqlConnector

Module DataModule
    ' ============================================================
    '  CRUD HUNTER
    ' ============================================================
    Public Function GetAllHunters() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM Hunters ORDER BY Rank ASC, Level DESC"
            Using conn As MySqlConnection = GetConnection()
                ' INI DIA DATA ADAPTER-NYA!
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan Hunter: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchHunters(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM Hunters WHERE ID LIKE @kw OR Name LIKE @kw OR Specialization LIKE @kw ORDER BY Rank ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari Hunter: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GenerateHunterID() As String
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand("SELECT ID FROM Hunters ORDER BY ID DESC LIMIT 1", conn)
                Dim last As Object = cmd.ExecuteScalar()
                If last Is Nothing OrElse last Is DBNull.Value Then Return "HG-001"
                Dim num As Integer = CInt(last.ToString().Substring(3)) + 1
                Return $"HG-{num.ToString("D3")}"
            End Using
        End Using
    End Function

    Public Function SimpanHunter(id As String, nama As String, rank As String, spec As String, level As Integer, region As String) As Boolean
        Try
            Dim query As String = "INSERT INTO Hunters (ID, Name, Rank, Specialization, Level, Region) VALUES (@id, @nm, @rk, @sp, @lv, @rg)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id) : cmd.Parameters.AddWithValue("@nm", nama)
                    cmd.Parameters.AddWithValue("@rk", rank) : cmd.Parameters.AddWithValue("@sp", spec)
                    cmd.Parameters.AddWithValue("@lv", level) : cmd.Parameters.AddWithValue("@rg", region)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahHunter(id As String, nama As String, rank As String, spec As String, level As Integer, region As String) As Boolean
        Try
            Dim query As String = "UPDATE Hunters SET Name=@nm, Rank=@rk, Specialization=@sp, Level=@lv, Region=@rg WHERE ID=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id) : cmd.Parameters.AddWithValue("@nm", nama)
                    cmd.Parameters.AddWithValue("@rk", rank) : cmd.Parameters.AddWithValue("@sp", spec)
                    cmd.Parameters.AddWithValue("@lv", level) : cmd.Parameters.AddWithValue("@rg", region)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusHunter(id As String) As Boolean
        Try
            Dim query As String = "DELETE FROM Hunters WHERE ID = @id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ============================================================
    '  CRUD QUEST LOG
    ' ============================================================
    Public Function GetAllQuests() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM Quests ORDER BY Difficulty, Status"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan Quest: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SearchQuests(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM Quests WHERE ID LIKE @kw OR Title LIKE @kw OR Difficulty LIKE @kw OR Type LIKE @kw ORDER BY Difficulty"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari Quest: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function GenerateQuestID() As String
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand("SELECT ID FROM Quests ORDER BY ID DESC LIMIT 1", conn)
                Dim last As Object = cmd.ExecuteScalar()
                If last Is Nothing OrElse last Is DBNull.Value Then Return "QT-001"
                Dim num As Integer = CInt(last.ToString().Substring(3)) + 1
                Return $"QT-{num.ToString("D3")}"
            End Using
        End Using
    End Function

    Public Function SimpanQuest(id As String, title As String, diff As String, type As String, reward As String, loc As String, stat As String, desc As String) As Boolean
        Try
            Dim query As String = "INSERT INTO Quests (ID,Title,Difficulty,Type,Reward,Location,Status,Description) VALUES (@id,@ti,@di,@ty,@rw,@lo,@st,@ds)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id) : cmd.Parameters.AddWithValue("@ti", title)
                    cmd.Parameters.AddWithValue("@di", diff) : cmd.Parameters.AddWithValue("@ty", type)
                    cmd.Parameters.AddWithValue("@rw", reward) : cmd.Parameters.AddWithValue("@lo", loc)
                    cmd.Parameters.AddWithValue("@st", stat) : cmd.Parameters.AddWithValue("@ds", desc)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan Quest: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahQuest(id As String, title As String, diff As String, type As String, reward As String, loc As String, stat As String, desc As String) As Boolean
        Try
            Dim query As String = "UPDATE Quests SET Title=@ti, Difficulty=@di, Type=@ty, Reward=@rw, Location=@lo, Status=@st, Description=@ds WHERE ID=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id) : cmd.Parameters.AddWithValue("@ti", title)
                    cmd.Parameters.AddWithValue("@di", diff) : cmd.Parameters.AddWithValue("@ty", type)
                    cmd.Parameters.AddWithValue("@rw", reward) : cmd.Parameters.AddWithValue("@lo", loc)
                    cmd.Parameters.AddWithValue("@st", stat) : cmd.Parameters.AddWithValue("@ds", desc)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah Quest: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusQuest(id As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM Quests WHERE ID=@id", conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module