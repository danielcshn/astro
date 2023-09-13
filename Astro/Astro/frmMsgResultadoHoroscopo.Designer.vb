<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMsgResultadoHoroscopo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsgResultadoHoroscopo))
        Me.bgPanel = New System.Windows.Forms.Panel()
        Me.txtHoroscopo = New System.Windows.Forms.TextBox()
        Me.pbSigno = New System.Windows.Forms.PictureBox()
        Me.lblSigno = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.ilSignos = New System.Windows.Forms.ImageList(Me.components)
        Me.lklCopiar = New System.Windows.Forms.LinkLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bgPanel.SuspendLayout()
        CType(Me.pbSigno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bgPanel
        '
        Me.bgPanel.BackColor = System.Drawing.Color.White
        Me.bgPanel.Controls.Add(Me.lklCopiar)
        Me.bgPanel.Controls.Add(Me.lblClose)
        Me.bgPanel.Controls.Add(Me.pbSigno)
        Me.bgPanel.Controls.Add(Me.lblSigno)
        Me.bgPanel.Controls.Add(Me.Label2)
        Me.bgPanel.Controls.Add(Me.txtHoroscopo)
        Me.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bgPanel.Location = New System.Drawing.Point(0, 0)
        Me.bgPanel.Name = "bgPanel"
        Me.bgPanel.Size = New System.Drawing.Size(556, 348)
        Me.bgPanel.TabIndex = 16
        '
        'txtHoroscopo
        '
        Me.txtHoroscopo.BackColor = System.Drawing.Color.White
        Me.txtHoroscopo.Font = New System.Drawing.Font("Lato Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoroscopo.HideSelection = False
        Me.txtHoroscopo.Location = New System.Drawing.Point(12, 118)
        Me.txtHoroscopo.Multiline = True
        Me.txtHoroscopo.Name = "txtHoroscopo"
        Me.txtHoroscopo.ReadOnly = True
        Me.txtHoroscopo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHoroscopo.ShortcutsEnabled = False
        Me.txtHoroscopo.Size = New System.Drawing.Size(532, 216)
        Me.txtHoroscopo.TabIndex = 20
        '
        'pbSigno
        '
        Me.pbSigno.BackColor = System.Drawing.Color.Transparent
        Me.pbSigno.Location = New System.Drawing.Point(12, 12)
        Me.pbSigno.Name = "pbSigno"
        Me.pbSigno.Size = New System.Drawing.Size(100, 100)
        Me.pbSigno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbSigno.TabIndex = 3
        Me.pbSigno.TabStop = False
        '
        'lblSigno
        '
        Me.lblSigno.AutoSize = True
        Me.lblSigno.BackColor = System.Drawing.Color.Transparent
        Me.lblSigno.Font = New System.Drawing.Font("Lato", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSigno.ForeColor = System.Drawing.Color.Gold
        Me.lblSigno.Location = New System.Drawing.Point(118, 58)
        Me.lblSigno.Name = "lblSigno"
        Me.lblSigno.Size = New System.Drawing.Size(82, 42)
        Me.lblSigno.TabIndex = 5
        Me.lblSigno.Text = "????"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lato Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label2.Location = New System.Drawing.Point(118, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Horoscopo:"
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.Gold
        Me.lblClose.Location = New System.Drawing.Point(524, 12)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(20, 20)
        Me.lblClose.TabIndex = 6
        Me.lblClose.Text = "X"
        '
        'ilSignos
        '
        Me.ilSignos.ImageStream = CType(resources.GetObject("ilSignos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilSignos.TransparentColor = System.Drawing.Color.Transparent
        Me.ilSignos.Images.SetKeyName(0, "piscis-pro_100.png")
        Me.ilSignos.Images.SetKeyName(1, "libra-pro_100.png")
        Me.ilSignos.Images.SetKeyName(2, "cancer-pro_100.png")
        Me.ilSignos.Images.SetKeyName(3, "sagitario-pro_100.png")
        Me.ilSignos.Images.SetKeyName(4, "tauro-pro_100.png")
        Me.ilSignos.Images.SetKeyName(5, "aries-pro_100.png")
        Me.ilSignos.Images.SetKeyName(6, "leon-pro_100.png")
        Me.ilSignos.Images.SetKeyName(7, "acuario-pro_100.png")
        Me.ilSignos.Images.SetKeyName(8, "capricornio-pro_100.png")
        Me.ilSignos.Images.SetKeyName(9, "geminis-pro_100.png")
        Me.ilSignos.Images.SetKeyName(10, "escorpio-pro_100.png")
        Me.ilSignos.Images.SetKeyName(11, "virgo-pro_100.png")
        Me.ilSignos.Images.SetKeyName(12, "cerdo-pro_100.png")
        Me.ilSignos.Images.SetKeyName(13, "gallo-pro_100.png")
        Me.ilSignos.Images.SetKeyName(14, "perro-pro_100.png")
        Me.ilSignos.Images.SetKeyName(15, "mono-pro_100.png")
        Me.ilSignos.Images.SetKeyName(16, "cabra-pro_100.png")
        Me.ilSignos.Images.SetKeyName(17, "serpiente-pro_100.png")
        Me.ilSignos.Images.SetKeyName(18, "caballo-pro_100.png")
        Me.ilSignos.Images.SetKeyName(19, "dragon-pro_100.png")
        Me.ilSignos.Images.SetKeyName(20, "conejo-pro_100.png")
        Me.ilSignos.Images.SetKeyName(21, "buey-pro_100.png")
        Me.ilSignos.Images.SetKeyName(22, "tigre-pro_100.png")
        Me.ilSignos.Images.SetKeyName(23, "rata-pro_100.png")
        '
        'lklCopiar
        '
        Me.lklCopiar.BackColor = System.Drawing.Color.Transparent
        Me.lklCopiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lklCopiar.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklCopiar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lklCopiar.LinkColor = System.Drawing.Color.Gold
        Me.lklCopiar.Location = New System.Drawing.Point(450, 96)
        Me.lklCopiar.Name = "lklCopiar"
        Me.lklCopiar.Size = New System.Drawing.Size(94, 19)
        Me.lklCopiar.TabIndex = 1
        Me.lklCopiar.TabStop = True
        Me.lklCopiar.Text = "COPIAR"
        Me.lklCopiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmMsgResultadoHoroscopo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 348)
        Me.Controls.Add(Me.bgPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMsgResultadoHoroscopo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMsgResultadoHoroscopo"
        Me.TopMost = True
        Me.bgPanel.ResumeLayout(False)
        Me.bgPanel.PerformLayout()
        CType(Me.pbSigno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bgPanel As Panel
    Friend WithEvents txtHoroscopo As TextBox
    Friend WithEvents pbSigno As PictureBox
    Friend WithEvents lblSigno As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents ilSignos As ImageList
    Friend WithEvents lklCopiar As LinkLabel
    Friend WithEvents Timer1 As Timer
End Class
