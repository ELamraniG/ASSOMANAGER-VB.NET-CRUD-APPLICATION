Imports System.Data.OleDb

Public Class Form10
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Public Property IsEditMode As Boolean = False
    Public Property ParametreId As String = ""
    Dim requete As String


    Public Property ParametreCle As String
        Get
            Return TextBox101.Text
        End Get
        Set(ByVal value As String)
            TextBox101.Text = value
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
            Return TextBox101.Text
        End Get
        Set(ByVal value As String)
            TextBox101.Text = value
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

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Text = "Catégorie de dépense"


        Label101.Text = "Nom:"


        Label102.Visible = False


        TextBox101.Height = 26
        enregistrer10.Location = New Point(87, 80)
        Button10.Location = New Point(236, 80)
        Me.Height = 180

        If IsEditMode Then
            enregistrer10.Text = "Modifier"
            Button10.Text = "Annuler"
        Else
            enregistrer10.Text = "Ajouter"
            Button10.Text = "Fermer"
        End If
    End Sub

    Private Sub enregistrer10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enregistrer10.Click
        If TextBox101.Text.Trim() = "" Then
            MsgBox("Veuillez entrer un nom de catégorie", vbExclamation, "Données manquantes")
            TextBox101.Focus()
            Return
        End If

        connexion()

        If Not IsEditMode OrElse enregistrer10.Text = "Ajouter" Then

            requete = "INSERT INTO categoriedepenses (nomcategoriedepense) VALUES ('" & TextBox101.Text & "')"
        Else

            requete = "UPDATE categoriedepenses SET nomcategoriedepense = '" & TextBox101.Text & "' WHERE idcategoriedepense = " & ParametreId
        End If

        cmdsql()
        Try
            cmd.ExecuteNonQuery()
            con.Close()

            Form9.afficher_entity()

            Me.Close()
        Catch ex As Exception
            MsgBox("Erreur lors de l'enregistrement: " & ex.Message, vbExclamation, "Erreur")
            con.Close()
        End Try
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

    Private Sub TextBox101_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox101.GotFocus
        TextBox101.BackColor = Color.Aqua
    End Sub

    Private Sub TextBox101_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox101.LostFocus
        TextBox101.BackColor = Color.White
    End Sub
End Class
