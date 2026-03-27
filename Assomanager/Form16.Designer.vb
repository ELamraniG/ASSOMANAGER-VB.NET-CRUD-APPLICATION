<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form16
    Inherits System.Windows.Forms.Form


    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    Private components As System.ComponentModel.IContainer


    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form16))
        Me.ligne_modifie = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.type_operation = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.motdepasse = New System.Windows.Forms.TextBox()
        Me.idrole = New System.Windows.Forms.ComboBox()
        Me.statut = New System.Windows.Forms.ComboBox()
        Me.datecreation = New System.Windows.Forms.DateTimePicker()
        Me.idutilisateur = New System.Windows.Forms.TextBox()
        Me.ancien_email = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()


        Me.ligne_modifie.AutoSize = True
        Me.ligne_modifie.Location = New System.Drawing.Point(273, 12)
        Me.ligne_modifie.Name = "ligne_modifie"
        Me.ligne_modifie.Size = New System.Drawing.Size(91, 17)
        Me.ligne_modifie.TabIndex = 30
        Me.ligne_modifie.Text = "ligne_modifie"
        Me.ligne_modifie.Visible = False


        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "actualiser.png")
        Me.ImageList1.Images.SetKeyName(1, "ajouter.png")
        Me.ImageList1.Images.SetKeyName(2, "imprimer.png")
        Me.ImageList1.Images.SetKeyName(3, "rechercher.png")
        Me.ImageList1.Images.SetKeyName(4, "save.png")
        Me.ImageList1.Images.SetKeyName(5, "supprimer.png")


        Me.type_operation.AutoSize = True
        Me.type_operation.Location = New System.Drawing.Point(370, 12)
        Me.type_operation.Name = "type_operation"
        Me.type_operation.Size = New System.Drawing.Size(103, 17)
        Me.type_operation.TabIndex = 29
        Me.type_operation.Text = "type_operation"
        Me.type_operation.Visible = False


        Me.Save.FlatAppearance.BorderSize = 0
        Me.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.ImageIndex = 4
        Me.Save.ImageList = Me.ImageList1
        Me.Save.Location = New System.Drawing.Point(59, 339)
        Me.Save.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(51, 37)
        Me.Save.TabIndex = 27
        Me.Save.UseVisualStyleBackColor = True


        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nom"


        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Email"


        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Mot de passe"


        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Rôle"


        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Statut"


        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(293, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 17)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Date création"


        Me.nom.Location = New System.Drawing.Point(59, 113)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(498, 22)
        Me.nom.TabIndex = 1


        Me.email.Location = New System.Drawing.Point(59, 163)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(498, 22)
        Me.email.TabIndex = 2


        Me.motdepasse.Location = New System.Drawing.Point(59, 213)
        Me.motdepasse.Name = "motdepasse"
        Me.motdepasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.motdepasse.Size = New System.Drawing.Size(498, 22)
        Me.motdepasse.TabIndex = 3


        Me.idrole.FormattingEnabled = True
        Me.idrole.Location = New System.Drawing.Point(59, 263)
        Me.idrole.Name = "idrole"
        Me.idrole.Size = New System.Drawing.Size(121, 24)
        Me.idrole.TabIndex = 4


        Me.statut.FormattingEnabled = True
        Me.statut.Items.AddRange(New Object() {"actif", "inactif"})
        Me.statut.Location = New System.Drawing.Point(59, 313)
        Me.statut.Name = "statut"
        Me.statut.Size = New System.Drawing.Size(121, 24)
        Me.statut.TabIndex = 5


        Me.datecreation.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datecreation.Location = New System.Drawing.Point(293, 313)
        Me.datecreation.Name = "datecreation"
        Me.datecreation.Size = New System.Drawing.Size(200, 22)
        Me.datecreation.TabIndex = 6


        Me.idutilisateur.Location = New System.Drawing.Point(59, 29)
        Me.idutilisateur.Name = "idutilisateur"
        Me.idutilisateur.Size = New System.Drawing.Size(100, 22)
        Me.idutilisateur.TabIndex = 43
        Me.idutilisateur.Visible = False


        Me.ancien_email.Location = New System.Drawing.Point(165, 29)
        Me.ancien_email.Name = "ancien_email"
        Me.ancien_email.Size = New System.Drawing.Size(100, 22)
        Me.ancien_email.TabIndex = 44
        Me.ancien_email.Visible = False


        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 400)
        Me.Controls.Add(Me.ancien_email)
        Me.Controls.Add(Me.idutilisateur)
        Me.Controls.Add(Me.datecreation)
        Me.Controls.Add(Me.statut)
        Me.Controls.Add(Me.idrole)
        Me.Controls.Add(Me.motdepasse)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ligne_modifie)
        Me.Controls.Add(Me.type_operation)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form16"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire Utilisateur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ligne_modifie As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents type_operation As System.Windows.Forms.Label
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nom As System.Windows.Forms.TextBox
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents motdepasse As System.Windows.Forms.TextBox
    Friend WithEvents idrole As System.Windows.Forms.ComboBox
    Friend WithEvents statut As System.Windows.Forms.ComboBox
    Friend WithEvents datecreation As System.Windows.Forms.DateTimePicker
    Friend WithEvents idutilisateur As System.Windows.Forms.TextBox
    Friend WithEvents ancien_email As System.Windows.Forms.TextBox
End Class
