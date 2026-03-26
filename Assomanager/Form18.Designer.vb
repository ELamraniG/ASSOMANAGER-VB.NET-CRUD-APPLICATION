<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form18
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form18))
        Me.ancien_email = New System.Windows.Forms.TextBox()
        Me.idmembre = New System.Windows.Forms.TextBox()
        Me.dateinscription = New System.Windows.Forms.DateTimePicker()
        Me.statut = New System.Windows.Forms.ComboBox()
        Me.idcategoriemembre = New System.Windows.Forms.ComboBox()
        Me.telephone = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.adresse = New System.Windows.Forms.TextBox()
        Me.prenom = New System.Windows.Forms.TextBox()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ligne_modifie = New System.Windows.Forms.Label()
        Me.type_operation = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()


        Me.ancien_email.Location = New System.Drawing.Point(201, 55)
        Me.ancien_email.Name = "ancien_email"
        Me.ancien_email.Size = New System.Drawing.Size(100, 22)
        Me.ancien_email.TabIndex = 61
        Me.ancien_email.Visible = False


        Me.idmembre.Location = New System.Drawing.Point(95, 55)
        Me.idmembre.Name = "idmembre"
        Me.idmembre.Size = New System.Drawing.Size(100, 22)
        Me.idmembre.TabIndex = 60
        Me.idmembre.Visible = False


        Me.dateinscription.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateinscription.Location = New System.Drawing.Point(329, 339)
        Me.dateinscription.Name = "dateinscription"
        Me.dateinscription.Size = New System.Drawing.Size(200, 22)
        Me.dateinscription.TabIndex = 56


        Me.statut.FormattingEnabled = True
        Me.statut.Items.AddRange(New Object() {"actif", "inactif"})
        Me.statut.Location = New System.Drawing.Point(95, 339)
        Me.statut.Name = "statut"
        Me.statut.Size = New System.Drawing.Size(121, 24)
        Me.statut.TabIndex = 55


        Me.idcategoriemembre.FormattingEnabled = True
        Me.idcategoriemembre.Location = New System.Drawing.Point(95, 289)
        Me.idcategoriemembre.Name = "idcategoriemembre"
        Me.idcategoriemembre.Size = New System.Drawing.Size(434, 24)
        Me.idcategoriemembre.TabIndex = 54


        Me.telephone.Location = New System.Drawing.Point(95, 239)
        Me.telephone.Name = "telephone"
        Me.telephone.Size = New System.Drawing.Size(434, 22)
        Me.telephone.TabIndex = 53


        Me.email.Location = New System.Drawing.Point(95, 189)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(434, 22)
        Me.email.TabIndex = 52


        Me.adresse.Location = New System.Drawing.Point(329, 139)
        Me.adresse.Name = "adresse"
        Me.adresse.Multiline = True
        Me.adresse.Size = New System.Drawing.Size(200, 40)
        Me.adresse.TabIndex = 51


        Me.prenom.Location = New System.Drawing.Point(95, 139)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(200, 22)
        Me.prenom.TabIndex = 50


        Me.nom.Location = New System.Drawing.Point(95, 89)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(434, 22)
        Me.nom.TabIndex = 45


        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(329, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Adresse"


        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(91, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Prénom"


        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(329, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 17)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Date inscription"


        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Statut"


        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "actualiser.png")
        Me.ImageList1.Images.SetKeyName(1, "ajouter.png")
        Me.ImageList1.Images.SetKeyName(2, "imprimer.png")
        Me.ImageList1.Images.SetKeyName(3, "rechercher.png")
        Me.ImageList1.Images.SetKeyName(4, "save.png")
        Me.ImageList1.Images.SetKeyName(5, "supprimer.png")


        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Catégorie"


        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Téléphone"


        Me.ligne_modifie.AutoSize = True
        Me.ligne_modifie.Location = New System.Drawing.Point(309, 38)
        Me.ligne_modifie.Name = "ligne_modifie"
        Me.ligne_modifie.Size = New System.Drawing.Size(91, 17)
        Me.ligne_modifie.TabIndex = 55
        Me.ligne_modifie.Text = "ligne_modifie"
        Me.ligne_modifie.Visible = False


        Me.type_operation.AutoSize = True
        Me.type_operation.Location = New System.Drawing.Point(406, 38)
        Me.type_operation.Name = "type_operation"
        Me.type_operation.Size = New System.Drawing.Size(103, 17)
        Me.type_operation.TabIndex = 54
        Me.type_operation.Text = "type_operation"
        Me.type_operation.Visible = False


        Me.Save.FlatAppearance.BorderSize = 0
        Me.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.ImageIndex = 4
        Me.Save.ImageList = Me.ImageList1
        Me.Save.Location = New System.Drawing.Point(95, 365)
        Me.Save.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(51, 37)
        Me.Save.TabIndex = 57
        Me.Save.UseVisualStyleBackColor = True


        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Email"


        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Nom"


        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 481)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ancien_email)
        Me.Controls.Add(Me.idmembre)
        Me.Controls.Add(Me.dateinscription)
        Me.Controls.Add(Me.statut)
        Me.Controls.Add(Me.idcategoriemembre)
        Me.Controls.Add(Me.telephone)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.adresse)
        Me.Controls.Add(Me.prenom)
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
        Me.Name = "Form18"
        Me.Text = "Form18"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ancien_email As System.Windows.Forms.TextBox
    Friend WithEvents idmembre As System.Windows.Forms.TextBox
    Friend WithEvents dateinscription As System.Windows.Forms.DateTimePicker
    Friend WithEvents statut As System.Windows.Forms.ComboBox
    Friend WithEvents idcategoriemembre As System.Windows.Forms.ComboBox
    Friend WithEvents telephone As System.Windows.Forms.TextBox
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents adresse As System.Windows.Forms.TextBox
    Friend WithEvents prenom As System.Windows.Forms.TextBox
    Friend WithEvents nom As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ligne_modifie As System.Windows.Forms.Label
    Friend WithEvents type_operation As System.Windows.Forms.Label
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
