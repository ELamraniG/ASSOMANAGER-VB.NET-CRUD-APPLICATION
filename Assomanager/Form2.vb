Imports System.Data.OleDb
Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.BackColor = Color.Aqua
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.BackColor = Color.White
    End Sub

    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        TextBox2.BackColor = Color.Aqua
    End Sub

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        TextBox2.BackColor = Color.White
    End Sub

    Private Sub enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enregistrer.Click
        If enregistrer.Text = "Ajouter" Then
            requete = "insert into roles(idrole, nomrole) values ('" + TextBox1.Text + "', '" + TextBox2.Text + "')"
        Else
            requete = "update roles set idrole = '" + TextBox1.Text + "', nomrole = '" + TextBox2.Text + "' where idrole = '" + TextBox1.Text + "'"
        End If
        connexion()
        cmdsql()
        Try
            cmd.ExecuteNonQuery()
            con.Close()
            Me.Close()
            Form1.afficher_service()
        Catch ex As Exception
            MsgBox("Le ID role existe déjà, Veuillez le remplacer par un autre...", MsgBoxStyle.Exclamation, "Message")
            con.Close()
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox1.Text = TextBox1.Text
    End Sub
End Class
