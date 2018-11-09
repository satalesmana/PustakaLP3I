Imports System.Data.SqlClient

Public Class Form1
    Dim cmd_gl As SqlCommand
    Dim dr_gl As SqlDataReader
    Dim query_gl As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call OpenKoneksi()


        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim strsql As String
        btnUpdate.Visible = False
        tId.Visible = False

        ' Dim todaysdate As String = String.Format("{0:yyyy/MM/dd}", DateTime.Now)

        Try

            strsql = "select * from pengarang"
            cmd = New SqlCommand(strsql, conn)
            dr = cmd.ExecuteReader

            cbPengarang.Items.Clear()
            Do While dr.Read
                cbPengarang.Items.Add(dr("pengarangId") & "-" & dr("NamaPengarang"))
            Loop
            dr.Close()

            'tes perubahan
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
        Dim penerbit As Array = cbPenerbit.Text.Split("-")
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
                    "VALUES (" & uid & "," & pengarang(0) & ",'" & penerbit(0) & "', '" & tJudul.Text & "','" & tSinopsis.Text & "'," & tStok.Text & ")"

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


    Private Sub show_list_buku(Optional ByVal keyword As String = "")
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim query_id As String

        LVbuku.View = View.Details
        LVbuku.Columns.Add("NO", 50)
        LVbuku.Columns.Add("JUDUL BUKU", 300)
        LVbuku.Columns.Add("PENGARANG", 150)
        LVbuku.Columns.Add("PENERBIT", 200)
        query_id = ""

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
                LVbuku.Items.Add(dr("BukuId"))
                LVbuku.Items(LVbuku.Items.Count - 1).SubItems.Add(dr("judul"))
                LVbuku.Items(LVbuku.Items.Count - 1).SubItems.Add(dr("NamaPengarang"))
                LVbuku.Items(LVbuku.Items.Count - 1).SubItems.Add(dr("NamaPenerbit"))
            Loop
            dr.Close()
            Call CloseKoneksi()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim IdBuku As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        Try
            IdBuku = LVbuku.SelectedItems(0).Text

            Call OpenKoneksi()
            Dim query As String = "delete from buku where BukuId='" + IdBuku + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            Call CloseKoneksi()
            dr.Close()

            LVbuku.Clear()
            show_list_buku()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim IdBuku As String
        btnUpdate.Visible = True
        btnSimpan.Visible = False

        Try
            IdBuku = LVbuku.SelectedItems(0).Text

            Call OpenKoneksi()
            Dim query As String = "SELECT buku.*, penerbit.penerbitId, penerbit.NamaPenerbit, " & _
                    "pengarang.NamaPengarang FROM buku " & _
                    "JOIN penerbit ON penerbit.penerbitId=buku.penerbit " & _
                    "JOIN pengarang ON pengarang.pengarangId=buku.pengarangId " & _
                    "WHERE buku.BukuId='" + IdBuku + "'"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Read()

            tJudul.Text = dr("judul")
            cbPengarang.Text = dr("pengarangId") & "-" & dr("NamaPengarang")
            cbPenerbit.Text = dr("penerbitId") & "-" & dr("NamaPenerbit")
            tStok.Text = dr("stok")
            tSinopsis.Text = dr("sinopsis")
            tId.Text = dr("BukuId")

            dr.Close()
            Call CloseKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        btnSimpan.Visible = True
        btnUpdate.Visible = False
        Dim cmbPenerbit As Array = cbPenerbit.Text.Split("-")
        Dim cmbPengarang As Array = cbPengarang.Text.Split("-")
        Try

            Call OpenKoneksi()
            query_gl = "UPDATE buku SET " & _
                "judul = '" & tJudul.Text & "'," & _
                "pengarangId ='" & cmbPengarang(0) & "'," & _
                "penerbit = '" & cmbPenerbit(0) & "', " & _
                "stok = " & tStok.Text & "," & _
                "sinopsis = '" & tSinopsis.Text & "' " & _
                "WHERE BukuId = '" & tId.Text & "'"
            cmd_gl = New SqlCommand(query_gl, conn)
            dr_gl = cmd_gl.ExecuteReader
            dr_gl.Close()
            Call CloseKoneksi()
            cler_from()
            LVbuku.Clear()
            show_list_buku()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        btnSimpan.Visible = True
        btnUpdate.Visible = False
        cler_from()
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim keywod As String = tFind.Text
        LVbuku.Clear()
        show_list_buku(keywod)
    End Sub

    Private Sub tFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tFind.TextChanged
        Dim keywod As String = tFind.Text
        LVbuku.Clear()
        show_list_buku(keywod)
    End Sub
End Class
