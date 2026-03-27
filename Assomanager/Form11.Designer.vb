<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form11))
        Me.dgv11 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip11 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton111 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton112 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton113 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton114 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripDropDownButton111 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ImprimerTousLesServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.P11 = New System.Drawing.Printing.PrintDocument()
        Me.d11 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgv11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip11.SuspendLayout()
        Me.SuspendLayout()


        Me.dgv11.AllowUserToAddRows = False
        Me.dgv11.AllowUserToDeleteRows = False
        Me.dgv11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv11.Location = New System.Drawing.Point(177, 151)
        Me.dgv11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv11.Name = "dgv11"
        Me.dgv11.ReadOnly = True
        Me.dgv11.RowTemplate.Height = 28
        Me.dgv11.Size = New System.Drawing.Size(213, 121)
        Me.dgv11.TabIndex = 0


        Me.ToolStrip11.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip11.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton111, Me.ToolStripSeparator1, Me.ToolStripButton112, Me.ToolStripSeparator2, Me.ToolStripButton113, Me.ToolStripSeparator3, Me.ToolStripButton114, Me.ToolStripSeparator4, Me.ToolStripDropDownButton111})
        Me.ToolStrip11.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip11.Name = "ToolStrip11"
        Me.ToolStrip11.Size = New System.Drawing.Size(1119, 39)
        Me.ToolStrip11.TabIndex = 1
        Me.ToolStrip11.Text = "ToolStrip1"


        Me.ToolStripButton111.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton111.Image = CType(resources.GetObject("ToolStripButton111.Image"), System.Drawing.Image)
        Me.ToolStripButton111.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton111.Name = "ToolStripButton111"
        Me.ToolStripButton111.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton111.Text = "Ajouter un service"


        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)


        Me.ToolStripButton112.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton112.Image = CType(resources.GetObject("ToolStripButton112.Image"), System.Drawing.Image)
        Me.ToolStripButton112.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton112.Name = "ToolStripButton112"
        Me.ToolStripButton112.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton112.Text = "ToolStripButton2"
        Me.ToolStripButton112.ToolTipText = "Supprimer"


        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)


        Me.ToolStripButton113.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton113.Image = CType(resources.GetObject("ToolStripButton113.Image"), System.Drawing.Image)
        Me.ToolStripButton113.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton113.Name = "ToolStripButton113"
        Me.ToolStripButton113.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton113.Text = "ToolStripButton3"
        Me.ToolStripButton113.ToolTipText = "Actualiser"


        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)


        Me.ToolStripButton114.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton114.Image = CType(resources.GetObject("ToolStripButton114.Image"), System.Drawing.Image)
        Me.ToolStripButton114.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton114.Name = "ToolStripButton114"
        Me.ToolStripButton114.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton114.Text = "ToolStripButton4"
        Me.ToolStripButton114.ToolTipText = "Rechercher un service"


        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)


        Me.ToolStripDropDownButton111.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton111.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimerTousLesServicesToolStripMenuItem})
        Me.ToolStripDropDownButton111.Image = CType(resources.GetObject("ToolStripDropDownButton111.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton111.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton111.Name = "ToolStripDropDownButton111"
        Me.ToolStripDropDownButton111.Size = New System.Drawing.Size(45, 36)
        Me.ToolStripDropDownButton111.Text = "ToolStripDropDownButton1"


        Me.ImprimerTousLesServicesToolStripMenuItem.Name = "ImprimerTousLesServicesToolStripMenuItem"
        Me.ImprimerTousLesServicesToolStripMenuItem.Size = New System.Drawing.Size(248, 24)
        Me.ImprimerTousLesServicesToolStripMenuItem.Text = "Imprimer tous les services"


        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(646, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 25)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Label7"


        Me.d11.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.d11.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.d11.ClientSize = New System.Drawing.Size(400, 300)
        Me.d11.Document = Me.P11
        Me.d11.Enabled = True
        Me.d11.Icon = CType(resources.GetObject("d11.Icon"), System.Drawing.Icon)
        Me.d11.Name = "PrintPreviewDialog1"
        Me.d11.Visible = False


        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1119, 450)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ToolStrip11)
        Me.Controls.Add(Me.dgv11)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form11"
        Me.Text = "evenements"
        CType(Me.dgv11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip11.ResumeLayout(False)
        Me.ToolStrip11.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip11 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton111 As System.Windows.Forms.ToolStripButton
    Friend WithEvents nombredeservice As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton112 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton113 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton114 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripDropDownButton111 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ImprimerTousLesServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents P11 As System.Drawing.Printing.PrintDocument
    Friend WithEvents d11 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dgv11 As System.Windows.Forms.DataGridView

End Class
