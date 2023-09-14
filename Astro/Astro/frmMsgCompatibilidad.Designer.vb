<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsgCompatibilidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsgCompatibilidad))
        Me.bgPanel = New System.Windows.Forms.Panel()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHoroscopo = New System.Windows.Forms.TextBox()
        Me.pbComp = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lklCopiar = New System.Windows.Forms.LinkLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bgPanel.SuspendLayout()
        CType(Me.pbComp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bgPanel
        '
        Me.bgPanel.Controls.Add(Me.lklCopiar)
        Me.bgPanel.Controls.Add(Me.lblClose)
        Me.bgPanel.Controls.Add(Me.Label2)
        Me.bgPanel.Controls.Add(Me.txtHoroscopo)
        Me.bgPanel.Controls.Add(Me.pbComp)
        Me.bgPanel.Controls.Add(Me.PictureBox1)
        Me.bgPanel.Controls.Add(Me.PictureBox2)
        Me.bgPanel.Controls.Add(Me.Label1)
        Me.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bgPanel.Location = New System.Drawing.Point(0, 0)
        Me.bgPanel.Name = "bgPanel"
        Me.bgPanel.Size = New System.Drawing.Size(558, 454)
        Me.bgPanel.TabIndex = 27
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Transparent
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.Gold
        Me.lblClose.Location = New System.Drawing.Point(530, 9)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(20, 20)
        Me.lblClose.TabIndex = 2
        Me.lblClose.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lato Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 33)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Compatibilidad"
        '
        'txtHoroscopo
        '
        Me.txtHoroscopo.BackColor = System.Drawing.Color.White
        Me.txtHoroscopo.Font = New System.Drawing.Font("Lato Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoroscopo.HideSelection = False
        Me.txtHoroscopo.Location = New System.Drawing.Point(12, 222)
        Me.txtHoroscopo.Multiline = True
        Me.txtHoroscopo.Name = "txtHoroscopo"
        Me.txtHoroscopo.ReadOnly = True
        Me.txtHoroscopo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHoroscopo.ShortcutsEnabled = False
        Me.txtHoroscopo.Size = New System.Drawing.Size(532, 216)
        Me.txtHoroscopo.TabIndex = 4
        '
        'pbComp
        '
        Me.pbComp.BackColor = System.Drawing.Color.Transparent
        Me.pbComp.Location = New System.Drawing.Point(247, 51)
        Me.pbComp.Name = "pbComp"
        Me.pbComp.Size = New System.Drawing.Size(64, 64)
        Me.pbComp.TabIndex = 26
        Me.pbComp.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(90, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(318, 54)
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
        Me.Label1.Location = New System.Drawing.Point(261, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "+"
        '
        'lklCopiar
        '
        Me.lklCopiar.BackColor = System.Drawing.Color.Transparent
        Me.lklCopiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lklCopiar.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklCopiar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lklCopiar.LinkColor = System.Drawing.Color.Gold
        Me.lklCopiar.Location = New System.Drawing.Point(450, 200)
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
        'frmMsgCompatibilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 454)
        Me.Controls.Add(Me.bgPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMsgCompatibilidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmMsgCompatibilidad"
        Me.TopMost = True
        Me.bgPanel.ResumeLayout(False)
        Me.bgPanel.PerformLayout()
        CType(Me.pbComp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bgPanel As Panel
    Friend WithEvents pbComp As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHoroscopo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents lklCopiar As LinkLabel
    Friend WithEvents Timer1 As Timer
End Class
