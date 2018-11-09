Imports System.Data.SqlClient
Public Class DialogMember
    Dim query As String
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Private Sub DialogMember_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        show_memer()
    End Sub

    Private Sub show_memer(Optional ByVal keyword As String = "")
        Dim filter As String = ""
        Dim no As Integer = 1

        lvDialogMember.View = View.Details
        lvDialogMember.Columns.Add("NO", 30)
        lvDialogMember.Columns.Add("ID", 40)
        lvDialogMember.Columns.Add("NAMA MEMBER", 150)
        lvDialogMember.Columns.Add("TELPON", 100)
        lvDialogMember.Columns.Add("EMAIL", 100)

        lvDialogMember.FullRowSelect = True

        Try
            If (keyword <> "") Then
                filter = "WHERE NamaMember LIKE '%" & keyword & "%'"
            End If
            query = "SELECT * FROM member " & filter
            Call OpenKoneksi()
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader

            Do While dr.Read
                lvDialogMember.Items.Add(no)
                lvDialogMember.Items(lvDialogMember.Items.Count - 1).SubItems.Add(dr("idMember").ToString.Trim)
                lvDialogMember.Items(lvDialogMember.Items.Count - 1).SubItems.Add(dr("NamaMember").ToString.Trim)
                lvDialogMember.Items(lvDialogMember.Items.Count - 1).SubItems.Add(dr("Telpon").ToString.Trim)
                lvDialogMember.Items(lvDialogMember.Items.Count - 1).SubItems.Add(dr("Email").ToString.Trim)
                no = no + 1
            Loop
            dr.Close()
            Call CloseKoneksi()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub lvDialogMember_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvDialogMember.DoubleClick
        Dim sendValue As String = ""
        sendValue = lvDialogMember.SelectedItems(0).SubItems(1).Text
        sendValue += "-" & lvDialogMember.SelectedItems(0).SubItems(2).Text

        Pinjam.tIdMember.Text = sendValue.Trim
        Me.Close()
    End Sub

    Private Sub lvDialogMember_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvDialogMember.SelectedIndexChanged

    End Sub
End Class