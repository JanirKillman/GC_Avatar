Option Strict Off
Option Explicit On 
Imports System.Data.OleDb
Friend Class Frm_Efficiency
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
	Public WithEvents Txt_rof As System.Windows.Forms.TextBox
	Public WithEvents Txt_e As System.Windows.Forms.TextBox
	Public WithEvents Txt_DMC As System.Windows.Forms.TextBox
	Public WithEvents Txt_v As System.Windows.Forms.TextBox
	Public WithEvents Txt_p As System.Windows.Forms.TextBox
	Public WithEvents Txt_dz As System.Windows.Forms.TextBox
	Public WithEvents Txt_f As System.Windows.Forms.TextBox
	Public WithEvents Cmd_First As System.Windows.Forms.Button
	Public WithEvents Cmd_Back As System.Windows.Forms.Button
	Public WithEvents Txt_Num As System.Windows.Forms.TextBox
	Public WithEvents Cmd_Forward As System.Windows.Forms.Button
	Public WithEvents Cmd_Last As System.Windows.Forms.Button
	Public WithEvents Cmd_New As System.Windows.Forms.Button
	Public WithEvents Cmd_Del As System.Windows.Forms.Button
	Public WithEvents Cmd_Ins As System.Windows.Forms.Button
	Public WithEvents Cmd_Exit As System.Windows.Forms.Button
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents Bt_List As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Efficiency))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cmd_First = New System.Windows.Forms.Button
        Me.Cmd_Back = New System.Windows.Forms.Button
        Me.Cmd_Forward = New System.Windows.Forms.Button
        Me.Cmd_Last = New System.Windows.Forms.Button
        Me.Cmd_New = New System.Windows.Forms.Button
        Me.Cmd_Del = New System.Windows.Forms.Button
        Me.Cmd_Ins = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Txt_rem = New System.Windows.Forms.TextBox
        Me.Txt_rof = New System.Windows.Forms.TextBox
        Me.Txt_e = New System.Windows.Forms.TextBox
        Me.Txt_DMC = New System.Windows.Forms.TextBox
        Me.Txt_v = New System.Windows.Forms.TextBox
        Me.Txt_p = New System.Windows.Forms.TextBox
        Me.Txt_dz = New System.Windows.Forms.TextBox
        Me.Txt_f = New System.Windows.Forms.TextBox
        Me.Txt_Num = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Bt_List = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Cmd_First
        '
        Me.Cmd_First.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmd_First.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_First.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_First.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_First.Image = CType(resources.GetObject("Cmd_First.Image"), System.Drawing.Image)
        Me.Cmd_First.Location = New System.Drawing.Point(8, 208)
        Me.Cmd_First.Name = "Cmd_First"
        Me.Cmd_First.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_First.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_First.TabIndex = 8
        Me.Cmd_First.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_First, "Na začátek")
        Me.Cmd_First.UseVisualStyleBackColor = False
        '
        'Cmd_Back
        '
        Me.Cmd_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmd_Back.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Back.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Back.Image = CType(resources.GetObject("Cmd_Back.Image"), System.Drawing.Image)
        Me.Cmd_Back.Location = New System.Drawing.Point(48, 208)
        Me.Cmd_Back.Name = "Cmd_Back"
        Me.Cmd_Back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Back.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_Back.TabIndex = 7
        Me.Cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Back, "O 1 vzad")
        Me.Cmd_Back.UseVisualStyleBackColor = False
        '
        'Cmd_Forward
        '
        Me.Cmd_Forward.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmd_Forward.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Forward.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Forward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Forward.Image = CType(resources.GetObject("Cmd_Forward.Image"), System.Drawing.Image)
        Me.Cmd_Forward.Location = New System.Drawing.Point(224, 208)
        Me.Cmd_Forward.Name = "Cmd_Forward"
        Me.Cmd_Forward.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Forward.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_Forward.TabIndex = 5
        Me.Cmd_Forward.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Forward, "O 1 vpřed")
        Me.Cmd_Forward.UseVisualStyleBackColor = False
        '
        'Cmd_Last
        '
        Me.Cmd_Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmd_Last.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Last.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Last.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Last.Image = CType(resources.GetObject("Cmd_Last.Image"), System.Drawing.Image)
        Me.Cmd_Last.Location = New System.Drawing.Point(264, 208)
        Me.Cmd_Last.Name = "Cmd_Last"
        Me.Cmd_Last.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Last.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_Last.TabIndex = 4
        Me.Cmd_Last.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Last, "Na konec")
        Me.Cmd_Last.UseVisualStyleBackColor = False
        '
        'Cmd_New
        '
        Me.Cmd_New.BackColor = System.Drawing.Color.White
        Me.Cmd_New.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_New.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_New.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_New.Location = New System.Drawing.Point(192, 296)
        Me.Cmd_New.Name = "Cmd_New"
        Me.Cmd_New.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_New.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_New.TabIndex = 3
        Me.Cmd_New.Text = "NOVÁ"
        Me.ToolTip1.SetToolTip(Me.Cmd_New, "Vymaže pole, příprava na vepsání nového kouzla")
        Me.Cmd_New.UseVisualStyleBackColor = False
        '
        'Cmd_Del
        '
        Me.Cmd_Del.BackColor = System.Drawing.Color.Red
        Me.Cmd_Del.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Del.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Del.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Del.Location = New System.Drawing.Point(8, 296)
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
        Me.Cmd_Ins.Location = New System.Drawing.Point(104, 248)
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
        Me.Cmd_Exit.Location = New System.Drawing.Point(8, 336)
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
        Me.Txt_rem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_rem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_rem.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_rem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_rem.Location = New System.Drawing.Point(104, 176)
        Me.Txt_rem.MaxLength = 0
        Me.Txt_rem.Name = "Txt_rem"
        Me.Txt_rem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_rem.Size = New System.Drawing.Size(201, 19)
        Me.Txt_rem.TabIndex = 24
        '
        'Txt_rof
        '
        Me.Txt_rof.AcceptsReturn = True
        Me.Txt_rof.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_rof.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_rof.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_rof.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_rof.Location = New System.Drawing.Point(104, 152)
        Me.Txt_rof.MaxLength = 0
        Me.Txt_rof.Name = "Txt_rof"
        Me.Txt_rof.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_rof.Size = New System.Drawing.Size(201, 19)
        Me.Txt_rof.TabIndex = 22
        '
        'Txt_e
        '
        Me.Txt_e.AcceptsReturn = True
        Me.Txt_e.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_e.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_e.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_e.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_e.Location = New System.Drawing.Point(104, 128)
        Me.Txt_e.MaxLength = 0
        Me.Txt_e.Name = "Txt_e"
        Me.Txt_e.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_e.Size = New System.Drawing.Size(201, 19)
        Me.Txt_e.TabIndex = 20
        '
        'Txt_DMC
        '
        Me.Txt_DMC.AcceptsReturn = True
        Me.Txt_DMC.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_DMC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_DMC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DMC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_DMC.Location = New System.Drawing.Point(104, 104)
        Me.Txt_DMC.MaxLength = 0
        Me.Txt_DMC.Name = "Txt_DMC"
        Me.Txt_DMC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_DMC.Size = New System.Drawing.Size(201, 19)
        Me.Txt_DMC.TabIndex = 18
        '
        'Txt_v
        '
        Me.Txt_v.AcceptsReturn = True
        Me.Txt_v.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_v.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_v.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_v.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_v.Location = New System.Drawing.Point(104, 80)
        Me.Txt_v.MaxLength = 0
        Me.Txt_v.Name = "Txt_v"
        Me.Txt_v.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_v.Size = New System.Drawing.Size(201, 19)
        Me.Txt_v.TabIndex = 16
        '
        'Txt_p
        '
        Me.Txt_p.AcceptsReturn = True
        Me.Txt_p.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_p.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_p.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_p.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_p.Location = New System.Drawing.Point(104, 56)
        Me.Txt_p.MaxLength = 0
        Me.Txt_p.Name = "Txt_p"
        Me.Txt_p.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_p.Size = New System.Drawing.Size(201, 19)
        Me.Txt_p.TabIndex = 14
        '
        'Txt_dz
        '
        Me.Txt_dz.AcceptsReturn = True
        Me.Txt_dz.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_dz.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_dz.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_dz.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_dz.Location = New System.Drawing.Point(104, 32)
        Me.Txt_dz.MaxLength = 0
        Me.Txt_dz.Name = "Txt_dz"
        Me.Txt_dz.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_dz.Size = New System.Drawing.Size(201, 19)
        Me.Txt_dz.TabIndex = 12
        '
        'Txt_f
        '
        Me.Txt_f.AcceptsReturn = True
        Me.Txt_f.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_f.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_f.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_f.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_f.Location = New System.Drawing.Point(104, 8)
        Me.Txt_f.MaxLength = 0
        Me.Txt_f.Name = "Txt_f"
        Me.Txt_f.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_f.Size = New System.Drawing.Size(201, 19)
        Me.Txt_f.TabIndex = 10
        '
        'Txt_Num
        '
        Me.Txt_Num.AcceptsReturn = True
        Me.Txt_Num.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_Num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Num.Font = New System.Drawing.Font("Arial", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Location = New System.Drawing.Point(88, 208)
        Me.Txt_Num.MaxLength = 0
        Me.Txt_Num.Name = "Txt_Num"
        Me.Txt_Num.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Num.Size = New System.Drawing.Size(137, 33)
        Me.Txt_Num.TabIndex = 6
        Me.Txt_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(8, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(89, 17)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Poznámky"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(8, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Rate of Fire"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(89, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Energy"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(8, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Damage"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Vzor"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Poddruh"
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(8, 32)
        Me.label2.Name = "label2"
        Me.label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label2.Size = New System.Drawing.Size(89, 17)
        Me.label2.TabIndex = 11
        Me.label2.Text = "Druh zbraně"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Firma"
        '
        'Bt_List
        '
        Me.Bt_List.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Bt_List.Image = CType(resources.GetObject("Bt_List.Image"), System.Drawing.Image)
        Me.Bt_List.Location = New System.Drawing.Point(128, 288)
        Me.Bt_List.Name = "Bt_List"
        Me.Bt_List.Size = New System.Drawing.Size(56, 40)
        Me.Bt_List.TabIndex = 48
        Me.Bt_List.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Frm_Efficiency
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(313, 402)
        Me.Controls.Add(Me.Bt_List)
        Me.Controls.Add(Me.Txt_rem)
        Me.Controls.Add(Me.Txt_rof)
        Me.Controls.Add(Me.Txt_e)
        Me.Controls.Add(Me.Txt_DMC)
        Me.Controls.Add(Me.Txt_v)
        Me.Controls.Add(Me.Txt_p)
        Me.Controls.Add(Me.Txt_dz)
        Me.Controls.Add(Me.Txt_f)
        Me.Controls.Add(Me.Cmd_First)
        Me.Controls.Add(Me.Cmd_Back)
        Me.Controls.Add(Me.Txt_Num)
        Me.Controls.Add(Me.Cmd_Forward)
        Me.Controls.Add(Me.Cmd_Last)
        Me.Controls.Add(Me.Cmd_New)
        Me.Controls.Add(Me.Cmd_Del)
        Me.Controls.Add(Me.Cmd_Ins)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.Name = "Frm_Efficiency"
        Me.Opacity = 0.9
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC AVATAR - Odria weapons efficiency"
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Frm_Efficiency
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Frm_Efficiency
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Frm_Efficiency()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As Frm_Efficiency)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region
    Private Sub Frm_EFsez_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles my_sez.Closed
        If Tef <> "" Then
            EFposition = 0
            Do Until (EFrec.Tables("ef").Rows(EFposition)("Kód") = Tef)
                EFposition += 1
            Loop
        End If
        FillForm()
        Me.Refresh()
    End Sub

    Private Sub Cmd_Back_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Back.Click
        EFposition -= 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_First_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_First.Click
        EFposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Forward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Forward.Click
        EFposition += 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Last_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Last.Click
        EFposition = EFcount - 1
        Call FillForm()
    End Sub

    Private Sub Cmd_New_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_New.Click
        Txt_f.Text = ""
        Txt_dz.Text = ""
        Txt_p.Text = ""
        Txt_v.Text = ""
        Txt_DMC.Text = ""
        Txt_e.Text = ""
        Txt_rof.Text = ""
        Txt_rem.Text = ""

        Cmd_Del.Enabled = False
        Txt_Num.Text = "NEW"
    End Sub

    Private Sub Frm_Efficiency_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call EFrecopen()
        EFposition = 0
        ApplyColor()
        Call FillForm()
        EF = True
    End Sub


    Private Sub EFrecopen()
        Dim skc As New OleDbCommand
        skc.Connection = Odrialink2
        skc.CommandText = "select * from Weapon_efficiency order by Firma, Druh_Zbraně, Poddruh, Vzor"
        EFdat.SelectCommand = skc
        EFrec.Clear()
        EFdat.Fill(EFrec, "ef")
        EFcount = EFrec.Tables("ef").Rows.Count
    End Sub


    Sub FillForm()


        Txt_f.Text = EFrec.Tables("ef").Rows(EFposition)("Firma")
        Txt_dz.Text = EFrec.Tables("ef").Rows(EFposition)("Druh_Zbraně")
        Txt_p.Text = EFrec.Tables("ef").Rows(EFposition)("Poddruh")
        Txt_v.Text = EFrec.Tables("ef").Rows(EFposition)("Vzor")
        If Not IsDBNull(EFrec.Tables("ef").Rows(EFposition)("DMC")) Then
            Txt_DMC.Text = EFrec.Tables("ef").Rows(EFposition)("DMC")
        Else
            Txt_DMC.Text = ""
        End If
        If Not IsDBNull(EFrec.Tables("ef").Rows(EFposition)("EC")) Then
            Txt_e.Text = EFrec.Tables("ef").Rows(EFposition)("EC")
        Else
            Txt_e.Text = ""
        End If
        If Not IsDBNull(EFrec.Tables("ef").Rows(EFposition)("ROF")) Then
            Txt_rof.Text = EFrec.Tables("ef").Rows(EFposition)("ROF")
        Else
            Txt_rof.Text = ""
        End If
        If Not IsDBNull(EFrec.Tables("ef").Rows(EFposition)("Poznámka")) Then
            Txt_rem.Text = EFrec.Tables("ef").Rows(EFposition)("Poznámka")
        Else
            Txt_rem.Text = ""
        End If
        If EFposition = 0 Then
            Cmd_Back.Enabled = False
        Else
            Cmd_Back.Enabled = True
        End If
        Cmd_Del.Enabled = True
        If EFposition + 1 = EFcount Then
            Cmd_Forward.Enabled = False
        Else
            Cmd_Forward.Enabled = True
        End If
        Cmd_Ins.Enabled = True
        Cmd_New.Enabled = True

        Txt_Num.Text = (EFposition + 1) & "/" & EFcount

    End Sub


    Private Sub Frm_Efficiency_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        EF = False
        EFrec.Clear()
    End Sub

    Private Sub Txt_Num_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Num.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Not IsNumeric(Txt_Num.Text) Then
                MsgBox("Tady musí být číslo!", MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            If CShort(Txt_Num.Text) > EFcount Or CShort(Txt_Num.Text) < 1 Then
                MsgBox("Číslo musí být v rozsahu 1 - počet záznamů!", MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            KeyAscii = 0
            EFposition = CShort(Txt_Num.Text) - 1
            Call FillForm()
        End If
EventExitSub:
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Cmd_Ins_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Ins.Click
        If Txt_f.Text = "" Then
            MsgBox("Firma musí být uvedena!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        If Txt_dz.Text = "" Then
            MsgBox("Druh zbraně musí být uveden!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        If Txt_p.Text = "" Then
            MsgBox("Poddruh musí být uveden!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        If Txt_v.Text = "" Then
            MsgBox("Vzor musí být uveden!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        Dim tsc As New OleDbCommand
        Dim treader As OleDbDataReader
        Try
            tsc.Connection = Odrialink2
            tsc.CommandText = "select * from Weapons_efficiency where Firma = @sk and Druh_Zbraně = @dz and Poddruh = @po and Vzor = @vz"
            tsc.Parameters.AddWithValue("@sk", Txt_f.Text)
            tsc.Parameters.AddWithValue("@dz", Txt_dz.Text)
            tsc.Parameters.AddWithValue("@po", Txt_p.Text)
            tsc.Parameters.AddWithValue("@vz", Txt_v.Text)
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
                s1 = "INSERT INTO Weapons_efficiency (Firma, Druh_Zbraně, Poddruh, Vzor"
                s2 = " VALUES (@sk, @dz, @po, @vz"
                ic.Parameters.AddWithValue("@sk", Txt_f.Text)
                ic.Parameters.AddWithValue("@dz", Txt_dz.Text)
                ic.Parameters.AddWithValue("@po", Txt_p.Text)
                ic.Parameters.AddWithValue("@vz", Txt_v.Text)
                If Txt_DMC.Text <> "" Then
                    ic.Parameters.AddWithValue("@se", Trim(Txt_DMC.Text))
                    s1 = s1 & ", DMC"
                    s2 = s2 & ", @se"
                End If
                If Txt_e.Text <> "" Then
                    ic.Parameters.AddWithValue("@ne", Trim(Txt_e.Text))
                    s1 = s1 & ", EC"
                    s2 = s2 & ", @ne"
                End If
                If Txt_rof.Text <> "" Then
                    ic.Parameters.AddWithValue("@go", Trim(Txt_rof.Text))
                    s1 = s1 & ", ROF"
                    s2 = s2 & ", @go"
                End If
                If Txt_rem.Text <> "" Then
                    ic.Parameters.AddWithValue("@j1", Trim(Txt_rem.Text))
                    s1 = s1 & ", Poznámka"
                    s2 = s2 & ", @j1"
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
            EFrec.Clear()
            EFdat.Fill(EFrec, "ef")
            EFcount = EFrec.Tables("ef").Rows.Count
            Call FillForm()
        Else
            treader.Close()
            If MsgBox("Takový záznam již v databázi existuje, chcete přepsat aktuální záznam?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Upozornění") = MsgBoxResult.Yes Then
                Try
                    Dim s3 As String
                    Dim uc As New OleDbCommand
                    s3 = "UPDATE Weapon_efficiency set Firma = @sk, Druh_Zbraně = @dz, Poddruh = @po, Vzor = @vz, DMC = @di, EC = @aa, ROF = @us, Poznámka = @hi WHERE Kód = @ID"
                    uc.Parameters.AddWithValue("@sk", Txt_f.Text)
                    uc.Parameters.AddWithValue("@dz", Txt_dz.Text)
                    uc.Parameters.AddWithValue("@po", Txt_p.Text)
                    uc.Parameters.AddWithValue("@vz", Txt_v.Text)
                    If Txt_DMC.Text = "" Then
                        uc.Parameters.AddWithValue("@di", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@di", Trim(Txt_DMC.Text))
                    End If
                    If Txt_e.Text = "" Then
                        uc.Parameters.AddWithValue("@aa", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@aa", Trim(Txt_e.Text))
                    End If
                    If Txt_rof.Text = "" Then
                        uc.Parameters.AddWithValue("@us", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@us", Trim(Txt_rof.Text))
                    End If
                    If Txt_rem.Text = "" Then
                        uc.Parameters.AddWithValue("@hi", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@hi", Trim(Txt_rem.Text))
                    End If
                    uc.Parameters.AddWithValue("@ID", EFrec.Tables("ef").Rows(EFposition)("Kód"))
                    uc.Connection = Odrialink2
                    uc.CommandText = s3
                    uc.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Chyba updatu případu: " + ex.Message, , "Pokus o update")
                    Exit Sub
                End Try
                EFrec.Clear()
                EFdat.Fill(EFrec, "ef")
                Call FillForm()
            Else
                Exit Sub
            End If
        End If

    End Sub


    Private Sub Cmd_Del_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Del.Click
        Dim tsc As New OleDbCommand
        If MsgBox("Opravdu vymazat tento záznam ?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Upozornění") = MsgBoxResult.Yes Then
            Try
                tsc.Connection = Odrialink2
                tsc.CommandText = "DELETE from Weapon_efficiency WHERE Kód = @ID"
                tsc.Parameters.AddWithValue("@ID", EFrec.Tables("ef").Rows(EFposition)("Kód"))
                tsc.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception("Chyba při výmazu případu: " + ex.Message)
                Exit Sub
            End Try
        Else
            Exit Sub
        End If
        EFrec.Clear()
        EFdat.Fill(EFrec, "ef")
        EFcount = EFrec.Tables("ef").Rows.Count
        If EFposition = EFcount Then
            EFposition -= 1
        End If
        Call FillForm()
    End Sub

    Private Sub Bt_List_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_List.Click
        If my_sez Is Nothing Then
            my_sez = New Frm_EFsez
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
        Me.BackColor = Color.FromArgb(FEFB)
        Cmd_Exit.BackColor = Color.FromArgb(COE)
        Cmd_Ins.BackColor = Color.FromArgb(COI)
        Cmd_Del.BackColor = Color.FromArgb(COD)
        Cmd_New.BackColor = Color.FromArgb(CON)
        Cmd_Ins.ForeColor = Color.FromArgb(COFO)
        Cmd_Del.ForeColor = Color.FromArgb(COFO)
        Cmd_New.ForeColor = Color.FromArgb(COFO)
        Label1.ForeColor = Color.FromArgb(FEFFO)
        label2.ForeColor = Color.FromArgb(FEFFO)
        Label3.ForeColor = Color.FromArgb(FEFFO)
        Label4.ForeColor = Color.FromArgb(FEFFO)
        Label5.ForeColor = Color.FromArgb(FEFFO)
        Label6.ForeColor = Color.FromArgb(FEFFO)
        Label7.ForeColor = Color.FromArgb(FEFFO)
        Label8.ForeColor = Color.FromArgb(FEFFO)
        Txt_Num.ForeColor = Color.FromArgb(FEFFO)
        Txt_f.ForeColor = Color.FromArgb(FEFFO)
        Txt_dz.ForeColor = Color.FromArgb(FEFFO)
        Txt_p.ForeColor = Color.FromArgb(FEFFO)
        Txt_v.ForeColor = Color.FromArgb(FEFFO)
        Txt_DMC.ForeColor = Color.FromArgb(FEFFO)
        Txt_e.ForeColor = Color.FromArgb(FEFFO)
        Txt_rof.ForeColor = Color.FromArgb(FEFFO)
        Txt_rem.ForeColor = Color.FromArgb(FEFFO)

    End Sub
End Class