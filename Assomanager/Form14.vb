Imports System.Data.OleDb
Imports System.IO

Public Class Form14
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Public Property IsEditMode As Boolean = False
    Public Property ParametreId As String = ""
    Dim requete As String


    Public Property ParametreCle As String
        Get
            Return TextBox141.Text
        End Get
        Set(ByVal value As String)
            TextBox141.Text = value
        End Set
    End Property

    Public Property CheminFichier As String
        Get
            Return TextBox142.Text
        End Get
        Set(ByVal value As String)
            TextBox142.Text = value
        End Set
    End Property

    Public Property TypeDocument As String
        Get
            Return ComboBox141.Text
        End Get
        Set(ByVal value As String)
            ComboBox141.Text = value
        End Set
    End Property

    Public Property DateAjout As Date
        Get
            Return DatePicker141.Value
        End Get
        Set(ByVal value As Date)
            DatePicker141.Value = value
        End Set
    End Property

    Private Sub connexion()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AssoManager.accdb")
        con.Open()
    End Sub

    Private Sub cmdsql()
        cmd = New OleDbCommand(requete, con)
    End Sub

    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Text = "Document"


        Label141.Text = "Titre:"
        Label142.Text = "Chemin fichier:"
        Label143.Text = "Type de document:"
        Label144.Text = "Date d'ajout:"


        ComboBox141.Items.Clear()
        ComboBox141.Items.Add("Statuts")
        ComboBox141.Items.Add("PV")
        ComboBox141.Items.Add("Rapport Financier")
        ComboBox141.Items.Add("Autre")


        DatePicker141.Value = Date.Today


        Me.Height = 365


        If IsEditMode Then
            enregistrer14.Text = "Modifier"
            Button14.Text = "Annuler"
        Else
            enregistrer14.Text = "Ajouter"
            Button14.Text = "Fermer"
        End If
    End Sub

    Private Sub enregistrer14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enregistrer14.Click
        If TextBox141.Text.Trim() = "" Then
            MsgBox("Veuillez entrer un titre pour le document", vbExclamation, "Données manquantes")
            TextBox141.Focus()
            Return
        End If

        If TextBox142.Text.Trim() = "" Then
            MsgBox("Veuillez spécifier un chemin de fichier", vbExclamation, "Données manquantes")
            TextBox142.Focus()
            Return
        End If

        If ComboBox141.Text.Trim() = "" Then
            MsgBox("Veuillez sélectionner un type de document", vbExclamation, "Données manquantes")
            ComboBox141.Focus()
            Return
        End If

        connexion()

        If Not IsEditMode OrElse enregistrer14.Text = "Ajouter" Then

            requete = "INSERT INTO documents (titre, cheminfichier, typedocument, dateajout) VALUES " & _
                     "('" & TextBox141.Text & "', '" & TextBox142.Text.Replace("'", "''") & "', " & _
                     "'" & ComboBox141.Text & "', " & _
                     "#" & DatePicker141.Value.ToString("MM/dd/yyyy") & "#)"
        Else

            requete = "UPDATE documents SET titre = '" & TextBox141.Text & "', " & _
                     "cheminfichier = '" & TextBox142.Text.Replace("'", "''") & "', " & _
                     "typedocument = '" & ComboBox141.Text & "', " & _
                     "dateajout = #" & DatePicker141.Value.ToString("MM/dd/yyyy") & "# " & _
                     "WHERE iddocument = " & ParametreId
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

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Me.Close()
    End Sub

    Private Sub TextBox141_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox141.GotFocus
        TextBox141.BackColor = Color.Aqua
    End Sub

    Private Sub TextBox141_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox141.LostFocus
        TextBox141.BackColor = Color.White
    End Sub

    Private Sub TextBox142_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox142.GotFocus
        TextBox142.BackColor = Color.Aqua
    End Sub

    Private Sub TextBox142_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox142.LostFocus
        TextBox142.BackColor = Color.White
    End Sub

    Private Sub BrowseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button141.Click

        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Title = "Sélectionner un fichier"
        openFileDialog.Filter = "Tous les fichiers (*.*)|*.*|Documents PDF (*.pdf)|*.pdf|Documents Word (*.doc;*.docx)|*.doc;*.docx"
        openFileDialog.FilterIndex = 1

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            TextBox142.Text = openFileDialog.FileName
        End If
    End Sub
End Class
