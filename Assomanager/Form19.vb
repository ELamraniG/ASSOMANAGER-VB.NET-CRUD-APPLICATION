Imports System.Data.OleDb

Public Class Form19
    Public etat As Integer

    Private Sub Form19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.Text = "Gestion des cotisations"
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

        afficher_cotisations()
    End Sub

    Public Sub afficher_cotisations()
        Try
            connexion()


            requete = "SELECT c.idcotisation, m.nom, m.prenom, c.montant, c.datepaiement, " & _
                     "c.modepaiement, c.statut, c.periodemois, c.periodeannee, c.idmembre " & _
                     "FROM cotisations c LEFT JOIN membres m ON c.idmembre = m.idmembre " & _
                     "ORDER BY c.datepaiement DESC"

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


            If DataGridView1.Columns.Count > 0 Then
                DataGridView1.Columns(0).HeaderText = "ID"
                DataGridView1.Columns(1).HeaderText = "Nom"
                DataGridView1.Columns(2).HeaderText = "Prénom"
                DataGridView1.Columns(3).HeaderText = "Montant"
                DataGridView1.Columns(4).HeaderText = "Date Paiement"
                DataGridView1.Columns(5).HeaderText = "Mode Paiement"
                DataGridView1.Columns(6).HeaderText = "Statut"
                DataGridView1.Columns(7).HeaderText = "Mois"
                DataGridView1.Columns(8).HeaderText = "Année"
                DataGridView1.Columns(9).HeaderText = "ID Membre"
                DataGridView1.Columns(9).Visible = False
            End If

            Dim nombre As Integer = DataGridView1.Rows.Count
            cpt.Text = "Nombre de cotisations : " + nombre.ToString
            If (Form20.type_operation.Text = "Ajouter") Then
                If DataGridView1.Rows.Count > 0 Then
                    DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows.Count - 1
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).Selected = True
                End If
            End If
            If (Form20.type_operation.Text = "Modifier") Then
                If DataGridView1.Rows.Count > Val(Form20.ligne_modifie.Text) Then
                    DataGridView1.Rows(Val(Form20.ligne_modifie.Text)).Selected = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
            deconnexion()
        End Try
    End Sub

    Private Sub Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        Form20.type_operation.Text = "Ajouter"
        Form20.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex


        Form20.idcotisation.Text = DataGridView1.Rows(i).Cells(0).Value.ToString

        Form20.idmembre.Text = DataGridView1.Rows(i).Cells(9).Value.ToString
        Form20.montant.Text = DataGridView1.Rows(i).Cells(3).Value.ToString
        Form20.datepaiement.Value = DataGridView1.Rows(i).Cells(4).Value
        Form20.modepaiement.Text = DataGridView1.Rows(i).Cells(5).Value.ToString
        Form20.statut.Text = DataGridView1.Rows(i).Cells(6).Value.ToString
        Form20.periodemois.Text = DataGridView1.Rows(i).Cells(7).Value.ToString
        Form20.periodeannee.Text = DataGridView1.Rows(i).Cells(8).Value.ToString

        Form20.ligne_modifie.Text = i
        Form20.type_operation.Text = "Modifier"
        Form20.ShowDialog()
    End Sub

    Private Sub Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supprimer.Click
        Form20.type_operation.Text = "Ajouter"
        If (DataGridView1.Rows.Count = 0) Then
            MsgBox("Aucune cotisation...", vbExclamation, "Message")
        Else
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            Dim id As String = DataGridView1.Rows(i).Cells(0).Value.ToString
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de supprimer cette cotisation ? ", vbYesNo + vbQuestion, "Confirmation")
            If (rep = vbYes) Then
                Try
                    connexion()
                    requete = "DELETE FROM cotisations WHERE idcotisation = " & id
                    cmdsql()
                    cmd.ExecuteNonQuery()
                    deconnexion()
                    afficher_cotisations()
                Catch ex As Exception
                    MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
                    deconnexion()
                End Try
            End If
        End If
    End Sub

    Private Sub Rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rechercher.Click
        Dim recherche As String
        recherche = InputBox("Entrez le nom, prénom du membre ou le statut de la cotisation : ", "Recherche", "")
        Try
            connexion()
            requete = "SELECT c.idcotisation, m.nom, m.prenom, c.montant, c.datepaiement, " & _
                     "c.modepaiement, c.statut, c.periodemois, c.periodeannee, c.idmembre " & _
                     "FROM cotisations c LEFT JOIN membres m ON c.idmembre = m.idmembre " & _
                     "WHERE m.nom LIKE '%" + recherche + "%' OR m.prenom LIKE '%" + recherche + "%' " & _
                     "OR c.statut LIKE '%" + recherche + "%' " & _
                     "ORDER BY c.datepaiement DESC"

            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter(requete, con)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
            deconnexion()

            If (DataGridView1.Rows.Count = 0) Then
                MsgBox("Aucune cotisation trouvée...", vbExclamation, "Message")
            End If
        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
            deconnexion()
        End Try
    End Sub

    Private Sub Actualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualiser.Click
        afficher_cotisations()
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
        e.Graphics.DrawString("Liste des cotisations", font_titre, Brushes.Black, cl, ln)
        Dim ligne As New Pen(Color.Gray)
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        ln = ln + 20
        With e.Graphics
            .DrawString("ID", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("Membre", font_tcolonne, Brushes.Black, cl + 50, ln)
            .DrawString("Montant", font_tcolonne, Brushes.Black, cl + 200, ln)
            .DrawString("Date", font_tcolonne, Brushes.Black, cl + 300, ln)
            .DrawString("Mode", font_tcolonne, Brushes.Black, cl + 400, ln)
            .DrawString("Statut", font_tcolonne, Brushes.Black, cl + 500, ln)
            .DrawString("Période", font_tcolonne, Brushes.Black, cl + 600, ln)
        End With
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Dim c1, c2, c3, c4, c5, c6, c7, c8, c9 As String
        Dim nld As Integer
        If etat = 1 Then nld = DataGridView1.Rows.Count
        If etat = 2 Then nld = DataGridView2.Rows.Count
        For i = 0 To nld - 1
            If etat = 1 Then
                c1 = DataGridView1.Rows(i).Cells(0).Value.ToString
                c2 = DataGridView1.Rows(i).Cells(1).Value.ToString & " " & DataGridView1.Rows(i).Cells(2).Value.ToString
                c3 = DataGridView1.Rows(i).Cells(3).Value.ToString
                c4 = DataGridView1.Rows(i).Cells(4).Value.ToString
                c5 = DataGridView1.Rows(i).Cells(5).Value.ToString
                c6 = DataGridView1.Rows(i).Cells(6).Value.ToString
                c7 = DataGridView1.Rows(i).Cells(7).Value.ToString & "/" & DataGridView1.Rows(i).Cells(8).Value.ToString
            Else
                c1 = DataGridView2.Rows(i).Cells(0).Value.ToString
                c2 = DataGridView2.Rows(i).Cells(1).Value.ToString & " " & DataGridView2.Rows(i).Cells(2).Value.ToString
                c3 = DataGridView2.Rows(i).Cells(3).Value.ToString
                c4 = DataGridView2.Rows(i).Cells(4).Value.ToString
                c5 = DataGridView2.Rows(i).Cells(5).Value.ToString
                c6 = DataGridView2.Rows(i).Cells(6).Value.ToString
                c7 = DataGridView2.Rows(i).Cells(7).Value.ToString & "/" & DataGridView2.Rows(i).Cells(8).Value.ToString
            End If

            With e.Graphics
                .DrawString(c1, font_colonne, Brushes.Black, cl, ln)
                .DrawString(c2, font_colonne, Brushes.Black, cl + 50, ln)
                .DrawString(c3, font_colonne, Brushes.Black, cl + 200, ln)
                .DrawString(c4, font_colonne, Brushes.Black, cl + 300, ln)
                .DrawString(c5, font_colonne, Brushes.Black, cl + 400, ln)
                .DrawString(c6, font_colonne, Brushes.Black, cl + 500, ln)
                .DrawString(c7, font_colonne, Brushes.Black, cl + 600, ln)
            End With
            ln = ln + 20
            e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 750, 1100)
        e.Graphics.DrawString("ASSOMANAGER : Liste des cotisations", font_titre, Brushes.Black, cl, 1100)
    End Sub

    Private Sub ImprimerListeDesEmployésDunServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerListeDesEmployésDunServiceToolStripMenuItem.Click
        etat = 2
        Dim statut_recherche As String
        statut_recherche = InputBox("Entrez le statut à rechercher (payé, en attente, retard)", "Imprimer liste des cotisations par statut", "payé")

        Try
            connexion()
            requete = "SELECT c.idcotisation, m.nom, m.prenom, c.montant, c.datepaiement, " & _
                     "c.modepaiement, c.statut, c.periodemois, c.periodeannee, c.idmembre " & _
                     "FROM cotisations c LEFT JOIN membres m ON c.idmembre = m.idmembre " & _
                     "WHERE c.statut = '" & statut_recherche & "' " & _
                     "ORDER BY c.datepaiement DESC"

            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter(requete, con)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView2.DataSource = dt.DefaultView
            deconnexion()

            Dim cpt As Integer = DataGridView2.Rows.Count()

            If cpt = 0 Then
                MsgBox("Aucune cotisation trouvée avec ce statut...", MsgBoxStyle.Information, "Message")
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
        Dim membre_recherche As String
        membre_recherche = InputBox("Entrez le nom du membre à rechercher", "Imprimer cotisations par membre", "")

        Try
            connexion()
            requete = "SELECT c.idcotisation, m.nom, m.prenom, c.montant, c.datepaiement, " & _
                     "c.modepaiement, c.statut, c.periodemois, c.periodeannee, c.idmembre " & _
                     "FROM cotisations c LEFT JOIN membres m ON c.idmembre = m.idmembre " & _
                     "WHERE m.nom LIKE '%" & membre_recherche & "%' OR m.prenom LIKE '%" & membre_recherche & "%' " & _
                     "ORDER BY c.datepaiement DESC"

            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter(requete, con)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView2.DataSource = dt.DefaultView
            deconnexion()

            Dim cpt As Integer = DataGridView2.Rows.Count()

            If cpt = 0 Then
                MsgBox("Aucune cotisation trouvée pour ce membre...", MsgBoxStyle.Information, "Message")
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
