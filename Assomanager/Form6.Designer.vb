<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Ll = New System.Windows.Forms.Label()
        Me.enregistrer3 = New System.Windows.Forms.Button()
        Me.label10 = New System.Windows.Forms.Label()
        Me.L = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()


        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(189, 64)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(406, 30)
        Me.TextBox10.TabIndex = 3


        Me.Ll.AutoSize = True
        Me.Ll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ll.Location = New System.Drawing.Point(25, 125)
        Me.Ll.Name = "Ll"
        Me.Ll.Size = New System.Drawing.Size(109, 25)
        Me.Ll.TabIndex = 2
        Me.Ll.Text = "Valeur"


        Me.enregistrer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enregistrer3.Location = New System.Drawing.Point(50, 196)
        Me.enregistrer3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.enregistrer3.Name = "enregistrer3"
        Me.enregistrer3.Size = New System.Drawing.Size(146, 52)
        Me.enregistrer3.TabIndex = 4
        Me.enregistrer3.Text = "Ajouter"
        Me.enregistrer3.UseVisualStyleBackColor = True


        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(691, 19)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(51, 17)
        Me.label10.TabIndex = 5
        Me.label10.Text = "Label3"


        Me.L.AutoSize = True
        Me.L.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L.Location = New System.Drawing.Point(25, 64)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(57, 25)
        Me.L.TabIndex = 0
        Me.L.Text = "Clé"


        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(189, 125)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(406, 30)
        Me.TextBox11.TabIndex = 6


        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(225, 196)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 52)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True


        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 400)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.enregistrer3)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.Ll)
        Me.Controls.Add(Me.L)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form6"
        Me.Text = "Gestion des paramètres"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Ll As System.Windows.Forms.Label
    Friend WithEvents enregistrer3 As System.Windows.Forms.Button
    Friend WithEvents label10 As System.Windows.Forms.Label
    Friend WithEvents L As System.Windows.Forms.Label
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
