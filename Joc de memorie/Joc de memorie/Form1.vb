Public Class Form1


    'In firstClicked se pastreaza label-ul peca care s-a dat prima data click
    'Daca nu s-a efectual nici un click atunci firstClicked este Nothing
    Private firstClicked As Label = Nothing

    'In secondClicked se pastreaza al doilea label pe care s-a dat click
    Private secondClicked As Label = Nothing

    'Folosim obiectul Random pentru a alege random o imagine  
    Private random As New Random

    Dim clic As Boolean

    Dim sir As String
    Dim nume As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clic = True
        lblMutari.Text = 0
        lblPotriviri.Text = 0
        lblScor.Text = 0
        lblMin.Text = "00"
        lblSec.Text = "00"
        Timer2.Start()
        TableLayoutPanel1.Enabled = True
        AssignIconsToSquares()

    End Sub


    'Atribuim random fiecarui patrat o immagine din lista
    Private Sub AssignIconsToSquares()

        'Fiecare din litara din lista este o imagime folosind fontul Webdings
        'Fiecare imagine va aparea de doua ori in lista
        Dim icons = New List(Of String) From {"!", "!", "N", "N", ",", ",", "k", "k",
                             "b", "b", "v", "v", "w", "w", "z", "z"}

        'TableLayoutPanel are 16 labels si lista are 16 imagini
        'Vom alege random o imagine din lista si o adaugam in fiecare label
        For Each control In TableLayoutPanel1.Controls
            Dim iconLabel = TryCast(control, Label)
            If iconLabel IsNot Nothing Then
                Dim randomNumber = random.Next(icons.Count)
                iconLabel.Text = icons(randomNumber)
                'Ascundem imaginile atribuind backgound-ului din fata background-ul din spate
                iconLabel.ForeColor = iconLabel.BackColor
                icons.RemoveAt(randomNumber)
            End If
        Next
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    'Atribuim o functie fiecarui label pe care s-a dat un click
    Private Sub label_Click(ByVal sender As System.Object,
                    ByVal e As System.EventArgs) Handles Label1.Click,
        Label2.Click, Label3.Click, Label4.Click, Label5.Click, Label6.Click,
        Label7.Click, Label8.Click, Label9.Click, Label10.Click, Label11.Click,
        Label12.Click, Label13.Click, Label14.Click, Label15.Click, Label16.Click

        If clic = True Then


            'Timpul este activat doar daca utilizatorul nu a nimerit doua imagimi
            'Si se ignora orice click cat timp ceasul functioneaza

            If Timer1.Enabled Then Exit Sub

            'Sender-ul este transformat in Label
            Dim clickedLabel = TryCast(sender, Label)

            If clickedLabel IsNot Nothing Then

                'Daca label-ul pe care s-a dat click este daja intors(backgound-ul este negru) 
                'click-ul se ignora

                If clickedLabel.ForeColor = Color.Black Then Exit Sub

                secondClicked = clickedLabel
                secondClicked.ForeColor = Color.Black


                'Verificam daca jucatorul a castigat
                CheckForWinner()

                'Daca firstClicked este Nothing atunci este primul click dat de utilizator
                'Se initializeaza firstClicked cu primul label pe care s-a dat click
                'Schimbam culoare in negru(afisam imaginea)

                If firstClicked Is Nothing Then
                    firstClicked = clickedLabel
                    firstClicked.ForeColor = Color.Black
                    Exit Sub
                End If


                'Daca Timer1-ul nu functioneaza si firstClicked nu este Nothing
                'secondClicked trebuie egalat cu label-ul pe care s-a efectuat click-ul
                'se intoarce imaginea

                secondClicked = clickedLabel
                secondClicked.ForeColor = Color.Black


                ' Daca jucatorul a dat click pe doua imagini la fel, le pastram afisate 
                'Se poate da un alt click
                If firstClicked.Text = secondClicked.Text Then

                    firstClicked = Nothing
                    secondClicked = Nothing
                    lblMutari.Text += 1
                    lblPotriviri.Text += 1
                    lblScor.Text += 20
                    Exit Sub
                End If

                'Jucatorul a dat click pe doua imagini si se activeaza timpul
                Timer1.Start()

            End If
        End If
    End Sub


    'Timer1 va proni cand utilizatorul a apasat pe doua label-uri
    'Numara cateva secund, intoarce ambele imagini si se opreste

    Private Sub Timer1_Tick() Handles Timer1.Tick
        'Opreste timpul
        lblMutari.Text += 1
        lblScor.Text -= 10
        Timer1.Stop()
        'Ascunde ambele imagini
        firstClicked.ForeColor = firstClicked.BackColor
        secondClicked.ForeColor = secondClicked.BackColor
        'Resetaza firstClicked si secondClicked pentru urmatoarele click-uri
        firstClicked = Nothing
        secondClicked = Nothing

    End Sub


    'Verificam fiecare imagine daca este intoarsa comparand culoarea din fata(foreground color)
    'cu cea din spate(background color)
    'Daca toate imaginile sunt potrivite atunci jucatorul a castigat

    Private Sub CheckForWinner()

        If clic = True Then

            For Each control In TableLayoutPanel1.Controls
                Dim iconLabel = TryCast(control, Label)
                If iconLabel IsNot Nothing AndAlso
                   iconLabel.ForeColor = iconLabel.BackColor Then Exit Sub
            Next
            Timer2.Stop()
            'Daca s-au potrivit toate imaginile va aparea un mesaj prin care se felicita jucatorul
            MessageBox.Show("Ai marcat toate figurile!", "Felicitari!")
            ' Me.Close()

            nume = InputBox("Introduceti numele : ")

            sir = nume & "                                        " & CStr(lblScor.Text)

            Scor.ListBox1.Items.Add(sir)


        End If

    End Sub



    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblSec.Text += 1
        If lblSec.Text = 60 Then
            lblMin.Text += 1
            lblSec.Text = "00"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer2.Stop()
        nume = InputBox("Introduceti numele : ")

        sir = nume & "                                        " & CStr(lblScor.Text)

        Scor.ListBox1.Items.Add(sir)
        TableLayoutPanel1.Enabled = False

    End Sub


End Class
