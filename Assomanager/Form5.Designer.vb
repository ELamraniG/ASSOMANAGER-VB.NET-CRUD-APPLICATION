<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.dgv3 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip11 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton22 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton33 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton44 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ImprimerTousLesServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.P3 = New System.Drawing.Printing.PrintDocument()
        Me.d3 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip11.SuspendLayout()
        Me.SuspendLayout()


        Me.dgv3.AllowUserToAddRows = False
        Me.dgv3.AllowUserToDeleteRows = False
        Me.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv3.Location = New System.Drawing.Point(177, 151)
        Me.dgv3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv3.Name = "dgv3"
        Me.dgv3.ReadOnly = True
        Me.dgv3.RowTemplate.Height = 28
        Me.dgv3.Size = New System.Drawing.Size(213, 120)
        Me.dgv3.TabIndex = 0


        Me.ToolStrip11.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip11.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton11, Me.ToolStripSeparator1, Me.ToolStripButton22, Me.ToolStripSeparator2, Me.ToolStripButton33, Me.ToolStripSeparator3, Me.ToolStripButton44, Me.ToolStripSeparator4, Me.ToolStripDropDownButton1})
        Me.ToolStrip11.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip11.Name = "ToolStrip11"
        Me.ToolStrip11.Size = New System.Drawing.Size(900, 39)
        Me.ToolStrip11.TabIndex = 1
        Me.ToolStrip11.Text = "ToolStrip1"


        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton11.Text = "Ajouter un service"


        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)


        Me.ToolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton22.Image = CType(resources.GetObject("ToolStripButton22.Image"), System.Drawing.Image)
        Me.ToolStripButton22.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton22.Name = "ToolStripButton22"
        Me.ToolStripButton22.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton22.Text = "ToolStripButton2"
        Me.ToolStripButton22.ToolTipText = "Supprimer"


        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)


        Me.ToolStripButton33.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton33.Image = CType(resources.GetObject("ToolStripButton33.Image"), System.Drawing.Image)
        Me.ToolStripButton33.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton33.Name = "ToolStripButton33"
        Me.ToolStripButton33.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton33.Text = "ToolStripButton3"
        Me.ToolStripButton33.ToolTipText = "Actualiser"


        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)


        Me.ToolStripButton44.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton44.Image = CType(resources.GetObject("ToolStripButton44.Image"), System.Drawing.Image)
        Me.ToolStripButton44.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton44.Name = "ToolStripButton44"
        Me.ToolStripButton44.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton44.Text = "ToolStripButton4"
        Me.ToolStripButton44.ToolTipText = "Rechercher un service"


        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)


        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimerTousLesServicesToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(45, 36)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"


        Me.ImprimerTousLesServicesToolStripMenuItem.Name = "ImprimerTousLesServicesToolStripMenuItem"
        Me.ImprimerTousLesServicesToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.ImprimerTousLesServicesToolStripMenuItem.Text = "Imprimer tous les services"


        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(758, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label2"


        Me.d3.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.d3.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.d3.ClientSize = New System.Drawing.Size(400, 300)
        Me.d3.Document = Me.P3
        Me.d3.Enabled = True
        Me.d3.Icon = CType(resources.GetObject("d3.Icon"), System.Drawing.Icon)
        Me.d3.Name = "PrintPreviewDialog1"
        Me.d3.Visible = False


        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 505)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip11)
        Me.Controls.Add(Me.dgv3)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form5"
        Me.Text = "parametres"
        CType(Me.dgv3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip11.ResumeLayout(False)
        Me.ToolStrip11.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv3 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip11 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents nombredeservice As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton22 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton33 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton44 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ImprimerTousLesServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents P3 As System.Drawing.Printing.PrintDocument
    Friend WithEvents d3 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
