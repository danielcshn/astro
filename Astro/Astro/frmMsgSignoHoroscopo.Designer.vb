<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsgSignoHoroscopo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsgSignoHoroscopo))
        Me.bgPanel = New System.Windows.Forms.Panel()
        Me.pbSignoHoroscopo = New System.Windows.Forms.PictureBox()
        Me.lblSignoChino = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ilSignosHoroscopo = New System.Windows.Forms.ImageList(Me.components)
        Me.bgPanel.SuspendLayout()
        CType(Me.pbSignoHoroscopo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bgPanel
        '
        Me.bgPanel.Controls.Add(Me.pbSignoHoroscopo)
        Me.bgPanel.Controls.Add(Me.lblSignoChino)
        Me.bgPanel.Controls.Add(Me.Label1)
        Me.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bgPanel.Location = New System.Drawing.Point(0, 0)
        Me.bgPanel.Name = "bgPanel"
        Me.bgPanel.Size = New System.Drawing.Size(425, 159)
        Me.bgPanel.TabIndex = 4
        '
        'pbSignoHoroscopo
        '
        Me.pbSignoHoroscopo.BackColor = System.Drawing.Color.Transparent
        Me.pbSignoHoroscopo.Location = New System.Drawing.Point(13, 14)
        Me.pbSignoHoroscopo.Name = "pbSignoHoroscopo"
        Me.pbSignoHoroscopo.Size = New System.Drawing.Size(130, 130)
        Me.pbSignoHoroscopo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbSignoHoroscopo.TabIndex = 0
        Me.pbSignoHoroscopo.TabStop = False
        '
        'lblSignoChino
        '
        Me.lblSignoChino.AutoSize = True
        Me.lblSignoChino.BackColor = System.Drawing.Color.Transparent
        Me.lblSignoChino.Font = New System.Drawing.Font("Lato", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignoChino.ForeColor = System.Drawing.Color.Gold
        Me.lblSignoChino.Location = New System.Drawing.Point(149, 76)
        Me.lblSignoChino.Name = "lblSignoChino"
        Me.lblSignoChino.Size = New System.Drawing.Size(34, 42)
        Me.lblSignoChino.TabIndex = 2
        Me.lblSignoChino.Text = "?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lato Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(149, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tu signo es:"
        '
        'ilSignosHoroscopo
        '
        Me.ilSignosHoroscopo.ImageStream = CType(resources.GetObject("ilSignosHoroscopo.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilSignosHoroscopo.TransparentColor = System.Drawing.Color.Transparent
        Me.ilSignosHoroscopo.Images.SetKeyName(0, "aries-pro_100.png")
        Me.ilSignosHoroscopo.Images.SetKeyName(1, "tauro-pro_100.png")
        Me.ilSignosHoroscopo.Images.SetKeyName(2, "geminis-pro_100.png")
        Me.ilSignosHoroscopo.Images.SetKeyName(3, "cancer-pro_100.png")
        Me.ilSignosHoroscopo.Images.SetKeyName(4, "leon-pro_100.png")
        Me.ilSignosHoroscopo.Images.SetKeyName(5, "virgo-pro_100.png")
        Me.ilSignosHoroscopo.Images.SetKeyName(6, "libra-pro_100.png")
        Me.ilSignosHoroscopo.Images.SetKeyName(7, "escorpion-pro_100.png")
        Me.ilSignosHoroscopo.Images.SetKeyName(8, "sagitario-pro_100.png")
        Me.ilSignosHoroscopo.Images.SetKeyName(9, "capricornio-pro_100.png")
        Me.ilSignosHoroscopo.Images.SetKeyName(10, "acuario-pro_100.png")
        Me.ilSignosHoroscopo.Images.SetKeyName(11, "piscis-pro_100.png")
        '
        'frmMsgSignoHoroscopo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 159)
        Me.Controls.Add(Me.bgPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsgSignoHoroscopo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMsgSignoHoroscopo"
        Me.TopMost = True
        Me.bgPanel.ResumeLayout(False)
        Me.bgPanel.PerformLayout()
        CType(Me.pbSignoHoroscopo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bgPanel As Panel
    Friend WithEvents pbSignoHoroscopo As PictureBox
    Friend WithEvents lblSignoChino As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ilSignosHoroscopo As ImageList
End Class
