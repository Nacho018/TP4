<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticuloForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Id = New System.Windows.Forms.Label()
        Me.Descripcion = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.IdRubros = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Id
        '
        Me.Id.AutoSize = True
        Me.Id.Location = New System.Drawing.Point(177, 41)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(16, 13)
        Me.Id.TabIndex = 0
        Me.Id.Text = "Id"
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Location = New System.Drawing.Point(130, 81)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.Descripcion.TabIndex = 1
        Me.Descripcion.Text = "Descripcion"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(199, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(106, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(199, 78)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(106, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(169, 181)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(88, 27)
        Me.Aceptar.TabIndex = 4
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(284, 181)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(83, 27)
        Me.Cancelar.TabIndex = 5
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'IdRubros
        '
        Me.IdRubros.AutoSize = True
        Me.IdRubros.Location = New System.Drawing.Point(143, 122)
        Me.IdRubros.Name = "IdRubros"
        Me.IdRubros.Size = New System.Drawing.Size(50, 13)
        Me.IdRubros.TabIndex = 6
        Me.IdRubros.Text = "IdRubros"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(199, 119)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(106, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'ArticuloForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 261)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.IdRubros)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.Id)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ArticuloForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArticuloForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Id As Label
    Friend WithEvents Descripcion As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Aceptar As Button
    Friend WithEvents Cancelar As Button
    Friend WithEvents IdRubros As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
