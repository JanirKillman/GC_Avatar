Option Strict Off
Option Explicit On 
Imports System.Data.oledb
Friend Class Frm_Nations
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
	Public WithEvents Lst_nei As System.Windows.Forms.ListBox
	Public WithEvents Cmd_Snei As System.Windows.Forms.Button
	Public WithEvents Cmd_Slan As System.Windows.Forms.Button
	Public WithEvents Cmd_Srul As System.Windows.Forms.Button
	Public WithEvents Cmd_Shlm As System.Windows.Forms.Button
	Public WithEvents Cmd_Exit As System.Windows.Forms.Button
	Public WithEvents Cmd_Ins As System.Windows.Forms.Button
	Public WithEvents Cmd_Del As System.Windows.Forms.Button
	Public WithEvents Cmd_Find As System.Windows.Forms.Button
	Public WithEvents Cmd_New As System.Windows.Forms.Button
	Public WithEvents Cmd_Print As System.Windows.Forms.Button
	Public WithEvents Cmd_Order As System.Windows.Forms.Button
	Public WithEvents Cmd_First As System.Windows.Forms.Button
	Public WithEvents Cmd_Back As System.Windows.Forms.Button
	Public WithEvents Cmd_Forward As System.Windows.Forms.Button
	Public WithEvents Cmd_Last As System.Windows.Forms.Button
	Public WithEvents Txt_Num As System.Windows.Forms.TextBox
	Public WithEvents Txt_poz As System.Windows.Forms.TextBox
	Public WithEvents Txt_exp As System.Windows.Forms.TextBox
	Public WithEvents Txt_side As System.Windows.Forms.TextBox
	Public WithEvents Txt_imp As System.Windows.Forms.TextBox
	Public WithEvents Txt_lan As System.Windows.Forms.TextBox
	Public WithEvents Txt_nei As System.Windows.Forms.TextBox
	Public WithEvents Txt_zas As System.Windows.Forms.TextBox
	Public WithEvents Txt_divi As System.Windows.Forms.TextBox
	Public WithEvents Txt_aexp As System.Windows.Forms.TextBox
	Public WithEvents Txt_atrain As System.Windows.Forms.TextBox
	Public WithEvents Txt_asize As System.Windows.Forms.TextBox
	Public WithEvents Txt_rich As System.Windows.Forms.TextBox
	Public WithEvents Txt_hap As System.Windows.Forms.TextBox
	Public WithEvents Txt_maglev As System.Windows.Forms.TextBox
	Public WithEvents Txt_lord As System.Windows.Forms.TextBox
	Public WithEvents Txt_par As System.Windows.Forms.TextBox
	Public WithEvents Txt_child As System.Windows.Forms.TextBox
	Public WithEvents Txt_ruler As System.Windows.Forms.TextBox
	Public WithEvents Txt_ccount As System.Windows.Forms.TextBox
	Public WithEvents Txt_gov As System.Windows.Forms.TextBox
	Public WithEvents Txt_hlm As System.Windows.Forms.TextBox
	Public WithEvents Txt_kont As System.Windows.Forms.TextBox
	Public WithEvents Txt_name As System.Windows.Forms.TextBox
	Public WithEvents Txt_N As System.Windows.Forms.TextBox
	Public WithEvents Label25 As System.Windows.Forms.Label
	Public WithEvents Label24 As System.Windows.Forms.Label
	Public WithEvents Label23 As System.Windows.Forms.Label
	Public WithEvents Label22 As System.Windows.Forms.Label
	Public WithEvents Label21 As System.Windows.Forms.Label
	Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Nations))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Ins = New System.Windows.Forms.Button
        Me.Cmd_Del = New System.Windows.Forms.Button
        Me.Cmd_Find = New System.Windows.Forms.Button
        Me.Cmd_New = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_Order = New System.Windows.Forms.Button
        Me.Cmd_First = New System.Windows.Forms.Button
        Me.Cmd_Back = New System.Windows.Forms.Button
        Me.Cmd_Forward = New System.Windows.Forms.Button
        Me.Cmd_Last = New System.Windows.Forms.Button
        Me.Lst_nei = New System.Windows.Forms.ListBox
        Me.Cmd_Snei = New System.Windows.Forms.Button
        Me.Cmd_Slan = New System.Windows.Forms.Button
        Me.Cmd_Srul = New System.Windows.Forms.Button
        Me.Cmd_Shlm = New System.Windows.Forms.Button
        Me.Txt_Num = New System.Windows.Forms.TextBox
        Me.Txt_poz = New System.Windows.Forms.TextBox
        Me.Txt_exp = New System.Windows.Forms.TextBox
        Me.Txt_side = New System.Windows.Forms.TextBox
        Me.Txt_imp = New System.Windows.Forms.TextBox
        Me.Txt_lan = New System.Windows.Forms.TextBox
        Me.Txt_nei = New System.Windows.Forms.TextBox
        Me.Txt_zas = New System.Windows.Forms.TextBox
        Me.Txt_divi = New System.Windows.Forms.TextBox
        Me.Txt_aexp = New System.Windows.Forms.TextBox
        Me.Txt_atrain = New System.Windows.Forms.TextBox
        Me.Txt_asize = New System.Windows.Forms.TextBox
        Me.Txt_rich = New System.Windows.Forms.TextBox
        Me.Txt_hap = New System.Windows.Forms.TextBox
        Me.Txt_maglev = New System.Windows.Forms.TextBox
        Me.Txt_lord = New System.Windows.Forms.TextBox
        Me.Txt_par = New System.Windows.Forms.TextBox
        Me.Txt_child = New System.Windows.Forms.TextBox
        Me.Txt_ruler = New System.Windows.Forms.TextBox
        Me.Txt_ccount = New System.Windows.Forms.TextBox
        Me.Txt_gov = New System.Windows.Forms.TextBox
        Me.Txt_hlm = New System.Windows.Forms.TextBox
        Me.Txt_kont = New System.Windows.Forms.TextBox
        Me.Txt_name = New System.Windows.Forms.TextBox
        Me.Txt_N = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Bt_List = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Exit.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(600, 352)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Exit.Size = New System.Drawing.Size(144, 57)
        Me.Cmd_Exit.TabIndex = 59
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
        Me.Cmd_Ins.Location = New System.Drawing.Point(512, 240)
        Me.Cmd_Ins.Name = "Cmd_Ins"
        Me.Cmd_Ins.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Ins.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Ins.TabIndex = 58
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
        Me.Cmd_Del.Location = New System.Drawing.Point(512, 272)
        Me.Cmd_Del.Name = "Cmd_Del"
        Me.Cmd_Del.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Del.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Del.TabIndex = 57
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
        Me.Cmd_Find.Location = New System.Drawing.Point(512, 304)
        Me.Cmd_Find.Name = "Cmd_Find"
        Me.Cmd_Find.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Find.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Find.TabIndex = 56
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
        Me.Cmd_New.Location = New System.Drawing.Point(632, 240)
        Me.Cmd_New.Name = "Cmd_New"
        Me.Cmd_New.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_New.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_New.TabIndex = 55
        Me.Cmd_New.Text = "NOVÝ"
        Me.ToolTip1.SetToolTip(Me.Cmd_New, "Vymaže pole, příprava na vepsání nového kouzla")
        Me.Cmd_New.UseVisualStyleBackColor = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.Cyan
        Me.Cmd_Print.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Print.Location = New System.Drawing.Point(632, 272)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Print.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Print.TabIndex = 54
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
        Me.Cmd_Order.Location = New System.Drawing.Point(632, 304)
        Me.Cmd_Order.Name = "Cmd_Order"
        Me.Cmd_Order.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Order.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Order.TabIndex = 53
        Me.Cmd_Order.Text = "ŘAZENÍ"
        Me.ToolTip1.SetToolTip(Me.Cmd_Order, "Změnit parametry řazení kouzel")
        Me.Cmd_Order.UseVisualStyleBackColor = False
        '
        'Cmd_First
        '
        Me.Cmd_First.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_First.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_First.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_First.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_First.Image = CType(resources.GetObject("Cmd_First.Image"), System.Drawing.Image)
        Me.Cmd_First.Location = New System.Drawing.Point(240, 432)
        Me.Cmd_First.Name = "Cmd_First"
        Me.Cmd_First.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_First.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_First.TabIndex = 52
        Me.Cmd_First.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_First, "Na začátek")
        Me.Cmd_First.UseVisualStyleBackColor = False
        '
        'Cmd_Back
        '
        Me.Cmd_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Back.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Back.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Back.Image = CType(resources.GetObject("Cmd_Back.Image"), System.Drawing.Image)
        Me.Cmd_Back.Location = New System.Drawing.Point(280, 432)
        Me.Cmd_Back.Name = "Cmd_Back"
        Me.Cmd_Back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Back.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_Back.TabIndex = 51
        Me.Cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Back, "O 1 vzad")
        Me.Cmd_Back.UseVisualStyleBackColor = False
        '
        'Cmd_Forward
        '
        Me.Cmd_Forward.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Forward.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Forward.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Forward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Forward.Image = CType(resources.GetObject("Cmd_Forward.Image"), System.Drawing.Image)
        Me.Cmd_Forward.Location = New System.Drawing.Point(432, 432)
        Me.Cmd_Forward.Name = "Cmd_Forward"
        Me.Cmd_Forward.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Forward.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_Forward.TabIndex = 50
        Me.Cmd_Forward.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Forward, "O 1 vpřed")
        Me.Cmd_Forward.UseVisualStyleBackColor = False
        '
        'Cmd_Last
        '
        Me.Cmd_Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Last.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Last.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Last.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Last.Image = CType(resources.GetObject("Cmd_Last.Image"), System.Drawing.Image)
        Me.Cmd_Last.Location = New System.Drawing.Point(472, 432)
        Me.Cmd_Last.Name = "Cmd_Last"
        Me.Cmd_Last.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Last.Size = New System.Drawing.Size(41, 33)
        Me.Cmd_Last.TabIndex = 49
        Me.Cmd_Last.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Last, "Na konec")
        Me.Cmd_Last.UseVisualStyleBackColor = False
        '
        'Lst_nei
        '
        Me.Lst_nei.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lst_nei.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_nei.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_nei.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Lst_nei.ItemHeight = 14
        Me.Lst_nei.Location = New System.Drawing.Point(304, 32)
        Me.Lst_nei.Name = "Lst_nei"
        Me.Lst_nei.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_nei.Size = New System.Drawing.Size(153, 60)
        Me.Lst_nei.TabIndex = 65
        Me.Lst_nei.Visible = False
        '
        'Cmd_Snei
        '
        Me.Cmd_Snei.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Snei.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Snei.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Snei.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Snei.Location = New System.Drawing.Point(568, 472)
        Me.Cmd_Snei.Name = "Cmd_Snei"
        Me.Cmd_Snei.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Snei.Size = New System.Drawing.Size(153, 33)
        Me.Cmd_Snei.TabIndex = 64
        Me.Cmd_Snei.Text = "Sousedy"
        Me.Cmd_Snei.UseVisualStyleBackColor = False
        '
        'Cmd_Slan
        '
        Me.Cmd_Slan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Slan.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Slan.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Slan.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Slan.Location = New System.Drawing.Point(416, 472)
        Me.Cmd_Slan.Name = "Cmd_Slan"
        Me.Cmd_Slan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Slan.Size = New System.Drawing.Size(153, 33)
        Me.Cmd_Slan.TabIndex = 63
        Me.Cmd_Slan.Text = "Jazyk"
        Me.Cmd_Slan.UseVisualStyleBackColor = False
        '
        'Cmd_Srul
        '
        Me.Cmd_Srul.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Srul.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Srul.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Srul.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Srul.Location = New System.Drawing.Point(264, 472)
        Me.Cmd_Srul.Name = "Cmd_Srul"
        Me.Cmd_Srul.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Srul.Size = New System.Drawing.Size(153, 33)
        Me.Cmd_Srul.TabIndex = 62
        Me.Cmd_Srul.Text = "Vládce"
        Me.Cmd_Srul.UseVisualStyleBackColor = False
        '
        'Cmd_Shlm
        '
        Me.Cmd_Shlm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Shlm.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Shlm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Shlm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Shlm.Location = New System.Drawing.Point(112, 472)
        Me.Cmd_Shlm.Name = "Cmd_Shlm"
        Me.Cmd_Shlm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Shlm.Size = New System.Drawing.Size(153, 33)
        Me.Cmd_Shlm.TabIndex = 61
        Me.Cmd_Shlm.Text = "Hlavní město"
        Me.Cmd_Shlm.UseVisualStyleBackColor = False
        '
        'Txt_Num
        '
        Me.Txt_Num.AcceptsReturn = True
        Me.Txt_Num.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Num.Font = New System.Drawing.Font("Arial", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Location = New System.Drawing.Point(320, 432)
        Me.Txt_Num.MaxLength = 0
        Me.Txt_Num.Name = "Txt_Num"
        Me.Txt_Num.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Num.Size = New System.Drawing.Size(113, 33)
        Me.Txt_Num.TabIndex = 48
        Me.Txt_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_poz
        '
        Me.Txt_poz.AcceptsReturn = True
        Me.Txt_poz.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_poz.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_poz.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_poz.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_poz.Location = New System.Drawing.Point(88, 328)
        Me.Txt_poz.MaxLength = 0
        Me.Txt_poz.Multiline = True
        Me.Txt_poz.Name = "Txt_poz"
        Me.Txt_poz.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_poz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_poz.Size = New System.Drawing.Size(417, 89)
        Me.Txt_poz.TabIndex = 47
        '
        'Txt_exp
        '
        Me.Txt_exp.AcceptsReturn = True
        Me.Txt_exp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_exp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_exp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_exp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_exp.Location = New System.Drawing.Point(88, 272)
        Me.Txt_exp.MaxLength = 0
        Me.Txt_exp.Multiline = True
        Me.Txt_exp.Name = "Txt_exp"
        Me.Txt_exp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_exp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_exp.Size = New System.Drawing.Size(417, 41)
        Me.Txt_exp.TabIndex = 45
        '
        'Txt_side
        '
        Me.Txt_side.AcceptsReturn = True
        Me.Txt_side.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_side.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_side.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_side.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_side.Location = New System.Drawing.Point(424, 240)
        Me.Txt_side.MaxLength = 0
        Me.Txt_side.Name = "Txt_side"
        Me.Txt_side.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_side.Size = New System.Drawing.Size(81, 19)
        Me.Txt_side.TabIndex = 43
        '
        'Txt_imp
        '
        Me.Txt_imp.AcceptsReturn = True
        Me.Txt_imp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_imp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_imp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_imp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_imp.Location = New System.Drawing.Point(280, 240)
        Me.Txt_imp.MaxLength = 0
        Me.Txt_imp.Name = "Txt_imp"
        Me.Txt_imp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_imp.Size = New System.Drawing.Size(65, 19)
        Me.Txt_imp.TabIndex = 41
        '
        'Txt_lan
        '
        Me.Txt_lan.AcceptsReturn = True
        Me.Txt_lan.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_lan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_lan.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_lan.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_lan.Location = New System.Drawing.Point(88, 240)
        Me.Txt_lan.MaxLength = 0
        Me.Txt_lan.Name = "Txt_lan"
        Me.Txt_lan.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_lan.Size = New System.Drawing.Size(97, 19)
        Me.Txt_lan.TabIndex = 39
        '
        'Txt_nei
        '
        Me.Txt_nei.AcceptsReturn = True
        Me.Txt_nei.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_nei.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_nei.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_nei.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_nei.Location = New System.Drawing.Point(104, 192)
        Me.Txt_nei.MaxLength = 0
        Me.Txt_nei.Multiline = True
        Me.Txt_nei.Name = "Txt_nei"
        Me.Txt_nei.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_nei.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_nei.Size = New System.Drawing.Size(641, 33)
        Me.Txt_nei.TabIndex = 37
        '
        'Txt_zas
        '
        Me.Txt_zas.AcceptsReturn = True
        Me.Txt_zas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_zas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_zas.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_zas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_zas.Location = New System.Drawing.Point(336, 168)
        Me.Txt_zas.MaxLength = 0
        Me.Txt_zas.Name = "Txt_zas"
        Me.Txt_zas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_zas.Size = New System.Drawing.Size(409, 19)
        Me.Txt_zas.TabIndex = 35
        '
        'Txt_divi
        '
        Me.Txt_divi.AcceptsReturn = True
        Me.Txt_divi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_divi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_divi.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_divi.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_divi.Location = New System.Drawing.Point(104, 168)
        Me.Txt_divi.MaxLength = 0
        Me.Txt_divi.Name = "Txt_divi"
        Me.Txt_divi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_divi.Size = New System.Drawing.Size(105, 19)
        Me.Txt_divi.TabIndex = 33
        '
        'Txt_aexp
        '
        Me.Txt_aexp.AcceptsReturn = True
        Me.Txt_aexp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_aexp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_aexp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_aexp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_aexp.Location = New System.Drawing.Point(584, 136)
        Me.Txt_aexp.MaxLength = 0
        Me.Txt_aexp.Name = "Txt_aexp"
        Me.Txt_aexp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_aexp.Size = New System.Drawing.Size(65, 19)
        Me.Txt_aexp.TabIndex = 31
        '
        'Txt_atrain
        '
        Me.Txt_atrain.AcceptsReturn = True
        Me.Txt_atrain.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_atrain.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_atrain.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_atrain.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_atrain.Location = New System.Drawing.Point(416, 136)
        Me.Txt_atrain.MaxLength = 0
        Me.Txt_atrain.Name = "Txt_atrain"
        Me.Txt_atrain.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_atrain.Size = New System.Drawing.Size(65, 19)
        Me.Txt_atrain.TabIndex = 29
        '
        'Txt_asize
        '
        Me.Txt_asize.AcceptsReturn = True
        Me.Txt_asize.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_asize.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_asize.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_asize.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_asize.Location = New System.Drawing.Point(224, 136)
        Me.Txt_asize.MaxLength = 0
        Me.Txt_asize.Name = "Txt_asize"
        Me.Txt_asize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_asize.Size = New System.Drawing.Size(113, 19)
        Me.Txt_asize.TabIndex = 27
        '
        'Txt_rich
        '
        Me.Txt_rich.AcceptsReturn = True
        Me.Txt_rich.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_rich.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_rich.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_rich.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_rich.Location = New System.Drawing.Point(648, 112)
        Me.Txt_rich.MaxLength = 0
        Me.Txt_rich.Name = "Txt_rich"
        Me.Txt_rich.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_rich.Size = New System.Drawing.Size(65, 19)
        Me.Txt_rich.TabIndex = 25
        '
        'Txt_hap
        '
        Me.Txt_hap.AcceptsReturn = True
        Me.Txt_hap.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_hap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_hap.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_hap.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_hap.Location = New System.Drawing.Point(488, 112)
        Me.Txt_hap.MaxLength = 0
        Me.Txt_hap.Name = "Txt_hap"
        Me.Txt_hap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_hap.Size = New System.Drawing.Size(65, 19)
        Me.Txt_hap.TabIndex = 23
        '
        'Txt_maglev
        '
        Me.Txt_maglev.AcceptsReturn = True
        Me.Txt_maglev.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_maglev.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_maglev.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_maglev.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_maglev.Location = New System.Drawing.Point(312, 112)
        Me.Txt_maglev.MaxLength = 0
        Me.Txt_maglev.Name = "Txt_maglev"
        Me.Txt_maglev.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_maglev.Size = New System.Drawing.Size(65, 19)
        Me.Txt_maglev.TabIndex = 21
        '
        'Txt_lord
        '
        Me.Txt_lord.AcceptsReturn = True
        Me.Txt_lord.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_lord.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_lord.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_lord.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_lord.Location = New System.Drawing.Point(120, 112)
        Me.Txt_lord.MaxLength = 0
        Me.Txt_lord.Name = "Txt_lord"
        Me.Txt_lord.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_lord.Size = New System.Drawing.Size(65, 19)
        Me.Txt_lord.TabIndex = 19
        '
        'Txt_par
        '
        Me.Txt_par.AcceptsReturn = True
        Me.Txt_par.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_par.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_par.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_par.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_par.Location = New System.Drawing.Point(616, 80)
        Me.Txt_par.MaxLength = 0
        Me.Txt_par.Name = "Txt_par"
        Me.Txt_par.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_par.Size = New System.Drawing.Size(129, 19)
        Me.Txt_par.TabIndex = 17
        '
        'Txt_child
        '
        Me.Txt_child.AcceptsReturn = True
        Me.Txt_child.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_child.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_child.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_child.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_child.Location = New System.Drawing.Point(616, 56)
        Me.Txt_child.MaxLength = 0
        Me.Txt_child.Name = "Txt_child"
        Me.Txt_child.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_child.Size = New System.Drawing.Size(129, 19)
        Me.Txt_child.TabIndex = 15
        '
        'Txt_ruler
        '
        Me.Txt_ruler.AcceptsReturn = True
        Me.Txt_ruler.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_ruler.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ruler.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ruler.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_ruler.Location = New System.Drawing.Point(616, 32)
        Me.Txt_ruler.MaxLength = 0
        Me.Txt_ruler.Name = "Txt_ruler"
        Me.Txt_ruler.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_ruler.Size = New System.Drawing.Size(129, 19)
        Me.Txt_ruler.TabIndex = 13
        '
        'Txt_ccount
        '
        Me.Txt_ccount.AcceptsReturn = True
        Me.Txt_ccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_ccount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ccount.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ccount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_ccount.Location = New System.Drawing.Point(136, 80)
        Me.Txt_ccount.MaxLength = 0
        Me.Txt_ccount.Name = "Txt_ccount"
        Me.Txt_ccount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_ccount.Size = New System.Drawing.Size(129, 19)
        Me.Txt_ccount.TabIndex = 11
        '
        'Txt_gov
        '
        Me.Txt_gov.AcceptsReturn = True
        Me.Txt_gov.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_gov.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_gov.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_gov.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_gov.Location = New System.Drawing.Point(136, 56)
        Me.Txt_gov.MaxLength = 0
        Me.Txt_gov.Name = "Txt_gov"
        Me.Txt_gov.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_gov.Size = New System.Drawing.Size(129, 19)
        Me.Txt_gov.TabIndex = 9
        '
        'Txt_hlm
        '
        Me.Txt_hlm.AcceptsReturn = True
        Me.Txt_hlm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_hlm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_hlm.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_hlm.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_hlm.Location = New System.Drawing.Point(136, 32)
        Me.Txt_hlm.MaxLength = 0
        Me.Txt_hlm.Name = "Txt_hlm"
        Me.Txt_hlm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_hlm.Size = New System.Drawing.Size(129, 19)
        Me.Txt_hlm.TabIndex = 7
        '
        'Txt_kont
        '
        Me.Txt_kont.AcceptsReturn = True
        Me.Txt_kont.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_kont.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_kont.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_kont.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_kont.Location = New System.Drawing.Point(616, 8)
        Me.Txt_kont.MaxLength = 0
        Me.Txt_kont.Name = "Txt_kont"
        Me.Txt_kont.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_kont.Size = New System.Drawing.Size(129, 19)
        Me.Txt_kont.TabIndex = 5
        '
        'Txt_name
        '
        Me.Txt_name.AcceptsReturn = True
        Me.Txt_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_name.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_name.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_name.Location = New System.Drawing.Point(240, 8)
        Me.Txt_name.MaxLength = 0
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_name.Size = New System.Drawing.Size(241, 19)
        Me.Txt_name.TabIndex = 3
        '
        'Txt_N
        '
        Me.Txt_N.AcceptsReturn = True
        Me.Txt_N.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_N.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_N.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_N.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_N.Location = New System.Drawing.Point(72, 8)
        Me.Txt_N.MaxLength = 0
        Me.Txt_N.Name = "Txt_N"
        Me.Txt_N.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_N.Size = New System.Drawing.Size(57, 19)
        Me.Txt_N.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(24, 480)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(73, 17)
        Me.Label25.TabIndex = 60
        Me.Label25.Text = "Vyhledat"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(8, 328)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(73, 17)
        Me.Label24.TabIndex = 46
        Me.Label24.Text = "Poznámky"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(8, 272)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(57, 17)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Export"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(360, 240)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(73, 17)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Strana"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(200, 240)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(81, 17)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Důležitost"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(8, 240)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(49, 17)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Jazyk"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(8, 192)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(81, 17)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Sousedé"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(224, 168)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(105, 17)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Zastoupení ras"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(8, 168)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(81, 17)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Rozdělení"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(496, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(73, 17)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Zkušenost"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(352, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(73, 17)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Tréning"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(96, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(129, 17)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Velikost armády"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(568, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(73, 17)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Bohatství"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(392, 112)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(89, 17)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Spokojenost"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(200, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(105, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Úroveň magie"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(48, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(65, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Lordů"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(504, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(105, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Partner"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(504, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(105, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Děti"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(504, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(105, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Vládce"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(121, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Počet obyvatel"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(121, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Typ vlády"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(121, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Hlavní město"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(504, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Kontinent"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(160, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Jméno"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Číslo"
        '
        'Bt_List
        '
        Me.Bt_List.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Bt_List.Image = CType(resources.GetObject("Bt_List.Image"), System.Drawing.Image)
        Me.Bt_List.Location = New System.Drawing.Point(512, 352)
        Me.Bt_List.Name = "Bt_List"
        Me.Bt_List.Size = New System.Drawing.Size(80, 56)
        Me.Bt_List.TabIndex = 66
        Me.Bt_List.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Frm_Nations
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(751, 519)
        Me.Controls.Add(Me.Bt_List)
        Me.Controls.Add(Me.Lst_nei)
        Me.Controls.Add(Me.Cmd_Snei)
        Me.Controls.Add(Me.Cmd_Slan)
        Me.Controls.Add(Me.Cmd_Srul)
        Me.Controls.Add(Me.Cmd_Shlm)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.Cmd_Ins)
        Me.Controls.Add(Me.Cmd_Del)
        Me.Controls.Add(Me.Cmd_Find)
        Me.Controls.Add(Me.Cmd_New)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Cmd_Order)
        Me.Controls.Add(Me.Cmd_First)
        Me.Controls.Add(Me.Cmd_Back)
        Me.Controls.Add(Me.Cmd_Forward)
        Me.Controls.Add(Me.Cmd_Last)
        Me.Controls.Add(Me.Txt_Num)
        Me.Controls.Add(Me.Txt_poz)
        Me.Controls.Add(Me.Txt_exp)
        Me.Controls.Add(Me.Txt_side)
        Me.Controls.Add(Me.Txt_imp)
        Me.Controls.Add(Me.Txt_lan)
        Me.Controls.Add(Me.Txt_nei)
        Me.Controls.Add(Me.Txt_zas)
        Me.Controls.Add(Me.Txt_divi)
        Me.Controls.Add(Me.Txt_aexp)
        Me.Controls.Add(Me.Txt_atrain)
        Me.Controls.Add(Me.Txt_asize)
        Me.Controls.Add(Me.Txt_rich)
        Me.Controls.Add(Me.Txt_hap)
        Me.Controls.Add(Me.Txt_maglev)
        Me.Controls.Add(Me.Txt_lord)
        Me.Controls.Add(Me.Txt_par)
        Me.Controls.Add(Me.Txt_child)
        Me.Controls.Add(Me.Txt_ruler)
        Me.Controls.Add(Me.Txt_ccount)
        Me.Controls.Add(Me.Txt_gov)
        Me.Controls.Add(Me.Txt_hlm)
        Me.Controls.Add(Me.Txt_kont)
        Me.Controls.Add(Me.Txt_name)
        Me.Controls.Add(Me.Txt_N)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
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
        Me.Name = "Frm_Nations"
        Me.Opacity = 0.9
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC AVATAR - Odria Nations"
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Frm_Nations
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Frm_Nations
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Frm_Nations()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As Frm_Nations)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region
    Private Sub Frm_NAsez_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles my_sez.Closed
        If Tnar <> "" Then
            NAposition = 0
            Do Until NArec.Tables("na").Rows(NAposition)("ID") = Tnar
                NAposition += 1
            Loop
            FillForm()
            Me.Refresh()
        End If
    End Sub

    Private Sub Cmd_Back_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Back.Click
        NAposition -= 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_First_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_First.Click
        NAposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Forward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Forward.Click
        NAposition += 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Last_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Last.Click
        NAposition = NAcount - 1
        Call FillForm()
    End Sub

    Private Sub Cmd_New_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_New.Click
        Txt_N.Text = ""
        Txt_name.Text = ""
        Txt_kont.Text = ""
        Txt_hlm.Text = ""
        Txt_gov.Text = ""
        Txt_ccount.Text = ""
        Txt_ruler.Text = ""
        Txt_child.Text = ""
        Txt_par.Text = ""
        Txt_lord.Text = ""
        Txt_maglev.Text = ""
        Txt_hap.Text = ""
        Txt_rich.Text = ""
        Txt_asize.Text = ""
        Txt_atrain.Text = ""
        Txt_aexp.Text = ""
        Txt_divi.Text = ""
        Txt_zas.Text = ""
        Txt_nei.Text = ""
        Txt_lan.Text = ""
        Txt_imp.Text = ""
        Txt_side.Text = ""
        Txt_exp.Text = ""
        Txt_poz.Text = ""
        Cmd_Print.Enabled = False
        Cmd_Del.Enabled = False
        Txt_Num.Text = "NEW"
    End Sub

    Private Sub Cmd_Shlm_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Shlm.Click
        If Txt_hlm.Text <> "" Then
            If SI Then
                FSi.Txt_site.Text = Txt_hlm.Text
                Call SISearch()
                FSi.Show()
            Else
                FSi = New Frm_Sites
                FSi.Show()
                Do
                    System.Windows.Forms.Application.DoEvents()
                Loop Until SI
                FSi.Txt_site.Text = Txt_hlm.Text
                Call SISearch()
                FSi.Show()
            End If
        End If
    End Sub

    Private Sub Cmd_Slan_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Slan.Click
        If Txt_lan.Text <> "" Then
            If LA Then
                FLa.Txt_language.Text = Txt_lan.Text
                Call LASearch()
                FLa.Show()
            Else
                FLa = New Frm_Languages
                FLa.Show()
                Do
                    System.Windows.Forms.Application.DoEvents()
                Loop Until LA
                FLa.Txt_language.Text = Txt_lan.Text
                Call LASearch()
                FLa.Show()
            End If
        End If
    End Sub

    Private Sub Cmd_Snei_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Snei.Click
        Dim x As Long
        Dim y As Short
        Dim pomstr As String
        Dim pomchar As String
        x = Len(Txt_nei.Text)
        y = 1
        Lst_nei.Items.Clear()
        Do While y < x
            pomchar = Mid(Txt_nei.Text, y, 1)
            If pomchar <> " " Then
                If pomchar = "," Then
                    Lst_nei.Items.Add((pomstr))
                    pomstr = ""
                Else
                    pomstr = pomstr & pomchar
                End If
            Else
                If Len(pomstr) > 1 Then
                    pomstr = pomstr & pomchar
                End If
            End If
            y = y + 1
        Loop
        If x > 1 Then
            pomstr = pomstr & Mid(Txt_nei.Text, x, 1)
            Lst_nei.Items.Add((pomstr))
        End If
        Lst_nei.Visible = True
        Lst_nei.Focus()
        Frm_Nations.DefInstance.Refresh()

    End Sub

    Private Sub Cmd_Srul_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Srul.Click
        If Txt_ruler.Text <> "" Then
            If PE Then
                FPer.Txt_name.Text = Txt_ruler.Text
                Call PESearch()
                FPer.Show()
            Else
                FPer = New Frm_Personel
                FPer.Show()
                Do
                    System.Windows.Forms.Application.DoEvents()
                Loop Until PE
                FPer.Txt_name.Text = Txt_ruler.Text
                Call PESearch()
                FPer.Show()
            End If
        End If
    End Sub

    Private Sub Frm_Nations_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call NArecopen()
        NAposition = 0
        ApplyColor()
        Call FillForm()
        NA = True
    End Sub


    Private Sub NArecopen()
        Dim ssc As New OleDbCommand
        ssc.Connection = Odrialink2
        Select Case NAorder
            Case Is = 1
                If NAdirect = 1 Then
                    ssc.CommandText = "select * from Nations order by Kontinent, Číslo"
                Else
                    ssc.CommandText = "select * from Nations order by Kontinent, Číslo desc"
                End If
            Case Is = 2
                If NAdirect = 1 Then
                    ssc.CommandText = "select * from Nations order by Jméno"
                Else
                    ssc.CommandText = "select * from Nations order by Jméno desc"
                End If
            Case Is = 3
                If NAdirect = 1 Then
                    ssc.CommandText = "select * from Nations order by Importance"
                Else
                    ssc.CommandText = "select * from Nations order by Importance desc"
                End If
        End Select
        NAdat.SelectCommand = ssc
        NArec.Clear()
        NAdat.Fill(NArec, "na")
        NAcount = NArec.Tables("na").Rows.Count
    End Sub


    Sub FillForm()


        Txt_N.Text = NArec.Tables("na").Rows(NAposition)("Číslo")
        Txt_kont.Text = NArec.Tables("na").Rows(NAposition)("Kontinent")
        Txt_name.Text = NArec.Tables("na").Rows(NAposition)("Jméno")
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Hlměsto")) Then
            Txt_hlm.Text = NArec.Tables("na").Rows(NAposition)("Hlměsto")
        Else
            Txt_hlm.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Vláda")) Then
            Txt_gov.Text = NArec.Tables("na").Rows(NAposition)("Vláda")
        Else
            Txt_gov.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Pocobyvatel")) Then
            Txt_ccount.Text = CStr(CDec(NArec.Tables("na").Rows(NAposition)("Pocobyvatel")))
        Else
            Txt_ccount.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Vládce")) Then
            Txt_ruler.Text = NArec.Tables("na").Rows(NAposition)("Vládce")
        Else
            Txt_ruler.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Děti")) Then
            Txt_child.Text = NArec.Tables("na").Rows(NAposition)("Děti")
        Else
            Txt_child.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Partner")) Then
            Txt_par.Text = NArec.Tables("na").Rows(NAposition)("Partner")
        Else
            Txt_par.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Lords")) Then
            Txt_lord.Text = NArec.Tables("na").Rows(NAposition)("Lords")
        Else
            Txt_lord.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Maglevel")) Then
            Txt_maglev.Text = NArec.Tables("na").Rows(NAposition)("Maglevel")
        Else
            Txt_maglev.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Happy")) Then
            Txt_hap.Text = NArec.Tables("na").Rows(NAposition)("Happy")
        Else
            Txt_hap.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Rich")) Then
            Txt_rich.Text = NArec.Tables("na").Rows(NAposition)("Rich")
        Else
            Txt_rich.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Army")) Then
            Txt_asize.Text = NArec.Tables("na").Rows(NAposition)("Army")
        Else
            Txt_asize.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Trainingix")) Then
            Txt_atrain.Text = NArec.Tables("na").Rows(NAposition)("Trainingix")
        Else
            Txt_atrain.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Experienceix")) Then
            Txt_aexp.Text = NArec.Tables("na").Rows(NAposition)("Experienceix")
        Else
            Txt_aexp.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Rozdělení")) Then
            Txt_divi.Text = NArec.Tables("na").Rows(NAposition)("Rozdělení")
        Else
            Txt_divi.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Zastoupení")) Then
            Txt_zas.Text = NArec.Tables("na").Rows(NAposition)("Zastoupení")
        Else
            Txt_zas.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Sousedé")) Then
            Txt_nei.Text = NArec.Tables("na").Rows(NAposition)("Sousedé")
        Else
            Txt_nei.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Languag")) Then
            Txt_lan.Text = NArec.Tables("na").Rows(NAposition)("Languag")
        Else
            Txt_lan.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Importance")) Then
            Txt_imp.Text = NArec.Tables("na").Rows(NAposition)("Importance")
        Else
            Txt_imp.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Side")) Then
            Txt_side.Text = NArec.Tables("na").Rows(NAposition)("Side")
        Else
            Txt_side.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Export")) Then
            Txt_exp.Text = NArec.Tables("na").Rows(NAposition)("Export")
        Else
            Txt_exp.Text = ""
        End If
        If Not IsDBNull(NArec.Tables("na").Rows(NAposition)("Poznámky")) Then
            Txt_poz.Text = NArec.Tables("na").Rows(NAposition)("Poznámky")
        Else
            Txt_poz.Text = ""
        End If
        If NAposition = 0 Then
            Cmd_Back.Enabled = False
        Else
            Cmd_Back.Enabled = True
        End If
        Cmd_Del.Enabled = True
        Cmd_Find.Enabled = True
        If NAposition + 1 = NAcount Then
            Cmd_Forward.Enabled = False
        Else
            Cmd_Forward.Enabled = True
        End If
        Cmd_Ins.Enabled = True
        Cmd_New.Enabled = True
        Cmd_Print.Enabled = True
        Lst_nei.Visible = False

        Txt_Num.Text = (NAposition + 1) & "/" & NAcount

    End Sub


    Private Sub Frm_Nations_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        NA = False
        NArec.Clear()
    End Sub

    Private Sub Lst_nei_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Lst_nei.SelectedIndexChanged
        Dim nu As Boolean
        nu = False
        NAposition = 0
        Do
            If CStr(Lst_nei.Text) = NArec.Tables("na").Rows(NAposition)("Jméno") Then
                nu = True
                Exit Do
            End If
            NAposition += 1
        Loop Until NAposition + 1 = NAcount
        If nu = False Then
            NArecopen()
            NAposition = 0
            Do
                If CStr(Lst_nei.Text) = NArec.Tables("na").Rows(NAposition)("Jméno") Then
                    Exit Do
                End If
                NAposition += 1
            Loop Until NAposition + 1 = NAcount
        End If
        Call FillForm()
    End Sub

    Private Sub Lst_nei_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Lst_nei.Leave
        Lst_nei.Visible = False
        Frm_Nations.DefInstance.Refresh()
    End Sub

    Private Sub Txt_Num_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Num.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Not IsNumeric(Txt_Num.Text) Then
                MsgBox("Tady musí být číslo!", MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            If CShort(Txt_Num.Text) > NAcount Or CShort(Txt_Num.Text) < 1 Then
                MsgBox("Číslo musí být v rozsahu 1 - počet záznamů!", MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            KeyAscii = 0
            NAposition = CShort(Txt_Num.Text) - 1
            Call FillForm()
        End If
EventExitSub:
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Cmd_Print_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Print.Click
        Dim NArint As New NAPrint
        NArint.Show()
    End Sub

    Private Sub Cmd_Order_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Order.Click
        OrderControl = "NA"
        FO = New Frm_Ordering
        FO.ShowDialog()
        FO = Nothing
        NArec.Clear()
        Call NArecopen()
        NAposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Ins_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Ins.Click
        If Txt_name.Text = "" Then
            MsgBox("Země musí mít jméno!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        If Txt_N.Text = "" Then
            MsgBox("Země musí mít číslo!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        If Txt_kont.Text = "" Then
            MsgBox("Země musí ležet na kontinentu anebo ostrově!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        Dim tsc As New OleDbCommand
        Dim treader As OleDbDataReader
        Try
            tsc.Connection = Odrialink2
            tsc.CommandText = "select * from Nations where Jméno = @on"
            tsc.Parameters.AddWithValue("@on", Txt_name.Text)
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
                s1 = "INSERT INTO Nations (Jméno"
                s2 = " VALUES (@Orig_name"
                ic.Parameters.AddWithValue("@Orig_name", Trim(Txt_name.Text))
                ic.Parameters.AddWithValue("@ci", Txt_N.Text)
                s1 = s1 & ", Číslo"
                s2 = s2 & ", @ci"
                ic.Parameters.AddWithValue("@ko", Txt_kont.Text)
                s1 = s1 & ", Kontinent"
                s2 = s2 & ", @ko"
                If Txt_hlm.Text <> "" Then
                    ic.Parameters.AddWithValue("@rp", Txt_hlm.Text)
                    s1 = s1 & ", Hlměsto"
                    s2 = s2 & ", @rp"
                End If
                If Txt_ccount.Text <> "" Then
                    ic.Parameters.AddWithValue("@rs", Txt_ccount.Text)
                    s1 = s1 & ", Pocobyvatel"
                    s2 = s2 & ", @rs"
                End If
                If Txt_gov.Text <> "" Then
                    ic.Parameters.AddWithValue("@rh", Txt_gov.Text)
                    s1 = s1 & ", Vláda"
                    s2 = s2 & ", @rh"
                End If
                If Txt_ruler.Text <> "" Then
                    ic.Parameters.AddWithValue("@rz", Txt_ruler.Text)
                    s1 = s1 & ", Vládce"
                    s2 = s2 & ", @rz"
                End If
                If Txt_child.Text <> "" Then
                    ic.Parameters.AddWithValue("@rf", Txt_child.Text)
                    s1 = s1 & ", Děti"
                    s2 = s2 & ", @rf"
                End If
                If Txt_par.Text <> "" Then
                    ic.Parameters.AddWithValue("@ro", Txt_par.Text)
                    s1 = s1 & ", Partner"
                    s2 = s2 & ", @ro"
                End If
                If Txt_lord.Text <> "" Then
                    ic.Parameters.AddWithValue("@ri", Txt_lord.Text)
                    s1 = s1 & ", Lords"
                    s2 = s2 & ", @ri"
                End If
                If Txt_maglev.Text <> "" Then
                    ic.Parameters.AddWithValue("@rw", Txt_maglev.Text)
                    s1 = s1 & ", Maglevel"
                    s2 = s2 & ", @rw"
                End If
                If Txt_hap.Text <> "" Then
                    ic.Parameters.AddWithValue("@rj", Txt_hap.Text)
                    s1 = s1 & ", Happy"
                    s2 = s2 & ", @rj"
                End If
                If Txt_rich.Text <> "" Then
                    ic.Parameters.AddWithValue("@rk", Txt_rich.Text)
                    s1 = s1 & ", Rich"
                    s2 = s2 & ", @rk"
                End If
                If Txt_asize.Text <> "" Then
                    ic.Parameters.AddWithValue("@rt", Txt_asize.Text)
                    s1 = s1 & ", Army"
                    s2 = s2 & ", @rt"
                End If
                If Txt_atrain.Text <> "" Then
                    ic.Parameters.AddWithValue("@ru", Txt_atrain.Text)
                    s1 = s1 & ", Trainingix"
                    s2 = s2 & ", @ru"
                End If
                If Txt_aexp.Text <> "" Then
                    ic.Parameters.AddWithValue("@dc", Txt_aexp.Text)
                    s1 = s1 & ", Experienceix"
                    s2 = s2 & ", @dc"
                End If
                If Txt_divi.Text <> "" Then
                    ic.Parameters.AddWithValue("@ha", Txt_divi.Text)
                    s1 = s1 & ", Rozdělení"
                    s2 = s2 & ", @ha"
                End If
                If Txt_zas.Text <> "" Then
                    ic.Parameters.AddWithValue("@co", Txt_zas.Text)
                    s1 = s1 & ", Zastoupení"
                    s2 = s2 & ", @co"
                End If
                If Txt_nei.Text <> "" Then
                    ic.Parameters.AddWithValue("@rl", Txt_nei.Text)
                    s1 = s1 & ", Sousedé"
                    s2 = s2 & ", @rl"
                End If
                If Txt_lan.Text <> "" Then
                    ic.Parameters.AddWithValue("@rr", Txt_lan.Text)
                    s1 = s1 & ", Languag"
                    s2 = s2 & ", @rr"
                End If
                If Txt_imp.Text <> "" Then
                    ic.Parameters.AddWithValue("@rx", Txt_imp.Text)
                    s1 = s1 & ", Importance"
                    s2 = s2 & ", @rx"
                End If
                If Txt_side.Text <> "" Then
                    ic.Parameters.AddWithValue("@ry", Txt_side.Text)
                    s1 = s1 & ", Side"
                    s2 = s2 & ", @ry"
                End If
                If Txt_exp.Text <> "" Then
                    ic.Parameters.AddWithValue("@xo", Txt_exp.Text)
                    s1 = s1 & ", Export"
                    s2 = s2 & ", @xo"
                End If
                If Txt_poz.Text <> "" Then
                    ic.Parameters.AddWithValue("@xa", Txt_poz.Text)
                    s1 = s1 & ", Poznámky"
                    s2 = s2 & ", @xa"
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
            NArec.Clear()
            NAdat.Fill(NArec, "na")
            NAcount = NArec.Tables("na").Rows.Count
            Call FillForm()
        Else
            treader.Close()
            If MsgBox("Země tohoto jména již v databázi existuje, chcete jí přepsat?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Upozornění") = MsgBoxResult.Yes Then
                Try
                    Dim s3 As String
                    Dim uc As New OleDbCommand
                    s3 = "UPDATE Nations set Jméno = @Orig_name, Číslo = @Ci, Kontinent = @ko, Hlměsto = @hm, Pocobyvatel = @po, Vláda = @go, Vládce = @ru, Děti = @ch, Partner = @pa, Zastoupení = @za, Rozdělení = @di, Sousedé = @ne, Lords = @lo, Happy = @ha, Maglevel = @ml,  Rich = @ri, Army = @as, Trainingix = @at, Experienceix = @ae, Languag = @la, Export = @ex, Poznámky = @po, Importance = @im, Side = @si WHERE ID = @ID"
                    uc.Parameters.AddWithValue("@Orig_name", Trim(Txt_name.Text))
                    uc.Parameters.AddWithValue("@Ci", Trim(Txt_N.Text))
                    uc.Parameters.AddWithValue("@ko", Trim(Txt_kont.Text))
                    If Txt_hlm.Text = "" Then
                        uc.Parameters.AddWithValue("@hm", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@hm", Txt_hlm.Text)
                    End If
                    If Txt_ccount.Text = "" Then
                        uc.Parameters.AddWithValue("@po", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@po", Txt_ccount.Text)
                    End If
                    If Txt_gov.Text = "" Then
                        uc.Parameters.AddWithValue("@go", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@go", Txt_gov.Text)
                    End If
                    If Txt_ruler.Text = "" Then
                        uc.Parameters.AddWithValue("@ru", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@ru", Txt_ruler.Text)
                    End If
                    If Txt_child.Text = "" Then
                        uc.Parameters.AddWithValue("@ch", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@ch", Txt_child.Text)
                    End If
                    If Txt_par.Text = "" Then
                        uc.Parameters.AddWithValue("@pa", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@pa", Txt_par.Text)
                    End If
                    If Txt_zas.Text = "" Then
                        uc.Parameters.AddWithValue("@za", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@za", Txt_zas.Text)
                    End If
                    If Txt_divi.Text = "" Then
                        uc.Parameters.AddWithValue("@di", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@di", Txt_divi.Text)
                    End If
                    If Txt_nei.Text = "" Then
                        uc.Parameters.AddWithValue("@ne", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@ne", Txt_nei.Text)
                    End If
                    If Txt_lord.Text = "" Then
                        uc.Parameters.AddWithValue("@lo", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@lo", Txt_lord.Text)
                    End If
                    If Txt_hap.Text = "" Then
                        uc.Parameters.AddWithValue("@ha", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@ha", Txt_hap.Text)
                    End If
                    If Txt_maglev.Text = "" Then
                        uc.Parameters.AddWithValue("@ml", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@ml", Txt_maglev.Text)
                    End If
                    If Txt_rich.Text = "" Then
                        uc.Parameters.AddWithValue("@ri", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@ri", Txt_rich.Text)
                    End If
                    If Txt_asize.Text = "" Then
                        uc.Parameters.AddWithValue("@as", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@as", Txt_asize.Text)
                    End If
                    If Txt_atrain.Text = "" Then
                        uc.Parameters.AddWithValue("@at", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@at", Txt_atrain.Text)
                    End If
                    If Txt_aexp.Text = "" Then
                        uc.Parameters.AddWithValue("@ae", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@ae", Txt_aexp.Text)
                    End If
                    If Txt_lan.Text = "" Then
                        uc.Parameters.AddWithValue("@la", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@la", Txt_lan.Text)
                    End If
                    If Txt_exp.Text = "" Then
                        uc.Parameters.AddWithValue("@ex", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@ex", Txt_exp.Text)
                    End If
                    If Txt_poz.Text = "" Then
                        uc.Parameters.AddWithValue("@po", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@po", Txt_poz.Text)
                    End If
                    If Txt_imp.Text = "" Then
                        uc.Parameters.AddWithValue("@im", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@im", Txt_imp.Text)
                    End If
                    If Txt_side.Text = "" Then
                        uc.Parameters.AddWithValue("@si", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@si", Txt_side.Text)
                    End If
                    uc.Parameters.AddWithValue("@ID", NArec.Tables("na").Rows(NAposition)("ID"))
                    uc.Connection = Odrialink2
                    uc.CommandText = s3
                    uc.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Chyba updatu případu: " + ex.Message, , "Pokus o update")
                    Exit Sub
                End Try
                NArec.Clear()
                NAdat.Fill(NArec, "na")
                Call FillForm()
            Else
                Exit Sub
            End If
        End If

    End Sub

    Private Sub Cmd_Find_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Find.Click
        Dim SPse As New OleDbCommand
        Dim SPre As OleDbDataReader
        Dim s As String
        Dim q1 As Long
        Dim na, cz, ma, vy, dos, ro, za, sc, nc, ti, fa, po, aa, ab, ac, ad, ae, af, ag, ah, ai, aj, ak, al As Boolean
        SPse.Connection = Odrialink2
        s = "SELECT * from Nations WHERE "
        If Txt_name.Text <> "" Then
            s = s & "Jméno LIKE @Orig_name"
            SPse.Parameters.AddWithValue("@Orig_name", "%" & Trim(Txt_name.Text) & "%")
            na = True
        End If
        If Txt_kont.Text <> "" Then
            If na Then
                s = s & " AND "
            End If
            s = s & "Kontinent LIKE @Czech_name"
            SPse.Parameters.AddWithValue("@Czech_name", "%" & Trim(Txt_kont.Text) & "%")
            cz = True
        End If
        If Txt_N.Text <> "" Then
            If na Or cz Then
                s = s & " AND "
            End If
            s = s & "Číslo = @Magenergy"
            SPse.Parameters.AddWithValue("@Magenergy", Trim(Txt_N.Text))
            ma = True
        End If
        If Txt_hlm.Text <> "" Then
            If na Or cz Or ma Then
                s = s & " AND "
            End If
            s = s & "Hlměsto LIKE @Cast_rounds"
            SPse.Parameters.AddWithValue("@Cast_rounds", "%" & Trim(Txt_hlm.Text) & "%")
            vy = True
        End If
        If Txt_gov.Text <> "" Then
            If na Or cz Or ma Or vy Then
                s = s & " AND "
            End If
            s = s & "Vláda LIKE @Reach"
            SPse.Parameters.AddWithValue("@Reach", "%" & Trim(Txt_gov.Text) & "%")
            dos = True
        End If
        If Txt_ruler.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Then
                s = s & " AND "
            End If
            s = s & "Vládce LIKE @Affect"
            SPse.Parameters.AddWithValue("@Affect", "%" & Trim(Txt_ruler.Text) & "%")
            ro = True
        End If
        If Txt_child.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Then
                s = s & " AND "
            End If
            s = s & "Děti LIKE @Spell_type"
            SPse.Parameters.AddWithValue("@Spell_type", "%" & Trim(Txt_child.Text) & "%")
            za = True
        End If
        If Txt_par.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Then
                s = s & " AND "
            End If
            s = s & "Partner LIKE @Spelling_cast"
            SPse.Parameters.AddWithValue("@Spelling_cast", "%" & Trim(Txt_par.Text) & "%")
            sc = True
        End If
        If Txt_ccount.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Then
                s = s & " AND "
            End If
            s = s & "Pocobyvatel = @Difficulty"
            SPse.Parameters.AddWithValue("@Difficulty", Trim(Txt_ccount.Text))
            nc = True
        End If
        If Txt_lord.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Then
                s = s & " AND "
            End If
            s = s & "Lords = @Cast_time"
            SPse.Parameters.AddWithValue("@Cast_time", Trim(Txt_lord.Text))
            ti = True
        End If
        If Txt_maglev.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Then
                s = s & " AND "
            End If
            s = s & "Maglevel = @Fatigue"
            SPse.Parameters.AddWithValue("@Fatigue", Trim(Txt_maglev.Text))
            fa = True
        End If
        If Txt_hap.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Then
                s = s & " AND "
            End If
            s = s & "Happy = @Texto"
            SPse.Parameters.AddWithValue("@Texto", Trim(Txt_hap.Text))
            po = True
        End If
        If Txt_rich.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Then
                s = s & " AND "
            End If
            s = s & "Rich = @aa"
            SPse.Parameters.AddWithValue("@aa", Trim(Txt_rich.Text))
            aa = True
        End If
        If Txt_asize.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Then
                s = s & " AND "
            End If
            s = s & "Army = @ab"
            SPse.Parameters.AddWithValue("@ab", Trim(Txt_asize.Text))
            ab = True
        End If
        If Txt_atrain.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Then
                s = s & " AND "
            End If
            s = s & "Trainingix = @ac"
            SPse.Parameters.AddWithValue("@ac", Trim(Txt_atrain.Text))
            ac = True
        End If
        If Txt_aexp.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Then
                s = s & " AND "
            End If
            s = s & "Experienceix = @ad"
            SPse.Parameters.AddWithValue("@ad", Trim(Txt_aexp.Text))
            ad = True
        End If
        If Txt_divi.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Then
                s = s & " AND "
            End If
            s = s & "Rozdělení LIKE @ae"
            SPse.Parameters.AddWithValue("@ae", "%" & Trim(Txt_divi.Text) & "%")
            ae = True
        End If
        If Txt_zas.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Or ae Then
                s = s & " AND "
            End If
            s = s & "Zastoupení LIKE @af"
            SPse.Parameters.AddWithValue("@af", "%" & Trim(Txt_zas.Text) & "%")
            af = True
        End If
        If Txt_nei.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Or ae Or af Then
                s = s & " AND "
            End If
            s = s & "Sousedé LIKE @ag"
            SPse.Parameters.AddWithValue("@ag", "%" & Trim(Txt_nei.Text) & "%")
            ag = True
        End If
        If Txt_lan.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Or ae Or af Or ag Then
                s = s & " AND "
            End If
            s = s & "Languag    LIKE @ah"
            SPse.Parameters.AddWithValue("@ah", "%" & Trim(Txt_lan.Text) & "%")
            ah = True
        End If
        If Txt_imp.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Or ae Or af Or ag Or ah Then
                s = s & " AND "
            End If
            s = s & "Importance = @ai"
            SPse.Parameters.AddWithValue("@ai", Trim(Txt_imp.Text))
            ai = True
        End If
        If Txt_side.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Or ae Or af Or ag Or ah Or ai Then
                s = s & " AND "
            End If
            s = s & "Side LIKE @aj"
            SPse.Parameters.AddWithValue("@aj", "%" & Trim(Txt_side.Text) & "%")
            aj = True
        End If
        If Txt_exp.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Or ae Or af Or ag Or ah Or ai Or aj Then
                s = s & " AND "
            End If
            s = s & "Export LIKE @ak"
            SPse.Parameters.AddWithValue("@ak", "%" & Trim(Txt_exp.Text) & "%")
            ak = True
        End If
        If Txt_poz.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or aa Or ab Or ac Or ad Or ae Or af Or ag Or ah Or ai Or aj Or ak Then
                s = s & " AND "
            End If
            s = s & "Poznámky LIKE @al"
            SPse.Parameters.AddWithValue("@al", "%" & Trim(Txt_poz.Text) & "%")
            al = True
        End If
        NAposition = 0
        If s = "SELECT * from Nations WHERE " Then
            NArecopen()
            FillForm()
            Exit Sub
        End If
        Try
            SPse.CommandText = s
            SPre = SPse.ExecuteReader
            If SPre.HasRows Then
                q1 = 0
                While SPre.Read()
                    q1 += 1
                End While
                SPre.Close()
                NAdat.SelectCommand = SPse
                NArec.Clear()
                NAdat.Fill(NArec, "na")
                NAcount = NArec.Tables("na").Rows.Count
                If GC_list = 1 Then
                    If my_sez Is Nothing Then
                        my_sez = New Frm_NAsez
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
            Else
                SPre.Close()
                MsgBox("Žádný záznam neodpovídá zvoleným parametrům.", , "Nenalezeno")
                Exit Sub
            End If
            SPre.Close()
        Catch ex As Exception
            MsgBox("Chyba při čtení databáze." + ex.Message, , "Chyba")
            Exit Sub
        End Try

        Call FillForm()
    End Sub

    Private Sub Cmd_Del_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Del.Click
        Dim tsc As New OleDbCommand
        If MsgBox("Opravdu vymazat zemi " & Txt_name.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Upozornění") = MsgBoxResult.Yes Then
            Try
                tsc.Connection = Odrialink2
                tsc.CommandText = "DELETE from Nations WHERE ID = @ID"
                tsc.Parameters.AddWithValue("@ID", NArec.Tables("na").Rows(NAposition)("ID"))
                tsc.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception("Chyba při výmazu případu: " + ex.Message)
                Exit Sub
            End Try
        Else
            Exit Sub
        End If
        NArec.Clear()
        NAdat.Fill(NArec, "na")
        NAcount = NArec.Tables("na").Rows.Count
        If NAposition = NAcount Then
            NAposition -= 1
        End If
        Call FillForm()
    End Sub

    Private Sub Bt_List_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_List.Click
        If my_sez Is Nothing Then
            my_sez = New Frm_NAsez
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
        Me.BackColor = Color.FromArgb(FNB)
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
        Label1.ForeColor = Color.FromArgb(FNFO)
        Label2.ForeColor = Color.FromArgb(FNFO)
        Label3.ForeColor = Color.FromArgb(FNFO)
        Label4.ForeColor = Color.FromArgb(FNFO)
        Label5.ForeColor = Color.FromArgb(FNFO)
        Label6.ForeColor = Color.FromArgb(FNFO)
        Label7.ForeColor = Color.FromArgb(FNFO)
        Label8.ForeColor = Color.FromArgb(FNFO)
        Label9.ForeColor = Color.FromArgb(FNFO)
        Label10.ForeColor = Color.FromArgb(FNFO)
        Label11.ForeColor = Color.FromArgb(FNFO)
        Label12.ForeColor = Color.FromArgb(FNFO)
        Label13.ForeColor = Color.FromArgb(FNFO)
        Label14.ForeColor = Color.FromArgb(FNFO)
        Label15.ForeColor = Color.FromArgb(FNFO)
        Label16.ForeColor = Color.FromArgb(FNFO)
        Label17.ForeColor = Color.FromArgb(FNFO)
        Label18.ForeColor = Color.FromArgb(FNFO)
        Label19.ForeColor = Color.FromArgb(FNFO)
        Label20.ForeColor = Color.FromArgb(FNFO)
        Label21.ForeColor = Color.FromArgb(FNFO)
        Label22.ForeColor = Color.FromArgb(FNFO)
        Label23.ForeColor = Color.FromArgb(FNFO)
        Label24.ForeColor = Color.FromArgb(FNFO)
        Label25.ForeColor = Color.FromArgb(FNFO)
        Txt_Num.ForeColor = Color.FromArgb(FNFO)
        Txt_name.ForeColor = Color.FromArgb(FNFO)
        Txt_N.ForeColor = Color.FromArgb(FNFO)
        Txt_kont.ForeColor = Color.FromArgb(FNFO)
        Txt_hlm.ForeColor = Color.FromArgb(FNFO)
        Txt_gov.ForeColor = Color.FromArgb(FNFO)
        Txt_ccount.ForeColor = Color.FromArgb(FNFO)
        Txt_ruler.ForeColor = Color.FromArgb(FNFO)
        Txt_child.ForeColor = Color.FromArgb(FNFO)
        Txt_par.ForeColor = Color.FromArgb(FNFO)
        Txt_lord.ForeColor = Color.FromArgb(FNFO)
        Txt_maglev.ForeColor = Color.FromArgb(FNFO)
        Txt_hap.ForeColor = Color.FromArgb(FNFO)
        Txt_rich.ForeColor = Color.FromArgb(FNFO)
        Txt_asize.ForeColor = Color.FromArgb(FNFO)
        Txt_atrain.ForeColor = Color.FromArgb(FNFO)
        Txt_aexp.ForeColor = Color.FromArgb(FNFO)
        Txt_divi.ForeColor = Color.FromArgb(FNFO)
        Txt_zas.ForeColor = Color.FromArgb(FNFO)
        Txt_nei.ForeColor = Color.FromArgb(FNFO)
        Txt_lan.ForeColor = Color.FromArgb(FNFO)
        Txt_side.ForeColor = Color.FromArgb(FNFO)
        Txt_imp.ForeColor = Color.FromArgb(FNFO)
        Txt_exp.ForeColor = Color.FromArgb(FNFO)
        Txt_poz.ForeColor = Color.FromArgb(FNFO)
    End Sub
End Class