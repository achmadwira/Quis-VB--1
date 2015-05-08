Public Class Form1
    Dim byr, total, disc, hg_disc, harga, qts As Single
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub nb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nb.SelectedIndexChanged
        If nb.Text = "Niu Green Tea Rp.4.000/Botol" Then
            harga = 4000
            hg.Text = harga
        ElseIf nb.Text = "Pulpy Orange Rp.5.000/Botol" Then
            harga = 5000
            hg.Text = harga
        ElseIf nb.Text = "U C-1000 Rp.6.000/Botol" Then
            harga = 6000
            hg.Text = harga
        ElseIf nb.Text = "Beng-Beng Rp.1.500/Botol" Then
            harga = 1500
            hg.Text = harga
        ElseIf nb.Text = "TOP Orange Rp.2.000/Botol" Then
            harga = 2000
            hg.Text = harga
        ElseIf nb.Text = "Kitkat Rp.2.500/Botol" Then
            harga = 2500
            hg.Text = harga


        End If
    End Sub

    Private Sub kategori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kategori.SelectedIndexChanged
        nb.Items.Clear()
        hg.Clear()
        tot.Clear()
        dis.Clear()
        bayar.Clear()

        If kategori.Text = "Minuman Ringan" Then
            nb.Items.Clear()
            nb.Items.Add("Niu Green Tea Rp.4.000/Botol")
            nb.Items.Add("Pulpy Orange Rp.5.000/Botol")
            nb.Items.Add("U C-1000 Rp.6.000/Botol")

        ElseIf kategori.Text = "Makanan Ringan" Then
            nb.Items.Clear()
            nb.Items.Add("Beng-Beng Rp.1.500/Botol")
            nb.Items.Add("TOP Orange Rp.2.000/Botol")
            nb.Items.Add("Kitkat Rp.2.500/Botol")
        End If
    End Sub

    Private Sub qty_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qty.SelectedIndexChanged
        qts = qty.SelectedItem

        total = harga * qts
        tot.Text = total

        If total >= 500000 Then
            disc = 0.05

        Else
            disc = 0
        End If

        hg_disc = total * disc
        byr = total - hg_disc
        dis.Text = hg_disc
        bayar.Text = byr


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
