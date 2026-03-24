<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.dgv7 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip7 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton77 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton777 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7777 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton7 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ImprimerTousLesServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.P7 = New System.Drawing.Printing.PrintDocument()
        Me.d7 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgv7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip7.SuspendLayout()
        Me.SuspendLayout()


        Me.dgv7.AllowUserToAddRows = False
        Me.dgv7.AllowUserToDeleteRows = False
        Me.dgv7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv7.Location = New System.Drawing.Point(177, 151)
        Me.dgv7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv7.Name = "dgv7"
        Me.dgv7.ReadOnly = True
        Me.dgv7.RowTemplate.Height = 28
        Me.dgv7.Size = New System.Drawing.Size(213, 121)
        Me.dgv7.TabIndex = 0


        Me.ToolStrip7.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip7.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton7, Me.ToolStripSeparator1, Me.ToolStripButton77, Me.ToolStripSeparator2, Me.ToolStripButton777, Me.ToolStripSeparator3, Me.ToolStripButton7777, Me.ToolStripSeparator4, Me.ToolStripDropDownButton7})
        Me.ToolStrip7.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip7.Name = "ToolStrip7"
        Me.ToolStrip7.Size = New System.Drawing.Size(900, 39)
        Me.ToolStrip7.TabIndex = 1
        Me.ToolStrip7.Text = "ToolStrip1"


        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton7.Text = "Ajouter un service"


        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)


        Me.ToolStripButton77.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton77.Image = CType(resources.GetObject("ToolStripButton77.Image"), System.Drawing.Image)
        Me.ToolStripButton77.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton77.Name = "ToolStripButton77"
        Me.ToolStripButton77.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton77.Text = "ToolStripButton2"
        Me.ToolStripButton77.ToolTipText = "Supprimer"


        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)


        Me.ToolStripButton777.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton777.Image = CType(resources.GetObject("ToolStripButton777.Image"), System.Drawing.Image)
        Me.ToolStripButton777.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton777.Name = "ToolStripButton777"
        Me.ToolStripButton777.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton777.Text = "ToolStripButton3"
        Me.ToolStripButton777.ToolTipText = "Actualiser"


        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)


        Me.ToolStripButton7777.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7777.Image = CType(resources.GetObject("ToolStripButton7777.Image"), System.Drawing.Image)
        Me.ToolStripButton7777.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7777.Name = "ToolStripButton7777"
        Me.ToolStripButton7777.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton7777.Text = "ToolStripButton4"
        Me.ToolStripButton7777.ToolTipText = "Rechercher un service"


        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)


        Me.ToolStripDropDownButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton7.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimerTousLesServicesToolStripMenuItem})
        Me.ToolStripDropDownButton7.Image = CType(resources.GetObject("ToolStripDropDownButton7.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton7.Name = "ToolStripDropDownButton7"
        Me.ToolStripDropDownButton7.Size = New System.Drawing.Size(45, 36)
        Me.ToolStripDropDownButton7.Text = "ToolStripDropDownButton1"


        Me.ImprimerTousLesServicesToolStripMenuItem.Name = "ImprimerTousLesServicesToolStripMenuItem"
        Me.ImprimerTousLesServicesToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.ImprimerTousLesServicesToolStripMenuItem.Text = "Imprimer tous les services"


        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(757, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Label7"


        Me.d7.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.d7.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.d7.ClientSize = New System.Drawing.Size(400, 300)
        Me.d7.Document = Me.P7
        Me.d7.Enabled = True
        Me.d7.Icon = CType(resources.GetObject("d7.Icon"), System.Drawing.Icon)
        Me.d7.Name = "PrintPreviewDialog1"
        Me.d7.Visible = False


        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 505)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ToolStrip7)
        Me.Controls.Add(Me.dgv7)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form7"
        Me.Text = "categoriemembres"
        CType(Me.dgv7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip7.ResumeLayout(False)
        Me.ToolStrip7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv7 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip7 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents nombredeservice As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton77 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton777 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton7777 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton7 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ImprimerTousLesServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents P7 As System.Drawing.Printing.PrintDocument
    Friend WithEvents d7 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
