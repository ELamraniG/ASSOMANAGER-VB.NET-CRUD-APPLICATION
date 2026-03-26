Imports System.Data.OleDb

Public Class Form15
    Public etat As Integer

    Private Sub Form15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.Text = "Gestion des utilisateurs"
        Me.BackColor = Color.White
        Me.Width = 1200
        Me.Height = 600
        Me.CenterToScreen()


        DataGridView1.Location = New Point(20, 40)
        DataGridView1.Width = Me.Width - 40
        DataGridView1.Height = Me.Height - 220
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom

        afficher_utilisateurs()
    End Sub

    Public Sub afficher_utilisateurs()
        Try
            connexion()


            requete = "SELECT u.idutilisateur, u.nom, u.email, u.idrole, r.nomrole, " & _
                     "u.statut, u.datecreation " & _
                     "FROM utilisateurs u LEFT JOIN roles r ON u.idrole = r.idrole"

            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable

            Try
                da = New OleDbDataAdapter(requete, con)
                da.Fill(dt)
                DataGridView1.DataSource = dt.DefaultView
            Finally

                If da IsNot Nothing Then
                    da.Dispose()
                End If
                deconnexion()
            End Try


            If DataGridView1.Columns.Count > 4 Then
                DataGridView1.Columns(3).HeaderText = "ID Rôle"
                DataGridView1.Columns(4).HeaderText = "Nom du Rôle"
            End If

            Dim nombre As Integer = DataGridView1.Rows.Count
            cpt.Text = "Nombre d'utilisateurs : " + nombre.ToString
            If (Form16.type_operation.Text = "Ajouter") Then
                If DataGridView1.Rows.Count > 0 Then
                    DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows.Count - 1
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).Selected = True
                End If
            End If
            If (Form16.type_operation.Text = "Modifier") Then
                If DataGridView1.Rows.Count > Val(Form16.ligne_modifie.Text) Then
                    DataGridView1.Rows(Val(Form16.ligne_modifie.Text)).Selected = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
            deconnexion()
        End Try
    End Sub

    Private Sub Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        Form16.type_operation.Text = "Ajouter"
        Form16.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex
        Form16.idutilisateur.Text = DataGridView1.Rows(i).Cells(0).Value.ToString
        Form16.nom.Text = DataGridView1.Rows(i).Cells(1).Value.ToString
        Form16.email.Text = DataGridView1.Rows(i).Cells(2).Value.ToString
        Form16.ancien_email.Text = DataGridView1.Rows(i).Cells(2).Value.ToString


        Dim roleId As String = DataGridView1.Rows(i).Cells(3).Value.ToString
        Form16.SelectRoleById(roleId)

        Form16.statut.Text = DataGridView1.Rows(i).Cells(5).Value.ToString
        Form16.datecreation.Value = DataGridView1.Rows(i).Cells(6).Value
        Form16.ligne_modifie.Text = i
        Form16.type_operation.Text = "Modifier"
        Form16.ShowDialog()
    End Sub

    Private Sub Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supprimer.Click
        Form16.type_operation.Text = "Ajouter"
        If (DataGridView1.Rows.Count = 0) Then
            MsgBox("Aucun utilisateur...", vbExclamation, "Message")
        Else
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            Dim id As String = DataGridView1.Rows(i).Cells(0).Value.ToString
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de supprimer cet utilisateur ? ", vbYesNo + vbQuestion, "Confirmation")
            If (rep = vbYes) Then
                Try
                    connexion()
                    requete = "DELETE FROM utilisateurs WHERE idutilisateur = " & id
                    cmdsql()
                    cmd.ExecuteNonQuery()
                    deconnexion()
                    afficher_utilisateurs()
                Catch ex As Exception
                    MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
                    deconnexion()
                End Try
            End If
        End If
    End Sub

    Private Sub Rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rechercher.Click
        Dim nom_a_chercher As String
        nom_a_chercher = InputBox("Entrez le nom, l'email ou le rôle de l'utilisateur à chercher : ", "Recherche", "")
        Try
            connexion()

            requete = "SELECT u.idutilisateur, u.nom, u.email, u.idrole, r.nomrole, " & _
                     "u.statut, u.datecreation " & _
                     "FROM utilisateurs u LEFT JOIN roles r ON u.idrole = r.idrole " & _
                     "WHERE u.nom LIKE '%" + nom_a_chercher + "%' OR u.email LIKE '%" + nom_a_chercher + "%' " & _
                     "OR r.nomrole LIKE '%" + nom_a_chercher + "%'"
            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter(requete, con)
            Dim dt As New DataTable
            Dim ds As New DataSet
            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
            deconnexion()
            If (DataGridView1.Rows.Count = 0) Then MsgBox("Introuvable...", vbExclamation, "Message")
        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
            deconnexion()
        End Try
    End Sub

    Private Sub Actualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualiser.Click
        afficher_utilisateurs()
    End Sub

    Private Sub ImprimerTousLesServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
        etat = 1
        DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
        PrintDocument1.DefaultPageSettings.Landscape = False
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font_titre As New Font("Arial", 12, FontStyle.Regular)
        Dim font_tcolonne As New Font("Arial", 10, FontStyle.Bold)
        Dim font_colonne As New Font("Arial", 10, FontStyle.Regular)
        Dim ln As Integer = 50
        Dim cl As Integer = 50
        e.Graphics.DrawString("Liste des utilisateurs", font_titre, Brushes.Black, cl, ln)
        Dim ligne As New Pen(Color.Gray)
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        ln = ln + 20
        With e.Graphics
            .DrawString("ID", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("Nom", font_tcolonne, Brushes.Black, cl + 50, ln)
            .DrawString("Email", font_tcolonne, Brushes.Black, cl + 200, ln)
            .DrawString("ID Rôle", font_tcolonne, Brushes.Black, cl + 400, ln)
            .DrawString("Nom Rôle", font_tcolonne, Brushes.Black, cl + 450, ln)
            .DrawString("Statut", font_tcolonne, Brushes.Black, cl + 550, ln)
            .DrawString("Date création", font_tcolonne, Brushes.Black, cl + 620, ln)
        End With
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Dim c1, c2, c3, c4, c5, c6, c7 As String
        Dim nld As Integer
        If etat = 1 Then nld = DataGridView1.Rows.Count
        If etat = 2 Then nld = DataGridView2.Rows.Count
        For i = 0 To nld - 1
            If etat = 1 Then
                c1 = DataGridView1.Rows(i).Cells(0).Value.ToString
                c2 = DataGridView1.Rows(i).Cells(1).Value.ToString
                c3 = DataGridView1.Rows(i).Cells(2).Value.ToString
                c4 = DataGridView1.Rows(i).Cells(3).Value.ToString
                c5 = DataGridView1.Rows(i).Cells(4).Value.ToString
                c6 = DataGridView1.Rows(i).Cells(5).Value.ToString
                c7 = DataGridView1.Rows(i).Cells(6).Value.ToString
            Else
                c1 = DataGridView2.Rows(i).Cells(0).Value.ToString
                c2 = DataGridView2.Rows(i).Cells(1).Value.ToString
                c3 = DataGridView2.Rows(i).Cells(2).Value.ToString
                c4 = DataGridView2.Rows(i).Cells(3).Value.ToString
                c5 = DataGridView2.Rows(i).Cells(4).Value.ToString
                c6 = DataGridView2.Rows(i).Cells(5).Value.ToString
                c2 = DataGridView2.Rows(i).Cells(1).Value.ToString
                c3 = DataGridView2.Rows(i).Cells(2).Value.ToString
                c4 = DataGridView2.Rows(i).Cells(3).Value.ToString
                c5 = DataGridView2.Rows(i).Cells(4).Value.ToString
                c6 = DataGridView2.Rows(i).Cells(5).Value.ToString
            End If

            With e.Graphics
                .DrawString(c1, font_colonne, Brushes.Black, cl, ln)
                .DrawString(c2, font_colonne, Brushes.Black, cl + 50, ln)
                .DrawString(c3, font_colonne, Brushes.Black, cl + 200, ln)
                .DrawString(c4, font_colonne, Brushes.Black, cl + 400, ln)
                .DrawString(c5, font_colonne, Brushes.Black, cl + 450, ln)
                .DrawString(c6, font_colonne, Brushes.Black, cl + 550, ln)
            End With
            ln = ln + 20
            e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 750, 1100)
        e.Graphics.DrawString("Entreprise : Liste des utilisateurs", font_titre, Brushes.Black, cl, 1100)
    End Sub

    Private Sub ImprimerListeDesEmployésDunServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerListeDesEmployésDunServiceToolStripMenuItem.Click
        etat = 2
        Dim role_recherche As String
        role_recherche = InputBox("Entrez l'ID du rôle à rechercher", "Imprimer liste des utilisateurs par rôle", "")

        Try

            connexion()
            requete = "SELECT u.idutilisateur, u.nom, u.email, u.idrole, r.nomrole, " & _
                "u.statut, u.datecreation " & _
                "FROM utilisateurs u LEFT JOIN roles r ON u.idrole = r.idrole " & _
                "WHERE u.idrole = " & role_recherche

            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter(requete, con)
            Dim dt As New DataTable
            Dim ds As New DataSet
            da.Fill(dt)
            DataGridView2.DataSource = dt.DefaultView
            deconnexion()

            Dim cpt As Integer = DataGridView2.Rows.Count()

            If cpt = 0 Then
                MsgBox("Aucun utilisateur trouvé avec ce rôle...", MsgBoxStyle.Information, "Message")
            Else

                DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
                PrintDocument1.DefaultPageSettings.Landscape = False
                PrintPreviewDialog1.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
            deconnexion()
        End Try
    End Sub

    Private Sub ImprimerHistoriqueDesAffectationsDunEmployéToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerHistoriqueDesAffectationsDunEmployéToolStripMenuItem.Click
        etat = 2
        Dim statut_recherche As String
        statut_recherche = InputBox("Entrez le statut à rechercher (actif/inactif)", "Imprimer liste des utilisateurs par statut", "actif")

        Try

            connexion()
            requete = "SELECT idutilisateur, nom, email, idrole, statut, datecreation " & _
                "FROM utilisateurs " & _
                "WHERE statut = '" & statut_recherche & "'"

            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter(requete, con)
            Dim dt As New DataTable
            Dim ds As New DataSet
            da.Fill(dt)
            DataGridView2.DataSource = dt.DefaultView
            deconnexion()

            Dim cpt As Integer = DataGridView2.Rows.Count()

            If cpt = 0 Then
                MsgBox("Aucun utilisateur trouvé avec ce statut...", MsgBoxStyle.Information, "Message")
            Else

                DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
                PrintDocument1.DefaultPageSettings.Landscape = False
                PrintPreviewDialog1.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
            deconnexion()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Imprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimer.Click

    End Sub

    Private Sub toolbar_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles toolbar.ItemClicked

    End Sub
End Class
