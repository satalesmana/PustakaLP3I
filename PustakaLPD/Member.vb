Imports System.Data.SqlClient
Public Class Member
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim query As String

    Private Sub Member_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        show_memer()
    End Sub

    Private Sub show_memer(Optional ByVal keyword As String = "")
        Dim no As Integer = 1
        lvMember.View = View.Details
        lvMember.Columns.Add("NO", 50)
        lvMember.Columns.Add("MEMBER ID", 50)
        lvMember.Columns.Add("NAMA MEMBER", 300)
        lvMember.Columns.Add("TELPON", 150)
        lvMember.Columns.Add("EMAIL", 200)
        lvMember.FullRowSelect = True

        Try
            query = "SELECT * FROM member"
            Call OpenKoneksi()
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader

            Do While dr.Read
                lvMember.Items.Add(no)
                lvMember.Items(lvMember.Items.Count - 1).SubItems.Add(dr("idMember"))
                lvMember.Items(lvMember.Items.Count - 1).SubItems.Add(dr("NamaMember"))
                lvMember.Items(lvMember.Items.Count - 1).SubItems.Add(dr("Telpon"))
                lvMember.Items(lvMember.Items.Count - 1).SubItems.Add(dr("Email"))
                no = no + 1
            Loop
            dr.Close()
            Call CloseKoneksi()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Class