Imports System.Data.OleDb
Public Class Form5

    Private nombredeentity As Integer = 0
    Private WithEvents DataGridView5 As New DataGridView

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

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 1200
        Me.Height = 600
        Me.CenterToScreen()
        dgv3.Width = Me.Width - 50
        dgv3.Height = Me.Height - 120

        dgv3.BorderStyle = BorderStyle.None
        dgv3.DefaultCellStyle.Font = New Font("Arial", 10)
        dgv3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv3.ColumnHeadersDefaultCellStyle.BackColor = Color.Beige
        dgv3.EnableHeadersVisualStyles = False
        dgv3.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        dgv3.CellBorderStyle = DataGridViewCellBorderStyle.None
        afficher_entity()

        nombredeentity = dgv3.Rows.Count
        If nombredeentity = 0 Then
            nombredeentity = 1
        End If

        Controls.Add(DataGridView5)
        DataGridView5.Visible = False

        AddHandler ToolStripButton11.Click, AddressOf ToolStripButton11_Click
        AddHandler ToolStripButton22.Click, AddressOf ToolStripButton22_Click
        AddHandler ToolStripButton33.Click, AddressOf ToolStripButton33_Click
        AddHandler ToolStripButton44.Click, AddressOf ToolStripButton44_Click
        AddHandler dgv3.CellDoubleClick, AddressOf dgv_CellDoubleClick
    End Sub

    Public Sub afficher_entity()
        connexion()
        requete = "select * from parametres"
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgv3.DataSource = dt.DefaultView
        con.Close()

        Dim nombre As Integer
        nombre = dgv3.Rows.Count
        Label3.Text = "Nombre de paramètres : " + nombre.ToString
        Label3.Left = Me.Width - Label3.Width - 50
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New Form6()
        frm.Button1.Text = "Ajouter"
        frm.ParametreCle = ""
        frm.ParametreValeur = ""
        frm.ParametreId = ""
        frm.ShowDialog()
    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim i As Integer
        i = dgv3.CurrentCell.RowIndex

        If i < 0 OrElse i >= dgv3.Rows.Count Then
            Return
        End If

        Dim frm As New Form6()
        frm.IsEditMode = True


        Dim paramId As String = dgv3.Rows(i).Cells(0).Value.ToString()
        frm.ParametreId = paramId

        If dgv3.Rows(i).Cells(1).Value IsNot Nothing Then
            frm.ParametreCle = dgv3.Rows(i).Cells(1).Value.ToString()
        Else
            frm.ParametreCle = ""
        End If

        If dgv3.Rows(i).Cells.Count > 2 AndAlso dgv3.Rows(i).Cells(2).Value IsNot Nothing Then
            frm.ParametreValeur = dgv3.Rows(i).Cells(2).Value.ToString()
        Else
            frm.ParametreValeur = ""
        End If

        frm.Button1.Text = "Modifier"

        frm.ShowDialog()
        afficher_entity()
    End Sub

    Private Sub ToolStripButton22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (dgv3.Rows.Count = 0) Then
            MsgBox("Aucun paramètre...", vbExclamation, "Message")
        Else
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de vouloir supprimer ce paramètre ?", vbQuestion + vbYesNo, "Message")
            If (rep = vbYes) Then
                connexion()
                Dim i As Integer
                i = dgv3.CurrentCell.RowIndex
                Dim id As Integer
                If Integer.TryParse(dgv3.Rows(i).Cells(0).Value.ToString(), id) Then
                    requete = "DELETE FROM parametres WHERE idparametre = " & id
                    cmdsql()
                    cmd.ExecuteNonQuery()
                    MsgBox("Paramètre supprimé avec succès", vbInformation)
                Else
                    MsgBox("ID du paramètre invalide", vbExclamation)
                End If
                con.Close()
                afficher_entity()
            End If
        End If
    End Sub

    Private Sub ToolStripButton33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        afficher_entity()
    End Sub

    Private Sub ToolStripButton44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nomachercher As String
        nomachercher = InputBox("Entrez la clé à chercher", "Rechercher par clé", "")
        If String.IsNullOrEmpty(nomachercher) Then Return

        requete = "SELECT * FROM parametres WHERE cle LIKE '%" & nomachercher & "%'"
        connexion()
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgv3.DataSource = dt.DefaultView

        If (dgv3.Rows.Count = 0) Then
            MsgBox("Ce paramètre est introuvable.", vbExclamation, "Message")
        End If
        con.Close()
    End Sub

    Private Sub ImprimerTousLesServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
        DirectCast(d3, Form).WindowState = FormWindowState.Maximized
        P3.DefaultPageSettings.Landscape = False
        d3.ShowDialog()
    End Sub

    Private Sub DataGridView5_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView5.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim paramId As String = DataGridView5.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim cleParam As String = DataGridView5.Rows(e.RowIndex).Cells(1).Value.ToString()
            Dim valeurParam As String = ""

            If DataGridView5.Rows(e.RowIndex).Cells.Count > 2 AndAlso
               DataGridView5.Rows(e.RowIndex).Cells(2).Value IsNot Nothing Then
                valeurParam = DataGridView5.Rows(e.RowIndex).Cells(2).Value.ToString()
            End If

            Dim frm As New Form6()
            frm.ParametreId = paramId
            frm.ParametreCle = cleParam
            frm.ParametreValeur = valeurParam
            frm.ShowDialog()
        End If
    End Sub

    Public Sub refreshdatagridviewentity()
        DataGridView5.DataSource = Nothing
        DataGridView5.Rows.Clear()

        Dim mysql As String = "SELECT * FROM parametres ORDER BY idparametre"

        connexion()
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(mysql, con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView5.DataSource = dt.DefaultView
        con.Close()

        nombredeentity = DataGridView5.Rows.Count
    End Sub

    Private Sub dgv3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv3.CellContentClick
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
    End Sub

    Private Sub P3_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles P3.PrintPage
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

        e.Graphics.DrawString("Liste des paramètres", fontTitre, Brushes.Black, 90, 50)
        Dim ligne As New Pen(Color.Black)
        ln = ln + 30

        With e.Graphics
            .DrawString("ID", fontTColonne, Brushes.Black, cl, ln)
            .DrawString("Clé", fontTColonne, Brushes.Black, cl + 150, ln)
            .DrawString("Valeur", fontTColonne, Brushes.Black, cl + 350, ln)
        End With

        ln = ln + 30

        connexion()
        Dim cmd As New OleDbCommand("SELECT idparametre, cle, valeur FROM parametres", con)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim id As String = reader("idparametre").ToString()
            Dim cle As String = reader("cle").ToString()
            Dim valeur As String = ""

            If Not reader.IsDBNull(2) Then
                valeur = reader("valeur").ToString()
            End If

            With e.Graphics
                .DrawString(id, fontColonne, Brushes.Black, cl, ln)
                .DrawString(cle, fontTColonne, Brushes.Black, cl + 150, ln)
                .DrawString(valeur, fontColonne, Brushes.Black, cl + 350, ln)
            End With

            ln = ln + 30
        End While

        reader.Close()
        con.Close()
        e.Graphics.DrawString("Entreprise | Liste des paramètres", fontTitre, Brushes.Black, cl, 1100)
    End Sub

    Private Sub ToolStripDropDownButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton1.Click
    End Sub

    Private Sub d3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d3.Load
    End Sub

    Private Sub ToolStripButton11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click

    End Sub
End Class
