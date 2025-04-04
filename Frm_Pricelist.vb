Option Strict Off
Option Explicit On 
Imports System.Data.OleDb
Friend Class Frm_Pricelist
    Inherits System.Windows.Forms.Form
    Private WithEvents my_sez As Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'For the start-up form, the first instance created is the default instance.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Txt_rem As System.Windows.Forms.TextBox
	Public WithEvents Txt_cena As System.Windows.Forms.TextBox
	Public WithEvents Txt_rarita As System.Windows.Forms.TextBox
	Public WithEvents Txt_podtyp As System.Windows.Forms.TextBox
	Public WithEvents Txt_typ As System.Windows.Forms.TextBox
	Public WithEvents Txt_název As System.Windows.Forms.TextBox
	Public WithEvents Cmd_First As System.Windows.Forms.Button
	Public WithEvents Cmd_Back As System.Windows.Forms.Button
	Public WithEvents Txt_Num As System.Windows.Forms.TextBox
	Public WithEvents Cmd_Forward As System.Windows.Forms.Button
	Public WithEvents Cmd_Last As System.Windows.Forms.Button
	Public WithEvents Cmd_Order As System.Windows.Forms.Button
	Public WithEvents Cmd_Print As System.Windows.Forms.Button
	Public WithEvents Cmd_New As System.Windows.Forms.Button
	Public WithEvents Cmd_Find As System.Windows.Forms.Button
	Public WithEvents Cmd_Del As System.Windows.Forms.Button
	Public WithEvents Cmd_Ins As System.Windows.Forms.Button
	Public WithEvents Cmd_Exit As System.Windows.Forms.Button
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents Bt_List As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Pricelist))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cmd_First = New System.Windows.Forms.Button
        Me.Cmd_Back = New System.Windows.Forms.Button
        Me.Cmd_Forward = New System.Windows.Forms.Button
        Me.Cmd_Last = New System.Windows.Forms.Button
        Me.Cmd_Order = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_New = New System.Windows.Forms.Button
        Me.Cmd_Find = New System.Windows.Forms.Button
        Me.Cmd_Del = New System.Windows.Forms.Button
        Me.Cmd_Ins = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Txt_rem = New System.Windows.Forms.TextBox
        Me.Txt_cena = New System.Windows.Forms.TextBox
        Me.Txt_rarita = New System.Windows.Forms.TextBox
        Me.Txt_podtyp = New System.Windows.Forms.TextBox
        Me.Txt_typ = New System.Windows.Forms.TextBox
        Me.Txt_název = New System.Windows.Forms.TextBox
        Me.Txt_Num = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Bt_List = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Cmd_First
        '
        Me.Cmd_First.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_First.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_First.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_First.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_First.Image = CType(resources.GetObject("Cmd_First.Image"), System.Drawing.Image)
        Me.Cmd_First.Location = New System.Drawing.Point(56, 184)
        Me.Cmd_First.Name = "Cmd_First"
        Me.Cmd_First.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_First.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_First.TabIndex = 11
        Me.Cmd_First.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_First, "Na začátek")
        Me.Cmd_First.UseVisualStyleBackColor = False
        '
        'Cmd_Back
        '
        Me.Cmd_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Back.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Back.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Back.Image = CType(resources.GetObject("Cmd_Back.Image"), System.Drawing.Image)
        Me.Cmd_Back.Location = New System.Drawing.Point(96, 184)
        Me.Cmd_Back.Name = "Cmd_Back"
        Me.Cmd_Back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Back.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_Back.TabIndex = 10
        Me.Cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Back, "O 1 vzad")
        Me.Cmd_Back.UseVisualStyleBackColor = False
        '
        'Cmd_Forward
        '
        Me.Cmd_Forward.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Forward.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Forward.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Forward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Forward.Image = CType(resources.GetObject("Cmd_Forward.Image"), System.Drawing.Image)
        Me.Cmd_Forward.Location = New System.Drawing.Point(272, 184)
        Me.Cmd_Forward.Name = "Cmd_Forward"
        Me.Cmd_Forward.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Forward.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_Forward.TabIndex = 8
        Me.Cmd_Forward.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Forward, "O 1 vpřed")
        Me.Cmd_Forward.UseVisualStyleBackColor = False
        '
        'Cmd_Last
        '
        Me.Cmd_Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Last.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Last.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Last.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Last.Image = CType(resources.GetObject("Cmd_Last.Image"), System.Drawing.Image)
        Me.Cmd_Last.Location = New System.Drawing.Point(312, 184)
        Me.Cmd_Last.Name = "Cmd_Last"
        Me.Cmd_Last.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Last.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_Last.TabIndex = 7
        Me.Cmd_Last.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Last, "Na konec")
        Me.Cmd_Last.UseVisualStyleBackColor = False
        '
        'Cmd_Order
        '
        Me.Cmd_Order.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Order.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Order.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Order.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Order.Location = New System.Drawing.Point(216, 296)
        Me.Cmd_Order.Name = "Cmd_Order"
        Me.Cmd_Order.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Order.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Order.TabIndex = 6
        Me.Cmd_Order.Text = "ŘAZENÍ"
        Me.ToolTip1.SetToolTip(Me.Cmd_Order, "Změnit parametry řazení kouzel")
        Me.Cmd_Order.UseVisualStyleBackColor = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.Cyan
        Me.Cmd_Print.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Print.Location = New System.Drawing.Point(216, 264)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Print.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Print.TabIndex = 5
        Me.Cmd_Print.Text = "TISK"
        Me.ToolTip1.SetToolTip(Me.Cmd_Print, "Tisk kouzla anebo sestavy")
        Me.Cmd_Print.UseVisualStyleBackColor = False
        '
        'Cmd_New
        '
        Me.Cmd_New.BackColor = System.Drawing.Color.White
        Me.Cmd_New.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_New.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_New.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_New.Location = New System.Drawing.Point(216, 232)
        Me.Cmd_New.Name = "Cmd_New"
        Me.Cmd_New.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_New.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_New.TabIndex = 4
        Me.Cmd_New.Text = "NOVÁ"
        Me.ToolTip1.SetToolTip(Me.Cmd_New, "Vymaže pole, příprava na vepsání nového kouzla")
        Me.Cmd_New.UseVisualStyleBackColor = False
        '
        'Cmd_Find
        '
        Me.Cmd_Find.BackColor = System.Drawing.Color.Yellow
        Me.Cmd_Find.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Find.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Find.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Find.Location = New System.Drawing.Point(80, 296)
        Me.Cmd_Find.Name = "Cmd_Find"
        Me.Cmd_Find.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Find.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Find.TabIndex = 3
        Me.Cmd_Find.Text = "NAJÍT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Find, "Najít kouzlo")
        Me.Cmd_Find.UseVisualStyleBackColor = False
        '
        'Cmd_Del
        '
        Me.Cmd_Del.BackColor = System.Drawing.Color.Red
        Me.Cmd_Del.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Del.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Del.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Del.Location = New System.Drawing.Point(80, 264)
        Me.Cmd_Del.Name = "Cmd_Del"
        Me.Cmd_Del.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Del.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Del.TabIndex = 2
        Me.Cmd_Del.Text = "SMAZAT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Del, "Smazat aktuální kouzlo")
        Me.Cmd_Del.UseVisualStyleBackColor = False
        '
        'Cmd_Ins
        '
        Me.Cmd_Ins.BackColor = System.Drawing.Color.Green
        Me.Cmd_Ins.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Ins.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Ins.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Ins.Location = New System.Drawing.Point(80, 232)
        Me.Cmd_Ins.Name = "Cmd_Ins"
        Me.Cmd_Ins.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Ins.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Ins.TabIndex = 1
        Me.Cmd_Ins.Text = "VLOŽIT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Ins, "Vložit nové kouzlo anebo updatnout stávající")
        Me.Cmd_Ins.UseVisualStyleBackColor = False
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Exit.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(56, 344)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Exit.Size = New System.Drawing.Size(297, 57)
        Me.Cmd_Exit.TabIndex = 0
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Exit, "Zavřít toto okno")
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'Txt_rem
        '
        Me.Txt_rem.AcceptsReturn = True
        Me.Txt_rem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_rem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_rem.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_rem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_rem.Location = New System.Drawing.Point(96, 136)
        Me.Txt_rem.MaxLength = 0
        Me.Txt_rem.Multiline = True
        Me.Txt_rem.Name = "Txt_rem"
        Me.Txt_rem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_rem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_rem.Size = New System.Drawing.Size(305, 33)
        Me.Txt_rem.TabIndex = 23
        '
        'Txt_cena
        '
        Me.Txt_cena.AcceptsReturn = True
        Me.Txt_cena.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_cena.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_cena.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cena.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_cena.Location = New System.Drawing.Point(96, 112)
        Me.Txt_cena.MaxLength = 0
        Me.Txt_cena.Name = "Txt_cena"
        Me.Txt_cena.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_cena.Size = New System.Drawing.Size(121, 19)
        Me.Txt_cena.TabIndex = 21
        '
        'Txt_rarita
        '
        Me.Txt_rarita.AcceptsReturn = True
        Me.Txt_rarita.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_rarita.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_rarita.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_rarita.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_rarita.Location = New System.Drawing.Point(96, 88)
        Me.Txt_rarita.MaxLength = 0
        Me.Txt_rarita.Name = "Txt_rarita"
        Me.Txt_rarita.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_rarita.Size = New System.Drawing.Size(121, 19)
        Me.Txt_rarita.TabIndex = 19
        '
        'Txt_podtyp
        '
        Me.Txt_podtyp.AcceptsReturn = True
        Me.Txt_podtyp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_podtyp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_podtyp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_podtyp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_podtyp.Location = New System.Drawing.Point(96, 64)
        Me.Txt_podtyp.MaxLength = 0
        Me.Txt_podtyp.Name = "Txt_podtyp"
        Me.Txt_podtyp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_podtyp.Size = New System.Drawing.Size(121, 19)
        Me.Txt_podtyp.TabIndex = 17
        '
        'Txt_typ
        '
        Me.Txt_typ.AcceptsReturn = True
        Me.Txt_typ.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_typ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_typ.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_typ.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_typ.Location = New System.Drawing.Point(96, 40)
        Me.Txt_typ.MaxLength = 0
        Me.Txt_typ.Name = "Txt_typ"
        Me.Txt_typ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_typ.Size = New System.Drawing.Size(121, 19)
        Me.Txt_typ.TabIndex = 15
        '
        'Txt_název
        '
        Me.Txt_název.AcceptsReturn = True
        Me.Txt_název.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_název.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_název.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_název.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_název.Location = New System.Drawing.Point(96, 8)
        Me.Txt_název.MaxLength = 0
        Me.Txt_název.Name = "Txt_název"
        Me.Txt_název.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_název.Size = New System.Drawing.Size(305, 19)
        Me.Txt_název.TabIndex = 13
        '
        'Txt_Num
        '
        Me.Txt_Num.AcceptsReturn = True
        Me.Txt_Num.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Num.Font = New System.Drawing.Font("Arial", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Location = New System.Drawing.Point(136, 184)
        Me.Txt_Num.MaxLength = 0
        Me.Txt_Num.Name = "Txt_Num"
        Me.Txt_Num.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Num.Size = New System.Drawing.Size(137, 33)
        Me.Txt_Num.TabIndex = 9
        Me.Txt_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Poznámky"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(81, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Cena"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Rarita"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Podtyp"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Typ"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Položka"
        '
        'Bt_List
        '
        Me.Bt_List.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Bt_List.Image = CType(resources.GetObject("Bt_List.Image"), System.Drawing.Image)
        Me.Bt_List.Location = New System.Drawing.Point(232, 40)
        Me.Bt_List.Name = "Bt_List"
        Me.Bt_List.Size = New System.Drawing.Size(168, 88)
        Me.Bt_List.TabIndex = 48
        Me.Bt_List.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Frm_Pricelist
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(412, 410)
        Me.Controls.Add(Me.Bt_List)
        Me.Controls.Add(Me.Txt_rem)
        Me.Controls.Add(Me.Txt_cena)
        Me.Controls.Add(Me.Txt_rarita)
        Me.Controls.Add(Me.Txt_podtyp)
        Me.Controls.Add(Me.Txt_typ)
        Me.Controls.Add(Me.Txt_název)
        Me.Controls.Add(Me.Cmd_First)
        Me.Controls.Add(Me.Cmd_Back)
        Me.Controls.Add(Me.Txt_Num)
        Me.Controls.Add(Me.Cmd_Forward)
        Me.Controls.Add(Me.Cmd_Last)
        Me.Controls.Add(Me.Cmd_Order)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Cmd_New)
        Me.Controls.Add(Me.Cmd_Find)
        Me.Controls.Add(Me.Cmd_Del)
        Me.Controls.Add(Me.Cmd_Ins)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.Name = "Frm_Pricelist"
        Me.Opacity = 0.9
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC AVATAR - Odria Pricelist"
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Frm_Pricelist
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Frm_Pricelist
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Frm_Pricelist()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As Frm_Pricelist)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region
    Private Sub Frm_PRsez_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles my_sez.Closed
        If Tpri <> "" Then
            PRposition = 0
            Do Until (PRrec.Tables("pr").Rows(PRposition)("Nazev") = Tpri)
                PRposition += 1
            Loop
        End If
        FillForm()
        Me.Refresh()
    End Sub

    Private Sub Cmd_Back_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Back.Click
        PRposition -= 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_First_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_First.Click
        PRposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Forward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Forward.Click
        PRposition += 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Last_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Last.Click
        PRposition = PRcount - 1
        Call FillForm()
    End Sub

    Private Sub Cmd_New_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_New.Click
        Txt_název.Text = ""
        Txt_typ.Text = ""
        Txt_podtyp.Text = ""
        Txt_rarita.Text = ""
        Txt_cena.Text = ""
        Txt_rem.Text = ""
        Cmd_Print.Enabled = False
        Cmd_Del.Enabled = False
        Txt_Num.Text = "NEW"
    End Sub

    Private Sub Frm_Pricelist_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call PRrecopen()
        PRposition = 0
        ApplyColor()
        Call FillForm()
        PR = True
    End Sub


    Private Sub PRrecopen()
        Dim skc As New OleDbCommand
        skc.Connection = Odrialink2
        Select Case PRorder
            Case Is = 1
                If PRdirect = 1 Then
                    skc.CommandText = "select * from Items_pricelist order by Nazev"
                Else
                    skc.CommandText = "select * from Items_pricelist order by Nazev desc"
                End If
            Case Is = 2
                If PRdirect = 1 Then
                    skc.CommandText = "select * from Items_pricelist order by Typ, Podtyp, Nazev"
                Else
                    skc.CommandText = "select * from Items_pricelist order by Typ, Podtyp, Nazev desc"
                End If
            Case Is = 3
                If PRdirect = 1 Then
                    skc.CommandText = "select * from Items_pricelist order by Rarita, Name"
                Else
                    skc.CommandText = "select * from Items_pricelist order by Rarita, Name desc"
                End If
        End Select
        PRdat.SelectCommand = skc
        PRrec.Clear()
        PRdat.Fill(PRrec, "pr")
        PRcount = PRrec.Tables("pr").Rows.Count
    End Sub


    Sub FillForm()


        Txt_název.Text = PRrec.Tables("pr").Rows(PRposition)("Nazev")
        If Not IsDBNull(PRrec.Tables("pr").Rows(PRposition)("Typ")) Then
            Txt_typ.Text = PRrec.Tables("pr").Rows(PRposition)("Typ")
        Else
            Txt_typ.Text = ""
        End If
        If Not IsDBNull(PRrec.Tables("pr").Rows(PRposition)("Podtyp")) Then
            Txt_podtyp.Text = PRrec.Tables("pr").Rows(PRposition)("Podtyp")
        Else
            Txt_podtyp.Text = ""
        End If
        If Not IsDBNull(PRrec.Tables("pr").Rows(PRposition)("Rarita")) Then
            Txt_rarita.Text = PRrec.Tables("pr").Rows(PRposition)("Rarita")
        Else
            Txt_rarita.Text = ""
        End If
        If Not IsDBNull(PRrec.Tables("pr").Rows(PRposition)("Cena")) Then
            Txt_cena.Text = PRrec.Tables("pr").Rows(PRposition)("Cena")
        Else
            Txt_cena.Text = ""
        End If
        If Not IsDBNull(PRrec.Tables("pr").Rows(PRposition)("Poznamky")) Then
            Txt_rem.Text = PRrec.Tables("pr").Rows(PRposition)("Poznamky")
        Else
            Txt_rem.Text = ""
        End If
        If PRposition = 0 Then
            Cmd_Back.Enabled = False
        Else
            Cmd_Back.Enabled = True
        End If
        Cmd_Del.Enabled = True
        Cmd_Find.Enabled = True
        If PRposition + 1 = PRcount Then
            Cmd_Forward.Enabled = False
        Else
            Cmd_Forward.Enabled = True
        End If
        Cmd_Ins.Enabled = True
        Cmd_New.Enabled = True
        Cmd_Print.Enabled = True


        Txt_Num.Text = (PRposition + 1) & "/" & PRcount

    End Sub


    Private Sub Frm_Pricelist_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        PR = False
        PRrec.Clear()
    End Sub

    Private Sub Txt_Num_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Num.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Not IsNumeric(Txt_Num.Text) Then
                MsgBox("Tady musí být číslo!", MsgBoxStyle.OKOnly, "Chyba")
                GoTo EventExitSub
            End If
            If CShort(Txt_Num.Text) > PRcount Or CShort(Txt_Num.Text) < 1 Then
                MsgBox("Číslo musí být v rozsahu 1 - počet záznamů!", MsgBoxStyle.OKOnly, "Chyba")
                GoTo EventExitSub
            End If
            KeyAscii = 0
            PRposition = CShort(Txt_Num.Text) - 1
            Call FillForm()
        End If
