Imports System.Data.SqlClient
Public Class DialogBuku
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim query_id As String
    Private Sub DialogBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        show_list_buku()
    End Sub

    Private Sub show_list_buku(Optional ByVal keyword As String = "")
       

        lvDialogBuku.View = View.Details
        lvDialogBuku.Columns.Add("ID", 50)
        lvDialogBuku.Columns.Add("JUDUL BUKU", 200)
        lvDialogBuku.Columns.Add("PENGARANG", 150)
        lvDialogBuku.Columns.Add("PENERBIT", 200)
        query_id = ""

        lvDialogBuku.FullRowSelect = True

        Try
            Call OpenKoneksi()

            query_id += "SELECT buku.*, penerbit.NamaPenerbit, pengarang.NamaPengarang"
            query_id += " FROM buku"
            query_id += " JOIN penerbit ON penerbit.penerbitId = buku.penerbit"
            query_id += " JOIN pengarang ON pengarang.pengarangId = buku.pengarangId"

            If keyword.Trim <> "" Then
                query_id += " WHERE judul LIKE '%" & keyword & "%'"
            End If

            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader


            Do While dr.Read
                lvDialogBuku.Items.Add(dr("BukuId"))
                lvDialogBuku.Items(lvDialogBuku.Items.Count - 1).SubItems.Add(dr("judul").ToString.Trim)
                lvDialogBuku.Items(lvDialogBuku.Items.Count - 1).SubItems.Add(dr("NamaPengarang").ToString.Trim)
                lvDialogBuku.Items(lvDialogBuku.Items.Count - 1).SubItems.Add(dr("NamaPenerbit").ToString.Trim)
            Loop
            dr.Close()
            Call CloseKoneksi()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub tFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFind.Click
        Dim keyword As String
        keyword = tKeyword.Text
        lvDialogBuku.Clear()
        show_list_buku(keyword)
    End Sub

    Private Sub lvDialogBuku_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvDialogBuku.DoubleClick
        Dim no As Integer
        Dim bukuId As String
        Dim judul As String
        Dim pengarang As String


        no = Pinjam.lvItemPinjam.Items.Count()
        bukuId = lvDialogBuku.SelectedItems(0).SubItems(0).Text
        judul = lvDialogBuku.SelectedItems(0).SubItems(1).Text
        pengarang = lvDialogBuku.SelectedItems(0).SubItems(2).Text

        Pinjam.lvItemPinjam.Items.Add(no + 1)
        Pinjam.lvItemPinjam.Items(Pinjam.lvItemPinjam.Items.Count - 1).SubItems.Add(bukuId)
        Pinjam.lvItemPinjam.Items(Pinjam.lvItemPinjam.Items.Count - 1).SubItems.Add(judul)
        Pinjam.lvItemPinjam.Items(Pinjam.lvItemPinjam.Items.Count - 1).SubItems.Add(pengarang)


        Me.Close()

    End Sub
End Class