Imports System.Data.OleDb

Public Class Form8
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Public Property IsEditMode As Boolean = False
    Public Property ParametreId As String = ""
    Dim requete As String


    Public Property ParametreCle As String
        Get
            Return TextBox81.Text
        End Get
        Set(ByVal value As String)
            TextBox81.Text = value
        End Set
    End Property


    Public Property ParametreValeur As String
        Get
            Return ""
        End Get
        Set(ByVal value As String)

        End Set
    End Property


    Public Property TypeName As String
        Get
            Return TextBox81.Text
        End Get
        Set(ByVal value As String)
            TextBox81.Text = value
        End Set
    End Property


    Public Property TypeDescription As String
        Get
            Return ""
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Private Sub connexion()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AssoManager.accdb")
        con.Open()
    End Sub

    Private Sub cmdsql()
        cmd = New OleDbCommand(requete, con)
    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Text = "Catégorie de membre"


        Label81.Text = "Nom:"


        Label82.Visible = False


        TextBox81.Height = 26
        enregistrer8.Location = New Point(87, 80)
        Button8.Location = New Point(236, 80)
        Me.Height = 180

        If IsEditMode Then
            enregistrer8.Text = "Modifier"
            Button8.Text = "Annuler"
        Else
            enregistrer8.Text = "Ajouter"
            Button8.Text = "Fermer"
        End If
    End Sub

    Private Sub enregistrer8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enregistrer8.Click
        If TextBox81.Text.Trim() = "" Then
            MsgBox("Veuillez entrer un nom de catégorie", vbExclamation, "Données manquantes")
            TextBox81.Focus()
            Return
        End If

        connexion()

        If Not IsEditMode OrElse enregistrer8.Text = "Ajouter" Then

            requete = "INSERT INTO categoriemembre (nomcategoriemembre) VALUES ('" & TextBox81.Text & "')"
        Else

            requete = "UPDATE categoriemembre SET nomcategoriemembre = '" & TextBox81.Text & "' WHERE idcategoriemembre = " & ParametreId
        End If

        cmdsql()
        Try
            cmd.ExecuteNonQuery()
            con.Close()

            Form7.afficher_entity()

            Me.Close()
        Catch ex As Exception
            MsgBox("Erreur lors de l'enregistrement: " & ex.Message, vbExclamation, "Erreur")
            con.Close()
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub TextBox81_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox81.GotFocus
        TextBox81.BackColor = Color.Aqua
    End Sub

    Private Sub TextBox81_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox81.LostFocus
        TextBox81.BackColor = Color.White
    End Sub
End Class
