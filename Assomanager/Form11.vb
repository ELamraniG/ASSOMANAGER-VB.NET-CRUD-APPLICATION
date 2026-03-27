Imports System.Data.OleDb
Public Class Form11

    Private nombredeventements As Integer = 0
    Private WithEvents DataGridView11 As New DataGridView

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

    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Width = 1560
        Me.Height = 780
        Me.CenterToScreen()
        dgv11.Width = Me.Width - 50
        dgv11.Height = Me.Height - 120
        Me.Text = "Gestion des événements"

        dgv11.BorderStyle = BorderStyle.None
        dgv11.DefaultCellStyle.Font = New Font("Arial", 10)
        dgv11.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv11.ColumnHeadersDefaultCellStyle.BackColor = Color.Beige
        dgv11.EnableHeadersVisualStyles = False
        dgv11.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        dgv11.CellBorderStyle = DataGridViewCellBorderStyle.None


        afficher_evenements()

        nombredeventements = dgv11.Rows.Count
        If nombredeventements = 0 Then
            nombredeventements = 1
        End If

        Controls.Add(DataGridView11)
        DataGridView11.Visible = False


        AddHandler ToolStripButton112.Click, AddressOf ToolStripButton112_Click
        AddHandler ToolStripButton113.Click, AddressOf ToolStripButton113_Click
        AddHandler ToolStripButton114.Click, AddressOf ToolStripButton114_Click
        AddHandler dgv11.CellDoubleClick, AddressOf dgv11_CellDoubleClick
    End Sub


    Public Sub afficher_evenements()
        Try
            connexion()

            requete = "SELECT idevenement, titre, description, datedebut, datefin, lieu FROM evenements ORDER BY idevenement ASC"
            da = New OleDbDataAdapter(requete, con)
            ds = New DataSet()
            da.Fill(ds, "evenements")
            dgv11.DataSource = ds.Tables("evenements")


            If dgv11.Columns.Count >= 6 Then
                dgv11.Columns(0).HeaderText = "ID"
                dgv11.Columns(0).Width = 32
                dgv11.Columns(1).HeaderText = "Titre"
                dgv11.Columns(1).Width = 105
                dgv11.Columns(2).HeaderText = "Description"
                dgv11.Columns(2).Width = 160
                dgv11.Columns(3).HeaderText = "Date Début"
                dgv11.Columns(3).Width = 100
                dgv11.Columns(4).HeaderText = "Date Fin"
                dgv11.Columns(4).Width = 100
                dgv11.Columns(5).HeaderText = "Lieu"
                dgv11.Columns(5).Width = 243
            End If

            con.Close()


            Dim nombre As Integer = dgv11.Rows.Count
            Label11.Text = "Nombre d'événements : " + nombre.ToString
            Label11.Left = Me.Width - Label11.Width - 50

        Catch ex As Exception
            MsgBox("Erreur lors du chargement des événements: " & ex.Message, vbExclamation, "Erreur")
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub


    Public Sub afficher_entity11()

    End Sub

    Private Sub ToolStripButton111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim frm As New Form12()
        frm.IsEditMode = False
        frm.ParametreId = ""
        frm.ParametreCle = ""
        frm.ShowDialog()


        afficher_evenements()
    End Sub

    Private Sub dgv11_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim i As Integer
        i = dgv11.CurrentCell.RowIndex

        If i < 0 OrElse i >= dgv11.Rows.Count Then
            Return
        End If

        Dim frm As New Form12()
        frm.IsEditMode = True


        frm.ParametreId = dgv11.Rows(i).Cells(0).Value.ToString()

        If dgv11.Rows(i).Cells(1).Value IsNot Nothing Then
            frm.ParametreCle = dgv11.Rows(i).Cells(1).Value.ToString()
        Else
            frm.ParametreCle = ""
        End If

        If dgv11.Rows(i).Cells(2).Value IsNot Nothing Then
            frm.TypeDescription = dgv11.Rows(i).Cells(2).Value.ToString()
        End If

        If dgv11.Rows(i).Cells(3).Value IsNot Nothing Then
            frm.DateDebut = CDate(dgv11.Rows(i).Cells(3).Value)
        End If

        If dgv11.Rows(i).Cells(4).Value IsNot Nothing Then
            frm.DateFin = CDate(dgv11.Rows(i).Cells(4).Value)
        End If

        If dgv11.Rows(i).Cells(5).Value IsNot Nothing Then
            frm.Lieu = dgv11.Rows(i).Cells(5).Value.ToString()
        End If

        frm.ShowDialog()


        afficher_evenements()
    End Sub

    Private Sub ToolStripButton112_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (dgv11.Rows.Count = 0) Then
            MsgBox("Aucun événement disponible...", vbExclamation, "Message")
        Else
            Dim rep As MsgBoxResult
            rep = MsgBox("Êtes-vous sûr de vouloir supprimer cet événement ?", vbQuestion + vbYesNo, "Message")
            If (rep = vbYes) Then
                connexion()
                Dim i As Integer
                i = dgv11.CurrentCell.RowIndex
                Dim id As Integer
                If Integer.TryParse(dgv11.Rows(i).Cells(0).Value.ToString(), id) Then
                    requete = "DELETE FROM evenements WHERE idevenement = " & id
                    cmdsql()
                    cmd.ExecuteNonQuery()
                    MsgBox("Événement supprimé avec succès", vbInformation)
                Else
                    MsgBox("ID de l'événement invalide", vbExclamation)
                End If
                con.Close()
                afficher_evenements()
            End If
        End If
    End Sub

    Private Sub ToolStripButton113_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        afficher_evenements()
    End Sub

    Private Sub ToolStripButton114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim titreachercher As String
        titreachercher = InputBox("Entrez le titre de l'événement à chercher", "Rechercher par titre", "")
        If String.IsNullOrEmpty(titreachercher) Then Return


        requete = "SELECT * FROM evenements WHERE titre LIKE '%" & titreachercher & "%' ORDER BY idevenement ASC"
        connexion()
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgv11.DataSource = dt.DefaultView

        If (dgv11.Rows.Count = 0) Then
            MsgBox("Cet événement est introuvable.", vbExclamation, "Message")
        End If
        con.Close()
    End Sub

    Private Sub ImprimerTousLesServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
        DirectCast(d11, Form).WindowState = FormWindowState.Maximized
        P11.DefaultPageSettings.Landscape = False
        d11.ShowDialog()
    End Sub

    Private Sub DataGridView11_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView11.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim categorieId As String = DataGridView11.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim nomCategorie As String = ""

            If DataGridView11.Rows(e.RowIndex).Cells(1).Value IsNot Nothing Then
                nomCategorie = DataGridView11.Rows(e.RowIndex).Cells(1).Value.ToString()
            End If

            Dim frm As New Form12()
            frm.ParametreId = categorieId
            frm.ParametreCle = nomCategorie
            frm.ShowDialog()
        End If
    End Sub

    Public Sub refreshdatagridviewentity11()
        DataGridView11.DataSource = Nothing
        DataGridView11.Rows.Clear()

        Dim mysql As String = "SELECT * FROM categoriedepenses ORDER BY idcategoriedepense"

        connexion()
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(mysql, con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView11.DataSource = dt.DefaultView
        con.Close()

        nombredeventements = DataGridView11.Rows.Count
    End Sub

    Private Sub dgv11_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv11.CellContentClick
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
    End Sub

    Private Sub P11_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles P11.PrintPage
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

        e.Graphics.DrawString("Liste des catégories de dépenses", fontTitre, Brushes.Black, 90, 50)
        Dim ligne As New Pen(Color.Black)
        ln = ln + 30

        With e.Graphics
            .DrawString("ID", fontTColonne, Brushes.Black, cl, ln)
            .DrawString("Nom", fontTColonne, Brushes.Black, cl + 150, ln)
        End With

        ln = ln + 30

        connexion()
        Dim cmd As New OleDbCommand("SELECT idcategoriedepense, nomcategoriedepense FROM categoriedepenses", con)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim id As String = reader("idcategoriedepense").ToString()
            Dim nom As String = ""

            If Not reader.IsDBNull(1) Then
                nom = reader("nomcategoriedepense").ToString()
            End If

            With e.Graphics
                .DrawString(id, fontColonne, Brushes.Black, cl, ln)
                .DrawString(nom, fontTColonne, Brushes.Black, cl + 150, ln)
            End With

            ln = ln + 30
        End While

        reader.Close()
        con.Close()
        e.Graphics.DrawString("Entreprise | Liste des catégories de dépenses", fontTitre, Brushes.Black, cl, 1100)
    End Sub

    Private Sub ToolStripDropDownButton111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton111.Click
    End Sub

    Private Sub d11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d11.Load
    End Sub

    Private Sub ToolStripButton111_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton111.Click

        Dim frm As New Form12()
        frm.IsEditMode = False
        frm.ParametreId = ""
        frm.ParametreCle = ""
        frm.ShowDialog()


        afficher_evenements()
    End Sub
End Class
