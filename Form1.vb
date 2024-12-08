Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_ajouter_Click(sender As Object, e As EventArgs) Handles Btn_ajouter.Click
        Dim l As livre
        l.ISBN = txt_isbn.Text
        l.titre = txt_titre.Text
        l.auteur = txt_auteur.Text

        If ajouterlivre(l) Then
            MessageBox.Show("Ajout du livre avec succes")
        Else
            MessageBox.Show("le tableau bibliotheque est sature")
        End If
    End Sub

    Private Sub Btn_afficher_Click(sender As Object, e As EventArgs) Handles Btn_afficher.Click
        Form2.Show()
    End Sub
    Private Sub AfficherMessage(message As String)

    End Sub
End Class
