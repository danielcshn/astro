<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.bgPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bgPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lato Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(383, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(240, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "HORÓSCOPO Y SIGNOS DEL ZODÍACO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Lato Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(383, 196)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(240, 50)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "COMPATIBILIDAD ENTRE SIGNOS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Lato Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(383, 252)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(240, 50)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "HORÓSCOPO CHINO"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Lato Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(383, 308)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(240, 50)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "NUMEROLOGÍA"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'bgPanel
        '
        Me.bgPanel.BackColor = System.Drawing.Color.Transparent
        Me.bgPanel.Controls.Add(Me.PictureBox1)
        Me.bgPanel.Controls.Add(Me.Button1)
        Me.bgPanel.Controls.Add(Me.Button4)
        Me.bgPanel.Controls.Add(Me.Button2)
        Me.bgPanel.Controls.Add(Me.Button3)
        Me.bgPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bgPanel.Location = New System.Drawing.Point(0, 0)
        Me.bgPanel.Name = "bgPanel"
        Me.bgPanel.Size = New System.Drawing.Size(649, 380)
        Me.bgPanel.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(380, 380)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 380)
        Me.Controls.Add(Me.bgPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Astro"
        Me.bgPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents bgPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
