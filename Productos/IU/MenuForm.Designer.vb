<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.RubrosButton = New System.Windows.Forms.ToolStripButton()
        Me.ArticulosButton = New System.Windows.Forms.ToolStripButton()
        Me.SalirButton = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.YellowGreen
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 89)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 27.25!)
        Me.Label1.Location = New System.Drawing.Point(276, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Productos"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.Highlight
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RubrosButton, Me.ArticulosButton, Me.SalirButton})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 89)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1024, 53)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'RubrosButton
        '
        Me.RubrosButton.Image = CType(resources.GetObject("RubrosButton.Image"), System.Drawing.Image)
        Me.RubrosButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RubrosButton.Name = "RubrosButton"
        Me.RubrosButton.Size = New System.Drawing.Size(48, 50)
        Me.RubrosButton.Text = "Rubros"
        Me.RubrosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ArticulosButton
        '
        Me.ArticulosButton.Image = CType(resources.GetObject("ArticulosButton.Image"), System.Drawing.Image)
        Me.ArticulosButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ArticulosButton.Name = "ArticulosButton"
        Me.ArticulosButton.Size = New System.Drawing.Size(58, 50)
        Me.ArticulosButton.Text = "Articulos"
        Me.ArticulosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'SalirButton
        '
        Me.SalirButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirButton.Image = CType(resources.GetObject("SalirButton.Image"), System.Drawing.Image)
        Me.SalirButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalirButton.Name = "SalirButton"
        Me.SalirButton.Size = New System.Drawing.Size(44, 50)
        Me.SalirButton.Text = "Salir"
        Me.SalirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1024, 562)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "MenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents RubrosButton As ToolStripButton
    Friend WithEvents ArticulosButton As ToolStripButton
    Friend WithEvents SalirButton As ToolStripButton
End Class
