Imports System.Data.OleDb

Public Class Form23
    Public etat As Integer

    Private Sub Form23_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.Text = "Gestion des participants aux événements"
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

        afficher_participants()
    End Sub

    Public Sub afficher_participants()
        Try
            connexion()


            requete = "SELECT p.idparticipantevenement, e.titre, m.nom, m.prenom, " & _
                     "p.statutpresence, e.datedebut, e.datefin, e.lieu, " & _
                     "p.idevenement, p.idmembre " & _
                     "FROM (participantevenements p " & _
                     "LEFT JOIN evenements e ON p.idevenement = e.idevenement) " & _
                     "LEFT JOIN membres m ON p.idmembre = m.idmembre " & _
                     "ORDER BY e.datedebut DESC, m.nom, m.prenom"

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
                DataGridView1.Columns(1).HeaderText = "Événement"
                DataGridView1.Columns(2).HeaderText = "Nom"
                DataGridView1.Columns(3).HeaderText = "Prénom"
                DataGridView1.Columns(4).HeaderText = "Statut Présence"
                DataGridView1.Columns(5).HeaderText = "Date Début"
                DataGridView1.Columns(6).HeaderText = "Date Fin"
                DataGridView1.Columns(7).HeaderText = "Lieu"
                DataGridView1.Columns(8).HeaderText = "ID Événement"
                DataGridView1.Columns(9).HeaderText = "ID Membre"
                DataGridView1.Columns(8).Visible = False
                DataGridView1.Columns(9).Visible = False
            End If

            Dim nombre As Integer = DataGridView1.Rows.Count
            cpt.Text = "Nombre de participants : " + nombre.ToString
            If (Form24.type_operation.Text = "Ajouter") Then
                If DataGridView1.Rows.Count > 0 Then
                    DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows.Count - 1
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).Selected = True
                End If
            End If
            If (Form24.type_operation.Text = "Modifier") Then
                If DataGridView1.Rows.Count > Val(Form24.ligne_modifie.Text) Then
                    DataGridView1.Rows(Val(Form24.ligne_modifie.Text)).Selected = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
            deconnexion()
        End Try
    End Sub

    Private Sub Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        Form24.type_operation.Text = "Ajouter"
        Form24.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex


        Form24.idparticipant.Text = DataGridView1.Rows(i).Cells(0).Value.ToString
        Form24.SelectEventById(DataGridView1.Rows(i).Cells(8).Value.ToString)
        Form24.SelectMembreById(DataGridView1.Rows(i).Cells(9).Value.ToString)
        Form24.statutpresence.Text = DataGridView1.Rows(i).Cells(4).Value.ToString

        Form24.ligne_modifie.Text = i
        Form24.type_operation.Text = "Modifier"
        Form24.ShowDialog()
    End Sub

    Private Sub Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supprimer.Click
        Form24.type_operation.Text = "Ajouter"
        If (DataGridView1.Rows.Count = 0) Then
            MsgBox("Aucun participant...", vbExclamation, "Message")
        Else
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            Dim id As String = DataGridView1.Rows(i).Cells(0).Value.ToString
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de supprimer ce participant ? ", vbYesNo + vbQuestion, "Confirmation")
            If (rep = vbYes) Then
                Try
                    connexion()
                    requete = "DELETE FROM participantevenements WHERE idparticipantevenement = " & id
                    cmdsql()
                    cmd.ExecuteNonQuery()
                    deconnexion()
                    afficher_participants()
                Catch ex As Exception
                    MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
                    deconnexion()
                End Try
            End If
        End If
    End Sub

    Private Sub Rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rechercher.Click
        Dim recherche As String
        recherche = InputBox("Entrez le nom du membre, titre de l'événement ou statut de présence : ", "Recherche", "")
        Try
            connexion()
            requete = "SELECT p.idparticipantevenement, e.titre, m.nom, m.prenom, " & _
                     "p.statutpresence, e.datedebut, e.datefin, e.lieu, " & _
                     "p.idevenement, p.idmembre " & _
                     "FROM (participantevenements p " & _
                     "LEFT JOIN evenements e ON p.idevenement = e.idevenement) " & _
                     "LEFT JOIN membres m ON p.idmembre = m.idmembre " & _
                     "WHERE m.nom LIKE '%" + recherche + "%' OR m.prenom LIKE '%" + recherche + "%' " & _
                     "OR e.titre LIKE '%" + recherche + "%' OR p.statutpresence LIKE '%" + recherche + "%' " & _
                     "ORDER BY e.datedebut DESC, m.nom, m.prenom"

            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter(requete, con)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
            deconnexion()

            If (DataGridView1.Rows.Count = 0) Then
                MsgBox("Aucun participant trouvé...", vbExclamation, "Message")
            End If
        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
            deconnexion()
        End Try
    End Sub

    Private Sub Actualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualiser.Click
        afficher_participants()
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
        e.Graphics.DrawString("Liste des participants aux événements", font_titre, Brushes.Black, cl, ln)
        Dim ligne As New Pen(Color.Gray)
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        ln = ln + 20
        With e.Graphics
            .DrawString("ID", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("Événement", font_tcolonne, Brushes.Black, cl + 50, ln)
            .DrawString("Participant", font_tcolonne, Brushes.Black, cl + 200, ln)
            .DrawString("Statut", font_tcolonne, Brushes.Black, cl + 350, ln)
            .DrawString("Date", font_tcolonne, Brushes.Black, cl + 450, ln)
            .DrawString("Lieu", font_tcolonne, Brushes.Black, cl + 550, ln)
        End With
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Dim c1, c2, c3, c4, c5, c6 As String
        Dim nld As Integer
        If etat = 1 Then nld = DataGridView1.Rows.Count
        If etat = 2 Then nld = DataGridView2.Rows.Count
        For i = 0 To nld - 1
            If etat = 1 Then
                c1 = DataGridView1.Rows(i).Cells(0).Value.ToString
                c2 = DataGridView1.Rows(i).Cells(1).Value.ToString
                c3 = DataGridView1.Rows(i).Cells(2).Value.ToString & " " & DataGridView1.Rows(i).Cells(3).Value.ToString
                c4 = DataGridView1.Rows(i).Cells(4).Value.ToString
                c5 = DataGridView1.Rows(i).Cells(5).Value.ToString
                c6 = DataGridView1.Rows(i).Cells(7).Value.ToString
            Else
                c1 = DataGridView2.Rows(i).Cells(0).Value.ToString
                c2 = DataGridView2.Rows(i).Cells(1).Value.ToString
                c3 = DataGridView2.Rows(i).Cells(2).Value.ToString & " " & DataGridView2.Rows(i).Cells(3).Value.ToString
                c4 = DataGridView2.Rows(i).Cells(4).Value.ToString
                c5 = DataGridView2.Rows(i).Cells(5).Value.ToString
                c6 = DataGridView2.Rows(i).Cells(7).Value.ToString
            End If

            With e.Graphics
                .DrawString(c1, font_colonne, Brushes.Black, cl, ln)
                .DrawString(c2, font_colonne, Brushes.Black, cl + 50, ln)
                .DrawString(c3, font_colonne, Brushes.Black, cl + 200, ln)
                .DrawString(c4, font_colonne, Brushes.Black, cl + 350, ln)
                .DrawString(c5, font_colonne, Brushes.Black, cl + 450, ln)
                .DrawString(c6, font_colonne, Brushes.Black, cl + 550, ln)
            End With
            ln = ln + 20
            e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 750, 1100)
        e.Graphics.DrawString("ASSOMANAGER : Liste des participants", font_titre, Brushes.Black, cl, 1100)
    End Sub

    Private Sub ImprimerListeDesEmployésDunServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerListeDesEmployésDunServiceToolStripMenuItem.Click
        etat = 2
        Dim statut_recherche As String
        statut_recherche = InputBox("Entrez le statut de présence à rechercher (présent, absent, inscrit)", "Imprimer participants par statut", "présent")

        Try
            connexion()
            requete = "SELECT p.idparticipantevenement, e.titre, m.nom, m.prenom, " & _
                     "p.statutpresence, e.datedebut, e.datefin, e.lieu, " & _
                     "p.idevenement, p.idmembre " & _
                     "FROM (participantevenements p " & _
                     "LEFT JOIN evenements e ON p.idevenement = e.idevenement) " & _
                     "LEFT JOIN membres m ON p.idmembre = m.idmembre " & _
                     "WHERE p.statutpresence = '" & statut_recherche & "' " & _
                     "ORDER BY e.datedebut DESC, m.nom, m.prenom"

            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter(requete, con)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView2.DataSource = dt.DefaultView
            deconnexion()

            Dim cpt As Integer = DataGridView2.Rows.Count()

            If cpt = 0 Then
                MsgBox("Aucun participant trouvé avec ce statut...", MsgBoxStyle.Information, "Message")
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

    Public Sub ImprimerHistoriqueDesAffectationsDunEmployéToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerHistoriqueDesAffectationsDunEmployéToolStripMenuItem.Click
        etat = 2
        Dim evenement_recherche As String
        evenement_recherche = InputBox("Entrez le titre de l'événement à rechercher", "Imprimer participants par événement", "")

        Try
            connexion()
            requete = "SELECT p.idparticipantevenement, e.titre, m.nom, m.prenom, " & _
                     "p.statutpresence, e.datedebut, e.datefin, e.lieu, " & _
                     "p.idevenement, p.idmembre " & _
                     "FROM (participantevenements p " & _
                     "LEFT JOIN evenements e ON p.idevenement = e.idevenement) " & _
                     "LEFT JOIN membres m ON p.idmembre = m.idmembre " & _
                     "WHERE e.titre LIKE '%" & evenement_recherche & "%' " & _
                     "ORDER BY e.datedebut DESC, m.nom, m.prenom"

            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter(requete, con)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView2.DataSource = dt.DefaultView
            deconnexion()

            Dim cpt As Integer = DataGridView2.Rows.Count()

            If cpt = 0 Then
                MsgBox("Aucun participant trouvé pour cet événement...", MsgBoxStyle.Information, "Message")
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
