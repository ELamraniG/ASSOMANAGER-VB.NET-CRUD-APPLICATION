Imports System.Data.OleDb

Public Class Form4
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Dim requete As String

    Private Sub connexion()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AssoManager.accdb")
        con.Open()
    End Sub

    Private Sub cmdsql()
        cmd = New OleDbCommand(requete, con)
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If TextBox1 Is Nothing Then
            TextBox1 = New TextBox()
            TextBox1.Font = New Font("Microsoft Sans Serif", 12, FontStyle.Regular)
            TextBox1.Size = New Size(201, 30)
            TextBox1.Location = New Point(188, 19)
            Me.Controls.Add(TextBox1)
        End If


            ancienidtypeassociation.Visible = False
            TextBox1.Enabled = False
        TextBox4.Multiline = True
        TextBox4.ScrollBars = ScrollBars.Vertical
    End Sub

    Private Sub enregistrer2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enregistrer2.Click
        If TextBox0.Text.Trim() = "" Then
            MsgBox("Veuillez entrer un nom pour le type d'association", vbExclamation, "Données manquantes")
            Return
        End If


        If enregistrer2.Text = "Ajouter" Then
            requete = "INSERT INTO typeassociation (type, description) VALUES ('" & TextBox0.Text & "', '" & TextBox4.Text & "')"
            MsgBox("kkkk")
        Else
            requete = "UPDATE typeassociation SET type = '" & TextBox0.Text & "', description = '" & TextBox4.Text & "' WHERE idtypeassociation = " & ancienidtypeassociation.Text
        End If

        connexion()
        cmdsql()
        cmd.ExecuteNonQuery()

        con.Close()


        Dim f3 As Form3 = CType(Application.OpenForms("Form3"), Form3)
        If f3 IsNot Nothing Then
            f3.afficher_typeassociation()
        End If

        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
    End Sub
End Class
