<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumerologia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNumerologia))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lklCopiar = New System.Windows.Forms.LinkLabel()
        Me.lblNumeroFinal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrediccion = New System.Windows.Forms.TextBox()
        Me.bgPanel = New System.Windows.Forms.Panel()
        Me.lblSigno = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.bgPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 124)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lato Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(359, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Escribe tu fecha de nacimiento para conocer tu número"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lato", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(404, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "CALCULAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lato Thin", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(274, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Año"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lato Thin", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(150, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato Thin", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Dia"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownHeight = 110
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Font = New System.Drawing.Font("Lato", 12.0!)
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.IntegralHeight = False
        Me.ComboBox3.Location = New System.Drawing.Point(277, 72)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 27)
        Me.ComboBox3.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownHeight = 110
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Lato", 12.0!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.IntegralHeight = False
        Me.ComboBox2.Location = New System.Drawing.Point(150, 72)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 27)
        Me.ComboBox2.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownHeight = 110
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IntegralHeight = False
        Me.ComboBox1.Location = New System.Drawing.Point(23, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 27)
        Me.ComboBox1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lklCopiar)
        Me.Panel2.Controls.Add(Me.lblNumeroFinal)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtPrediccion)
        Me.Panel2.Location = New System.Drawing.Point(12, 206)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(545, 287)
        Me.Panel2.TabIndex = 1
        '
        'lklCopiar
        '
        Me.lklCopiar.BackColor = System.Drawing.Color.Transparent
        Me.lklCopiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lklCopiar.Font = New System.Drawing.Font("Lato", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lklCopiar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lklCopiar.LinkColor = System.Drawing.Color.DarkGoldenrod
        Me.lklCopiar.Location = New System.Drawing.Point(431, 40)
        Me.lklCopiar.Name = "lklCopiar"
        Me.lklCopiar.Size = New System.Drawing.Size(94, 19)
        Me.lklCopiar.TabIndex = 5
        Me.lklCopiar.TabStop = True
        Me.lklCopiar.Text = "COPIAR"
        Me.lklCopiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNumeroFinal
        '
        Me.lblNumeroFinal.AutoSize = True
        Me.lblNumeroFinal.BackColor = System.Drawing.Color.Transparent
        Me.lblNumeroFinal.Font = New System.Drawing.Font("Lato", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroFinal.ForeColor = System.Drawing.Color.Green
        Me.lblNumeroFinal.Location = New System.Drawing.Point(221, 10)
        Me.lblNumeroFinal.Name = "lblNumeroFinal"
        Me.lblNumeroFinal.Size = New System.Drawing.Size(82, 42)
        Me.lblNumeroFinal.TabIndex = 4
        Me.lblNumeroFinal.Text = "????"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lato Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label5.Location = New System.Drawing.Point(17, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 33)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Tu número es el:"
        '
        'txtPrediccion
        '
        Me.txtPrediccion.BackColor = System.Drawing.Color.White
        Me.txtPrediccion.Font = New System.Drawing.Font("Lato Light", 14.25!)
        Me.txtPrediccion.Location = New System.Drawing.Point(23, 62)
        Me.txtPrediccion.Multiline = True
        Me.txtPrediccion.Name = "txtPrediccion"
        Me.txtPrediccion.ReadOnly = True
        Me.txtPrediccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPrediccion.Size = New System.Drawing.Size(502, 204)
        Me.txtPrediccion.TabIndex = 2
        '
        'bgPanel
        '
        Me.bgPanel.Controls.Add(Me.lblSigno)
        Me.bgPanel.Controls.Add(Me.Panel1)
        Me.bgPanel.Controls.Add(Me.Panel2)
        Me.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bgPanel.Location = New System.Drawing.Point(0, 0)
        Me.bgPanel.Name = "bgPanel"
        Me.bgPanel.Size = New System.Drawing.Size(570, 508)
        Me.bgPanel.TabIndex = 2
        '
        'lblSigno
        '
        Me.lblSigno.AutoSize = True
        Me.lblSigno.BackColor = System.Drawing.Color.Transparent
        Me.lblSigno.Font = New System.Drawing.Font("Lato", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSigno.ForeColor = System.Drawing.Color.Gold
        Me.lblSigno.Location = New System.Drawing.Point(12, 9)
        Me.lblSigno.Name = "lblSigno"
        Me.lblSigno.Size = New System.Drawing.Size(425, 42)
        Me.lblSigno.TabIndex = 16
        Me.lblSigno.Text = "Numerología de la Semana" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'frmNumerologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 508)
        Me.Controls.Add(Me.bgPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNumerologia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Numerología de la semana"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.bgPanel.ResumeLayout(False)
        Me.bgPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPrediccion As TextBox
    Friend WithEvents bgPanel As Panel
    Friend WithEvents lblSigno As Label
    Friend WithEvents lblNumeroFinal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lklCopiar As LinkLabel
    Friend WithEvents Timer1 As Timer
End Class
