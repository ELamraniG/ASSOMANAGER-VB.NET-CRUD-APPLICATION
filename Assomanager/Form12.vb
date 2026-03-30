Imports System.Data.OleDb

Public Class Form12
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Public Property IsEditMode As Boolean = False
    Public Property ParametreId As String = ""
    Dim requete As String


    Public Property ParametreCle As String
        Get
            Return TextBox121.Text
        End Get
        Set(ByVal value As String)
            TextBox121.Text = value
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
            Return TextBox121.Text
        End Get
        Set(ByVal value As String)
            TextBox121.Text = value
        End Set
    End Property


    Public Property TypeDescription As String
        Get
            Return TextBoxDescription.Text
        End Get
        Set(ByVal value As String)
            TextBoxDescription.Text = value
        End Set
    End Property


    Public Property DateDebut As Date
        Get
            Return DatePickerDebut.Value
        End Get
        Set(ByVal value As Date)
            DatePickerDebut.Value = value
        End Set
    End Property


    Public Property DateFin As Date
        Get
            Return DatePickerFin.Value
        End Get
        Set(ByVal value As Date)
            DatePickerFin.Value = value
        End Set
    End Property


    Public Property Lieu As String
        Get
            Return TextBoxLieu.Text
        End Get
        Set(ByVal value As String)
            TextBoxLieu.Text = value
        End Set
    End Property

    Private Sub connexion()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AssoManager.accdb")
        con.Open()
    End Sub

    Private Sub cmdsql()
        cmd = New OleDbCommand(requete, con)
    End Sub

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Text = "Événement"


        Label121.Text = "Titre:"
        Label122.Text = "Description:"
        Label122.Visible = True


        DatePickerDebut.Value = Date.Today
        DatePickerFin.Value = Date.Today


        Me.Height = 405

        If IsEditMode Then
            enregistrer12.Text = "Modifier"
            Button12.Text = "Annuler"
        Else
            enregistrer12.Text = "Ajouter"
            Button12.Text = "Fermer"
        End If
    End Sub

    Private Sub enregistrer12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enregistrer12.Click
        If TextBox121.Text.Trim() = "" Then
            MsgBox("Veuillez entrer un titre pour l'événement", vbExclamation, "Données manquantes")
            TextBox121.Focus()
            Return
        End If

        If DatePickerFin.Value < DatePickerDebut.Value Then
            MsgBox("La date de fin ne peut pas être antérieure à la date de début", vbExclamation, "Dates invalides")
            DatePickerFin.Focus()
            Return
        End If

        connexion()

        If Not IsEditMode OrElse enregistrer12.Text = "Ajouter" Then

            requete = "INSERT INTO evenements (titre, description, datedebut, datefin, lieu) VALUES " & _
                     "('" & TextBox121.Text & "', '" & TextBoxDescription.Text & "', " & _
                     "#" & DatePickerDebut.Value.ToString("MM/dd/yyyy") & "#, " & _
                     "#" & DatePickerFin.Value.ToString("MM/dd/yyyy") & "#, " & _
                     "'" & TextBoxLieu.Text & "')"
        Else

            requete = "UPDATE evenements SET titre = '" & TextBox121.Text & "', " & _
                     "description = '" & TextBoxDescription.Text & "', " & _
                     "datedebut = #" & DatePickerDebut.Value.ToString("MM/dd/yyyy") & "#, " & _
                     "datefin = #" & DatePickerFin.Value.ToString("MM/dd/yyyy") & "#, " & _
                     "lieu = '" & TextBoxLieu.Text & "' " & _
                     "WHERE idevenement = " & ParametreId
        End If

        cmdsql()
        Try
            cmd.ExecuteNonQuery()
            con.Close()


            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MsgBox("Erreur lors de l'enregistrement: " & ex.Message, vbExclamation, "Erreur")
            con.Close()
        End Try
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.Close()
    End Sub

    Private Sub TextBox121_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox121.GotFocus
        TextBox121.BackColor = Color.Aqua
    End Sub

    Private Sub TextBox121_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox121.LostFocus
        TextBox121.BackColor = Color.White
    End Sub

    Private Sub TextBoxDescription_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxDescription.GotFocus
        TextBoxDescription.BackColor = Color.Aqua
    End Sub

    Private Sub TextBoxDescription_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxDescription.LostFocus
        TextBoxDescription.BackColor = Color.White
    End Sub

    Private Sub TextBoxLieu_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxLieu.GotFocus
        TextBoxLieu.BackColor = Color.Aqua
    End Sub

    Private Sub TextBoxLieu_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBoxLieu.LostFocus
        TextBoxLieu.BackColor = Color.White
    End Sub
End Class
