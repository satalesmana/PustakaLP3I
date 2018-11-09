Public Class Pinjam

    
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        DialogMember.Show()
    End Sub

    Private Sub Pinjam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tIdMember.ReadOnly = True
        addDropdown()
        show_item_pinjam()
    End Sub

    Private Sub addDropdown()
        tLamaPinjam.Items.Insert(0, "Satu Hari")
        tLamaPinjam.Items.Insert(1, "Dua Hari")
        tLamaPinjam.Items.Insert(2, "Tiga Hari")
        tLamaPinjam.Items.Insert(3, "Empat Hari")
        tLamaPinjam.Items.Insert(4, "Lima Hari")
        tLamaPinjam.Items.Insert(5, "Enam Hari")
        tLamaPinjam.Items.Insert(6, "Tujuh Hari")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim jmlHari As Integer = tLamaPinjam.SelectedIndex.ToString.Trim() + 1
        MsgBox(jmlHari)
    End Sub

    Private Sub btnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItem.Click
        DialogBuku.Show()
    End Sub

    Private Sub show_item_pinjam()
        lvItemPinjam.View = View.Details
        lvItemPinjam.Columns.Add("NO", 30)
        lvItemPinjam.Columns.Add("ID BUKU", 150)
        lvItemPinjam.Columns.Add("JUDUL BUKU", 200)
        lvItemPinjam.Columns.Add("PENGARANG", 100)

    End Sub
End Class