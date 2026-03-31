Imports System.Data.OleDb

Public Class Form20

    Private Sub Form20_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.Text = "Formulaire Cotisation"
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.CenterToScreen()

        Try

            connexion()
            requete = "SELECT idmembre, nom, prenom FROM membres ORDER BY nom, prenom"
            cmdsql()

            Dim data As IDataReader = Nothing
            Try
                idmembre.Items.Clear()
                data = cmd.ExecuteReader()

                While data.Read()
                    Dim membreId As String = data(0).ToString()
                    Dim membreName As String = data(1).ToString() & " " & data(2).ToString()
                    idmembre.Items.Add(membreId + " | " + membreName)
                End While
            Finally

                If data IsNot Nothing AndAlso Not data.IsClosed Then
                    data.Close()
                End If
                deconnexion()
            End Try


            If type_operation.Text = "Ajouter" Then
                idcotisation.Text = ""
                idmembre.SelectedIndex = -1
                montant.Text = ""
                datepaiement.Value = Date.Now
                modepaiement.SelectedIndex = 0
                statut.SelectedIndex = 1


                periodemois.SelectedIndex = Date.Now.Month - 1
                periodeannee.Text = Date.Now.Year.ToString()
            End If

        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
            deconnexion()
        End Try
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click

        If idmembre.Text = "" Then
            MsgBox("Veuillez sélectionner un membre!", vbExclamation, "Message")
            idmembre.Focus()
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

        If modepaiement.Text = "" Then
            MsgBox("Veuillez sélectionner un mode de paiement!", vbExclamation, "Message")
            modepaiement.Focus()
            Exit Sub
        End If

        If statut.Text = "" Then
            MsgBox("Veuillez sélectionner un statut!", vbExclamation, "Message")
            statut.Focus()
            Exit Sub
        End If

        If periodemois.Text = "" Then
            MsgBox("Veuillez sélectionner un mois pour la période!", vbExclamation, "Message")
            periodemois.Focus()
            Exit Sub
        End If

        If periodeannee.Text = "" Then
            MsgBox("Veuillez saisir une année pour la période!", vbExclamation, "Message")
            periodeannee.Focus()
            Exit Sub
        End If


        Dim annee As Integer
        If Not Integer.TryParse(periodeannee.Text, annee) Or annee < 2000 Or annee > 2100 Then
            MsgBox("L'année doit être un nombre entre 2000 et 2100!", vbExclamation, "Message")
            periodeannee.Focus()
            Exit Sub
        End If

        Try

            Dim membreId As String = ""


            If idmembre.Text.Contains("|") Then
                membreId = idmembre.Text.Substring(0, idmembre.Text.IndexOf("|")).Trim()
            Else
                membreId = idmembre.Text.Trim()
            End If


            If String.IsNullOrEmpty(membreId) Then
                MsgBox("Veuillez sélectionner un membre valide!", vbExclamation, "Message")
                idmembre.Focus()
                Exit Sub
            End If


            montantValue = Double.Parse(montant.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture)


            Dim dateStr As String = datepaiement.Value.ToString("yyyy/MM/dd")

            Try
                connexion()

                If type_operation.Text = "Ajouter" Then
                    requete = "INSERT INTO cotisations ([idmembre], [montant], [datepaiement], [modepaiement], " & _
                              "[statut], [periodemois], [periodeannee]) VALUES (?,?,?,?,?,?,?)"
                    cmdsql()
                    cmd.Parameters.Clear()

                    cmd.Parameters.Add("@p1", OleDbType.Integer).Value = Convert.ToInt32(membreId)
                    cmd.Parameters.Add("@p2", OleDbType.Double).Value = montantValue
                    cmd.Parameters.Add("@p3", OleDbType.Date).Value = datepaiement.Value
                    cmd.Parameters.Add("@p4", OleDbType.VarChar).Value = modepaiement.Text
                    cmd.Parameters.Add("@p5", OleDbType.VarChar).Value = statut.Text
                    cmd.Parameters.Add("@p6", OleDbType.Integer).Value = Convert.ToInt32(periodemois.Text)
                    cmd.Parameters.Add("@p7", OleDbType.Integer).Value = annee
                Else
                    requete = "UPDATE cotisations SET [idmembre]=?, [montant]=?, [datepaiement]=?, " & _
                              "[modepaiement]=?, [statut]=?, [periodemois]=?, [periodeannee]=? WHERE [idcotisation]=?"
                    cmdsql()
                    cmd.Parameters.Clear()

                    cmd.Parameters.Add("@p1", OleDbType.Integer).Value = Convert.ToInt32(membreId)
                    cmd.Parameters.Add("@p2", OleDbType.Double).Value = montantValue
                    cmd.Parameters.Add("@p3", OleDbType.Date).Value = datepaiement.Value
                    cmd.Parameters.Add("@p4", OleDbType.VarChar).Value = modepaiement.Text
                    cmd.Parameters.Add("@p5", OleDbType.VarChar).Value = statut.Text
                    cmd.Parameters.Add("@p6", OleDbType.Integer).Value = Convert.ToInt32(periodemois.Text)
                    cmd.Parameters.Add("@p7", OleDbType.Integer).Value = annee
                    cmd.Parameters.Add("@p8", OleDbType.Integer).Value = Convert.ToInt32(idcotisation.Text)
                End If

                cmd.ExecuteNonQuery()
            Finally

                deconnexion()
            End Try

            Form19.afficher_cotisations()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur SQL")
            deconnexion()
        End Try
    End Sub


    Public Sub SelectMembreById(ByVal membreId As String)
        If String.IsNullOrEmpty(membreId) Then
            Return
        End If


        For i As Integer = 0 To idmembre.Items.Count - 1
            Dim item As String = idmembre.Items(i).ToString()
            If item.StartsWith(membreId & " |") Then
                idmembre.SelectedIndex = i
                Return
            End If
        Next


        idmembre.Text = membreId
    End Sub
End Class
