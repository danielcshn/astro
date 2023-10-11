<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHoroscopo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoroscopo))
        Me.bgPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblSigno = New System.Windows.Forms.Label()
        Me.btnPiscis = New System.Windows.Forms.Button()
        Me.btnAcuario = New System.Windows.Forms.Button()
        Me.btnCapricornio = New System.Windows.Forms.Button()
        Me.btnSagitario = New System.Windows.Forms.Button()
        Me.btnEscorpio = New System.Windows.Forms.Button()
        Me.btnLibra = New System.Windows.Forms.Button()
        Me.btnVirgo = New System.Windows.Forms.Button()
        Me.btnLeo = New System.Windows.Forms.Button()
        Me.btnCancer = New System.Windows.Forms.Button()
        Me.btnGeminis = New System.Windows.Forms.Button()
        Me.btnTauro = New System.Windows.Forms.Button()
        Me.btnAries = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.bgPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bgPanel
        '
        Me.bgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bgPanel.Controls.Add(Me.Panel1)
        Me.bgPanel.Controls.Add(Me.lblSigno)
        Me.bgPanel.Controls.Add(Me.btnPiscis)
        Me.bgPanel.Controls.Add(Me.btnAcuario)
        Me.bgPanel.Controls.Add(Me.btnCapricornio)
        Me.bgPanel.Controls.Add(Me.btnSagitario)
        Me.bgPanel.Controls.Add(Me.btnEscorpio)
        Me.bgPanel.Controls.Add(Me.btnLibra)
        Me.bgPanel.Controls.Add(Me.btnVirgo)
        Me.bgPanel.Controls.Add(Me.btnLeo)
        Me.bgPanel.Controls.Add(Me.btnCancer)
        Me.bgPanel.Controls.Add(Me.btnGeminis)
        Me.bgPanel.Controls.Add(Me.btnTauro)
        Me.bgPanel.Controls.Add(Me.btnAries)
        Me.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bgPanel.Location = New System.Drawing.Point(0, 0)
        Me.bgPanel.Name = "bgPanel"
        Me.bgPanel.Size = New System.Drawing.Size(564, 528)
        Me.bgPanel.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnCalcular)
        Me.Panel1.Location = New System.Drawing.Point(284, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 91)
        Me.Panel1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lato Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Escribe tu fecha de nacimiento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para conocer tu signo"
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Lato", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(136, 46)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(119, 23)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "CONOCER"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblSigno
        '
        Me.lblSigno.AutoSize = True
        Me.lblSigno.BackColor = System.Drawing.Color.Transparent
        Me.lblSigno.Font = New System.Drawing.Font("Lato", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSigno.ForeColor = System.Drawing.Color.Gold
        Me.lblSigno.Location = New System.Drawing.Point(12, 9)
        Me.lblSigno.Name = "lblSigno"
        Me.lblSigno.Size = New System.Drawing.Size(195, 84)
        Me.lblSigno.TabIndex = 15
        Me.lblSigno.Text = "Horoscopo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del Zodiaco"
        '
        'btnPiscis
        '
        Me.btnPiscis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPiscis.Font = New System.Drawing.Font("Lato Light", 12.0!)
        Me.btnPiscis.ForeColor = System.Drawing.Color.Black
        Me.btnPiscis.Image = CType(resources.GetObject("btnPiscis.Image"), System.Drawing.Image)
        Me.btnPiscis.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPiscis.Location = New System.Drawing.Point(420, 381)
        Me.btnPiscis.Name = "btnPiscis"
        Me.btnPiscis.Size = New System.Drawing.Size(130, 130)
        Me.btnPiscis.TabIndex = 14
        Me.btnPiscis.Tag = ""
        Me.btnPiscis.Text = "PISCIS"
        Me.btnPiscis.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPiscis.UseCompatibleTextRendering = True
        Me.btnPiscis.UseVisualStyleBackColor = True
        '
        'btnAcuario
        '
        Me.btnAcuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAcuario.Font = New System.Drawing.Font("Lato Light", 12.0!)
        Me.btnAcuario.ForeColor = System.Drawing.Color.Black
        Me.btnAcuario.Image = CType(resources.GetObject("btnAcuario.Image"), System.Drawing.Image)
        Me.btnAcuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAcuario.Location = New System.Drawing.Point(284, 381)
        Me.btnAcuario.Name = "btnAcuario"
        Me.btnAcuario.Size = New System.Drawing.Size(130, 130)
        Me.btnAcuario.TabIndex = 13
        Me.btnAcuario.Tag = ""
        Me.btnAcuario.Text = "ACUARIO"
        Me.btnAcuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAcuario.UseCompatibleTextRendering = True
        Me.btnAcuario.UseVisualStyleBackColor = True
        '
        'btnCapricornio
        '
        Me.btnCapricornio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCapricornio.Font = New System.Drawing.Font("Lato Light", 12.0!)
        Me.btnCapricornio.ForeColor = System.Drawing.Color.Black
        Me.btnCapricornio.Image = CType(resources.GetObject("btnCapricornio.Image"), System.Drawing.Image)
        Me.btnCapricornio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCapricornio.Location = New System.Drawing.Point(148, 381)
        Me.btnCapricornio.Name = "btnCapricornio"
        Me.btnCapricornio.Size = New System.Drawing.Size(130, 130)
        Me.btnCapricornio.TabIndex = 12
        Me.btnCapricornio.Tag = ""
        Me.btnCapricornio.Text = "CAPRICORNIO"
        Me.btnCapricornio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCapricornio.UseCompatibleTextRendering = True
        Me.btnCapricornio.UseVisualStyleBackColor = True
        '
        'btnSagitario
        '
        Me.btnSagitario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSagitario.Font = New System.Drawing.Font("Lato Light", 12.0!)
        Me.btnSagitario.ForeColor = System.Drawing.Color.Black
        Me.btnSagitario.Image = CType(resources.GetObject("btnSagitario.Image"), System.Drawing.Image)
        Me.btnSagitario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSagitario.Location = New System.Drawing.Point(12, 381)
        Me.btnSagitario.Name = "btnSagitario"
        Me.btnSagitario.Size = New System.Drawing.Size(130, 130)
        Me.btnSagitario.TabIndex = 11
        Me.btnSagitario.Tag = ""
        Me.btnSagitario.Text = "SAGITARIO"
        Me.btnSagitario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSagitario.UseCompatibleTextRendering = True
        Me.btnSagitario.UseVisualStyleBackColor = True
        '
        'btnEscorpio
        '
        Me.btnEscorpio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEscorpio.Font = New System.Drawing.Font("Lato Light", 12.0!)
        Me.btnEscorpio.ForeColor = System.Drawing.Color.Black
        Me.btnEscorpio.Image = CType(resources.GetObject("btnEscorpio.Image"), System.Drawing.Image)
        Me.btnEscorpio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEscorpio.Location = New System.Drawing.Point(420, 245)
        Me.btnEscorpio.Name = "btnEscorpio"
        Me.btnEscorpio.Size = New System.Drawing.Size(130, 130)
        Me.btnEscorpio.TabIndex = 10
        Me.btnEscorpio.Tag = ""
        Me.btnEscorpio.Text = "ESCORPIO"
        Me.btnEscorpio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEscorpio.UseCompatibleTextRendering = True
        Me.btnEscorpio.UseVisualStyleBackColor = True
        '
        'btnLibra
        '
        Me.btnLibra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLibra.Font = New System.Drawing.Font("Lato Light", 12.0!)
        Me.btnLibra.ForeColor = System.Drawing.Color.Black
        Me.btnLibra.Image = CType(resources.GetObject("btnLibra.Image"), System.Drawing.Image)
        Me.btnLibra.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLibra.Location = New System.Drawing.Point(284, 245)
        Me.btnLibra.Name = "btnLibra"
        Me.btnLibra.Size = New System.Drawing.Size(130, 130)
        Me.btnLibra.TabIndex = 9
        Me.btnLibra.Tag = ""
        Me.btnLibra.Text = "LIBRA"
        Me.btnLibra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLibra.UseCompatibleTextRendering = True
        Me.btnLibra.UseVisualStyleBackColor = True
        '
        'btnVirgo
        '
        Me.btnVirgo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnVirgo.Font = New System.Drawing.Font("Lato Light", 12.0!)
        Me.btnVirgo.ForeColor = System.Drawing.Color.Black
        Me.btnVirgo.Image = CType(resources.GetObject("btnVirgo.Image"), System.Drawing.Image)
        Me.btnVirgo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVirgo.Location = New System.Drawing.Point(148, 245)
        Me.btnVirgo.Name = "btnVirgo"
        Me.btnVirgo.Size = New System.Drawing.Size(130, 130)
        Me.btnVirgo.TabIndex = 8
        Me.btnVirgo.Tag = ""
        Me.btnVirgo.Text = "VIRGO"
        Me.btnVirgo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVirgo.UseCompatibleTextRendering = True
        Me.btnVirgo.UseVisualStyleBackColor = True
        '
        'btnLeo
        '
        Me.btnLeo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLeo.Font = New System.Drawing.Font("Lato Light", 12.0!)
        Me.btnLeo.ForeColor = System.Drawing.Color.Black
        Me.btnLeo.Image = CType(resources.GetObject("btnLeo.Image"), System.Drawing.Image)
        Me.btnLeo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLeo.Location = New System.Drawing.Point(12, 245)
        Me.btnLeo.Name = "btnLeo"
        Me.btnLeo.Size = New System.Drawing.Size(130, 130)
        Me.btnLeo.TabIndex = 7
        Me.btnLeo.Tag = ""
        Me.btnLeo.Text = "LEO"
        Me.btnLeo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLeo.UseCompatibleTextRendering = True
        Me.btnLeo.UseVisualStyleBackColor = True
        '
        'btnCancer
        '
        Me.btnCancer.AutoSize = True
        Me.btnCancer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancer.Font = New System.Drawing.Font("Lato Light", 12.0!)
        Me.btnCancer.ForeColor = System.Drawing.Color.Black
        Me.btnCancer.Image = CType(resources.GetObject("btnCancer.Image"), System.Drawing.Image)
        Me.btnCancer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancer.Location = New System.Drawing.Point(420, 109)
        Me.btnCancer.Margin = New System.Windows.Forms.Padding(5)
        Me.btnCancer.Name = "btnCancer"
        Me.btnCancer.Size = New System.Drawing.Size(130, 130)
        Me.btnCancer.TabIndex = 6
        Me.btnCancer.Tag = ""
        Me.btnCancer.Text = "CANCER"
        Me.btnCancer.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancer.UseCompatibleTextRendering = True
        Me.btnCancer.UseVisualStyleBackColor = True
        '
        'btnGeminis
        '
        Me.btnGeminis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGeminis.Font = New System.Drawing.Font("Lato Light", 12.0!)
        Me.btnGeminis.ForeColor = System.Drawing.Color.Black
        Me.btnGeminis.Image = CType(resources.GetObject("btnGeminis.Image"), System.Drawing.Image)
        Me.btnGeminis.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGeminis.Location = New System.Drawing.Point(284, 109)
        Me.btnGeminis.Name = "btnGeminis"
        Me.btnGeminis.Size = New System.Drawing.Size(130, 130)
        Me.btnGeminis.TabIndex = 5
        Me.btnGeminis.Tag = ""
        Me.btnGeminis.Text = "GEMINIS"
        Me.btnGeminis.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGeminis.UseCompatibleTextRendering = True
        Me.btnGeminis.UseVisualStyleBackColor = True
        '
        'btnTauro
        '
        Me.btnTauro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTauro.Font = New System.Drawing.Font("Lato Light", 12.0!)
        Me.btnTauro.ForeColor = System.Drawing.Color.Black
        Me.btnTauro.Image = CType(resources.GetObject("btnTauro.Image"), System.Drawing.Image)
        Me.btnTauro.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTauro.Location = New System.Drawing.Point(148, 109)
        Me.btnTauro.Name = "btnTauro"
        Me.btnTauro.Size = New System.Drawing.Size(130, 130)
        Me.btnTauro.TabIndex = 4
        Me.btnTauro.Tag = ""
        Me.btnTauro.Text = "TAURO"
        Me.btnTauro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTauro.UseCompatibleTextRendering = True
        Me.btnTauro.UseVisualStyleBackColor = True
        '
        'btnAries
        '
        Me.btnAries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAries.Font = New System.Drawing.Font("Lato Light", 12.0!)
        Me.btnAries.ForeColor = System.Drawing.Color.Black
        Me.btnAries.Image = CType(resources.GetObject("btnAries.Image"), System.Drawing.Image)
        Me.btnAries.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAries.Location = New System.Drawing.Point(12, 109)
        Me.btnAries.Name = "btnAries"
        Me.btnAries.Size = New System.Drawing.Size(130, 130)
        Me.btnAries.TabIndex = 0
        Me.btnAries.Tag = ""
        Me.btnAries.Text = "ARIES"
        Me.btnAries.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAries.UseCompatibleTextRendering = True
        Me.btnAries.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(16, 48)
        Me.DateTimePicker1.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(114, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'frmHoroscopo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 528)
        Me.Controls.Add(Me.bgPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHoroscopo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horóscopo y signos del zodíaco"
        Me.TopMost = True
        Me.bgPanel.ResumeLayout(False)
        Me.bgPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bgPanel As Panel
    Friend WithEvents btnPiscis As Button
    Friend WithEvents btnAcuario As Button
    Friend WithEvents btnCapricornio As Button
    Friend WithEvents btnSagitario As Button
    Friend WithEvents btnEscorpio As Button
    Friend WithEvents btnLibra As Button
    Friend WithEvents btnVirgo As Button
    Friend WithEvents btnLeo As Button
    Friend WithEvents btnCancer As Button
    Friend WithEvents btnGeminis As Button
    Friend WithEvents btnTauro As Button
    Friend WithEvents btnAries As Button
    Friend WithEvents lblSigno As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
