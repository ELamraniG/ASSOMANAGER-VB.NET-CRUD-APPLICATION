<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form24
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form24))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.idparticipant = New System.Windows.Forms.TextBox()
        Me.statutpresence = New System.Windows.Forms.ComboBox()
        Me.idmembre = New System.Windows.Forms.ComboBox()
        Me.idevenement = New System.Windows.Forms.ComboBox()
        Me.ligne_modifie = New System.Windows.Forms.Label()
        Me.type_operation = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()


        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "actualiser.png")
        Me.ImageList1.Images.SetKeyName(1, "ajouter.png")
        Me.ImageList1.Images.SetKeyName(2, "imprimer.png")
        Me.ImageList1.Images.SetKeyName(3, "rechercher.png")
        Me.ImageList1.Images.SetKeyName(4, "save.png")
        Me.ImageList1.Images.SetKeyName(5, "supprimer.png")


        Me.idparticipant.Location = New System.Drawing.Point(207, 49)
        Me.idparticipant.Name = "idparticipant"
        Me.idparticipant.Size = New System.Drawing.Size(100, 22)
        Me.idparticipant.TabIndex = 122
        Me.idparticipant.Visible = False


        Me.statutpresence.FormattingEnabled = True
        Me.statutpresence.Items.AddRange(New Object() {"inscrit", "présent", "absent"})
        Me.statutpresence.Location = New System.Drawing.Point(207, 215)
        Me.statutpresence.Name = "statutpresence"
        Me.statutpresence.Size = New System.Drawing.Size(200, 24)
        Me.statutpresence.TabIndex = 117


        Me.idmembre.FormattingEnabled = True
        Me.idmembre.Location = New System.Drawing.Point(207, 165)
        Me.idmembre.Name = "idmembre"
        Me.idmembre.Size = New System.Drawing.Size(434, 24)
        Me.idmembre.TabIndex = 113


        Me.idevenement.FormattingEnabled = True
        Me.idevenement.Location = New System.Drawing.Point(207, 115)
        Me.idevenement.Name = "idevenement"
        Me.idevenement.Size = New System.Drawing.Size(434, 24)
        Me.idevenement.TabIndex = 109


        Me.ligne_modifie.AutoSize = True
        Me.ligne_modifie.Location = New System.Drawing.Point(421, 49)
        Me.ligne_modifie.Name = "ligne_modifie"
        Me.ligne_modifie.Size = New System.Drawing.Size(91, 17)
        Me.ligne_modifie.TabIndex = 114
        Me.ligne_modifie.Text = "ligne_modifie"
        Me.ligne_modifie.Visible = False


        Me.type_operation.AutoSize = True
        Me.type_operation.Location = New System.Drawing.Point(518, 49)
        Me.type_operation.Name = "type_operation"
        Me.type_operation.Size = New System.Drawing.Size(103, 17)
        Me.type_operation.TabIndex = 112
        Me.type_operation.Text = "type_operation"
        Me.type_operation.Visible = False


        Me.Save.FlatAppearance.BorderSize = 0
        Me.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.ImageIndex = 4
        Me.Save.ImageList = Me.ImageList1
        Me.Save.Location = New System.Drawing.Point(207, 270)
        Me.Save.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(51, 37)
        Me.Save.TabIndex = 119
        Me.Save.UseVisualStyleBackColor = True


        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(207, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Événement"


        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Membre"


        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Statut Présence"


        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 347)
        Me.Controls.Add(Me.idparticipant)
        Me.Controls.Add(Me.statutpresence)
        Me.Controls.Add(Me.idmembre)
        Me.Controls.Add(Me.idevenement)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ligne_modifie)
        Me.Controls.Add(Me.type_operation)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form24"
        Me.Text = "Gestion des participants"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents idparticipant As System.Windows.Forms.TextBox
    Friend WithEvents statutpresence As System.Windows.Forms.ComboBox
    Friend WithEvents idmembre As System.Windows.Forms.ComboBox
    Friend WithEvents idevenement As System.Windows.Forms.ComboBox
    Friend WithEvents ligne_modifie As System.Windows.Forms.Label
    Friend WithEvents type_operation As System.Windows.Forms.Label
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
