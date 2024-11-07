<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuBotones = New Panel()
        btnTickets = New Button()
        btnPagos = New Button()
        btnReservaciones = New Button()
        btnResumen = New Button()
        Panel1 = New Panel()
        imgLogo = New PictureBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        MenuBotones.SuspendLayout()
        Panel1.SuspendLayout()
        CType(imgLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        MenuBotones.TabIndex = 0
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
        ' Panel2
        ' 
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(200, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(954, 25)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(200, 25)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(25, 611)
        Panel3.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.Dock = DockStyle.Right
        Panel4.Location = New Point(1128, 25)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(26, 611)
        Panel4.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.Dock = DockStyle.Bottom
        Panel5.Location = New Point(225, 606)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(903, 30)
        Panel5.TabIndex = 4
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(66), CByte(65), CByte(66))
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(225, 25)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(903, 81)
        Panel6.TabIndex = 5
        ' 
        ' Panel7
        ' 
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(225, 106)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(903, 27)
        Panel7.TabIndex = 6
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(66), CByte(65), CByte(66))
        Panel8.Dock = DockStyle.Fill
        Panel8.Location = New Point(225, 133)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(903, 473)
        Panel8.TabIndex = 7
        ' 
        ' Form1
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
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Resumen"
        MenuBotones.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(imgLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MenuBotones As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents btnTickets As Button
    Friend WithEvents btnPagos As Button
    Friend WithEvents btnReservaciones As Button
    Friend WithEvents btnResumen As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel

End Class
