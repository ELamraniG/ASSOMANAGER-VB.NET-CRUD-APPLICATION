<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form13
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form13))
        Me.dgv13 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip13 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton131 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton132 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton133 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton134 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton131 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ImprimerTousLesServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.P13 = New System.Drawing.Printing.PrintDocument()
        Me.d13 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgv13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip13.SuspendLayout()
        Me.SuspendLayout()


        Me.dgv13.AllowUserToAddRows = False
        Me.dgv13.AllowUserToDeleteRows = False
        Me.dgv13.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv13.Location = New System.Drawing.Point(177, 151)
        Me.dgv13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv13.Name = "dgv13"
        Me.dgv13.ReadOnly = True
        Me.dgv13.RowTemplate.Height = 28
        Me.dgv13.Size = New System.Drawing.Size(213, 121)
        Me.dgv13.TabIndex = 0


        Me.ToolStrip13.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip13.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton131, Me.ToolStripSeparator1, Me.ToolStripButton132, Me.ToolStripSeparator2, Me.ToolStripButton133, Me.ToolStripSeparator3, Me.ToolStripButton134, Me.ToolStripSeparator4, Me.ToolStripDropDownButton131})
        Me.ToolStrip13.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip13.Name = "ToolStrip13"
        Me.ToolStrip13.Size = New System.Drawing.Size(1015, 39)
        Me.ToolStrip13.TabIndex = 1
        Me.ToolStrip13.Text = "ToolStrip1"


        Me.ToolStripButton131.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton131.Image = CType(resources.GetObject("ToolStripButton131.Image"), System.Drawing.Image)
        Me.ToolStripButton131.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton131.Name = "ToolStripButton131"
        Me.ToolStripButton131.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton131.Text = "Ajouter un service"


        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)


        Me.ToolStripButton132.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton132.Image = CType(resources.GetObject("ToolStripButton132.Image"), System.Drawing.Image)
        Me.ToolStripButton132.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton132.Name = "ToolStripButton132"
        Me.ToolStripButton132.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton132.Text = "ToolStripButton2"
        Me.ToolStripButton132.ToolTipText = "Supprimer"


        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)


        Me.ToolStripButton133.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton133.Image = CType(resources.GetObject("ToolStripButton133.Image"), System.Drawing.Image)
        Me.ToolStripButton133.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton133.Name = "ToolStripButton133"
        Me.ToolStripButton133.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton133.Text = "ToolStripButton3"
        Me.ToolStripButton133.ToolTipText = "Actualiser"


        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)


        Me.ToolStripButton134.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton134.Image = CType(resources.GetObject("ToolStripButton134.Image"), System.Drawing.Image)
        Me.ToolStripButton134.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton134.Name = "ToolStripButton134"
        Me.ToolStripButton134.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton134.Text = "ToolStripButton4"
        Me.ToolStripButton134.ToolTipText = "Rechercher un service"


        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)


        Me.ToolStripDropDownButton131.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton131.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimerTousLesServicesToolStripMenuItem})
        Me.ToolStripDropDownButton131.Image = CType(resources.GetObject("ToolStripDropDownButton131.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton131.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton131.Name = "ToolStripDropDownButton131"
        Me.ToolStripDropDownButton131.Size = New System.Drawing.Size(45, 36)
        Me.ToolStripDropDownButton131.Text = "ToolStripDropDownButton1"


        Me.ImprimerTousLesServicesToolStripMenuItem.Name = "ImprimerTousLesServicesToolStripMenuItem"
        Me.ImprimerTousLesServicesToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.ImprimerTousLesServicesToolStripMenuItem.Text = "Imprimer tous les services"


        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(646, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 25)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Label7"


        Me.d13.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.d13.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.d13.ClientSize = New System.Drawing.Size(400, 300)
        Me.d13.Document = Me.P13
        Me.d13.Enabled = True
        Me.d13.Icon = CType(resources.GetObject("d13.Icon"), System.Drawing.Icon)
        Me.d13.Name = "PrintPreviewDialog1"
        Me.d13.Visible = False


        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1015, 450)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ToolStrip13)
        Me.Controls.Add(Me.dgv13)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form13"
        Me.Text = "documents"
        CType(Me.dgv13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip13.ResumeLayout(False)
        Me.ToolStrip13.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip13 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton131 As System.Windows.Forms.ToolStripButton
    Friend WithEvents nombredeservice As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton132 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton133 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton134 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton131 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ImprimerTousLesServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents P13 As System.Drawing.Printing.PrintDocument
    Friend WithEvents d13 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dgv13 As System.Windows.Forms.DataGridView

End Class
