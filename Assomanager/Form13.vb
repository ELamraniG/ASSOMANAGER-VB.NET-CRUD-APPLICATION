Imports System.Data.OleDb
Public Class Form13

    Private nombredocuments As Integer = 0
    Private WithEvents DataGridView13 As New DataGridView

    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim requete As String
    Dim da As OleDbDataAdapter
    Dim ds As DataSet

    Private Sub connexion()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AssoManager.accdb")
        con.Open()
    End Sub

    Private Sub cmdsql()
        cmd = New OleDbCommand(requete, con)
    End Sub

    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Width = 1560
        Me.Height = 780
        Me.CenterToScreen()
        dgv13.Width = Me.Width - 50
        dgv13.Height = Me.Height - 120
        Me.Text = "Gestion des documents"

        dgv13.BorderStyle = BorderStyle.None
        dgv13.DefaultCellStyle.Font = New Font("Arial", 10)
        dgv13.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv13.ColumnHeadersDefaultCellStyle.BackColor = Color.Beige
        dgv13.EnableHeadersVisualStyles = False
        dgv13.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        dgv13.CellBorderStyle = DataGridViewCellBorderStyle.None


        afficher_documents()

        nombredocuments = dgv13.Rows.Count
        If nombredocuments = 0 Then
            nombredocuments = 1
        End If

        Controls.Add(DataGridView13)
        DataGridView13.Visible = False

        AddHandler ToolStripButton132.Click, AddressOf ToolStripButton132_Click
        AddHandler ToolStripButton133.Click, AddressOf ToolStripButton133_Click
        AddHandler ToolStripButton134.Click, AddressOf ToolStripButton134_Click
        AddHandler dgv13.CellDoubleClick, AddressOf dgv13_CellDoubleClick
    End Sub


    Public Sub afficher_documents()
        Try
            connexion()

            requete = "SELECT iddocument, titre, cheminfichier, typedocument, dateajout FROM documents ORDER BY iddocument ASC"
            da = New OleDbDataAdapter(requete, con)
            ds = New DataSet()
            da.Fill(ds, "documents")
            dgv13.DataSource = ds.Tables("documents")


            If dgv13.Columns.Count >= 5 Then
                dgv13.Columns(0).HeaderText = "ID"
                dgv13.Columns(0).Width = 32
                dgv13.Columns(1).HeaderText = "Titre"
                dgv13.Columns(1).Width = 150
                dgv13.Columns(2).HeaderText = "Chemin fichier"
                dgv13.Columns(2).Width = 200
                dgv13.Columns(3).HeaderText = "Type"
                dgv13.Columns(3).Width = 120
                dgv13.Columns(4).HeaderText = "Date ajout"
                dgv13.Columns(4).Width = 100
            End If

            con.Close()


            Dim nombre As Integer = dgv13.Rows.Count
            Label13.Text = "Nombre de documents : " + nombre.ToString
            Label13.Left = Me.Width - Label13.Width - 50

        Catch ex As Exception
            MsgBox("Erreur lors du chargement des documents: " & ex.Message, vbExclamation, "Erreur")
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub


    Public Sub afficher_entity13()

    End Sub

    Private Sub ToolStripButton131_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton131.Click
        Dim frm As New Form14()
        frm.IsEditMode = False
        frm.ParametreId = ""
        frm.ParametreCle = ""
        frm.ShowDialog()


        afficher_documents()
    End Sub

    Private Sub dgv13_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim i As Integer
        i = dgv13.CurrentCell.RowIndex

        If i < 0 OrElse i >= dgv13.Rows.Count Then
            Return
        End If

        Dim frm As New Form14()
        frm.IsEditMode = True


        frm.ParametreId = dgv13.Rows(i).Cells(0).Value.ToString()

        If dgv13.Rows(i).Cells(1).Value IsNot Nothing Then
            frm.ParametreCle = dgv13.Rows(i).Cells(1).Value.ToString()
        Else
            frm.ParametreCle = ""
        End If

        If dgv13.Rows(i).Cells(2).Value IsNot Nothing Then
            frm.CheminFichier = dgv13.Rows(i).Cells(2).Value.ToString()
        End If

        If dgv13.Rows(i).Cells(3).Value IsNot Nothing Then
            frm.TypeDocument = dgv13.Rows(i).Cells(3).Value.ToString()
        End If

        If dgv13.Rows(i).Cells(4).Value IsNot Nothing Then
            frm.DateAjout = CDate(dgv13.Rows(i).Cells(4).Value)
        End If

        frm.ShowDialog()


        afficher_documents()
    End Sub

    Private Sub ToolStripButton132_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (dgv13.Rows.Count = 0) Then
            MsgBox("Aucun document disponible...", vbExclamation, "Message")
        Else
            Dim rep As MsgBoxResult
            rep = MsgBox("Êtes-vous sûr de vouloir supprimer ce document ?", vbQuestion + vbYesNo, "Message")
            If (rep = vbYes) Then
                connexion()
                Dim i As Integer
                i = dgv13.CurrentCell.RowIndex
                Dim id As Integer
                If Integer.TryParse(dgv13.Rows(i).Cells(0).Value.ToString(), id) Then
                    requete = "DELETE FROM documents WHERE iddocument = " & id
                    cmdsql()
                    cmd.ExecuteNonQuery()
                    MsgBox("Document supprimé avec succès", vbInformation)
                Else
                    MsgBox("ID du document invalide", vbExclamation)
                End If
                con.Close()
                afficher_documents()
            End If
        End If
    End Sub

    Private Sub ToolStripButton133_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        afficher_documents()
    End Sub

    Private Sub ToolStripButton134_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim titreachercher As String
        titreachercher = InputBox("Entrez le titre du document à chercher", "Rechercher par titre", "")
        If String.IsNullOrEmpty(titreachercher) Then Return


        requete = "SELECT * FROM documents WHERE titre LIKE '%" & titreachercher & "%' ORDER BY iddocument ASC"
        connexion()
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgv13.DataSource = dt.DefaultView

        If (dgv13.Rows.Count = 0) Then
            MsgBox("Ce document est introuvable.", vbExclamation, "Message")
        End If
        con.Close()
    End Sub

    Private Sub ImprimerTousLesServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
        DirectCast(d13, Form).WindowState = FormWindowState.Maximized
        P13.DefaultPageSettings.Landscape = False
        d13.ShowDialog()
    End Sub

    Private Sub DataGridView13_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView13.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim categorieId As String = DataGridView13.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim nomCategorie As String = ""

            If DataGridView13.Rows(e.RowIndex).Cells(1).Value IsNot Nothing Then
                nomCategorie = DataGridView13.Rows(e.RowIndex).Cells(1).Value.ToString()
            End If

            Dim frm As New Form14()
            frm.ParametreId = categorieId
            frm.ParametreCle = nomCategorie
            frm.ShowDialog()
        End If
    End Sub

    Public Sub refreshdatagridviewentity13()
        DataGridView13.DataSource = Nothing
        DataGridView13.Rows.Clear()

        Dim mysql As String = "SELECT * FROM categoriedepenses ORDER BY idcategoriedepense"

        connexion()
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(mysql, con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView13.DataSource = dt.DefaultView
        con.Close()

        nombredocuments = DataGridView13.Rows.Count
    End Sub

    Private Sub dgv13_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv13.CellContentClick
    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click
    End Sub

    Private Sub P13_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles P13.PrintPage
        Dim fontTitre As New Font("Arial", 12, FontStyle.Regular)
        Dim fontTColonne As New Font("Arial", 10, FontStyle.Bold)
        Dim fontColonne As New Font("Arial", 10, FontStyle.Regular)
        Dim ln As Integer = 80
        Dim cl As Integer = 50

        Dim imageToPrint As Image
        If System.IO.File.Exists("images/logo.png") Then
            imageToPrint = Image.FromFile("images/logo.png")
            e.Graphics.DrawImage(imageToPrint, 40, 40, 40, 40)
        End If

        e.Graphics.DrawString("Liste des documents", fontTitre, Brushes.Black, 90, 50)
        Dim ligne As New Pen(Color.Black)
        ln = ln + 30

        With e.Graphics
            .DrawString("ID", fontTColonne, Brushes.Black, cl, ln)
            .DrawString("Titre", fontTColonne, Brushes.Black, cl + 50, ln)
            .DrawString("Type", fontTColonne, Brushes.Black, cl + 250, ln)
            .DrawString("Date d'ajout", fontTColonne, Brushes.Black, cl + 400, ln)
        End With

        ln = ln + 30

        connexion()
        Dim cmd As New OleDbCommand("SELECT iddocument, titre, typedocument, dateajout FROM documents", con)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim id As String = reader("iddocument").ToString()
            Dim titre As String = ""
            Dim type As String = ""
            Dim date_ajout As String = ""

            If Not reader.IsDBNull(1) Then
                titre = reader("titre").ToString()
            End If

            If Not reader.IsDBNull(2) Then
                type = reader("typedocument").ToString()
            End If

            If Not reader.IsDBNull(3) Then
                date_ajout = CDate(reader("dateajout")).ToString("dd/MM/yyyy")
            End If

            With e.Graphics
                .DrawString(id, fontColonne, Brushes.Black, cl, ln)
                .DrawString(titre, fontColonne, Brushes.Black, cl + 50, ln)
                .DrawString(type, fontColonne, Brushes.Black, cl + 250, ln)
                .DrawString(date_ajout, fontColonne, Brushes.Black, cl + 400, ln)
            End With

            ln = ln + 30
        End While

        reader.Close()
        con.Close()
        e.Graphics.DrawString("Association | Liste des documents", fontTitre, Brushes.Black, cl, 1100)
    End Sub

    Private Sub ToolStripDropDownButton131_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton131.Click
    End Sub

    Private Sub d13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d13.Load
    End Sub
End Class
