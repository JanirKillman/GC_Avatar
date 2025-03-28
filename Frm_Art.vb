Option Strict Off
Option Explicit On 
Imports System.Data.OleDb
Friend Class Frm_Art
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
	Public WithEvents Txt_aut As System.Windows.Forms.TextBox
	Public WithEvents Txt_naz As System.Windows.Forms.TextBox
	Public WithEvents Txt_typ As System.Windows.Forms.TextBox
	Public WithEvents Txt_inst As System.Windows.Forms.TextBox
	Public WithEvents Txt_Lap As System.Windows.Forms.TextBox
	Public WithEvents Txt_Wip As System.Windows.Forms.TextBox
	Public WithEvents Txt_pop As System.Windows.Forms.TextBox
	Public WithEvents Txt_rem As System.Windows.Forms.TextBox
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
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents Bt_List As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Art))
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
        Me.Txt_aut = New System.Windows.Forms.TextBox
        Me.Txt_naz = New System.Windows.Forms.TextBox
        Me.Txt_typ = New System.Windows.Forms.TextBox
        Me.Txt_inst = New System.Windows.Forms.TextBox
        Me.Txt_Lap = New System.Windows.Forms.TextBox
        Me.Txt_Wip = New System.Windows.Forms.TextBox
        Me.Txt_pop = New System.Windows.Forms.TextBox
        Me.Txt_rem = New System.Windows.Forms.TextBox
        Me.Txt_Num = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Bt_List = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Cmd_First
        '
        Me.Cmd_First.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_First.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_First.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_First.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_First.Image = CType(resources.GetObject("Cmd_First.Image"), System.Drawing.Image)
        Me.Cmd_First.Location = New System.Drawing.Point(72, 336)
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
        Me.Cmd_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Back.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Back.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Back.Image = CType(resources.GetObject("Cmd_Back.Image"), System.Drawing.Image)
        Me.Cmd_Back.Location = New System.Drawing.Point(112, 336)
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
        Me.Cmd_Forward.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Forward.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Forward.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Forward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Forward.Image = CType(resources.GetObject("Cmd_Forward.Image"), System.Drawing.Image)
        Me.Cmd_Forward.Location = New System.Drawing.Point(288, 336)
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
        Me.Cmd_Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Last.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Last.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Last.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Last.Image = CType(resources.GetObject("Cmd_Last.Image"), System.Drawing.Image)
        Me.Cmd_Last.Location = New System.Drawing.Point(328, 336)
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
        Me.Cmd_Order.Location = New System.Drawing.Point(240, 448)
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
        Me.Cmd_Print.Location = New System.Drawing.Point(240, 416)
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
        Me.Cmd_New.Location = New System.Drawing.Point(240, 384)
        Me.Cmd_New.Name = "Cmd_New"
        Me.Cmd_New.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_New.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_New.TabIndex = 4
        Me.Cmd_New.Text = "NOVÉ"
        Me.ToolTip1.SetToolTip(Me.Cmd_New, "Vymaže pole, příprava na vepsání nového kouzla")
        Me.Cmd_New.UseVisualStyleBackColor = False
        '
        'Cmd_Find
        '
        Me.Cmd_Find.BackColor = System.Drawing.Color.Yellow
        Me.Cmd_Find.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Find.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Find.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Find.Location = New System.Drawing.Point(88, 448)
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
        Me.Cmd_Del.Location = New System.Drawing.Point(88, 416)
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
        Me.Cmd_Ins.Location = New System.Drawing.Point(88, 384)
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
        Me.Cmd_Exit.Location = New System.Drawing.Point(72, 496)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Exit.Size = New System.Drawing.Size(297, 57)
        Me.Cmd_Exit.TabIndex = 0
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Exit, "Zavřít toto okno")
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'Txt_aut
        '
        Me.Txt_aut.AcceptsReturn = True
        Me.Txt_aut.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_aut.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_aut.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_aut.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_aut.Location = New System.Drawing.Point(128, 16)
        Me.Txt_aut.MaxLength = 0
        Me.Txt_aut.Name = "Txt_aut"
        Me.Txt_aut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_aut.Size = New System.Drawing.Size(305, 22)
        Me.Txt_aut.TabIndex = 19
        '
        'Txt_naz
        '
        Me.Txt_naz.AcceptsReturn = True
        Me.Txt_naz.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_naz.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_naz.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_naz.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_naz.Location = New System.Drawing.Point(128, 48)
        Me.Txt_naz.MaxLength = 0
        Me.Txt_naz.Name = "Txt_naz"
        Me.Txt_naz.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_naz.Size = New System.Drawing.Size(305, 20)
        Me.Txt_naz.TabIndex = 18
        '
        'Txt_typ
        '
        Me.Txt_typ.AcceptsReturn = True
        Me.Txt_typ.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_typ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_typ.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_typ.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_typ.Location = New System.Drawing.Point(128, 80)
        Me.Txt_typ.MaxLength = 0
        Me.Txt_typ.Name = "Txt_typ"
        Me.Txt_typ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_typ.Size = New System.Drawing.Size(185, 20)
        Me.Txt_typ.TabIndex = 17
        '
        'Txt_inst
        '
        Me.Txt_inst.AcceptsReturn = True
        Me.Txt_inst.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_inst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_inst.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_inst.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_inst.Location = New System.Drawing.Point(128, 104)
        Me.Txt_inst.MaxLength = 0
        Me.Txt_inst.Name = "Txt_inst"
        Me.Txt_inst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_inst.Size = New System.Drawing.Size(305, 20)
        Me.Txt_inst.TabIndex = 16
        '
        'Txt_Lap
        '
        Me.Txt_Lap.AcceptsReturn = True
        Me.Txt_Lap.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_Lap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Lap.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Lap.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_Lap.Location = New System.Drawing.Point(176, 144)
        Me.Txt_Lap.MaxLength = 0
        Me.Txt_Lap.Name = "Txt_Lap"
        Me.Txt_Lap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Lap.Size = New System.Drawing.Size(121, 20)
        Me.Txt_Lap.TabIndex = 15
        '
        'Txt_Wip
        '
        Me.Txt_Wip.AcceptsReturn = True
        Me.Txt_Wip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_Wip.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Wip.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Wip.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_Wip.Location = New System.Drawing.Point(176, 168)
        Me.Txt_Wip.MaxLength = 0
        Me.Txt_Wip.Name = "Txt_Wip"
        Me.Txt_Wip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Wip.Size = New System.Drawing.Size(121, 20)
        Me.Txt_Wip.TabIndex = 14
        '
        'Txt_pop
        '
        Me.Txt_pop.AcceptsReturn = True
        Me.Txt_pop.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_pop.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_pop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pop.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_pop.Location = New System.Drawing.Point(128, 200)
        Me.Txt_pop.MaxLength = 0
        Me.Txt_pop.Multiline = True
        Me.Txt_pop.Name = "Txt_pop"
        Me.Txt_pop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_pop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_pop.Size = New System.Drawing.Size(305, 57)
        Me.Txt_pop.TabIndex = 13
        '
        'Txt_rem
        '
        Me.Txt_rem.AcceptsReturn = True
        Me.Txt_rem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_rem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_rem.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_rem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_rem.Location = New System.Drawing.Point(128, 272)
        Me.Txt_rem.MaxLength = 0
        Me.Txt_rem.Multiline = True
        Me.Txt_rem.Name = "Txt_rem"
        Me.Txt_rem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_rem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_rem.Size = New System.Drawing.Size(305, 49)
        Me.Txt_rem.TabIndex = 12
        '
        'Txt_Num
        '
        Me.Txt_Num.AcceptsReturn = True
        Me.Txt_Num.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_Num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Num.Font = New System.Drawing.Font("Arial", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Location = New System.Drawing.Point(152, 336)
        Me.Txt_Num.MaxLength = 0
        Me.Txt_Num.Name = "Txt_Num"
        Me.Txt_Num.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Num.Size = New System.Drawing.Size(137, 34)
        Me.Txt_Num.TabIndex = 9
        Me.Txt_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Autor"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Název díla"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(16, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(105, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Typ díla"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Instance"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(16, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(137, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Cena v Laithanoru"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(16, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(137, 17)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Cena ve Wittgardu"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(16, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(105, 17)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Obsah/Popis"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(16, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(105, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Poznámky"
        '
        'Bt_List
        '
        Me.Bt_List.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Bt_List.Image = CType(resources.GetObject("Bt_List.Image"), System.Drawing.Image)
        Me.Bt_List.Location = New System.Drawing.Point(312, 144)
        Me.Bt_List.Name = "Bt_List"
        Me.Bt_List.Size = New System.Drawing.Size(120, 48)
        Me.Bt_List.TabIndex = 48
        Me.Bt_List.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Frm_Art
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(444, 576)
        Me.Controls.Add(Me.Bt_List)
        Me.Controls.Add(Me.Txt_aut)
        Me.Controls.Add(Me.Txt_naz)
        Me.Controls.Add(Me.Txt_typ)
        Me.Controls.Add(Me.Txt_inst)
        Me.Controls.Add(Me.Txt_Lap)
        Me.Controls.Add(Me.Txt_Wip)
        Me.Controls.Add(Me.Txt_pop)
        Me.Controls.Add(Me.Txt_rem)
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 30)
        Me.MaximizeBox = False
        Me.Name = "Frm_Art"
        Me.Opacity = 0.9
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC AVATAR - Odria Art"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Frm_Art
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Frm_Art
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Frm_Art()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As Frm_Art)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region

    Private Sub Frm_ATsez_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles my_sez.Closed
        If Tart <> "" Then
            ATposition = 0
            Do Until (ATrec.Tables("at").Rows(ATposition)("ID") = Tart)
                ATposition += 1
            Loop
        End If
        FillForm()
        Me.Refresh()
    End Sub

    Private Sub Cmd_Back_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Back.Click
        ATposition -= 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_First_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_First.Click
        ATposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Forward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Forward.Click
        ATposition += 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Last_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Last.Click
        ATposition = ATcount - 1
        Call FillForm()
    End Sub

    Private Sub Cmd_New_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_New.Click
        Txt_aut.Text = ""
        Txt_naz.Text = ""
        Txt_typ.Text = ""
        Txt_inst.Text = ""
        Txt_Lap.Text = ""
        Txt_Wip.Text = ""
        Txt_pop.Text = ""
        Txt_rem.Text = ""
        Cmd_Print.Enabled = False
        Cmd_Del.Enabled = False
        Txt_Num.Text = "NEW"
    End Sub

    Private Sub Frm_Art_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call ATrecopen()
        ATposition = 0
        ApplyColor()
        Call FillForm()
        AT = True
    End Sub


    Private Sub ATrecopen()
        Dim skc As New OleDbCommand
        skc.Connection = Odrialink2
        Select Case ATorder
            Case Is = 1
                If ATdirect = 1 Then
                    skc.CommandText = "select * from Art order by Author, Name, Instance"
                Else
                    skc.CommandText = "select * from Art order by Author, Name, Instance desc"
                End If
            Case Is = 2
                If ATdirect = 1 Then
                    skc.CommandText = "select * from Art order by Type, Author, Name, Instance"
                Else
                    skc.CommandText = "select * from Art order by Type, Author, Name, Instance desc"
                End If
            Case Is = 3
                If ATdirect = 1 Then
                    skc.CommandText = "select * from Art order by Name, Instance"
                Else
                    skc.CommandText = "select * from Art order by Name, Instance desc"
                End If
        End Select
        ATdat.SelectCommand = skc
        ATrec.Clear()
        ATdat.Fill(ATrec, "at")
        ATcount = ATrec.Tables("at").Rows.Count
    End Sub


    Private Sub FillForm()


        Txt_aut.Text = ATrec.Tables("at").Rows(ATposition)("Author")
        If Not IsDBNull(ATrec.Tables("at").Rows(ATposition)("Name")) Then
            Txt_naz.Text = ATrec.Tables("at").Rows(ATposition)("Name")
        Else
            Txt_naz.Text = ""
        End If
        If Not IsDBNull(ATrec.Tables("at").Rows(ATposition)("Type")) Then
            Txt_typ.Text = ATrec.Tables("at").Rows(ATposition)("Type")
        Else
            Txt_typ.Text = ""
        End If
        If Not IsDBNull(ATrec.Tables("at").Rows(ATposition)("Instance")) Then
            Txt_inst.Text = ATrec.Tables("at").Rows(ATposition)("Instance")
        Else
            Txt_inst.Text = ""
        End If
        If Not IsDBNull(ATrec.Tables("at").Rows(ATposition)("Content")) Then
            Txt_pop.Text = ATrec.Tables("at").Rows(ATposition)("Content")
        Else
            Txt_pop.Text = ""
        End If
        If Not IsDBNull(ATrec.Tables("at").Rows(ATposition)("Remark")) Then
            Txt_rem.Text = ATrec.Tables("at").Rows(ATposition)("Remark")
        Else
            Txt_rem.Text = ""
        End If
        If Not IsDBNull(ATrec.Tables("at").Rows(ATposition)("Laithanor_cost")) Then
            Txt_Lap.Text = ATrec.Tables("at").Rows(ATposition)("Laithanor_cost")
        Else
            Txt_Lap.Text = ""
        End If
        If Not IsDBNull(ATrec.Tables("at").Rows(ATposition)("Wittgard_cost")) Then
            Txt_Wip.Text = ATrec.Tables("at").Rows(ATposition)("Wittgard_cost")
        Else
            Txt_Wip.Text = ""
        End If
        If ATposition = 0 Then
            Cmd_Back.Enabled = False
        Else
            Cmd_Back.Enabled = True
        End If
        Cmd_Del.Enabled = True
        Cmd_Find.Enabled = True
        If ATposition + 1 = ATcount Then
            Cmd_Forward.Enabled = False
        Else
            Cmd_Forward.Enabled = True
        End If
        Cmd_Ins.Enabled = True
        Cmd_New.Enabled = True
        Cmd_Print.Enabled = True


        Txt_Num.Text = (ATposition + 1) & "/" & ATcount

    End Sub


    Private Sub Frm_Art_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        AT = False
        ATrec.Clear()
    End Sub

    Private Sub Txt_Num_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Num.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Not IsNumeric(Txt_Num.Text) Then
                MsgBox("Tady musí být číslo!", MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            If CShort(Txt_Num.Text) > ATcount Or CShort(Txt_Num.Text) < 1 Then
                MsgBox("Číslo musí být v rozsahu 1 - počet záznamů!", MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            KeyAscii = 0
            ATposition = CShort(Txt_Num.Text) - 1
            Call FillForm()
        End If
EventExitSub:
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Cmd_Print_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Print.Click
        Dim ATrint As New ATPrint
        ATrint.Show()
    End Sub

    Private Sub Cmd_Order_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Order.Click
        OrderControl = "AT"
        FO = New Frm_Ordering
        FO.ShowDialog()
        FO = Nothing
        ATrec.Clear()
        Call ATrecopen()
        ATposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Ins_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Ins.Click

        If Txt_aut.Text = "" Then
            MsgBox("Dílo musí mít autora!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        If Txt_naz.Text = "" Then
            MsgBox("Dílo se musí nějak jmenovat!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        Dim tsc As New OleDbCommand
        Dim treader As OleDbDataReader
        Try
            tsc.Connection = Odrialink2
            tsc.CommandText = "select * from Art where Author = @sk and Name = @na and Instance = @in"
            tsc.Parameters.AddWithValue("@sk", Txt_aut.Text)
            tsc.Parameters.AddWithValue("@na", Txt_naz.Text)
            tsc.Parameters.AddWithValue("@in", Txt_inst.Text)
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
                s1 = "INSERT INTO Art (Author, Name"
                s2 = " VALUES (@sk, @na"
                ic.Parameters.AddWithValue("@sk", Txt_aut.Text)
                ic.Parameters.AddWithValue("@na", Txt_naz.Text)
                If Txt_typ.Text <> "" Then
                    ic.Parameters.AddWithValue("@se", Trim(Txt_typ.Text))
                    s1 = s1 & ", Type"
                    s2 = s2 & ", @se"
                End If
                If Txt_inst.Text <> "" Then
                    ic.Parameters.AddWithValue("@in", Trim(Txt_inst.Text))
                    s1 = s1 & ", Instance"
                    s2 = s2 & ", @in"
                End If
                If Txt_pop.Text <> "" Then
                    ic.Parameters.AddWithValue("@co", Trim(Txt_pop.Text))
                    s1 = s1 & ", Content"
                    s2 = s2 & ", @co"
                End If
                If Txt_rem.Text <> "" Then
                    ic.Parameters.AddWithValue("@re", Trim(Txt_rem.Text))
                    s1 = s1 & ", Remark"
                    s2 = s2 & ", @re"
                End If
                If Txt_Lap.Text <> "" Then
                    ic.Parameters.AddWithValue("@lc", Trim(Txt_Lap.Text))
                    s1 = s1 & ", Laithanor_cost"
                    s2 = s2 & ", @lc"
                End If
                If Txt_Wip.Text <> "" Then
                    ic.Parameters.AddWithValue("@wc", Trim(Txt_Wip.Text))
                    s1 = s1 & ", Wittgard_cost"
                    s2 = s2 & ", @wc"
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
            OperationP = "INSERT"
            OnTable = "Art"
            Dim tsx As New OleDbCommand
            Dim xreader As OleDbDataReader
            Try
                tsx.Connection = Odrialink2
                tsx.CommandText = "select * from Art where Author = @sk and Name = @na and Instance = @in"
                tsx.Parameters.AddWithValue("@sk", Txt_aut.Text)
                tsx.Parameters.AddWithValue("@na", Txt_naz.Text)
                tsx.Parameters.AddWithValue("@in", Txt_inst.Text)
                xreader = tsc.ExecuteReader
                xreader.Read()
            Catch ex As Exception
                MsgBox("Chyba při kontrolním čtení databáze: " + ex.Message, , "CHYBA")
                xreader.Close()
                Exit Sub
            End Try
            NewData = xreader.GetValue(0) & "|" & xreader.GetString(1) & "|" & xreader.GetString(2) & "|" & xreader.GetString(3) & "|" & xreader.GetString(4) & "|" & xreader.GetString(5) & "|" & xreader.GetString(6) & "|" & xreader.GetString(7) & "|" & xreader.GetString(8)
            xreader.Close()
            Do Until Undergo = False
                Continue Do
            Loop
            ChangeDemon()
            ATrec.Clear()
            ATdat.Fill(ATrec, "at")
            ATcount = ATrec.Tables("at").Rows.Count
            Call FillForm()
        Else
            treader.Close()
            If MsgBox("Dílo tohoto autora, jména a instance již v databázi existuje, chcete jej přepsat?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Upozornění") = MsgBoxResult.Yes Then
                Try
                    Dim s3 As String
                    Dim uc As New OleDbCommand
                    s3 = "UPDATE Art set Author = @sk, Name = @di, Type = @aa, Instance = @us, Laithanor_cost = @hi, Wittgard_cost = @re, Content = @o3, Remark = @rm WHERE ID = @ID"
                    uc.Parameters.AddWithValue("@sk", Txt_aut.Text)
                    NewData = Txt_aut.Text
                    uc.Parameters.AddWithValue("@di", Txt_naz.Text)
                    NewData = NewData & "|" & Txt_naz.Text
                    If Txt_typ.Text = "" Then
                        uc.Parameters.AddWithValue("@aa", System.DBNull.Value)
                        NewData = NewData & "|"
                    Else
                        uc.Parameters.AddWithValue("@aa", Trim(Txt_typ.Text))
                        NewData = NewData & "|" & Txt_typ.Text
                    End If
                    If Txt_inst.Text = "" Then
                        uc.Parameters.AddWithValue("@us", System.DBNull.Value)
                        NewData = NewData & "|"
                    Else
                        uc.Parameters.AddWithValue("@us", Trim(Txt_inst.Text))
                        NewData = NewData & "|" & Txt_inst.Text
                    End If
                    If Txt_Lap.Text = "" Then
                        uc.Parameters.AddWithValue("@hi", System.DBNull.Value)
                        NewData = NewData & "|"
                    Else
                        uc.Parameters.AddWithValue("@hi", Trim(Txt_Lap.Text))
                        NewData = NewData & "|" & Txt_Lap.Text
                    End If
                    If Txt_Wip.Text = "" Then
                        uc.Parameters.AddWithValue("@re", System.DBNull.Value)
                        NewData = NewData & "|"
                    Else
                        uc.Parameters.AddWithValue("@re", Trim(Txt_Wip.Text))
                        NewData = NewData & "|" & Txt_Wip.Text
                    End If
                    If Txt_pop.Text = "" Then
                        uc.Parameters.AddWithValue("@o3", System.DBNull.Value)
                        NewData = NewData & "|"
                    Else
                        uc.Parameters.AddWithValue("@o3", Trim(Txt_pop.Text))
                        NewData = NewData & "|" & Txt_pop.Text
                    End If
                    If Txt_rem.Text = "" Then
                        uc.Parameters.AddWithValue("@rm", System.DBNull.Value)
                        NewData = NewData & "|"
                    Else
                        uc.Parameters.AddWithValue("@rm", Trim(Txt_rem.Text))
                        NewData = NewData & "|" & Txt_rem.Text
                    End If
                    uc.Parameters.AddWithValue("@ID", ATrec.Tables("at").Rows(ATposition)("ID"))
                    NewData = ATrec.Tables("at").Rows(ATposition)("ID") & "|" & NewData
                    uc.Connection = Odrialink2
                    uc.CommandText = s3
                    uc.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Chyba updatu případu: " + ex.Message, , "Pokus o update")
                    Exit Sub
                End Try
                OperationP = "UPDATE"
                OnTable = "Art"
                OldData = ATrec.Tables("at").Rows(ATposition)("ID") & "|" & ATrec.Tables("at").Rows(ATposition)("Author") & "|" & ATrec.Tables("at").Rows(ATposition)("Name") & "|" & ATrec.Tables("at").Rows(ATposition)("Type") & "|" & ATrec.Tables("at").Rows(ATposition)("Instance") & "|" & ATrec.Tables("at").Rows(ATposition)("Laithanor_cost") & "|" & ATrec.Tables("at").Rows(ATposition)("Wittgard_cost") & "|" & ATrec.Tables("at").Rows(ATposition)("Content") & "|" & ATrec.Tables("at").Rows(ATposition)("Remark")
                Do Until Undergo = False
                    Continue Do
                Loop
                ChangeDemon()
                ATrec.Clear()
                ATdat.Fill(ATrec, "at")
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
        Dim ski, dif, aat, usa, his, rea, jj, wic As Boolean
        se.Connection = Odrialink2
        s = "SELECT * from Art WHERE "

        If Txt_aut.Text <> "" Then
            s = s & "Author LIKE @sk"
            se.Parameters.AddWithValue("@sk", "%" & Txt_aut.Text & "%")
            ski = True
        End If
        If Txt_naz.Text <> "" Then
            If ski Then
                s = s & " AND "
            End If
            s = s & "Name LIKE @di"
            se.Parameters.AddWithValue("@di", "%" & Txt_naz.Text & "%")
            dif = True
        End If
        If Txt_typ.Text <> "" Then
            If ski Or dif Then
                s = s & " AND "
            End If
            s = s & "Type LIKE @aa"
            se.Parameters.AddWithValue("@aa", "%" & Txt_typ.Text & "%")
            aat = True
        End If
        If Txt_inst.Text <> "" Then
            If ski Or dif Or aat Then
                s = s & " AND "
            End If
            s = s & "Instance LIKE @us"
            se.Parameters.AddWithValue("@us", "%" & Txt_inst.Text & "%")
            usa = True
        End If
        If Txt_pop.Text <> "" Then
            If ski Or dif Or aat Or usa Then
                s = s & " AND "
            End If
            s = s & "Content LIKE @hi"
            se.Parameters.AddWithValue("@hi", "%" & Txt_pop.Text & "%")
            his = True
        End If
        If Txt_rem.Text <> "" Then
            If ski Or dif Or aat Or usa Or his Then
                s = s & " AND "
            End If
            s = s & "Remark LIKE @re"
            se.Parameters.AddWithValue("@re", "%" & Txt_rem.Text & "%")
            rea = True
        End If
        If Txt_Lap.Text <> "" Then
            If ski Or dif Or aat Or usa Or his Or rea Then
                s = s & " AND "
            End If
            s = s & "Laithanor_cost LIKE @o3"
            se.Parameters.AddWithValue("@o3", "%" & Txt_Lap.Text & "%")
            jj = True
        End If
        If Txt_Wip.Text <> "" Then
            If ski Or dif Or aat Or usa Or his Or rea Or jj Then
                s = s & " AND "
            End If
            s = s & "Wittgard_cost LIKE @wc"
            se.Parameters.AddWithValue("@wc", "%" & Txt_Wip.Text & "%")
            wic = True
        End If
        ATposition = 0
        If s = "SELECT * from Art WHERE " Then
            ATrecopen()
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
                        If Txt_aut.Text = ATrec.Tables("at").Rows(ATposition)("Author") And Txt_naz.Text = ATrec.Tables("at").Rows(ATposition)("Name") And Txt_inst.Text = ATrec.Tables("at").Rows(ATposition)("Instance") Then
                            Exit Do
                        End If
                        ATposition += 1
                    Loop Until ATposition + 1 = ATcount
                Else
                    ATdat.SelectCommand = se
                    ATrec.Clear()
                    ATdat.Fill(ATrec, "at")
                    ATcount = ATrec.Tables("at").Rows.Count
                    If GC_list = 1 Then
                        If my_sez Is Nothing Then
                            my_sez = New Frm_ATsez
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
        If MsgBox("Opravdu vymazat dílo " & Txt_aut.Text & " " & Txt_naz.Text & " " & Txt_inst.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Upozornění") = MsgBoxResult.Yes Then
            Try
                tsc.Connection = Odrialink2
                tsc.CommandText = "DELETE from Art WHERE ID = @ID"
                tsc.Parameters.AddWithValue("@ID", ATrec.Tables("at").Rows(ATposition)("ID"))
                tsc.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception("Chyba při výmazu případu: " + ex.Message)
                Exit Sub
            End Try
        Else
            Exit Sub
        End If
        OperationP = "DELETE"
        OnTable = "Art"
        OldData = ATrec.Tables("at").Rows(ATposition)("ID") & "|" & ATrec.Tables("at").Rows(ATposition)("Author") & "|" & ATrec.Tables("at").Rows(ATposition)("Name") & "|" & ATrec.Tables("at").Rows(ATposition)("Type") & "|" & ATrec.Tables("at").Rows(ATposition)("Instance") & "|" & ATrec.Tables("at").Rows(ATposition)("Laithanor_cost") & "|" & ATrec.Tables("at").Rows(ATposition)("Wittgard_cost") & "|" & ATrec.Tables("at").Rows(ATposition)("Content") & "|" & ATrec.Tables("at").Rows(ATposition)("Remark")
        Do Until Undergo = False
            Continue Do
        Loop
        ChangeDemon()
        ATrec.Clear()
        ATdat.Fill(ATrec, "at")
        ATcount = ATrec.Tables("at").Rows.Count
        If ATposition = ATcount Then
            ATposition -= 1
        End If
        Call FillForm()
    End Sub

    Private Sub Bt_List_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_List.Click
        If my_sez Is Nothing Then
            my_sez = New Frm_ATsez
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
        Me.BackColor = Color.FromArgb(FUB)
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
        Label1.ForeColor = Color.FromArgb(FUF)
        Label2.ForeColor = Color.FromArgb(FUF)
        Label3.ForeColor = Color.FromArgb(FUF)
        Label4.ForeColor = Color.FromArgb(FUF)
        Label5.ForeColor = Color.FromArgb(FUF)
        Label6.ForeColor = Color.FromArgb(FUF)
        Label7.ForeColor = Color.FromArgb(FUF)
        Label9.ForeColor = Color.FromArgb(FUF)
        Txt_Num.ForeColor = Color.FromArgb(FUF)
        Txt_aut.ForeColor = Color.FromArgb(FUF)
        Txt_naz.ForeColor = Color.FromArgb(FUF)
        Txt_typ.ForeColor = Color.FromArgb(FUF)
        Txt_inst.ForeColor = Color.FromArgb(FUF)
        Txt_pop.ForeColor = Color.FromArgb(FUF)
        Txt_rem.ForeColor = Color.FromArgb(FUF)
        Txt_Lap.ForeColor = Color.FromArgb(FUF)
        Txt_Wip.ForeColor = Color.FromArgb(FUF)

    End Sub
End Class