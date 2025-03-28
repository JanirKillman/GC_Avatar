Option Strict Off
Option Explicit On 
Imports System.Data.OleDb
Imports System.IO
Imports System.Object
Imports System.MarshalByRefObject
Friend Class Frm_Weapons
    Inherits System.Windows.Forms.Form
    Private WithEvents my_sez As Form
    Private TLock As String
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
	Public WithEvents Txt_rar As System.Windows.Forms.TextBox
	Public WithEvents Txt_price As System.Windows.Forms.TextBox
	Public WithEvents Txt_rem As System.Windows.Forms.TextBox
	Public WithEvents Txt_pop As System.Windows.Forms.TextBox
	Public WithEvents Txt_ep As System.Windows.Forms.TextBox
	Public WithEvents Txt_eptyp As System.Windows.Forms.TextBox
	Public WithEvents Txt_mg As System.Windows.Forms.TextBox
	Public WithEvents Txt_spec As System.Windows.Forms.TextBox
	Public WithEvents Txt_stuff As System.Windows.Forms.TextBox
	Public WithEvents Txt_OC As System.Windows.Forms.TextBox
	Public WithEvents Txt_sa As System.Windows.Forms.TextBox
	Public WithEvents Txt_ut As System.Windows.Forms.TextBox
	Public WithEvents Txt_UC As System.Windows.Forms.TextBox
	Public WithEvents Txt_typ As System.Windows.Forms.TextBox
	Public WithEvents Txt_w As System.Windows.Forms.TextBox
	Public WithEvents Cmd_Last As System.Windows.Forms.Button
	Public WithEvents Cmd_Forward As System.Windows.Forms.Button
	Public WithEvents Txt_Num As System.Windows.Forms.TextBox
	Public WithEvents Cmd_Back As System.Windows.Forms.Button
	Public WithEvents Cmd_First As System.Windows.Forms.Button
	Public WithEvents Cmd_Exit As System.Windows.Forms.Button
	Public WithEvents Cmd_Ins As System.Windows.Forms.Button
	Public WithEvents Cmd_Del As System.Windows.Forms.Button
	Public WithEvents Cmd_Find As System.Windows.Forms.Button
	Public WithEvents Cmd_New As System.Windows.Forms.Button
	Public WithEvents Cmd_Print As System.Windows.Forms.Button
	Public WithEvents Cmd_Order As System.Windows.Forms.Button
	Public WithEvents Lst_spells As System.Windows.Forms.ListBox
	Public WithEvents Lst_skills As System.Windows.Forms.ListBox
	Public WithEvents Lst_res As System.Windows.Forms.ListBox
	Public WithEvents Cmd_as As System.Windows.Forms.Button
	Public WithEvents Cmd_ds As System.Windows.Forms.Button
	Public WithEvents Cmd_ak As System.Windows.Forms.Button
	Public WithEvents Cmd_dk As System.Windows.Forms.Button
	Public WithEvents Cmd_ar As System.Windows.Forms.Button
	Public WithEvents Cmd_dr As System.Windows.Forms.Button
	Public WithEvents Cmd_ss As System.Windows.Forms.Button
	Public WithEvents Cmd_sk As System.Windows.Forms.Button
	Public WithEvents Cmd_sr As System.Windows.Forms.Button
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Txt_Typg As System.Windows.Forms.TextBox
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Txt_pru As System.Windows.Forms.TextBox
    Public WithEvents Txt_drt As System.Windows.Forms.TextBox
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents Txt_ini As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Txt_len As System.Windows.Forms.TextBox
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents Txt_silm As System.Windows.Forms.TextBox
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents Txt_zas2 As System.Windows.Forms.TextBox
    Public WithEvents Txt_zas3 As System.Windows.Forms.TextBox
    Public WithEvents Txt_ran As System.Windows.Forms.TextBox
    Public WithEvents Txt_ran2 As System.Windows.Forms.TextBox
    Public WithEvents Txt_ran3 As System.Windows.Forms.TextBox
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents Txt_hp As System.Windows.Forms.TextBox
    Public WithEvents Label28 As System.Windows.Forms.Label
    Public WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents Txt_drc As System.Windows.Forms.TextBox
    Public WithEvents Label30 As System.Windows.Forms.Label
    Public WithEvents Txt_bod As System.Windows.Forms.TextBox
    Public WithEvents Label31 As System.Windows.Forms.Label
    Public WithEvents Txt_mag As System.Windows.Forms.TextBox
    Public WithEvents Txt_omg As System.Windows.Forms.TextBox
    Public WithEvents Txt_sek As System.Windows.Forms.TextBox
    Public WithEvents Label32 As System.Windows.Forms.Label
    Public WithEvents Label33 As System.Windows.Forms.Label
    Public WithEvents Label34 As System.Windows.Forms.Label
    Public WithEvents Txt_we As System.Windows.Forms.TextBox
    Public WithEvents Label35 As System.Windows.Forms.Label
    Public WithEvents Txt_awe As System.Windows.Forms.TextBox
    Public WithEvents Label36 As System.Windows.Forms.Label
    Public WithEvents Txt_typd As System.Windows.Forms.TextBox
    Public WithEvents Txt_dem As System.Windows.Forms.TextBox
    Public WithEvents Label37 As System.Windows.Forms.Label
    Public WithEvents Txt_ench As System.Windows.Forms.TextBox
    Public WithEvents Label38 As System.Windows.Forms.Label
    Public WithEvents Txt_bles As System.Windows.Forms.TextBox
    Public WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Bt_List As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Weapons))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cmd_Last = New System.Windows.Forms.Button
        Me.Cmd_Forward = New System.Windows.Forms.Button
        Me.Cmd_Back = New System.Windows.Forms.Button
        Me.Cmd_First = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Ins = New System.Windows.Forms.Button
        Me.Cmd_Del = New System.Windows.Forms.Button
        Me.Cmd_Find = New System.Windows.Forms.Button
        Me.Cmd_New = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_Order = New System.Windows.Forms.Button
        Me.Txt_rar = New System.Windows.Forms.TextBox
        Me.Txt_price = New System.Windows.Forms.TextBox
        Me.Txt_rem = New System.Windows.Forms.TextBox
        Me.Txt_pop = New System.Windows.Forms.TextBox
        Me.Txt_ep = New System.Windows.Forms.TextBox
        Me.Txt_eptyp = New System.Windows.Forms.TextBox
        Me.Txt_mg = New System.Windows.Forms.TextBox
        Me.Txt_spec = New System.Windows.Forms.TextBox
        Me.Txt_stuff = New System.Windows.Forms.TextBox
        Me.Txt_OC = New System.Windows.Forms.TextBox
        Me.Txt_sa = New System.Windows.Forms.TextBox
        Me.Txt_ut = New System.Windows.Forms.TextBox
        Me.Txt_UC = New System.Windows.Forms.TextBox
        Me.Txt_typ = New System.Windows.Forms.TextBox
        Me.Txt_w = New System.Windows.Forms.TextBox
        Me.Txt_Num = New System.Windows.Forms.TextBox
        Me.Lst_spells = New System.Windows.Forms.ListBox
        Me.Lst_skills = New System.Windows.Forms.ListBox
        Me.Lst_res = New System.Windows.Forms.ListBox
        Me.Cmd_as = New System.Windows.Forms.Button
        Me.Cmd_ds = New System.Windows.Forms.Button
        Me.Cmd_ak = New System.Windows.Forms.Button
        Me.Cmd_dk = New System.Windows.Forms.Button
        Me.Cmd_ar = New System.Windows.Forms.Button
        Me.Cmd_dr = New System.Windows.Forms.Button
        Me.Cmd_ss = New System.Windows.Forms.Button
        Me.Cmd_sk = New System.Windows.Forms.Button
        Me.Cmd_sr = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Txt_Typg = New System.Windows.Forms.TextBox
        Me.Txt_pru = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Txt_drt = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Txt_ini = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Txt_len = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Txt_silm = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Txt_zas2 = New System.Windows.Forms.TextBox
        Me.Txt_zas3 = New System.Windows.Forms.TextBox
        Me.Txt_ran = New System.Windows.Forms.TextBox
        Me.Txt_ran2 = New System.Windows.Forms.TextBox
        Me.Txt_ran3 = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Txt_hp = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Txt_drc = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Txt_bod = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Txt_mag = New System.Windows.Forms.TextBox
        Me.Txt_omg = New System.Windows.Forms.TextBox
        Me.Txt_sek = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Txt_we = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.Txt_awe = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Txt_typd = New System.Windows.Forms.TextBox
        Me.Txt_dem = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.Txt_ench = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Txt_bles = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Bt_List = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Cmd_Last
        '
        Me.Cmd_Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Last.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Last.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Last.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Last.Image = CType(resources.GetObject("Cmd_Last.Image"), System.Drawing.Image)
        Me.Cmd_Last.Location = New System.Drawing.Point(472, 672)
        Me.Cmd_Last.Name = "Cmd_Last"
        Me.Cmd_Last.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Last.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_Last.TabIndex = 26
        Me.Cmd_Last.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Last, "Na konec")
        Me.Cmd_Last.UseVisualStyleBackColor = False
        '
        'Cmd_Forward
        '
        Me.Cmd_Forward.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Forward.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Forward.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Forward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Forward.Image = CType(resources.GetObject("Cmd_Forward.Image"), System.Drawing.Image)
        Me.Cmd_Forward.Location = New System.Drawing.Point(432, 672)
        Me.Cmd_Forward.Name = "Cmd_Forward"
        Me.Cmd_Forward.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Forward.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_Forward.TabIndex = 25
        Me.Cmd_Forward.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Forward, "O 1 vpřed")
        Me.Cmd_Forward.UseVisualStyleBackColor = False
        '
        'Cmd_Back
        '
        Me.Cmd_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Back.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Back.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Back.Image = CType(resources.GetObject("Cmd_Back.Image"), System.Drawing.Image)
        Me.Cmd_Back.Location = New System.Drawing.Point(256, 672)
        Me.Cmd_Back.Name = "Cmd_Back"
        Me.Cmd_Back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Back.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_Back.TabIndex = 23
        Me.Cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Back, "O 1 vzad")
        Me.Cmd_Back.UseVisualStyleBackColor = False
        '
        'Cmd_First
        '
        Me.Cmd_First.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_First.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_First.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_First.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_First.Image = CType(resources.GetObject("Cmd_First.Image"), System.Drawing.Image)
        Me.Cmd_First.Location = New System.Drawing.Point(216, 672)
        Me.Cmd_First.Name = "Cmd_First"
        Me.Cmd_First.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_First.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_First.TabIndex = 22
        Me.Cmd_First.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_First, "Na začátek")
        Me.Cmd_First.UseVisualStyleBackColor = False
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Exit.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(608, 296)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Exit.Size = New System.Drawing.Size(113, 88)
        Me.Cmd_Exit.TabIndex = 21
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Exit, "Zavřít toto okno")
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'Cmd_Ins
        '
        Me.Cmd_Ins.BackColor = System.Drawing.Color.Green
        Me.Cmd_Ins.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Ins.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Ins.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Ins.Location = New System.Drawing.Point(608, 40)
        Me.Cmd_Ins.Name = "Cmd_Ins"
        Me.Cmd_Ins.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Ins.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Ins.TabIndex = 20
        Me.Cmd_Ins.Text = "VLOŽIT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Ins, "Vložit nové kouzlo anebo updatnout stávající")
        Me.Cmd_Ins.UseVisualStyleBackColor = False
        '
        'Cmd_Del
        '
        Me.Cmd_Del.BackColor = System.Drawing.Color.Red
        Me.Cmd_Del.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Del.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Del.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Del.Location = New System.Drawing.Point(608, 72)
        Me.Cmd_Del.Name = "Cmd_Del"
        Me.Cmd_Del.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Del.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Del.TabIndex = 19
        Me.Cmd_Del.Text = "SMAZAT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Del, "Smazat aktuální kouzlo")
        Me.Cmd_Del.UseVisualStyleBackColor = False
        '
        'Cmd_Find
        '
        Me.Cmd_Find.BackColor = System.Drawing.Color.Yellow
        Me.Cmd_Find.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Find.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Find.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Find.Location = New System.Drawing.Point(608, 104)
        Me.Cmd_Find.Name = "Cmd_Find"
        Me.Cmd_Find.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Find.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Find.TabIndex = 18
        Me.Cmd_Find.Text = "NAJÍT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Find, "Najít kouzlo")
        Me.Cmd_Find.UseVisualStyleBackColor = False
        '
        'Cmd_New
        '
        Me.Cmd_New.BackColor = System.Drawing.Color.White
        Me.Cmd_New.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_New.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_New.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_New.Location = New System.Drawing.Point(608, 168)
        Me.Cmd_New.Name = "Cmd_New"
        Me.Cmd_New.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_New.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_New.TabIndex = 17
        Me.Cmd_New.Text = "NOVÁ"
        Me.ToolTip1.SetToolTip(Me.Cmd_New, "Vymaže pole, příprava na vepsání nového kouzla")
        Me.Cmd_New.UseVisualStyleBackColor = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.Cyan
        Me.Cmd_Print.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Print.Location = New System.Drawing.Point(608, 200)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Print.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Print.TabIndex = 16
        Me.Cmd_Print.Text = "TISK"
        Me.ToolTip1.SetToolTip(Me.Cmd_Print, "Tisk kouzla anebo sestavy")
        Me.Cmd_Print.UseVisualStyleBackColor = False
        '
        'Cmd_Order
        '
        Me.Cmd_Order.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Order.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Order.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Order.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Order.Location = New System.Drawing.Point(608, 232)
        Me.Cmd_Order.Name = "Cmd_Order"
        Me.Cmd_Order.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Order.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Order.TabIndex = 15
        Me.Cmd_Order.Text = "ŘAZENÍ"
        Me.ToolTip1.SetToolTip(Me.Cmd_Order, "Změnit parametry řazení kouzel")
        Me.Cmd_Order.UseVisualStyleBackColor = False
        '
        'Txt_rar
        '
        Me.Txt_rar.AcceptsReturn = True
        Me.Txt_rar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_rar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_rar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_rar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_rar.Location = New System.Drawing.Point(88, 464)
        Me.Txt_rar.MaxLength = 0
        Me.Txt_rar.Name = "Txt_rar"
        Me.Txt_rar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_rar.Size = New System.Drawing.Size(113, 19)
        Me.Txt_rar.TabIndex = 54
        '
        'Txt_price
        '
        Me.Txt_price.AcceptsReturn = True
        Me.Txt_price.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_price.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_price.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_price.Location = New System.Drawing.Point(600, 464)
        Me.Txt_price.MaxLength = 0
        Me.Txt_price.Name = "Txt_price"
        Me.Txt_price.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_price.Size = New System.Drawing.Size(121, 19)
        Me.Txt_price.TabIndex = 53
        '
        'Txt_rem
        '
        Me.Txt_rem.AcceptsReturn = True
        Me.Txt_rem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_rem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_rem.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_rem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_rem.Location = New System.Drawing.Point(176, 400)
        Me.Txt_rem.MaxLength = 0
        Me.Txt_rem.Multiline = True
        Me.Txt_rem.Name = "Txt_rem"
        Me.Txt_rem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_rem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_rem.Size = New System.Drawing.Size(544, 33)
        Me.Txt_rem.TabIndex = 51
        '
        'Txt_pop
        '
        Me.Txt_pop.AcceptsReturn = True
        Me.Txt_pop.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_pop.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_pop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pop.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_pop.Location = New System.Drawing.Point(32, 320)
        Me.Txt_pop.MaxLength = 0
        Me.Txt_pop.Multiline = True
        Me.Txt_pop.Name = "Txt_pop"
        Me.Txt_pop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_pop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_pop.Size = New System.Drawing.Size(560, 35)
        Me.Txt_pop.TabIndex = 50
        '
        'Txt_ep
        '
        Me.Txt_ep.AcceptsReturn = True
        Me.Txt_ep.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_ep.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ep.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ep.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_ep.Location = New System.Drawing.Point(352, 440)
        Me.Txt_ep.MaxLength = 0
        Me.Txt_ep.Name = "Txt_ep"
        Me.Txt_ep.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_ep.Size = New System.Drawing.Size(65, 19)
        Me.Txt_ep.TabIndex = 46
        '
        'Txt_eptyp
        '
        Me.Txt_eptyp.AcceptsReturn = True
        Me.Txt_eptyp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_eptyp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_eptyp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_eptyp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_eptyp.Location = New System.Drawing.Point(552, 440)
        Me.Txt_eptyp.MaxLength = 0
        Me.Txt_eptyp.Name = "Txt_eptyp"
        Me.Txt_eptyp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_eptyp.Size = New System.Drawing.Size(169, 19)
        Me.Txt_eptyp.TabIndex = 45
        '
        'Txt_mg
        '
        Me.Txt_mg.AcceptsReturn = True
        Me.Txt_mg.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_mg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_mg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_mg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_mg.Location = New System.Drawing.Point(136, 440)
        Me.Txt_mg.MaxLength = 0
        Me.Txt_mg.Name = "Txt_mg"
        Me.Txt_mg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_mg.Size = New System.Drawing.Size(65, 19)
        Me.Txt_mg.TabIndex = 44
        '
        'Txt_spec
        '
        Me.Txt_spec.AcceptsReturn = True
        Me.Txt_spec.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_spec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_spec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_spec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_spec.Location = New System.Drawing.Point(176, 360)
        Me.Txt_spec.MaxLength = 0
        Me.Txt_spec.Multiline = True
        Me.Txt_spec.Name = "Txt_spec"
        Me.Txt_spec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_spec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_spec.Size = New System.Drawing.Size(416, 35)
        Me.Txt_spec.TabIndex = 42
        '
        'Txt_stuff
        '
        Me.Txt_stuff.AcceptsReturn = True
        Me.Txt_stuff.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_stuff.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_stuff.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_stuff.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_stuff.Location = New System.Drawing.Point(432, 224)
        Me.Txt_stuff.MaxLength = 0
        Me.Txt_stuff.Name = "Txt_stuff"
        Me.Txt_stuff.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_stuff.Size = New System.Drawing.Size(161, 19)
        Me.Txt_stuff.TabIndex = 40
        '
        'Txt_OC
        '
        Me.Txt_OC.AcceptsReturn = True
        Me.Txt_OC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_OC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_OC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_OC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_OC.Location = New System.Drawing.Point(144, 176)
        Me.Txt_OC.MaxLength = 0
        Me.Txt_OC.Name = "Txt_OC"
        Me.Txt_OC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_OC.Size = New System.Drawing.Size(49, 19)
        Me.Txt_OC.TabIndex = 38
        '
        'Txt_sa
        '
        Me.Txt_sa.AcceptsReturn = True
        Me.Txt_sa.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_sa.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_sa.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_sa.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_sa.Location = New System.Drawing.Point(144, 224)
        Me.Txt_sa.MaxLength = 0
        Me.Txt_sa.Name = "Txt_sa"
        Me.Txt_sa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_sa.Size = New System.Drawing.Size(161, 19)
        Me.Txt_sa.TabIndex = 36
        '
        'Txt_ut
        '
        Me.Txt_ut.AcceptsReturn = True
        Me.Txt_ut.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_ut.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ut.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ut.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_ut.Location = New System.Drawing.Point(144, 152)
        Me.Txt_ut.MaxLength = 0
        Me.Txt_ut.Name = "Txt_ut"
        Me.Txt_ut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_ut.Size = New System.Drawing.Size(48, 19)
        Me.Txt_ut.TabIndex = 34
        '
        'Txt_UC
        '
        Me.Txt_UC.AcceptsReturn = True
        Me.Txt_UC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_UC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_UC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_UC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_UC.Location = New System.Drawing.Point(144, 80)
        Me.Txt_UC.MaxLength = 0
        Me.Txt_UC.Name = "Txt_UC"
        Me.Txt_UC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_UC.Size = New System.Drawing.Size(49, 19)
        Me.Txt_UC.TabIndex = 32
        '
        'Txt_typ
        '
        Me.Txt_typ.AcceptsReturn = True
        Me.Txt_typ.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_typ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_typ.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_typ.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_typ.Location = New System.Drawing.Point(144, 32)
        Me.Txt_typ.MaxLength = 0
        Me.Txt_typ.Name = "Txt_typ"
        Me.Txt_typ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_typ.Size = New System.Drawing.Size(152, 19)
        Me.Txt_typ.TabIndex = 29
        '
        'Txt_w
        '
        Me.Txt_w.AcceptsReturn = True
        Me.Txt_w.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_w.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_w.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_w.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_w.Location = New System.Drawing.Point(144, 8)
        Me.Txt_w.MaxLength = 0
        Me.Txt_w.Name = "Txt_w"
        Me.Txt_w.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_w.Size = New System.Drawing.Size(361, 19)
        Me.Txt_w.TabIndex = 28
        '
        'Txt_Num
        '
        Me.Txt_Num.AcceptsReturn = True
        Me.Txt_Num.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Num.Font = New System.Drawing.Font("Arial", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Location = New System.Drawing.Point(296, 672)
        Me.Txt_Num.MaxLength = 0
        Me.Txt_Num.Name = "Txt_Num"
        Me.Txt_Num.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Num.Size = New System.Drawing.Size(137, 33)
        Me.Txt_Num.TabIndex = 24
        Me.Txt_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lst_spells
        '
        Me.Lst_spells.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lst_spells.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_spells.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_spells.ForeColor = System.Drawing.Color.Yellow
        Me.Lst_spells.ItemHeight = 14
        Me.Lst_spells.Location = New System.Drawing.Point(32, 504)
        Me.Lst_spells.Name = "Lst_spells"
        Me.Lst_spells.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_spells.Size = New System.Drawing.Size(177, 130)
        Me.Lst_spells.TabIndex = 11
        '
        'Lst_skills
        '
        Me.Lst_skills.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lst_skills.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_skills.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_skills.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Lst_skills.ItemHeight = 14
        Me.Lst_skills.Location = New System.Drawing.Point(280, 504)
        Me.Lst_skills.Name = "Lst_skills"
        Me.Lst_skills.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_skills.Size = New System.Drawing.Size(177, 130)
        Me.Lst_skills.TabIndex = 10
        '
        'Lst_res
        '
        Me.Lst_res.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lst_res.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_res.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_res.ForeColor = System.Drawing.Color.Yellow
        Me.Lst_res.ItemHeight = 14
        Me.Lst_res.Location = New System.Drawing.Point(528, 504)
        Me.Lst_res.Name = "Lst_res"
        Me.Lst_res.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_res.Size = New System.Drawing.Size(177, 130)
        Me.Lst_res.TabIndex = 9
        '
        'Cmd_as
        '
        Me.Cmd_as.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_as.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_as.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_as.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_as.Image = CType(resources.GetObject("Cmd_as.Image"), System.Drawing.Image)
        Me.Cmd_as.Location = New System.Drawing.Point(72, 640)
        Me.Cmd_as.Name = "Cmd_as"
        Me.Cmd_as.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_as.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_as.TabIndex = 8
        Me.Cmd_as.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_as.UseVisualStyleBackColor = False
        '
        'Cmd_ds
        '
        Me.Cmd_ds.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_ds.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ds.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ds.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ds.Image = CType(resources.GetObject("Cmd_ds.Image"), System.Drawing.Image)
        Me.Cmd_ds.Location = New System.Drawing.Point(112, 640)
        Me.Cmd_ds.Name = "Cmd_ds"
        Me.Cmd_ds.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ds.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_ds.TabIndex = 7
        Me.Cmd_ds.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_ds.UseVisualStyleBackColor = False
        '
        'Cmd_ak
        '
        Me.Cmd_ak.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_ak.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ak.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ak.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ak.Image = CType(resources.GetObject("Cmd_ak.Image"), System.Drawing.Image)
        Me.Cmd_ak.Location = New System.Drawing.Point(320, 640)
        Me.Cmd_ak.Name = "Cmd_ak"
        Me.Cmd_ak.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ak.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_ak.TabIndex = 6
        Me.Cmd_ak.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_ak.UseVisualStyleBackColor = False
        '
        'Cmd_dk
        '
        Me.Cmd_dk.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_dk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_dk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_dk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_dk.Image = CType(resources.GetObject("Cmd_dk.Image"), System.Drawing.Image)
        Me.Cmd_dk.Location = New System.Drawing.Point(360, 640)
        Me.Cmd_dk.Name = "Cmd_dk"
        Me.Cmd_dk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_dk.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_dk.TabIndex = 5
        Me.Cmd_dk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_dk.UseVisualStyleBackColor = False
        '
        'Cmd_ar
        '
        Me.Cmd_ar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_ar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ar.Image = CType(resources.GetObject("Cmd_ar.Image"), System.Drawing.Image)
        Me.Cmd_ar.Location = New System.Drawing.Point(568, 640)
        Me.Cmd_ar.Name = "Cmd_ar"
        Me.Cmd_ar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ar.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_ar.TabIndex = 4
        Me.Cmd_ar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_ar.UseVisualStyleBackColor = False
        '
        'Cmd_dr
        '
        Me.Cmd_dr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_dr.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_dr.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_dr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_dr.Image = CType(resources.GetObject("Cmd_dr.Image"), System.Drawing.Image)
        Me.Cmd_dr.Location = New System.Drawing.Point(608, 640)
        Me.Cmd_dr.Name = "Cmd_dr"
        Me.Cmd_dr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_dr.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_dr.TabIndex = 3
        Me.Cmd_dr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_dr.UseVisualStyleBackColor = False
        '
        'Cmd_ss
        '
        Me.Cmd_ss.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_ss.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ss.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ss.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ss.Image = CType(resources.GetObject("Cmd_ss.Image"), System.Drawing.Image)
        Me.Cmd_ss.Location = New System.Drawing.Point(152, 640)
        Me.Cmd_ss.Name = "Cmd_ss"
        Me.Cmd_ss.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ss.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_ss.TabIndex = 2
        Me.Cmd_ss.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_ss.UseVisualStyleBackColor = False
        '
        'Cmd_sk
        '
        Me.Cmd_sk.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_sk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_sk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_sk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_sk.Image = CType(resources.GetObject("Cmd_sk.Image"), System.Drawing.Image)
        Me.Cmd_sk.Location = New System.Drawing.Point(400, 640)
        Me.Cmd_sk.Name = "Cmd_sk"
        Me.Cmd_sk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_sk.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_sk.TabIndex = 1
        Me.Cmd_sk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_sk.UseVisualStyleBackColor = False
        '
        'Cmd_sr
        '
        Me.Cmd_sr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_sr.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_sr.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_sr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_sr.Image = CType(resources.GetObject("Cmd_sr.Image"), System.Drawing.Image)
        Me.Cmd_sr.Location = New System.Drawing.Point(648, 640)
        Me.Cmd_sr.Name = "Cmd_sr"
        Me.Cmd_sr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_sr.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_sr.TabIndex = 0
        Me.Cmd_sr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_sr.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(32, 464)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(57, 17)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "Rarita"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(488, 464)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(65, 17)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Cena"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(32, 400)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(81, 17)
        Me.Label16.TabIndex = 52
        Me.Label16.Text = "Poznámky"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(32, 296)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(97, 17)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Popis"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(272, 440)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(57, 17)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "EP/SP"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(488, 440)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(49, 17)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Typu"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(32, 440)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(105, 17)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Magenergie"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(32, 360)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(153, 17)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Speciální schopnosti"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(328, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(113, 17)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Materiál"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(56, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "OČ"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(32, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(104, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Speciální DMG"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(56, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Zásažnost"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(520, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Typ"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(129, 25)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Jméno zbraně"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(72, 488)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Sesílá kouzla"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(288, 488)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(185, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Posiluje/dává dovednosti"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(552, 488)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(137, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Zvyšuje resistence"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label19.Location = New System.Drawing.Point(88, 32)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 16)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "Vzor"
        '
        'Txt_Typg
        '
        Me.Txt_Typg.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Typg.Location = New System.Drawing.Point(560, 8)
        Me.Txt_Typg.Name = "Txt_Typg"
        Me.Txt_Typg.Size = New System.Drawing.Size(160, 20)
        Me.Txt_Typg.TabIndex = 58
        '
        'Txt_pru
        '
        Me.Txt_pru.AcceptsReturn = True
        Me.Txt_pru.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_pru.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_pru.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pru.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_pru.Location = New System.Drawing.Point(144, 104)
        Me.Txt_pru.MaxLength = 0
        Me.Txt_pru.Name = "Txt_pru"
        Me.Txt_pru.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_pru.Size = New System.Drawing.Size(49, 19)
        Me.Txt_pru.TabIndex = 60
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(56, 104)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(80, 17)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Průraznost"
        '
        'Txt_drt
        '
        Me.Txt_drt.AcceptsReturn = True
        Me.Txt_drt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_drt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_drt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_drt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_drt.Location = New System.Drawing.Point(144, 128)
        Me.Txt_drt.MaxLength = 0
        Me.Txt_drt.Name = "Txt_drt"
        Me.Txt_drt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_drt.Size = New System.Drawing.Size(49, 19)
        Me.Txt_drt.TabIndex = 62
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(56, 128)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(80, 17)
        Me.Label21.TabIndex = 61
        Me.Label21.Text = "Drtivost"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(56, 152)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(80, 17)
        Me.Label22.TabIndex = 63
        Me.Label22.Text = "Ničivost"
        '
        'Txt_ini
        '
        Me.Txt_ini.AcceptsReturn = True
        Me.Txt_ini.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_ini.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ini.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ini.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_ini.Location = New System.Drawing.Point(144, 200)
        Me.Txt_ini.MaxLength = 0
        Me.Txt_ini.Name = "Txt_ini"
        Me.Txt_ini.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_ini.Size = New System.Drawing.Size(49, 19)
        Me.Txt_ini.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(56, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Iniciativa"
        '
        'Txt_len
        '
        Me.Txt_len.AcceptsReturn = True
        Me.Txt_len.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_len.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_len.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_len.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_len.Location = New System.Drawing.Point(144, 248)
        Me.Txt_len.MaxLength = 0
        Me.Txt_len.Name = "Txt_len"
        Me.Txt_len.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_len.Size = New System.Drawing.Size(80, 19)
        Me.Txt_len.TabIndex = 67
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(32, 248)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(56, 17)
        Me.Label23.TabIndex = 66
        Me.Label23.Text = "Délka"
        '
        'Txt_silm
        '
        Me.Txt_silm.AcceptsReturn = True
        Me.Txt_silm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_silm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_silm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_silm.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_silm.Location = New System.Drawing.Point(144, 272)
        Me.Txt_silm.MaxLength = 0
        Me.Txt_silm.Name = "Txt_silm"
        Me.Txt_silm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_silm.Size = New System.Drawing.Size(80, 19)
        Me.Txt_silm.TabIndex = 69
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(32, 272)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(112, 17)
        Me.Label24.TabIndex = 68
        Me.Label24.Text = "Silové minimum"
        '
        'Txt_zas2
        '
        Me.Txt_zas2.AcceptsReturn = True
        Me.Txt_zas2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_zas2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_zas2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_zas2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_zas2.Location = New System.Drawing.Point(248, 80)
        Me.Txt_zas2.MaxLength = 0
        Me.Txt_zas2.Name = "Txt_zas2"
        Me.Txt_zas2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_zas2.Size = New System.Drawing.Size(49, 19)
        Me.Txt_zas2.TabIndex = 70
        '
        'Txt_zas3
        '
        Me.Txt_zas3.AcceptsReturn = True
        Me.Txt_zas3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_zas3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_zas3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_zas3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_zas3.Location = New System.Drawing.Point(352, 80)
        Me.Txt_zas3.MaxLength = 0
        Me.Txt_zas3.Name = "Txt_zas3"
        Me.Txt_zas3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_zas3.Size = New System.Drawing.Size(49, 19)
        Me.Txt_zas3.TabIndex = 71
        '
        'Txt_ran
        '
        Me.Txt_ran.AcceptsReturn = True
        Me.Txt_ran.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_ran.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ran.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ran.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_ran.Location = New System.Drawing.Point(192, 80)
        Me.Txt_ran.MaxLength = 0
        Me.Txt_ran.Name = "Txt_ran"
        Me.Txt_ran.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_ran.Size = New System.Drawing.Size(49, 19)
        Me.Txt_ran.TabIndex = 72
        '
        'Txt_ran2
        '
        Me.Txt_ran2.AcceptsReturn = True
        Me.Txt_ran2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_ran2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ran2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ran2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_ran2.Location = New System.Drawing.Point(296, 80)
        Me.Txt_ran2.MaxLength = 0
        Me.Txt_ran2.Name = "Txt_ran2"
        Me.Txt_ran2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_ran2.Size = New System.Drawing.Size(49, 19)
        Me.Txt_ran2.TabIndex = 73
        '
        'Txt_ran3
        '
        Me.Txt_ran3.AcceptsReturn = True
        Me.Txt_ran3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_ran3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ran3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ran3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_ran3.Location = New System.Drawing.Point(400, 80)
        Me.Txt_ran3.MaxLength = 0
        Me.Txt_ran3.Name = "Txt_ran3"
        Me.Txt_ran3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_ran3.Size = New System.Drawing.Size(49, 19)
        Me.Txt_ran3.TabIndex = 74
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(192, 56)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(56, 17)
        Me.Label25.TabIndex = 75
        Me.Label25.Text = "Dostřel"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(296, 56)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(56, 17)
        Me.Label26.TabIndex = 76
        Me.Label26.Text = "Dostřel"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(400, 56)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(56, 17)
        Me.Label27.TabIndex = 77
        Me.Label27.Text = "Dostřel"
        '
        'Txt_hp
        '
        Me.Txt_hp.AcceptsReturn = True
        Me.Txt_hp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_hp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_hp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_hp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_hp.Location = New System.Drawing.Point(544, 200)
        Me.Txt_hp.MaxLength = 0
        Me.Txt_hp.Name = "Txt_hp"
        Me.Txt_hp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_hp.Size = New System.Drawing.Size(49, 19)
        Me.Txt_hp.TabIndex = 89
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(472, 200)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(64, 17)
        Me.Label28.TabIndex = 88
        Me.Label28.Text = "HP"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.Font = New System.Drawing.Font("Symbol", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(472, 152)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(56, 17)
        Me.Label29.TabIndex = 87
        Me.Label29.Text = "W"
        '
        'Txt_drc
        '
        Me.Txt_drc.AcceptsReturn = True
        Me.Txt_drc.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_drc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_drc.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_drc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_drc.Location = New System.Drawing.Point(544, 128)
        Me.Txt_drc.MaxLength = 0
        Me.Txt_drc.Name = "Txt_drc"
        Me.Txt_drc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_drc.Size = New System.Drawing.Size(49, 19)
        Me.Txt_drc.TabIndex = 86
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(472, 128)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(48, 17)
        Me.Label30.TabIndex = 85
        Me.Label30.Text = "Drcení"
        '
        'Txt_bod
        '
        Me.Txt_bod.AcceptsReturn = True
        Me.Txt_bod.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_bod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_bod.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_bod.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_bod.Location = New System.Drawing.Point(544, 80)
        Me.Txt_bod.MaxLength = 0
        Me.Txt_bod.Name = "Txt_bod"
        Me.Txt_bod.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_bod.Size = New System.Drawing.Size(49, 19)
        Me.Txt_bod.TabIndex = 84
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(472, 104)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(48, 17)
        Me.Label31.TabIndex = 83
        Me.Label31.Text = "Sek"
        '
        'Txt_mag
        '
        Me.Txt_mag.AcceptsReturn = True
        Me.Txt_mag.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_mag.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_mag.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_mag.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_mag.Location = New System.Drawing.Point(544, 176)
        Me.Txt_mag.MaxLength = 0
        Me.Txt_mag.Name = "Txt_mag"
        Me.Txt_mag.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_mag.Size = New System.Drawing.Size(49, 19)
        Me.Txt_mag.TabIndex = 82
        '
        'Txt_omg
        '
        Me.Txt_omg.AcceptsReturn = True
        Me.Txt_omg.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_omg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_omg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_omg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_omg.Location = New System.Drawing.Point(544, 152)
        Me.Txt_omg.MaxLength = 0
        Me.Txt_omg.Name = "Txt_omg"
        Me.Txt_omg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_omg.Size = New System.Drawing.Size(48, 19)
        Me.Txt_omg.TabIndex = 80
        '
        'Txt_sek
        '
        Me.Txt_sek.AcceptsReturn = True
        Me.Txt_sek.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_sek.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_sek.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_sek.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_sek.Location = New System.Drawing.Point(544, 104)
        Me.Txt_sek.MaxLength = 0
        Me.Txt_sek.Name = "Txt_sek"
        Me.Txt_sek.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_sek.Size = New System.Drawing.Size(49, 19)
        Me.Txt_sek.TabIndex = 79
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(472, 176)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(64, 17)
        Me.Label32.TabIndex = 81
        Me.Label32.Text = "Magie"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(472, 80)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(72, 17)
        Me.Label33.TabIndex = 78
        Me.Label33.Text = "Bod"
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label34.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label34.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label34.Location = New System.Drawing.Point(256, 152)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(88, 17)
        Me.Label34.TabIndex = 93
        Me.Label34.Text = "Aktivní váha"
        '
        'Txt_we
        '
        Me.Txt_we.AcceptsReturn = True
        Me.Txt_we.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_we.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_we.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_we.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_we.Location = New System.Drawing.Point(344, 128)
        Me.Txt_we.MaxLength = 0
        Me.Txt_we.Name = "Txt_we"
        Me.Txt_we.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_we.Size = New System.Drawing.Size(64, 19)
        Me.Txt_we.TabIndex = 92
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label35.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(256, 128)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(80, 17)
        Me.Label35.TabIndex = 91
        Me.Label35.Text = "Váha"
        '
        'Txt_awe
        '
        Me.Txt_awe.AcceptsReturn = True
        Me.Txt_awe.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_awe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_awe.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_awe.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_awe.Location = New System.Drawing.Point(344, 152)
        Me.Txt_awe.MaxLength = 0
        Me.Txt_awe.Name = "Txt_awe"
        Me.Txt_awe.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_awe.Size = New System.Drawing.Size(64, 19)
        Me.Txt_awe.TabIndex = 90
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label36.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(256, 176)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(88, 17)
        Me.Label36.TabIndex = 95
        Me.Label36.Text = "Typ DMG"
        '
        'Txt_typd
        '
        Me.Txt_typd.AcceptsReturn = True
        Me.Txt_typd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_typd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_typd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_typd.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_typd.Location = New System.Drawing.Point(344, 176)
        Me.Txt_typd.MaxLength = 0
        Me.Txt_typd.Name = "Txt_typd"
        Me.Txt_typd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_typd.Size = New System.Drawing.Size(64, 19)
        Me.Txt_typd.TabIndex = 94
        '
        'Txt_dem
        '
        Me.Txt_dem.AcceptsReturn = True
        Me.Txt_dem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_dem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_dem.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_dem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_dem.Location = New System.Drawing.Point(432, 248)
        Me.Txt_dem.MaxLength = 0
        Me.Txt_dem.Name = "Txt_dem"
        Me.Txt_dem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_dem.Size = New System.Drawing.Size(161, 19)
        Me.Txt_dem.TabIndex = 97
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label37.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label37.Location = New System.Drawing.Point(328, 248)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(113, 17)
        Me.Label37.TabIndex = 96
        Me.Label37.Text = "Démon"
        '
        'Txt_ench
        '
        Me.Txt_ench.AcceptsReturn = True
        Me.Txt_ench.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_ench.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ench.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ench.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_ench.Location = New System.Drawing.Point(432, 272)
        Me.Txt_ench.MaxLength = 0
        Me.Txt_ench.Name = "Txt_ench"
        Me.Txt_ench.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_ench.Size = New System.Drawing.Size(161, 19)
        Me.Txt_ench.TabIndex = 99
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label38.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label38.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(328, 272)
        Me.Label38.Name = "Label38"
        Me.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label38.Size = New System.Drawing.Size(113, 17)
        Me.Label38.TabIndex = 98
        Me.Label38.Text = "Enchantment"
        '
        'Txt_bles
        '
        Me.Txt_bles.AcceptsReturn = True
        Me.Txt_bles.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_bles.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_bles.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_bles.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_bles.Location = New System.Drawing.Point(432, 296)
        Me.Txt_bles.MaxLength = 0
        Me.Txt_bles.Name = "Txt_bles"
        Me.Txt_bles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_bles.Size = New System.Drawing.Size(161, 19)
        Me.Txt_bles.TabIndex = 101
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label39.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label39.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label39.Location = New System.Drawing.Point(328, 296)
        Me.Label39.Name = "Label39"
        Me.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label39.Size = New System.Drawing.Size(113, 17)
        Me.Label39.TabIndex = 100
        Me.Label39.Text = "Blessing"
        '
        'Bt_List
        '
        Me.Bt_List.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Bt_List.Image = CType(resources.GetObject("Bt_List.Image"), System.Drawing.Image)
        Me.Bt_List.Location = New System.Drawing.Point(232, 248)
        Me.Bt_List.Name = "Bt_List"
        Me.Bt_List.Size = New System.Drawing.Size(72, 64)
        Me.Bt_List.TabIndex = 102
        Me.Bt_List.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Frm_Weapons
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 710)
        Me.Controls.Add(Me.Bt_List)
        Me.Controls.Add(Me.Txt_bles)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Txt_ench)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Txt_dem)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Txt_typd)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Txt_we)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Txt_awe)
        Me.Controls.Add(Me.Txt_hp)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Txt_drc)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Txt_bod)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Txt_mag)
        Me.Controls.Add(Me.Txt_omg)
        Me.Controls.Add(Me.Txt_sek)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Txt_ran3)
        Me.Controls.Add(Me.Txt_ran2)
        Me.Controls.Add(Me.Txt_ran)
        Me.Controls.Add(Me.Txt_zas3)
        Me.Controls.Add(Me.Txt_zas2)
        Me.Controls.Add(Me.Txt_silm)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Txt_len)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Txt_ini)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Txt_drt)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Txt_pru)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Txt_Typg)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Txt_rar)
        Me.Controls.Add(Me.Txt_price)
        Me.Controls.Add(Me.Txt_rem)
        Me.Controls.Add(Me.Txt_pop)
        Me.Controls.Add(Me.Txt_ep)
        Me.Controls.Add(Me.Txt_eptyp)
        Me.Controls.Add(Me.Txt_mg)
        Me.Controls.Add(Me.Txt_spec)
        Me.Controls.Add(Me.Txt_stuff)
        Me.Controls.Add(Me.Txt_OC)
        Me.Controls.Add(Me.Txt_sa)
        Me.Controls.Add(Me.Txt_ut)
        Me.Controls.Add(Me.Txt_UC)
        Me.Controls.Add(Me.Txt_typ)
        Me.Controls.Add(Me.Txt_w)
        Me.Controls.Add(Me.Cmd_Last)
        Me.Controls.Add(Me.Cmd_Forward)
        Me.Controls.Add(Me.Txt_Num)
        Me.Controls.Add(Me.Cmd_Back)
        Me.Controls.Add(Me.Cmd_First)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.Cmd_Ins)
        Me.Controls.Add(Me.Cmd_Del)
        Me.Controls.Add(Me.Cmd_Find)
        Me.Controls.Add(Me.Cmd_New)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Cmd_Order)
        Me.Controls.Add(Me.Lst_spells)
        Me.Controls.Add(Me.Lst_skills)
        Me.Controls.Add(Me.Lst_res)
        Me.Controls.Add(Me.Cmd_as)
        Me.Controls.Add(Me.Cmd_ds)
        Me.Controls.Add(Me.Cmd_ak)
        Me.Controls.Add(Me.Cmd_dk)
        Me.Controls.Add(Me.Cmd_ar)
        Me.Controls.Add(Me.Cmd_dr)
        Me.Controls.Add(Me.Cmd_ss)
        Me.Controls.Add(Me.Cmd_sk)
        Me.Controls.Add(Me.Cmd_sr)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.Name = "Frm_Weapons"
        Me.Opacity = 0.9
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC AVATAR - Odria Weapons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Frm_Weapons
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Frm_Weapons
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Frm_Weapons()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As Frm_Weapons)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region
    Private Sub Frm_WEsez_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles my_sez.Closed
        If Tweap <> "" Then
            WEposition = 0
            Do Until WErec.Tables("W").Rows(WEposition)("Weap_name") = Tweap
                WEposition += 1
            Loop
            FillForm()
            Me.Refresh()
        End If
    End Sub


    Private Sub Cmd_ak_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_ak.Click
        Transtr = ""
        FSKCH = New Frm_SKCHoose
        FSKCH.ShowDialog()
        FSKCH = Nothing
        If Transtr <> "" Then
            Lst_skills.Items.Add((Transtr))
            Cmd_dk.Enabled = True
            Cmd_sk.Enabled = True
        End If
    End Sub

    Private Sub Cmd_ar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_ar.Click
        Transtr = ""
        FELCH = New Frm_ELCHoose
        FELCH.ShowDialog()
        FELCH = Nothing
        If Transtr <> "" Then
            Lst_res.Items.Add((Transtr))
            Cmd_dr.Enabled = True
            Cmd_sr.Enabled = True
        End If
    End Sub

    Private Sub Cmd_as_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_as.Click
        Transtr = ""
        FSPCH = New Frm_SPCHoose
        FSPCH.ShowDialog()
        FSPCH = Nothing
        If Transtr <> "" Then
            Lst_spells.Items.Add((Transtr))
            Cmd_ds.Enabled = True
            Cmd_ss.Enabled = True
        End If
    End Sub

    Private Sub Cmd_Back_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Back.Click
        WEposition -= 1
        Call FillForm()
    End Sub

    Private Sub Cmd_dk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_dk.Click
        Dim a As Object
        If Lst_skills.Text <> "" Then
            For a = 0 To Lst_skills.Items.Count
                If VB6.GetItemString(Lst_skills, a) = Lst_skills.Text Then
                    Lst_skills.Items.RemoveAt((a))
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Cmd_dr_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_dr.Click
        Dim a As Object
        If Lst_res.Text <> "" Then
            For a = 0 To Lst_res.Items.Count
                If VB6.GetItemString(Lst_res, a) = Lst_res.Text Then
                    Lst_res.Items.RemoveAt((a))
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Cmd_ds_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_ds.Click
        Dim a As Object
        If Lst_spells.Text <> "" Then
            For a = 0 To Lst_spells.Items.Count
                If VB6.GetItemString(Lst_spells, a) = Lst_spells.Text Then
                    Lst_spells.Items.RemoveAt((a))
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Cmd_Exit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_First_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_First.Click
        WEposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Forward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Forward.Click
        WEposition += 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Last_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Last.Click
        WEposition = WEcount - 1
        Call FillForm()
    End Sub

    Private Sub Cmd_New_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_New.Click
        If Txt_Num.Text = "NEW" Then
            Weapaid()
        End If
        Txt_w.Text = ""
        Txt_typ.Text = ""
        Txt_Typg.Text = ""
        Txt_pop.Text = ""
        Txt_UC.Text = ""
        Txt_mg.Text = ""
        Txt_ep.Text = ""
        Txt_eptyp.Text = ""
        Txt_rem.Text = ""
        Txt_ut.Text = ""
        Txt_sa.Text = ""
        Txt_OC.Text = ""
        Txt_spec.Text = ""
        Txt_rar.Text = ""
        Txt_price.Text = ""
        Txt_stuff.Text = ""
        Txt_ran.Text = ""
        Txt_zas2.Text = ""
        Txt_zas3.Text = ""
        Txt_ran2.Text = ""
        Txt_ran3.Text = ""
        Txt_pru.Text = ""
        Txt_drt.Text = ""
        Txt_ini.Text = ""
        Txt_we.Text = ""
        Txt_awe.Text = ""
        Txt_typd.Text = ""
        Txt_bod.Text = ""
        Txt_sek.Text = ""
        Txt_drc.Text = ""
        Txt_omg.Text = ""
        Txt_mag.Text = ""
        Txt_hp.Text = ""
        Txt_len.Text = ""
        Txt_silm.Text = ""
        Txt_dem.Text = ""
        Txt_ench.Text = ""
        Txt_bles.Text = ""
        Lst_spells.Items.Clear()
        Lst_skills.Items.Clear()
        Lst_res.Items.Clear()
        Cmd_Print.Enabled = False
        Cmd_Del.Enabled = False
        Txt_Num.Text = "NEW"
    End Sub


    Private Sub Cmd_sk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_sk.Click
        Dim a As Long
        Dim pstr As String
        pstr = ""
        If Lst_skills.Text <> "" Then
            For a = 1 To Len(Lst_skills.Text)
                If Mid(Lst_skills.Text, a, 3) <> "   " Then
                    pstr = pstr & Mid(Lst_skills.Text, a, 1)
                Else
                    Exit For
                End If
            Next
            If SK Then
                FSk.Txt_s.Text = pstr
                Call SKSearch()
                FSk.Show()
            Else

                FSk = New Frm_Skills
                FSk.Show()
                Do
                    System.Windows.Forms.Application.DoEvents()
                Loop Until SK
                FSk.Txt_s.Text = pstr
                Call SKSearch()
                FSk.Show()
            End If
        End If
    End Sub

    Private Sub Cmd_sr_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_sr.Click
        If Lst_res.Text <> "" Then
            If EL Then

                FEle.Show()
            Else

                FEle = New Frm_Elements

                FEle.Show()
            End If
        End If
    End Sub

    Private Sub Cmd_ss_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_ss.Click
        If Lst_spells.Text <> "" Then
            If SP Then
                FSp.Txt_Spellname.Text = Lst_spells.Text
                Call SPSearch()
                FSp.Show()
            Else

                FSp = New Frm_Spells
                FSp.Show()
                Do
                    System.Windows.Forms.Application.DoEvents()
                Loop Until SP
                FSp.Txt_Spellname.Text = Lst_spells.Text
                Call SPSearch()
                FSp.Show()
            End If
        End If
    End Sub

    Private Sub Frm_Weapons_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call WErecopen()
        WEposition = 0
        ApplyColor()
        Call FillForm()
        WE = True
    End Sub


    Private Sub WErecopen()
        Dim isc As New OleDbCommand
        isc.Connection = Odrialink2
        Select Case WEorder
            Case Is = 1
                If WEdirect = 1 Then
                    isc.CommandText = "select * from Weapons order by Weap_name"
                Else
                    isc.CommandText = "select * from Weapons order by Weap_name desc"
                End If
            Case Is = 2
                If WEdirect = 1 Then
                    isc.CommandText = "select * from Weapons order by Type"
                Else
                    isc.CommandText = "select * from Weapons order by Type desc"
                End If
            Case Is = 3
                If WEdirect = 1 Then
                    isc.CommandText = "select * from Weapons order by Rarity"
                Else
                    isc.CommandText = "select * from Weapons order by Rarity desc"
                End If
        End Select
        WEdat.SelectCommand = isc
        WErec.Clear()
        WEdat.Fill(WErec, "W")
        WEcount = WErec.Tables("W").Rows.Count
    End Sub


    Sub FillForm()
        Dim spe As New OleDbCommand
        Dim ski As New OleDbCommand
        Dim ele As New OleDbCommand
        Dim a, b, c As Int16
        Dim ax, bx, cx As Int16

        Txt_w.Text = WErec.Tables("W").Rows(WEposition)("Weap_name")
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Typeg")) Then
            Txt_Typg.Text = WErec.Tables("W").Rows(WEposition)("Typeg")
        Else
            Txt_Typg.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Templatex")) Then
            Txt_typ.Text = WErec.Tables("W").Rows(WEposition)("Templatex")
        Else
            Txt_typ.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Looking")) Then
            Txt_pop.Text = WErec.Tables("W").Rows(WEposition)("Looking")
        Else
            Txt_pop.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Daily_MG")) Then
            Txt_mg.Text = WErec.Tables("W").Rows(WEposition)("Daily_MG")
        Else
            Txt_mg.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Spec_powers")) Then
            Txt_spec.Text = WErec.Tables("W").Rows(WEposition)("Spec_powers")
        Else
            Txt_spec.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("EP_SP")) Then
            Txt_ep.Text = WErec.Tables("W").Rows(WEposition)("EP_SP")
        Else
            Txt_ep.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("EP_SP_type")) Then
            Txt_eptyp.Text = WErec.Tables("W").Rows(WEposition)("EP_SP_type")
        Else
            Txt_eptyp.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Zas")) Then
            Txt_UC.Text = WErec.Tables("W").Rows(WEposition)("Zas")
        Else
            Txt_UC.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Nic")) Then
            Txt_ut.Text = WErec.Tables("W").Rows(WEposition)("Nic")
        Else
            Txt_ut.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Spec_dmg")) Then
            Txt_sa.Text = WErec.Tables("W").Rows(WEposition)("Spec_dmg")
        Else
            Txt_sa.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("OC")) Then
            Txt_OC.Text = WErec.Tables("W").Rows(WEposition)("OC")
        Else
            Txt_OC.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Pru")) Then
            Txt_pru.Text = WErec.Tables("W").Rows(WEposition)("Pru")
        Else
            Txt_pru.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Drt")) Then
            Txt_drt.Text = WErec.Tables("W").Rows(WEposition)("Drt")
        Else
            Txt_drt.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Ini")) Then
            Txt_ini.Text = WErec.Tables("W").Rows(WEposition)("Ini")
        Else
            Txt_ini.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Zas2")) Then
            Txt_zas2.Text = WErec.Tables("W").Rows(WEposition)("Zas2")
        Else
            Txt_zas2.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Zas3")) Then
            Txt_zas3.Text = WErec.Tables("W").Rows(WEposition)("Zas3")
        Else
            Txt_zas3.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Rang")) Then
            Txt_ran.Text = WErec.Tables("W").Rows(WEposition)("Rang")
        Else
            Txt_ran.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Rang2")) Then
            Txt_ran2.Text = WErec.Tables("W").Rows(WEposition)("Rang2")
        Else
            Txt_ran2.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Rang3")) Then
            Txt_ran3.Text = WErec.Tables("W").Rows(WEposition)("Rang3")
        Else
            Txt_ran3.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Bod")) Then
            Txt_bod.Text = WErec.Tables("W").Rows(WEposition)("Bod")
        Else
            Txt_bod.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Sek")) Then
            Txt_sek.Text = WErec.Tables("W").Rows(WEposition)("Sek")
        Else
            Txt_sek.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Drc")) Then
            Txt_drc.Text = WErec.Tables("W").Rows(WEposition)("Drc")
        Else
            Txt_drc.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Omg")) Then
            Txt_omg.Text = WErec.Tables("W").Rows(WEposition)("Omg")
        Else
            Txt_omg.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Mag")) Then
            Txt_mag.Text = WErec.Tables("W").Rows(WEposition)("Mag")
        Else
            Txt_mag.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("HP")) Then
            Txt_hp.Text = WErec.Tables("W").Rows(WEposition)("HP")
        Else
            Txt_hp.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Weight")) Then
            Txt_we.Text = WErec.Tables("W").Rows(WEposition)("Weight")
        Else
            Txt_we.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Aweight")) Then
            Txt_awe.Text = WErec.Tables("W").Rows(WEposition)("Aweight")
        Else
            Txt_awe.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Typed")) Then
            Txt_typd.Text = WErec.Tables("W").Rows(WEposition)("Typed")
        Else
            Txt_typd.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Delk")) Then
            Txt_len.Text = WErec.Tables("W").Rows(WEposition)("Delk")
        Else
            Txt_len.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Silmin")) Then
            Txt_silm.Text = WErec.Tables("W").Rows(WEposition)("Silmin")
        Else
            Txt_silm.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Demon")) Then
            Txt_dem.Text = WErec.Tables("W").Rows(WEposition)("Demon")
        Else
            Txt_dem.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Ench")) Then
            Txt_ench.Text = WErec.Tables("W").Rows(WEposition)("Ench")
        Else
            Txt_ench.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Bless")) Then
            Txt_bles.Text = WErec.Tables("W").Rows(WEposition)("Bless")
        Else
            Txt_bles.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Rarity")) Then
            Txt_rar.Text = WErec.Tables("W").Rows(WEposition)("Rarity")
        Else
            Txt_rar.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("App_price")) Then
            Txt_price.Text = WErec.Tables("W").Rows(WEposition)("App_price")
        Else
            Txt_price.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Remarks")) Then
            Txt_rem.Text = WErec.Tables("W").Rows(WEposition)("Remarks")
        Else
            Txt_rem.Text = ""
        End If
        If Not IsDBNull(WErec.Tables("W").Rows(WEposition)("Material")) Then
            Txt_stuff.Text = WErec.Tables("W").Rows(WEposition)("Material")
        Else
            Txt_stuff.Text = ""
        End If
        spe.Connection = Odrialink2
        ski.Connection = Odrialink2
        ele.Connection = Odrialink2
        Lst_spells.Items.Clear()
        Lst_skills.Items.Clear()
        Lst_res.Items.Clear()
        spe.CommandText = "select * from Wespells where We_ID = " & WErec.Tables("W").Rows(WEposition)("ID")
        WESPdat.SelectCommand = spe
        WESP.Clear()
        WESPdat.Fill(WESP, "sp")
        ax = WESP.Tables("sp").Rows.Count
        a = 0
        If ax > 0 Then
            Do
                Lst_spells.Items.Add((WESP.Tables("sp").Rows(a)("Spell")))
                a += 1
            Loop Until a = ax
            Cmd_ds.Enabled = True
            Cmd_ss.Enabled = True
        Else
            Cmd_ds.Enabled = False
            Cmd_ss.Enabled = False
        End If
        ski.CommandText = "select * from Weskills where We_ID = " & WErec.Tables("W").Rows(WEposition)("ID")
        WESKdat.SelectCommand = ski
        WESK.Clear()
        WESKdat.Fill(WESK, "sk")
        bx = WESK.Tables("sk").Rows.Count
        b = 0
        If bx > 0 Then
            Do
                Lst_skills.Items.Add((WESK.Tables("sk").Rows(b)("Skill") & "   " & WESK.Tables("sk").Rows(b)("Knowledge")))
                b += 1
            Loop Until b = bx
            Cmd_dk.Enabled = True
            Cmd_sk.Enabled = True
        Else
            Cmd_dk.Enabled = False
            Cmd_sk.Enabled = False
        End If
        ele.CommandText = "select * from Weresistances where We_ID = " & WErec.Tables("W").Rows(WEposition)("ID")
        WEELdat.SelectCommand = ele
        WEEL.Clear()
        WEELdat.Fill(WEEL, "el")
        cx = WEEL.Tables("el").Rows.Count
        c = 0
        If cx > 0 Then
            Do
                Lst_res.Items.Add((WEEL.Tables("el").Rows(c)("Resistance_to") & "   " & WEEL.Tables("el").Rows(c)("Percent") & "%"))
                c += 1
            Loop Until c = cx
            Cmd_dr.Enabled = True
            Cmd_sr.Enabled = True
        Else
            Cmd_dr.Enabled = False
            Cmd_sr.Enabled = False
        End If
        If WEposition = 0 Then
            Cmd_Back.Enabled = False
        Else
            Cmd_Back.Enabled = True
        End If
        Cmd_Del.Enabled = True
        Cmd_Find.Enabled = True
        If WEposition + 1 = WEcount Then
            Cmd_Forward.Enabled = False
        Else
            Cmd_Forward.Enabled = True
        End If
        Cmd_Ins.Enabled = True
        Cmd_New.Enabled = True
        Cmd_Print.Enabled = True


        Txt_Num.Text = (WEposition + 1) & "/" & WEcount

    End Sub


    Private Sub Frm_Weapons_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        WE = False
        WESP.Clear()
        WESK.Clear()
        WEEL.Clear()
        WErec.Clear()
    End Sub

    Private Sub Txt_Num_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Num.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Not IsNumeric(Txt_Num.Text) Then
                MsgBox("Tady musí být číslo!", MsgBoxStyle.OKOnly, "Chyba")
                GoTo EventExitSub
            End If
            If CShort(Txt_Num.Text) > WEcount Or CShort(Txt_Num.Text) < 1 Then
                MsgBox("Číslo musí být v rozsahu 1 - počet záznamů!", MsgBoxStyle.OKOnly, "Chyba")
                GoTo EventExitSub
            End If
            KeyAscii = 0
            WEposition = CShort(Txt_Num.Text) - 1
            Call FillForm()
        End If
