Public Class Main

    Dim angkaKomputer As Integer
    Dim hitung As Integer

    Private Sub bMulai_Click(sender As Object, e As EventArgs) Handles bMulai.Click
        GroupBoxRange.Enabled = False
        hitung = 0
        bMulai.Enabled = False
        TMasukan.Enabled = True
        bYa.Enabled = True
        LDitebak.Text = "Angka yang Ditebak : " + Str(hitung)
        LTingRend.Text = ""
        TMasukan.Focus()
        TMasukan.Clear()
        AngkaDitebak()
    End Sub

    Private Sub AngkaDitebak()
        Randomize()
        If Range10.Checked = True Then
            angkaKomputer = CInt(Rnd() * 9 + 1)
        ElseIf Range100.Checked = True Then
            angkaKomputer = CInt(Rnd() * 99 + 1)
        Else
            angkaKomputer = CInt(Rnd() * 999 + 1)
        End If
    End Sub

    Private Sub bYa_Click(sender As Object, e As EventArgs) Handles bYa.Click
        If TMasukan.Text <> "" Then
            Try
                If Integer.Parse(TMasukan.Text) = angkaKomputer Then
                    JawabBenar()
                Else
                    JawabSalah()
                End If
            Catch ex As Exception
                TMasukan.Clear()
                TMasukan.Focus()
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub JawabBenar()
        hitung += 1
        LDitebak.Text = "Angka yang Ditebak : " + Str(hitung)
        GroupBoxRange.Enabled = True
        bMulai.Enabled = True
        TMasukan.Enabled = False

        MessageBox.Show("Selamat!! Kamu menebak dengan " + Str(hitung) + " tebakan!")
    End Sub

    Private Sub JawabSalah()
        hitung += 1
        LDitebak.Text = "Angka yang Ditebak : " + Str(hitung)
        If Integer.Parse(TMasukan.Text) < angkaKomputer Then
            LTingRend.Text = "Angka Terlalu Rendaah"
        Else
            LTingRend.Text = "Angka Terlalu Tinggi"
        End If
        TMasukan.Clear()
        TMasukan.Focus()
    End Sub
End Class
