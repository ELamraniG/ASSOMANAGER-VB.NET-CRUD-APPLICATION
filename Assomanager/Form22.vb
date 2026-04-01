Imports System.Data.OleDb
Imports System.IO

Public Class Form22

    Private Sub Form22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.Text = "Formulaire Dépense"
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.CenterToScreen()

        Try

            connexion()
            requete = "SELECT idcategoriedepense, nomcategoriedepense FROM categoriedepenses ORDER BY nomcategoriedepense"
            cmdsql()

            Dim data As IDataReader = Nothing
            Try
                idcategoriedepense.Items.Clear()
                data = cmd.ExecuteReader()

                While data.Read()
                    Dim categorieId As String = data(0).ToString()
                    Dim categorieName As String = data(1).ToString()
                    idcategoriedepense.Items.Add(categorieId + " | " + categorieName)
                End While
            Finally

                If data IsNot Nothing AndAlso Not data.IsClosed Then
                    data.Close()
                End If
                deconnexion()
            End Try


            If type_operation.Text = "Ajouter" Then
                iddepense.Text = ""
                libelle.Text = ""
                montant.Text = ""
                datedepense.Value = Date.Now
                idcategoriedepense.SelectedIndex = -1
                fournisseur.Text = ""
                justificatif.Text = ""
            End If

        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
            deconnexion()
        End Try
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click

        If libelle.Text = "" Then
            MsgBox("Veuillez saisir un libellé!", vbExclamation, "Message")
            libelle.Focus()
            Exit Sub
        End If

        If montant.Text = "" Then
            MsgBox("Veuillez saisir un montant!", vbExclamation, "Message")
            montant.Focus()
            Exit Sub
        End If


        Dim montantValue As Double
        If Not Double.TryParse(montant.Text.Replace(",", "."), montantValue) Then
            MsgBox("Le montant doit être un nombre valide!", vbExclamation, "Message")
            montant.Focus()
            Exit Sub
        End If

        If idcategoriedepense.Text = "" Then
            MsgBox("Veuillez sélectionner une catégorie!", vbExclamation, "Message")
            idcategoriedepense.Focus()
            Exit Sub
        End If

        If fournisseur.Text = "" Then
            MsgBox("Veuillez saisir un fournisseur!", vbExclamation, "Message")
            fournisseur.Focus()
            Exit Sub
        End If

        Try

            Dim categorieId As String = ""


            If idcategoriedepense.Text.Contains("|") Then
                categorieId = idcategoriedepense.Text.Substring(0, idcategoriedepense.Text.IndexOf("|")).Trim()
            Else
                categorieId = idcategoriedepense.Text.Trim()
            End If


            If String.IsNullOrEmpty(categorieId) Then
                MsgBox("Veuillez sélectionner une catégorie valide!", vbExclamation, "Message")
                idcategoriedepense.Focus()
                Exit Sub
            End If


            montantValue = Double.Parse(montant.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture)

            Try
                connexion()

                If type_operation.Text = "Ajouter" Then
                    requete = "INSERT INTO depenses ([libelle], [montant], [datedepense], [idcategoriedepense], " & _
                              "[fournisseur], [justificatif]) VALUES (?,?,?,?,?,?)"
                    cmdsql()
                    cmd.Parameters.Clear()

                    cmd.Parameters.Add("@p1", OleDbType.VarChar).Value = libelle.Text
                    cmd.Parameters.Add("@p2", OleDbType.Double).Value = montantValue
                    cmd.Parameters.Add("@p3", OleDbType.Date).Value = Date.Now
                    cmd.Parameters.Add("@p4", OleDbType.Integer).Value = Convert.ToInt32(categorieId)
                    cmd.Parameters.Add("@p5", OleDbType.VarChar).Value = fournisseur.Text
                    cmd.Parameters.Add("@p6", OleDbType.VarChar).Value = justificatif.Text
                Else
                    requete = "UPDATE depenses SET [libelle]=?, [montant]=?, [datedepense]=?, " & _
                              "[idcategoriedepense]=?, [fournisseur]=?, [justificatif]=? WHERE [iddepense]=?"
                    cmdsql()
                    cmd.Parameters.Clear()

                    cmd.Parameters.Add("@p1", OleDbType.VarChar).Value = libelle.Text
                    cmd.Parameters.Add("@p2", OleDbType.Double).Value = montantValue
                    cmd.Parameters.Add("@p3", OleDbType.Date).Value = datedepense.Value
                    cmd.Parameters.Add("@p4", OleDbType.Integer).Value = Convert.ToInt32(categorieId)
                    cmd.Parameters.Add("@p5", OleDbType.VarChar).Value = fournisseur.Text
                    cmd.Parameters.Add("@p6", OleDbType.VarChar).Value = justificatif.Text
                    cmd.Parameters.Add("@p7", OleDbType.Integer).Value = Convert.ToInt32(iddepense.Text)
                End If

                cmd.ExecuteNonQuery()
            Finally

                deconnexion()
            End Try

            Form21.afficher_depenses()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur SQL")
            deconnexion()
        End Try
    End Sub


    Public Sub SelectCategorieById(ByVal categorieId As String)
        If String.IsNullOrEmpty(categorieId) Then
            Return
        End If


        For i As Integer = 0 To idcategoriedepense.Items.Count - 1
            Dim item As String = idcategoriedepense.Items(i).ToString()
            If item.StartsWith(categorieId & " |") Then
                idcategoriedepense.SelectedIndex = i
                Return
            End If
        Next


        idcategoriedepense.Text = categorieId
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Documents (*.pdf;*.doc;*.docx;*.jpg;*.png)|*.pdf;*.doc;*.docx;*.jpg;*.png|All files (*.*)|*.*"
        openFileDialog.Title = "Sélectionner un justificatif"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            justificatif.Text = openFileDialog.FileName
        End If
    End Sub
End Class
