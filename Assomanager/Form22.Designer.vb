<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form22
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form22))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.iddepense = New System.Windows.Forms.TextBox()
        Me.datedepense = New System.Windows.Forms.DateTimePicker()
        Me.idcategoriedepense = New System.Windows.Forms.ComboBox()
        Me.montant = New System.Windows.Forms.TextBox()
        Me.libelle = New System.Windows.Forms.TextBox()
        Me.ligne_modifie = New System.Windows.Forms.Label()
        Me.type_operation = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fournisseur = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.justificatif = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.SuspendLayout()


        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "actualiser.png")
        Me.ImageList1.Images.SetKeyName(1, "ajouter.png")
        Me.ImageList1.Images.SetKeyName(2, "imprimer.png")
        Me.ImageList1.Images.SetKeyName(3, "rechercher.png")
        Me.ImageList1.Images.SetKeyName(4, "save.png")
        Me.ImageList1.Images.SetKeyName(5, "supprimer.png")


        Me.iddepense.Location = New System.Drawing.Point(222, 55)
        Me.iddepense.Name = "iddepense"
        Me.iddepense.Size = New System.Drawing.Size(100, 22)
        Me.iddepense.TabIndex = 105
        Me.iddepense.Visible = False


        Me.datedepense.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datedepense.Location = New System.Drawing.Point(222, 221)
        Me.datedepense.Name = "datedepense"
        Me.datedepense.Size = New System.Drawing.Size(200, 22)
        Me.datedepense.TabIndex = 100


        Me.idcategoriedepense.FormattingEnabled = True
        Me.idcategoriedepense.Location = New System.Drawing.Point(222, 271)
        Me.idcategoriedepense.Name = "idcategoriedepense"
        Me.idcategoriedepense.Size = New System.Drawing.Size(434, 24)
        Me.idcategoriedepense.TabIndex = 96


        Me.montant.Location = New System.Drawing.Point(222, 171)
        Me.montant.Name = "montant"
        Me.montant.Size = New System.Drawing.Size(200, 22)
        Me.montant.TabIndex = 94


        Me.libelle.Location = New System.Drawing.Point(222, 121)
        Me.libelle.Name = "libelle"
        Me.libelle.Size = New System.Drawing.Size(434, 22)
        Me.libelle.TabIndex = 92


        Me.ligne_modifie.AutoSize = True
        Me.ligne_modifie.Location = New System.Drawing.Point(436, 55)
        Me.ligne_modifie.Name = "ligne_modifie"
        Me.ligne_modifie.Size = New System.Drawing.Size(91, 17)
        Me.ligne_modifie.TabIndex = 97
        Me.ligne_modifie.Text = "ligne_modifie"
        Me.ligne_modifie.Visible = False


        Me.type_operation.AutoSize = True
        Me.type_operation.Location = New System.Drawing.Point(533, 55)
        Me.type_operation.Name = "type_operation"
        Me.type_operation.Size = New System.Drawing.Size(103, 17)
        Me.type_operation.TabIndex = 95
        Me.type_operation.Text = "type_operation"
        Me.type_operation.Visible = False


        Me.Save.FlatAppearance.BorderSize = 0
        Me.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.ImageIndex = 4
        Me.Save.ImageList = Me.ImageList1
        Me.Save.Location = New System.Drawing.Point(222, 397)
        Me.Save.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(51, 37)
        Me.Save.TabIndex = 102
        Me.Save.UseVisualStyleBackColor = True


        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(222, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Libellé"


        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Montant"


        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Date"


        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(222, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Catégorie"


        Me.fournisseur.Location = New System.Drawing.Point(222, 321)
        Me.fournisseur.Name = "fournisseur"
        Me.fournisseur.Size = New System.Drawing.Size(434, 22)
        Me.fournisseur.TabIndex = 98


        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(222, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Fournisseur"


        Me.justificatif.Location = New System.Drawing.Point(222, 371)
        Me.justificatif.Name = "justificatif"
        Me.justificatif.Size = New System.Drawing.Size(354, 22)
        Me.justificatif.TabIndex = 104


        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(222, 351)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Justificatif"


        Me.btnBrowse.Location = New System.Drawing.Point(582, 370)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 107
        Me.btnBrowse.Text = "Parcourir"
        Me.btnBrowse.UseVisualStyleBackColor = True


        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 488)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.justificatif)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fournisseur)
        Me.Controls.Add(Me.iddepense)
        Me.Controls.Add(Me.datedepense)
        Me.Controls.Add(Me.idcategoriedepense)
        Me.Controls.Add(Me.montant)
        Me.Controls.Add(Me.libelle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ligne_modifie)
        Me.Controls.Add(Me.type_operation)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form22"
        Me.Text = "Gestion des dépenses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents iddepense As System.Windows.Forms.TextBox
    Friend WithEvents datedepense As System.Windows.Forms.DateTimePicker
    Friend WithEvents idcategoriedepense As System.Windows.Forms.ComboBox
    Friend WithEvents montant As System.Windows.Forms.TextBox
    Friend WithEvents libelle As System.Windows.Forms.TextBox
    Friend WithEvents ligne_modifie As System.Windows.Forms.Label
    Friend WithEvents type_operation As System.Windows.Forms.Label
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fournisseur As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents justificatif As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
End Class
