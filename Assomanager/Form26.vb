Imports System.Windows.Forms
Imports System.IO

Public Class Form26

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Form26_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Politique de confidentialité"

        Dim chemin As String = "aides/politique de confidentialité.txt"


        If File.Exists(chemin) Then

            Dim content As String = File.ReadAllText(chemin)


            TextBox1.Text = content
        Else
            MessageBox.Show("Le fichier texte n'existe pas.")
        End If
    End Sub
End Class
