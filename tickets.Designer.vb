<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtickets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtickets))
        btnTickets = New Button()
        btnPagos = New Button()
        btnReservaciones = New Button()
        btnResumen = New Button()
        Panel1 = New Panel()
        imgLogo = New PictureBox()
        Panel8 = New Panel()
        Panel7 = New Panel()
        Panel6 = New Panel()
        btnBuscar = New Button()
        TextBox1 = New TextBox()
        lblBuscar = New Label()
        Panel5 = New Panel()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        MenuBotones = New Panel()
        Panel9 = New Panel()
        lblPagosPen = New Label()
        Panel10 = New Panel()
        Panel1.SuspendLayout()
        CType(imgLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        Panel6.SuspendLayout()
        MenuBotones.SuspendLayout()
        Panel9.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnTickets
        ' 
        btnTickets.Dock = DockStyle.Top
        btnTickets.FlatAppearance.BorderSize = 0
        btnTickets.FlatStyle = FlatStyle.Flat
        btnTickets.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnTickets.ForeColor = Color.White
        btnTickets.Location = New Point(0, 271)
        btnTickets.Name = "btnTickets"
        btnTickets.Size = New Size(200, 53)
        btnTickets.TabIndex = 3
        btnTickets.Text = "Tickets"
        btnTickets.UseVisualStyleBackColor = True
        ' 
        ' btnPagos
        ' 
        btnPagos.Dock = DockStyle.Top
        btnPagos.FlatAppearance.BorderSize = 0
        btnPagos.FlatStyle = FlatStyle.Flat
        btnPagos.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPagos.ForeColor = Color.White
        btnPagos.Location = New Point(0, 218)
        btnPagos.Name = "btnPagos"
        btnPagos.Size = New Size(200, 53)
        btnPagos.TabIndex = 2
        btnPagos.Text = "Pagos"
        btnPagos.UseVisualStyleBackColor = True
        ' 
        ' btnReservaciones
        ' 
        btnReservaciones.Dock = DockStyle.Top
        btnReservaciones.FlatAppearance.BorderSize = 0
        btnReservaciones.FlatStyle = FlatStyle.Flat
        btnReservaciones.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnReservaciones.ForeColor = Color.White
        btnReservaciones.Location = New Point(0, 165)
        btnReservaciones.Name = "btnReservaciones"
        btnReservaciones.Size = New Size(200, 53)
        btnReservaciones.TabIndex = 1
        btnReservaciones.Text = "Reservaciones"
        btnReservaciones.UseVisualStyleBackColor = True
        ' 
        ' btnResumen
        ' 
        btnResumen.BackColor = Color.FromArgb(CByte(66), CByte(65), CByte(66))
        btnResumen.Dock = DockStyle.Top
        btnResumen.FlatAppearance.BorderSize = 0
        btnResumen.FlatStyle = FlatStyle.Flat
        btnResumen.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnResumen.ForeColor = Color.White
        btnResumen.Location = New Point(0, 112)
        btnResumen.Name = "btnResumen"
        btnResumen.Size = New Size(200, 53)
        btnResumen.TabIndex = 1
        btnResumen.Text = "Resumen"
        btnResumen.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(imgLogo)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 112)
        Panel1.TabIndex = 0
        ' 
        ' imgLogo
        ' 
        imgLogo.Image = My.Resources.Resources.disney_logo_1
        imgLogo.InitialImage = CType(resources.GetObject("imgLogo.InitialImage"), Image)
        imgLogo.Location = New Point(26, 26)
        imgLogo.Name = "imgLogo"
        imgLogo.Size = New Size(136, 59)
        imgLogo.SizeMode = PictureBoxSizeMode.StretchImage
        imgLogo.TabIndex = 0
        imgLogo.TabStop = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(66), CByte(65), CByte(66))
        Panel8.Controls.Add(Panel10)
        Panel8.Controls.Add(Panel9)
        Panel8.Dock = DockStyle.Fill
        Panel8.Location = New Point(225, 133)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(903, 473)
        Panel8.TabIndex = 15
        ' 
        ' Panel7
        ' 
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(225, 106)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(903, 27)
        Panel7.TabIndex = 14
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(66), CByte(65), CByte(66))
        Panel6.Controls.Add(btnBuscar)
        Panel6.Controls.Add(TextBox1)
        Panel6.Controls.Add(lblBuscar)
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(225, 25)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(903, 81)
        Panel6.TabIndex = 13
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(819, 28)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(51, 23)
        btnBuscar.TabIndex = 22
        btnBuscar.Text = "buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(612, 27)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(189, 23)
        TextBox1.TabIndex = 21
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBuscar.ForeColor = Color.White
        lblBuscar.Location = New Point(476, 24)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(130, 25)
        lblBuscar.TabIndex = 20
        lblBuscar.Text = "Buscar tickets:"
        ' 
        ' Panel5
        ' 
        Panel5.Dock = DockStyle.Bottom
        Panel5.Location = New Point(225, 606)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(903, 30)
        Panel5.TabIndex = 12
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Right
        Panel4.Location = New Point(1128, 25)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(26, 611)
        Panel4.TabIndex = 11
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(200, 25)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(25, 611)
        Panel3.TabIndex = 10
        ' 
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(200, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(954, 25)
        Panel2.TabIndex = 9
        ' 
        ' MenuBotones
        ' 
        MenuBotones.BackColor = Color.FromArgb(CByte(66), CByte(65), CByte(66))
        MenuBotones.Controls.Add(btnTickets)
        MenuBotones.Controls.Add(btnPagos)
        MenuBotones.Controls.Add(btnReservaciones)
        MenuBotones.Controls.Add(btnResumen)
        MenuBotones.Controls.Add(Panel1)
        MenuBotones.Dock = DockStyle.Left
        MenuBotones.Location = New Point(0, 0)
        MenuBotones.Name = "MenuBotones"
        MenuBotones.Size = New Size(200, 636)
        MenuBotones.TabIndex = 8
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(lblPagosPen)
        Panel9.Dock = DockStyle.Top
        Panel9.Location = New Point(0, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(903, 71)
        Panel9.TabIndex = 1
        ' 
        ' lblPagosPen
        ' 
        lblPagosPen.AutoSize = True
        lblPagosPen.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPagosPen.ForeColor = Color.White
        lblPagosPen.Location = New Point(17, 23)
        lblPagosPen.Name = "lblPagosPen"
        lblPagosPen.Size = New Size(176, 25)
        lblPagosPen.TabIndex = 20
        lblPagosPen.Text = "1 pagos pendientes"
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = SystemColors.Control
        Panel10.Dock = DockStyle.Top
        Panel10.Location = New Point(0, 71)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(903, 2)
        Panel10.TabIndex = 3
        ' 
        ' frmtickets
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1154, 636)
        Controls.Add(Panel8)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(MenuBotones)
        Name = "frmtickets"
        StartPosition = FormStartPosition.CenterScreen
        Text = "tickets"
        Panel1.ResumeLayout(False)
        CType(imgLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        MenuBotones.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnTickets As Button
    Friend WithEvents btnPagos As Button
    Friend WithEvents btnReservaciones As Button
    Friend WithEvents btnResumen As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuBotones As Panel
    Friend WithEvents btnBuscar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblPagosPen As Label
    Friend WithEvents Panel10 As Panel
End Class
