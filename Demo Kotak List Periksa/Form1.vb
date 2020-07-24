Public Class Form1

    Private Sub tombolHitung_Click(sender As Object, e As EventArgs) Handles tombolHitung.Click
        Dim intIndeks As Integer            'indeks dari item
        Dim intKotaTercentang As Integer = 0    'menghitung banyak item tercentang

        'menjejak item-item pada kotak list, menghitung
        'banyak item yang tercentang
        For intIndeks = 0 To clbKota.Items.Count - 1
            If clbKota.GetItemChecked(intIndeks) = True Then
                intKotaTercentang += 1
            End If
        Next

        'menampilkan banyak kota yang tercentang
        MessageBox.Show("Anda mencentang " & intKotaTercentang.ToString() & " kota.")
    End Sub
End Class
