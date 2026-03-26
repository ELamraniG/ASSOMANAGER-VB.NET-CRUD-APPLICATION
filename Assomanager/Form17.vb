Imports System.Data.OleDb

Public Class Form17
    Public etat As Integer

    Private Sub Form17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.Text = "Gestion des membres"
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

        afficher_membres()
    End Sub

    Public Sub afficher_membres()
        Try
            connexion()


            requete = "SELECT m.idmembre, m.nom, m.prenom, m.adresse, m.telephone, m.email, " & _
                     "m.idcategoriemembre, c.nomcategoriemembre, " & _
                     "m.statut, m.dateinscription " & _
                     "FROM membres m LEFT JOIN categoriemembre c ON m.idcategoriemembre = c.idcategoriemembre"

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


            If DataGridView1.Columns.Count > 7 Then
                DataGridView1.Columns(6).HeaderText = "ID Catégorie"
                DataGridView1.Columns(7).HeaderText = "Nom Catégorie"
            End If

            Dim nombre As Integer = DataGridView1.Rows.Count
            cpt.Text = "Nombre de membres : " + nombre.ToString
            If (Form18.type_operation.Text = "Ajouter") Then
                If DataGridView1.Rows.Count > 0 Then
                    DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows.Count - 1
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).Selected = True
                End If
            End If
            If (Form18.type_operation.Text = "Modifier") Then
                If DataGridView1.Rows.Count > Val(Form18.ligne_modifie.Text) Then
                    DataGridView1.Rows(Val(Form18.ligne_modifie.Text)).Selected = True
                End If
            End If
        Catch ex As Exception
            MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
            deconnexion()
        End Try
    End Sub

    Private Sub Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        Form18.type_operation.Text = "Ajouter"
        Form18.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex
        Form18.idmembre.Text = DataGridView1.Rows(i).Cells(0).Value.ToString
        Form18.nom.Text = DataGridView1.Rows(i).Cells(1).Value.ToString
        Form18.prenom.Text = DataGridView1.Rows(i).Cells(2).Value.ToString
        Form18.adresse.Text = DataGridView1.Rows(i).Cells(3).Value.ToString
        Form18.telephone.Text = DataGridView1.Rows(i).Cells(4).Value.ToString
        Form18.email.Text = DataGridView1.Rows(i).Cells(5).Value.ToString
        Form18.ancien_email.Text = DataGridView1.Rows(i).Cells(5).Value.ToString


        Dim categorieId As String = DataGridView1.Rows(i).Cells(6).Value.ToString
        Form18.SelectCategorieById(categorieId)

        Form18.statut.Text = DataGridView1.Rows(i).Cells(8).Value.ToString
        Form18.dateinscription.Value = DataGridView1.Rows(i).Cells(9).Value
        Form18.ligne_modifie.Text = i
        Form18.type_operation.Text = "Modifier"
        Form18.ShowDialog()
    End Sub

    Private Sub Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supprimer.Click
        Form18.type_operation.Text = "Ajouter"
        If (DataGridView1.Rows.Count = 0) Then
            MsgBox("Aucun membre...", vbExclamation, "Message")
        Else
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            Dim id As String = DataGridView1.Rows(i).Cells(0).Value.ToString
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de supprimer ce membre ? ", vbYesNo + vbQuestion, "Confirmation")
            If (rep = vbYes) Then
                Try
                    connexion()
                    requete = "DELETE FROM membres WHERE idmembre = " & id
                    cmdsql()
                    cmd.ExecuteNonQuery()
                    deconnexion()
                    afficher_membres()
                Catch ex As Exception
                    MsgBox("Erreur: " & ex.Message, vbExclamation, "Erreur de base de données")
                    deconnexion()
                End Try
            End If
        End If
    End Sub

    Private Sub Rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rechercher.Click
        Dim nom_a_chercher As String
        nom_a_chercher = InputBox("Entrez le nom, prénom ou email du membre à chercher : ", "Recherche", "")
        Try
            connexion()

            requete = "SELECT m.idmembre, m.nom, m.prenom, m.adresse, m.telephone, m.email, " & _
                     "m.idcategoriemembre, c.nomcategoriemembre, " & _
                     "m.statut, m.dateinscription " & _
                     "FROM membres m LEFT JOIN categoriemembre c ON m.idcategoriemembre = c.idcategoriemembre " & _
                     "WHERE m.nom LIKE '%" + nom_a_chercher + "%' OR m.prenom LIKE '%" + nom_a_chercher + "%' " & _
                     "OR m.email LIKE '%" + nom_a_chercher + "%'"
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
        afficher_membres()
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
        e.Graphics.DrawString("Liste des membres", font_titre, Brushes.Black, cl, ln)
        Dim ligne As New Pen(Color.Gray)
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        ln = ln + 20
        With e.Graphics
            .DrawString("ID", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("Nom", font_tcolonne, Brushes.Black, cl + 50, ln)
            .DrawString("Prénom", font_tcolonne, Brushes.Black, cl + 150, ln)
            .DrawString("Téléphone", font_tcolonne, Brushes.Black, cl + 250, ln)
            .DrawString("Email", font_tcolonne, Brushes.Black, cl + 350, ln)
            .DrawString("Catégorie", font_tcolonne, Brushes.Black, cl + 500, ln)
            .DrawString("Statut", font_tcolonne, Brushes.Black, cl + 600, ln)
            .DrawString("Inscription", font_tcolonne, Brushes.Black, cl + 650, ln)
        End With
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Dim c1, c2, c3, c4, c5, c7, c8, c9 As String
        Dim nld As Integer
        If etat = 1 Then nld = DataGridView1.Rows.Count
        If etat = 2 Then nld = DataGridView2.Rows.Count
        For i = 0 To nld - 1
            If etat = 1 Then
                c1 = DataGridView1.Rows(i).Cells(0).Value.ToString
                c2 = DataGridView1.Rows(i).Cells(1).Value.ToString
                c3 = DataGridView1.Rows(i).Cells(2).Value.ToString
                c4 = DataGridView1.Rows(i).Cells(4).Value.ToString
                c5 = DataGridView1.Rows(i).Cells(5).Value.ToString
                c7 = DataGridView1.Rows(i).Cells(7).Value.ToString
                c8 = DataGridView1.Rows(i).Cells(8).Value.ToString
                c9 = DataGridView1.Rows(i).Cells(9).Value.ToString
            Else
                c1 = DataGridView2.Rows(i).Cells(0).Value.ToString
                c2 = DataGridView2.Rows(i).Cells(1).Value.ToString
                c3 = DataGridView2.Rows(i).Cells(2).Value.ToString
                c4 = DataGridView2.Rows(i).Cells(4).Value.ToString
                c5 = DataGridView2.Rows(i).Cells(5).Value.ToString
                c7 = DataGridView2.Rows(i).Cells(7).Value.ToString
                c8 = DataGridView2.Rows(i).Cells(8).Value.ToString
                c9 = DataGridView2.Rows(i).Cells(9).Value.ToString
            End If

            With e.Graphics
                .DrawString(c1, font_colonne, Brushes.Black, cl, ln)
                .DrawString(c2, font_colonne, Brushes.Black, cl + 50, ln)
                .DrawString(c3, font_colonne, Brushes.Black, cl + 150, ln)
                .DrawString(c4, font_colonne, Brushes.Black, cl + 250, ln)
                .DrawString(c5, font_colonne, Brushes.Black, cl + 350, ln)
                .DrawString(c7, font_colonne, Brushes.Black, cl + 500, ln)
                .DrawString(c8, font_colonne, Brushes.Black, cl + 600, ln)
                .DrawString(c9, font_colonne, Brushes.Black, cl + 650, ln)
            End With
            ln = ln + 20
            e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 750, 1100)
        e.Graphics.DrawString("Entreprise : Liste des membres", font_titre, Brushes.Black, cl, 1100)
    End Sub

    Public Sub ImprimerListeDesEmployésDunServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerListeDesEmployésDunServiceToolStripMenuItem.Click
        etat = 2
        Dim categorie_recherche As String
        categorie_recherche = InputBox("Entrez l'ID de la catégorie à rechercher", "Imprimer liste des membres par catégorie", "")

        Try

            connexion()
            requete = "SELECT m.idmembre, m.nom, m.prenom, m.adresse, m.telephone, m.email, " & _
                     "m.idcategoriemembre, c.nomcategoriemembre, " & _
                     "m.statut, m.dateinscription " & _
                     "FROM membres m LEFT JOIN categoriemembre c ON m.idcategoriemembre = c.idcategoriemembre " & _
                     "WHERE m.idcategoriemembre = " & categorie_recherche

            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter(requete, con)
            Dim dt As New DataTable
            Dim ds As New DataSet
            da.Fill(dt)
            DataGridView2.DataSource = dt.DefaultView
            deconnexion()

            Dim cpt As Integer = DataGridView2.Rows.Count()

            If cpt = 0 Then
                MsgBox("Aucun membre trouvé dans cette catégorie...", MsgBoxStyle.Information, "Message")
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
        statut_recherche = InputBox("Entrez le statut à rechercher (actif/inactif)", "Imprimer liste des membres par statut", "actif")

        Try

            connexion()
            requete = "SELECT m.idmembre, m.nom, m.prenom, m.adresse, m.telephone, m.email, " & _
                     "m.idcategoriemembre, c.nomcategoriemembre, " & _
                     "m.statut, m.dateinscription " & _
                     "FROM membres m LEFT JOIN categoriemembre c ON m.idcategoriemembre = c.idcategoriemembre " & _
                     "WHERE m.statut = '" & statut_recherche & "'"

            Dim da As New OleDbDataAdapter
            da = New OleDbDataAdapter(requete, con)
            Dim dt As New DataTable
            Dim ds As New DataSet
            da.Fill(dt)
            DataGridView2.DataSource = dt.DefaultView
            deconnexion()

            Dim cpt As Integer = DataGridView2.Rows.Count()

            If cpt = 0 Then
                MsgBox("Aucun membre trouvé avec ce statut...", MsgBoxStyle.Information, "Message")
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
