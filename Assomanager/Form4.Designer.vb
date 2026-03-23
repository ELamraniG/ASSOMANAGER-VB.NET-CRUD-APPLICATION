<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.TextBox0 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.enregistrer2 = New System.Windows.Forms.Button()
        Me.ancienidtypeassociation = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()


        Me.TextBox0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox0.Location = New System.Drawing.Point(189, 64)
        Me.TextBox0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox0.Name = "TextBox0"
        Me.TextBox0.Size = New System.Drawing.Size(406, 30)
        Me.TextBox0.TabIndex = 3


        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description"


        Me.enregistrer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enregistrer2.Location = New System.Drawing.Point(50, 196)
        Me.enregistrer2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.enregistrer2.Name = "enregistrer2"
        Me.enregistrer2.Size = New System.Drawing.Size(146, 52)
        Me.enregistrer2.TabIndex = 4
        Me.enregistrer2.Text = "Ajouter"
        Me.enregistrer2.UseVisualStyleBackColor = True


        Me.ancienidtypeassociation.AutoSize = True
        Me.ancienidtypeassociation.Location = New System.Drawing.Point(691, 19)
        Me.ancienidtypeassociation.Name = "ancienidtypeassociation"
        Me.ancienidtypeassociation.Size = New System.Drawing.Size(51, 17)
        Me.ancienidtypeassociation.TabIndex = 5
        Me.ancienidtypeassociation.Text = "Label3"


        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type"


        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(189, 125)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(406, 30)
        Me.TextBox4.TabIndex = 6


        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 400)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.ancienidtypeassociation)
        Me.Controls.Add(Me.enregistrer2)
        Me.Controls.Add(Me.TextBox0)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.Text = "typeassociations_ajt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox0 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents enregistrer2 As System.Windows.Forms.Button
    Friend WithEvents ancienidtypeassociation As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
End Class
