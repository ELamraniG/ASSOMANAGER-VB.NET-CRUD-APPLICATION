Imports System.Data.OleDb

Public Class Form21
    Public etat As Integer

    Private Sub Form21_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.Text = "Gestion des dépenses"
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

        afficher_depenses()
    End Sub

    Public Sub afficher_depenses()
        Try
            connexion()


            requete = "SELECT d.iddepense, d.libelle, d.montant, d.datedepense, " & _
                     "c.nomcategoriedepense, d.fournisseur, d.justificatif, d.idcategoriedepense " & _
                     "FROM depenses d LEFT JOIN categoriedepenses c ON d.idcategoriedepense = c.idcategoriedepense " & _
                     "ORDER BY d.datedepense DESC"

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
                DataGridView1.Columns(1).HeaderText = "Libellé"
                DataGridView1.Columns(2).HeaderText = "Montant"
                DataGridView1.Columns(3).HeaderText = "Date"
                DataGridView1.Columns(4).HeaderText = "Catégorie"
                DataGridView1.Columns(5).HeaderText = "Fournisseur"
                DataGridView1.Columns(6).HeaderText = "Justificatif"
                DataGridView1.Columns(7).HeaderText = "ID Catégorie"
                DataGridView1.Columns(7).Visible = False
            End If

            Dim nombre As Integer = DataGridView1.Rows.Count
            cpt.Text = "Nombre de dépenses : " + nombre.ToString
            If (Form22.type_operation.Text = "Ajouter") Then
                If DataGridView1.Rows.Count > 0 Then
                    DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows.Count - 1
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).Selected = True
                End If
            End If
            If (Form22.type_operation.Text = "Modifier") Then
                If DataGridView1.Rows.Count > Val(Form22.ligne_modifie.Text) Then
                    DataGridView1.Rows(Val(Form22.ligne_modifie.Text)).Selected = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
            deconnexion()
        End Try
    End Sub

    Private Sub Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        Form22.type_operation.Text = "Ajouter"
        Form22.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex


        Form22.iddepense.Text = DataGridView1.Rows(i).Cells(0).Value.ToString
        Form22.libelle.Text = DataGridView1.Rows(i).Cells(1).Value.ToString
        Form22.montant.Text = DataGridView1.Rows(i).Cells(2).Value.ToString
        Form22.datedepense.Value = DataGridView1.Rows(i).Cells(3).Value
        Form22.idcategoriedepense.Text = DataGridView1.Rows(i).Cells(7).Value.ToString
        Form22.fournisseur.Text = DataGridView1.Rows(i).Cells(5).Value.ToString
        Form22.justificatif.Text = DataGridView1.Rows(i).Cells(6).Value.ToString

        Form22.ligne_modifie.Text = i
        Form22.type_operation.Text = "Modifier"
        Form22.ShowDialog()
    End Sub

    Private Sub Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supprimer.Click
        Form22.type_operation.Text = "Ajouter"
        If (DataGridView1.Rows.Count = 0) Then
            MsgBox("Aucune dépense...", vbExclamation, "Message")
        Else
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            Dim id As String = DataGridView1.Rows(i).Cells(0).Value.ToString
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de supprimer cette dépense ? ", vbYesNo + vbQuestion, "Confirmation")
            If (rep = vbYes) Then
                Try
                    connexion()
                    requete = "DELETE FROM depenses WHERE iddepense = " & id
                    cmdsql()
                    cmd.ExecuteNonQuery()
                    deconnexion()
                    afficher_depenses()
                Catch ex As Exception
                    MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
                    deconnexion()
                End Try
            End If
        End If
    End Sub

    Private Sub Rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rechercher.Click
        Dim recherche As String
        recherche = InputBox("Entrez le libellé, le fournisseur ou la catégorie à rechercher : ", "Recherche", "")
        Try
            connexion()
            requete = "SELECT d.iddepense, d.libelle, d.montant, d.datedepense, " & _
                     "c.nomcategoriedepense, d.fournisseur, d.justificatif, d.idcategoriedepense " & _
                     "FROM depenses d LEFT JOIN categoriedepenses c ON d.idcategoriedepense = c.idcategoriedepense " & _
                     "WHERE d.libelle LIKE '%" + recherche + "%' OR d.fournisseur LIKE '%" + recherche + "%' " & _
                     "OR c.nomcategoriedepense LIKE '%" + recherche + "%' " & _
                     "ORDER BY d.datedepense DESC"

            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter(requete, con)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
            deconnexion()

            If (DataGridView1.Rows.Count = 0) Then
                MsgBox("Aucune dépense trouvée...", vbExclamation, "Message")
            End If
        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
            deconnexion()
        End Try
    End Sub

    Private Sub Actualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualiser.Click
        afficher_depenses()
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
        e.Graphics.DrawString("Liste des dépenses", font_titre, Brushes.Black, cl, ln)
        Dim ligne As New Pen(Color.Gray)
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        ln = ln + 20
        With e.Graphics
            .DrawString("ID", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("Libellé", font_tcolonne, Brushes.Black, cl + 50, ln)
            .DrawString("Montant", font_tcolonne, Brushes.Black, cl + 200, ln)
            .DrawString("Date", font_tcolonne, Brushes.Black, cl + 300, ln)
            .DrawString("Catégorie", font_tcolonne, Brushes.Black, cl + 400, ln)
            .DrawString("Fournisseur", font_tcolonne, Brushes.Black, cl + 500, ln)
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
                c3 = DataGridView1.Rows(i).Cells(2).Value.ToString
                c4 = DataGridView1.Rows(i).Cells(3).Value.ToString
                c5 = DataGridView1.Rows(i).Cells(4).Value.ToString
                c6 = DataGridView1.Rows(i).Cells(5).Value.ToString
            Else
                c1 = DataGridView2.Rows(i).Cells(0).Value.ToString
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
                .DrawString(c4, font_colonne, Brushes.Black, cl + 300, ln)
                .DrawString(c5, font_colonne, Brushes.Black, cl + 400, ln)
                .DrawString(c6, font_colonne, Brushes.Black, cl + 500, ln)
            End With
            ln = ln + 20
            e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 750, 1100)
        e.Graphics.DrawString("ASSOMANAGER : Liste des dépenses", font_titre, Brushes.Black, cl, 1100)
    End Sub

    Private Sub ImprimerListeDesEmployésDunServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerListeDesEmployésDunServiceToolStripMenuItem.Click
        etat = 2
        Dim categorie_recherche As String
        categorie_recherche = InputBox("Entrez la catégorie de dépense à rechercher", "Imprimer dépenses par catégorie", "")

        Try
            connexion()
            requete = "SELECT d.iddepense, d.libelle, d.montant, d.datedepense, " & _
                     "c.nomcategoriedepense, d.fournisseur, d.justificatif, d.idcategoriedepense " & _
                     "FROM depenses d LEFT JOIN categoriedepenses c ON d.idcategoriedepense = c.idcategoriedepense " & _
                     "WHERE c.nomcategoriedepense LIKE '%" & categorie_recherche & "%' " & _
                     "ORDER BY d.datedepense DESC"

            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter(requete, con)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView2.DataSource = dt.DefaultView
            deconnexion()

            Dim cpt As Integer = DataGridView2.Rows.Count()

            If cpt = 0 Then
                MsgBox("Aucune dépense trouvée dans cette catégorie...", MsgBoxStyle.Information, "Message")
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
        Dim fournisseur_recherche As String
        fournisseur_recherche = InputBox("Entrez le nom du fournisseur à rechercher", "Imprimer dépenses par fournisseur", "")

        Try
            connexion()
            requete = "SELECT d.iddepense, d.libelle, d.montant, d.datedepense, " & _
                     "c.nomcategoriedepense, d.fournisseur, d.justificatif, d.idcategoriedepense " & _
                     "FROM depenses d LEFT JOIN categoriedepenses c ON d.idcategoriedepense = c.idcategoriedepense " & _
                     "WHERE d.fournisseur LIKE '%" & fournisseur_recherche & "%' " & _
                     "ORDER BY d.datedepense DESC"

            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter(requete, con)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView2.DataSource = dt.DefaultView
            deconnexion()

            Dim cpt As Integer = DataGridView2.Rows.Count()

            If cpt = 0 Then
                MsgBox("Aucune dépense trouvée pour ce fournisseur...", MsgBoxStyle.Information, "Message")
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