EventExitSub:
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Cmd_Print_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Print.Click
        Dim WErint As New WEPrint
        Dim a As Integer
        Try
            Dim tsc As New OleDbCommand
            tsc.Connection = Odrialink2
            tsc.CommandText = "DELETE * from WeTemp"
            tsc.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Chyba při výmazu případu: " + ex.Message)
            Exit Sub
        End Try
        For a = 0 To WEcount - 1
            Try
                Dim ic As New OleDbCommand
                Dim s1, s2 As String
                s1 = "INSERT INTO WeTemp (ID, Weap_name"
                s2 = " VALUES (@ID, @Weap_name"
                ic.Parameters.AddWithValue("@ID", WErec.Tables("W").Rows(a)("ID"))
                ic.Parameters.AddWithValue("@Weap_name", WErec.Tables("W").Rows(a)("Weap_name"))
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Typeg")) Then
                    ic.Parameters.AddWithValue("@Typeg", WErec.Tables("W").Rows(a)("Typeg"))
                    s1 = s1 & ", Typeg"
                    s2 = s2 & ", @Typeg"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Looking")) Then
                    ic.Parameters.AddWithValue("@Looking", WErec.Tables("W").Rows(a)("Looking"))
                    s1 = s1 & ", Looking"
                    s2 = s2 & ", @Looking"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Spec_powers")) Then
                    ic.Parameters.AddWithValue("@Special_powers", WErec.Tables("W").Rows(a)("Spec_powers"))
                    s1 = s1 & ", Spec_powers"
                    s2 = s2 & ", @Spec_powers"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Daily_MG")) Then
                    ic.Parameters.AddWithValue("@Daily_MG", WErec.Tables("W").Rows(a)("Daily_MG"))
                    s1 = s1 & ", Daily_MG"
                    s2 = s2 & ", @Daily_MG"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("EP_SP")) Then
                    ic.Parameters.AddWithValue("@EP_SP", WErec.Tables("W").Rows(a)("EP_SP"))
                    s1 = s1 & ", EP_SP"
                    s2 = s2 & ", @EP_SP"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("EP_SP_type")) Then
                    ic.Parameters.AddWithValue("@EP_SP_type", WErec.Tables("W").Rows(a)("EP_SP_type"))
                    s1 = s1 & ", EP_SP_type"
                    s2 = s2 & ", @EP_SP_type"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Remarks")) Then
                    ic.Parameters.AddWithValue("@Remarks", WErec.Tables("W").Rows(a)("Remarks"))
                    s1 = s1 & ", Remarks"
                    s2 = s2 & ", @Remarks"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Templatex")) Then
                    ic.Parameters.AddWithValue("@Templatex", WErec.Tables("W").Rows(a)("Templatex"))
                    s1 = s1 & ", Templatex"
                    s2 = s2 & ", @Templatex"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Zas")) Then
                    ic.Parameters.AddWithValue("@Zas", WErec.Tables("W").Rows(a)("Zas"))
                    s1 = s1 & ", Zas"
                    s2 = s2 & ", @Zas"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Pru")) Then
                    ic.Parameters.AddWithValue("@Pru", WErec.Tables("W").Rows(a)("Pru"))
                    s1 = s1 & ", Pru"
                    s2 = s2 & ", @Pru"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Drt")) Then
                    ic.Parameters.AddWithValue("@Drt", WErec.Tables("W").Rows(a)("Drt"))
                    s1 = s1 & ", Drt"
                    s2 = s2 & ", @Drt"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Rarity")) Then
                    ic.Parameters.AddWithValue("@Rarity", WErec.Tables("W").Rows(a)("Rarity"))
                    s1 = s1 & ", Rarity"
                    s2 = s2 & ", @Rarity"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("App_price")) Then
                    ic.Parameters.AddWithValue("@App_price", WErec.Tables("W").Rows(a)("App_price"))
                    s1 = s1 & ", App_price"
                    s2 = s2 & ", @App_price"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Nic")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Nic"))
                    s1 = s1 & ", Nic"
                    s2 = s2 & ", @Nic"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("OC")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("OC"))
                    s1 = s1 & ", OC"
                    s2 = s2 & ", @OC"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Ini")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Ini"))
                    s1 = s1 & ", Ini"
                    s2 = s2 & ", @Ini"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Spec_dmg")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Spec_dmg"))
                    s1 = s1 & ", Spec_dmg"
                    s2 = s2 & ", @Spec_dmg"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Delk")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Delk"))
                    s1 = s1 & ", Delk"
                    s2 = s2 & ", @Delk"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Silmin")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Silmin"))
                    s1 = s1 & ", Silmin"
                    s2 = s2 & ", @Silmin"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Zas2")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Zas2"))
                    s1 = s1 & ", Zas2"
                    s2 = s2 & ", @Zas2"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Zas3")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Zas3"))
                    s1 = s1 & ", Zas3"
                    s2 = s2 & ", @Zas3"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Rang")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Rang"))
                    s1 = s1 & ", Rang"
                    s2 = s2 & ", @Rang"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Rang2")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Rang2"))
                    s1 = s1 & ", Rang2"
                    s2 = s2 & ", @Rang2"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Rang3")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Rang3"))
                    s1 = s1 & ", Rang3"
                    s2 = s2 & ", @Rang3"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Bod")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Bod"))
                    s1 = s1 & ", Bod"
                    s2 = s2 & ", @Bod"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Sek")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Sek"))
                    s1 = s1 & ", Sek"
                    s2 = s2 & ", @Sek"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Drc")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Drc"))
                    s1 = s1 & ", Drc"
                    s2 = s2 & ", @Drc"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Omg")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Omg"))
                    s1 = s1 & ", Omg"
                    s2 = s2 & ", @Omg"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Mag")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Mag"))
                    s1 = s1 & ", Mag"
                    s2 = s2 & ", @Mag"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("HP")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("HP"))
                    s1 = s1 & ", HP"
                    s2 = s2 & ", @HP"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Weight")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Weight"))
                    s1 = s1 & ", Weight"
                    s2 = s2 & ", @Weight"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Aweight")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Aweight"))
                    s1 = s1 & ", Aweight"
                    s2 = s2 & ", @Aweight"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Typed")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Typed"))
                    s1 = s1 & ", Typed"
                    s2 = s2 & ", @Typed"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Demon")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Demon"))
                    s1 = s1 & ", Demon"
                    s2 = s2 & ", @Demon"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Ench")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Ench"))
                    s1 = s1 & ", Ench"
                    s2 = s2 & ", @Ench"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Bless")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Bless"))
                    s1 = s1 & ", Bless"
                    s2 = s2 & ", @Bless"
                End If
                If Not IsDBNull(WErec.Tables("W").Rows(a)("Material")) Then
                    ic.Parameters.AddWithValue("@Alch", WErec.Tables("W").Rows(a)("Material"))
                    s1 = s1 & ", Material"
                    s2 = s2 & ", @Material"
                End If
                Dim spe As New OleDbCommand
                Dim ski As New OleDbCommand
                Dim ele As New OleDbCommand
                Dim u, b, c As Int16
                Dim ax, bx, cx As Int16
                spe.Connection = Odrialink2
                ski.Connection = Odrialink2
                ele.Connection = Odrialink2
                spe.CommandText = "select * from Wespells where We_ID = " & WErec.Tables("W").Rows(a)("ID")
                WESPdat.SelectCommand = spe
                WESP.Clear()
                WESPdat.Fill(WESP, "sp")
                ax = WESP.Tables("sp").Rows.Count
                u = 0
                If ax > 0 Then
                    Dim gu As String
                    gu = ""
                    Do
                        If u > 0 Then
                            gu = gu & ", "
                        End If
                        gu = gu & WESP.Tables("sp").Rows(u)("Spell")
                        u += 1
                    Loop Until u = ax
                    ic.Parameters.AddWithValue("@Spelly", gu)
                    s1 = s1 & ", Spelly"
                    s2 = s2 & ", @Spelly"
                End If
                ski.CommandText = "select * from Weskills where We_ID = " & WErec.Tables("W").Rows(a)("ID")
                WESKdat.SelectCommand = ski
                WESK.Clear()
                WESKdat.Fill(WESK, "sk")
                bx = WESK.Tables("sk").Rows.Count
                b = 0
                If bx > 0 Then
                    Dim gu As String
                    gu = ""
                    Do
                        If b > 0 Then
                            gu = gu & ", "
                        End If
                        gu = gu & WESK.Tables("sk").Rows(b)("Skill")
                        If Mid(WESK.Tables("sk").Rows(b)("Knowledge"), 1, 1) = "+" Or "-" Then
                            gu = gu & " o "
                        Else
                            gu = gu & " "
                        End If
                        gu = gu & WESK.Tables("sk").Rows(b)("Knowledge")
                        b += 1
                    Loop Until b = bx
                    ic.Parameters.AddWithValue("@Skilly", gu)
                    s1 = s1 & ", Skilly"
                    s2 = s2 & ", @Skilly"
                End If
                ele.CommandText = "select * from Weresistances where We_ID = " & WErec.Tables("W").Rows(a)("ID")
                WEELdat.SelectCommand = ele
                WEEL.Clear()
                WEELdat.Fill(WEEL, "el")
                cx = WEEL.Tables("el").Rows.Count
                c = 0
                If cx > 0 Then
                    Dim gu As String
                    gu = ""
                    Do
                        If c > 0 Then
                            gu = gu & ", "
                        End If
                        gu = gu & WEEL.Tables("el").Rows(c)("Resistance_to") & " " & WEEL.Tables("el").Rows(c)("Percent") & "%"
                        c += 1
                    Loop Until c = cx
                    ic.Parameters.AddWithValue("@Resky", gu)
                    s1 = s1 & ", Resky"
                    s2 = s2 & ", @Resky"
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
        Next
        Dim isc As New OleDbCommand
        Dim da As New OleDbDataAdapter
        isc.Connection = Odrialink2
        isc.CommandText = "select * from WeTemp order by ID"
        da.SelectCommand = isc
        Tsetw.Clear()
        da.Fill(Tsetw, "We")
        WErint.Show()
    End Sub

    Private Sub Cmd_Order_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Order.Click
        OrderControl = "WE"
        FO = New Frm_Ordering
        FO.ShowDialog()
        FO = Nothing
        WErec.Clear()
        Call WErecopen()
        WEposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Ins_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Ins.Click
        If Txt_w.Text = "" Then
            MsgBox("Zbraň musí mít jméno!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        Dim tsc As New OleDbCommand
        Dim treader As OleDbDataReader
        Try
            tsc.Connection = Odrialink2
            tsc.CommandText = "select * from Weapons where Weap_name = @it"
            tsc.Parameters.AddWithValue("@it", Txt_w.Text)
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
                s1 = "INSERT INTO Weapons (Weap_name"
                s2 = " VALUES (@Weap_name"
                ic.Parameters.AddWithValue("@Weap_name", Trim(Txt_w.Text))
                If Not Txt_Typg.Text = "" Then
                    ic.Parameters.AddWithValue("@Typeg", Trim(Txt_Typg.Text))
                    s1 = s1 & ", Typeg"
                    s2 = s2 & ", @Typeg"
                End If
                If Not Txt_typ.Text = "" Then
                    ic.Parameters.AddWithValue("@Templatex", Trim(Txt_typ.Text))
                    s1 = s1 & ", Templatex"
                    s2 = s2 & ", @Templatex"
                End If
                If Not Txt_pop.Text = "" Then
                    ic.Parameters.AddWithValue("@Looking", Trim(Txt_pop.Text))
                    s1 = s1 & ", Looking"
                    s2 = s2 & ", @Looking"
                End If
                If Not Txt_spec.Text = "" Then
                    ic.Parameters.AddWithValue("@Spec_powers", Trim(Txt_spec.Text))
                    s1 = s1 & ", Spec_powers"
                    s2 = s2 & ", @Spec_powers"
                End If
                If Not Txt_mg.Text = "" Then
                    ic.Parameters.AddWithValue("@Daily_MG", Trim(Txt_mg.Text))
                    s1 = s1 & ", Daily_MG"
                    s2 = s2 & ", @Daily_MG"
                End If
                If Not Txt_ep.Text = "" Then
                    ic.Parameters.AddWithValue("@EP_SP", Trim(Txt_ep.Text))
                    s1 = s1 & ", EP_SP"
                    s2 = s2 & ", @EP_SP"
                End If
                If Not Txt_eptyp.Text = "" Then
                    ic.Parameters.AddWithValue("@EP_SP_type", Trim(Txt_eptyp.Text))
                    s1 = s1 & ", EP_SP_type"
                    s2 = s2 & ", @EP_SP_type"
                End If
                If Not Txt_rem.Text = "" Then
                    ic.Parameters.AddWithValue("@Remarks", Trim(Txt_rem.Text))
                    s1 = s1 & ", Remarks"
                    s2 = s2 & ", @Remarks"
                End If
                If Not Txt_UC.Text = "" Then
                    ic.Parameters.AddWithValue("@Zas", Trim(Txt_UC.Text))
                    s1 = s1 & ", Zas"
                    s2 = s2 & ", @Zas"
                End If
                If Not Txt_ut.Text = "" Then
                    ic.Parameters.AddWithValue("@Nic", Trim(Txt_ut.Text))
                    s1 = s1 & ", Nic"
                    s2 = s2 & ", @Nic"
                End If
                If Not Txt_sa.Text = "" Then
                    ic.Parameters.AddWithValue("@Spec_dmg", Trim(Txt_sa.Text))
                    s1 = s1 & ", Spec_dmg"
                    s2 = s2 & ", @Spec_dmg"
                End If
                If Not Txt_OC.Text = "" Then
                    ic.Parameters.AddWithValue("@OC", Trim(Txt_OC.Text))
                    s1 = s1 & ", OC"
                    s2 = s2 & ", @OC"
                End If
                If Not Txt_rar.Text = "" Then
                    ic.Parameters.AddWithValue("@Rarity", Trim(Txt_rar.Text))
                    s1 = s1 & ", Rarity"
                    s2 = s2 & ", @Rarity"
                End If
                If Not Txt_price.Text = "" Then
                    ic.Parameters.AddWithValue("@App_price", Trim(Txt_price.Text))
                    s1 = s1 & ", App_price"
                    s2 = s2 & ", @App_price"
                End If
                If Not Txt_stuff.Text = "" Then
                    ic.Parameters.AddWithValue("@Material", Trim(Txt_stuff.Text))
                    s1 = s1 & ", Material"
                    s2 = s2 & ", @Material"
                End If
                If Not Txt_zas2.Text = "" Then
                    ic.Parameters.AddWithValue("@Zas2", Trim(Txt_zas2.Text))
                    s1 = s1 & ", Zas2"
                    s2 = s2 & ", @Zas2"
                End If
                If Not Txt_zas3.Text = "" Then
                    ic.Parameters.AddWithValue("@Zas3", Trim(Txt_zas3.Text))
                    s1 = s1 & ", Zas3"
                    s2 = s2 & ", @Zas3"
                End If
                If Not Txt_ran.Text = "" Then
                    ic.Parameters.AddWithValue("@Rang", Trim(Txt_ran.Text))
                    s1 = s1 & ", Rang"
                    s2 = s2 & ", @Rang"
                End If
                If Not Txt_ran2.Text = "" Then
                    ic.Parameters.AddWithValue("@Rang2", Trim(Txt_ran2.Text))
                    s1 = s1 & ", Rang2"
                    s2 = s2 & ", @Rang2"
                End If
                If Not Txt_ran3.Text = "" Then
                    ic.Parameters.AddWithValue("@Rang3", Trim(Txt_ran3.Text))
                    s1 = s1 & ", Rang3"
                    s2 = s2 & ", @Rang3"
                End If
                If Not Txt_pru.Text = "" Then
                    ic.Parameters.AddWithValue("@Pru", Trim(Txt_pru.Text))
                    s1 = s1 & ", Pru"
                    s2 = s2 & ", @Pru"
                End If
                If Not Txt_drt.Text = "" Then
                    ic.Parameters.AddWithValue("@Drt", Trim(Txt_drt.Text))
                    s1 = s1 & ", Drt"
                    s2 = s2 & ", @Drt"
                End If
                If Not Txt_ini.Text = "" Then
                    ic.Parameters.AddWithValue("@Ini", Trim(Txt_ini.Text))
                    s1 = s1 & ", Ini"
                    s2 = s2 & ", @Ini"
                End If
                If Not Txt_bod.Text = "" Then
                    ic.Parameters.AddWithValue("@Bod", Trim(Txt_bod.Text))
                    s1 = s1 & ", Bod"
                    s2 = s2 & ", @Bod"
                End If
                If Not Txt_sek.Text = "" Then
                    ic.Parameters.AddWithValue("@Sek", Trim(Txt_sek.Text))
                    s1 = s1 & ", Sek"
                    s2 = s2 & ", @Sek"
                End If
                If Not Txt_drc.Text = "" Then
                    ic.Parameters.AddWithValue("@Drc", Trim(Txt_drc.Text))
                    s1 = s1 & ", Drc"
                    s2 = s2 & ", @Drc"
                End If
                If Not Txt_omg.Text = "" Then
                    ic.Parameters.AddWithValue("@Omg", Trim(Txt_omg.Text))
                    s1 = s1 & ", Omg"
                    s2 = s2 & ", @Omg"
                End If
                If Not Txt_mag.Text = "" Then
                    ic.Parameters.AddWithValue("@Mag", Trim(Txt_mag.Text))
                    s1 = s1 & ", Mag"
                    s2 = s2 & ", @Mag"
                End If
                If Not Txt_hp.Text = "" Then
                    ic.Parameters.AddWithValue("@HP", Trim(Txt_hp.Text))
                    s1 = s1 & ", HP"
                    s2 = s2 & ", @HP"
                End If
                If Not Txt_we.Text = "" Then
                    ic.Parameters.AddWithValue("@Weight", Trim(Txt_we.Text))
                    s1 = s1 & ", Weight"
                    s2 = s2 & ", @Weight"
                End If
                If Not Txt_awe.Text = "" Then
                    ic.Parameters.AddWithValue("@Aweight", Trim(Txt_awe.Text))
                    s1 = s1 & ", Aweight"
                    s2 = s2 & ", @Aweight"
                End If
                If Not Txt_typd.Text = "" Then
                    ic.Parameters.AddWithValue("@Typed", Trim(Txt_typd.Text))
                    s1 = s1 & ", Typed"
                    s2 = s2 & ", @Typed"
                End If
                If Not Txt_len.Text = "" Then
                    ic.Parameters.AddWithValue("@Delk", Trim(Txt_len.Text))
                    s1 = s1 & ", Delk"
                    s2 = s2 & ", @Delk"
                End If
                If Not Txt_silm.Text = "" Then
                    ic.Parameters.AddWithValue("@Silmin", Trim(Txt_silm.Text))
                    s1 = s1 & ", Silmin"
                    s2 = s2 & ", @Silmin"
                End If
                If Not Txt_dem.Text = "" Then
                    ic.Parameters.AddWithValue("@Demon", Trim(Txt_dem.Text))
                    s1 = s1 & ", Demon"
                    s2 = s2 & ", @Demon"
                End If
                If Not Txt_ench.Text = "" Then
                    ic.Parameters.AddWithValue("@Ench", Trim(Txt_ench.Text))
                    s1 = s1 & ", Ench"
                    s2 = s2 & ", @Ench"
                End If
                If Not Txt_bles.Text = "" Then
                    ic.Parameters.AddWithValue("@Bless", Trim(Txt_bles.Text))
                    s1 = s1 & ", Bless"
                    s2 = s2 & ", @Bless"
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
            WErec.Clear()
            WEdat.Fill(WErec, "W")
            WEcount = WErec.Tables("W").Rows.Count
            Dim tsd As New OleDbCommand
            Dim trdeader As OleDbDataReader
            Try
                tsd.Connection = Odrialink2
                tsd.CommandText = "select ID from Weapons where Weap_name = @it"
                tsd.Parameters.AddWithValue("@it", Txt_w.Text)
                trdeader = tsd.ExecuteReader
                trdeader.Read()
                TLock = trdeader.GetInt32(0)
                trdeader.Close()
            Catch ex As Exception
                MsgBox("Chyba při čtení databáze: " + ex.Message, , "CHYBA")
                trdeader.Close()
                Exit Sub
            End Try
            Call WESPsubadd()
            Call WESKsubadd()
            Call WEELsubadd()
            Call FillForm()
        Else
            treader.Close()
            If MsgBox("Zbraň tohoto jména již v databázi existuje, chcete ji přepsat?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Upozornění") = MsgBoxResult.Yes Then
                Try
                    Dim s3 As String
                    Dim uc As New OleDbCommand
                    s3 = "UPDATE Weapons set Weap_name = @Weap_name, Typeg = @Typeg, Templatex = @Templatex, Looking = @Looking, Special_powers = @Special_powers, Daily_MG = @Daily_MG, EP_SP = @EP_SP, EP_SP_type = @EP_SP_type, Remarks = @Remarks, Rarity = @Rarity, App_price = @App_price, Zas = @Zas, Pru = @Pru, Drt = @Drt, Nic = @Nic, OC = @OC, Ini = @Ini, Spec_dmg = @Spec_dmg, Delk = @Delk, Silmin = @Silmin, Zas2 = @Zas2, Zas3 = @Zas3, Rang = @Rang, Rang2 = @Rang2, Rang3 = @Rang3, Bod = @Bod, Sek = @Sek, Drc = @Drc, Omg = @Omg, Mag = @Mag, HP = @HP, Weight = @Weight, Aweight = @Aweight, Typed = @Typed, Demon = @Demon, Ench = @Ench, Bless = @Bless, Material = @Material WHERE ID = @ID"
                    uc.Parameters.AddWithValue("@Weap_name", Trim(Txt_w.Text))
                    If Txt_Typg.Text = "" Then
                        uc.Parameters.AddWithValue("@Typeg", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Typeg", Trim(Txt_Typg.Text))
                    End If
                    If Txt_typ.Text = "" Then
                        uc.Parameters.AddWithValue("@Templatex", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Templatex", Trim(Txt_typ.Text))
                    End If
                    If Txt_pop.Text = "" Then
                        uc.Parameters.AddWithValue("@Looking", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Looking", Trim(Txt_pop.Text))
                    End If
                    If Txt_spec.Text = "" Then
                        uc.Parameters.AddWithValue("@Spec_powers", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Spec_powers", Trim(Txt_spec.Text))
                    End If
                    If Txt_mg.Text = "" Then
                        uc.Parameters.AddWithValue("@Daily_MG", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Daily_MG", Trim(Txt_mg.Text))
                    End If
                    If Txt_ep.Text = "" Then
                        uc.Parameters.AddWithValue("@EP_SP", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@EP_SP", Trim(Txt_ep.Text))
                    End If
                    If Txt_eptyp.Text = "" Then
                        uc.Parameters.AddWithValue("@EP_SP_type", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@EP_SP_type", Trim(Txt_eptyp.Text))
                    End If
                    If Txt_rem.Text = "" Then
                        uc.Parameters.AddWithValue("@Remarks", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Remarks", Trim(Txt_rem.Text))
                    End If
                    If Txt_UC.Text = "" Then
                        uc.Parameters.AddWithValue("@Zas", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Zas", Trim(Txt_UC.Text))
                    End If
                    If Txt_ut.Text = "" Then
                        uc.Parameters.AddWithValue("@Nic", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Nic", Trim(Txt_ut.Text))
                    End If
                    If Txt_sa.Text = "" Then
                        uc.Parameters.AddWithValue("@Spec_dmg", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Spec_dmg", Trim(Txt_sa.Text))
                    End If
                    If Txt_OC.Text = "" Then
                        uc.Parameters.AddWithValue("@OC", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@OC", Trim(Txt_OC.Text))
                    End If
                    If Txt_rar.Text = "" Then
                        uc.Parameters.AddWithValue("@Rarity", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Rarity", Trim(Txt_rar.Text))
                    End If
                    If Txt_price.Text = "" Then
                        uc.Parameters.AddWithValue("@App_price", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@App_price", Trim(Txt_price.Text))
                    End If
                    If Txt_stuff.Text = "" Then
                        uc.Parameters.AddWithValue("@Material", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Material", Trim(Txt_stuff.Text))
                    End If
                    If Txt_pru.Text = "" Then
                        uc.Parameters.AddWithValue("@Pru", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Pru", Trim(Txt_pru.Text))
                    End If
                    If Txt_drt.Text = "" Then
                        uc.Parameters.AddWithValue("@Drt", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Drt", Trim(Txt_drt.Text))
                    End If
                    If Txt_ini.Text = "" Then
                        uc.Parameters.AddWithValue("@Ini", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Ini", Trim(Txt_ini.Text))
                    End If
                    If Txt_zas2.Text = "" Then
                        uc.Parameters.AddWithValue("@Zas2", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Zas2", Trim(Txt_zas2.Text))
                    End If
                    If Txt_zas3.Text = "" Then
                        uc.Parameters.AddWithValue("@Zas3", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Zas3", Trim(Txt_zas3.Text))
                    End If
                    If Txt_ran.Text = "" Then
                        uc.Parameters.AddWithValue("@Rang", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Rang", Trim(Txt_ran.Text))
                    End If
                    If Txt_ran2.Text = "" Then
                        uc.Parameters.AddWithValue("@Rang2", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Rang2", Trim(Txt_ran2.Text))
                    End If
                    If Txt_ran3.Text = "" Then
                        uc.Parameters.AddWithValue("@Rang3", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Rang3", Trim(Txt_ran3.Text))
                    End If
                    If Txt_bod.Text = "" Then
                        uc.Parameters.AddWithValue("@Bod", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Bod", Trim(Txt_bod.Text))
                    End If
                    If Txt_sek.Text = "" Then
                        uc.Parameters.AddWithValue("@Sek", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Sek", Trim(Txt_sek.Text))
                    End If
                    If Txt_drc.Text = "" Then
                        uc.Parameters.AddWithValue("@Drc", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Drc", Trim(Txt_drc.Text))
                    End If
                    If Txt_omg.Text = "" Then
                        uc.Parameters.AddWithValue("@Omg", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Omg", Trim(Txt_omg.Text))
                    End If
                    If Txt_mag.Text = "" Then
                        uc.Parameters.AddWithValue("@Mag", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Mag", Trim(Txt_mag.Text))
                    End If
                    If Txt_hp.Text = "" Then
                        uc.Parameters.AddWithValue("@HP", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@HP", Trim(Txt_hp.Text))
                    End If
                    If Txt_we.Text = "" Then
                        uc.Parameters.AddWithValue("@Weight", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Weight", Trim(Txt_we.Text))
                    End If
                    If Txt_awe.Text = "" Then
                        uc.Parameters.AddWithValue("@Aweight", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Aweight", Trim(Txt_awe.Text))
                    End If
                    If Txt_typd.Text = "" Then
                        uc.Parameters.AddWithValue("@Typed", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Typed", Trim(Txt_typd.Text))
                    End If
                    If Txt_len.Text = "" Then
                        uc.Parameters.AddWithValue("@Delk", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Delk", Trim(Txt_len.Text))
                    End If
                    If Txt_silm.Text = "" Then
                        uc.Parameters.AddWithValue("@Silmin", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Silmin", Trim(Txt_silm.Text))
                    End If
                    If Txt_dem.Text = "" Then
                        uc.Parameters.AddWithValue("@Demon", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Demon", Trim(Txt_dem.Text))
                    End If
                    If Txt_ench.Text = "" Then
                        uc.Parameters.AddWithValue("@Ench", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Ench", Trim(Txt_ench.Text))
                    End If
                    If Txt_bles.Text = "" Then
                        uc.Parameters.AddWithValue("@Bless", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Bless", Trim(Txt_bles.Text))
                    End If
                    Call WESPsubupd()
                    Call WESKsubupd()
                    Call WEELsubupd()
                    uc.Parameters.AddWithValue("@ID", WErec.Tables("W").Rows(WEposition)("ID"))
                    uc.Connection = Odrialink2
                    uc.CommandText = s3
                    uc.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Chyba při zápisu do databáze: " + ex.Message, , "CHYBA")
                    Exit Sub
                End Try
                WErec.Clear()
                WEdat.Fill(WErec, "W")
                Call FillForm()
            Else
                Exit Sub
            End If
        End If

    End Sub

    Private Sub Cmd_Find_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Find.Click
        Dim WEse As New OleDbCommand
        Dim WEre As OleDbDataReader
        Dim s As String
        Dim q1 As Long
        Dim na, cz, ma, vy, dos, ro, za, sc, nc, ti, fa, po, rr, ap, al, xa, xb, xc, xd, xe, xf, xg, xh, xi, xj, xk, xl, xm, xn, xo, xp, xq, xr, xs, xt, xu, xv, xw As Boolean
        WEse.Connection = Odrialink2
        s = "SELECT * from Weapons WHERE "
        If Txt_w.Text <> "" Then
            s = s & "Weap_name LIKE @Weap_name"
            WEse.Parameters.AddWithValue("@Weap_name", "%" & Trim(Txt_w.Text) & "%")
            na = True
        End If
        If Txt_Typg.Text <> "" Then
            If na Then
                s = s & " AND "
            End If
            s = s & "Typeg LIKE @Typeg"
            WEse.Parameters.AddWithValue("@Typeg", "%" & Trim(Txt_Typg.Text) & "%")
            cz = True
        End If
        If Txt_pop.Text <> "" Then
            If na Or cz Then
                s = s & " AND "
            End If
            s = s & "Looking LIKE @Looking"
            WEse.Parameters.AddWithValue("@Looking", "%" & Trim(Txt_pop.Text) & "%")
            ma = True
        End If
        If Txt_spec.Text <> "" Then
            If na Or cz Or ma Then
                s = s & " AND "
            End If
            s = s & "Special_powers LIKE @Special_powers"
            WEse.Parameters.AddWithValue("@Special_powers", "%" & Trim(Txt_spec.Text) & "%")
            vy = True
        End If
        If Txt_mg.Text <> "" Then
            If na Or cz Or ma Or vy Then
                s = s & " AND "
            End If
            s = s & "Daily_MG = @Daily_MG"
            WEse.Parameters.AddWithValue("@Daily_MG", Trim(Txt_mg.Text))
            dos = True
        End If
        If Txt_ep.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Then
                s = s & " AND "
            End If
            s = s & "EP_SP = @EP_SP"
            WEse.Parameters.AddWithValue("@EP_SP", Trim(Txt_ep.Text))
            ro = True
        End If
        If Txt_eptyp.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Then
                s = s & " AND "
            End If
            s = s & "EP_SP_type LIKE @EP_SP_type"
            WEse.Parameters.AddWithValue("@EP_SP_type", "%" & Trim(Txt_eptyp.Text) & "%")
            za = True
        End If
        If Txt_rem.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Then
                s = s & " AND "
            End If
            s = s & "Remarks LIKE @Remarks"
            WEse.Parameters.AddWithValue("@Remarks", "%" & Trim(Txt_rem.Text) & "%")
            sc = True
        End If
        If Txt_typ.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Then
                s = s & " AND "
            End If
            s = s & "Templatex LIKE @Templatex"
            WEse.Parameters.AddWithValue("@Templatex", "%" & Trim(Txt_typ.Text) & "%")
            nc = True
        End If
        If Txt_UC.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Then
                s = s & " AND "
            End If
            s = s & "Zas = @Zas"
            WEse.Parameters.AddWithValue("@Zas", Trim(Txt_UC.Text))
            ti = True
        End If
        If Txt_pru.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Then
                s = s & " AND "
            End If
            s = s & "Pru = @Pru"
            WEse.Parameters.AddWithValue("@Pru", Trim(Txt_pru.Text))
            fa = True
        End If
        If Txt_drt.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Then
                s = s & " AND "
            End If
            s = s & "Drt = @SDrt"
            WEse.Parameters.AddWithValue("@Drt", Trim(Txt_drt.Text))
            po = True
        End If
        If Txt_rar.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Then
                s = s & " AND "
            End If
            s = s & "Rarity LIKE @Rarity"
            WEse.Parameters.AddWithValue("@Rarity", "%" & Trim(Txt_rar.Text) & "%")
            rr = True
        End If
        If Txt_price.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Then
                s = s & " AND "
            End If
            s = s & "App_price LIKE @App_price"
            WEse.Parameters.AddWithValue("@App_price", "%" & Trim(Txt_price.Text) & "%")
            ap = True
        End If
        If Txt_ut.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Then
                s = s & " AND "
            End If
            s = s & "Nic = @Nic"
            WEse.Parameters.AddWithValue("@Nic", Trim(Txt_ut.Text))
            al = True
        End If
        If Txt_OC.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Then
                s = s & " AND "
            End If
            s = s & "OC = @OC"
            WEse.Parameters.AddWithValue("@OC", Trim(Txt_OC.Text))
            xa = True
        End If
        If Txt_ini.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Then
                s = s & " AND "
            End If
            s = s & "Ini = @Ini"
            WEse.Parameters.AddWithValue("@Ini", Trim(Txt_ini.Text))
            xb = True
        End If
        If Txt_zas2.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Then
                s = s & " AND "
            End If
            s = s & "Zas2 = @Zas2"
            WEse.Parameters.AddWithValue("@Zas2", Trim(Txt_zas2.Text))
            xc = True
        End If
        If Txt_zas3.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Then
                s = s & " AND "
            End If
            s = s & "Zas3 = @Zas3"
            WEse.Parameters.AddWithValue("@Zas3", Trim(Txt_zas3.Text))
            xd = True
        End If
        If Txt_ran.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Then
                s = s & " AND "
            End If
            s = s & "Rang = @Rang"
            WEse.Parameters.AddWithValue("@Rang", Trim(Txt_ran.Text))
            xe = True
        End If
        If Txt_ran2.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Or xe Then
                s = s & " AND "
            End If
            s = s & "Rang2 = @Rang2"
            WEse.Parameters.AddWithValue("@Rang2", Trim(Txt_ran2.Text))
            xf = True
        End If
        If Txt_ran3.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Or xe Or xf Then
                s = s & " AND "
            End If
            s = s & "Rang3 = @Rang3"
            WEse.Parameters.AddWithValue("@Rang3", Trim(Txt_ran3.Text))
            xg = True
        End If
        If Txt_bod.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Or xe Or xf Or xg Then
                s = s & " AND "
            End If
            s = s & "Bod = @Bod"
            WEse.Parameters.AddWithValue("@Bod", Trim(Txt_bod.Text))
            xh = True
        End If
        If Txt_sek.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Or xe Or xf Or xg Or xh Then
                s = s & " AND "
            End If
            s = s & "Sek = @Sek"
            WEse.Parameters.AddWithValue("@Sek", Trim(Txt_sek.Text))
            xi = True
        End If
        If Txt_drc.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Or xe Or xf Or xg Or xh Or xi Then
                s = s & " AND "
            End If
            s = s & "Drc = @Drc"
            WEse.Parameters.AddWithValue("@Drc", Trim(Txt_drc.Text))
            xj = True
        End If
        If Txt_omg.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Or xe Or xf Or xg Or xh Or xi Or xj Then
                s = s & " AND "
            End If
            s = s & "Omg = @Omg"
            WEse.Parameters.AddWithValue("@Omg", Trim(Txt_omg.Text))
            xk = True
        End If
        If Txt_mag.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Or xe Or xf Or xg Or xh Or xi Or xj Or xk Then
                s = s & " AND "
            End If
            s = s & "Mag = @Mag"
            WEse.Parameters.AddWithValue("@Mag", Trim(Txt_mag.Text))
            xl = True
        End If
        If Txt_hp.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Or xe Or xf Or xg Or xh Or xi Or xj Or xk Or xl Then
                s = s & " AND "
            End If
            s = s & "HP = @HP"
            WEse.Parameters.AddWithValue("@HP", Trim(Txt_hp.Text))
            xm = True
        End If
        If Txt_we.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Or xe Or xf Or xg Or xh Or xi Or xj Or xk Or xl Or xm Then
                s = s & " AND "
            End If
            s = s & "Weight = @Weight"
            WEse.Parameters.AddWithValue("@Weight", Trim(Txt_we.Text))
            xn = True
        End If
        If Txt_awe.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Or xe Or xf Or xg Or xh Or xi Or xj Or xk Or xl Or xm Or xn Then
                s = s & " AND "
            End If
            s = s & "Aweight = @Aweight"
            WEse.Parameters.AddWithValue("@Aweight", Trim(Txt_awe.Text))
            xo = True
        End If
        If Txt_silm.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Or xe Or xf Or xg Or xh Or xi Or xj Or xk Or xl Or xm Or xn Or xo Then
                s = s & " AND "
            End If
            s = s & "Silmin = @Silmin"
            WEse.Parameters.AddWithValue("@Silmin", Trim(Txt_silm.Text))
            xp = True
        End If
        If Txt_len.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Or xe Or xf Or xg Or xh Or xi Or xj Or xk Or xl Or xm Or xn Or xo Or xp Then
                s = s & " AND "
            End If
            s = s & "Delk = @Delk"
            WEse.Parameters.AddWithValue("@Delk", Trim(Txt_len.Text))
            xq = True
        End If
        If Txt_sa.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Or xe Or xf Or xg Or xh Or xi Or xj Or xk Or xl Or xm Or xn Or xo Or xp Or xq Then
                s = s & " AND "
            End If
            s = s & "Spec_dmg LIKE @Spec_dmg"
            WEse.Parameters.AddWithValue("@Spec_dmg", "%" & Trim(Txt_sa.Text) & "%")
            xr = True
        End If
        If Txt_typd.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Or xe Or xf Or xg Or xh Or xi Or xj Or xk Or xl Or xm Or xn Or xo Or xp Or xq Or xr Then
                s = s & " AND "
            End If
            s = s & "Typed LIKE @Typed"
            WEse.Parameters.AddWithValue("@Typed", "%" & Trim(Txt_typd.Text) & "%")
            xs = True
        End If
        If Txt_stuff.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Or xe Or xf Or xg Or xh Or xi Or xj Or xk Or xl Or xm Or xn Or xo Or xp Or xq Or xr Or xs Then
                s = s & " AND "
            End If
            s = s & "Material LIKE @Material"
            WEse.Parameters.AddWithValue("@Material", "%" & Trim(Txt_stuff.Text) & "%")
            xt = True
        End If
        If Txt_dem.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Or xe Or xf Or xg Or xh Or xi Or xj Or xk Or xl Or xm Or xn Or xo Or xp Or xq Or xr Or xs Or xt Then
                s = s & " AND "
            End If
            s = s & "Demon LIKE @Demon"
            WEse.Parameters.AddWithValue("@Demon", "%" & Trim(Txt_dem.Text) & "%")
            xu = True
        End If
        If Txt_ench.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Or xe Or xf Or xg Or xh Or xi Or xj Or xk Or xl Or xm Or xn Or xo Or xp Or xq Or xr Or xs Or xt Or xu Then
                s = s & " AND "
            End If
            s = s & "Ench LIKE @Ench"
            WEse.Parameters.AddWithValue("@Ench", "%" & Trim(Txt_ench.Text) & "%")
            xv = True
        End If
        If Txt_bles.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Or al Or xa Or xb Or xc Or xd Or xe Or xf Or xg Or xh Or xi Or xj Or xk Or xl Or xm Or xn Or xo Or xp Or xq Or xr Or xs Or xt Or xu Or xv Then
                s = s & " AND "
            End If
            s = s & "Bless LIKE @Bless"
            WEse.Parameters.AddWithValue("@Bless", "%" & Trim(Txt_bles.Text) & "%")
            xw = True
        End If
        WEposition = 0
        If s = "SELECT * from Weapons WHERE " Then
            WErecopen()
            FillForm()
            Exit Sub
        End If
        Try
            WEse.CommandText = s
            WEre = WEse.ExecuteReader
            If WEre.HasRows Then
                q1 = 0
                While WEre.Read()
                    q1 += 1
                End While
                WEre.Close()
                If q1 = 1 Then
                    Do
                        If Txt_w.Text = WErec.Tables("W").Rows(WEposition)("Weap_name") Then
                            Exit Do
                        End If
                        WEposition += 1
                    Loop Until WEposition + 1 = WEcount
                Else
                    WEdat.SelectCommand = WEse
                    WErec.Clear()
                    WEdat.Fill(WErec, "W")
                    WEcount = WErec.Tables("W").Rows.Count
                    If GC_list = 1 Then
                        If my_sez Is Nothing Then
                            my_sez = New Frm_WEsez
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
                WEre.Close()
                MsgBox("Žádný záznam neodpovídá zvoleným parametrům.", , "Nenalezeno")
                Exit Sub
            End If
            WEre.Close()
        Catch ex As Exception
            MsgBox("Chyba při čtení databáze." + ex.Message, , "Chyba")
            Exit Sub
        End Try
        Call FillForm()
    End Sub

    Private Sub Cmd_Del_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Del.Click
        Dim tsc As New OleDbCommand
        If MsgBox("Opravdu vymazat zbraň " & Txt_w.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Upozornění") = MsgBoxResult.Yes Then
            Try
                tsc.Connection = Odrialink2
                tsc.CommandText = "DELETE from Weapons WHERE ID = @ID"
                tsc.Parameters.AddWithValue("@ID", WErec.Tables("W").Rows(WEposition)("ID"))
                tsc.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception("Chyba při výmazu případu: " + ex.Message)
                Exit Sub
            End Try
        Else
            Exit Sub
        End If
        WErec.Clear()
        WEdat.Fill(WErec, "W")
        WEcount = WErec.Tables("W").Rows.Count
        If WEposition = WEcount Then
            WEposition -= 1
        End If
        Call FillForm()
    End Sub


    Private Sub WESPsubadd()
        Dim a As Long
        Dim q As Long
        q = Lst_spells.Items.Count
        If q > -1 Then
            Dim gr As String
            gr = "INSERT INTO Wespells (We_ID, Spell) VALUES (@We_ID, @Spell)"

            For a = 0 To q - 1
                Dim g As New OleDbCommand
                g.Parameters.AddWithValue("@We_ID", TLock)
                g.Parameters.AddWithValue("@Spell", VB6.GetItemString(Lst_spells, a))
                g.Connection = Odrialink2
                g.CommandText = gr
                g.ExecuteScalar()
                g.Dispose()
            Next
        End If
    End Sub


    Private Sub WESPsubupd()
        Dim a As Long
        Dim q As Long
        Dim h As New OleDbCommand
        Try
            h.Connection = Odrialink2
            h.CommandText = "DELETE from Wespells WHERE We_ID = @ii"
            h.Parameters.AddWithValue("@ii", WErec.Tables("W").Rows(WEposition)("ID"))
            h.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Chyba při výmazu případu: " + ex.Message)
            Exit Sub
        End Try
        q = Lst_spells.Items.Count
        If q > -1 Then
            Dim gr As String
            gr = "INSERT INTO Wespells (We_ID, Spell) VALUES (@We_ID, @Spell)"

            For a = 0 To q - 1
                Dim g As New OleDbCommand
                g.Parameters.AddWithValue("@We_ID", WErec.Tables("W").Rows(WEposition)("ID"))
                g.Parameters.AddWithValue("@Spell", VB6.GetItemString(Lst_spells, a))
                g.Connection = Odrialink2
                g.CommandText = gr
                g.ExecuteScalar()
                g.Dispose()
            Next
        End If

    End Sub


    Private Sub WESKsubadd()
        Dim a As Long
        Dim q As Long
        Dim c As Long
        q = Lst_skills.Items.Count
        If q > -1 Then
            Dim gr As String
            gr = "INSERT INTO Weskills (We_ID, Skill, Knowledge) VALUES (@We_ID, @Skill, @Know)"

            For a = 0 To q - 1
                Dim g As New OleDbCommand
                g.Parameters.AddWithValue("@We_ID", TLock)
                For c = 1 To Len(VB6.GetItemString(Lst_skills, a)) - 2
                    If Mid(VB6.GetItemString(Lst_skills, a), c, 3) = "   " Then
                        g.Parameters.AddWithValue("@Skill", Mid(VB6.GetItemString(Lst_skills, a), 1, c - 1))
                        g.Parameters.AddWithValue("@Knowledge", Mid(VB6.GetItemString(Lst_skills, a), c + 3, Len(VB6.GetItemString(Lst_skills, a)) - (c + 2)))
                    End If
                Next
                g.Connection = Odrialink2
                g.CommandText = gr
                g.ExecuteScalar()
                g.Dispose()
            Next
        End If
    End Sub

    Private Sub WESKsubupd()
        Dim a As Long
        Dim q As Long
        Dim c As Long
        Dim h As New OleDbCommand
        Try
            h.Connection = Odrialink2
            h.CommandText = "DELETE from Weskills WHERE We_ID = @ii"
            h.Parameters.AddWithValue("@ii", WErec.Tables("W").Rows(WEposition)("ID"))
            h.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Chyba při výmazu případu: " + ex.Message)
            Exit Sub
        End Try
        q = Lst_skills.Items.Count
        If q > -1 Then
            Dim gr As String
            gr = "INSERT INTO Weskills (We_ID, Skill, Knowledge) VALUES (@We_ID, @Skill, @Know)"

            For a = 0 To q - 1
                Dim g As New OleDbCommand
                g.Parameters.AddWithValue("@We_ID", WErec.Tables("W").Rows(WEposition)("ID"))
                For c = 1 To Len(VB6.GetItemString(Lst_skills, a)) - 2
                    If Mid(VB6.GetItemString(Lst_skills, a), c, 3) = "   " Then
                        g.Parameters.AddWithValue("@Skill", Mid(VB6.GetItemString(Lst_skills, a), 1, c - 1))
                        g.Parameters.AddWithValue("@Knowledge", Mid(VB6.GetItemString(Lst_skills, a), c + 3, Len(VB6.GetItemString(Lst_skills, a)) - (c + 2)))
                    End If
                Next
                g.Connection = Odrialink2
                g.CommandText = gr
                g.ExecuteScalar()
                g.Dispose()
            Next
        End If

    End Sub

    Private Sub WEELsubadd()
        Dim c As Long
        Dim a As Long
        Dim q As Long
        q = Lst_res.Items.Count
        If q > -1 Then
            Dim gr As String
            gr = "INSERT INTO Weresistances (We_ID, Resistance_to, Percent) VALUES (@We_ID, @Rest, @Per)"

            For a = 0 To q - 1
                Dim g As New OleDbCommand
                g.Parameters.AddWithValue("@We_ID", TLock)
                For c = 1 To Len(VB6.GetItemString(Lst_res, a)) - 2
                    If Mid(VB6.GetItemString(Lst_res, a), c, 3) = "   " Then
                        g.Parameters.AddWithValue("@Rest", Mid(VB6.GetItemString(Lst_res, a), 1, c - 1))
                        g.Parameters.AddWithValue("@Per", Mid(VB6.GetItemString(Lst_res, a), c + 3, Len(VB6.GetItemString(Lst_res, a)) - (c + 3)))
                    End If
                Next
                g.Connection = Odrialink2
                g.CommandText = gr
                g.ExecuteScalar()
                g.Dispose()
            Next
        End If
    End Sub

    Private Sub WEELsubupd()
        Dim c As Long
        Dim a As Long
        Dim q As Long
        Dim h As New OleDbCommand
        Try
            h.Connection = Odrialink2
            h.CommandText = "DELETE from Weresistances WHERE We_ID = @ii"
            h.Parameters.AddWithValue("@ii", WErec.Tables("W").Rows(WEposition)("ID"))
            h.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Chyba při výmazu případu: " + ex.Message)
            Exit Sub
        End Try
        q = Lst_res.Items.Count
        If q > -1 Then
            Dim gr As String
            gr = "INSERT INTO Weresistances (We_ID, Resistance_to, Percent) VALUES (@We_ID, @Rest, @Per)"

            For a = 0 To q - 1
                Dim g As New OleDbCommand
                g.Parameters.AddWithValue("@We_ID", WErec.Tables("W").Rows(WEposition)("ID"))
                For c = 1 To Len(VB6.GetItemString(Lst_res, a)) - 2
                    If Mid(VB6.GetItemString(Lst_res, a), c, 3) = "   " Then
                        g.Parameters.AddWithValue("@Rest", Mid(VB6.GetItemString(Lst_res, a), 1, c - 1))
                        g.Parameters.AddWithValue("@Per", Mid(VB6.GetItemString(Lst_res, a), c + 3, Len(VB6.GetItemString(Lst_res, a)) - (c + 3)))
                    End If
                Next
                g.Connection = Odrialink2
                g.CommandText = gr
                g.ExecuteScalar()
                g.Dispose()
            Next
        End If
    End Sub

    Private Sub Bt_List_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_List.Click
        If my_sez Is Nothing Then
            my_sez = New Frm_WEsez
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
        Me.BackColor = Color.FromArgb(FWB)
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
        Label1.ForeColor = Color.FromArgb(FWFO)
        Label2.ForeColor = Color.FromArgb(FWFO)
        Label3.ForeColor = Color.FromArgb(FWFO)
        Label4.ForeColor = Color.FromArgb(FWFO)
        Label5.ForeColor = Color.FromArgb(FWFO)
        Label6.ForeColor = Color.FromArgb(FWFO)
        Label7.ForeColor = Color.FromArgb(FWFO)
        Label8.ForeColor = Color.FromArgb(FWFO)
        Label9.ForeColor = Color.FromArgb(FWFO)
        Label10.ForeColor = Color.FromArgb(FWFO)
        Label11.ForeColor = Color.FromArgb(FWFO)
        Label12.ForeColor = Color.FromArgb(FWFO)
        Label13.ForeColor = Color.FromArgb(FWFO)
        Label14.ForeColor = Color.FromArgb(FWFO)
        Label15.ForeColor = Color.FromArgb(FWFO)
        Label16.ForeColor = Color.FromArgb(FWFO)
        Label17.ForeColor = Color.FromArgb(FWFO)
        Label18.ForeColor = Color.FromArgb(FWFO)
        Label19.ForeColor = Color.FromArgb(FWFO)
        Label20.ForeColor = Color.FromArgb(FWFO)
        Label21.ForeColor = Color.FromArgb(FWFO)
        Label22.ForeColor = Color.FromArgb(FWFO)
        Label23.ForeColor = Color.FromArgb(FWFO)
        Label24.ForeColor = Color.FromArgb(FWFO)
        Label25.ForeColor = Color.FromArgb(FWFO)
        Label26.ForeColor = Color.FromArgb(FWFO)
        Label27.ForeColor = Color.FromArgb(FWFO)
        Label28.ForeColor = Color.FromArgb(FWFO)
        Label29.ForeColor = Color.FromArgb(FWFO)
        Label30.ForeColor = Color.FromArgb(FWFO)
        Label31.ForeColor = Color.FromArgb(FWFO)
        Label32.ForeColor = Color.FromArgb(FWFO)
        Label33.ForeColor = Color.FromArgb(FWFO)
        Label34.ForeColor = Color.FromArgb(FWFO)
        Label35.ForeColor = Color.FromArgb(FWFO)
        Label36.ForeColor = Color.FromArgb(FWFO)
        Label37.ForeColor = Color.FromArgb(FWFO)
        Label38.ForeColor = Color.FromArgb(FWFO)
        Label39.ForeColor = Color.FromArgb(FWFO)
        Txt_Num.ForeColor = Color.FromArgb(FWFO)
        Txt_w.ForeColor = Color.FromArgb(FWFO)
        Txt_Typg.ForeColor = Color.FromArgb(FWFO)
        Txt_typ.ForeColor = Color.FromArgb(FWFO)
        Txt_pop.ForeColor = Color.FromArgb(FWFO)
        Txt_spec.ForeColor = Color.FromArgb(FWFO)
        Txt_mg.ForeColor = Color.FromArgb(FWFO)
        Txt_ep.ForeColor = Color.FromArgb(FWFO)
        Txt_eptyp.ForeColor = Color.FromArgb(FWFO)
        Txt_rem.ForeColor = Color.FromArgb(FWFO)
        Txt_UC.ForeColor = Color.FromArgb(FWFO)
        Txt_pru.ForeColor = Color.FromArgb(FWFO)
        Txt_drt.ForeColor = Color.FromArgb(FWFO)
        Txt_spec.ForeColor = Color.FromArgb(FWFO)
        Txt_ut.ForeColor = Color.FromArgb(FWFO)
        Txt_rar.ForeColor = Color.FromArgb(FWFO)
        Txt_price.ForeColor = Color.FromArgb(FWFO)
        Txt_OC.ForeColor = Color.FromArgb(FWFO)
        Txt_ini.ForeColor = Color.FromArgb(FWFO)
        Txt_zas2.ForeColor = Color.FromArgb(FWFO)
        Txt_zas3.ForeColor = Color.FromArgb(FWFO)
        Txt_ran.ForeColor = Color.FromArgb(FWFO)
        Txt_ran2.ForeColor = Color.FromArgb(FWFO)
        Txt_ran3.ForeColor = Color.FromArgb(FWFO)
        Txt_bod.ForeColor = Color.FromArgb(FWFO)
        Txt_sek.ForeColor = Color.FromArgb(FWFO)
        Txt_drc.ForeColor = Color.FromArgb(FWFO)
        Txt_omg.ForeColor = Color.FromArgb(FWFO)
        Txt_mag.ForeColor = Color.FromArgb(FWFO)
        Txt_hp.ForeColor = Color.FromArgb(FWFO)
        Txt_len.ForeColor = Color.FromArgb(FWFO)
        Txt_silm.ForeColor = Color.FromArgb(FWFO)
        Txt_typd.ForeColor = Color.FromArgb(FWFO)
        Txt_sa.ForeColor = Color.FromArgb(FWFO)
        Txt_we.ForeColor = Color.FromArgb(FWFO)
        Txt_awe.ForeColor = Color.FromArgb(FWFO)
        Txt_stuff.ForeColor = Color.FromArgb(FWFO)
        Txt_dem.ForeColor = Color.FromArgb(FWFO)
        Txt_ench.ForeColor = Color.FromArgb(FWFO)
        Txt_bles.ForeColor = Color.FromArgb(FWFO)
        Lst_spells.ForeColor = Color.FromArgb(FSPFO)
        Lst_spells.BackColor = Color.FromArgb(FSPB)
        Lst_skills.ForeColor = Color.FromArgb(FSKFO)
        Lst_skills.BackColor = Color.FromArgb(FSKB)
        Lst_res.ForeColor = Color.FromArgb(FEFO)
        Lst_res.BackColor = Color.FromArgb(FEB)
    End Sub

    Sub Weapaid()
        Dim waid As New Frm_Waid
        waid.Show()

    End Sub
End Class