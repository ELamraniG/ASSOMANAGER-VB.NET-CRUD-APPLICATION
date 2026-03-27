Imports System.Data.OleDb

Public Class Form16

    Private Sub Form16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.Text = "Formulaire Utilisateur"
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.CenterToScreen()

        Try

            connexion()
            requete = "SELECT idrole, nomrole FROM roles ORDER BY idrole"
            cmdsql()

            Dim data As IDataReader = Nothing
            Try
                idrole.Items.Clear()
                data = cmd.ExecuteReader()

                While data.Read()
                    Dim roleId As String = data(0).ToString()
                    Dim roleName As String = data(1).ToString()
                    idrole.Items.Add(roleId + " | " + roleName)
                End While
            Finally

                If data IsNot Nothing AndAlso Not data.IsClosed Then
                    data.Close()
                End If
                deconnexion()
            End Try


            If type_operation.Text = "Ajouter" Then
                idutilisateur.Text = ""
                nom.Text = ""
                email.Text = ""
                motdepasse.Text = ""
                idrole.Text = ""
                statut.SelectedIndex = 0
                datecreation.Value = Date.Now
            End If
        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
            deconnexion()
        End Try
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click

        If nom.Text = "" Then
            MsgBox("Veuillez saisir un nom d'utilisateur!", vbExclamation, "Message")
            nom.Focus()
            Exit Sub
        End If

        If email.Text = "" Then
            MsgBox("Veuillez saisir une adresse email!", vbExclamation, "Message")
            email.Focus()
            Exit Sub
        End If

        If motdepasse.Text = "" And type_operation.Text = "Ajouter" Then
            MsgBox("Veuillez saisir un mot de passe!", vbExclamation, "Message")
            motdepasse.Focus()
            Exit Sub
        End If

        If idrole.Text = "" Then
            MsgBox("Veuillez sélectionner un rôle!", vbExclamation, "Message")
            idrole.Focus()
            Exit Sub
        End If


        If type_operation.Text = "Ajouter" Or (type_operation.Text = "Modifier" And ancien_email.Text <> email.Text) Then
            Try
                connexion()
                requete = "SELECT COUNT(*) FROM utilisateurs WHERE email = '" & email.Text & "'"
                cmdsql()
                Dim count As Integer = cmd.ExecuteScalar()
                deconnexion()

                If count > 0 Then
                    MsgBox("Cette adresse email existe déjà!", vbExclamation, "Message")
                    email.Focus()
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
                deconnexion()
                Exit Sub
            End Try
        End If

        Try

            Dim roleId As String = ""


            If idrole.Text.Contains("|") Then
                roleId = idrole.Text.Substring(0, idrole.Text.IndexOf("|")).Trim()
            Else
                roleId = idrole.Text.Trim()
            End If


            If String.IsNullOrEmpty(roleId) Then
                MsgBox("Veuillez sélectionner un rôle valide!", vbExclamation, "Message")
                idrole.Focus()
                Exit Sub
            End If


            Dim dateStr As String = datecreation.Value.ToString("yyyy/MM/dd")

            Try
                connexion()

                If type_operation.Text = "Ajouter" Then
                    requete = "INSERT INTO utilisateurs ([nom], [email], [motdepasse], [idrole], [statut], [datecreation]) VALUES (?,?,?,?,?,?)"
                    cmdsql()
                    cmd.Parameters.Clear()


                    cmd.Parameters.Add("@p1", OleDbType.VarChar).Value = nom.Text
                    cmd.Parameters.Add("@p2", OleDbType.VarChar).Value = email.Text
                    cmd.Parameters.Add("@p3", OleDbType.VarChar).Value = motdepasse.Text
                    cmd.Parameters.Add("@p4", OleDbType.VarChar).Value = roleId
                    cmd.Parameters.Add("@p5", OleDbType.VarChar).Value = statut.Text
                    cmd.Parameters.Add("@p6", OleDbType.Date).Value = datecreation.Value
                Else
                    If motdepasse.Text <> "" Then
                        requete = "UPDATE utilisateurs SET [nom]=?, [email]=?, [motdepasse]=?, [idrole]=?, [statut]=?, [datecreation]=? WHERE [idutilisateur]=?"
                        cmdsql()
                        cmd.Parameters.Clear()

                        cmd.Parameters.Add("@p1", OleDbType.VarChar).Value = nom.Text
                        cmd.Parameters.Add("@p2", OleDbType.VarChar).Value = email.Text
                        cmd.Parameters.Add("@p3", OleDbType.VarChar).Value = motdepasse.Text
                        cmd.Parameters.Add("@p4", OleDbType.VarChar).Value = roleId
                        cmd.Parameters.Add("@p5", OleDbType.VarChar).Value = statut.Text
                        cmd.Parameters.Add("@p6", OleDbType.Date).Value = datecreation.Value
                        cmd.Parameters.Add("@p7", OleDbType.Integer).Value = Convert.ToInt32(idutilisateur.Text)
                    Else
                        requete = "UPDATE utilisateurs SET [nom]=?, [email]=?, [idrole]=?, [statut]=?, [datecreation]=? WHERE [idutilisateur]=?"
                        cmdsql()
                        cmd.Parameters.Clear()

                        cmd.Parameters.Add("@p1", OleDbType.VarChar).Value = nom.Text
                        cmd.Parameters.Add("@p2", OleDbType.VarChar).Value = email.Text
                        cmd.Parameters.Add("@p3", OleDbType.VarChar).Value = roleId
                        cmd.Parameters.Add("@p4", OleDbType.VarChar).Value = statut.Text
                        cmd.Parameters.Add("@p5", OleDbType.Date).Value = datecreation.Value
                        cmd.Parameters.Add("@p6", OleDbType.Integer).Value = Convert.ToInt32(idutilisateur.Text)
                    End If
                End If

                cmd.ExecuteNonQuery()
            Finally

                deconnexion()
            End Try

            Form15.afficher_utilisateurs()
            Me.Close()
        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur SQL")
            deconnexion()
        End Try
    End Sub


    Public Sub SelectRoleById(ByVal roleId As String)
        If String.IsNullOrEmpty(roleId) Then
            Return
        End If


        For i As Integer = 0 To idrole.Items.Count - 1
            Dim item As String = idrole.Items(i).ToString()
            If item.StartsWith(roleId & " |") Then
                idrole.SelectedIndex = i
                Return
            End If
        Next


        idrole.Text = roleId
    End Sub
End Class