EventExitSub:
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Cmd_Print_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Print.Click
        Dim PRrint As New PRPrint
        PRrint.Show()
    End Sub

    Private Sub Cmd_Order_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Order.Click
        OrderControl = "PR"
        FO = New Frm_Ordering
        FO.ShowDialog()
        FO = Nothing
        PRrec.Clear()
        Call PRrecopen()
        PRposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Ins_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Ins.Click
        If Txt_název.Text = "" Then
            MsgBox("Položka musí být zadána!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        Dim tsc As New OleDbCommand
        Dim treader As OleDbDataReader
        Try
            tsc.Connection = Odrialink2
            tsc.CommandText = "select * from Items_pricelist where Nazev = @sk"
            tsc.Parameters.AddWithValue("@sk", Txt_název.Text)
            treader = tsc.ExecuteReader
        Catch ex As Exception
            MsgBox("Chyba při čtení databáze: " + ex.Message, , "CHYBA")
            treader.Close()
            Exit Sub
        End Try
        If Not treader.HasRows Then
            treader.Close()
            Try
                Dim ic As New OleDbCommand
                Dim s1, s2 As String
                s1 = "INSERT INTO Items_pricelist (Nazev"
                s2 = " VALUES (@sk"
                ic.Parameters.AddWithValue("@sk", Txt_název.Text)
                If Txt_typ.Text <> "" Then
                    ic.Parameters.AddWithValue("@di", Trim(Txt_typ.Text))
                    s1 = s1 & ", Typ"
                    s2 = s2 & ", @di"
                End If
                If Txt_podtyp.Text <> "" Then
                    ic.Parameters.AddWithValue("@de", Trim(Txt_podtyp.Text))
                    s1 = s1 & ", Podtyp"
                    s2 = s2 & ", @de"
                End If
                If Txt_rarita.Text <> "" Then
                    ic.Parameters.AddWithValue("@do", Trim(Txt_rarita.Text))
                    s1 = s1 & ", Rarita"
                    s2 = s2 & ", @do"
                End If
                If Txt_cena.Text <> "" Then
                    ic.Parameters.AddWithValue("@du", Trim(Txt_cena.Text))
                    s1 = s1 & ", Cena"
                    s2 = s2 & ", @du"
                End If
                If Txt_rem.Text <> "" Then
                    ic.Parameters.AddWithValue("@dy", Trim(Txt_rem.Text))
                    s1 = s1 & ", Poznamky"
                    s2 = s2 & ", @dy"
                End If
                s1 = s1 & ")"
                s2 = s2 & ")"
                ic.Connection = Odrialink2
                ic.CommandText = s1 + s2
                ic.ExecuteScalar()
            Catch ex As Exception
                MsgBox("Chyba při zápisu do databáze: " + ex.Message, , "CHYBA")
                Exit Sub
            End Try
            PRrec.Clear()
            PRdat.Fill(PRrec, "pr")
            PRcount = PRrec.Tables("pr").Rows.Count
            Call FillForm()
        Else
            treader.Close()
            If MsgBox("Položka tohoto jména již v databázi existuje, chcete jí přepsat?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Upozornění") = MsgBoxResult.Yes Then
                Try
                    Dim s3 As String
                    Dim uc As New OleDbCommand
                    s3 = "UPDATE Items_pricelist set Nazev = @sk, Typ = @di, Podtyp = @aa, Rarita = @us, Cena = @ce, Poznamky = @po WHERE ID = @ID"
                    uc.Parameters.AddWithValue("@sk", Txt_název.Text)
                    If Txt_typ.Text = "" Then
                        uc.Parameters.AddWithValue("@di", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@di", Txt_typ.Text)
                    End If
                    If Txt_podtyp.Text = "" Then
                        uc.Parameters.AddWithValue("@aa", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@aa", Txt_podtyp.Text)
                    End If
                    If Txt_rarita.Text = "" Then
                        uc.Parameters.AddWithValue("@us", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@us", Txt_rarita.Text)
                    End If
                    If Txt_cena.Text = "" Then
                        uc.Parameters.AddWithValue("@ce", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@ce", Txt_cena.Text)
                    End If
                    If Txt_rem.Text = "" Then
                        uc.Parameters.AddWithValue("@po", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@po", Txt_rem.Text)
                    End If
                    uc.Parameters.AddWithValue("@ID", PRrec.Tables("pr").Rows(PRposition)("ID"))
                    uc.Connection = Odrialink2
                    uc.CommandText = s3
                    uc.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Chyba updatu případu: " + ex.Message, , "Pokus o update")
                    Exit Sub
                End Try
                PRrec.Clear()
                PRdat.Fill(PRrec, "pr")
                Call FillForm()
            Else
                Exit Sub
            End If
        End If

    End Sub

    Private Sub Cmd_Find_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Find.Click
        Dim se As New OleDbCommand
        Dim re As OleDbDataReader
        Dim s As String
        Dim q1 As Long
        Dim ski, dif, aat, usa, cen, poz As Boolean
        se.Connection = Odrialink2
        s = "SELECT * from Items_pricelist WHERE "
        If Txt_název.Text <> "" Then
            s = s & "Nazev LIKE @sk"
            se.Parameters.AddWithValue("@sk", "%" & Txt_název.Text & "%")
            ski = True
        End If
        If Txt_typ.Text <> "" Then
            If ski Then
                s = s & " AND "
            End If
            s = s & "Typ LIKE @di"
            se.Parameters.AddWithValue("@di", "%" & Txt_typ.Text & "%")
            dif = True
        End If
        If Txt_podtyp.Text <> "" Then
            If ski Or dif Then
                s = s & " AND "
            End If
            s = s & "Podtyp LIKE @aa"
            se.Parameters.AddWithValue("@aa", "%" & Txt_podtyp.Text & "%")
            aat = True
        End If
        If Txt_rarita.Text <> "" Then
            If ski Or dif Or aat Then
                s = s & " AND "
            End If
            s = s & "Rarita LIKE @us"
            se.Parameters.AddWithValue("@us", "%" & Txt_rarita.Text & "%")
            usa = True
        End If
        If Txt_cena.Text <> "" Then
            If ski Or dif Or aat Or usa Then
                s = s & " AND "
            End If
            s = s & "Cena LIKE @ce"
            se.Parameters.AddWithValue("@ce", "%" & Txt_cena.Text & "%")
            cen = True
        End If
        If Txt_rem.Text <> "" Then
            If ski Or dif Or aat Or usa Or cen Then
                s = s & " AND "
            End If
            s = s & "Poznamky LIKE @po"
            se.Parameters.AddWithValue("@po", "%" & Txt_rem.Text & "%")
            poz = True
        End If
        PRposition = 0
        If s = "SELECT * from Items_pricelist WHERE " Then
            PRrecopen()
            FillForm()
            Exit Sub
        End If
        Try
            se.CommandText = s
            re = se.ExecuteReader
            If re.HasRows Then
                q1 = 0
                While re.Read()
                    q1 += 1
                End While
                re.Close()
                If q1 = 1 Then
                    Do
                        If Txt_název.Text = PRrec.Tables("pr").Rows(PRposition)("Nazev") Then
                            Exit Do
                        End If
                        PRposition += 1
                    Loop Until PRposition + 1 = PRcount
                Else
                    PRdat.SelectCommand = se
                    PRrec.Clear()
                    PRdat.Fill(PRrec, "pr")
                    PRcount = PRrec.Tables("pr").Rows.Count
                    If GC_list = 1 Then
                        If my_sez Is Nothing Then
                            my_sez = New Frm_PRsez
                            my_sez.Show()
                        Else
                            If my_sez.WindowState = FormWindowState.Minimized Or my_sez.WindowState = FormWindowState.Maximized Then
                                my_sez.WindowState = FormWindowState.Normal
                            Else
                                my_sez.Close()
                                my_sez = Nothing
                            End If
                        End If
                        Exit Sub
                    End If
                End If
            Else
                re.Close()
                MsgBox("Žádný záznam neodpovídá zvoleným parametrům.", , "Nenalezeno")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Chyba při čtení databáze." + ex.Message, , "Chyba")
            Exit Sub
        End Try
        Call FillForm()
    End Sub

    Private Sub Cmd_Del_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Del.Click
        Dim tsc As New OleDbCommand
        If MsgBox("Opravdu vymazat položku " & Txt_název.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Upozornění") = MsgBoxResult.Yes Then
            Try
                tsc.Connection = Odrialink2
                tsc.CommandText = "DELETE from Items_pricelist WHERE ID = @ID"
                tsc.Parameters.AddWithValue("@ID", PRrec.Tables("pr").Rows(PRposition)("ID"))
                tsc.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception("Chyba při výmazu případu: " + ex.Message)
                Exit Sub
            End Try
        Else
            Exit Sub
        End If
        PRrec.Clear()
        PRdat.Fill(PRrec, "pr")
        PRcount = PRrec.Tables("pr").Rows.Count
        If PRposition = PRcount Then
            PRposition -= 1
        End If
        Call FillForm()
    End Sub

    Private Sub Bt_List_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_List.Click
        If my_sez Is Nothing Then
            my_sez = New Frm_PRsez
            my_sez.Show()
        Else
            If my_sez.WindowState = FormWindowState.Minimized Or my_sez.WindowState = FormWindowState.Maximized Then
                my_sez.WindowState = FormWindowState.Normal
            Else
                my_sez.Close()
                my_sez = Nothing
            End If
        End If
    End Sub

    Sub ApplyColor()
        Me.BackColor = Color.FromArgb(FCEB)
        Cmd_Exit.BackColor = Color.FromArgb(COE)
        Cmd_Ins.BackColor = Color.FromArgb(COI)
        Cmd_Del.BackColor = Color.FromArgb(COD)
        Cmd_Find.BackColor = Color.FromArgb(COF)
        Cmd_New.BackColor = Color.FromArgb(CON)
        Cmd_Print.BackColor = Color.FromArgb(COP)
        Cmd_Order.BackColor = Color.FromArgb(COO)
        Cmd_Ins.ForeColor = Color.FromArgb(COFO)
        Cmd_Del.ForeColor = Color.FromArgb(COFO)
        Cmd_Find.ForeColor = Color.FromArgb(COFO)
        Cmd_New.ForeColor = Color.FromArgb(COFO)
        Cmd_Print.ForeColor = Color.FromArgb(COFO)
        Cmd_Order.ForeColor = Color.FromArgb(COFO)
        Label1.ForeColor = Color.FromArgb(FCEF)
        Label2.ForeColor = Color.FromArgb(FCEF)
        Label3.ForeColor = Color.FromArgb(FCEF)
        Label4.ForeColor = Color.FromArgb(FCEF)
        Label5.ForeColor = Color.FromArgb(FCEF)
        Label6.ForeColor = Color.FromArgb(FCEF)
        Txt_Num.ForeColor = Color.FromArgb(FCEF)
        Txt_název.ForeColor = Color.FromArgb(FCEF)
        Txt_typ.ForeColor = Color.FromArgb(FCEF)
        Txt_podtyp.ForeColor = Color.FromArgb(FCEF)
        Txt_rarita.ForeColor = Color.FromArgb(FCEF)
        Txt_cena.ForeColor = Color.FromArgb(FCEF)
        Txt_rem.ForeColor = Color.FromArgb(FCEF)
    End Sub
End Class