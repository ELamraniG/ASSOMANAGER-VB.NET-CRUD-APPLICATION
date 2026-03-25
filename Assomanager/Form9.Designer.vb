<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        Me.dgv8 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip8 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton16 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton17 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton18 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton19 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ImprimerTousLesServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.P8 = New System.Drawing.Printing.PrintDocument()
        Me.d8 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgv8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip8.SuspendLayout()
        Me.SuspendLayout()


        Me.dgv8.AllowUserToAddRows = False
        Me.dgv8.AllowUserToDeleteRows = False
        Me.dgv8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv8.Location = New System.Drawing.Point(177, 151)
        Me.dgv8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv8.Name = "dgv8"
        Me.dgv8.ReadOnly = True
        Me.dgv8.RowTemplate.Height = 28
        Me.dgv8.Size = New System.Drawing.Size(213, 121)
        Me.dgv8.TabIndex = 0


        Me.ToolStrip8.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip8.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton15, Me.ToolStripSeparator1, Me.ToolStripButton16, Me.ToolStripSeparator2, Me.ToolStripButton17, Me.ToolStripSeparator3, Me.ToolStripButton18, Me.ToolStripSeparator4, Me.ToolStripDropDownButton19})
        Me.ToolStrip8.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip8.Name = "ToolStrip8"
        Me.ToolStrip8.Size = New System.Drawing.Size(774, 39)
        Me.ToolStrip8.TabIndex = 1
        Me.ToolStrip8.Text = "ToolStrip1"


        Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), System.Drawing.Image)
        Me.ToolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton15.Text = "Ajouter un service"


        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)


        Me.ToolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton16.Image = CType(resources.GetObject("ToolStripButton16.Image"), System.Drawing.Image)
        Me.ToolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton16.Name = "ToolStripButton16"
        Me.ToolStripButton16.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton16.Text = "ToolStripButton2"
        Me.ToolStripButton16.ToolTipText = "Supprimer"


        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)


        Me.ToolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton17.Image = CType(resources.GetObject("ToolStripButton17.Image"), System.Drawing.Image)
        Me.ToolStripButton17.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton17.Name = "ToolStripButton17"
        Me.ToolStripButton17.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton17.Text = "ToolStripButton3"
        Me.ToolStripButton17.ToolTipText = "Actualiser"


        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)


        Me.ToolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton18.Image = CType(resources.GetObject("ToolStripButton18.Image"), System.Drawing.Image)
        Me.ToolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton18.Name = "ToolStripButton18"
        Me.ToolStripButton18.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton18.Text = "ToolStripButton4"
        Me.ToolStripButton18.ToolTipText = "Rechercher un service"


        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)


        Me.ToolStripDropDownButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton19.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimerTousLesServicesToolStripMenuItem})
        Me.ToolStripDropDownButton19.Image = CType(resources.GetObject("ToolStripDropDownButton19.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton19.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton19.Name = "ToolStripDropDownButton19"
        Me.ToolStripDropDownButton19.Size = New System.Drawing.Size(45, 36)
        Me.ToolStripDropDownButton19.Text = "ToolStripDropDownButton1"


        Me.ImprimerTousLesServicesToolStripMenuItem.Name = "ImprimerTousLesServicesToolStripMenuItem"
        Me.ImprimerTousLesServicesToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.ImprimerTousLesServicesToolStripMenuItem.Text = "Imprimer tous les services"


        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(646, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 25)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Label7"


        Me.d8.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.d8.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.d8.ClientSize = New System.Drawing.Size(400, 300)
        Me.d8.Document = Me.P8
        Me.d8.Enabled = True
        Me.d8.Icon = CType(resources.GetObject("d8.Icon"), System.Drawing.Icon)
        Me.d8.Name = "PrintPreviewDialog1"
        Me.d8.Visible = False


        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(774, 372)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ToolStrip8)
        Me.Controls.Add(Me.dgv8)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form9"
        Me.Text = "✅categoriedepenses"
        CType(Me.dgv8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip8.ResumeLayout(False)
        Me.ToolStrip8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip8 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton15 As System.Windows.Forms.ToolStripButton
    Friend WithEvents nombredeservice As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton16 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton17 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton18 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton19 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ImprimerTousLesServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents P8 As System.Drawing.Printing.PrintDocument
    Friend WithEvents d8 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgv8 As System.Windows.Forms.DataGridView

End Class
