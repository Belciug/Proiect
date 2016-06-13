Public Class Meniu

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        MsgBox("Belciug Maria" & vbCrLf & "Grupa 3121B", MsgBoxStyle.Information)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim ok As Integer
        ok = MsgBox("Sunteti sigur ca vreti sa parasiti aplicatia? ", vbOKCancel)
        If ok = vbOK Then
            Me.Close()
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        btnMediu.Visible = True
        btnGreu.Visible = True

    End Sub

    Private Sub btnScor_Click(sender As Object, e As EventArgs) Handles btnScor.Click
        Scor.Show()
    End Sub


    Private Sub Meniu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMediu_Click(sender As Object, e As EventArgs) Handles btnMediu.Click
        Form1.Show()
    End Sub

    Private Sub btnGreu_Click(sender As Object, e As EventArgs) Handles btnGreu.Click


        Form2.Show()
    End Sub

    Private Sub btnAjutor_Click(sender As Object, e As EventArgs) Handles btnAjutor.Click
        MsgBox("*Dati click pe oricare doua patrate" & vbCrLf & "*Daca cele doua imagini sunt la fel se vor pastra" & vbCrLf & "*Daca nu sunt la fel se vor intoarce " & vbCrLf & "*Retine ce este pe fiecare patrat" & vbCrLf & "*Jocul se termina cand toate imaginile sunt potrivite" & vbCrLf & "*Jucatorul castiga un anumit punctaj", MsgBoxStyle.Information)
    End Sub
End Class