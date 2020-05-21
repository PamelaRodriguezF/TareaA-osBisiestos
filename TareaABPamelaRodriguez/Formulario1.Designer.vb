<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BotonContinuar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextoNombre = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BotonContinuar
        '
        Me.BotonContinuar.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonContinuar.Location = New System.Drawing.Point(129, 199)
        Me.BotonContinuar.Name = "BotonContinuar"
        Me.BotonContinuar.Size = New System.Drawing.Size(120, 40)
        Me.BotonContinuar.TabIndex = 1
        Me.BotonContinuar.Text = "Continuar"
        Me.BotonContinuar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Por Favor Ingrese Su Nombre"
        '
        'TextoNombre
        '
        Me.TextoNombre.Location = New System.Drawing.Point(119, 152)
        Me.TextoNombre.Name = "TextoNombre"
        Me.TextoNombre.Size = New System.Drawing.Size(145, 20)
        Me.TextoNombre.TabIndex = 4
        '
        'Formulario1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.TextoNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BotonContinuar)
        Me.IsMdiContainer = True
        Me.Name = "Formulario1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programa "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BotonContinuar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextoNombre As TextBox
End Class
