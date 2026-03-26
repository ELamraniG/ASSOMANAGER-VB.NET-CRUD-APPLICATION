<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form17
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form17))
        Me.Supprimer = New System.Windows.Forms.ToolStripButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Ajouter = New System.Windows.Forms.ToolStripButton()
        Me.cpt = New System.Windows.Forms.ToolStripLabel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbar = New System.Windows.Forms.ToolStrip()
        Me.Rechercher = New System.Windows.Forms.ToolStripButton()
        Me.Actualiser = New System.Windows.Forms.ToolStripButton()
        Me.Imprimer = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ImprimerTousLesServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimerListeDesEmployésDunServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimerHistoriqueDesAffectationsDunEmployéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolbar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()


        Me.Supprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Supprimer.Image = CType(resources.GetObject("Supprimer.Image"), System.Drawing.Image)
        Me.Supprimer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(28, 28)
        Me.Supprimer.Text = "Supprimer"


        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "actualiser.png")
        Me.ImageList1.Images.SetKeyName(1, "ajouter.png")
        Me.ImageList1.Images.SetKeyName(2, "imprimer.png")
        Me.ImageList1.Images.SetKeyName(3, "rechercher.png")
        Me.ImageList1.Images.SetKeyName(4, "save.png")
        Me.ImageList1.Images.SetKeyName(5, "supprimer.png")


        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(160, 20)
        Me.ToolStripStatusLabel2.Text = "| Gestion des membres"


        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)


        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(147, 20)
        Me.ToolStripStatusLabel1.Text = "La paie du personnel"


        Me.Ajouter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Ajouter.Image = CType(resources.GetObject("Ajouter.Image"), System.Drawing.Image)
        Me.Ajouter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(28, 28)
        Me.Ajouter.Text = "Ajouter"


        Me.cpt.Name = "cpt"
        Me.cpt.Size = New System.Drawing.Size(113, 28)
        Me.cpt.Text = "ToolStripLabel1"


        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)


        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(35, 82)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(456, 204)
        Me.DataGridView2.TabIndex = 20
        Me.DataGridView2.Visible = False


        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)


        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)


        Me.toolbar.BackColor = System.Drawing.Color.White
        Me.toolbar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.Ajouter, Me.Supprimer, Me.ToolStripSeparator2, Me.Rechercher, Me.ToolStripSeparator3, Me.Actualiser, Me.ToolStripSeparator4, Me.Imprimer, Me.cpt})
        Me.toolbar.Location = New System.Drawing.Point(0, 0)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(744, 31)
        Me.toolbar.TabIndex = 18
        Me.toolbar.Text = "Rechercher par le nom du service"


        Me.Rechercher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Rechercher.Image = CType(resources.GetObject("Rechercher.Image"), System.Drawing.Image)
        Me.Rechercher.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Rechercher.Name = "Rechercher"
        Me.Rechercher.Size = New System.Drawing.Size(28, 28)
        Me.Rechercher.Text = "Rechercher par nom ou prénom"


        Me.Actualiser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Actualiser.Image = CType(resources.GetObject("Actualiser.Image"), System.Drawing.Image)
        Me.Actualiser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Actualiser.Name = "Actualiser"
        Me.Actualiser.Size = New System.Drawing.Size(28, 28)
        Me.Actualiser.Text = "Actualiser"


        Me.Imprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Imprimer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimerTousLesServicesToolStripMenuItem, Me.ToolStripSeparator5, Me.ImprimerListeDesEmployésDunServiceToolStripMenuItem, Me.ToolStripSeparator6, Me.ImprimerHistoriqueDesAffectationsDunEmployéToolStripMenuItem})
        Me.Imprimer.Image = CType(resources.GetObject("Imprimer.Image"), System.Drawing.Image)
        Me.Imprimer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Imprimer.Name = "Imprimer"
        Me.Imprimer.Size = New System.Drawing.Size(37, 28)
        Me.Imprimer.Text = "Imprimer"


        Me.ImprimerTousLesServicesToolStripMenuItem.Name = "ImprimerTousLesServicesToolStripMenuItem"
        Me.ImprimerTousLesServicesToolStripMenuItem.Size = New System.Drawing.Size(356, 24)
        Me.ImprimerTousLesServicesToolStripMenuItem.Text = "Imprimer tous les membres"


        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(353, 6)


        Me.ImprimerListeDesEmployésDunServiceToolStripMenuItem.Name = "ImprimerListeDesEmployésDunServiceToolStripMenuItem"
        Me.ImprimerListeDesEmployésDunServiceToolStripMenuItem.Size = New System.Drawing.Size(356, 24)
        Me.ImprimerListeDesEmployésDunServiceToolStripMenuItem.Text = "Imprimer liste des membres par catégorie"


        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(353, 6)


        Me.ImprimerHistoriqueDesAffectationsDunEmployéToolStripMenuItem.Name = "ImprimerHistoriqueDesAffectationsDunEmployéToolStripMenuItem"
        Me.ImprimerHistoriqueDesAffectationsDunEmployéToolStripMenuItem.Size = New System.Drawing.Size(356, 24)
        Me.ImprimerHistoriqueDesAffectationsDunEmployéToolStripMenuItem.Text = "Imprimer liste des membres par statut"


        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False


        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 42)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(700, 300)
        Me.DataGridView1.TabIndex = 17


        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 462)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(744, 25)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"


        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 487)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "Form17"
        Me.Text = "membres"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Supprimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Ajouter As System.Windows.Forms.ToolStripButton
    Friend WithEvents cpt As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents Rechercher As System.Windows.Forms.ToolStripButton
    Friend WithEvents Actualiser As System.Windows.Forms.ToolStripButton
    Friend WithEvents Imprimer As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ImprimerTousLesServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimerListeDesEmployésDunServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimerHistoriqueDesAffectationsDunEmployéToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
End Class
