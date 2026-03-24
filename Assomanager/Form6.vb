Imports System.Data.OleDb

Public Class Form6
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Public Property IsEditMode As Boolean = False
    Public Property ParametreId As String = ""
    Dim requete As String


    Public Property ParametreCle As String
        Get
            Return TextBox10.Text
        End Get
        Set(ByVal value As String)
            TextBox10.Text = value
        End Set
    End Property

    Public Property ParametreValeur As String
        Get
            Return TextBox11.Text
        End Get
        Set(ByVal value As String)
            TextBox11.Text = value
        End Set
    End Property


    Public Property TypeName As String
        Get
            Return TextBox10.Text
        End Get
        Set(ByVal value As String)
            TextBox10.Text = value
        End Set
    End Property

    Public Property TypeDescription As String
        Get
            Return TextBox11.Text
        End Get
        Set(ByVal value As String)
            TextBox11.Text = value
        End Set
    End Property


    Public Property TypeAssociationId As String
        Get
            Return ParametreId
        End Get
        Set(ByVal value As String)
            ParametreId = value
        End Set
    End Property

    Private Sub connexion()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AssoManager.accdb")
        con.Open()
    End Sub

    Private Sub cmdsql()
        cmd = New OleDbCommand(requete, con)
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        If IsEditMode Then
            enregistrer3.Text = "Modifier"
            Button1.Text = "Annuler"
        Else
            enregistrer3.Text = "Ajouter"
            Button1.Text = "Fermer"
        End If
    End Sub

    Private Sub enregistrer3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enregistrer3.Click
        If TextBox10.Text.Trim() = "" Then
            MsgBox("Veuillez entrer une clé de paramètre", vbExclamation, "Données manquantes")
            TextBox10.Focus()
            Return
        End If

        connexion()

        If Not IsEditMode OrElse enregistrer3.Text = "Ajouter" Then

            requete = "INSERT INTO parametres (cle, valeur) VALUES ('" & TextBox10.Text & "', '" & TextBox11.Text & "')"
        Else

            requete = "UPDATE parametres SET cle = '" & TextBox10.Text & "', valeur = '" & TextBox11.Text & "' WHERE idparametre = " & ParametreId
        End If

        cmdsql()
        Try
            cmd.ExecuteNonQuery()
            con.Close()

            Form5.afficher_entity()


            Me.Close()
        Catch ex As Exception
            MsgBox("Erreur lors de l'enregistrement: " & ex.Message, vbExclamation, "Erreur")
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TextBox10_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox10.GotFocus
        TextBox10.BackColor = Color.Aqua
    End Sub

    Private Sub TextBox10_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox10.LostFocus
        TextBox10.BackColor = Color.White
    End Sub

    Private Sub TextBox11_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.GotFocus
        TextBox11.BackColor = Color.Aqua
    End Sub

    Private Sub TextBox11_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.LostFocus
        TextBox11.BackColor = Color.White
    End Sub
End Class
