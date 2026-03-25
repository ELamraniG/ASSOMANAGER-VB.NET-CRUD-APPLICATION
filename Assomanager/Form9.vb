Imports System.Data.OleDb
Public Class Form9

    Private nombredeentity As Integer = 0
    Private WithEvents DataGridView9 As New DataGridView

    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim requete As String

    Private Sub connexion()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AssoManager.accdb")
        con.Open()
    End Sub

    Private Sub cmdsql()
        cmd = New OleDbCommand(requete, con)
    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 1200
        Me.Height = 600
        Me.CenterToScreen()
        dgv8.Width = Me.Width - 50
        dgv8.Height = Me.Height - 120
        Me.Text = "Gestion des catégories de dépenses"

        dgv8.BorderStyle = BorderStyle.None
        dgv8.DefaultCellStyle.Font = New Font("Arial", 10)
        dgv8.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv8.ColumnHeadersDefaultCellStyle.BackColor = Color.Beige
        dgv8.EnableHeadersVisualStyles = False
        dgv8.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        dgv8.CellBorderStyle = DataGridViewCellBorderStyle.None
        afficher_entity()

        nombredeentity = dgv8.Rows.Count
        If nombredeentity = 0 Then
            nombredeentity = 1
        End If

        Controls.Add(DataGridView9)
        DataGridView9.Visible = False

        AddHandler ToolStripButton15.Click, AddressOf ToolStripButton15_Click
        AddHandler ToolStripButton16.Click, AddressOf ToolStripButton16_Click
        AddHandler ToolStripButton17.Click, AddressOf ToolStripButton17_Click
        AddHandler ToolStripButton18.Click, AddressOf ToolStripButton18_Click
        AddHandler dgv8.CellDoubleClick, AddressOf dgv_CellDoubleClick
    End Sub

    Public Sub afficher_entity()
        connexion()
        requete = "select * from categoriedepenses"
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgv8.DataSource = dt.DefaultView
        con.Close()

        Dim nombre As Integer
        nombre = dgv8.Rows.Count
        Label8.Text = "Nombre de catégories : " + nombre.ToString
        Label8.Left = Me.Width - Label8.Width - 50
    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New Form10()
        frm.Button10.Text = "Ajouter"
        frm.ParametreId = ""
        frm.ParametreCle = ""
        frm.ShowDialog()
    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim i As Integer
        i = dgv8.CurrentCell.RowIndex

        If i < 0 OrElse i >= dgv8.Rows.Count Then
            Return
        End If

        Dim frm As New Form10()
        frm.IsEditMode = True


        Dim categorieId As String = dgv8.Rows(i).Cells(0).Value.ToString()
        frm.ParametreId = categorieId

        If dgv8.Rows(i).Cells(1).Value IsNot Nothing Then
            frm.ParametreCle = dgv8.Rows(i).Cells(1).Value.ToString()
        Else
            frm.ParametreCle = ""
        End If

        frm.Button10.Text = "Modifier"

        frm.ShowDialog()
        afficher_entity()
    End Sub

    Private Sub ToolStripButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (dgv8.Rows.Count = 0) Then
            MsgBox("Aucune catégorie de dépense...", vbExclamation, "Message")
        Else
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de vouloir supprimer cette catégorie de dépense ?", vbQuestion + vbYesNo, "Message")
            If (rep = vbYes) Then
                connexion()
                Dim i As Integer
                i = dgv8.CurrentCell.RowIndex
                Dim id As Integer
                If Integer.TryParse(dgv8.Rows(i).Cells(0).Value.ToString(), id) Then
                    requete = "DELETE FROM categoriedepenses WHERE idcategoriedepense = " & id
                    cmdsql()
                    cmd.ExecuteNonQuery()
                    MsgBox("Catégorie de dépense supprimée avec succès", vbInformation)
                Else
                    MsgBox("ID de la catégorie de dépense invalide", vbExclamation)
                End If
                con.Close()
                afficher_entity()
            End If
        End If
    End Sub

    Private Sub ToolStripButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        afficher_entity()
    End Sub

    Private Sub ToolStripButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nomachercher As String
        nomachercher = InputBox("Entrez le nom de la catégorie de dépense à chercher", "Rechercher par nom", "")
        If String.IsNullOrEmpty(nomachercher) Then Return

        requete = "SELECT * FROM categoriedepenses WHERE nomcategoriedepense LIKE '%" & nomachercher & "%'"
        connexion()
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgv8.DataSource = dt.DefaultView

        If (dgv8.Rows.Count = 0) Then
            MsgBox("Cette catégorie de dépense est introuvable.", vbExclamation, "Message")
        End If
        con.Close()
    End Sub

    Private Sub ImprimerTousLesServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
        DirectCast(d8, Form).WindowState = FormWindowState.Maximized
        P8.DefaultPageSettings.Landscape = False
        d8.ShowDialog()
    End Sub

    Private Sub DataGridView9_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView9.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim categorieId As String = DataGridView9.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim nomCategorie As String = ""

            If DataGridView9.Rows(e.RowIndex).Cells(1).Value IsNot Nothing Then
                nomCategorie = DataGridView9.Rows(e.RowIndex).Cells(1).Value.ToString()
            End If

            Dim frm As New Form10()
            frm.ParametreId = categorieId
            frm.ParametreCle = nomCategorie
            frm.ShowDialog()
        End If
    End Sub

    Public Sub refreshdatagridviewentity()
        DataGridView9.DataSource = Nothing
        DataGridView9.Rows.Clear()

        Dim mysql As String = "SELECT * FROM categoriedepenses ORDER BY idcategoriedepense"

        connexion()
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(mysql, con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView9.DataSource = dt.DefaultView
        con.Close()

        nombredeentity = DataGridView9.Rows.Count
    End Sub

    Private Sub dgv8_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv8.CellContentClick
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
    End Sub

    Private Sub P8_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles P8.PrintPage
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

    Private Sub ToolStripDropDownButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton19.Click
    End Sub

    Private Sub d8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d8.Load
    End Sub

    Private Sub ToolStripButton15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton15.Click
    End Sub
End Class
