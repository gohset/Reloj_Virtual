<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lblminuto = New System.Windows.Forms.Label()
        Me.lblpunto = New System.Windows.Forms.Label()
        Me.lbldia = New System.Windows.Forms.Label()
        Me.lblc3 = New System.Windows.Forms.Label()
        Me.lblc2 = New System.Windows.Forms.Label()
        Me.lblc1 = New System.Windows.Forms.Label()
        Me.lblciudad = New System.Windows.Forms.Label()
        Me.lblanio = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblmover = New System.Windows.Forms.Label()
        Me.pfecha = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbdia = New System.Windows.Forms.ComboBox()
        Me.cmbmes = New System.Windows.Forms.ComboBox()
        Me.cmbanio = New System.Windows.Forms.ComboBox()
        Me.lblconfiguracion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txthora = New System.Windows.Forms.TextBox()
        Me.txtminutos = New System.Windows.Forms.TextBox()
        Me.txtsegundos = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pfecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.Reloj_Virtual.My.Resources.Resources.FondoReloj
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.lblconfiguracion)
        Me.Panel1.Controls.Add(Me.pfecha)
        Me.Panel1.Controls.Add(Me.lblmover)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lbldia)
        Me.Panel1.Controls.Add(Me.lblc3)
        Me.Panel1.Controls.Add(Me.lblc2)
        Me.Panel1.Controls.Add(Me.lblc1)
        Me.Panel1.Controls.Add(Me.lblciudad)
        Me.Panel1.Controls.Add(Me.lblanio)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(323, 360)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Reloj_Virtual.My.Resources.Resources.fondo_sombra
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.lblhora)
        Me.Panel2.Controls.Add(Me.lblminuto)
        Me.Panel2.Controls.Add(Me.lblpunto)
        Me.Panel2.Location = New System.Drawing.Point(73, 222)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(181, 55)
        Me.Panel2.TabIndex = 11
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Castellar", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.ForeColor = System.Drawing.Color.White
        Me.lblhora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblhora.Location = New System.Drawing.Point(9, 5)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(56, 44)
        Me.lblhora.TabIndex = 2
        Me.lblhora.Text = "12"
        '
        'lblminuto
        '
        Me.lblminuto.AutoSize = True
        Me.lblminuto.Font = New System.Drawing.Font("Castellar", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblminuto.ForeColor = System.Drawing.Color.White
        Me.lblminuto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblminuto.Location = New System.Drawing.Point(107, 5)
        Me.lblminuto.Name = "lblminuto"
        Me.lblminuto.Size = New System.Drawing.Size(62, 44)
        Me.lblminuto.TabIndex = 9
        Me.lblminuto.Text = "22"
        '
        'lblpunto
        '
        Me.lblpunto.AutoSize = True
        Me.lblpunto.Font = New System.Drawing.Font("Castellar", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpunto.ForeColor = System.Drawing.Color.White
        Me.lblpunto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblpunto.Location = New System.Drawing.Point(72, 5)
        Me.lblpunto.Name = "lblpunto"
        Me.lblpunto.Size = New System.Drawing.Size(30, 44)
        Me.lblpunto.TabIndex = 10
        Me.lblpunto.Text = ":"
        '
        'lbldia
        '
        Me.lbldia.AutoSize = True
        Me.lbldia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldia.ForeColor = System.Drawing.Color.White
        Me.lbldia.Image = Global.Reloj_Virtual.My.Resources.Resources.fondo_sombra
        Me.lbldia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbldia.Location = New System.Drawing.Point(118, 286)
        Me.lbldia.Name = "lbldia"
        Me.lbldia.Size = New System.Drawing.Size(89, 19)
        Me.lbldia.TabIndex = 8
        Me.lbldia.Text = "lun, 06 / 24"
        '
        'lblc3
        '
        Me.lblc3.AutoSize = True
        Me.lblc3.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblc3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblc3.Image = Global.Reloj_Virtual.My.Resources.Resources.fondo_sombra
        Me.lblc3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblc3.Location = New System.Drawing.Point(189, 143)
        Me.lblc3.Name = "lblc3"
        Me.lblc3.Size = New System.Drawing.Size(39, 23)
        Me.lblc3.TabIndex = 7
        Me.lblc3.Text = "27º"
        '
        'lblc2
        '
        Me.lblc2.AutoSize = True
        Me.lblc2.Font = New System.Drawing.Font("Castellar", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblc2.ForeColor = System.Drawing.Color.White
        Me.lblc2.Image = Global.Reloj_Virtual.My.Resources.Resources.fondo_sombra
        Me.lblc2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblc2.Location = New System.Drawing.Point(140, 141)
        Me.lblc2.Name = "lblc2"
        Me.lblc2.Size = New System.Drawing.Size(45, 25)
        Me.lblc2.TabIndex = 6
        Me.lblc2.Text = "24º"
        '
        'lblc1
        '
        Me.lblc1.AutoSize = True
        Me.lblc1.Font = New System.Drawing.Font("Castellar", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblc1.ForeColor = System.Drawing.Color.Crimson
        Me.lblc1.Image = Global.Reloj_Virtual.My.Resources.Resources.fondo_sombra
        Me.lblc1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblc1.Location = New System.Drawing.Point(95, 143)
        Me.lblc1.Name = "lblc1"
        Me.lblc1.Size = New System.Drawing.Size(39, 23)
        Me.lblc1.TabIndex = 5
        Me.lblc1.Text = "27º"
        '
        'lblciudad
        '
        Me.lblciudad.AutoSize = True
        Me.lblciudad.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblciudad.ForeColor = System.Drawing.Color.White
        Me.lblciudad.Image = Global.Reloj_Virtual.My.Resources.Resources.fondo_sombra
        Me.lblciudad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblciudad.Location = New System.Drawing.Point(118, 175)
        Me.lblciudad.Name = "lblciudad"
        Me.lblciudad.Size = New System.Drawing.Size(86, 19)
        Me.lblciudad.TabIndex = 4
        Me.lblciudad.Text = "Guayaquil"
        '
        'lblanio
        '
        Me.lblanio.AutoSize = True
        Me.lblanio.Font = New System.Drawing.Font("Castellar", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblanio.ForeColor = System.Drawing.Color.White
        Me.lblanio.Image = Global.Reloj_Virtual.My.Resources.Resources.fondo_sombra
        Me.lblanio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblanio.Location = New System.Drawing.Point(139, 204)
        Me.lblanio.Name = "lblanio"
        Me.lblanio.Size = New System.Drawing.Size(46, 18)
        Me.lblanio.TabIndex = 3
        Me.lblanio.Text = "2018"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Reloj_Virtual.My.Resources.Resources.RelojNuve
        Me.PictureBox2.Location = New System.Drawing.Point(83, 80)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(149, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Reloj_Virtual.My.Resources.Resources.RelojNuve
        Me.PictureBox1.Location = New System.Drawing.Point(30, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'lblmover
        '
        Me.lblmover.AutoSize = True
        Me.lblmover.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmover.Location = New System.Drawing.Point(26, 272)
        Me.lblmover.Name = "lblmover"
        Me.lblmover.Size = New System.Drawing.Size(17, 24)
        Me.lblmover.TabIndex = 12
        Me.lblmover.Text = "*"
        '
        'pfecha
        '
        Me.pfecha.BackColor = System.Drawing.Color.Transparent
        Me.pfecha.Controls.Add(Me.txtsegundos)
        Me.pfecha.Controls.Add(Me.txtminutos)
        Me.pfecha.Controls.Add(Me.txthora)
        Me.pfecha.Controls.Add(Me.Label2)
        Me.pfecha.Controls.Add(Me.cmbanio)
        Me.pfecha.Controls.Add(Me.cmbmes)
        Me.pfecha.Controls.Add(Me.cmbdia)
        Me.pfecha.Controls.Add(Me.Label1)
        Me.pfecha.Location = New System.Drawing.Point(83, 131)
        Me.pfecha.Name = "pfecha"
        Me.pfecha.Size = New System.Drawing.Size(171, 180)
        Me.pfecha.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(54, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha"
        '
        'cmbdia
        '
        Me.cmbdia.FormattingEnabled = True
        Me.cmbdia.ItemHeight = 13
        Me.cmbdia.Location = New System.Drawing.Point(9, 45)
        Me.cmbdia.Name = "cmbdia"
        Me.cmbdia.Size = New System.Drawing.Size(35, 21)
        Me.cmbdia.TabIndex = 1
        '
        'cmbmes
        '
        Me.cmbmes.FormattingEnabled = True
        Me.cmbmes.Location = New System.Drawing.Point(49, 45)
        Me.cmbmes.Name = "cmbmes"
        Me.cmbmes.Size = New System.Drawing.Size(47, 21)
        Me.cmbmes.TabIndex = 2
        '
        'cmbanio
        '
        Me.cmbanio.FormattingEnabled = True
        Me.cmbanio.Location = New System.Drawing.Point(102, 44)
        Me.cmbanio.Name = "cmbanio"
        Me.cmbanio.Size = New System.Drawing.Size(62, 21)
        Me.cmbanio.TabIndex = 3
        '
        'lblconfiguracion
        '
        Me.lblconfiguracion.AutoSize = True
        Me.lblconfiguracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconfiguracion.Location = New System.Drawing.Point(36, 318)
        Me.lblconfiguracion.Name = "lblconfiguracion"
        Me.lblconfiguracion.Size = New System.Drawing.Size(17, 24)
        Me.lblconfiguracion.TabIndex = 14
        Me.lblconfiguracion.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(56, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hora"
        '
        'txthora
        '
        Me.txthora.Location = New System.Drawing.Point(22, 134)
        Me.txthora.Name = "txthora"
        Me.txthora.Size = New System.Drawing.Size(46, 20)
        Me.txthora.TabIndex = 5
        '
        'txtminutos
        '
        Me.txtminutos.Location = New System.Drawing.Point(74, 134)
        Me.txtminutos.Name = "txtminutos"
        Me.txtminutos.Size = New System.Drawing.Size(46, 20)
        Me.txtminutos.TabIndex = 6
        '
        'txtsegundos
        '
        Me.txtsegundos.Location = New System.Drawing.Point(126, 134)
        Me.txtsegundos.Name = "txtsegundos"
        Me.txtsegundos.Size = New System.Drawing.Size(23, 20)
        Me.txtsegundos.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(323, 360)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Reloj Virtual"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pfecha.ResumeLayout(False)
        Me.pfecha.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblc3 As System.Windows.Forms.Label
    Friend WithEvents lblc2 As System.Windows.Forms.Label
    Friend WithEvents lblc1 As System.Windows.Forms.Label
    Friend WithEvents lblciudad As System.Windows.Forms.Label
    Friend WithEvents lblanio As System.Windows.Forms.Label
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents lbldia As System.Windows.Forms.Label
    Friend WithEvents lblminuto As System.Windows.Forms.Label
    Friend WithEvents lblpunto As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pfecha As System.Windows.Forms.Panel
    Friend WithEvents cmbanio As System.Windows.Forms.ComboBox
    Friend WithEvents cmbmes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbdia As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblmover As System.Windows.Forms.Label
    Friend WithEvents lblconfiguracion As System.Windows.Forms.Label
    Friend WithEvents txtsegundos As System.Windows.Forms.TextBox
    Friend WithEvents txtminutos As System.Windows.Forms.TextBox
    Friend WithEvents txthora As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
