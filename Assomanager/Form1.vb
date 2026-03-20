Imports System.Data.OleDb
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 1200
        Me.Height = 600
        Me.CenterToScreen()
        dgv.Width = Me.Width - 50
        dgv.Height = Me.Height - 120


        dgv.BorderStyle = BorderStyle.None
        dgv.DefaultCellStyle.Font = New Font("Arial", 10)
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Beige
        dgv.EnableHeadersVisualStyles = False
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.None
        afficher_service()
    End Sub
    Public Sub afficher_service()
        connexion()
        requete = "select * from roles"
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgv.DataSource = dt.DefaultView
        con.Close()


        Dim nombre As Integer
        nombre = dgv.Rows.Count
        nombredeservice.Text = "Nombre de role : " + nombre.ToString
        nombredeservice.Left = Me.Width - nombredeservice.Width - 50
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Form2.enregistrer.Text = "Ajouter"
        Form2.ShowDialog()
    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        Dim i As Integer
        i = dgv.CurrentCell.RowIndex
        Form2.TextBox1.Text = dgv.Rows(i).Cells(0).Value
        Form2.ancienidservice.Text = dgv.Rows(i).Cells(0).Value
        Form2.TextBox2.Text = dgv.Rows(i).Cells(1).Value
        Form2.enregistrer.Text = "Modifier"
        Form2.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If (dgv.Rows.Count = 0) Then
            MsgBox("Aucun role...", vbExclamation, "Message")
        Else
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de vouloir supprimer ce role ?", vbQuestion + vbYesNo, "Message")
            If (rep = vbYes) Then
                connexion()
                Dim i As Integer
                i = dgv.CurrentCell.RowIndex
                Dim id As String
                id = dgv.Rows(i).Cells(0).Value
                requete = "delete from roles where idrole = '" + id + "'"
                cmdsql()
                cmd.ExecuteNonQuery()
                con.Close()
                afficher_service()
            End If
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        afficher_service()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Dim nomachercher As String
        nomachercher = InputBox("Entrez le nom à chercher ", "Rechercher par le nom", "")
        requete = "select * from roles where nomrole like '%" + nomachercher + "%'"
        connexion()
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        da.Fill(dt)
        dgv.DataSource = dt.DefaultView
        con.Close()
        If (dgv.Rows.Count = 0) Then
            MsgBox("Ce nom de role est introuvable.", vbExclamation, "Message")
        End If

    End Sub

    Private Sub ImprimerTousLesServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
        DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
        PrintDocument1.DefaultPageSettings.Landscape = False
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontTitre As New Font("Arial", 12, FontStyle.Regular)
        Dim fontTColonne As New Font("Arial", 10, FontStyle.Bold)
        Dim fontColonne As New Font("Arial", 10, FontStyle.Regular)
        Dim ln As Integer = 80
        Dim cl As Integer = 50


        Try
            If System.IO.File.Exists("images/logo.png") Then
                Dim imageToPrint As Image = Image.FromFile("images/logo.png")
                e.Graphics.DrawImage(imageToPrint, 40, 40, 40, 40)
            End If
        Catch ex As Exception

        End Try

        e.Graphics.DrawString("Liste des roles", fontTitre, Brushes.Black, 90, 50)
        Dim ligne As New Pen(Color.Black)
        ln = ln + 30

        With e.Graphics
            .DrawString("Id Role", fontTColonne, Brushes.Black, cl, ln)
            .DrawString("Nom", fontTColonne, Brushes.Black, cl + 150, ln)
        End With
        ln = ln + 30

        Dim c1, c2 As String
        For i = 0 To dgv.Rows.Count - 1
            c1 = dgv.Rows(i).Cells(0).Value.ToString()
            c2 = dgv.Rows(i).Cells(1).Value.ToString()
            With e.Graphics
                .DrawString(c1, fontColonne, Brushes.Black, cl, ln)
                .DrawString(c2, fontTColonne, Brushes.Black, cl + 150, ln)
            End With
            ln = ln + 30
        Next
        e.Graphics.DrawString("Entreprise | Liste des roles", fontTitre, Brushes.Black, cl, 1100)
    End Sub

    Private Sub PrintPreviewDialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewDialog1.Load

    End Sub
End Class
