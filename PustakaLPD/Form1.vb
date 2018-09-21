Imports System.Data.SqlClient

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call OpenKoneksi()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim strsql As String



        Try

            strsql = "select * from pengarang"
            cmd = New SqlCommand(strsql, conn)
            dr = cmd.ExecuteReader

            cbPengarang.Items.Clear()
            Do While dr.Read
                cbPengarang.Items.Add(dr("pengarangId") & "-" & dr("NamaPengarang"))
            Loop
            dr.Close()


            strsql = "select * from penerbit"
            cmd = New SqlCommand(strsql, conn)
            dr = cmd.ExecuteReader

            cbPenerbit.Items.Clear()
            Do While dr.Read
                cbPenerbit.Items.Add(dr("penerbitId") & "-" & dr("NamaPenerbit"))
            Loop
            dr.Close()

            Call CloseKoneksi()

            show_list_buku()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim pengarang As Array = cbPengarang.Text.Split("-")
        Dim uid As String
        Dim cekStok As Boolean = False


        Try
            Call OpenKoneksi()
            Dim query_id As String = "SELECT MAX(BukuId)+1 AS MXID FROM buku"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            uid = dr("MXID")
            dr.Close()

            If (IsNumeric(tStok.Text)) Then
                cekStok = True
            End If

            If (cekStok = False) Then
                MsgBox("Stok tidak sesuai")
                Exit Sub
            End If



            query = "INSERT INTO buku (BukuId,pengarangId,penerbit,judul,sinopsis,stok) " & _
                    "VALUES (" & uid & "," & pengarang(0) & ",'" & cbPenerbit.Text & "', '" & tJudul.Text & "','" & tSinopsis.Text & "'," & tStok.Text & ")"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()

            MsgBox("Data buku '" + tJudul.Text + "' Berhasil Tersimpan")
            cler_from()

            LVbuku.Clear()
            show_list_buku()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cler_from()
        tJudul.Text = ""
        cbPengarang.Text = ""
        cbPenerbit.Text = ""
        tStok.Text = ""
        tSinopsis.Text = ""
    End Sub


    Private Sub show_list_buku()
        Dim cmd As SqlCommand        Dim dr As SqlDataReader        LVbuku.View = View.Details        LVbuku.Columns.Add("NO", 50)        LVbuku.Columns.Add("JUDUL BUKU", 300)        LVbuku.Columns.Add("PENGARANG", 150)        LVbuku.Columns.Add("PENERBIT", 200)

        Try            Call OpenKoneksi()            Dim query_id As String = "select * from buku"            cmd = New SqlCommand(query_id, conn)            dr = cmd.ExecuteReader            Do While dr.Read                LVbuku.Items.Add(dr("BukuId"))                LVbuku.Items(LVbuku.Items.Count - 1).SubItems.Add(dr("judul"))                LVbuku.Items(LVbuku.Items.Count - 1).SubItems.Add(dr("pengarangId"))                LVbuku.Items(LVbuku.Items.Count - 1).SubItems.Add(dr("penerbit"))            Loop            dr.Close()            Call CloseKoneksi()        Catch ex As Exception            MsgBox(ex.ToString)        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim IdBuku As String
        Dim cmd As SqlCommand        Dim dr As SqlDataReader

        Try
            IdBuku = LVbuku.SelectedItems(0).Text

            Call OpenKoneksi()
            Dim query As String = "delete from buku where BukuId='" + IdBuku + "'"            cmd = New SqlCommand(query, conn)            dr = cmd.ExecuteReader
            Call CloseKoneksi()
            dr.Close()

            LVbuku.Clear()
            show_list_buku()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
       
    End Sub
End Class
