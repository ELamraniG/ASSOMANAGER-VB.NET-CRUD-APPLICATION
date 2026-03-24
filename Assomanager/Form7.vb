Imports System.Data.OleDb
Public Class Form7

    Private nombredeentity As Integer = 0
    Private WithEvents DataGridView7 As New DataGridView


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

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 1200
        Me.Height = 600
        Me.CenterToScreen()
        dgv7.Width = Me.Width - 50
        dgv7.Height = Me.Height - 120
        Me.Text = "Gestion des catégories de membres"

        dgv7.BorderStyle = BorderStyle.None
        dgv7.DefaultCellStyle.Font = New Font("Arial", 10)
        dgv7.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv7.ColumnHeadersDefaultCellStyle.BackColor = Color.Beige
        dgv7.EnableHeadersVisualStyles = False
        dgv7.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        dgv7.CellBorderStyle = DataGridViewCellBorderStyle.None
        afficher_entity()

        nombredeentity = dgv7.Rows.Count
        If nombredeentity = 0 Then
            nombredeentity = 1
        End If

        Controls.Add(DataGridView7)
        DataGridView7.Visible = False


        AddHandler ToolStripButton7.Click, AddressOf ToolStripButton7_Click
        AddHandler ToolStripButton77.Click, AddressOf ToolStripButton77_Click
        AddHandler ToolStripButton777.Click, AddressOf ToolStripButton777_Click
        AddHandler ToolStripButton7777.Click, AddressOf ToolStripButton7777_Click
        AddHandler dgv7.CellDoubleClick, AddressOf dgv_CellDoubleClick
    End Sub

    Public Sub afficher_entity()
        connexion()
        requete = "select * from categoriemembre"
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgv7.DataSource = dt.DefaultView
        con.Close()

        Dim nombre As Integer
        nombre = dgv7.Rows.Count
        Label7.Text = "Nombre de catégories : " + nombre.ToString
        Label7.Left = Me.Width - Label7.Width - 50
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New Form8()
        frm.Button8.Text = "Ajouter"
        frm.ParametreId = ""
        frm.ParametreCle = ""
        frm.ShowDialog()
    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim i As Integer
        i = dgv7.CurrentCell.RowIndex

        If i < 0 OrElse i >= dgv7.Rows.Count Then
            Return
        End If

        Dim frm As New Form8()
        frm.IsEditMode = True


        Dim categorieId As String = dgv7.Rows(i).Cells(0).Value.ToString()
        frm.ParametreId = categorieId

        If dgv7.Rows(i).Cells(1).Value IsNot Nothing Then
            frm.ParametreCle = dgv7.Rows(i).Cells(1).Value.ToString()
        Else
            frm.ParametreCle = ""
        End If

        frm.Button8.Text = "Modifier"

        frm.ShowDialog()
        afficher_entity()
    End Sub

    Private Sub ToolStripButton77_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (dgv7.Rows.Count = 0) Then
            MsgBox("Aucune catégorie...", vbExclamation, "Message")
        Else
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de vouloir supprimer cette catégorie ?", vbQuestion + vbYesNo, "Message")
            If (rep = vbYes) Then
                connexion()
                Dim i As Integer
                i = dgv7.CurrentCell.RowIndex
                Dim id As Integer
                If Integer.TryParse(dgv7.Rows(i).Cells(0).Value.ToString(), id) Then
                    requete = "DELETE FROM categoriemembre WHERE idcategoriemembre = " & id
                    cmdsql()
                    cmd.ExecuteNonQuery()
                    MsgBox("Catégorie supprimée avec succès", vbInformation)
                Else
                    MsgBox("ID de la catégorie invalide", vbExclamation)
                End If
                con.Close()
                afficher_entity()
            End If
        End If
    End Sub

    Private Sub ToolStripButton777_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        afficher_entity()
    End Sub

    Private Sub ToolStripButton7777_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nomachercher As String
        nomachercher = InputBox("Entrez le nom de la catégorie à chercher", "Rechercher par nom", "")
        If String.IsNullOrEmpty(nomachercher) Then Return

        requete = "SELECT * FROM categoriemembre WHERE nomcategoriemembre LIKE '%" & nomachercher & "%'"
        connexion()
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgv7.DataSource = dt.DefaultView

        If (dgv7.Rows.Count = 0) Then
            MsgBox("Cette catégorie est introuvable.", vbExclamation, "Message")
        End If
        con.Close()
    End Sub

    Private Sub ImprimerTousLesServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
        DirectCast(d7, Form).WindowState = FormWindowState.Maximized
        P7.DefaultPageSettings.Landscape = False
        d7.ShowDialog()
    End Sub


    Private Sub DataGridView7_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView7.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim categorieId As String = DataGridView7.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim nomCategorie As String = ""

            If DataGridView7.Rows(e.RowIndex).Cells(1).Value IsNot Nothing Then
                nomCategorie = DataGridView7.Rows(e.RowIndex).Cells(1).Value.ToString()
            End If

            Dim frm As New Form8()
            frm.ParametreId = categorieId
            frm.ParametreCle = nomCategorie
            frm.ShowDialog()
        End If
    End Sub

    Public Sub refreshdatagridviewentity()
        DataGridView7.DataSource = Nothing
        DataGridView7.Rows.Clear()

        Dim mysql As String = "SELECT * FROM categoriemembre ORDER BY idcategoriemembre"

        connexion()
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(mysql, con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView7.DataSource = dt.DefaultView
        con.Close()

        nombredeentity = DataGridView7.Rows.Count
    End Sub

    Private Sub dgv7_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv7.CellContentClick
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
    End Sub

    Private Sub P7_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles P7.PrintPage
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

        e.Graphics.DrawString("Liste des catégories de membres", fontTitre, Brushes.Black, 90, 50)
        Dim ligne As New Pen(Color.Black)
        ln = ln + 30

        With e.Graphics
            .DrawString("ID", fontTColonne, Brushes.Black, cl, ln)
            .DrawString("Nom", fontTColonne, Brushes.Black, cl + 150, ln)
        End With

        ln = ln + 30

        connexion()
        Dim cmd As New OleDbCommand("SELECT idcategoriemembre, nomcategoriemembre FROM categoriemembre", con)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim id As String = reader("idcategoriemembre").ToString()
            Dim nom As String = ""

            If Not reader.IsDBNull(1) Then
                nom = reader("nomcategoriemembre").ToString()
            End If

            With e.Graphics
                .DrawString(id, fontColonne, Brushes.Black, cl, ln)
                .DrawString(nom, fontTColonne, Brushes.Black, cl + 150, ln)
            End With

            ln = ln + 30
        End While

        reader.Close()
        con.Close()
        e.Graphics.DrawString("Entreprise | Liste des catégories de membres", fontTitre, Brushes.Black, cl, 1100)
    End Sub

    Private Sub ToolStripDropDownButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton7.Click
    End Sub

    Private Sub d7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d7.Load
    End Sub

    Private Sub ToolStripButton7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
    End Sub
End Class
