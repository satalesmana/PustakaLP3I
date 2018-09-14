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

        Try
            Call OpenKoneksi()
            Dim query_id As String = "SELECT MAX(BukuId)+1 AS MXID FROM buku"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            uid = dr("MXID")
            dr.Close()

            query = "INSERT INTO buku (BukuId,pengarangId,penerbit,judul,sinopsis,stok) " & _
                    "VALUES (" & uid & "," & pengarang(0) & ",'" & cbPenerbit.Text & "', '" & tJudul.Text & "','" & tSinopsis.Text & "'," & tStok.Text & ")"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


  
End Class
