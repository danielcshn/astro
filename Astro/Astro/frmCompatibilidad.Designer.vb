<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompatibilidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompatibilidad))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lklAries = New System.Windows.Forms.LinkLabel()
        Me.lklTauro = New System.Windows.Forms.LinkLabel()
        Me.lklGeminis = New System.Windows.Forms.LinkLabel()
        Me.lklCancer = New System.Windows.Forms.LinkLabel()
        Me.lklLeo = New System.Windows.Forms.LinkLabel()
        Me.lklVirgo = New System.Windows.Forms.LinkLabel()
        Me.lklLibra = New System.Windows.Forms.LinkLabel()
        Me.lklEscorpio = New System.Windows.Forms.LinkLabel()
        Me.lklSagitario = New System.Windows.Forms.LinkLabel()
        Me.lklCapricornio = New System.Windows.Forms.LinkLabel()
        Me.lklAcuario = New System.Windows.Forms.LinkLabel()
        Me.lklPiscis = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.bgPanel = New System.Windows.Forms.Panel()
        Me.pbComp = New System.Windows.Forms.PictureBox()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.bgPanel.SuspendLayout()
        CType(Me.pbComp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.White
        Me.ImageList1.Images.SetKeyName(0, "cancer-pro_256.png")
        Me.ImageList1.Images.SetKeyName(1, "virgo-pro_256.png")
        Me.ImageList1.Images.SetKeyName(2, "escorpio-pro_256.png")
        Me.ImageList1.Images.SetKeyName(3, "geminis-pro_256.png")
        Me.ImageList1.Images.SetKeyName(4, "capricornio-pro_256.png")
        Me.ImageList1.Images.SetKeyName(5, "acuario-pro_256.png")
        Me.ImageList1.Images.SetKeyName(6, "leo-pro_256.png")
        Me.ImageList1.Images.SetKeyName(7, "aries-pro_256.png")
        Me.ImageList1.Images.SetKeyName(8, "tauro-pro_256.png")
        Me.ImageList1.Images.SetKeyName(9, "sagitario-pro_256.png")
        Me.ImageList1.Images.SetKeyName(10, "libra-pro_256.png")
        Me.ImageList1.Images.SetKeyName(11, "piscis-pro_256.png")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(39, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(267, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(210, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "+"
        '
        'lklAries
        '
        Me.lklAries.AutoSize = True
        Me.lklAries.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklAries.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lklAries.Location = New System.Drawing.Point(15, 14)
        Me.lklAries.Name = "lklAries"
        Me.lklAries.Size = New System.Drawing.Size(52, 19)
        Me.lklAries.TabIndex = 3
        Me.lklAries.TabStop = True
        Me.lklAries.Text = "ARIES"
        '
        'lklTauro
        '
        Me.lklTauro.AutoSize = True
        Me.lklTauro.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklTauro.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lklTauro.Location = New System.Drawing.Point(92, 14)
        Me.lklTauro.Name = "lklTauro"
        Me.lklTauro.Size = New System.Drawing.Size(63, 19)
        Me.lklTauro.TabIndex = 4
        Me.lklTauro.TabStop = True
        Me.lklTauro.Text = "TAURO"
        '
        'lklGeminis
        '
        Me.lklGeminis.AutoSize = True
        Me.lklGeminis.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklGeminis.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lklGeminis.Location = New System.Drawing.Point(180, 14)
        Me.lklGeminis.Name = "lklGeminis"
        Me.lklGeminis.Size = New System.Drawing.Size(74, 19)
        Me.lklGeminis.TabIndex = 5
        Me.lklGeminis.TabStop = True
        Me.lklGeminis.Text = "GÉMINIS"
        '
        'lklCancer
        '
        Me.lklCancer.AutoSize = True
        Me.lklCancer.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklCancer.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lklCancer.Location = New System.Drawing.Point(279, 14)
        Me.lklCancer.Name = "lklCancer"
        Me.lklCancer.Size = New System.Drawing.Size(73, 19)
        Me.lklCancer.TabIndex = 6
        Me.lklCancer.TabStop = True
        Me.lklCancer.Text = "CÁNCER"
        '
        'lklLeo
        '
        Me.lklLeo.AutoSize = True
        Me.lklLeo.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklLeo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lklLeo.Location = New System.Drawing.Point(377, 14)
        Me.lklLeo.Name = "lklLeo"
        Me.lklLeo.Size = New System.Drawing.Size(39, 19)
        Me.lklLeo.TabIndex = 7
        Me.lklLeo.TabStop = True
        Me.lklLeo.Text = "LEO"
        '
        'lklVirgo
        '
        Me.lklVirgo.AutoSize = True
        Me.lklVirgo.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklVirgo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lklVirgo.Location = New System.Drawing.Point(35, 46)
        Me.lklVirgo.Name = "lklVirgo"
        Me.lklVirgo.Size = New System.Drawing.Size(59, 19)
        Me.lklVirgo.TabIndex = 8
        Me.lklVirgo.TabStop = True
        Me.lklVirgo.Text = "VIRGO"
        '
        'lklLibra
        '
        Me.lklLibra.AutoSize = True
        Me.lklLibra.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklLibra.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lklLibra.Location = New System.Drawing.Point(119, 46)
        Me.lklLibra.Name = "lklLibra"
        Me.lklLibra.Size = New System.Drawing.Size(52, 19)
        Me.lklLibra.TabIndex = 9
        Me.lklLibra.TabStop = True
        Me.lklLibra.Text = "LIBRA"
        '
        'lklEscorpio
        '
        Me.lklEscorpio.AutoSize = True
        Me.lklEscorpio.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklEscorpio.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lklEscorpio.Location = New System.Drawing.Point(196, 46)
        Me.lklEscorpio.Name = "lklEscorpio"
        Me.lklEscorpio.Size = New System.Drawing.Size(88, 19)
        Me.lklEscorpio.TabIndex = 10
        Me.lklEscorpio.TabStop = True
        Me.lklEscorpio.Text = "ESCORPIO"
        '
        'lklSagitario
        '
        Me.lklSagitario.AutoSize = True
        Me.lklSagitario.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklSagitario.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lklSagitario.Location = New System.Drawing.Point(309, 46)
        Me.lklSagitario.Name = "lklSagitario"
        Me.lklSagitario.Size = New System.Drawing.Size(91, 19)
        Me.lklSagitario.TabIndex = 11
        Me.lklSagitario.TabStop = True
        Me.lklSagitario.Text = "SAGITARIO"
        '
        'lklCapricornio
        '
        Me.lklCapricornio.AutoSize = True
        Me.lklCapricornio.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklCapricornio.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lklCapricornio.Location = New System.Drawing.Point(64, 79)
        Me.lklCapricornio.Name = "lklCapricornio"
        Me.lklCapricornio.Size = New System.Drawing.Size(118, 19)
        Me.lklCapricornio.TabIndex = 12
        Me.lklCapricornio.TabStop = True
        Me.lklCapricornio.Text = "CAPRICORNIO"
        '
        'lklAcuario
        '
        Me.lklAcuario.AutoSize = True
        Me.lklAcuario.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklAcuario.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lklAcuario.Location = New System.Drawing.Point(207, 79)
        Me.lklAcuario.Name = "lklAcuario"
        Me.lklAcuario.Size = New System.Drawing.Size(81, 19)
        Me.lklAcuario.TabIndex = 13
        Me.lklAcuario.TabStop = True
        Me.lklAcuario.Text = "ACUARIO"
        '
        'lklPiscis
        '
        Me.lklPiscis.AutoSize = True
        Me.lklPiscis.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklPiscis.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lklPiscis.Location = New System.Drawing.Point(313, 79)
        Me.lklPiscis.Name = "lklPiscis"
        Me.lklPiscis.Size = New System.Drawing.Size(56, 19)
        Me.lklPiscis.TabIndex = 14
        Me.lklPiscis.TabStop = True
        Me.lklPiscis.Text = "PISCIS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lato Heavy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "|"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lato Heavy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(161, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "|"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lato Heavy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(260, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "|"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lato Heavy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(358, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 19)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "|"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lato Heavy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(100, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 19)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "|"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lato Heavy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(177, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 19)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "|"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lato Heavy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(290, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 19)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "|"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lato Heavy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(188, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 19)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "|"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lato Heavy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(294, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 19)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "|"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lklAries)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lklTauro)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lklGeminis)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lklCancer)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lklLeo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lklVirgo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lklLibra)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lklEscorpio)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lklSagitario)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lklCapricornio)
        Me.Panel1.Controls.Add(Me.lklPiscis)
        Me.Panel1.Controls.Add(Me.lklAcuario)
        Me.Panel1.Location = New System.Drawing.Point(12, 171)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 115)
        Me.Panel1.TabIndex = 24
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(195, 142)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(66, 23)
        Me.btnVer.TabIndex = 25
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        Me.btnVer.Visible = False
        '
        'bgPanel
        '
        Me.bgPanel.Controls.Add(Me.pbComp)
        Me.bgPanel.Controls.Add(Me.PictureBox1)
        Me.bgPanel.Controls.Add(Me.btnVer)
        Me.bgPanel.Controls.Add(Me.PictureBox2)
        Me.bgPanel.Controls.Add(Me.Panel1)
        Me.bgPanel.Controls.Add(Me.Label1)
        Me.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bgPanel.Location = New System.Drawing.Point(0, 0)
        Me.bgPanel.Name = "bgPanel"
        Me.bgPanel.Size = New System.Drawing.Size(456, 300)
        Me.bgPanel.TabIndex = 26
        '
        'pbComp
        '
        Me.pbComp.BackColor = System.Drawing.Color.Transparent
        Me.pbComp.Location = New System.Drawing.Point(196, 12)
        Me.pbComp.Name = "pbComp"
        Me.pbComp.Size = New System.Drawing.Size(64, 64)
        Me.pbComp.TabIndex = 26
        Me.pbComp.TabStop = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "corazon_64.png")
        Me.ImageList2.Images.SetKeyName(1, "neutral-64.png")
        Me.ImageList2.Images.SetKeyName(2, "x-64.png")
        '
        'frmCompatibilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 300)
        Me.Controls.Add(Me.bgPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompatibilidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compatibilidad entre signos"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.bgPanel.ResumeLayout(False)
        Me.bgPanel.PerformLayout()
        CType(Me.pbComp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lklAries As LinkLabel
    Friend WithEvents lklTauro As LinkLabel
    Friend WithEvents lklGeminis As LinkLabel
    Friend WithEvents lklCancer As LinkLabel
    Friend WithEvents lklLeo As LinkLabel
    Friend WithEvents lklVirgo As LinkLabel
    Friend WithEvents lklLibra As LinkLabel
    Friend WithEvents lklEscorpio As LinkLabel
    Friend WithEvents lklSagitario As LinkLabel
    Friend WithEvents lklCapricornio As LinkLabel
    Friend WithEvents lklAcuario As LinkLabel
    Friend WithEvents lklPiscis As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVer As Button
    Friend WithEvents bgPanel As Panel
    Friend WithEvents pbComp As PictureBox
    Friend WithEvents ImageList2 As ImageList
End Class
