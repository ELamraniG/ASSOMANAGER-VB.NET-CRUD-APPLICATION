<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.TextBox81 = New System.Windows.Forms.TextBox()
        Me.enregistrer8 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SuspendLayout()


        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(31, 38)
        Me.Label81.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(59, 25)
        Me.Label81.TabIndex = 0
        Me.Label81.Text = "Nom:"


        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(31, 100)
        Me.Label82.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(75, 25)
        Me.Label82.TabIndex = 1
        Me.Label82.Text = "Valeur:"
        Me.Label82.Visible = False


        Me.TextBox81.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox81.Location = New System.Drawing.Point(116, 34)
        Me.TextBox81.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox81.Name = "TextBox81"
        Me.TextBox81.Size = New System.Drawing.Size(344, 30)
        Me.TextBox81.TabIndex = 2


        Me.enregistrer8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enregistrer8.Location = New System.Drawing.Point(116, 98)
        Me.enregistrer8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.enregistrer8.Name = "enregistrer8"
        Me.enregistrer8.Size = New System.Drawing.Size(147, 53)
        Me.enregistrer8.TabIndex = 4
        Me.enregistrer8.Text = "Ajouter"
        Me.enregistrer8.UseVisualStyleBackColor = True


        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(315, 98)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(147, 53)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Fermer"
        Me.Button8.UseVisualStyleBackColor = True


        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 222)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.enregistrer8)
        Me.Controls.Add(Me.TextBox81)
        Me.Controls.Add(Me.Label82)
        Me.Controls.Add(Me.Label81)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catégorie de membre"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents TextBox81 As System.Windows.Forms.TextBox
    Friend WithEvents enregistrer8 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
