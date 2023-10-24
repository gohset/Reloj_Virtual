Public Class Form1
    Dim a, b, c, d, dia As Integer
    Dim lun, mar, mier, jue, vier, sad, dom As String
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.Opacity = 0.25
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        'Me.FormBorderStyle = False
        c = 1
        d = 83
        
        Me.BackColor = Color.White
        Me.TransparencyKey = Color.White

        ' PictureBox2.Parent = PictureBox1
        PictureBox2.BackColor = Color.Transparent
        PictureBox1.Left = 30
        PictureBox2.Left = 83

        Timer1.Start()
        lblhora.Parent = Panel2
        lblpunto.Parent = Panel2
        lblminuto.Parent = Panel2

        lblhora.BackColor = Color.Transparent
        lblpunto.BackColor = Color.Transparent
        lblminuto.BackColor = Color.Transparent

        dia = Today.Date.DayOfWeek
        lblanio.Text = Date.Now.Year
        'lbldia.Text = Today.Month & " / " & Today.Day
        pfecha.Visible = False

        dias()

    End Sub

    Sub dias()
        lun = "lun, "
        mar = "mar, "
        mier = "mier, "
        jue = "jue, "
        vier = "vier, "
        sad = "sad, "
        dom = "dom, "

    End Sub
    Sub fecha()
        '***************************************************
        '********************** FECHA **********************
        '***************************************************

        '****** DIA ******
        For d As Integer = 1 To 31
            cmbdia.Items.Add(d)


            cmbdia.IntegralHeight = False
            cmbdia.MaxDropDownItems = 5
        Next
        cmbdia.SelectedIndex = Today.Day - 1
        '****** MES *****

        cmbmes.Items.Add("Enero")
        cmbmes.Items.Add("Febrero")
        cmbmes.Items.Add("Marzo")
        cmbmes.Items.Add("Abril")
        cmbmes.Items.Add("Mayo")
        cmbmes.Items.Add("Junio")
        cmbmes.Items.Add("Julio")
        cmbmes.Items.Add("Agosto")
        cmbmes.Items.Add("Septiembre")
        cmbmes.Items.Add("Octubre")
        cmbmes.Items.Add("Noviembre")
        cmbmes.Items.Add("Diciembre")
        cmbmes.SelectedIndex = Today.Month - 1

        '********************************
        '********************************

        cmbmes.IntegralHeight = False
        cmbmes.MaxDropDownItems = 5


        '******* AÑO ******
        For anio As Integer = 0 To 41
            cmbanio.Items.Add(anio + Today.Year - 30)
            cmbanio.SelectedIndex = 0

            cmbanio.IntegralHeight = False
            cmbanio.MaxDropDownItems = 5
        Next


        '***************************************************
        '********************** HORA ***********************
        '***************************************************
        txthora.Text = TimeOfDay.Hour
        txtminutos.Text = TimeOfDay.Minute
        txtsegundos.Text = TimeOfDay.Second
    End Sub
    Sub condicion()
        If dia = 1 Then
            lbldia.Text = lun & Today.Month & " / " & Today.Day
        ElseIf dia = 2 Then
            lbldia.Text = mar & Today.Month & " / " & Today.Day
        ElseIf dia = 3 Then
            lbldia.Text = mier & Today.Month & " / " & Today.Day
        ElseIf dia = 4 Then
            lbldia.Text = jue & Today.Month & " / " & Today.Day
        ElseIf dia = 5 Then
            lbldia.Text = vier & Today.Month & " / " & Today.Day
        ElseIf dia = 6 Then
            lbldia.Text = sad & Today.Month & " / " & Today.Day
        ElseIf dia = 7 Then
            lbldia.Text = dom & Today.Month & " / " & Today.Day
        End If
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        condicion()
        a = a + c
        b = b + c
        PictureBox1.Left = a + 30
        PictureBox2.Left = b + d

        If PictureBox1.Left > 165 Then
            a = 0
            PictureBox1.Left = 30
        End If

        If PictureBox2.Left > 165 Then
            b = 0
            d = 30
            PictureBox2.Left = d
        End If

        lblhora.Text = TimeOfDay.Hour
        lblminuto.Text = TimeOfDay.Minute
    End Sub

    Private Sub lblconfiguracion_Click(sender As System.Object, e As System.EventArgs) Handles lblconfiguracion.Click
        pfecha.Visible = True
        fecha()
    End Sub
End Class
