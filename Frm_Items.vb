Option Strict Off
Option Explicit On 
Imports System.Data.OleDb
Imports System.Drawing.Image
Imports System.Drawing.Bitmap
Imports System.Drawing.Imaging.Metafile
Imports System.IO
Imports System.Object
Imports System.MarshalByRefObject
Friend Class Frm_Items
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
	Public WithEvents Cmd_sr As System.Windows.Forms.Button
	Public WithEvents Cmd_sk As System.Windows.Forms.Button
	Public WithEvents Cmd_ss As System.Windows.Forms.Button
	Public WithEvents Cmd_dr As System.Windows.Forms.Button
	Public WithEvents Cmd_ar As System.Windows.Forms.Button
	Public WithEvents Cmd_dk As System.Windows.Forms.Button
	Public WithEvents Cmd_ak As System.Windows.Forms.Button
	Public WithEvents Cmd_ds As System.Windows.Forms.Button
	Public WithEvents Cmd_as As System.Windows.Forms.Button
	Public WithEvents CHck_pri As System.Windows.Forms.CheckBox
	Public WithEvents Txt_price As System.Windows.Forms.TextBox
	Public WithEvents Txt_rar As System.Windows.Forms.TextBox
	Public WithEvents Txt_spec As System.Windows.Forms.TextBox
	Public WithEvents Txt_tim As System.Windows.Forms.TextBox
	Public WithEvents Txt_sur As System.Windows.Forms.TextBox
	Public WithEvents Txt_mgv As System.Windows.Forms.TextBox
	Public WithEvents Txt_rem As System.Windows.Forms.TextBox
	Public WithEvents Lst_res As System.Windows.Forms.ListBox
	Public WithEvents Lst_skills As System.Windows.Forms.ListBox
	Public WithEvents Lst_spells As System.Windows.Forms.ListBox
	Public WithEvents Txt_eptyp As System.Windows.Forms.TextBox
	Public WithEvents Txt_ep As System.Windows.Forms.TextBox
	Public WithEvents Txt_mg As System.Windows.Forms.TextBox
	Public WithEvents Txt_pow As System.Windows.Forms.TextBox
	Public WithEvents Txt_pop As System.Windows.Forms.TextBox
	Public WithEvents Txt_typ As System.Windows.Forms.TextBox
	Public WithEvents Txt_name As System.Windows.Forms.TextBox
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
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Line1 As System.Windows.Forms.Label
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
    Public WithEvents Txt_alch As System.Windows.Forms.TextBox
    Public WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Bt_List As System.Windows.Forms.Button
    Friend WithEvents Pb_pic As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Items))
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
        Me.Cmd_sr = New System.Windows.Forms.Button
        Me.Cmd_sk = New System.Windows.Forms.Button
        Me.Cmd_ss = New System.Windows.Forms.Button
        Me.Cmd_dr = New System.Windows.Forms.Button
        Me.Cmd_ar = New System.Windows.Forms.Button
        Me.Cmd_dk = New System.Windows.Forms.Button
        Me.Cmd_ak = New System.Windows.Forms.Button
        Me.Cmd_ds = New System.Windows.Forms.Button
        Me.Cmd_as = New System.Windows.Forms.Button
        Me.CHck_pri = New System.Windows.Forms.CheckBox
        Me.Txt_price = New System.Windows.Forms.TextBox
        Me.Txt_rar = New System.Windows.Forms.TextBox
        Me.Txt_spec = New System.Windows.Forms.TextBox
        Me.Txt_tim = New System.Windows.Forms.TextBox
        Me.Txt_sur = New System.Windows.Forms.TextBox
        Me.Txt_mgv = New System.Windows.Forms.TextBox
        Me.Txt_rem = New System.Windows.Forms.TextBox
        Me.Lst_res = New System.Windows.Forms.ListBox
        Me.Lst_skills = New System.Windows.Forms.ListBox
        Me.Lst_spells = New System.Windows.Forms.ListBox
        Me.Txt_eptyp = New System.Windows.Forms.TextBox
        Me.Txt_ep = New System.Windows.Forms.TextBox
        Me.Txt_mg = New System.Windows.Forms.TextBox
        Me.Txt_pow = New System.Windows.Forms.TextBox
        Me.Txt_pop = New System.Windows.Forms.TextBox
        Me.Txt_typ = New System.Windows.Forms.TextBox
        Me.Txt_name = New System.Windows.Forms.TextBox
        Me.Txt_Num = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Line1 = New System.Windows.Forms.Label
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
        Me.Txt_alch = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Bt_List = New System.Windows.Forms.Button
        Me.Pb_pic = New System.Windows.Forms.PictureBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.Pb_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cmd_First
        '
        Me.Cmd_First.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmd_First.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_First.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_First.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_First.Image = CType(resources.GetObject("Cmd_First.Image"), System.Drawing.Image)
        Me.Cmd_First.Location = New System.Drawing.Point(783, 740)
        Me.Cmd_First.Name = "Cmd_First"
        Me.Cmd_First.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_First.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_First.TabIndex = 11
        Me.Cmd_First.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_First, "Na začátek")
        Me.Cmd_First.UseVisualStyleBackColor = False
        '
        'Cmd_Back
        '
        Me.Cmd_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmd_Back.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Back.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Back.Image = CType(resources.GetObject("Cmd_Back.Image"), System.Drawing.Image)
        Me.Cmd_Back.Location = New System.Drawing.Point(836, 740)
        Me.Cmd_Back.Name = "Cmd_Back"
        Me.Cmd_Back.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Back.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_Back.TabIndex = 10
        Me.Cmd_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Back, "O 1 vzad")
        Me.Cmd_Back.UseVisualStyleBackColor = False
        '
        'Cmd_Forward
        '
        Me.Cmd_Forward.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmd_Forward.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Forward.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Forward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Forward.Image = CType(resources.GetObject("Cmd_Forward.Image"), System.Drawing.Image)
        Me.Cmd_Forward.Location = New System.Drawing.Point(1059, 740)
        Me.Cmd_Forward.Name = "Cmd_Forward"
        Me.Cmd_Forward.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Forward.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_Forward.TabIndex = 8
        Me.Cmd_Forward.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Forward, "O 1 vpřed")
        Me.Cmd_Forward.UseVisualStyleBackColor = False
        '
        'Cmd_Last
        '
        Me.Cmd_Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmd_Last.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Last.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Last.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Last.Image = CType(resources.GetObject("Cmd_Last.Image"), System.Drawing.Image)
        Me.Cmd_Last.Location = New System.Drawing.Point(1112, 740)
        Me.Cmd_Last.Name = "Cmd_Last"
        Me.Cmd_Last.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Last.Size = New System.Drawing.Size(55, 42)
        Me.Cmd_Last.TabIndex = 7
        Me.Cmd_Last.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Last, "Na konec")
        Me.Cmd_Last.UseVisualStyleBackColor = False
        '
        'Cmd_Order
        '
        Me.Cmd_Order.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Order.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Order.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Order.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Order.Location = New System.Drawing.Point(1007, 265)
        Me.Cmd_Order.Name = "Cmd_Order"
        Me.Cmd_Order.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Order.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Order.TabIndex = 6
        Me.Cmd_Order.Text = "ŘAZENÍ"
        Me.ToolTip1.SetToolTip(Me.Cmd_Order, "Změnit parametry řazení kouzel")
        Me.Cmd_Order.UseVisualStyleBackColor = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.Cyan
        Me.Cmd_Print.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Print.Location = New System.Drawing.Point(1007, 216)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Print.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Print.TabIndex = 5
        Me.Cmd_Print.Text = "TISK"
        Me.ToolTip1.SetToolTip(Me.Cmd_Print, "Tisk kouzla anebo sestavy")
        Me.Cmd_Print.UseVisualStyleBackColor = False
        '
        'Cmd_New
        '
        Me.Cmd_New.BackColor = System.Drawing.Color.White
        Me.Cmd_New.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_New.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_New.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_New.Location = New System.Drawing.Point(1007, 167)
        Me.Cmd_New.Name = "Cmd_New"
        Me.Cmd_New.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_New.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_New.TabIndex = 4
        Me.Cmd_New.Text = "NOVÝ"
        Me.ToolTip1.SetToolTip(Me.Cmd_New, "Vymaže pole, příprava na vepsání nového kouzla")
        Me.Cmd_New.UseVisualStyleBackColor = False
        '
        'Cmd_Find
        '
        Me.Cmd_Find.BackColor = System.Drawing.Color.Yellow
        Me.Cmd_Find.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Find.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Find.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Find.Location = New System.Drawing.Point(1007, 104)
        Me.Cmd_Find.Name = "Cmd_Find"
        Me.Cmd_Find.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Find.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Find.TabIndex = 3
        Me.Cmd_Find.Text = "NAJÍT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Find, "Najít kouzlo")
        Me.Cmd_Find.UseVisualStyleBackColor = False
        '
        'Cmd_Del
        '
        Me.Cmd_Del.BackColor = System.Drawing.Color.Red
        Me.Cmd_Del.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Del.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Del.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Del.Location = New System.Drawing.Point(1007, 56)
        Me.Cmd_Del.Name = "Cmd_Del"
        Me.Cmd_Del.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Del.Size = New System.Drawing.Size(160, 50)
        Me.Cmd_Del.TabIndex = 2
        Me.Cmd_Del.Text = "SMAZAT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Del, "Smazat aktuální kouzlo")
        Me.Cmd_Del.UseVisualStyleBackColor = False
        '
        'Cmd_Ins
        '
        Me.Cmd_Ins.BackColor = System.Drawing.Color.Green
        Me.Cmd_Ins.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Ins.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Ins.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Ins.Location = New System.Drawing.Point(1007, 8)
        Me.Cmd_Ins.Name = "Cmd_Ins"
        Me.Cmd_Ins.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Ins.Size = New System.Drawing.Size(160, 50)
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
        Me.Cmd_Exit.Location = New System.Drawing.Point(1017, 583)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Exit.Size = New System.Drawing.Size(150, 80)
        Me.Cmd_Exit.TabIndex = 0
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cmd_Exit, "Zavřít toto okno")
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'Cmd_sr
        '
        Me.Cmd_sr.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmd_sr.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_sr.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_sr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_sr.Image = CType(resources.GetObject("Cmd_sr.Image"), System.Drawing.Image)
        Me.Cmd_sr.Location = New System.Drawing.Point(721, 569)
        Me.Cmd_sr.Name = "Cmd_sr"
        Me.Cmd_sr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_sr.Size = New System.Drawing.Size(35, 35)
        Me.Cmd_sr.TabIndex = 55
        Me.Cmd_sr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_sr.UseVisualStyleBackColor = False
        '
        'Cmd_sk
        '
        Me.Cmd_sk.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmd_sk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_sk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_sk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_sk.Image = CType(resources.GetObject("Cmd_sk.Image"), System.Drawing.Image)
        Me.Cmd_sk.Location = New System.Drawing.Point(498, 569)
        Me.Cmd_sk.Name = "Cmd_sk"
        Me.Cmd_sk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_sk.Size = New System.Drawing.Size(35, 35)
        Me.Cmd_sk.TabIndex = 54
        Me.Cmd_sk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_sk.UseVisualStyleBackColor = False
        '
        'Cmd_ss
        '
        Me.Cmd_ss.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmd_ss.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ss.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ss.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ss.Image = CType(resources.GetObject("Cmd_ss.Image"), System.Drawing.Image)
        Me.Cmd_ss.Location = New System.Drawing.Point(269, 569)
        Me.Cmd_ss.Name = "Cmd_ss"
        Me.Cmd_ss.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ss.Size = New System.Drawing.Size(35, 35)
        Me.Cmd_ss.TabIndex = 53
        Me.Cmd_ss.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_ss.UseVisualStyleBackColor = False
        '
        'Cmd_dr
        '
        Me.Cmd_dr.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmd_dr.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_dr.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_dr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_dr.Image = CType(resources.GetObject("Cmd_dr.Image"), System.Drawing.Image)
        Me.Cmd_dr.Location = New System.Drawing.Point(681, 569)
        Me.Cmd_dr.Name = "Cmd_dr"
        Me.Cmd_dr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_dr.Size = New System.Drawing.Size(35, 35)
        Me.Cmd_dr.TabIndex = 52
        Me.Cmd_dr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_dr.UseVisualStyleBackColor = False
        '
        'Cmd_ar
        '
        Me.Cmd_ar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmd_ar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ar.Image = CType(resources.GetObject("Cmd_ar.Image"), System.Drawing.Image)
        Me.Cmd_ar.Location = New System.Drawing.Point(641, 569)
        Me.Cmd_ar.Name = "Cmd_ar"
        Me.Cmd_ar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ar.Size = New System.Drawing.Size(35, 35)
        Me.Cmd_ar.TabIndex = 51
        Me.Cmd_ar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_ar.UseVisualStyleBackColor = False
        '
        'Cmd_dk
        '
        Me.Cmd_dk.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmd_dk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_dk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_dk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_dk.Image = CType(resources.GetObject("Cmd_dk.Image"), System.Drawing.Image)
        Me.Cmd_dk.Location = New System.Drawing.Point(458, 569)
        Me.Cmd_dk.Name = "Cmd_dk"
        Me.Cmd_dk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_dk.Size = New System.Drawing.Size(35, 35)
        Me.Cmd_dk.TabIndex = 50
        Me.Cmd_dk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_dk.UseVisualStyleBackColor = False
        '
        'Cmd_ak
        '
        Me.Cmd_ak.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmd_ak.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ak.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ak.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ak.Image = CType(resources.GetObject("Cmd_ak.Image"), System.Drawing.Image)
        Me.Cmd_ak.Location = New System.Drawing.Point(418, 569)
        Me.Cmd_ak.Name = "Cmd_ak"
        Me.Cmd_ak.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ak.Size = New System.Drawing.Size(35, 35)
        Me.Cmd_ak.TabIndex = 49
        Me.Cmd_ak.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_ak.UseVisualStyleBackColor = False
        '
        'Cmd_ds
        '
        Me.Cmd_ds.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmd_ds.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ds.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ds.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ds.Image = CType(resources.GetObject("Cmd_ds.Image"), System.Drawing.Image)
        Me.Cmd_ds.Location = New System.Drawing.Point(229, 569)
        Me.Cmd_ds.Name = "Cmd_ds"
        Me.Cmd_ds.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ds.Size = New System.Drawing.Size(35, 35)
        Me.Cmd_ds.TabIndex = 48
        Me.Cmd_ds.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_ds.UseVisualStyleBackColor = False
        '
        'Cmd_as
        '
        Me.Cmd_as.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmd_as.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_as.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_as.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_as.Image = CType(resources.GetObject("Cmd_as.Image"), System.Drawing.Image)
        Me.Cmd_as.Location = New System.Drawing.Point(189, 569)
        Me.Cmd_as.Name = "Cmd_as"
        Me.Cmd_as.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_as.Size = New System.Drawing.Size(35, 35)
        Me.Cmd_as.TabIndex = 47
        Me.Cmd_as.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_as.UseVisualStyleBackColor = False
        '
        'CHck_pri
        '
        Me.CHck_pri.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CHck_pri.Cursor = System.Windows.Forms.Cursors.Default
        Me.CHck_pri.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CHck_pri.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CHck_pri.Location = New System.Drawing.Point(500, 812)
        Me.CHck_pri.Name = "CHck_pri"
        Me.CHck_pri.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CHck_pri.Size = New System.Drawing.Size(133, 26)
        Me.CHck_pri.TabIndex = 46
        Me.CHck_pri.Text = "Tisknout?"
        Me.CHck_pri.UseVisualStyleBackColor = False
        '
        'Txt_price
        '
        Me.Txt_price.AcceptsReturn = True
        Me.Txt_price.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_price.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_price.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_price.Location = New System.Drawing.Point(359, 775)
        Me.Txt_price.MaxLength = 0
        Me.Txt_price.Name = "Txt_price"
        Me.Txt_price.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_price.Size = New System.Drawing.Size(153, 26)
        Me.Txt_price.TabIndex = 45
        '
        'Txt_rar
        '
        Me.Txt_rar.AcceptsReturn = True
        Me.Txt_rar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_rar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_rar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_rar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_rar.Location = New System.Drawing.Point(80, 812)
        Me.Txt_rar.MaxLength = 0
        Me.Txt_rar.Name = "Txt_rar"
        Me.Txt_rar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_rar.Size = New System.Drawing.Size(161, 26)
        Me.Txt_rar.TabIndex = 43
        '
        'Txt_spec
        '
        Me.Txt_spec.AcceptsReturn = True
        Me.Txt_spec.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_spec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_spec.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_spec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_spec.Location = New System.Drawing.Point(223, 740)
        Me.Txt_spec.MaxLength = 0
        Me.Txt_spec.Name = "Txt_spec"
        Me.Txt_spec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_spec.Size = New System.Drawing.Size(533, 26)
        Me.Txt_spec.TabIndex = 41
        '
        'Txt_tim
        '
        Me.Txt_tim.AcceptsReturn = True
        Me.Txt_tim.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_tim.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_tim.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_tim.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_tim.Location = New System.Drawing.Point(873, 700)
        Me.Txt_tim.MaxLength = 0
        Me.Txt_tim.Name = "Txt_tim"
        Me.Txt_tim.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_tim.Size = New System.Drawing.Size(166, 26)
        Me.Txt_tim.TabIndex = 39
        '
        'Txt_sur
        '
        Me.Txt_sur.AcceptsReturn = True
        Me.Txt_sur.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_sur.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_sur.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_sur.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_sur.Location = New System.Drawing.Point(548, 700)
        Me.Txt_sur.MaxLength = 0
        Me.Txt_sur.Name = "Txt_sur"
        Me.Txt_sur.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_sur.Size = New System.Drawing.Size(126, 26)
        Me.Txt_sur.TabIndex = 37
        '
        'Txt_mgv
        '
        Me.Txt_mgv.AcceptsReturn = True
        Me.Txt_mgv.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_mgv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_mgv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_mgv.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_mgv.Location = New System.Drawing.Point(197, 700)
        Me.Txt_mgv.MaxLength = 0
        Me.Txt_mgv.Name = "Txt_mgv"
        Me.Txt_mgv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_mgv.Size = New System.Drawing.Size(114, 26)
        Me.Txt_mgv.TabIndex = 35
        '
        'Txt_rem
        '
        Me.Txt_rem.AcceptsReturn = True
        Me.Txt_rem.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_rem.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_rem.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_rem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_rem.Location = New System.Drawing.Point(135, 611)
        Me.Txt_rem.MaxLength = 0
        Me.Txt_rem.Multiline = True
        Me.Txt_rem.Name = "Txt_rem"
        Me.Txt_rem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_rem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_rem.Size = New System.Drawing.Size(847, 52)
        Me.Txt_rem.TabIndex = 33
        '
        'Lst_res
        '
        Me.Lst_res.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lst_res.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_res.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lst_res.ForeColor = System.Drawing.Color.Yellow
        Me.Lst_res.ItemHeight = 17
        Me.Lst_res.Location = New System.Drawing.Point(594, 391)
        Me.Lst_res.Name = "Lst_res"
        Me.Lst_res.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_res.Size = New System.Drawing.Size(230, 174)
        Me.Lst_res.TabIndex = 31
        '
        'Lst_skills
        '
        Me.Lst_skills.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lst_skills.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_skills.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lst_skills.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Lst_skills.ItemHeight = 17
        Me.Lst_skills.Location = New System.Drawing.Point(364, 391)
        Me.Lst_skills.Name = "Lst_skills"
        Me.Lst_skills.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_skills.Size = New System.Drawing.Size(230, 174)
        Me.Lst_skills.TabIndex = 29
        '
        'Lst_spells
        '
        Me.Lst_spells.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lst_spells.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_spells.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lst_spells.ForeColor = System.Drawing.Color.Yellow
        Me.Lst_spells.ItemHeight = 17
        Me.Lst_spells.Location = New System.Drawing.Point(134, 391)
        Me.Lst_spells.Name = "Lst_spells"
        Me.Lst_spells.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_spells.Size = New System.Drawing.Size(230, 174)
        Me.Lst_spells.TabIndex = 27
        '
        'Txt_eptyp
        '
        Me.Txt_eptyp.AcceptsReturn = True
        Me.Txt_eptyp.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_eptyp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_eptyp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_eptyp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_eptyp.Location = New System.Drawing.Point(591, 324)
        Me.Txt_eptyp.MaxLength = 0
        Me.Txt_eptyp.Name = "Txt_eptyp"
        Me.Txt_eptyp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_eptyp.Size = New System.Drawing.Size(208, 26)
        Me.Txt_eptyp.TabIndex = 25
        '
        'Txt_ep
        '
        Me.Txt_ep.AcceptsReturn = True
        Me.Txt_ep.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_ep.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ep.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_ep.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_ep.Location = New System.Drawing.Point(409, 324)
        Me.Txt_ep.MaxLength = 0
        Me.Txt_ep.Name = "Txt_ep"
        Me.Txt_ep.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_ep.Size = New System.Drawing.Size(74, 26)
        Me.Txt_ep.TabIndex = 23
        '
        'Txt_mg
        '
        Me.Txt_mg.AcceptsReturn = True
        Me.Txt_mg.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_mg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_mg.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_mg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_mg.Location = New System.Drawing.Point(204, 324)
        Me.Txt_mg.MaxLength = 0
        Me.Txt_mg.Name = "Txt_mg"
        Me.Txt_mg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_mg.Size = New System.Drawing.Size(128, 26)
        Me.Txt_mg.TabIndex = 21
        '
        'Txt_pow
        '
        Me.Txt_pow.AcceptsReturn = True
        Me.Txt_pow.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_pow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_pow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_pow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_pow.Location = New System.Drawing.Point(72, 192)
        Me.Txt_pow.MaxLength = 0
        Me.Txt_pow.Multiline = True
        Me.Txt_pow.Name = "Txt_pow"
        Me.Txt_pow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_pow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_pow.Size = New System.Drawing.Size(910, 126)
        Me.Txt_pow.TabIndex = 19
        '
        'Txt_pop
        '
        Me.Txt_pop.AcceptsReturn = True
        Me.Txt_pop.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_pop.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_pop.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_pop.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_pop.Location = New System.Drawing.Point(72, 53)
        Me.Txt_pop.MaxLength = 0
        Me.Txt_pop.Multiline = True
        Me.Txt_pop.Name = "Txt_pop"
        Me.Txt_pop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_pop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_pop.Size = New System.Drawing.Size(910, 133)
        Me.Txt_pop.TabIndex = 17
        '
        'Txt_typ
        '
        Me.Txt_typ.AcceptsReturn = True
        Me.Txt_typ.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_typ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_typ.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_typ.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_typ.Location = New System.Drawing.Point(846, 8)
        Me.Txt_typ.MaxLength = 0
        Me.Txt_typ.Name = "Txt_typ"
        Me.Txt_typ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_typ.Size = New System.Drawing.Size(140, 26)
        Me.Txt_typ.TabIndex = 15
        '
        'Txt_name
        '
        Me.Txt_name.AcceptsReturn = True
        Me.Txt_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_name.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_name.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_name.Location = New System.Drawing.Point(178, 8)
        Me.Txt_name.MaxLength = 0
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_name.Size = New System.Drawing.Size(578, 32)
        Me.Txt_name.TabIndex = 13
        '
        'Txt_Num
        '
        Me.Txt_Num.AcceptsReturn = True
        Me.Txt_Num.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_Num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Num.Font = New System.Drawing.Font("Arial", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Location = New System.Drawing.Point(890, 740)
        Me.Txt_Num.MaxLength = 0
        Me.Txt_Num.Name = "Txt_Num"
        Me.Txt_Num.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Num.Size = New System.Drawing.Size(170, 40)
        Me.Txt_Num.TabIndex = 9
        Me.Txt_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(279, 775)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(74, 26)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Cena"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(8, 812)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(66, 26)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "Rarita"
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Line1.Location = New System.Drawing.Point(8, 682)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(1159, 3)
        Me.Line1.TabIndex = 57
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(8, 740)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(205, 26)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Speciality na výrobu"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(710, 700)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(170, 26)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Čas na výrobu"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(334, 700)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(225, 26)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Surovin na výrobu"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(8, 700)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(169, 26)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Magů na výrobu"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(8, 611)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(113, 22)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Poznámky"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(616, 359)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(209, 29)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Zvyšuje resistence"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(356, 359)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(248, 29)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Posiluje/dává dovednosti"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(177, 359)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(140, 29)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Sesílá kouzla"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(511, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(61, 29)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Typu"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(338, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(72, 29)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "EP/SP"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 324)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(194, 29)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Počet magů na den"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(58, 25)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Síly"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(7, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(66, 37)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Popis"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(766, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(58, 22)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Typ"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(169, 26)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Jméno Itemu"
        '
        'Txt_alch
        '
        Me.Txt_alch.AcceptsReturn = True
        Me.Txt_alch.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Txt_alch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_alch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_alch.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_alch.Location = New System.Drawing.Point(136, 775)
        Me.Txt_alch.MaxLength = 0
        Me.Txt_alch.Name = "Txt_alch"
        Me.Txt_alch.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_alch.Size = New System.Drawing.Size(121, 26)
        Me.Txt_alch.TabIndex = 58
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(8, 775)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(98, 26)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Zařazení"
        '
        'Bt_List
        '
        Me.Bt_List.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Bt_List.Image = CType(resources.GetObject("Bt_List.Image"), System.Drawing.Image)
        Me.Bt_List.Location = New System.Drawing.Point(1042, 485)
        Me.Bt_List.Name = "Bt_List"
        Me.Bt_List.Size = New System.Drawing.Size(120, 80)
        Me.Bt_List.TabIndex = 60
        Me.Bt_List.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Pb_pic
        '
        Me.Pb_pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pb_pic.Location = New System.Drawing.Point(986, 360)
        Me.Pb_pic.Name = "Pb_pic"
        Me.Pb_pic.Size = New System.Drawing.Size(176, 104)
        Me.Pb_pic.TabIndex = 61
        Me.Pb_pic.TabStop = False
        '
        'Frm_Items
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1194, 846)
        Me.Controls.Add(Me.Pb_pic)
        Me.Controls.Add(Me.Bt_List)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Txt_alch)
        Me.Controls.Add(Me.Cmd_sr)
        Me.Controls.Add(Me.Cmd_sk)
        Me.Controls.Add(Me.Cmd_ss)
        Me.Controls.Add(Me.Cmd_dr)
        Me.Controls.Add(Me.Cmd_ar)
        Me.Controls.Add(Me.Cmd_dk)
        Me.Controls.Add(Me.Cmd_ak)
        Me.Controls.Add(Me.Cmd_ds)
        Me.Controls.Add(Me.Cmd_as)
        Me.Controls.Add(Me.CHck_pri)
        Me.Controls.Add(Me.Txt_price)
        Me.Controls.Add(Me.Txt_rar)
        Me.Controls.Add(Me.Txt_spec)
        Me.Controls.Add(Me.Txt_tim)
        Me.Controls.Add(Me.Txt_sur)
        Me.Controls.Add(Me.Txt_mgv)
        Me.Controls.Add(Me.Txt_rem)
        Me.Controls.Add(Me.Lst_res)
        Me.Controls.Add(Me.Lst_skills)
        Me.Controls.Add(Me.Lst_spells)
        Me.Controls.Add(Me.Txt_eptyp)
        Me.Controls.Add(Me.Txt_ep)
        Me.Controls.Add(Me.Txt_mg)
        Me.Controls.Add(Me.Txt_pow)
        Me.Controls.Add(Me.Txt_pop)
        Me.Controls.Add(Me.Txt_typ)
        Me.Controls.Add(Me.Txt_name)
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
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Line1)
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
        Me.Name = "Frm_Items"
        Me.Opacity = 0.9
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC AVATAR - Odria Items"
        CType(Me.Pb_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Frm_Items
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Frm_Items
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Frm_Items()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As Frm_Items)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

    Private Sub Frm_ITsez_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles my_sez.Closed
        If Titem <> "" Then
            ITposition = 0
            Do Until ITrec.Tables("I").Rows(ITposition)("Item_name") = Titem
                ITposition += 1
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
        ITposition -= 1
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
        ITposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Forward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Forward.Click
        ITposition += 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Last_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Last.Click
        ITposition = ITcount - 1
        Call FillForm()
    End Sub

    Private Sub Cmd_New_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_New.Click
        Txt_name.Text = ""
        Txt_typ.Text = ""
        Txt_pop.Text = ""
        Txt_pow.Text = ""
        Txt_mg.Text = ""
        Txt_ep.Text = ""
        Txt_eptyp.Text = ""
        Txt_rem.Text = ""
        Txt_mgv.Text = ""
        Txt_sur.Text = ""
        Txt_tim.Text = ""
        Txt_spec.Text = ""
        Txt_rar.Text = ""
        Txt_price.Text = ""
        Txt_alch.Text = ""
        Pb_pic.Image = Nothing
        CHck_pri.CheckState = System.Windows.Forms.CheckState.Unchecked
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

    Private Sub Frm_Items_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call ITrecopen()
        ITposition = 0
        ApplyColor()
        Call FillForm()
        IT = True
    End Sub


    Private Sub ITrecopen()
        Dim isc As New OleDbCommand
        isc.Connection = Odrialink2
        Select Case ITorder
            Case Is = 1
                If ITdirect = 1 Then
                    isc.CommandText = "select * from Items order by Item_name"
                Else
                    isc.CommandText = "select * from Items order by Item_name desc"
                End If
            Case Is = 2
                If ITdirect = 1 Then
                    isc.CommandText = "select * from Items order by Type"
                Else
                    isc.CommandText = "select * from Items order by Type desc"
                End If
            Case Is = 3
                If ITdirect = 1 Then
                    isc.CommandText = "select * from Items order by Alch"
                Else
                    isc.CommandText = "select * from Items order by Alch desc"
                End If
        End Select
        ITdat.SelectCommand = isc
        ITrec.Clear()
        ITdat.Fill(ITrec, "I")
        ITcount = ITrec.Tables("I").Rows.Count
    End Sub


    Sub FillForm()
        Dim spe As New OleDbCommand
        Dim ski As New OleDbCommand
        Dim ele As New OleDbCommand
        Dim a, b, c As Int16
        Dim ax, bx, cx As Int16
        Txt_name.Text = ITrec.Tables("I").Rows(ITposition)("Item_name")
        If Not IsDBNull(ITrec.Tables("I").Rows(ITposition)("Type")) Then
            Txt_typ.Text = ITrec.Tables("I").Rows(ITposition)("Type")
        Else
            Txt_typ.Text = ""
        End If
        If Not IsDBNull(ITrec.Tables("I").Rows(ITposition)("Looking")) Then
            Txt_pop.Text = ITrec.Tables("I").Rows(ITposition)("Looking")
        Else
            Txt_pop.Text = ""
        End If
        If Not IsDBNull(ITrec.Tables("I").Rows(ITposition)("Daily_MG")) Then
            Txt_mg.Text = ITrec.Tables("I").Rows(ITposition)("Daily_MG")
        Else
            Txt_mg.Text = ""
        End If
        If Not IsDBNull(ITrec.Tables("I").Rows(ITposition)("Special_powers")) Then
            Txt_pow.Text = ITrec.Tables("I").Rows(ITposition)("Special_powers")
        Else
            Txt_pow.Text = ""
        End If
        If Not IsDBNull(ITrec.Tables("I").Rows(ITposition)("EP_SP")) Then
            Txt_ep.Text = ITrec.Tables("I").Rows(ITposition)("EP_SP")
        Else
            Txt_ep.Text = ""
        End If
        If Not IsDBNull(ITrec.Tables("I").Rows(ITposition)("EP_SP_type")) Then
            Txt_eptyp.Text = ITrec.Tables("I").Rows(ITposition)("EP_SP_type")
        Else
            Txt_eptyp.Text = ""
        End If
        If Not IsDBNull(ITrec.Tables("I").Rows(ITposition)("MG_to_make")) Then
            Txt_mgv.Text = ITrec.Tables("I").Rows(ITposition)("MG_to_make")
        Else
            Txt_mgv.Text = ""
        End If
        If Not IsDBNull(ITrec.Tables("I").Rows(ITposition)("Res_to_make")) Then
            Txt_sur.Text = ITrec.Tables("I").Rows(ITposition)("Res_to_make")
        Else
            Txt_sur.Text = ""
        End If
        If Not IsDBNull(ITrec.Tables("I").Rows(ITposition)("Specs_to_make")) Then
            Txt_spec.Text = ITrec.Tables("I").Rows(ITposition)("Specs_to_make")
        Else
            Txt_spec.Text = ""
        End If
        If Not IsDBNull(ITrec.Tables("I").Rows(ITposition)("Time_to_make")) Then
            Txt_tim.Text = ITrec.Tables("I").Rows(ITposition)("Time_to_make")
        Else
            Txt_tim.Text = ""
        End If
        If Not IsDBNull(ITrec.Tables("I").Rows(ITposition)("Rarity")) Then
            Txt_rar.Text = ITrec.Tables("I").Rows(ITposition)("Rarity")
        Else
            Txt_rar.Text = ""
        End If
        If Not IsDBNull(ITrec.Tables("I").Rows(ITposition)("App_price")) Then
            Txt_price.Text = ITrec.Tables("I").Rows(ITposition)("App_price")
        Else
            Txt_price.Text = ""
        End If
        If Not IsDBNull(ITrec.Tables("I").Rows(ITposition)("Remarks")) Then
            Txt_rem.Text = ITrec.Tables("I").Rows(ITposition)("Remarks")
        Else
            Txt_rem.Text = ""
        End If
        If ITrec.Tables("I").Rows(ITposition)("Print") = True Then
            CHck_pri.CheckState = System.Windows.Forms.CheckState.Checked
        Else
            CHck_pri.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
        If Not IsDBNull(ITrec.Tables("I").Rows(ITposition)("Alch")) Then
            Txt_alch.Text = ITrec.Tables("I").Rows(ITposition)("Alch")
        Else
            Txt_alch.Text = ""
        End If
        If Not IsDBNull(ITrec.Tables("I").Rows(ITposition)("Pic")) Then
            Dim img() As Byte
            img = ITrec.Tables("I").Rows(ITposition)("Pic")
            Dim ms As New System.IO.MemoryStream(img)
            Pb_pic.Image = Image.FromStream(ms)
        Else
            Pb_pic.Image = Nothing
        End If
        spe.Connection = Odrialink2
        ski.Connection = Odrialink2
        ele.Connection = Odrialink2
        Lst_spells.Items.Clear()
        Lst_skills.Items.Clear()
        Lst_res.Items.Clear()
        spe.CommandText = "select * from Itspells where It_ID = " & ITrec.Tables("I").Rows(ITposition)("ID")
        ITSPdat.SelectCommand = spe
        ITSP.Clear()
        ITSPdat.Fill(ITSP, "sp")
        ax = ITSP.Tables("sp").Rows.Count
        a = 0
        If ax > 0 Then
            Do
                Lst_spells.Items.Add((ITSP.Tables("sp").Rows(a)("Spell")))
                a += 1
            Loop Until a = ax
            Cmd_ds.Enabled = True
            Cmd_ss.Enabled = True
        Else
            Cmd_ds.Enabled = False
            Cmd_ss.Enabled = False
        End If
        ski.CommandText = "select * from Itskills where It_ID = " & ITrec.Tables("I").Rows(ITposition)("ID")
        ITSKdat.SelectCommand = ski
        ITSK.Clear()
        ITSKdat.Fill(ITSK, "sk")
        bx = ITSK.Tables("sk").Rows.Count
        b = 0
        If bx > 0 Then
            Do
                Lst_skills.Items.Add((ITSK.Tables("sk").Rows(b)("Skill") & "   " & ITSK.Tables("sk").Rows(b)("Knowledge")))
                b += 1
            Loop Until b = bx
            Cmd_dk.Enabled = True
            Cmd_sk.Enabled = True
        Else
            Cmd_dk.Enabled = False
            Cmd_sk.Enabled = False
        End If
        ele.CommandText = "select * from Itresistances where It_ID = " & ITrec.Tables("I").Rows(ITposition)("ID")
        ITELdat.SelectCommand = ele
        ITEL.Clear()
        ITELdat.Fill(ITEL, "el")
        cx = ITEL.Tables("el").Rows.Count
        c = 0
        If cx > 0 Then
            Do
                Lst_res.Items.Add((ITEL.Tables("el").Rows(c)("Resistance_to") & "   " & ITEL.Tables("el").Rows(c)("Perct") & "%"))
                c += 1
            Loop Until c = cx
            Cmd_dr.Enabled = True
            Cmd_sr.Enabled = True
        Else
            Cmd_dr.Enabled = False
            Cmd_sr.Enabled = False
        End If
        If ITposition = 0 Then
            Cmd_Back.Enabled = False
        Else
            Cmd_Back.Enabled = True
        End If
        Cmd_Del.Enabled = True
        Cmd_Find.Enabled = True
        If ITposition + 1 = ITcount Then
            Cmd_Forward.Enabled = False
        Else
            Cmd_Forward.Enabled = True
        End If
        Cmd_Ins.Enabled = True
        Cmd_New.Enabled = True
        Cmd_Print.Enabled = True


        Txt_Num.Text = (ITposition + 1) & "/" & ITcount

    End Sub


    Private Sub Frm_Items_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        IT = False
        ITSP.Clear()
        ITSK.Clear()
        ITEL.Clear()
        ITrec.Clear()
    End Sub

    Private Sub Txt_Num_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Num.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Not IsNumeric(Txt_Num.Text) Then
                MsgBox("Tady musí být číslo!", MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            If CShort(Txt_Num.Text) > ITcount Or CShort(Txt_Num.Text) < 1 Then
                MsgBox("Číslo musí být v rozsahu 1 - počet záznamů!", MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            KeyAscii = 0
            ITposition = CShort(Txt_Num.Text) - 1
            Call FillForm()
        End If
EventExitSub:
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Cmd_Print_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Print.Click
        Dim ITrint As New ITPrint
        Dim a As Integer
        Try
            Dim tsc As New OleDbCommand
            tsc.Connection = Odrialink2
            tsc.CommandText = "DELETE * from ItTemp"
            tsc.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Chyba při výmazu případu: " + ex.Message)
            Exit Sub
        End Try
        For a = 0 To ITcount - 1
            Try
                Dim ic As New OleDbCommand
                Dim s1, s2 As String
                s1 = "INSERT INTO ItTemp (ID, Item_name"
                s2 = " VALUES (@ID, @Item_name"
                ic.Parameters.AddWithValue("@ID", ITrec.Tables("I").Rows(a)("ID"))
                ic.Parameters.AddWithValue("@Item_name", ITrec.Tables("I").Rows(a)("Item_name"))
                If Not IsDBNull(ITrec.Tables("I").Rows(a)("Type")) Then
                    ic.Parameters.AddWithValue("@Type", ITrec.Tables("I").Rows(a)("Type"))
                    s1 = s1 & ", Type"
                    s2 = s2 & ", @Type"
                End If
                If Not IsDBNull(ITrec.Tables("I").Rows(a)("Looking")) Then
                    ic.Parameters.AddWithValue("@Looking", ITrec.Tables("I").Rows(a)("Looking"))
                    s1 = s1 & ", Looking"
                    s2 = s2 & ", @Looking"
                End If
                If Not IsDBNull(ITrec.Tables("I").Rows(a)("Special_powers")) Then
                    ic.Parameters.AddWithValue("@Special_powers", ITrec.Tables("I").Rows(a)("Special_powers"))
                    s1 = s1 & ", Special_powers"
                    s2 = s2 & ", @Special_powers"
                End If
                If Not IsDBNull(ITrec.Tables("I").Rows(a)("Daily_MG")) Then
                    ic.Parameters.AddWithValue("@Daily_MG", ITrec.Tables("I").Rows(a)("Daily_MG"))
                    s1 = s1 & ", Daily_MG"
                    s2 = s2 & ", @Daily_MG"
                End If
                If Not IsDBNull(ITrec.Tables("I").Rows(a)("EP_SP")) Then
                    ic.Parameters.AddWithValue("@EP_SP", ITrec.Tables("I").Rows(a)("EP_SP"))
                    s1 = s1 & ", EP_SP"
                    s2 = s2 & ", @EP_SP"
                End If
                If Not IsDBNull(ITrec.Tables("I").Rows(a)("EP_SP_type")) Then
                    ic.Parameters.AddWithValue("@EP_SP_type", ITrec.Tables("I").Rows(a)("EP_SP_type"))
                    s1 = s1 & ", EP_SP_type"
                    s2 = s2 & ", @EP_SP_type"
                End If
                If Not IsDBNull(ITrec.Tables("I").Rows(a)("Remarks")) Then
                    ic.Parameters.AddWithValue("@Remarks", ITrec.Tables("I").Rows(a)("Remarks"))
                    s1 = s1 & ", Remarks"
                    s2 = s2 & ", @Remarks"
                End If
                If Not IsDBNull(ITrec.Tables("I").Rows(a)("MG_to_make")) Then
                    ic.Parameters.AddWithValue("@MG_to_make", ITrec.Tables("I").Rows(a)("MG_to_make"))
                    s1 = s1 & ", MG_to_make"
                    s2 = s2 & ", @MG_to_make"
                End If
                If Not IsDBNull(ITrec.Tables("I").Rows(a)("Res_to_make")) Then
                    ic.Parameters.AddWithValue("@Res_to_make", ITrec.Tables("I").Rows(a)("Res_to_make"))
                    s1 = s1 & ", Res_to_make"
                    s2 = s2 & ", @Res_to_make"
                End If
                If Not IsDBNull(ITrec.Tables("I").Rows(a)("Time_to_make")) Then
                    ic.Parameters.AddWithValue("@Time_to_make", ITrec.Tables("I").Rows(a)("Time_to_make"))
                    s1 = s1 & ", Time_to_make"
                    s2 = s2 & ", @Time_to_make"
                End If
                If Not IsDBNull(ITrec.Tables("I").Rows(a)("Specs_to_make")) Then
                    ic.Parameters.AddWithValue("@Specs_to_make", ITrec.Tables("I").Rows(a)("Specs_to_make"))
                    s1 = s1 & ", Specs_to_make"
                    s2 = s2 & ", @Specs_to_make"
                End If
                If Not IsDBNull(ITrec.Tables("I").Rows(a)("Rarity")) Then
                    ic.Parameters.AddWithValue("@Rarity", ITrec.Tables("I").Rows(a)("Rarity"))
                    s1 = s1 & ", Rarity"
                    s2 = s2 & ", @Rarity"
                End If
                If Not IsDBNull(ITrec.Tables("I").Rows(a)("App_price")) Then
                    ic.Parameters.AddWithValue("@App_price", ITrec.Tables("I").Rows(a)("App_price"))
                    s1 = s1 & ", App_price"
                    s2 = s2 & ", @App_price"
                End If
                If Not IsDBNull(ITrec.Tables("I").Rows(a)("Alch")) Then
                    ic.Parameters.AddWithValue("@Alch", ITrec.Tables("I").Rows(a)("Alch"))
                    s1 = s1 & ", Alch"
                    s2 = s2 & ", @Alch"
                End If
                Dim spe As New OleDbCommand
                Dim ski As New OleDbCommand
                Dim ele As New OleDbCommand
                Dim u, b, c As Int16
                Dim ax, bx, cx As Int16
                spe.Connection = Odrialink2
                ski.Connection = Odrialink2
                ele.Connection = Odrialink2
                spe.CommandText = "select * from Itspells where It_ID = " & ITrec.Tables("I").Rows(a)("ID")
                ITSPdat.SelectCommand = spe
                ITSP.Clear()
                ITSPdat.Fill(ITSP, "sp")
                ax = ITSP.Tables("sp").Rows.Count
                u = 0
                If ax > 0 Then
                    Dim gu As String
                    gu = ""
                    Do
                        If u > 0 Then
                            gu = gu & ", "
                        End If
                        gu = gu & ITSP.Tables("sp").Rows(u)("Spell")
                        u += 1
                    Loop Until u = ax
                    ic.Parameters.AddWithValue("@Spelly", gu)
                    s1 = s1 & ", Spelly"
                    s2 = s2 & ", @Spelly"
                End If
                ski.CommandText = "select * from Itskills where It_ID = " & ITrec.Tables("I").Rows(a)("ID")
                ITSKdat.SelectCommand = ski
                ITSK.Clear()
                ITSKdat.Fill(ITSK, "sk")
                bx = ITSK.Tables("sk").Rows.Count
                b = 0
                If bx > 0 Then
                    Dim gu, pogu As String
                    gu = ""
                    Do
                        If b > 0 Then
                            gu = gu & ", "
                        End If
                        gu = gu & ITSK.Tables("sk").Rows(b)("Skill")
                        pogu = ITSK.Tables("sk").Rows(b)("Knowledge")
                        If Mid(pogu, 1, 1) = "+" Or Mid(pogu, 1, 1) = "-" Then
                            gu = gu & " o "
                        Else
                            gu = gu & " "
                        End If
                        gu = gu & pogu
                        pogu = ""
                        b += 1
                    Loop Until b = bx
                    ic.Parameters.AddWithValue("@Skilly", gu)
                    s1 = s1 & ", Skilly"
                    s2 = s2 & ", @Skilly"
                End If
                ele.CommandText = "select * from Itresistances where It_ID = " & ITrec.Tables("I").Rows(a)("ID")
                ITELdat.SelectCommand = ele
                ITEL.Clear()
                ITELdat.Fill(ITEL, "el")
                cx = ITEL.Tables("el").Rows.Count
                c = 0
                If cx > 0 Then
                    Dim gu As String
                    gu = ""
                    Do
                        If c > 0 Then
                            gu = gu & ", "
                        End If
                        gu = gu & ITEL.Tables("el").Rows(c)("Resistance_to") & " " & ITEL.Tables("el").Rows(c)("Perct") & "%"
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
        isc.CommandText = "select * from ItTemp order by ID"
        da.SelectCommand = isc
        Tset.Clear()
        da.Fill(Tset, "It")
        ITrint.Show()
    End Sub

    Private Sub Cmd_Order_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Order.Click
        OrderControl = "IT"
        FO = New Frm_Ordering
        FO.ShowDialog()
        FO = Nothing
        ITrec.Clear()
        Call ITrecopen()
        ITposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Ins_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Ins.Click
        If Txt_name.Text = "" Then
            MsgBox("Item musí mít jméno!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        Dim tsc As New OleDbCommand
        Dim treader As OleDbDataReader
        Try
            tsc.Connection = Odrialink2
            tsc.CommandText = "select * from Items where Item_name = @it"
            tsc.Parameters.AddWithValue("@it", Txt_name.Text)
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
                s1 = "INSERT INTO Items (Item_name"
                s2 = " VALUES (@Item_name"
                ic.Parameters.AddWithValue("@Item_name", Trim(Txt_name.Text))
                If Txt_typ.Text <> "" Then
                    ic.Parameters.AddWithValue("@Type", Trim(Txt_typ.Text))
                    s1 = s1 & ", Type"
                    s2 = s2 & ", @Type"
                End If
                If Txt_pop.Text <> "" Then
                    ic.Parameters.AddWithValue("@Looking", Trim(Txt_pop.Text))
                    s1 = s1 & ", Looking"
                    s2 = s2 & ", @Looking"
                End If
                If Txt_pow.Text <> "" Then
                    ic.Parameters.AddWithValue("@Special_powers", Trim(Txt_pow.Text))
                    s1 = s1 & ", Special_powers"
                    s2 = s2 & ", @Special_powers"
                End If
                If Txt_mg.Text <> "" Then
                    ic.Parameters.AddWithValue("@Daily_MG", Trim(Txt_mg.Text))
                    s1 = s1 & ", Daily_MG"
                    s2 = s2 & ", @Daily_MG"
                End If
                If Txt_ep.Text <> "" Then
                    ic.Parameters.AddWithValue("@EP_SP", Trim(Txt_ep.Text))
                    s1 = s1 & ", EP_SP"
                    s2 = s2 & ", @EP_SP"
                End If
                If Txt_eptyp.Text <> "" Then
                    ic.Parameters.AddWithValue("@EP_SP_type", Trim(Txt_eptyp.Text))
                    s1 = s1 & ", EP_SP_type"
                    s2 = s2 & ", @EP_SP_type"
                End If
                If Txt_rem.Text <> "" Then
                    ic.Parameters.AddWithValue("@Remarks", Trim(Txt_rem.Text))
                    s1 = s1 & ", Remarks"
                    s2 = s2 & ", @Remarks"
                End If
                If Txt_mgv.Text <> "" Then
                    ic.Parameters.AddWithValue("@MG_to_make", Trim(Txt_mgv.Text))
                    s1 = s1 & ", MG_to_make"
                    s2 = s2 & ", @MG_to_make"
                End If
                If Txt_sur.Text <> "" Then
                    ic.Parameters.AddWithValue("@Res_to_make", Trim(Txt_sur.Text))
                    s1 = s1 & ", Res_to_make"
                    s2 = s2 & ", @Res_to_make"
                End If
                If Txt_tim.Text <> "" Then
                    ic.Parameters.AddWithValue("@Time_to_make", Trim(Txt_tim.Text))
                    s1 = s1 & ", Time_to_make"
                    s2 = s2 & ", @Time_to_make"
                End If
                If Txt_spec.Text <> "" Then
                    ic.Parameters.AddWithValue("@Specs_to_make", Trim(Txt_spec.Text))
                    s1 = s1 & ", Specs_to_make"
                    s2 = s2 & ", @Specs_to_make"
                End If
                If Txt_rar.Text <> "" Then
                    ic.Parameters.AddWithValue("@Rarity", Trim(Txt_rar.Text))
                    s1 = s1 & ", Rarity"
                    s2 = s2 & ", @Rarity"
                End If
                If Txt_price.Text <> "" Then
                    ic.Parameters.AddWithValue("@App_price", Trim(Txt_price.Text))
                    s1 = s1 & ", App_price"
                    s2 = s2 & ", @App_price"
                End If
                If Txt_alch.Text <> "" Then
                    ic.Parameters.AddWithValue("@Alch", Trim(Txt_alch.Text))
                    s1 = s1 & ", Alch"
                    s2 = s2 & ", @Alch"
                End If
                If Not Pb_pic.Image Is Nothing Then
                    Dim ms As New System.IO.MemoryStream
                    Pb_pic.Image.Save(ms, Pb_pic.Image.RawFormat)
                    Dim img() As Byte = ms.GetBuffer
                    ic.Parameters.AddWithValue("@Pic", img)
                    s1 = s1 & ", Pic"
                    s2 = s2 & ", @Pic"
                End If
                ic.Parameters.AddWithValue("@Print", False)
                s1 = s1 & ", Print"
                s2 = s2 & ", @Print"
                If CHck_pri.CheckState = 0 Then
                    ic.Parameters.AddWithValue("@Print", False)
                Else
                    ic.Parameters.AddWithValue("@Print", True)
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
            ITrec.Clear()
            ITdat.Fill(ITrec, "I")
            ITcount = ITrec.Tables("I").Rows.Count
            Dim tsd As New OleDbCommand
            Dim trdeader As OleDbDataReader
            Try
                tsd.Connection = Odrialink2
                tsd.CommandText = "select ID from Items where Item_name = @it"
                tsd.Parameters.AddWithValue("@it", Txt_name.Text)
                trdeader = tsd.ExecuteReader
                trdeader.Read()
                TLock = trdeader.GetInt32(0)
                trdeader.Close()
            Catch ex As Exception
                MsgBox("Chyba při čtení databáze: " + ex.Message, , "CHYBA")
                trdeader.Close()
                Exit Sub
            End Try
            Call ITSPsubadd()
            Call ITSKsubadd()
            Call ITELsubadd()
            Call FillForm()
        Else
            treader.Close()
            If MsgBox("Item tohoto jména již v databázi existuje, chcete ho přepsat?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Upozornění") = MsgBoxResult.Yes Then
                Try

                    Dim s3 As String
                    Dim uc As New OleDbCommand
                    s3 = "UPDATE Items set Item_name = @Item_name, Type = @Type, Looking = @Looking, Special_powers = @Special_powers, Daily_MG = @Daily_MG, EP_SP = @EP_SP, EP_SP_type = @EP_SP_type, Remarks = @Remarks, MG_to_make = @MG_to_make, Res_to_make = @Res_to_make, Time_to_make = @Time_to_make, Specs_to_make = @Specs_to_make, Rarity = @Rarity, App_price = @App_price, Print = @Print, Alch = @Alch, Pic = @Pic WHERE ID = @ID"
                    uc.Parameters.AddWithValue("@Item_name", Trim(Txt_name.Text))
                    If Txt_typ.Text = "" Then
                        uc.Parameters.AddWithValue("@Type", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Type", Trim(Txt_typ.Text))
                    End If
                    If Txt_pop.Text = "" Then
                        uc.Parameters.AddWithValue("@Looking", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Looking", Trim(Txt_pop.Text))
                    End If
                    If Txt_pow.Text = "" Then
                        uc.Parameters.AddWithValue("@Special_powers", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Special_powers", Trim(Txt_pow.Text))
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
                    If Txt_mgv.Text = "" Then
                        uc.Parameters.AddWithValue("@MG_to_make", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@MG_to_make", Trim(Txt_mgv.Text))
                    End If
                    If Txt_sur.Text = "" Then
                        uc.Parameters.AddWithValue("@Res_to_make", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Res_to_make", Trim(Txt_sur.Text))
                    End If
                    If Txt_tim.Text = "" Then
                        uc.Parameters.AddWithValue("@Time_to_make", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Time_to_make", Trim(Txt_tim.Text))
                    End If
                    If Txt_spec.Text = "" Then
                        uc.Parameters.AddWithValue("@Specs_to_make", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Specs_to_make", Trim(Txt_spec.Text))
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
                    If CHck_pri.CheckState = 0 Then
                        uc.Parameters.AddWithValue("@Print", False)
                    Else
                        uc.Parameters.AddWithValue("@Print", True)
                    End If
                    If Txt_alch.Text = "" Then
                        uc.Parameters.AddWithValue("@Alch", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Alch", Trim(Txt_alch.Text))
                    End If
                    If Pb_pic.Image Is Nothing Then
                        uc.Parameters.AddWithValue("@Pic", System.DBNull.Value)
                    Else
                        Dim ms As New System.IO.MemoryStream
                        Pb_pic.Image.Save(ms, Pb_pic.Image.RawFormat)
                        Dim img() As Byte = ms.GetBuffer

                        uc.Parameters.AddWithValue("@Pic", img)
                    End If

                    Call ITSPsubupd()
                    Call ITSKsubupd()
                    Call ITELsubupd()
                    uc.Parameters.AddWithValue("@ID", ITrec.Tables("I").Rows(ITposition)("ID"))
                    uc.Connection = Odrialink2
                    uc.CommandText = s3
                    uc.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Chyba při zápisu do databáze: " + ex.Message, , "CHYBA")
                    Exit Sub
                End Try
                ITrec.Clear()
                ITdat.Fill(ITrec, "I")
                Call FillForm()
            Else
                Exit Sub
            End If
        End If

    End Sub

    Private Sub Cmd_Find_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Find.Click
        Dim ITse As New OleDbCommand
        Dim ITre As OleDbDataReader
        Dim s As String
        Dim q1 As Long
        Dim na, cz, ma, vy, dos, ro, za, sc, nc, ti, fa, po, rr, ap, al As Boolean
        ITse.Connection = Odrialink2
        s = "SELECT * from Items WHERE "
        If Txt_name.Text <> "" Then
            s = s & "Item_name LIKE @Item_name"
            ITse.Parameters.AddWithValue("@Item_name", "%" & Trim(Txt_name.Text) & "%")
            na = True
        End If
        If Txt_typ.Text <> "" Then
            If na Then
                s = s & " AND "
            End If
            s = s & "Type LIKE @Type"
            ITse.Parameters.AddWithValue("@Type", "%" & Trim(Txt_typ.Text) & "%")
            cz = True
        End If
        If Txt_pop.Text <> "" Then
            If na Or cz Then
                s = s & " AND "
            End If
            s = s & "Looking LIKE @Looking"
            ITse.Parameters.AddWithValue("@Looking", "%" & Trim(Txt_pop.Text) & "%")
            ma = True
        End If
        If Txt_pow.Text <> "" Then
            If na Or cz Or ma Then
                s = s & " AND "
            End If
            s = s & "Special_powers LIKE @Special_powers"
            ITse.Parameters.AddWithValue("@Special_powers", "%" & Trim(Txt_pow.Text) & "%")
            vy = True
        End If
        If Txt_mg.Text <> "" Then
            If na Or cz Or ma Or vy Then
                s = s & " AND "
            End If
            s = s & "Daily_MG = @Daily_MG"
            ITse.Parameters.AddWithValue("@Daily_MG", Trim(Txt_mg.Text))
            dos = True
        End If
        If Txt_ep.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Then
                s = s & " AND "
            End If
            s = s & "EP_SP = @EP_SP"
            ITse.Parameters.AddWithValue("@EP_SP", Trim(Txt_ep.Text))
            ro = True
        End If
        If Txt_eptyp.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Then
                s = s & " AND "
            End If
            s = s & "EP_SP_type LIKE @EP_SP_type"
            ITse.Parameters.AddWithValue("@EP_SP_type", "%" & Trim(Txt_eptyp.Text) & "%")
            za = True
        End If
        If Txt_rem.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Then
                s = s & " AND "
            End If
            s = s & "Remarks LIKE @Remarks"
            ITse.Parameters.AddWithValue("@Remarks", "%" & Trim(Txt_rem.Text) & "%")
            sc = True
        End If
        If Txt_mgv.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Then
                s = s & " AND "
            End If
            s = s & "MG_to_make = @MG_to_make"
            ITse.Parameters.AddWithValue("@MG_to_make", Trim(Txt_mgv.Text))
            nc = True
        End If
        If Txt_sur.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Then
                s = s & " AND "
            End If
            s = s & "Res_to_make = @Res_to_make"
            ITse.Parameters.AddWithValue("@Res_to_make", Trim(Txt_sur.Text))
            ti = True
        End If
        If Txt_tim.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Then
                s = s & " AND "
            End If
            s = s & "Time_to_make = @Time_to_make"
            ITse.Parameters.AddWithValue("@Time_to_make", Trim(Txt_tim.Text))
            fa = True
        End If
        If Txt_spec.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Then
                s = s & " AND "
            End If
            s = s & "Specs_to_make LIKE @Specs_to_make"
            ITse.Parameters.AddWithValue("@Specs_to_make", "%" & Trim(Txt_spec.Text) & "%")
            po = True
        End If
        If Txt_rar.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Then
                s = s & " AND "
            End If
            s = s & "Rarity LIKE @Rarity"
            ITse.Parameters.AddWithValue("@Rarity", "%" & Trim(Txt_rar.Text) & "%")
            rr = True
        End If
        If Txt_price.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Then
                s = s & " AND "
            End If
            s = s & "App_price LIKE @App_price"
            ITse.Parameters.AddWithValue("@App_price", "%" & Trim(Txt_price.Text) & "%")
            ap = True
        End If
        If Txt_alch.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Or za Or sc Or nc Or ti Or fa Or po Or rr Or ap Then
                s = s & " AND "
            End If
            s = s & "Alch LIKE @Alch"
            ITse.Parameters.AddWithValue("@Alch", "%" & Trim(Txt_alch.Text) & "%")
            al = True
        End If
        ITposition = 0
        If s = "SELECT * from Items WHERE " Then
            ITrecopen()
            FillForm()
            Exit Sub
        End If
        Try
            ITse.CommandText = s
            ITre = ITse.ExecuteReader
            If ITre.HasRows Then
                q1 = 0
                While ITre.Read()
                    q1 += 1
                End While
                ITre.Close()
                If q1 = 1 Then
                    Do
                        If Txt_name.Text = ITrec.Tables("I").Rows(ITposition)("Item_name") Then
                            Exit Do
                        End If
                        ITposition += 1
                    Loop Until ITposition + 1 = ITcount
                Else
                    ITdat.SelectCommand = ITse
                    ITrec.Clear()
                    ITdat.Fill(ITrec, "I")
                    ITcount = ITrec.Tables("I").Rows.Count
                    If GC_list = 1 Then
                        If my_sez Is Nothing Then
                            my_sez = New Frm_ITsez
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
                ITre.Close()
                MsgBox("Žádný záznam neodpovídá zvoleným parametrům.", , "Nenalezeno")
                Exit Sub
            End If
            ITre.Close()
        Catch ex As Exception
            MsgBox("Chyba při čtení databáze." + ex.Message, , "Chyba")
            Exit Sub
        End Try
        Call FillForm()
    End Sub

    Private Sub Cmd_Del_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Del.Click
        Dim tsc As New OleDbCommand
        If MsgBox("Opravdu vymazat item " & Txt_name.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Upozornění") = MsgBoxResult.Yes Then
            Try
                tsc.Connection = Odrialink2
                tsc.CommandText = "DELETE from Items WHERE ID = @ID"
                tsc.Parameters.AddWithValue("@ID", ITrec.Tables("I").Rows(ITposition)("ID"))
                tsc.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception("Chyba při výmazu případu: " + ex.Message)
                Exit Sub
            End Try
        Else
            Exit Sub
        End If
        ITrec.Clear()
        ITdat.Fill(ITrec, "I")
        ITcount = ITrec.Tables("I").Rows.Count
        If ITposition = ITcount Then
            ITposition -= 1
        End If
        Call FillForm()
    End Sub


    Private Sub ITSPsubadd()
        Dim a As Long
        Dim q As Long
        q = Lst_spells.Items.Count
        If q > -1 Then
            Dim gr As String
            gr = "INSERT INTO Itspells (It_ID, Spell) VALUES (@It_ID, @Spell)"

            For a = 0 To q - 1
                Dim g As New OleDbCommand
                g.Parameters.AddWithValue("@It_ID", TLock)
                g.Parameters.AddWithValue("@Spell", VB6.GetItemString(Lst_spells, a))
                g.Connection = Odrialink2
                g.CommandText = gr
                g.ExecuteScalar()
                g.Dispose()
            Next
        End If
    End Sub


    Private Sub ITSPsubupd()
        Dim a As Long
        Dim q As Long
        Dim h As New OleDbCommand
        Try
            h.Connection = Odrialink2
            h.CommandText = "DELETE from Itspells WHERE It_ID = @ii"
            h.Parameters.AddWithValue("@ii", ITrec.Tables("I").Rows(ITposition)("ID"))
            h.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Chyba při výmazu případu: " + ex.Message)
            Exit Sub
        End Try
        q = Lst_spells.Items.Count
        If q > -1 Then
            Dim gr As String
            gr = "INSERT INTO Itspells (It_ID, Spell) VALUES (@It_ID, @Spell)"

            For a = 0 To q - 1
                Dim g As New OleDbCommand
                g.Parameters.AddWithValue("@It_ID", ITrec.Tables("I").Rows(ITposition)("ID"))
                g.Parameters.AddWithValue("@Spell", VB6.GetItemString(Lst_spells, a))
                g.Connection = Odrialink2
                g.CommandText = gr
                g.ExecuteScalar()
                g.Dispose()
            Next
        End If

    End Sub


    Private Sub ITSKsubadd()
        Dim a As Long
        Dim q As Long
        Dim c As Long
        q = Lst_skills.Items.Count
        If q > -1 Then
            Dim gr As String
            gr = "INSERT INTO Itskills (It_ID, Skill, Knowledge) VALUES (@It_ID, @Skill, @Know)"

            For a = 0 To q - 1
                Dim g As New OleDbCommand
                g.Parameters.AddWithValue("@It_ID", TLock)
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

    Private Sub ITSKsubupd()
        Dim a As Long
        Dim q As Long
        Dim c As Long
        Dim h As New OleDbCommand
        Try
            h.Connection = Odrialink2
            h.CommandText = "DELETE from Itskills WHERE It_ID = @ii"
            h.Parameters.AddWithValue("@ii", ITrec.Tables("I").Rows(ITposition)("ID"))
            h.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Chyba při výmazu případu: " + ex.Message)
            Exit Sub
        End Try
        q = Lst_skills.Items.Count
        If q > -1 Then
            Dim gr As String
            gr = "INSERT INTO Itskills (It_ID, Skill, Knowledge) VALUES (@It_ID, @Skill, @Know)"

            For a = 0 To q - 1
                Dim g As New OleDbCommand
                g.Parameters.AddWithValue("@It_ID", ITrec.Tables("I").Rows(ITposition)("ID"))
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

    Private Sub ITELsubadd()
        Dim c As Long
        Dim a As Long
        Dim q As Long
        q = Lst_res.Items.Count
        If q > -1 Then
            Dim gr As String
            gr = "INSERT INTO Itresistances (It_ID, Resistance_to, Perct) VALUES (@It_ID, @Rest, @Per)"

            For a = 0 To q - 1
                Dim g As New OleDbCommand
                g.Parameters.AddWithValue("@It_ID", TLock)
                For c = 1 To Len(VB6.GetItemString(Lst_res, a)) - 2
                    If Mid(VB6.GetItemString(Lst_res, a), c, 3) = "   " Then
                        g.Parameters.AddWithValue("@Rest", Mid(VB6.GetItemString(Lst_res, a), 1, c - 1))
                        g.Parameters.AddWithValue("@Per", Mid(VB6.GetItemString(Lst_res, a), c + 3, Len(VB6.GetItemString(Lst_res, a)) - (c + 3)))
                    End If
                Next
                g.Connection = Odrialink2
                g.CommandText = gr
                Try
                    g.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Chyba insertu " + ex.Message)
                End Try
                g.Dispose()
            Next
        End If

    End Sub

    Private Sub ITELsubupd()
        Dim c As Long
        Dim a As Long
        Dim q As Long
        Dim h As New OleDbCommand
        Try
            h.Connection = Odrialink2
            h.CommandText = "DELETE from Itresistances WHERE It_ID = @ii"
            h.Parameters.AddWithValue("@ii", ITrec.Tables("I").Rows(ITposition)("ID"))
            h.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Chyba při výmazu případu: " + ex.Message)
            Exit Sub
        End Try
        q = Lst_res.Items.Count
        If q > -1 Then
            Dim gr As String
            gr = "INSERT INTO Itresistances (It_ID, Resistance_to, Perct) VALUES (@It_ID, @Rest, @Per)"

            For a = 0 To q - 1
                Dim g As New OleDbCommand
                g.Parameters.AddWithValue("@It_ID", ITrec.Tables("I").Rows(ITposition)("ID"))
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
            my_sez = New Frm_ITsez
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
        Me.BackColor = Color.FromArgb(FTB)
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
        Label1.ForeColor = Color.FromArgb(FTF)
        Label2.ForeColor = Color.FromArgb(FTF)
        Label3.ForeColor = Color.FromArgb(FTF)
        Label4.ForeColor = Color.FromArgb(FTF)
        Label5.ForeColor = Color.FromArgb(FTF)
        Label6.ForeColor = Color.FromArgb(FTF)
        Label7.ForeColor = Color.FromArgb(FTF)
        Label8.ForeColor = Color.FromArgb(FTF)
        Label9.ForeColor = Color.FromArgb(FTF)
        Label10.ForeColor = Color.FromArgb(FTF)
        Label11.ForeColor = Color.FromArgb(FTF)
        Label12.ForeColor = Color.FromArgb(FTF)
        Label13.ForeColor = Color.FromArgb(FTF)
        Label14.ForeColor = Color.FromArgb(FTF)
        Label15.ForeColor = Color.FromArgb(FTF)
        Label16.ForeColor = Color.FromArgb(FTF)
        Label17.ForeColor = Color.FromArgb(FTF)
        Label18.ForeColor = Color.FromArgb(FTF)
        Txt_Num.ForeColor = Color.FromArgb(FTF)
        Txt_name.ForeColor = Color.FromArgb(FTF)
        Txt_typ.ForeColor = Color.FromArgb(FTF)
        Txt_pop.ForeColor = Color.FromArgb(FTF)
        Txt_pow.ForeColor = Color.FromArgb(FTF)
        Txt_mg.ForeColor = Color.FromArgb(FTF)
        Txt_ep.ForeColor = Color.FromArgb(FTF)
        Txt_eptyp.ForeColor = Color.FromArgb(FTF)
        Txt_rem.ForeColor = Color.FromArgb(FTF)
        Txt_mgv.ForeColor = Color.FromArgb(FTF)
        Txt_sur.ForeColor = Color.FromArgb(FTF)
        Txt_tim.ForeColor = Color.FromArgb(FTF)
        Txt_spec.ForeColor = Color.FromArgb(FTF)
        Txt_alch.ForeColor = Color.FromArgb(FTF)
        Txt_rar.ForeColor = Color.FromArgb(FTF)
        Txt_price.ForeColor = Color.FromArgb(FTF)
        CHck_pri.ForeColor = Color.FromArgb(FTF)
        Pb_pic.ForeColor = Color.FromArgb(FTF)
        Lst_spells.ForeColor = Color.FromArgb(FSPFO)
        Lst_spells.BackColor = Color.FromArgb(FSPB)
        Lst_skills.ForeColor = Color.FromArgb(FSKFO)
        Lst_skills.BackColor = Color.FromArgb(FSKB)
        Lst_res.ForeColor = Color.FromArgb(FEFO)
        Lst_res.BackColor = Color.FromArgb(FEB)
    End Sub

    Private Sub Pb_pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pb_pic.Click
        OpenFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|bmp files (*.bmp)|*.bmp"
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName = "" Then
            Pb_pic.Image = Nothing
        Else
            Dim i As Drawing.Image
            i = Drawing.Image.FromFile(OpenFileDialog1.FileName)
            If i.Width > 175 Or i.Height > 100 Then
                MsgBox("Obrázek je příliš velký, maximální rozměry jsou 175*100 pixelů", MsgBoxStyle.Exclamation, "Chyba")
                Exit Sub
            Else
                Pb_pic.Image = i
            End If
        End If
    End Sub
End Class