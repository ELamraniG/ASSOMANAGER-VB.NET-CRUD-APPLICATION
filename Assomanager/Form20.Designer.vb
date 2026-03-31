<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form20
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form20))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.idcotisation = New System.Windows.Forms.TextBox()
        Me.datepaiement = New System.Windows.Forms.DateTimePicker()
        Me.statut = New System.Windows.Forms.ComboBox()
        Me.modepaiement = New System.Windows.Forms.ComboBox()
        Me.montant = New System.Windows.Forms.TextBox()
        Me.idmembre = New System.Windows.Forms.ComboBox()
        Me.ligne_modifie = New System.Windows.Forms.Label()
        Me.type_operation = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.periodemois = New System.Windows.Forms.ComboBox()
        Me.periodeannee = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()


        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "actualiser.png")
        Me.ImageList1.Images.SetKeyName(1, "ajouter.png")
        Me.ImageList1.Images.SetKeyName(2, "imprimer.png")
        Me.ImageList1.Images.SetKeyName(3, "rechercher.png")
        Me.ImageList1.Images.SetKeyName(4, "save.png")
        Me.ImageList1.Images.SetKeyName(5, "supprimer.png")


        Me.idcotisation.Location = New System.Drawing.Point(112, 40)
        Me.idcotisation.Name = "idcotisation"
        Me.idcotisation.Size = New System.Drawing.Size(100, 22)
        Me.idcotisation.TabIndex = 86
        Me.idcotisation.Visible = False


        Me.datepaiement.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datepaiement.Location = New System.Drawing.Point(112, 206)
        Me.datepaiement.Name = "datepaiement"
        Me.datepaiement.Size = New System.Drawing.Size(200, 22)
        Me.datepaiement.TabIndex = 81


        Me.statut.FormattingEnabled = True
        Me.statut.Items.AddRange(New Object() {"payé", "en attente", "retard"})
        Me.statut.Location = New System.Drawing.Point(112, 306)
        Me.statut.Name = "statut"
        Me.statut.Size = New System.Drawing.Size(200, 24)
        Me.statut.TabIndex = 79


        Me.modepaiement.FormattingEnabled = True
        Me.modepaiement.Items.AddRange(New Object() {"Espèce", "Virement", "Carte"})
        Me.modepaiement.Location = New System.Drawing.Point(112, 256)
        Me.modepaiement.Name = "modepaiement"
        Me.modepaiement.Size = New System.Drawing.Size(200, 24)
        Me.modepaiement.TabIndex = 77


        Me.montant.Location = New System.Drawing.Point(112, 156)
        Me.montant.Name = "montant"
        Me.montant.Size = New System.Drawing.Size(200, 22)
        Me.montant.TabIndex = 75


        Me.idmembre.FormattingEnabled = True
        Me.idmembre.Location = New System.Drawing.Point(112, 106)
        Me.idmembre.Name = "idmembre"
        Me.idmembre.Size = New System.Drawing.Size(434, 24)
        Me.idmembre.TabIndex = 73


        Me.ligne_modifie.AutoSize = True
        Me.ligne_modifie.Location = New System.Drawing.Point(326, 40)
        Me.ligne_modifie.Name = "ligne_modifie"
        Me.ligne_modifie.Size = New System.Drawing.Size(91, 17)
        Me.ligne_modifie.TabIndex = 78
        Me.ligne_modifie.Text = "ligne_modifie"
        Me.ligne_modifie.Visible = False


        Me.type_operation.AutoSize = True
        Me.type_operation.Location = New System.Drawing.Point(423, 40)
        Me.type_operation.Name = "type_operation"
        Me.type_operation.Size = New System.Drawing.Size(103, 17)
        Me.type_operation.TabIndex = 76
        Me.type_operation.Text = "type_operation"
        Me.type_operation.Visible = False


        Me.Save.FlatAppearance.BorderSize = 0
        Me.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.ImageIndex = 4
        Me.Save.ImageList = Me.ImageList1
        Me.Save.Location = New System.Drawing.Point(112, 382)
        Me.Save.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(51, 37)
        Me.Save.TabIndex = 83
        Me.Save.UseVisualStyleBackColor = True


        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Membre"


        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Montant"


        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 17)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Date Paiement"


        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 17)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Mode Paiement"


        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(112, 286)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Statut"


        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(341, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Mois"


        Me.periodemois.FormattingEnabled = True
        Me.periodemois.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.periodemois.Location = New System.Drawing.Point(341, 306)
        Me.periodemois.Name = "periodemois"
        Me.periodemois.Size = New System.Drawing.Size(80, 24)
        Me.periodemois.TabIndex = 87


        Me.periodeannee.Location = New System.Drawing.Point(446, 306)
        Me.periodeannee.Name = "periodeannee"
        Me.periodeannee.Size = New System.Drawing.Size(100, 22)
        Me.periodeannee.TabIndex = 88


        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(446, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 17)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Année"


        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(112, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(400, 17)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Période: correspond au mois/année auquel la cotisation s'applique"


        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 475)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.periodeannee)
        Me.Controls.Add(Me.periodemois)
        Me.Controls.Add(Me.idcotisation)
        Me.Controls.Add(Me.datepaiement)
        Me.Controls.Add(Me.statut)
        Me.Controls.Add(Me.modepaiement)
        Me.Controls.Add(Me.montant)
        Me.Controls.Add(Me.idmembre)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ligne_modifie)
        Me.Controls.Add(Me.type_operation)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form20"
        Me.Text = "Gestion des cotisations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents idcotisation As System.Windows.Forms.TextBox
    Friend WithEvents datepaiement As System.Windows.Forms.DateTimePicker
    Friend WithEvents statut As System.Windows.Forms.ComboBox
    Friend WithEvents modepaiement As System.Windows.Forms.ComboBox
    Friend WithEvents montant As System.Windows.Forms.TextBox
    Friend WithEvents idmembre As System.Windows.Forms.ComboBox
    Friend WithEvents ligne_modifie As System.Windows.Forms.Label
    Friend WithEvents type_operation As System.Windows.Forms.Label
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents periodemois As System.Windows.Forms.ComboBox
    Friend WithEvents periodeannee As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
