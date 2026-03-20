Imports System.Data.OleDb
Public Class Form3

    Private nombredetypeassociation As Integer = 0
    Private WithEvents DataGridView3 As New DataGridView

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

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 1200
        Me.Height = 600
        Me.CenterToScreen()
        dgv2.Width = Me.Width - 50
        dgv2.Height = Me.Height - 120

        dgv2.BorderStyle = BorderStyle.None
        dgv2.DefaultCellStyle.Font = New Font("Arial", 10)
        dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv2.ColumnHeadersDefaultCellStyle.BackColor = Color.Beige
        dgv2.EnableHeadersVisualStyles = False
        dgv2.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        dgv2.CellBorderStyle = DataGridViewCellBorderStyle.None
        afficher_typeassociation()

        nombredetypeassociation = dgv2.Rows.Count
        If nombredetypeassociation = 0 Then
            nombredetypeassociation = 1
        End If

        Controls.Add(DataGridView3)
        DataGridView3.Visible = False

        AddHandler ToolStripButton1.Click, AddressOf ToolStripButton1_Click
        AddHandler ToolStripButton2.Click, AddressOf ToolStripButton2_Click
        AddHandler ToolStripButton3.Click, AddressOf ToolStripButton3_Click
        AddHandler ToolStripButton4.Click, AddressOf ToolStripButton4_Click

        AddHandler dgv2.CellDoubleClick, AddressOf dgv_CellDoubleClick
    End Sub

    Public Sub afficher_typeassociation()
        connexion()
        requete = "select * from typeassociation"
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgv2.DataSource = dt.DefaultView
        con.Close()

        Dim nombre As Integer
        nombre = dgv2.Rows.Count
        Label2.Text = "Nombre de types d'association : " + nombre.ToString
        Label2.Left = Me.Width - Label2.Width - 50
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New Form4()
        frm.enregistrer2.Text = "Ajouter"
        frm.TextBox4.Text = ""
        frm.TextBox0.Text = ""
        frm.ShowDialog()
    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim i As Integer
        i = dgv2.CurrentCell.RowIndex

        If i < 0 OrElse i >= dgv2.Rows.Count Then
            Return
        End If

        Dim frm As New Form4()

        Dim typeId As String = dgv2.Rows(i).Cells(0).Value.ToString()
        frm.ancienidtypeassociation.Text = typeId

        If dgv2.Rows(i).Cells(1).Value IsNot Nothing Then
            frm.TextBox0.Text = dgv2.Rows(i).Cells(1).Value.ToString()
        Else
            frm.TextBox0.Text = ""
        End If

        If dgv2.Rows(i).Cells.Count > 2 AndAlso dgv2.Rows(i).Cells(2).Value IsNot Nothing Then
            frm.TextBox4.Text = dgv2.Rows(i).Cells(2).Value.ToString()
        Else
            frm.TextBox4.Text = ""
        End If

        frm.enregistrer2.Text = "Modifier"

        frm.ShowDialog()
        afficher_typeassociation()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (dgv2.Rows.Count = 0) Then
            MsgBox("Aucun type d'association...", vbExclamation, "Message")
        Else
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de vouloir supprimer ce type d'association ?", vbQuestion + vbYesNo, "Message")
            If (rep = vbYes) Then
                connexion()
                Dim i As Integer
                i = dgv2.CurrentCell.RowIndex
                Dim id As Integer
                If Integer.TryParse(dgv2.Rows(i).Cells(0).Value.ToString(), id) Then
                    requete = "delete from typeassociation where idtypeassociation = " & id
                    cmdsql()
                    cmd.ExecuteNonQuery()
                    MsgBox("Type d'association supprimé avec succès", vbInformation)
                Else
                    MsgBox("ID du type d'association invalide", vbExclamation)
                End If
                con.Close()
                afficher_typeassociation()
            End If
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        afficher_typeassociation()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nomachercher As String
        nomachercher = InputBox("Entrez le nom à chercher ", "Rechercher par le nom", "")
        If String.IsNullOrEmpty(nomachercher) Then Return

        requete = "select * from typeassociation where type like '%" & nomachercher & "%'"
        connexion()
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgv2.DataSource = dt.DefaultView

        If (dgv2.Rows.Count = 0) Then
            MsgBox("Ce type d'association est introuvable.", vbExclamation, "Message")
        End If
        con.Close()
    End Sub

    Private Sub ImprimerTousLesTypesAssociationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
        DirectCast(d2, Form).WindowState = FormWindowState.Maximized
        P2.DefaultPageSettings.Landscape = False
        d2.ShowDialog()
    End Sub

    Private Sub DataGridView3_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim idtypeasso As String = DataGridView3.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim nomtypeasso As String = DataGridView3.Rows(e.RowIndex).Cells(1).Value.ToString()

            Dim frm As New Form4()
            frm.TextBox1.Text = idtypeasso
            frm.TextBox0.Text = nomtypeasso
            frm.ancienidtypeassociation.Text = idtypeasso
            frm.enregistrer2.Text = "Ajouter"
            frm.ShowDialog()
        End If
    End Sub

    Public Sub refreshdatagridviewtypeassociation()
        DataGridView3.DataSource = Nothing
        DataGridView3.Rows.Clear()

        Dim mysql As String = "SELECT * FROM typeassociation ORDER BY idtypeassociation"

        connexion()
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(mysql, con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView3.DataSource = dt.DefaultView
        con.Close()

        nombredetypeassociation = DataGridView3.Rows.Count
    End Sub

    Private Sub dgv_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv2.CellContentClick
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
    End Sub

    Private Sub PrintDocument2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles P2.PrintPage
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

        e.Graphics.DrawString("Liste des types d'association", fontTitre, Brushes.Black, 90, 50)
        Dim ligne As New Pen(Color.Black)
        ln = ln + 30

        With e.Graphics
            .DrawString("Id Type", fontTColonne, Brushes.Black, cl, ln)
            .DrawString("Type d'association", fontTColonne, Brushes.Black, cl + 150, ln)
            .DrawString("Description", fontTColonne, Brushes.Black, cl + 350, ln)
        End With

        ln = ln + 30

        connexion()
        Dim cmd As New OleDbCommand("SELECT idtypeassociation, type, description FROM typeassociation", con)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim id As String = reader("idtypeassociation").ToString()
            Dim typeName As String = reader("type").ToString()
            Dim description As String = ""

            If Not reader.IsDBNull(2) Then
                description = reader("description").ToString()
            End If

            With e.Graphics
                .DrawString(id, fontColonne, Brushes.Black, cl, ln)
                .DrawString(typeName, fontTColonne, Brushes.Black, cl + 150, ln)
                .DrawString(description, fontColonne, Brushes.Black, cl + 350, ln)
            End With

            ln = ln + 30
        End While

        reader.Close()
        con.Close()

        e.Graphics.DrawString("Entreprise | Liste des types d'association", fontTitre, Brushes.Black, cl, 1100)
    End Sub

    Private Sub ToolStripDropDownButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDropDownButton1.Click
    End Sub

    Private Sub d2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d2.Load
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

    End Sub
End Class
