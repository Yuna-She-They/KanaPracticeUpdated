Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Data
Imports System.Data.SqlClient

Public Class KanaDB
    Public Shared Function GetKana(ByVal kanaID As Integer,
                                   ByVal katakana As Boolean) _
                                   As Boolean
        Dim sql As String = String.Empty
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-1UVADPU;Initial Catalog=Kana;Integrated Security=True")
        Dim cmd As SqlCommand
        Dim blnReturn As Boolean
        Try
            If katakana Then
                sql = "SELECT Romanji, Katakana FROM Kana WHERE ID=@kanaID"
                'Todo: Figure out prams and where clause
            Else
                sql = "SELECT Romanji, Hiragana FROM Kana WHERE ID=@kanaID"
                'Todo: Figure out prams and where clause
            End If

            conn.Open()
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("kanaID", kanaID) '--add one something about kana id
            cmd.ExecuteNonQuery()
            blnReturn = True

        Catch ex As Exception
            '--MsgBox(ex.Message)
            blnReturn = False

        Finally
            If conn IsNot Nothing Then conn.Dispose()
        End Try

        Return blnReturn
    End Function

    Public Shared Function Study(ByVal katakana As Boolean) As Boolean
        Dim sql As String = String.Empty
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-1UVADPU;Initial Catalog=Kana;Integrated Security=True")
        Dim cmd As SqlCommand
        Dim blnReturn As Boolean

        Try
            If katakana Then
                sql = "SELECT Katakana FROM Kana"
            Else
                sql = "SELECT Hiragana FROM Kana"
            End If

            conn.Open()
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            blnReturn = True

        Catch ex As Exception
            '--MsgBox(ex.Message)
            blnReturn = False
        Finally
            If conn IsNot Nothing Then conn.Dispose()
        End Try

        Return blnReturn

    End Function

    Public Shared Function Learn(ByVal katakana As Boolean) As Boolean
        Dim sql As String = String.Empty
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-1UVADPU;Initial Catalog=Kana;Integrated Security=True")
        Dim cmd As SqlCommand
        Dim blnReturn As Boolean

        Try
            If katakana Then
                sql = "SELECT Romanji, Katakana FROM Kana"
            Else
                sql = "SELECT Romanji, Hiragana FROM Kana"
            End If

            conn.Open()
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            blnReturn = True
        Catch ex As Exception
            '--MsgBox(ex.Message)
            blnReturn = False
        Finally
            If conn IsNot Nothing Then conn.Dispose()
        End Try
        Return blnReturn
    End Function

    Public Shared Function GetRandomKana(ByVal katakana As Boolean) As Boolean
        Dim sql As String = String.Empty
        Dim conn As SqlConnection = New SqlConnection("Data Source=DESKTOP-1UVADPU;Initial Catalog=Kana;Integrated Security=True")
        Dim cmd As SqlCommand
        Dim blnReturn As Boolean

        Try
            If katakana Then
                sql = "SELECT TOP 1 Katakana FROM Kana ORDER BY NEWID()"
            Else
                sql = "SELECT TOP 1 Hiragana FROM Kana ORDER BY NEWID()"
            End If

            conn.Open()
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            blnReturn = True
        Catch ex As Exception
            ' -- MsgBox(ex.Message)
            blnReturn = False
        Finally
            If conn IsNot Nothing Then conn.Dispose()
        End Try
        Return blnReturn
    End Function
End Class
