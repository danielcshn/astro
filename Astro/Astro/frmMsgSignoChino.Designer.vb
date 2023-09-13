<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsgSignoChino
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsgSignoChino))
        Me.pbSignoChino = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSignoChino = New System.Windows.Forms.Label()
        Me.ilSignosChino = New System.Windows.Forms.ImageList(Me.components)
        Me.bgPanel = New System.Windows.Forms.Panel()
        CType(Me.pbSignoChino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bgPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbSignoChino
        '
        Me.pbSignoChino.BackColor = System.Drawing.Color.Transparent
        Me.pbSignoChino.Location = New System.Drawing.Point(13, 14)
        Me.pbSignoChino.Name = "pbSignoChino"
        Me.pbSignoChino.Size = New System.Drawing.Size(130, 130)
        Me.pbSignoChino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbSignoChino.TabIndex = 0
        Me.pbSignoChino.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lato Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(149, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tu signo es:"
        '
        'lblSignoChino
        '
        Me.lblSignoChino.AutoSize = True
        Me.lblSignoChino.BackColor = System.Drawing.Color.Transparent
        Me.lblSignoChino.Font = New System.Drawing.Font("Lato", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignoChino.ForeColor = System.Drawing.Color.Gold
        Me.lblSignoChino.Location = New System.Drawing.Point(149, 76)
        Me.lblSignoChino.Name = "lblSignoChino"
        Me.lblSignoChino.Size = New System.Drawing.Size(82, 42)
        Me.lblSignoChino.TabIndex = 2
        Me.lblSignoChino.Text = "????"
        '
        'ilSignosChino
        '
        Me.ilSignosChino.ImageStream = CType(resources.GetObject("ilSignosChino.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilSignosChino.TransparentColor = System.Drawing.Color.Transparent
        Me.ilSignosChino.Images.SetKeyName(0, "cerdo-pro_100.png")
        Me.ilSignosChino.Images.SetKeyName(1, "gallo-pro_100.png")
        Me.ilSignosChino.Images.SetKeyName(2, "perro-pro_100.png")
        Me.ilSignosChino.Images.SetKeyName(3, "mono-pro_100.png")
        Me.ilSignosChino.Images.SetKeyName(4, "cabra-pro_100.png")
        Me.ilSignosChino.Images.SetKeyName(5, "serpiente-pro_100.png")
        Me.ilSignosChino.Images.SetKeyName(6, "caballo-pro_100.png")
        Me.ilSignosChino.Images.SetKeyName(7, "dragon-pro_100.png")
        Me.ilSignosChino.Images.SetKeyName(8, "conejo-pro_100.png")
        Me.ilSignosChino.Images.SetKeyName(9, "buey-pro_100.png")
        Me.ilSignosChino.Images.SetKeyName(10, "tigre-pro_100.png")
        Me.ilSignosChino.Images.SetKeyName(11, "rata-pro_100.png")
        '
        'bgPanel
        '
        Me.bgPanel.Controls.Add(Me.pbSignoChino)
        Me.bgPanel.Controls.Add(Me.lblSignoChino)
        Me.bgPanel.Controls.Add(Me.Label1)
        Me.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bgPanel.Location = New System.Drawing.Point(0, 0)
        Me.bgPanel.Name = "bgPanel"
        Me.bgPanel.Size = New System.Drawing.Size(425, 159)
        Me.bgPanel.TabIndex = 3
        '
        'frmMsgSignoChino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(425, 159)
        Me.Controls.Add(Me.bgPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsgSignoChino"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMsgSignoChino"
        Me.TopMost = True
        CType(Me.pbSignoChino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bgPanel.ResumeLayout(False)
        Me.bgPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbSignoChino As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSignoChino As Label
    Friend WithEvents ilSignosChino As ImageList
    Friend WithEvents bgPanel As Panel
End Class
