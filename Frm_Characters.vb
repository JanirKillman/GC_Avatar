Option Strict Off
Option Explicit On 
Imports System.Data.OleDb
Friend Class Frm_Characters
    Inherits System.Windows.Forms.Form
    Private WithEvents my_sez As Form
    Private TLock As String
    Public Kilch As New Killman
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
	Public WithEvents Txt_hom As System.Windows.Forms.TextBox
    Public WithEvents Txt_pos As System.Windows.Forms.TextBox
	Public WithEvents Txt_spow As System.Windows.Forms.TextBox
	Public WithEvents Txt_on As System.Windows.Forms.TextBox
	Public WithEvents Txt_his As System.Windows.Forms.TextBox
	Public WithEvents Txt_pop As System.Windows.Forms.TextBox
	Public WithEvents Txt_comp As System.Windows.Forms.TextBox
	Public WithEvents Txt_mon As System.Windows.Forms.TextBox
	Public WithEvents Txt_eptyp As System.Windows.Forms.TextBox
	Public WithEvents Txt_sp As System.Windows.Forms.TextBox
	Public WithEvents Txt_ep As System.Windows.Forms.TextBox
	Public WithEvents Txt_psp As System.Windows.Forms.TextBox
	Public WithEvents Txt_mg As System.Windows.Forms.TextBox
	Public WithEvents Txt_hp As System.Windows.Forms.TextBox
	Public WithEvents Txt_kra As System.Windows.Forms.TextBox
	Public WithEvents Txt_jed As System.Windows.Forms.TextBox
	Public WithEvents Txt_mou As System.Windows.Forms.TextBox
	Public WithEvents Txt_IQ As System.Windows.Forms.TextBox
	Public WithEvents Txt_podl As System.Windows.Forms.TextBox
	Public WithEvents Txt_fodl As System.Windows.Forms.TextBox
	Public WithEvents Txt_zru As System.Windows.Forms.TextBox
	Public WithEvents Txt_hbi As System.Windows.Forms.TextBox
	Public WithEvents Txt_sil As System.Windows.Forms.TextBox
	Public WithEvents Txt_birth As System.Windows.Forms.TextBox
    Public WithEvents Txt_weight As System.Windows.Forms.TextBox
	Public WithEvents Txt_height As System.Windows.Forms.TextBox
	Public WithEvents Txt_class As System.Windows.Forms.TextBox
	Public WithEvents Txt_sex As System.Windows.Forms.TextBox
	Public WithEvents Txt_race As System.Windows.Forms.TextBox
	Public WithEvents Txt_titles As System.Windows.Forms.TextBox
	Public WithEvents Txt_name As System.Windows.Forms.TextBox
	Public WithEvents Cmd_aw As System.Windows.Forms.Button
	Public WithEvents Cmd_dw As System.Windows.Forms.Button
	Public WithEvents Cmd_sw As System.Windows.Forms.Button
	Public WithEvents Lst_weap As System.Windows.Forms.ListBox
	Public WithEvents Cmd_ai As System.Windows.Forms.Button
	Public WithEvents Cmd_di As System.Windows.Forms.Button
	Public WithEvents Cmd_si As System.Windows.Forms.Button
	Public WithEvents Lst_items As System.Windows.Forms.ListBox
	Public WithEvents Cmd_Last As System.Windows.Forms.Button
	Public WithEvents Cmd_Forward As System.Windows.Forms.Button
	Public WithEvents Txt_Num As System.Windows.Forms.TextBox
	Public WithEvents Cmd_Back As System.Windows.Forms.Button
	Public WithEvents Cmd_First As System.Windows.Forms.Button
	Public WithEvents Cmd_Exit As System.Windows.Forms.Button
	Public WithEvents Cmd_Ins As System.Windows.Forms.Button
	Public WithEvents Cmd_Del As System.Windows.Forms.Button
	Public WithEvents Cmd_Find As System.Windows.Forms.Button
    Public WithEvents Cmd_Print As System.Windows.Forms.Button
    Public WithEvents Lst_spells As System.Windows.Forms.ListBox
    Public WithEvents Cmd_as As System.Windows.Forms.Button
	Public WithEvents Cmd_ds As System.Windows.Forms.Button
    Public WithEvents Cmd_ss As System.Windows.Forms.Button
    Public WithEvents Label39 As System.Windows.Forms.Label
	Public WithEvents Label38 As System.Windows.Forms.Label
	Public WithEvents Label37 As System.Windows.Forms.Label
	Public WithEvents Label36 As System.Windows.Forms.Label
	Public WithEvents Label35 As System.Windows.Forms.Label
	Public WithEvents Label34 As System.Windows.Forms.Label
	Public WithEvents Label33 As System.Windows.Forms.Label
	Public WithEvents Label32 As System.Windows.Forms.Label
	Public WithEvents Label31 As System.Windows.Forms.Label
	Public WithEvents Label30 As System.Windows.Forms.Label
	Public WithEvents Label29 As System.Windows.Forms.Label
	Public WithEvents Label28 As System.Windows.Forms.Label
	Public WithEvents Label27 As System.Windows.Forms.Label
	Public WithEvents Label26 As System.Windows.Forms.Label
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
    Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents tc As System.Windows.Forms.TabControl
    Friend WithEvents tpVantages As System.Windows.Forms.TabPage
    Friend WithEvents tpClaskil As System.Windows.Forms.TabPage
    Friend WithEvents tpSkill As System.Windows.Forms.TabPage
    Public WithEvents Lst_skills As System.Windows.Forms.ListBox
    Public WithEvents Cmd_ak As System.Windows.Forms.Button
    Public WithEvents Cmd_dk As System.Windows.Forms.Button
    Public WithEvents Cmd_sk As System.Windows.Forms.Button
    Friend WithEvents tpRes As System.Windows.Forms.TabPage
    Friend WithEvents tpSpell As System.Windows.Forms.TabPage
    Friend WithEvents tpPsi As System.Windows.Forms.TabPage
    Friend WithEvents tpWeap As System.Windows.Forms.TabPage
    Friend WithEvents tpItem As System.Windows.Forms.TabPage
    Friend WithEvents tpRema As System.Windows.Forms.TabPage
    Public WithEvents Lst_neg As System.Windows.Forms.ListBox
    Public WithEvents Lst_pos As System.Windows.Forms.ListBox
    Public WithEvents Cmd_dd As System.Windows.Forms.Button
    Public WithEvents Cmd_ad As System.Windows.Forms.Button
    Public WithEvents Cmd_sd As System.Windows.Forms.Button
    Public WithEvents Cmd_sa As System.Windows.Forms.Button
    Public WithEvents Cmd_da As System.Windows.Forms.Button
    Public WithEvents Cmd_aa As System.Windows.Forms.Button
    Public WithEvents Cmd_aws As System.Windows.Forms.Button
    Public WithEvents Cmd_dws As System.Windows.Forms.Button
    Public WithEvents Cmd_sws As System.Windows.Forms.Button
    Friend WithEvents clSKN As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSKO As System.Windows.Forms.ColumnHeader
    Friend WithEvents clSKA As System.Windows.Forms.ColumnHeader
    Friend WithEvents tpWesk As System.Windows.Forms.TabPage
    Friend WithEvents Lst_wsm As System.Windows.Forms.ListView
    Friend WithEvents Lst_wsr As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Lst_wst As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Public WithEvents Cmd_ap As System.Windows.Forms.Button
    Public WithEvents Cmd_dp As System.Windows.Forms.Button
    Public WithEvents Cmd_sp As System.Windows.Forms.Button
    Public WithEvents Lst_psi As System.Windows.Forms.ListBox
    Public WithEvents Lst_csk As System.Windows.Forms.ListBox
    Public WithEvents Cmd_acs As System.Windows.Forms.Button
    Public WithEvents Cmd_dcs As System.Windows.Forms.Button
    Public WithEvents Cmd_scs As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents lblambda As System.Windows.Forms.Label
    Friend WithEvents lbmi As System.Windows.Forms.Label
    Friend WithEvents lbeta As System.Windows.Forms.Label
    Friend WithEvents lbksi As System.Windows.Forms.Label
    Friend WithEvents lbfi As System.Windows.Forms.Label
    Friend WithEvents lbtau As System.Windows.Forms.Label
    Friend WithEvents lbdelta As System.Windows.Forms.Label
    Friend WithEvents lbepsilon As System.Windows.Forms.Label
    Friend WithEvents lbgamma As System.Windows.Forms.Label
    Friend WithEvents lbpsi As System.Windows.Forms.Label
    Friend WithEvents lbbeta As System.Windows.Forms.Label
    Friend WithEvents lbalfa As System.Windows.Forms.Label
    Friend WithEvents lbdzeta As System.Windows.Forms.Label
    Friend WithEvents lbtheta As System.Windows.Forms.Label
    Friend WithEvents lbkappa As System.Windows.Forms.Label
    Friend WithEvents lbomicron As System.Windows.Forms.Label
    Friend WithEvents lbsigma As System.Windows.Forms.Label
    Friend WithEvents lbomega As System.Windows.Forms.Label
    Friend WithEvents lbchi As System.Windows.Forms.Label
    Friend WithEvents lbiota As System.Windows.Forms.Label
    Friend WithEvents lbro As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Characters))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Cmd_Last = New System.Windows.Forms.Button
        Me.Cmd_Forward = New System.Windows.Forms.Button
        Me.Cmd_Back = New System.Windows.Forms.Button
        Me.Cmd_First = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Ins = New System.Windows.Forms.Button
        Me.Cmd_Del = New System.Windows.Forms.Button
        Me.Cmd_Find = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Txt_hom = New System.Windows.Forms.TextBox
        Me.Txt_pos = New System.Windows.Forms.TextBox
        Me.Txt_spow = New System.Windows.Forms.TextBox
        Me.Txt_on = New System.Windows.Forms.TextBox
        Me.Txt_his = New System.Windows.Forms.TextBox
        Me.Txt_pop = New System.Windows.Forms.TextBox
        Me.Txt_comp = New System.Windows.Forms.TextBox
        Me.Txt_mon = New System.Windows.Forms.TextBox
        Me.Txt_eptyp = New System.Windows.Forms.TextBox
        Me.Txt_sp = New System.Windows.Forms.TextBox
        Me.Txt_ep = New System.Windows.Forms.TextBox
        Me.Txt_psp = New System.Windows.Forms.TextBox
        Me.Txt_mg = New System.Windows.Forms.TextBox
        Me.Txt_hp = New System.Windows.Forms.TextBox
        Me.Txt_kra = New System.Windows.Forms.TextBox
        Me.Txt_jed = New System.Windows.Forms.TextBox
        Me.Txt_mou = New System.Windows.Forms.TextBox
        Me.Txt_IQ = New System.Windows.Forms.TextBox
        Me.Txt_podl = New System.Windows.Forms.TextBox
        Me.Txt_fodl = New System.Windows.Forms.TextBox
        Me.Txt_zru = New System.Windows.Forms.TextBox
        Me.Txt_hbi = New System.Windows.Forms.TextBox
        Me.Txt_sil = New System.Windows.Forms.TextBox
        Me.Txt_birth = New System.Windows.Forms.TextBox
        Me.Txt_weight = New System.Windows.Forms.TextBox
        Me.Txt_height = New System.Windows.Forms.TextBox
        Me.Txt_class = New System.Windows.Forms.TextBox
        Me.Txt_sex = New System.Windows.Forms.TextBox
        Me.Txt_race = New System.Windows.Forms.TextBox
        Me.Txt_titles = New System.Windows.Forms.TextBox
        Me.Txt_name = New System.Windows.Forms.TextBox
        Me.Cmd_aw = New System.Windows.Forms.Button
        Me.Cmd_dw = New System.Windows.Forms.Button
        Me.Cmd_sw = New System.Windows.Forms.Button
        Me.Lst_weap = New System.Windows.Forms.ListBox
        Me.Cmd_ai = New System.Windows.Forms.Button
        Me.Cmd_di = New System.Windows.Forms.Button
        Me.Cmd_si = New System.Windows.Forms.Button
        Me.Lst_items = New System.Windows.Forms.ListBox
        Me.Txt_Num = New System.Windows.Forms.TextBox
        Me.Lst_spells = New System.Windows.Forms.ListBox
        Me.Cmd_as = New System.Windows.Forms.Button
        Me.Cmd_ds = New System.Windows.Forms.Button
        Me.Cmd_ss = New System.Windows.Forms.Button
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
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
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tc = New System.Windows.Forms.TabControl
        Me.tpVantages = New System.Windows.Forms.TabPage
        Me.Cmd_sa = New System.Windows.Forms.Button
        Me.Cmd_da = New System.Windows.Forms.Button
        Me.Cmd_aa = New System.Windows.Forms.Button
        Me.Cmd_sd = New System.Windows.Forms.Button
        Me.Cmd_dd = New System.Windows.Forms.Button
        Me.Cmd_ad = New System.Windows.Forms.Button
        Me.Lst_pos = New System.Windows.Forms.ListBox
        Me.Lst_neg = New System.Windows.Forms.ListBox
        Me.tpPsi = New System.Windows.Forms.TabPage
        Me.Cmd_ap = New System.Windows.Forms.Button
        Me.Cmd_dp = New System.Windows.Forms.Button
        Me.Cmd_sp = New System.Windows.Forms.Button
        Me.Lst_psi = New System.Windows.Forms.ListBox
        Me.tpClaskil = New System.Windows.Forms.TabPage
        Me.Lst_csk = New System.Windows.Forms.ListBox
        Me.Cmd_acs = New System.Windows.Forms.Button
        Me.Cmd_dcs = New System.Windows.Forms.Button
        Me.Cmd_scs = New System.Windows.Forms.Button
        Me.tpWeap = New System.Windows.Forms.TabPage
        Me.tpRema = New System.Windows.Forms.TabPage
        Me.tpWesk = New System.Windows.Forms.TabPage
        Me.Lst_wst = New System.Windows.Forms.ListView
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.Lst_wsr = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.Lst_wsm = New System.Windows.Forms.ListView
        Me.clSKN = New System.Windows.Forms.ColumnHeader
        Me.clSKO = New System.Windows.Forms.ColumnHeader
        Me.clSKA = New System.Windows.Forms.ColumnHeader
        Me.Cmd_aws = New System.Windows.Forms.Button
        Me.Cmd_dws = New System.Windows.Forms.Button
        Me.Cmd_sws = New System.Windows.Forms.Button
        Me.tpSkill = New System.Windows.Forms.TabPage
        Me.Lst_skills = New System.Windows.Forms.ListBox
        Me.Cmd_ak = New System.Windows.Forms.Button
        Me.Cmd_dk = New System.Windows.Forms.Button
        Me.Cmd_sk = New System.Windows.Forms.Button
        Me.tpRes = New System.Windows.Forms.TabPage
        Me.lbro = New System.Windows.Forms.Label
        Me.Label75 = New System.Windows.Forms.Label
        Me.lblambda = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.lbmi = New System.Windows.Forms.Label
        Me.Label71 = New System.Windows.Forms.Label
        Me.lbeta = New System.Windows.Forms.Label
        Me.Label69 = New System.Windows.Forms.Label
        Me.lbksi = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me.lbfi = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.lbtau = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.lbdelta = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.lbepsilon = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.lbgamma = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.lbpsi = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.lbbeta = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.lbalfa = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.lbdzeta = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.lbtheta = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.lbkappa = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.lbomicron = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.lbsigma = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.lbomega = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lbchi = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbiota = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tpSpell = New System.Windows.Forms.TabPage
        Me.tpItem = New System.Windows.Forms.TabPage
        Me.tc.SuspendLayout()
        Me.tpVantages.SuspendLayout()
        Me.tpPsi.SuspendLayout()
        Me.tpClaskil.SuspendLayout()
        Me.tpWeap.SuspendLayout()
        Me.tpRema.SuspendLayout()
        Me.tpWesk.SuspendLayout()
        Me.tpSkill.SuspendLayout()
        Me.tpRes.SuspendLayout()
        Me.tpSpell.SuspendLayout()
        Me.tpItem.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cmd_Last
        '
        Me.Cmd_Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Last.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Last.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Last.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Last.Image = CType(resources.GetObject("Cmd_Last.Image"), System.Drawing.Image)
        Me.Cmd_Last.Location = New System.Drawing.Point(320, 600)
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
        Me.Cmd_Forward.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Forward.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Forward.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Forward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Forward.Image = CType(resources.GetObject("Cmd_Forward.Image"), System.Drawing.Image)
        Me.Cmd_Forward.Location = New System.Drawing.Point(280, 600)
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
        Me.Cmd_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Back.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Back.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Back.Image = CType(resources.GetObject("Cmd_Back.Image"), System.Drawing.Image)
        Me.Cmd_Back.Location = New System.Drawing.Point(104, 600)
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
        Me.Cmd_First.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_First.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_First.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_First.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_First.Image = CType(resources.GetObject("Cmd_First.Image"), System.Drawing.Image)
        Me.Cmd_First.Location = New System.Drawing.Point(64, 600)
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
        Me.Cmd_Exit.Location = New System.Drawing.Point(768, 584)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Exit.Size = New System.Drawing.Size(120, 64)
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
        Me.Cmd_Ins.Location = New System.Drawing.Point(456, 584)
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
        Me.Cmd_Del.Location = New System.Drawing.Point(456, 616)
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
        Me.Cmd_Find.Location = New System.Drawing.Point(624, 584)
        Me.Cmd_Find.Name = "Cmd_Find"
        Me.Cmd_Find.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Find.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Find.TabIndex = 18
        Me.Cmd_Find.Text = "NAJÍT"
        Me.ToolTip1.SetToolTip(Me.Cmd_Find, "Najít kouzlo")
        Me.Cmd_Find.UseVisualStyleBackColor = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.Cyan
        Me.Cmd_Print.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Print.Location = New System.Drawing.Point(624, 616)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Print.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Print.TabIndex = 16
        Me.Cmd_Print.Text = "TISK"
        Me.ToolTip1.SetToolTip(Me.Cmd_Print, "Tisk kouzla anebo sestavy")
        Me.Cmd_Print.UseVisualStyleBackColor = False
        '
        'Txt_hom
        '
        Me.Txt_hom.AcceptsReturn = True
        Me.Txt_hom.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_hom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_hom.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_hom.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_hom.Location = New System.Drawing.Point(64, 560)
        Me.Txt_hom.MaxLength = 0
        Me.Txt_hom.Name = "Txt_hom"
        Me.Txt_hom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_hom.Size = New System.Drawing.Size(176, 19)
        Me.Txt_hom.TabIndex = 104
        '
        'Txt_pos
        '
        Me.Txt_pos.AcceptsReturn = True
        Me.Txt_pos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_pos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_pos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_pos.Location = New System.Drawing.Point(96, 312)
        Me.Txt_pos.MaxLength = 0
        Me.Txt_pos.Multiline = True
        Me.Txt_pos.Name = "Txt_pos"
        Me.Txt_pos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_pos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_pos.Size = New System.Drawing.Size(512, 128)
        Me.Txt_pos.TabIndex = 98
        '
        'Txt_spow
        '
        Me.Txt_spow.AcceptsReturn = True
        Me.Txt_spow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_spow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_spow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_spow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_spow.Location = New System.Drawing.Point(168, 264)
        Me.Txt_spow.MaxLength = 0
        Me.Txt_spow.Multiline = True
        Me.Txt_spow.Name = "Txt_spow"
        Me.Txt_spow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_spow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_spow.Size = New System.Drawing.Size(440, 40)
        Me.Txt_spow.TabIndex = 96
        '
        'Txt_on
        '
        Me.Txt_on.AcceptsReturn = True
        Me.Txt_on.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_on.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_on.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_on.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_on.Location = New System.Drawing.Point(128, 216)
        Me.Txt_on.MaxLength = 0
        Me.Txt_on.Multiline = True
        Me.Txt_on.Name = "Txt_on"
        Me.Txt_on.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_on.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_on.Size = New System.Drawing.Size(480, 40)
        Me.Txt_on.TabIndex = 94
        '
        'Txt_his
        '
        Me.Txt_his.AcceptsReturn = True
        Me.Txt_his.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_his.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_his.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_his.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_his.Location = New System.Drawing.Point(96, 80)
        Me.Txt_his.MaxLength = 0
        Me.Txt_his.Multiline = True
        Me.Txt_his.Name = "Txt_his"
        Me.Txt_his.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_his.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_his.Size = New System.Drawing.Size(512, 128)
        Me.Txt_his.TabIndex = 92
        '
        'Txt_pop
        '
        Me.Txt_pop.AcceptsReturn = True
        Me.Txt_pop.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_pop.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_pop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pop.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_pop.Location = New System.Drawing.Point(96, 16)
        Me.Txt_pop.MaxLength = 0
        Me.Txt_pop.Multiline = True
        Me.Txt_pop.Name = "Txt_pop"
        Me.Txt_pop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_pop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_pop.Size = New System.Drawing.Size(512, 56)
        Me.Txt_pop.TabIndex = 90
        '
        'Txt_comp
        '
        Me.Txt_comp.AcceptsReturn = True
        Me.Txt_comp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_comp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_comp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_comp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_comp.Location = New System.Drawing.Point(64, 480)
        Me.Txt_comp.MaxLength = 0
        Me.Txt_comp.Multiline = True
        Me.Txt_comp.Name = "Txt_comp"
        Me.Txt_comp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_comp.Size = New System.Drawing.Size(176, 72)
        Me.Txt_comp.TabIndex = 88
        '
        'Txt_mon
        '
        Me.Txt_mon.AcceptsReturn = True
        Me.Txt_mon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_mon.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_mon.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_mon.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_mon.Location = New System.Drawing.Point(64, 456)
        Me.Txt_mon.MaxLength = 0
        Me.Txt_mon.Name = "Txt_mon"
        Me.Txt_mon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_mon.Size = New System.Drawing.Size(176, 19)
        Me.Txt_mon.TabIndex = 86
        '
        'Txt_eptyp
        '
        Me.Txt_eptyp.AcceptsReturn = True
        Me.Txt_eptyp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_eptyp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_eptyp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_eptyp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_eptyp.Location = New System.Drawing.Point(64, 360)
        Me.Txt_eptyp.MaxLength = 0
        Me.Txt_eptyp.Multiline = True
        Me.Txt_eptyp.Name = "Txt_eptyp"
        Me.Txt_eptyp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_eptyp.Size = New System.Drawing.Size(176, 80)
        Me.Txt_eptyp.TabIndex = 84
        '
        'Txt_sp
        '
        Me.Txt_sp.AcceptsReturn = True
        Me.Txt_sp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_sp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_sp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_sp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_sp.Location = New System.Drawing.Point(128, 328)
        Me.Txt_sp.MaxLength = 0
        Me.Txt_sp.Name = "Txt_sp"
        Me.Txt_sp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_sp.Size = New System.Drawing.Size(65, 19)
        Me.Txt_sp.TabIndex = 82
        '
        'Txt_ep
        '
        Me.Txt_ep.AcceptsReturn = True
        Me.Txt_ep.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_ep.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ep.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ep.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_ep.Location = New System.Drawing.Point(128, 312)
        Me.Txt_ep.MaxLength = 0
        Me.Txt_ep.Name = "Txt_ep"
        Me.Txt_ep.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_ep.Size = New System.Drawing.Size(65, 19)
        Me.Txt_ep.TabIndex = 80
        '
        'Txt_psp
        '
        Me.Txt_psp.AcceptsReturn = True
        Me.Txt_psp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_psp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_psp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_psp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_psp.Location = New System.Drawing.Point(128, 296)
        Me.Txt_psp.MaxLength = 0
        Me.Txt_psp.Name = "Txt_psp"
        Me.Txt_psp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_psp.Size = New System.Drawing.Size(65, 19)
        Me.Txt_psp.TabIndex = 78
        '
        'Txt_mg
        '
        Me.Txt_mg.AcceptsReturn = True
        Me.Txt_mg.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_mg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_mg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_mg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_mg.Location = New System.Drawing.Point(128, 280)
        Me.Txt_mg.MaxLength = 0
        Me.Txt_mg.Name = "Txt_mg"
        Me.Txt_mg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_mg.Size = New System.Drawing.Size(65, 19)
        Me.Txt_mg.TabIndex = 76
        '
        'Txt_hp
        '
        Me.Txt_hp.AcceptsReturn = True
        Me.Txt_hp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_hp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_hp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_hp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_hp.Location = New System.Drawing.Point(128, 264)
        Me.Txt_hp.MaxLength = 0
        Me.Txt_hp.Name = "Txt_hp"
        Me.Txt_hp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_hp.Size = New System.Drawing.Size(65, 19)
        Me.Txt_hp.TabIndex = 74
        '
        'Txt_kra
        '
        Me.Txt_kra.AcceptsReturn = True
        Me.Txt_kra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_kra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_kra.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_kra.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_kra.Location = New System.Drawing.Point(152, 224)
        Me.Txt_kra.MaxLength = 0
        Me.Txt_kra.Name = "Txt_kra"
        Me.Txt_kra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_kra.Size = New System.Drawing.Size(41, 19)
        Me.Txt_kra.TabIndex = 72
        '
        'Txt_jed
        '
        Me.Txt_jed.AcceptsReturn = True
        Me.Txt_jed.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_jed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_jed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_jed.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_jed.Location = New System.Drawing.Point(152, 208)
        Me.Txt_jed.MaxLength = 0
        Me.Txt_jed.Name = "Txt_jed"
        Me.Txt_jed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_jed.Size = New System.Drawing.Size(41, 19)
        Me.Txt_jed.TabIndex = 70
        '
        'Txt_mou
        '
        Me.Txt_mou.AcceptsReturn = True
        Me.Txt_mou.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_mou.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_mou.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_mou.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_mou.Location = New System.Drawing.Point(152, 192)
        Me.Txt_mou.MaxLength = 0
        Me.Txt_mou.Name = "Txt_mou"
        Me.Txt_mou.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_mou.Size = New System.Drawing.Size(41, 19)
        Me.Txt_mou.TabIndex = 68
        '
        'Txt_IQ
        '
        Me.Txt_IQ.AcceptsReturn = True
        Me.Txt_IQ.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_IQ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_IQ.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_IQ.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_IQ.Location = New System.Drawing.Point(152, 176)
        Me.Txt_IQ.MaxLength = 0
        Me.Txt_IQ.Name = "Txt_IQ"
        Me.Txt_IQ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_IQ.Size = New System.Drawing.Size(41, 19)
        Me.Txt_IQ.TabIndex = 66
        '
        'Txt_podl
        '
        Me.Txt_podl.AcceptsReturn = True
        Me.Txt_podl.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_podl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_podl.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_podl.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_podl.Location = New System.Drawing.Point(152, 160)
        Me.Txt_podl.MaxLength = 0
        Me.Txt_podl.Name = "Txt_podl"
        Me.Txt_podl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_podl.Size = New System.Drawing.Size(41, 19)
        Me.Txt_podl.TabIndex = 64
        '
        'Txt_fodl
        '
        Me.Txt_fodl.AcceptsReturn = True
        Me.Txt_fodl.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_fodl.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_fodl.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_fodl.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_fodl.Location = New System.Drawing.Point(152, 144)
        Me.Txt_fodl.MaxLength = 0
        Me.Txt_fodl.Name = "Txt_fodl"
        Me.Txt_fodl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_fodl.Size = New System.Drawing.Size(41, 19)
        Me.Txt_fodl.TabIndex = 62
        '
        'Txt_zru
        '
        Me.Txt_zru.AcceptsReturn = True
        Me.Txt_zru.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_zru.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_zru.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_zru.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_zru.Location = New System.Drawing.Point(152, 128)
        Me.Txt_zru.MaxLength = 0
        Me.Txt_zru.Name = "Txt_zru"
        Me.Txt_zru.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_zru.Size = New System.Drawing.Size(41, 19)
        Me.Txt_zru.TabIndex = 60
        '
        'Txt_hbi
        '
        Me.Txt_hbi.AcceptsReturn = True
        Me.Txt_hbi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_hbi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_hbi.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_hbi.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_hbi.Location = New System.Drawing.Point(152, 112)
        Me.Txt_hbi.MaxLength = 0
        Me.Txt_hbi.Name = "Txt_hbi"
        Me.Txt_hbi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_hbi.Size = New System.Drawing.Size(41, 19)
        Me.Txt_hbi.TabIndex = 58
        '
        'Txt_sil
        '
        Me.Txt_sil.AcceptsReturn = True
        Me.Txt_sil.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_sil.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_sil.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_sil.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_sil.Location = New System.Drawing.Point(152, 96)
        Me.Txt_sil.MaxLength = 0
        Me.Txt_sil.Name = "Txt_sil"
        Me.Txt_sil.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_sil.Size = New System.Drawing.Size(41, 19)
        Me.Txt_sil.TabIndex = 56
        '
        'Txt_birth
        '
        Me.Txt_birth.AcceptsReturn = True
        Me.Txt_birth.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_birth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_birth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_birth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_birth.Location = New System.Drawing.Point(712, 40)
        Me.Txt_birth.MaxLength = 0
        Me.Txt_birth.Name = "Txt_birth"
        Me.Txt_birth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_birth.Size = New System.Drawing.Size(121, 19)
        Me.Txt_birth.TabIndex = 54
        '
        'Txt_weight
        '
        Me.Txt_weight.AcceptsReturn = True
        Me.Txt_weight.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_weight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_weight.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_weight.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_weight.Location = New System.Drawing.Point(504, 40)
        Me.Txt_weight.MaxLength = 0
        Me.Txt_weight.Name = "Txt_weight"
        Me.Txt_weight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_weight.Size = New System.Drawing.Size(81, 19)
        Me.Txt_weight.TabIndex = 50
        '
        'Txt_height
        '
        Me.Txt_height.AcceptsReturn = True
        Me.Txt_height.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_height.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_height.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_height.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_height.Location = New System.Drawing.Point(360, 40)
        Me.Txt_height.MaxLength = 0
        Me.Txt_height.Name = "Txt_height"
        Me.Txt_height.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_height.Size = New System.Drawing.Size(89, 19)
        Me.Txt_height.TabIndex = 48
        '
        'Txt_class
        '
        Me.Txt_class.AcceptsReturn = True
        Me.Txt_class.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_class.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_class.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_class.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_class.Location = New System.Drawing.Point(136, 64)
        Me.Txt_class.MaxLength = 0
        Me.Txt_class.Name = "Txt_class"
        Me.Txt_class.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_class.Size = New System.Drawing.Size(744, 19)
        Me.Txt_class.TabIndex = 46
        '
        'Txt_sex
        '
        Me.Txt_sex.AcceptsReturn = True
        Me.Txt_sex.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_sex.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_sex.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_sex.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_sex.Location = New System.Drawing.Point(240, 40)
        Me.Txt_sex.MaxLength = 0
        Me.Txt_sex.Name = "Txt_sex"
        Me.Txt_sex.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_sex.Size = New System.Drawing.Size(57, 19)
        Me.Txt_sex.TabIndex = 44
        '
        'Txt_race
        '
        Me.Txt_race.AcceptsReturn = True
        Me.Txt_race.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_race.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_race.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_race.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_race.Location = New System.Drawing.Point(72, 40)
        Me.Txt_race.MaxLength = 0
        Me.Txt_race.Name = "Txt_race"
        Me.Txt_race.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_race.Size = New System.Drawing.Size(97, 19)
        Me.Txt_race.TabIndex = 42
        '
        'Txt_titles
        '
        Me.Txt_titles.AcceptsReturn = True
        Me.Txt_titles.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_titles.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_titles.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_titles.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_titles.Location = New System.Drawing.Point(504, 8)
        Me.Txt_titles.MaxLength = 0
        Me.Txt_titles.Name = "Txt_titles"
        Me.Txt_titles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_titles.Size = New System.Drawing.Size(385, 19)
        Me.Txt_titles.TabIndex = 40
        '
        'Txt_name
        '
        Me.Txt_name.AcceptsReturn = True
        Me.Txt_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_name.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_name.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_name.Location = New System.Drawing.Point(72, 8)
        Me.Txt_name.MaxLength = 0
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_name.Size = New System.Drawing.Size(377, 19)
        Me.Txt_name.TabIndex = 38
        '
        'Cmd_aw
        '
        Me.Cmd_aw.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_aw.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_aw.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_aw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_aw.Image = CType(resources.GetObject("Cmd_aw.Image"), System.Drawing.Image)
        Me.Cmd_aw.Location = New System.Drawing.Point(280, 24)
        Me.Cmd_aw.Name = "Cmd_aw"
        Me.Cmd_aw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_aw.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_aw.TabIndex = 36
        Me.Cmd_aw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_aw.UseVisualStyleBackColor = False
        '
        'Cmd_dw
        '
        Me.Cmd_dw.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_dw.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_dw.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_dw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_dw.Image = CType(resources.GetObject("Cmd_dw.Image"), System.Drawing.Image)
        Me.Cmd_dw.Location = New System.Drawing.Point(280, 96)
        Me.Cmd_dw.Name = "Cmd_dw"
        Me.Cmd_dw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_dw.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_dw.TabIndex = 35
        Me.Cmd_dw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_dw.UseVisualStyleBackColor = False
        '
        'Cmd_sw
        '
        Me.Cmd_sw.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_sw.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_sw.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_sw.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_sw.Image = CType(resources.GetObject("Cmd_sw.Image"), System.Drawing.Image)
        Me.Cmd_sw.Location = New System.Drawing.Point(280, 168)
        Me.Cmd_sw.Name = "Cmd_sw"
        Me.Cmd_sw.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_sw.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_sw.TabIndex = 34
        Me.Cmd_sw.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_sw.UseVisualStyleBackColor = False
        '
        'Lst_weap
        '
        Me.Lst_weap.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lst_weap.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_weap.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_weap.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Lst_weap.ItemHeight = 14
        Me.Lst_weap.Location = New System.Drawing.Point(16, 16)
        Me.Lst_weap.Name = "Lst_weap"
        Me.Lst_weap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_weap.Size = New System.Drawing.Size(216, 424)
        Me.Lst_weap.TabIndex = 32
        '
        'Cmd_ai
        '
        Me.Cmd_ai.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_ai.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ai.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ai.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ai.Image = CType(resources.GetObject("Cmd_ai.Image"), System.Drawing.Image)
        Me.Cmd_ai.Location = New System.Drawing.Point(304, 32)
        Me.Cmd_ai.Name = "Cmd_ai"
        Me.Cmd_ai.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ai.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_ai.TabIndex = 31
        Me.Cmd_ai.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_ai.UseVisualStyleBackColor = False
        '
        'Cmd_di
        '
        Me.Cmd_di.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_di.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_di.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_di.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_di.Image = CType(resources.GetObject("Cmd_di.Image"), System.Drawing.Image)
        Me.Cmd_di.Location = New System.Drawing.Point(304, 104)
        Me.Cmd_di.Name = "Cmd_di"
        Me.Cmd_di.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_di.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_di.TabIndex = 30
        Me.Cmd_di.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_di.UseVisualStyleBackColor = False
        '
        'Cmd_si
        '
        Me.Cmd_si.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_si.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_si.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_si.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_si.Image = CType(resources.GetObject("Cmd_si.Image"), System.Drawing.Image)
        Me.Cmd_si.Location = New System.Drawing.Point(304, 176)
        Me.Cmd_si.Name = "Cmd_si"
        Me.Cmd_si.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_si.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_si.TabIndex = 29
        Me.Cmd_si.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_si.UseVisualStyleBackColor = False
        '
        'Lst_items
        '
        Me.Lst_items.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Lst_items.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_items.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_items.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Lst_items.ItemHeight = 14
        Me.Lst_items.Location = New System.Drawing.Point(24, 16)
        Me.Lst_items.Name = "Lst_items"
        Me.Lst_items.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_items.Size = New System.Drawing.Size(256, 424)
        Me.Lst_items.TabIndex = 27
        '
        'Txt_Num
        '
        Me.Txt_Num.AcceptsReturn = True
        Me.Txt_Num.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_Num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Num.Font = New System.Drawing.Font("Arial", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Location = New System.Drawing.Point(144, 600)
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
        Me.Lst_spells.Location = New System.Drawing.Point(24, 16)
        Me.Lst_spells.Name = "Lst_spells"
        Me.Lst_spells.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_spells.Size = New System.Drawing.Size(256, 410)
        Me.Lst_spells.TabIndex = 11
        '
        'Cmd_as
        '
        Me.Cmd_as.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_as.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_as.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_as.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_as.Image = CType(resources.GetObject("Cmd_as.Image"), System.Drawing.Image)
        Me.Cmd_as.Location = New System.Drawing.Point(312, 120)
        Me.Cmd_as.Name = "Cmd_as"
        Me.Cmd_as.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_as.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_as.TabIndex = 8
        Me.Cmd_as.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_as.UseVisualStyleBackColor = False
        '
        'Cmd_ds
        '
        Me.Cmd_ds.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_ds.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ds.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ds.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ds.Image = CType(resources.GetObject("Cmd_ds.Image"), System.Drawing.Image)
        Me.Cmd_ds.Location = New System.Drawing.Point(312, 184)
        Me.Cmd_ds.Name = "Cmd_ds"
        Me.Cmd_ds.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ds.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_ds.TabIndex = 7
        Me.Cmd_ds.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_ds.UseVisualStyleBackColor = False
        '
        'Cmd_ss
        '
        Me.Cmd_ss.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_ss.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ss.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ss.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ss.Image = CType(resources.GetObject("Cmd_ss.Image"), System.Drawing.Image)
        Me.Cmd_ss.Location = New System.Drawing.Point(312, 256)
        Me.Cmd_ss.Name = "Cmd_ss"
        Me.Cmd_ss.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ss.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_ss.TabIndex = 2
        Me.Cmd_ss.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_ss.UseVisualStyleBackColor = False
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label39.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label39.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label39.Location = New System.Drawing.Point(8, 560)
        Me.Label39.Name = "Label39"
        Me.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label39.Size = New System.Drawing.Size(56, 17)
        Me.Label39.TabIndex = 103
        Me.Label39.Text = "Domov"
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label38.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label38.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(120, 24)
        Me.Label38.Name = "Label38"
        Me.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label38.Size = New System.Drawing.Size(65, 17)
        Me.Label38.TabIndex = 101
        Me.Label38.Text = "Negativa"
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label37.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label37.Location = New System.Drawing.Point(440, 24)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(57, 17)
        Me.Label37.TabIndex = 99
        Me.Label37.Text = "Pozitiva"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label36.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(24, 312)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(56, 24)
        Me.Label36.TabIndex = 97
        Me.Label36.Text = "Majetek"
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label35.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(24, 264)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(145, 24)
        Me.Label35.TabIndex = 95
        Me.Label35.Text = "Speciální schopnosti"
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label34.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label34.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label34.Location = New System.Drawing.Point(24, 216)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(97, 24)
        Me.Label34.TabIndex = 93
        Me.Label34.Text = "Do budoucna"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(24, 80)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(57, 24)
        Me.Label33.TabIndex = 91
        Me.Label33.Text = "Historie"
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(24, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(49, 17)
        Me.Label32.TabIndex = 89
        Me.Label32.Text = "Popis"
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(8, 480)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(57, 17)
        Me.Label31.TabIndex = 87
        Me.Label31.Text = "Složení"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(8, 456)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(49, 17)
        Me.Label30.TabIndex = 85
        Me.Label30.Text = "Peníze"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(8, 360)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(81, 17)
        Me.Label29.TabIndex = 83
        Me.Label29.Text = "Typy EP"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(8, 328)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(89, 17)
        Me.Label28.TabIndex = 81
        Me.Label28.Text = "SP"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(8, 312)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(97, 17)
        Me.Label27.TabIndex = 79
        Me.Label27.Text = "EP"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(8, 296)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(105, 17)
        Me.Label26.TabIndex = 77
        Me.Label26.Text = "PSP"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(8, 280)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(89, 17)
        Me.Label25.TabIndex = 75
        Me.Label25.Text = "Magy"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(8, 264)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(89, 17)
        Me.Label24.TabIndex = 73
        Me.Label24.Text = "Životy"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(8, 224)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(105, 17)
        Me.Label23.TabIndex = 71
        Me.Label23.Text = "Krása"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(8, 208)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(97, 17)
        Me.Label22.TabIndex = 69
        Me.Label22.Text = "Jednání"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(8, 192)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(81, 17)
        Me.Label21.TabIndex = 67
        Me.Label21.Text = "Moudrost"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(8, 176)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(49, 17)
        Me.Label20.TabIndex = 65
        Me.Label20.Text = "IQ"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(8, 160)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(137, 17)
        Me.Label19.TabIndex = 63
        Me.Label19.Text = "Psychická odolnost"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(8, 144)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(121, 17)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "Fyzická odolnost"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(8, 128)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(65, 17)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Zručnost"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(8, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(57, 17)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Hbitost"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(8, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(49, 17)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Síla"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(592, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(113, 17)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Datum narození"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(456, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(41, 17)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Váha"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(304, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(49, 17)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Výška"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(8, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(120, 17)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Povolání a úrovně"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(176, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(57, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Pohlaví"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Rasa"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(456, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Tituly"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(64, 25)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Jméno"
        '
        'tc
        '
        Me.tc.Controls.Add(Me.tpVantages)
        Me.tc.Controls.Add(Me.tpPsi)
        Me.tc.Controls.Add(Me.tpClaskil)
        Me.tc.Controls.Add(Me.tpWeap)
        Me.tc.Controls.Add(Me.tpRema)
        Me.tc.Controls.Add(Me.tpWesk)
        Me.tc.Controls.Add(Me.tpSkill)
        Me.tc.Controls.Add(Me.tpRes)
        Me.tc.Controls.Add(Me.tpSpell)
        Me.tc.Controls.Add(Me.tpItem)
        Me.tc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tc.Location = New System.Drawing.Point(256, 96)
        Me.tc.Name = "tc"
        Me.tc.SelectedIndex = 0
        Me.tc.Size = New System.Drawing.Size(632, 480)
        Me.tc.TabIndex = 105
        '
        'tpVantages
        '
        Me.tpVantages.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpVantages.Controls.Add(Me.Cmd_sa)
        Me.tpVantages.Controls.Add(Me.Cmd_da)
        Me.tpVantages.Controls.Add(Me.Cmd_aa)
        Me.tpVantages.Controls.Add(Me.Cmd_sd)
        Me.tpVantages.Controls.Add(Me.Cmd_dd)
        Me.tpVantages.Controls.Add(Me.Cmd_ad)
        Me.tpVantages.Controls.Add(Me.Lst_pos)
        Me.tpVantages.Controls.Add(Me.Label38)
        Me.tpVantages.Controls.Add(Me.Label37)
        Me.tpVantages.Controls.Add(Me.Lst_neg)
        Me.tpVantages.Location = New System.Drawing.Point(4, 24)
        Me.tpVantages.Name = "tpVantages"
        Me.tpVantages.Size = New System.Drawing.Size(624, 452)
        Me.tpVantages.TabIndex = 0
        Me.tpVantages.Text = "Pozitiva negativa"
        '
        'Cmd_sa
        '
        Me.Cmd_sa.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_sa.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_sa.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_sa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_sa.Image = CType(resources.GetObject("Cmd_sa.Image"), System.Drawing.Image)
        Me.Cmd_sa.Location = New System.Drawing.Point(512, 408)
        Me.Cmd_sa.Name = "Cmd_sa"
        Me.Cmd_sa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_sa.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_sa.TabIndex = 111
        Me.Cmd_sa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_sa.UseVisualStyleBackColor = False
        '
        'Cmd_da
        '
        Me.Cmd_da.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_da.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_da.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_da.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_da.Image = CType(resources.GetObject("Cmd_da.Image"), System.Drawing.Image)
        Me.Cmd_da.Location = New System.Drawing.Point(448, 408)
        Me.Cmd_da.Name = "Cmd_da"
        Me.Cmd_da.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_da.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_da.TabIndex = 112
        Me.Cmd_da.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_da.UseVisualStyleBackColor = False
        '
        'Cmd_aa
        '
        Me.Cmd_aa.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_aa.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_aa.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_aa.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_aa.Image = CType(resources.GetObject("Cmd_aa.Image"), System.Drawing.Image)
        Me.Cmd_aa.Location = New System.Drawing.Point(384, 408)
        Me.Cmd_aa.Name = "Cmd_aa"
        Me.Cmd_aa.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_aa.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_aa.TabIndex = 113
        Me.Cmd_aa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_aa.UseVisualStyleBackColor = False
        '
        'Cmd_sd
        '
        Me.Cmd_sd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_sd.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_sd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_sd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_sd.Image = CType(resources.GetObject("Cmd_sd.Image"), System.Drawing.Image)
        Me.Cmd_sd.Location = New System.Drawing.Point(208, 408)
        Me.Cmd_sd.Name = "Cmd_sd"
        Me.Cmd_sd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_sd.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_sd.TabIndex = 108
        Me.Cmd_sd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_sd.UseVisualStyleBackColor = False
        '
        'Cmd_dd
        '
        Me.Cmd_dd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_dd.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_dd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_dd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_dd.Image = CType(resources.GetObject("Cmd_dd.Image"), System.Drawing.Image)
        Me.Cmd_dd.Location = New System.Drawing.Point(144, 408)
        Me.Cmd_dd.Name = "Cmd_dd"
        Me.Cmd_dd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_dd.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_dd.TabIndex = 109
        Me.Cmd_dd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_dd.UseVisualStyleBackColor = False
        '
        'Cmd_ad
        '
        Me.Cmd_ad.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_ad.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ad.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ad.Image = CType(resources.GetObject("Cmd_ad.Image"), System.Drawing.Image)
        Me.Cmd_ad.Location = New System.Drawing.Point(80, 408)
        Me.Cmd_ad.Name = "Cmd_ad"
        Me.Cmd_ad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ad.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_ad.TabIndex = 110
        Me.Cmd_ad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_ad.UseVisualStyleBackColor = False
        '
        'Lst_pos
        '
        Me.Lst_pos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lst_pos.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_pos.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_pos.ForeColor = System.Drawing.Color.Black
        Me.Lst_pos.ItemHeight = 14
        Me.Lst_pos.Location = New System.Drawing.Point(336, 48)
        Me.Lst_pos.Name = "Lst_pos"
        Me.Lst_pos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_pos.Size = New System.Drawing.Size(256, 354)
        Me.Lst_pos.TabIndex = 107
        '
        'Lst_neg
        '
        Me.Lst_neg.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lst_neg.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_neg.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_neg.ForeColor = System.Drawing.Color.Black
        Me.Lst_neg.ItemHeight = 14
        Me.Lst_neg.Location = New System.Drawing.Point(32, 48)
        Me.Lst_neg.Name = "Lst_neg"
        Me.Lst_neg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_neg.Size = New System.Drawing.Size(256, 354)
        Me.Lst_neg.TabIndex = 106
        '
        'tpPsi
        '
        Me.tpPsi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpPsi.Controls.Add(Me.Cmd_ap)
        Me.tpPsi.Controls.Add(Me.Cmd_dp)
        Me.tpPsi.Controls.Add(Me.Cmd_sp)
        Me.tpPsi.Controls.Add(Me.Lst_psi)
        Me.tpPsi.Location = New System.Drawing.Point(4, 24)
        Me.tpPsi.Name = "tpPsi"
        Me.tpPsi.Size = New System.Drawing.Size(624, 452)
        Me.tpPsi.TabIndex = 5
        Me.tpPsi.Text = "Psionika"
        '
        'Cmd_ap
        '
        Me.Cmd_ap.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_ap.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ap.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ap.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ap.Image = CType(resources.GetObject("Cmd_ap.Image"), System.Drawing.Image)
        Me.Cmd_ap.Location = New System.Drawing.Point(304, 32)
        Me.Cmd_ap.Name = "Cmd_ap"
        Me.Cmd_ap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ap.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_ap.TabIndex = 35
        Me.Cmd_ap.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_ap.UseVisualStyleBackColor = False
        '
        'Cmd_dp
        '
        Me.Cmd_dp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_dp.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_dp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_dp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_dp.Image = CType(resources.GetObject("Cmd_dp.Image"), System.Drawing.Image)
        Me.Cmd_dp.Location = New System.Drawing.Point(304, 104)
        Me.Cmd_dp.Name = "Cmd_dp"
        Me.Cmd_dp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_dp.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_dp.TabIndex = 34
        Me.Cmd_dp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_dp.UseVisualStyleBackColor = False
        '
        'Cmd_sp
        '
        Me.Cmd_sp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_sp.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_sp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_sp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_sp.Image = CType(resources.GetObject("Cmd_sp.Image"), System.Drawing.Image)
        Me.Cmd_sp.Location = New System.Drawing.Point(304, 176)
        Me.Cmd_sp.Name = "Cmd_sp"
        Me.Cmd_sp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_sp.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_sp.TabIndex = 33
        Me.Cmd_sp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_sp.UseVisualStyleBackColor = False
        '
        'Lst_psi
        '
        Me.Lst_psi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Lst_psi.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_psi.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_psi.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Lst_psi.ItemHeight = 14
        Me.Lst_psi.Location = New System.Drawing.Point(24, 16)
        Me.Lst_psi.Name = "Lst_psi"
        Me.Lst_psi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_psi.Size = New System.Drawing.Size(256, 424)
        Me.Lst_psi.TabIndex = 32
        '
        'tpClaskil
        '
        Me.tpClaskil.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpClaskil.Controls.Add(Me.Lst_csk)
        Me.tpClaskil.Controls.Add(Me.Cmd_acs)
        Me.tpClaskil.Controls.Add(Me.Cmd_dcs)
        Me.tpClaskil.Controls.Add(Me.Cmd_scs)
        Me.tpClaskil.Location = New System.Drawing.Point(4, 24)
        Me.tpClaskil.Name = "tpClaskil"
        Me.tpClaskil.Size = New System.Drawing.Size(624, 452)
        Me.tpClaskil.TabIndex = 1
        Me.tpClaskil.Text = "Skilly povolání"
        '
        'Lst_csk
        '
        Me.Lst_csk.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lst_csk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_csk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_csk.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Lst_csk.ItemHeight = 14
        Me.Lst_csk.Location = New System.Drawing.Point(24, 16)
        Me.Lst_csk.Name = "Lst_csk"
        Me.Lst_csk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_csk.Size = New System.Drawing.Size(256, 424)
        Me.Lst_csk.TabIndex = 21
        '
        'Cmd_acs
        '
        Me.Cmd_acs.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_acs.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_acs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_acs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_acs.Image = CType(resources.GetObject("Cmd_acs.Image"), System.Drawing.Image)
        Me.Cmd_acs.Location = New System.Drawing.Point(328, 104)
        Me.Cmd_acs.Name = "Cmd_acs"
        Me.Cmd_acs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_acs.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_acs.TabIndex = 20
        Me.Cmd_acs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_acs.UseVisualStyleBackColor = False
        '
        'Cmd_dcs
        '
        Me.Cmd_dcs.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_dcs.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_dcs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_dcs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_dcs.Image = CType(resources.GetObject("Cmd_dcs.Image"), System.Drawing.Image)
        Me.Cmd_dcs.Location = New System.Drawing.Point(328, 176)
        Me.Cmd_dcs.Name = "Cmd_dcs"
        Me.Cmd_dcs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_dcs.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_dcs.TabIndex = 19
        Me.Cmd_dcs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_dcs.UseVisualStyleBackColor = False
        '
        'Cmd_scs
        '
        Me.Cmd_scs.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_scs.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_scs.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_scs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_scs.Image = CType(resources.GetObject("Cmd_scs.Image"), System.Drawing.Image)
        Me.Cmd_scs.Location = New System.Drawing.Point(328, 248)
        Me.Cmd_scs.Name = "Cmd_scs"
        Me.Cmd_scs.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_scs.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_scs.TabIndex = 18
        Me.Cmd_scs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_scs.UseVisualStyleBackColor = False
        '
        'tpWeap
        '
        Me.tpWeap.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpWeap.Controls.Add(Me.Lst_weap)
        Me.tpWeap.Controls.Add(Me.Cmd_aw)
        Me.tpWeap.Controls.Add(Me.Cmd_dw)
        Me.tpWeap.Controls.Add(Me.Cmd_sw)
        Me.tpWeap.Location = New System.Drawing.Point(4, 24)
        Me.tpWeap.Name = "tpWeap"
        Me.tpWeap.Size = New System.Drawing.Size(624, 452)
        Me.tpWeap.TabIndex = 7
        Me.tpWeap.Text = "Zbraně"
        '
        'tpRema
        '
        Me.tpRema.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpRema.Controls.Add(Me.Label32)
        Me.tpRema.Controls.Add(Me.Txt_pop)
        Me.tpRema.Controls.Add(Me.Txt_his)
        Me.tpRema.Controls.Add(Me.Label34)
        Me.tpRema.Controls.Add(Me.Label33)
        Me.tpRema.Controls.Add(Me.Txt_on)
        Me.tpRema.Controls.Add(Me.Label36)
        Me.tpRema.Controls.Add(Me.Label35)
        Me.tpRema.Controls.Add(Me.Txt_spow)
        Me.tpRema.Controls.Add(Me.Txt_pos)
        Me.tpRema.Location = New System.Drawing.Point(4, 24)
        Me.tpRema.Name = "tpRema"
        Me.tpRema.Size = New System.Drawing.Size(624, 452)
        Me.tpRema.TabIndex = 9
        Me.tpRema.Text = "Poznámky"
        '
        'tpWesk
        '
        Me.tpWesk.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpWesk.Controls.Add(Me.Lst_wst)
        Me.tpWesk.Controls.Add(Me.Lst_wsr)
        Me.tpWesk.Controls.Add(Me.Lst_wsm)
        Me.tpWesk.Controls.Add(Me.Cmd_aws)
        Me.tpWesk.Controls.Add(Me.Cmd_dws)
        Me.tpWesk.Controls.Add(Me.Cmd_sws)
        Me.tpWesk.Location = New System.Drawing.Point(4, 24)
        Me.tpWesk.Name = "tpWesk"
        Me.tpWesk.Size = New System.Drawing.Size(624, 452)
        Me.tpWesk.TabIndex = 6
        Me.tpWesk.Text = "Zbraňové skilly"
        '
        'Lst_wst
        '
        Me.Lst_wst.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lst_wst.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.Lst_wst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lst_wst.ForeColor = System.Drawing.Color.Black
        Me.Lst_wst.FullRowSelect = True
        Me.Lst_wst.GridLines = True
        Me.Lst_wst.Location = New System.Drawing.Point(416, 16)
        Me.Lst_wst.Name = "Lst_wst"
        Me.Lst_wst.Size = New System.Drawing.Size(192, 368)
        Me.Lst_wst.TabIndex = 43
        Me.Lst_wst.UseCompatibleStateImageBehavior = False
        Me.Lst_wst.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "SKILL"
        Me.ColumnHeader4.Width = 130
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "L"
        Me.ColumnHeader5.Width = 30
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "E"
        Me.ColumnHeader6.Width = 30
        '
        'Lst_wsr
        '
        Me.Lst_wsr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lst_wsr.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.Lst_wsr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lst_wsr.ForeColor = System.Drawing.Color.Black
        Me.Lst_wsr.FullRowSelect = True
        Me.Lst_wsr.GridLines = True
        Me.Lst_wsr.Location = New System.Drawing.Point(216, 16)
        Me.Lst_wsr.Name = "Lst_wsr"
        Me.Lst_wsr.Size = New System.Drawing.Size(192, 368)
        Me.Lst_wsr.TabIndex = 42
        Me.Lst_wsr.UseCompatibleStateImageBehavior = False
        Me.Lst_wsr.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SKILL"
        Me.ColumnHeader1.Width = 130
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "L"
        Me.ColumnHeader2.Width = 30
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "E"
        Me.ColumnHeader3.Width = 30
        '
        'Lst_wsm
        '
        Me.Lst_wsm.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.Lst_wsm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lst_wsm.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clSKN, Me.clSKO, Me.clSKA})
        Me.Lst_wsm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lst_wsm.ForeColor = System.Drawing.Color.Black
        Me.Lst_wsm.FullRowSelect = True
        Me.Lst_wsm.GridLines = True
        Me.Lst_wsm.Location = New System.Drawing.Point(16, 16)
        Me.Lst_wsm.Name = "Lst_wsm"
        Me.Lst_wsm.Size = New System.Drawing.Size(192, 416)
        Me.Lst_wsm.TabIndex = 41
        Me.Lst_wsm.UseCompatibleStateImageBehavior = False
        Me.Lst_wsm.View = System.Windows.Forms.View.Details
        '
        'clSKN
        '
        Me.clSKN.Text = "SKILL"
        Me.clSKN.Width = 130
        '
        'clSKO
        '
        Me.clSKO.Text = "L"
        Me.clSKO.Width = 30
        '
        'clSKA
        '
        Me.clSKA.Text = "E"
        Me.clSKA.Width = 30
        '
        'Cmd_aws
        '
        Me.Cmd_aws.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_aws.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_aws.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_aws.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_aws.Image = CType(resources.GetObject("Cmd_aws.Image"), System.Drawing.Image)
        Me.Cmd_aws.Location = New System.Drawing.Point(256, 400)
        Me.Cmd_aws.Name = "Cmd_aws"
        Me.Cmd_aws.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_aws.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_aws.TabIndex = 40
        Me.Cmd_aws.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_aws.UseVisualStyleBackColor = False
        '
        'Cmd_dws
        '
        Me.Cmd_dws.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_dws.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_dws.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_dws.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_dws.Image = CType(resources.GetObject("Cmd_dws.Image"), System.Drawing.Image)
        Me.Cmd_dws.Location = New System.Drawing.Point(328, 400)
        Me.Cmd_dws.Name = "Cmd_dws"
        Me.Cmd_dws.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_dws.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_dws.TabIndex = 39
        Me.Cmd_dws.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_dws.UseVisualStyleBackColor = False
        '
        'Cmd_sws
        '
        Me.Cmd_sws.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_sws.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_sws.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_sws.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_sws.Image = CType(resources.GetObject("Cmd_sws.Image"), System.Drawing.Image)
        Me.Cmd_sws.Location = New System.Drawing.Point(400, 400)
        Me.Cmd_sws.Name = "Cmd_sws"
        Me.Cmd_sws.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_sws.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_sws.TabIndex = 38
        Me.Cmd_sws.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_sws.UseVisualStyleBackColor = False
        '
        'tpSkill
        '
        Me.tpSkill.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpSkill.Controls.Add(Me.Lst_skills)
        Me.tpSkill.Controls.Add(Me.Cmd_ak)
        Me.tpSkill.Controls.Add(Me.Cmd_dk)
        Me.tpSkill.Controls.Add(Me.Cmd_sk)
        Me.tpSkill.Location = New System.Drawing.Point(4, 24)
        Me.tpSkill.Name = "tpSkill"
        Me.tpSkill.Size = New System.Drawing.Size(624, 452)
        Me.tpSkill.TabIndex = 2
        Me.tpSkill.Text = "Obecné skilly"
        '
        'Lst_skills
        '
        Me.Lst_skills.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lst_skills.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_skills.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_skills.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Lst_skills.ItemHeight = 14
        Me.Lst_skills.Location = New System.Drawing.Point(24, 16)
        Me.Lst_skills.Name = "Lst_skills"
        Me.Lst_skills.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_skills.Size = New System.Drawing.Size(256, 424)
        Me.Lst_skills.TabIndex = 17
        '
        'Cmd_ak
        '
        Me.Cmd_ak.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_ak.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ak.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ak.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ak.Image = CType(resources.GetObject("Cmd_ak.Image"), System.Drawing.Image)
        Me.Cmd_ak.Location = New System.Drawing.Point(328, 104)
        Me.Cmd_ak.Name = "Cmd_ak"
        Me.Cmd_ak.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ak.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_ak.TabIndex = 16
        Me.Cmd_ak.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_ak.UseVisualStyleBackColor = False
        '
        'Cmd_dk
        '
        Me.Cmd_dk.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_dk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_dk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_dk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_dk.Image = CType(resources.GetObject("Cmd_dk.Image"), System.Drawing.Image)
        Me.Cmd_dk.Location = New System.Drawing.Point(328, 176)
        Me.Cmd_dk.Name = "Cmd_dk"
        Me.Cmd_dk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_dk.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_dk.TabIndex = 15
        Me.Cmd_dk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_dk.UseVisualStyleBackColor = False
        '
        'Cmd_sk
        '
        Me.Cmd_sk.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_sk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_sk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_sk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_sk.Image = CType(resources.GetObject("Cmd_sk.Image"), System.Drawing.Image)
        Me.Cmd_sk.Location = New System.Drawing.Point(328, 248)
        Me.Cmd_sk.Name = "Cmd_sk"
        Me.Cmd_sk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_sk.Size = New System.Drawing.Size(32, 32)
        Me.Cmd_sk.TabIndex = 14
        Me.Cmd_sk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_sk.UseVisualStyleBackColor = False
        '
        'tpRes
        '
        Me.tpRes.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpRes.Controls.Add(Me.lbro)
        Me.tpRes.Controls.Add(Me.Label75)
        Me.tpRes.Controls.Add(Me.lblambda)
        Me.tpRes.Controls.Add(Me.Label73)
        Me.tpRes.Controls.Add(Me.lbmi)
        Me.tpRes.Controls.Add(Me.Label71)
        Me.tpRes.Controls.Add(Me.lbeta)
        Me.tpRes.Controls.Add(Me.Label69)
        Me.tpRes.Controls.Add(Me.lbksi)
        Me.tpRes.Controls.Add(Me.Label67)
        Me.tpRes.Controls.Add(Me.lbfi)
        Me.tpRes.Controls.Add(Me.Label65)
        Me.tpRes.Controls.Add(Me.lbtau)
        Me.tpRes.Controls.Add(Me.Label63)
        Me.tpRes.Controls.Add(Me.lbdelta)
        Me.tpRes.Controls.Add(Me.Label61)
        Me.tpRes.Controls.Add(Me.lbepsilon)
        Me.tpRes.Controls.Add(Me.Label59)
        Me.tpRes.Controls.Add(Me.lbgamma)
        Me.tpRes.Controls.Add(Me.Label57)
        Me.tpRes.Controls.Add(Me.lbpsi)
        Me.tpRes.Controls.Add(Me.Label55)
        Me.tpRes.Controls.Add(Me.lbbeta)
        Me.tpRes.Controls.Add(Me.Label53)
        Me.tpRes.Controls.Add(Me.lbalfa)
        Me.tpRes.Controls.Add(Me.Label51)
        Me.tpRes.Controls.Add(Me.lbdzeta)
        Me.tpRes.Controls.Add(Me.Label49)
        Me.tpRes.Controls.Add(Me.lbtheta)
        Me.tpRes.Controls.Add(Me.Label47)
        Me.tpRes.Controls.Add(Me.lbkappa)
        Me.tpRes.Controls.Add(Me.Label45)
        Me.tpRes.Controls.Add(Me.lbomicron)
        Me.tpRes.Controls.Add(Me.Label43)
        Me.tpRes.Controls.Add(Me.lbsigma)
        Me.tpRes.Controls.Add(Me.Label41)
        Me.tpRes.Controls.Add(Me.lbomega)
        Me.tpRes.Controls.Add(Me.Label13)
        Me.tpRes.Controls.Add(Me.lbchi)
        Me.tpRes.Controls.Add(Me.Label9)
        Me.tpRes.Controls.Add(Me.lbiota)
        Me.tpRes.Controls.Add(Me.Label1)
        Me.tpRes.Location = New System.Drawing.Point(4, 24)
        Me.tpRes.Name = "tpRes"
        Me.tpRes.Size = New System.Drawing.Size(624, 452)
        Me.tpRes.TabIndex = 3
        Me.tpRes.Text = "Resistence"
        '
        'lbro
        '
        Me.lbro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbro.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbro.Location = New System.Drawing.Point(512, 376)
        Me.lbro.Name = "lbro"
        Me.lbro.Size = New System.Drawing.Size(48, 24)
        Me.lbro.TabIndex = 41
        Me.lbro.Text = "0"
        Me.lbro.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label75
        '
        Me.Label75.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label75.Location = New System.Drawing.Point(368, 376)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(88, 24)
        Me.Label75.TabIndex = 40
        Me.Label75.Text = "Ro"
        '
        'lblambda
        '
        Me.lblambda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblambda.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblambda.Location = New System.Drawing.Point(512, 336)
        Me.lblambda.Name = "lblambda"
        Me.lblambda.Size = New System.Drawing.Size(48, 24)
        Me.lblambda.TabIndex = 39
        Me.lblambda.Text = "0"
        Me.lblambda.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label73
        '
        Me.Label73.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label73.Location = New System.Drawing.Point(368, 336)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(88, 24)
        Me.Label73.TabIndex = 38
        Me.Label73.Text = "Lambda"
        '
        'lbmi
        '
        Me.lbmi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbmi.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbmi.Location = New System.Drawing.Point(512, 296)
        Me.lbmi.Name = "lbmi"
        Me.lbmi.Size = New System.Drawing.Size(48, 24)
        Me.lbmi.TabIndex = 37
        Me.lbmi.Text = "0"
        Me.lbmi.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label71
        '
        Me.Label71.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label71.Location = New System.Drawing.Point(368, 296)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(88, 24)
        Me.Label71.TabIndex = 36
        Me.Label71.Text = "Mi"
        '
        'lbeta
        '
        Me.lbeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbeta.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbeta.Location = New System.Drawing.Point(512, 256)
        Me.lbeta.Name = "lbeta"
        Me.lbeta.Size = New System.Drawing.Size(48, 24)
        Me.lbeta.TabIndex = 35
        Me.lbeta.Text = "0"
        Me.lbeta.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label69
        '
        Me.Label69.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label69.Location = New System.Drawing.Point(368, 256)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(88, 24)
        Me.Label69.TabIndex = 34
        Me.Label69.Text = "Eta"
        '
        'lbksi
        '
        Me.lbksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbksi.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbksi.Location = New System.Drawing.Point(512, 216)
        Me.lbksi.Name = "lbksi"
        Me.lbksi.Size = New System.Drawing.Size(48, 24)
        Me.lbksi.TabIndex = 33
        Me.lbksi.Text = "0"
        Me.lbksi.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label67.Location = New System.Drawing.Point(368, 216)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(88, 24)
        Me.Label67.TabIndex = 32
        Me.Label67.Text = "Ksi"
        '
        'lbfi
        '
        Me.lbfi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbfi.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbfi.Location = New System.Drawing.Point(512, 176)
        Me.lbfi.Name = "lbfi"
        Me.lbfi.Size = New System.Drawing.Size(48, 24)
        Me.lbfi.TabIndex = 31
        Me.lbfi.Text = "0"
        Me.lbfi.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label65.Location = New System.Drawing.Point(368, 176)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(88, 24)
        Me.Label65.TabIndex = 30
        Me.Label65.Text = "Fi"
        '
        'lbtau
        '
        Me.lbtau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbtau.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbtau.Location = New System.Drawing.Point(512, 136)
        Me.lbtau.Name = "lbtau"
        Me.lbtau.Size = New System.Drawing.Size(48, 24)
        Me.lbtau.TabIndex = 29
        Me.lbtau.Text = "0"
        Me.lbtau.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label63
        '
        Me.Label63.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label63.Location = New System.Drawing.Point(368, 136)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(88, 24)
        Me.Label63.TabIndex = 28
        Me.Label63.Text = "Tau"
        '
        'lbdelta
        '
        Me.lbdelta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbdelta.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbdelta.Location = New System.Drawing.Point(512, 96)
        Me.lbdelta.Name = "lbdelta"
        Me.lbdelta.Size = New System.Drawing.Size(48, 24)
        Me.lbdelta.TabIndex = 27
        Me.lbdelta.Text = "0"
        Me.lbdelta.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label61.Location = New System.Drawing.Point(368, 96)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(88, 24)
        Me.Label61.TabIndex = 26
        Me.Label61.Text = "Delta"
        '
        'lbepsilon
        '
        Me.lbepsilon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbepsilon.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbepsilon.Location = New System.Drawing.Point(512, 56)
        Me.lbepsilon.Name = "lbepsilon"
        Me.lbepsilon.Size = New System.Drawing.Size(48, 24)
        Me.lbepsilon.TabIndex = 25
        Me.lbepsilon.Text = "0"
        Me.lbepsilon.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label59.Location = New System.Drawing.Point(368, 56)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(88, 24)
        Me.Label59.TabIndex = 24
        Me.Label59.Text = "Epsilon"
        '
        'lbgamma
        '
        Me.lbgamma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbgamma.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbgamma.Location = New System.Drawing.Point(512, 16)
        Me.lbgamma.Name = "lbgamma"
        Me.lbgamma.Size = New System.Drawing.Size(48, 24)
        Me.lbgamma.TabIndex = 23
        Me.lbgamma.Text = "0"
        Me.lbgamma.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label57
        '
        Me.Label57.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label57.Location = New System.Drawing.Point(368, 16)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(88, 24)
        Me.Label57.TabIndex = 22
        Me.Label57.Text = "Gamma"
        '
        'lbpsi
        '
        Me.lbpsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbpsi.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbpsi.Location = New System.Drawing.Point(208, 416)
        Me.lbpsi.Name = "lbpsi"
        Me.lbpsi.Size = New System.Drawing.Size(48, 24)
        Me.lbpsi.TabIndex = 21
        Me.lbpsi.Text = "0"
        Me.lbpsi.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label55.Location = New System.Drawing.Point(64, 416)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(88, 24)
        Me.Label55.TabIndex = 20
        Me.Label55.Text = "Psi"
        '
        'lbbeta
        '
        Me.lbbeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbbeta.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbbeta.Location = New System.Drawing.Point(208, 376)
        Me.lbbeta.Name = "lbbeta"
        Me.lbbeta.Size = New System.Drawing.Size(48, 24)
        Me.lbbeta.TabIndex = 19
        Me.lbbeta.Text = "0"
        Me.lbbeta.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label53.Location = New System.Drawing.Point(64, 376)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(88, 24)
        Me.Label53.TabIndex = 18
        Me.Label53.Text = "Beta"
        '
        'lbalfa
        '
        Me.lbalfa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbalfa.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbalfa.Location = New System.Drawing.Point(208, 336)
        Me.lbalfa.Name = "lbalfa"
        Me.lbalfa.Size = New System.Drawing.Size(48, 24)
        Me.lbalfa.TabIndex = 17
        Me.lbalfa.Text = "0"
        Me.lbalfa.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label51.Location = New System.Drawing.Point(64, 336)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(88, 24)
        Me.Label51.TabIndex = 16
        Me.Label51.Text = "Alfa"
        '
        'lbdzeta
        '
        Me.lbdzeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbdzeta.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbdzeta.Location = New System.Drawing.Point(208, 296)
        Me.lbdzeta.Name = "lbdzeta"
        Me.lbdzeta.Size = New System.Drawing.Size(48, 24)
        Me.lbdzeta.TabIndex = 15
        Me.lbdzeta.Text = "0"
        Me.lbdzeta.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label49.Location = New System.Drawing.Point(64, 296)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(88, 24)
        Me.Label49.TabIndex = 14
        Me.Label49.Text = "Dzeta"
        '
        'lbtheta
        '
        Me.lbtheta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbtheta.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbtheta.Location = New System.Drawing.Point(208, 256)
        Me.lbtheta.Name = "lbtheta"
        Me.lbtheta.Size = New System.Drawing.Size(48, 24)
        Me.lbtheta.TabIndex = 13
        Me.lbtheta.Text = "0"
        Me.lbtheta.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label47.Location = New System.Drawing.Point(64, 256)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(88, 24)
        Me.Label47.TabIndex = 12
        Me.Label47.Text = "Theta"
        '
        'lbkappa
        '
        Me.lbkappa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbkappa.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbkappa.Location = New System.Drawing.Point(208, 216)
        Me.lbkappa.Name = "lbkappa"
        Me.lbkappa.Size = New System.Drawing.Size(48, 24)
        Me.lbkappa.TabIndex = 11
        Me.lbkappa.Text = "0"
        Me.lbkappa.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label45.Location = New System.Drawing.Point(64, 216)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(88, 24)
        Me.Label45.TabIndex = 10
        Me.Label45.Text = "Kappa"
        '
        'lbomicron
        '
        Me.lbomicron.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbomicron.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbomicron.Location = New System.Drawing.Point(208, 176)
        Me.lbomicron.Name = "lbomicron"
        Me.lbomicron.Size = New System.Drawing.Size(48, 24)
        Me.lbomicron.TabIndex = 9
        Me.lbomicron.Text = "0"
        Me.lbomicron.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label43.Location = New System.Drawing.Point(64, 176)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(88, 24)
        Me.Label43.TabIndex = 8
        Me.Label43.Text = "Omicron"
        '
        'lbsigma
        '
        Me.lbsigma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbsigma.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbsigma.Location = New System.Drawing.Point(208, 136)
        Me.lbsigma.Name = "lbsigma"
        Me.lbsigma.Size = New System.Drawing.Size(48, 24)
        Me.lbsigma.TabIndex = 7
        Me.lbsigma.Text = "0"
        Me.lbsigma.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label41.Location = New System.Drawing.Point(64, 136)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(88, 24)
        Me.Label41.TabIndex = 6
        Me.Label41.Text = "Sigma"
        '
        'lbomega
        '
        Me.lbomega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbomega.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbomega.Location = New System.Drawing.Point(208, 96)
        Me.lbomega.Name = "lbomega"
        Me.lbomega.Size = New System.Drawing.Size(48, 24)
        Me.lbomega.TabIndex = 5
        Me.lbomega.Text = "0"
        Me.lbomega.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.Location = New System.Drawing.Point(64, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 24)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Omega"
        '
        'lbchi
        '
        Me.lbchi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbchi.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbchi.Location = New System.Drawing.Point(208, 56)
        Me.lbchi.Name = "lbchi"
        Me.lbchi.Size = New System.Drawing.Size(48, 24)
        Me.lbchi.TabIndex = 3
        Me.lbchi.Text = "0"
        Me.lbchi.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(64, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 24)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Chi"
        '
        'lbiota
        '
        Me.lbiota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbiota.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbiota.Location = New System.Drawing.Point(208, 16)
        Me.lbiota.Name = "lbiota"
        Me.lbiota.Size = New System.Drawing.Size(48, 24)
        Me.lbiota.TabIndex = 1
        Me.lbiota.Text = "0"
        Me.lbiota.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Iota"
        '
        'tpSpell
        '
        Me.tpSpell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpSpell.Controls.Add(Me.Cmd_ss)
        Me.tpSpell.Controls.Add(Me.Lst_spells)
        Me.tpSpell.Controls.Add(Me.Cmd_ds)
        Me.tpSpell.Controls.Add(Me.Cmd_as)
        Me.tpSpell.Location = New System.Drawing.Point(4, 24)
        Me.tpSpell.Name = "tpSpell"
        Me.tpSpell.Size = New System.Drawing.Size(624, 452)
        Me.tpSpell.TabIndex = 4
        Me.tpSpell.Text = "Kouzla"
        '
        'tpItem
        '
        Me.tpItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpItem.Controls.Add(Me.Cmd_ai)
        Me.tpItem.Controls.Add(Me.Cmd_di)
        Me.tpItem.Controls.Add(Me.Cmd_si)
        Me.tpItem.Controls.Add(Me.Lst_items)
        Me.tpItem.Location = New System.Drawing.Point(4, 24)
        Me.tpItem.Name = "tpItem"
        Me.tpItem.Size = New System.Drawing.Size(624, 452)
        Me.tpItem.TabIndex = 8
        Me.tpItem.Text = "Itemy"
        '
        'Frm_Characters
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(897, 657)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.Txt_hom)
        Me.Controls.Add(Me.Txt_comp)
        Me.Controls.Add(Me.Txt_mon)
        Me.Controls.Add(Me.Txt_eptyp)
        Me.Controls.Add(Me.Txt_sp)
        Me.Controls.Add(Me.Txt_ep)
        Me.Controls.Add(Me.Txt_psp)
        Me.Controls.Add(Me.Txt_mg)
        Me.Controls.Add(Me.Txt_hp)
        Me.Controls.Add(Me.Txt_kra)
        Me.Controls.Add(Me.Txt_jed)
        Me.Controls.Add(Me.Txt_mou)
        Me.Controls.Add(Me.Txt_IQ)
        Me.Controls.Add(Me.Txt_podl)
        Me.Controls.Add(Me.Txt_fodl)
        Me.Controls.Add(Me.Txt_zru)
        Me.Controls.Add(Me.Txt_hbi)
        Me.Controls.Add(Me.Txt_sil)
        Me.Controls.Add(Me.Txt_birth)
        Me.Controls.Add(Me.Txt_weight)
        Me.Controls.Add(Me.Txt_height)
        Me.Controls.Add(Me.Txt_class)
        Me.Controls.Add(Me.Txt_sex)
        Me.Controls.Add(Me.Txt_race)
        Me.Controls.Add(Me.Txt_titles)
        Me.Controls.Add(Me.Txt_name)
        Me.Controls.Add(Me.Txt_Num)
        Me.Controls.Add(Me.Cmd_Last)
        Me.Controls.Add(Me.Cmd_Forward)
        Me.Controls.Add(Me.Cmd_Back)
        Me.Controls.Add(Me.Cmd_First)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.Cmd_Ins)
        Me.Controls.Add(Me.Cmd_Del)
        Me.Controls.Add(Me.Cmd_Find)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
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
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.Name = "Frm_Characters"
        Me.Opacity = 0.9
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC AVATAR - Odria Characters"
        Me.tc.ResumeLayout(False)
        Me.tpVantages.ResumeLayout(False)
        Me.tpPsi.ResumeLayout(False)
        Me.tpClaskil.ResumeLayout(False)
        Me.tpWeap.ResumeLayout(False)
        Me.tpRema.ResumeLayout(False)
        Me.tpWesk.ResumeLayout(False)
        Me.tpSkill.ResumeLayout(False)
        Me.tpRes.ResumeLayout(False)
        Me.tpSpell.ResumeLayout(False)
        Me.tpItem.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Frm_Characters
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Frm_Characters
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Frm_Characters()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As Frm_Characters)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region

    'Private Sub Frm_CHsez_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles my_sez.Closed
    '    If Tcha <> "" Then
    '        CHposition = 0
    '        Do Until CHrec.Tables("ch").Rows(CHposition)("Name") = Tcha
    '            CHposition += 1
    '        Loop
    '        FillForm()
    '        Me.Refresh()
    '    End If
    'End Sub

    Private Sub Cmd_ai_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_ai.Click
        Transtr = ""
        FITCH = New Frm_ITCHoose
        FITCH.ShowDialog()
        FITCH = Nothing
        If Transtr <> "" Then
            Lst_items.Items.Add((Transtr))
            Cmd_di.Enabled = True
            Cmd_si.Enabled = True
        End If
    End Sub

    Private Sub Cmd_ak_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
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

    Private Sub Cmd_aw_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_aw.Click
        Transtr = ""
        FWECH = New Frm_WECHoose
        FWECH.ShowDialog()
        FWECH = Nothing
        If Transtr <> "" Then
            Lst_weap.Items.Add((Transtr))
            Cmd_dw.Enabled = True
            Cmd_sw.Enabled = True
        End If
    End Sub

    Private Sub Cmd_Back_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Back.Click
        CHposition -= 1
        Call FillForm()
    End Sub

    Private Sub Cmd_di_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_di.Click
        Dim a As Object
        If Lst_items.Text <> "" Then
            For a = 0 To Lst_items.Items.Count
                If VB6.GetItemString(Lst_items, a) = Lst_items.Text Then
                    Lst_items.Items.RemoveAt((a))
                    Exit For
                End If
            Next
        End If
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

    Private Sub Cmd_dd_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_dd.Click
        Dim a As Object
        If Lst_neg.Text <> "" Then
            For a = 0 To Lst_neg.Items.Count
                If VB6.GetItemString(Lst_neg, a) = Lst_neg.Text Then
                    Lst_neg.Items.RemoveAt((a))
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

    Private Sub Cmd_dw_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_dw.Click
        Dim a As Object
        If Lst_weap.Text <> "" Then
            For a = 0 To Lst_weap.Items.Count
                If VB6.GetItemString(Lst_weap, a) = Lst_weap.Text Then
                    Lst_weap.Items.RemoveAt((a))
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Cmd_Exit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_First_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_First.Click
        CHposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Forward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Forward.Click
        CHposition += 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Last_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Last.Click
        CHposition = CHcount - 1
        Call FillForm()
    End Sub

    'Private Sub Cmd_New_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_New.Click
    '    Txt_name.Text = ""
    '    Txt_titles.Text = ""
    '    Txt_race.Text = ""
    '    Txt_sex.Text = ""
    '    Txt_height.Text = ""
    '    Txt_weight.Text = ""
    '    Txt_birth.Text = ""
    '    Txt_class.Text = ""
    '    Txt_sil.Text = ""
    '    Txt_hbi.Text = ""
    '    Txt_zru.Text = ""
    '    Txt_fodl.Text = ""
    '    Txt_podl.Text = ""
    '    Txt_IQ.Text = ""
    '    Txt_mou.Text = ""
    '    Txt_jed.Text = ""
    '    Txt_kra.Text = ""
    '    Txt_hp.Text = ""
    '    Txt_mg.Text = ""
    '    Txt_psp.Text = ""
    '    Txt_ep.Text = ""
    '    Txt_sp.Text = ""
    '    Txt_eptyp.Text = ""
    '    Txt_mon.Text = ""
    '    Txt_comp.Text = ""
    '    Txt_pop.Text = ""
    '    Txt_his.Text = ""
    '    Txt_on.Text = ""
    '    Txt_spow.Text = ""
    '    Txt_pos.Text = ""
    '    Txt_poz.Text = ""
    '    Txt_neg.Text = ""
    '    Txt_hom.Text = ""
    '    Lst_spells.Items.Clear()
    '    Lst_skills.Items.Clear()
    '    Lst_res.Items.Clear()
    '    Lst_items.Items.Clear()
    '    Lst_weap.Items.Clear()
    '    Cmd_Print.Enabled = False
    '    Cmd_Del.Enabled = False
    '    Txt_Num.Text = "NEW"
    'End Sub


    '    Private Sub Cmd_si_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_si.Click
    '        If Lst_items.Text <> "" Then
    '            If IT Then
    '                FIt.Txt_name.Text = Lst_items.Text
    '                Call ITSearch()
    '                FIt.Show()
    '            Else

    '                FIt = New Frm_Items
    '                FIt.Show()
    '                Do
    '                    System.Windows.Forms.Application.DoEvents()
    '                Loop Until IT
    '                FIt.Txt_name.Text = Lst_items.Text
    '                Call ITSearch()
    '                FIt.Show()
    '            End If
    '        End If
    '    End Sub

    '    Private Sub Cmd_sk_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_sk.Click
    '        Dim a As Long
    '        Dim pstr As String
    '        pstr = ""
    '        If Lst_skills.Text <> "" Then
    '            For a = 1 To Len(Lst_skills.Text)
    '                If Mid(Lst_skills.Text, a, 3) <> "   " Then
    '                    pstr = pstr & Mid(Lst_skills.Text, a, 1)
    '                Else
    '                    Exit For
    '                End If
    '            Next
    '            If SK Then
    '                FSk.Txt_s.Text = pstr
    '                Call SKSearch()
    '                FSk.Show()
    '            Else

    '                FSk = New Frm_Skills
    '                FSk.Show()
    '                Do
    '                    System.Windows.Forms.Application.DoEvents()
    '                Loop Until SK
    '                FSk.Txt_s.Text = pstr
    '                Call SKSearch()
    '                FSk.Show()
    '            End If
    '        End If
    '    End Sub

    '    Private Sub Cmd_sr_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_sr.Click
    '        If Lst_res.Text <> "" Then
    '            If EL Then

    '                FEle.Show()
    '            Else

    '                FEle = New Frm_Elements

    '                FEle.Show()
    '            End If
    '        End If
    '    End Sub

    '    Private Sub Cmd_ss_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_ss.Click
    '        If Lst_spells.Text <> "" Then
    '            If SP Then
    '                FSp.Txt_Spellname.Text = Lst_spells.Text
    '                Call SPSearch()
    '                FSp.Show()
    '            Else

    '                FSp = New Frm_Spells
    '                FSp.Show()
    '                Do
    '                    System.Windows.Forms.Application.DoEvents()
    '                Loop Until SP
    '                FSp.Txt_Spellname.Text = Lst_spells.Text
    '                Call SPSearch()
    '                FSp.Show()
    '            End If
    '        End If
    '    End Sub

    '    Private Sub Cmd_sw_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_sw.Click
    '        Dim a As Long
    '        Dim pstr As String
    '        pstr = ""
    '        If Lst_weap.Text <> "" Then
    '            For a = 1 To Len(Lst_weap.Text)
    '                If Mid(Lst_weap.Text, a, 3) <> "   " Then
    '                    pstr = pstr & Mid(Lst_weap.Text, a, 1)
    '                Else
    '                    Exit For
    '                End If
    '            Next
    '            If WE Then
    '                FWe.Txt_w.Text = pstr
    '                Call WESearch()
    '                FWe.Show()
    '            Else

    '                FWe = New Frm_Weapons
    '                FWe.Show()
    '                Do
    '                    System.Windows.Forms.Application.DoEvents()
    '                Loop Until WE
    '                FWe.Txt_w.Text = pstr
    '                Call WESearch()
    '                FWe.Show()
    '            End If
    '        End If
    '    End Sub

    Private Sub Frm_Characters_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        'ApplyColor()
        CHposition = 0
        Do Until CHrec.Tables("ch").Rows(CHposition)("Name") = Tcha
            CHposition += 1
        Loop
        Call FillForm()

    End Sub


    Sub FillForm()
        Dim spe As New OleDbCommand
        Dim ski As New OleDbCommand
        Dim ele As New OleDbCommand
        Dim ite As New OleDbCommand
        Dim wep As New OleDbCommand
        Dim van As New OleDbCommand
        Dim wsk As New OleDbCommand
        Dim psi As New OleDbCommand
        Dim csk As New OleDbCommand
        Dim a, b, c, d, e, f, g, h, i As Int16
        Dim ax, bx, cx, dx, ex, fx, gx, hx, ix As Int16

        Txt_name.Text = CHrec.Tables("ch").Rows(CHposition)("Name")
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Titles")) Then
            Txt_titles.Text = CHrec.Tables("ch").Rows(CHposition)("Titles")
        Else
            Txt_titles.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Race")) Then
            Txt_race.Text = CHrec.Tables("ch").Rows(CHposition)("Race")
        Else
            Txt_race.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Sex")) Then
            Txt_sex.Text = CHrec.Tables("ch").Rows(CHposition)("Sex")
        Else
            Txt_sex.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Height")) Then
            Txt_height.Text = CHrec.Tables("ch").Rows(CHposition)("Height")
        Else
            Txt_height.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Weight")) Then
            Txt_weight.Text = CHrec.Tables("ch").Rows(CHposition)("Weight")
        Else
            Txt_weight.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Birth")) Then
            Txt_birth.Text = CHrec.Tables("ch").Rows(CHposition)("Birth")
        Else
            Txt_birth.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Classes")) Then
            Txt_class.Text = Kilch.CLA(CHrec.Tables("ch").Rows(CHposition)("Classes"), CHrec.Tables("ch").Rows(CHposition)("Levels"))
        Else
            Txt_class.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Sil")) Then
            Txt_sil.Text = CHrec.Tables("ch").Rows(CHposition)("Sil")
        Else
            Txt_sil.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Hbi")) Then
            Txt_hbi.Text = CHrec.Tables("ch").Rows(CHposition)("Hbi")
        Else
            Txt_hbi.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Zru")) Then
            Txt_zru.Text = CHrec.Tables("ch").Rows(CHposition)("Zru")
        Else
            Txt_zru.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Fodl")) Then
            Txt_fodl.Text = CHrec.Tables("ch").Rows(CHposition)("Fodl")
        Else
            Txt_fodl.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Podl")) Then
            Txt_podl.Text = CHrec.Tables("ch").Rows(CHposition)("Podl")
        Else
            Txt_podl.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("IQ")) Then
            Txt_IQ.Text = CHrec.Tables("ch").Rows(CHposition)("IQ")
        Else
            Txt_IQ.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Mou")) Then
            Txt_mou.Text = CHrec.Tables("ch").Rows(CHposition)("Mou")
        Else
            Txt_mou.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Jed")) Then
            Txt_jed.Text = CHrec.Tables("ch").Rows(CHposition)("Jed")
        Else
            Txt_jed.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Kra")) Then
            Txt_kra.Text = CHrec.Tables("ch").Rows(CHposition)("Kra")
        Else
            Txt_kra.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("HP")) Then
            Txt_hp.Text = CHrec.Tables("ch").Rows(CHposition)("HP")
        Else
            Txt_hp.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("MG")) Then
            Txt_mg.Text = CHrec.Tables("ch").Rows(CHposition)("MG")
        Else
            Txt_mg.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("PSP")) Then
            Txt_psp.Text = CHrec.Tables("ch").Rows(CHposition)("PSP")
        Else
            Txt_psp.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("EP")) Then
            Txt_ep.Text = CHrec.Tables("ch").Rows(CHposition)("EP")
        Else
            Txt_ep.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("SP")) Then
            Txt_sp.Text = CHrec.Tables("ch").Rows(CHposition)("SP")
        Else
            Txt_sp.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("About_essence")) Then
            Txt_eptyp.Text = CHrec.Tables("ch").Rows(CHposition)("About_essence")
        Else
            Txt_eptyp.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Money_all")) Then
            Txt_mon.Text = CHrec.Tables("ch").Rows(CHposition)("Money_all")
        Else
            Txt_mon.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Money_comp")) Then
            Txt_comp.Text = CHrec.Tables("ch").Rows(CHposition)("Money_comp")
        Else
            Txt_comp.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Special_skills")) Then
            Txt_spow.Text = CHrec.Tables("ch").Rows(CHposition)("Special_skills")
        Else
            Txt_spow.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Looking")) Then
            Txt_pop.Text = CHrec.Tables("ch").Rows(CHposition)("Looking")
        Else
            Txt_pop.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("History")) Then
            Txt_his.Text = CHrec.Tables("ch").Rows(CHposition)("History")
        Else
            Txt_his.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Home_site")) Then
            Txt_hom.Text = CHrec.Tables("ch").Rows(CHposition)("Home_site")
        Else
            Txt_hom.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Ongoing")) Then
            Txt_on.Text = CHrec.Tables("ch").Rows(CHposition)("Ongoing")
        Else
            Txt_on.Text = ""
        End If
        If Not IsDBNull(CHrec.Tables("ch").Rows(CHposition)("Possession")) Then
            Txt_pos.Text = CHrec.Tables("ch").Rows(CHposition)("Possession")
        Else
            Txt_pos.Text = ""
        End If
        spe.Connection = Odrialink2
        ski.Connection = Odrialink2
        ele.Connection = Odrialink2
        Lst_spells.Items.Clear()
        spe.CommandText = "select * from Chspells where Char_ID = " & CHrec.Tables("ch").Rows(CHposition)("ID")
        CHSPdat.SelectCommand = spe
        CHSP.Clear()
        CHSPdat.Fill(CHSP, "sp")
        ax = CHSP.Tables("sp").Rows.Count
        a = 0
        If ax > 0 Then
            Do
                Dim ss As String
                Dim blah As Int16
                ss = CHSP.Tables("sp").Rows(a)("Spell")
                If CHSP.Tables("sp").Rows(a)("Dots") > 0 Then
                    ss = ss & "  "
                    For blah = 1 To CHSP.Tables("sp").Rows(a)("Dots")
                        ss = ss & "·"
                    Next
                End If
                Lst_spells.Items.Add(ss)
                a += 1
            Loop Until a = ax
            Cmd_ds.Enabled = True
            Cmd_ss.Enabled = True
        Else
            Cmd_ds.Enabled = False
            Cmd_ss.Enabled = False
        End If
        Lst_skills.Items.Clear()
        ski.CommandText = "select * from Chskills where Char_ID = " & CHrec.Tables("ch").Rows(CHposition)("ID")
        CHSKdat.SelectCommand = ski
        CHSK.Clear()
        CHSKdat.Fill(CHSK, "sk")
        bx = CHSK.Tables("sk").Rows.Count
        b = 0
        If bx > 0 Then
            Do
                Lst_skills.Items.Add((CHSK.Tables("sk").Rows(b)("Skill") & "   " & CHSK.Tables("sk").Rows(b)("Knowledge")))
                b += 1
            Loop Until b = bx
            Cmd_dk.Enabled = True
            Cmd_sk.Enabled = True
        Else
            Cmd_dk.Enabled = False
            Cmd_sk.Enabled = False
        End If
        Lst_items.Items.Clear()
        ite.CommandText = "select * from Chitems where Char_ID = " & CHrec.Tables("ch").Rows(CHposition)("ID")
        CHITdat.SelectCommand = ite
        CHIT.Clear()
        CHITdat.Fill(CHIT, "it")
        cx = CHIT.Tables("it").Rows.Count
        c = 0
        If cx > 0 Then
            Do
                Lst_items.Items.Add(CHIT.Tables("it").Rows(c)("Item"))
                c += 1
            Loop Until c = cx
            Cmd_di.Enabled = True
            Cmd_si.Enabled = True
        Else
            Cmd_di.Enabled = False
            Cmd_si.Enabled = False
        End If
        Lst_weap.Items.Clear()
        wep.CommandText = "select * from Chweapons where Char_ID = " & CHrec.Tables("ch").Rows(CHposition)("ID")
        CHWEdat.SelectCommand = wep
        CHWE.Clear()
        CHWEdat.Fill(CHWE, "we")
        dx = CHWE.Tables("we").Rows.Count
        d = 0
        If dx > 0 Then
            Do
                Lst_weap.Items.Add(CHWE.Tables("we").Rows(d)("Weapon") & "   +" & CHWE.Tables("we").Rows(d)("Special_bonus"))
                d += 1
            Loop Until d = dx
            Cmd_dw.Enabled = True
            Cmd_sw.Enabled = True
        Else
            Cmd_dw.Enabled = False
            Cmd_sw.Enabled = False
        End If
        Lst_neg.Items.Clear()
        Lst_pos.Items.Clear()
        van.CommandText = "select * from Chvantages where Char_ID = " & CHrec.Tables("ch").Rows(CHposition)("ID")
        CHADdat.SelectCommand = van
        CHAD.Clear()
        CHADdat.Fill(CHAD, "ad")
        ex = CHAD.Tables("ad").Rows.Count
        e = 0
        If ex > 0 Then
            Do
                If CHAD.Tables("ad").Rows(e)("Adv") = 1 Then
                    If CHAD.Tables("ad").Rows(e)("Ocurence") > 1 Then
                        Lst_pos.Items.Add(CHAD.Tables("ad").Rows(e)("Vantage") & " " & CHAD.Tables("ad").Rows(e)("Ocurence") & "*")
                    Else
                        Lst_pos.Items.Add(CHAD.Tables("ad").Rows(e)("Vantage"))
                    End If
                Else
                    If CHAD.Tables("ad").Rows(e)("Ocurence") > 1 Then
                        Lst_neg.Items.Add(CHAD.Tables("ad").Rows(e)("Vantage") & " " & CHAD.Tables("ad").Rows(e)("Ocurence") & "*")
                    Else
                        Lst_neg.Items.Add(CHAD.Tables("ad").Rows(e)("Vantage"))
                    End If
                End If
                e += 1
            Loop Until e = ex
            Cmd_dd.Enabled = True
            Cmd_sd.Enabled = True
            Cmd_da.Enabled = True
            Cmd_sa.Enabled = True
        Else
            Cmd_dd.Enabled = False
            Cmd_sd.Enabled = False
            Cmd_da.Enabled = False
            Cmd_sa.Enabled = False
        End If
        Lst_wsm.Items.Clear()
        Lst_wsr.Items.Clear()
        Lst_wst.Items.Clear()
        wsk.CommandText = "select * from Chwepskills where Char_ID = " & CHrec.Tables("ch").Rows(CHposition)("ID")
        CHWSdat.SelectCommand = wsk
        CHWS.Clear()
        CHWSdat.Fill(CHWS, "ws")
        fx = CHWS.Tables("ws").Rows.Count
        f = 0
        If fx > 0 Then
            Dim lvi As ListViewItem
            Do
                Select Case CHWS.Tables("ws").Rows(f)("Wsktip")
                    Case Is = "m"
                        lvi = Lst_wsm.Items.Add(CHWS.Tables("ws").Rows(f)("Wskill"))
                        lvi.SubItems.Add(CHWS.Tables("ws").Rows(f)("Level"))
                        lvi.SubItems.Add(CHWS.Tables("ws").Rows(f)("Extras"))
                    Case Is = "r"
                        lvi = Lst_wsr.Items.Add(CHWS.Tables("ws").Rows(f)("Wskill"))
                        lvi.SubItems.Add(CHWS.Tables("ws").Rows(f)("Level"))
                        lvi.SubItems.Add(CHWS.Tables("ws").Rows(f)("Extras"))
                    Case Is = "t"
                        lvi = Lst_wst.Items.Add(CHWS.Tables("ws").Rows(f)("Wskill"))
                        lvi.SubItems.Add(CHWS.Tables("ws").Rows(f)("Level"))
                        lvi.SubItems.Add(CHWS.Tables("ws").Rows(f)("Extras"))
                End Select
                f += 1
            Loop Until f = fx
            Cmd_dws.Enabled = True
            Cmd_sws.Enabled = True
        Else
            Cmd_dws.Enabled = False
            Cmd_sws.Enabled = False
        End If
        Lst_psi.Items.Clear()
        psi.CommandText = "select * from Chpsi where Char_ID = " & CHrec.Tables("ch").Rows(CHposition)("ID")
        CHPSdat.SelectCommand = psi
        CHPS.Clear()
        CHPSdat.Fill(CHPS, "ps")
        gx = CHPS.Tables("ps").Rows.Count
        g = 0
        If gx > 0 Then
            Do
                Lst_psi.Items.Add(CHPS.Tables("ps").Rows(g)("Pskill") & " " & CHPS.Tables("ps").Rows(g)("Plevel"))
                g += 1
            Loop Until g = gx
            Cmd_dp.Enabled = True
            Cmd_sp.Enabled = True
        Else
            Cmd_dp.Enabled = False
            Cmd_sp.Enabled = False
        End If
        Lst_csk.Items.Clear()
        csk.CommandText = "select * from Chclaskills where Char_ID = " & CHrec.Tables("ch").Rows(CHposition)("ID")
        CHCSdat.SelectCommand = csk
        CHCS.Clear()
        CHCSdat.Fill(CHCS, "cs")
        hx = CHCS.Tables("cs").Rows.Count
        h = 0
        If hx > 0 Then
            Do
                Lst_csk.Items.Add(CHCS.Tables("cs").Rows(h)("Name") & " " & CHCS.Tables("cs").Rows(h)("Level"))
                h += 1
            Loop Until h = hx
            Cmd_dcs.Enabled = True
            Cmd_scs.Enabled = True
        Else
            Cmd_dcs.Enabled = False
            Cmd_scs.Enabled = False
        End If
        lbiota.Text = "0"
        lbchi.Text = "0"
        lbomega.Text = "0"
        lbsigma.Text = "0"
        lbomicron.Text = "0"
        lbkappa.Text = "0"
        lbtheta.Text = "0"
        lbdzeta.Text = "0"
        lbalfa.Text = "0"
        lbbeta.Text = "0"
        lbpsi.Text = "0"
        lbgamma.Text = "0"
        lbepsilon.Text = "0"
        lbdelta.Text = "0"
        lbtau.Text = "0"
        lbfi.Text = "0"
        lbksi.Text = "0"
        lbeta.Text = "0"
        lbmi.Text = "0"
        lblambda.Text = "0"
        lbro.Text = "0"
        ele.CommandText = "select * from Chresistances where Char_ID = " & CHrec.Tables("ch").Rows(CHposition)("ID")
        CHELdat.SelectCommand = ele
        CHEL.Clear()
        CHELdat.Fill(CHEL, "el")
        ix = CHEL.Tables("el").Rows.Count
        i = 0
        If ix > 0 Then
            Do
                Select Case CHEL.Tables("el").Rows(i)("Resistance_to")
                    Case Is = "Iota"
                        lbiota.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Chi"
                        lbchi.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Omega"
                        lbomega.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Sigma"
                        lbsigma.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Omicron"
                        lbomicron.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Kappa"
                        lbkappa.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Theta"
                        lbtheta.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Dzeta"
                        lbdzeta.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Alfa"
                        lbalfa.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Beta"
                        lbbeta.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Psi"
                        lbpsi.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Gamma"
                        lbgamma.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Epsilon"
                        lbepsilon.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Delta"
                        lbdelta.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Tau"
                        lbtau.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Fi"
                        lbfi.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Ksi"
                        lbksi.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Eta"
                        lbeta.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Mi"
                        lbmi.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Lambda"
                        lblambda.Text = CHEL.Tables("el").Rows(i)("Percent")
                    Case Is = "Ro"
                        lbro.Text = CHEL.Tables("el").Rows(i)("Percent")
                End Select
                i += 1
            Loop Until i = ix
        End If
        If CHposition = 0 Then
            Cmd_Back.Enabled = False
        Else
            Cmd_Back.Enabled = True
        End If
        Cmd_Del.Enabled = True
        Cmd_Find.Enabled = True
        If CHposition = CHcount - 1 Then
            Cmd_Forward.Enabled = False
        Else
            Cmd_Forward.Enabled = True
        End If
        Cmd_Ins.Enabled = True
        Cmd_Print.Enabled = True


        Txt_Num.Text = (CHposition + 1) & "/" & CHcount

    End Sub


    '    Private Sub Frm_Characters_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
    '        CH = False
    '        CHSP.Close()
    '        CHSK.Close()
    '        CHEL.Close()
    '        CHIT.Close()
    '        CHWE.Close()
    '        CHrec.Close()
    '    End Sub

    '    Private Sub CHonposition()
    '        Dim x As Long
    '        CHrec.MoveFirst()
    '        x = 1
    '        Do While CHposition > x
    '            CHrec.MoveNext()
    '            x = x + 1
    '        Loop
    '    End Sub

    '    Private Sub Txt_Num_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Num.KeyPress
    '        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '        If KeyAscii = System.Windows.Forms.Keys.Return Then
    '            If Not IsNumeric(Txt_Num.Text) Then
    '                MsgBox("Tady musí být číslo!", MsgBoxStyle.OKOnly, "Chyba")
    '                GoTo EventExitSub
    '            End If
    '            If CShort(Txt_Num.Text) > CHcount Or CShort(Txt_Num.Text) < 1 Then
    '                MsgBox("Číslo musí být v rozsahu 1 - počet záznamů!", MsgBoxStyle.OKOnly, "Chyba")
    '                GoTo EventExitSub
    '            End If
    '            KeyAscii = 0
    '            CHposition = CShort(Txt_Num.Text)
    '            Call CHonposition()
    '            Call FillForm()
    '        End If
    'EventExitSub:
    '        If KeyAscii = 0 Then
    '            eventArgs.Handled = True
    '        End If
    '    End Sub

    '    Private Sub Cmd_Print_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Print.Click
    '        MsgBox("Tak TOHLE zatím nefunguje...", MsgBoxStyle.OKOnly + MsgBoxStyle.Exclamation, "Oops")
    '    End Sub

    '    Private Sub Cmd_Order_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Order.Click
    '        OrderControl = "CH"
    '        FO = New Frm_Ordering
    '        FO.ShowDialog()
    '        FO = Nothing
    '        CHrec.Close()
    '        Call CHrecopen()
    '        CHrec.MoveFirst()
    '        CHposition = 1
    '        Call FillForm()
    '    End Sub

    '    Private Sub Cmd_Ins_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Ins.Click
    '        Dim pomstr As String
    '        Dim str_Renamed As String
    '        If Txt_name.Text = "" Then
    '            MsgBox("Postava musí mít jméno!", MsgBoxStyle.Exclamation, "Chyba")
    '            Exit Sub
    '        End If
    '        str_Renamed = "select * from Characters where Name = " & """" & Txt_name.Text & """"
    '        pomrec.Open(str_Renamed, Odrialink, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
    '        If pomrec.BOF Then
    '            pomrec.Close()
    '            CHrec.AddNew()
    '            CHrec.Fields("Name").Value = Txt_name.Text
    '            If Txt_titles.Text = "" Then
    '                CHrec.Fields("Titles").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Titles").Value = Txt_titles.Text
    '            End If
    '            If Txt_race.Text = "" Then
    '                CHrec.Fields("Race").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Race").Value = Txt_race.Text
    '            End If
    '            If Txt_sex.Text = "" Then
    '                CHrec.Fields("Sex").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Sex").Value = Txt_sex.Text
    '            End If
    '            If Txt_class.Text = "" Then
    '                CHrec.Fields("Class").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Class").Value = Txt_class.Text
    '            End If
    '            If Txt_lev.Text = "" Then
    '                CHrec.Fields("Levels").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Levels").Value = Txt_lev.Text
    '            End If
    '            If Txt_height.Text = "" Then
    '                CHrec.Fields("Height").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Height").Value = Txt_height.Text
    '            End If
    '            If Txt_weight.Text = "" Then
    '                CHrec.Fields("Weight").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Weight").Value = Txt_weight.Text
    '            End If
    '            If Txt_birth.Text = "" Then
    '                CHrec.Fields("Birth").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Birth").Value = Txt_birth.Text
    '            End If
    '            If Txt_sil.Text = "" Then
    '                CHrec.Fields("Sil").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Sil").Value = Txt_sil.Text
    '            End If
    '            If Txt_hbi.Text = "" Then
    '                CHrec.Fields("Hbi").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Hbi").Value = Txt_hbi.Text
    '            End If
    '            If Txt_zru.Text = "" Then
    '                CHrec.Fields("Zru").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Zru").Value = Txt_zru.Text
    '            End If
    '            If Txt_fodl.Text = "" Then
    '                CHrec.Fields("Fodl").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Fodl").Value = Txt_fodl.Text
    '            End If
    '            If Txt_podl.Text = "" Then
    '                CHrec.Fields("Podl").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Podl").Value = Txt_podl.Text
    '            End If
    '            If Txt_IQ.Text = "" Then
    '                CHrec.Fields("IQ").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("IQ").Value = Txt_IQ.Text
    '            End If
    '            If Txt_mou.Text = "" Then
    '                CHrec.Fields("Mou").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Mou").Value = Txt_mou.Text
    '            End If
    '            If Txt_jed.Text = "" Then
    '                CHrec.Fields("Jed").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Jed").Value = Txt_jed.Text
    '            End If
    '            If Txt_kra.Text = "" Then
    '                CHrec.Fields("Kra").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Kra").Value = Txt_kra.Text
    '            End If
    '            If Txt_hp.Text = "" Then
    '                CHrec.Fields("HP").Value = System.DBNull.Value
    '    Else
    '        CHrec.Fields("HP").Value = Txt_hp.Text
    '    End If
    '    If Txt_mg.Text = "" Then
    '        CHrec.Fields("MG").Value = System.DBNull.Value
    '    Else
    '        CHrec.Fields("MG").Value = Txt_mg.Text
    '    End If
    '    If Txt_psp.Text = "" Then
    '        CHrec.Fields("PSP").Value = System.DBNull.Value
    '    Else
    '        CHrec.Fields("PSP").Value = Txt_psp.Text
    '    End If
    '    If Txt_ep.Text = "" Then
    '        CHrec.Fields("EP").Value = System.DBNull.Value
    '    Else
    '        CHrec.Fields("EP").Value = Txt_ep.Text
    '    End If
    '    If Txt_sp.Text = "" Then
    '        CHrec.Fields("SP").Value = System.DBNull.Value
    '    Else
    '        CHrec.Fields("SP").Value = Txt_sp.Text
    '    End If
    '    If Txt_eptyp.Text = "" Then
    '        CHrec.Fields("About_essence").Value = System.DBNull.Value
    '    Else
    '        CHrec.Fields("About_essence").Value = Txt_eptyp.Text
    '    End If
    '    If Txt_mon.Text = "" Then
    '        CHrec.Fields("Money_all").Value = System.DBNull.Value
    '    Else
    '        CHrec.Fields("Money_all").Value = Txt_mon.Text
    '    End If
    '    If Txt_comp.Text = "" Then
    '        CHrec.Fields("Money_comp").Value = System.DBNull.Value
    '    Else
    '        CHrec.Fields("Money_comp").Value = Txt_comp.Text
    '    End If
    '    If Txt_spow.Text = "" Then
    '        CHrec.Fields("Special_skills").Value = System.DBNull.Value
    '    Else
    '        CHrec.Fields("Special_skills").Value = Txt_spow.Text
    '    End If
    '    If Txt_pop.Text = "" Then
    '        CHrec.Fields("Looking").Value = System.DBNull.Value
    '    Else
    '        CHrec.Fields("Looking").Value = Txt_pop.Text
    '    End If
    '    If Txt_his.Text = "" Then
    '        CHrec.Fields("History").Value = System.DBNull.Value
    '    Else
    '        CHrec.Fields("History").Value = Txt_his.Text
    '    End If
    '    If Txt_hom.Text = "" Then
    '        CHrec.Fields("Home_site").Value = System.DBNull.Value
    '    Else
    '        CHrec.Fields("Home_site").Value = Txt_hom.Text
    '    End If
    '    If Txt_on.Text = "" Then
    '        CHrec.Fields("Ongoing").Value = System.DBNull.Value
    '    Else
    '        CHrec.Fields("Ongoing").Value = Txt_on.Text
    '    End If
    '    If Txt_pos.Text = "" Then
    '        CHrec.Fields("Possession").Value = System.DBNull.Value
    '    Else
    '        CHrec.Fields("Possession").Value = Txt_pos.Text
    '    End If
    '    If Txt_poz.Text = "" Then
    '        CHrec.Fields("Pozitiva").Value = System.DBNull.Value
    '    Else
    '        CHrec.Fields("Pozitiva").Value = Txt_poz.Text
    '    End If
    '    If Txt_neg.Text = "" Then
    '        CHrec.Fields("Negativa").Value = System.DBNull.Value
    '    Else
    '        CHrec.Fields("Negativa").Value = Txt_neg.Text
    '    End If
    '    CHrec.Update()
    '    CHcount = CHcount + 1
    '    Call CHSPsubadd()
    '    Call CHSKsubadd()
    '    Call CHELsubadd()
    '    Call CHITsubadd()
    '    Call CHWEsubadd()
    '    CHrec.Requery()
    '    Call CHonposition()
    '    Call FillForm()
    'Else
    '    pomrec.Close()
    '    If MsgBox("Postava tohoto jména již v databázi existuje, chcete ji přepsat?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Upozornění") = MsgBoxResult.Yes Then
    '        CHrec.MoveFirst()
    '        Do While CHrec.Fields("Name").Value <> Txt_name.Text
    '            CHrec.MoveNext()
    '        Loop
    '        CHrec.Fields("Name").Value = Txt_name.Text
    '        If Txt_titles.Text = "" Then
    '            CHrec.Fields("Titles").Value = System.DBNull.Value
    '        Else
    '            CHrec.Fields("Titles").Value = Txt_titles.Text
    '        End If
    '        If Txt_race.Text = "" Then
    '            CHrec.Fields("Race").Value = System.DBNull.Value
    '        Else
    '            CHrec.Fields("Race").Value = Txt_race.Text
    '        End If
    '        If Txt_sex.Text = "" Then
    '            CHrec.Fields("Sex").Value = System.DBNull.Value
    '        Else
    '            CHrec.Fields("Sex").Value = Txt_sex.Text
    '        End If
    '        If Txt_class.Text = "" Then
    '            CHrec.Fields("Class").Value = System.DBNull.Value
    '        Else
    '            CHrec.Fields("Class").Value = Txt_class.Text
    '        End If
    '        If Txt_lev.Text = "" Then
    '            CHrec.Fields("Levels").Value = System.DBNull.Value
    '        Else
    '            CHrec.Fields("Levels").Value = Txt_lev.Text
    '        End If
    '        If Txt_height.Text = "" Then
    '            CHrec.Fields("Height").Value = System.DBNull.Value
    '        Else
    '            CHrec.Fields("Height").Value = Txt_height.Text
    '        End If
    '        If Txt_weight.Text = "" Then
    '            CHrec.Fields("Weight").Value = System.DBNull.Value
    '        Else
    '            CHrec.Fields("Weight").Value = Txt_weight.Text
    '        End If
    '        If Txt_birth.Text = "" Then
    '            CHrec.Fields("Birth").Value = System.DBNull.Value
    '        Else
    '            CHrec.Fields("Birth").Value = Txt_birth.Text
    '        End If
    '        If Txt_sil.Text = "" Then
    '            CHrec.Fields("Sil").Value = System.DBNull.Value
    '        Else
    '                CHrec.Fields("Sil").Value = Txt_sil.Text
    '            End If
    '            If Txt_hbi.Text = "" Then
    '                CHrec.Fields("Hbi").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Hbi").Value = Txt_hbi.Text
    '            End If
    '            If Txt_zru.Text = "" Then
    '                CHrec.Fields("Zru").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Zru").Value = Txt_zru.Text
    '            End If
    '            If Txt_fodl.Text = "" Then
    '                CHrec.Fields("Fodl").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Fodl").Value = Txt_fodl.Text
    '            End If
    '            If Txt_podl.Text = "" Then
    '                CHrec.Fields("Podl").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Podl").Value = Txt_podl.Text
    '            End If
    '            If Txt_IQ.Text = "" Then
    '                CHrec.Fields("IQ").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("IQ").Value = Txt_IQ.Text
    '            End If
    '            If Txt_mou.Text = "" Then
    '                CHrec.Fields("Mou").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Mou").Value = Txt_mou.Text
    '            End If
    '            If Txt_jed.Text = "" Then
    '                CHrec.Fields("Jed").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Jed").Value = Txt_jed.Text
    '            End If
    '            If Txt_kra.Text = "" Then
    '                CHrec.Fields("Kra").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Kra").Value = Txt_kra.Text
    '            End If
    '            If Txt_hp.Text = "" Then
    '                CHrec.Fields("HP").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("HP").Value = Txt_hp.Text
    '            End If
    '            If Txt_mg.Text = "" Then
    '                CHrec.Fields("MG").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("MG").Value = Txt_mg.Text
    '            End If
    '            If Txt_psp.Text = "" Then
    '                CHrec.Fields("PSP").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("PSP").Value = Txt_psp.Text
    '            End If
    '            If Txt_ep.Text = "" Then
    '                CHrec.Fields("EP").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("EP").Value = Txt_ep.Text
    '            End If
    '            If Txt_sp.Text = "" Then
    '                CHrec.Fields("SP").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("SP").Value = Txt_sp.Text
    '            End If
    '            If Txt_eptyp.Text = "" Then
    '                CHrec.Fields("About_essence").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("About_essence").Value = Txt_eptyp.Text
    '            End If
    '            If Txt_mon.Text = "" Then
    '                CHrec.Fields("Money_all").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Money_all").Value = Txt_mon.Text
    '            End If
    '            If Txt_comp.Text = "" Then
    '                CHrec.Fields("Money_comp").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Money_comp").Value = Txt_comp.Text
    '            End If
    '            If Txt_spow.Text = "" Then
    '                CHrec.Fields("Special_skills").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Special_skills").Value = Txt_spow.Text
    '            End If
    '            If Txt_pop.Text = "" Then
    '                CHrec.Fields("Looking").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Looking").Value = Txt_pop.Text
    '            End If
    '            If Txt_his.Text = "" Then
    '                CHrec.Fields("History").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("History").Value = Txt_his.Text
    '            End If
    '            If Txt_hom.Text = "" Then
    '                CHrec.Fields("Home_site").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Home_site").Value = Txt_hom.Text
    '            End If
    '            If Txt_on.Text = "" Then
    '                CHrec.Fields("Ongoing").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Ongoing").Value = Txt_on.Text
    '            End If
    '            If Txt_pos.Text = "" Then
    '                CHrec.Fields("Possession").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Possession").Value = Txt_pos.Text
    '            End If
    '            If Txt_poz.Text = "" Then
    '                CHrec.Fields("Pozitiva").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Pozitiva").Value = Txt_poz.Text
    '            End If
    '            If Txt_neg.Text = "" Then
    '                CHrec.Fields("Negativa").Value = System.DBNull.Value
    '            Else
    '                CHrec.Fields("Negativa").Value = Txt_neg.Text
    '            End If
    '            CHrec.Update()
    '            pomstr = CHrec.Fields("Name").Value
    '            Call CHSPsubupd()
    '            Call CHSKsubupd()
    '            Call CHELsubupd()
    '            Call CHITsubupd()
    '            Call CHWEsubupd()
    '            CHrec.Requery()
    '            CHrec.MoveFirst()
    '            CHposition = 1
    '            Do While CHrec.Fields("Name").Value <> pomstr
    '                CHrec.MoveNext()
    '                CHposition = CHposition + 1
    '            Loop
    '            Call FillForm()
    '        Else
    '            Exit Sub
    '        End If
    '    End If

    'End Sub

    'Private Sub Cmd_Find_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Find.Click
    '    Dim pomnumber As Long
    '    If Txt_name.Text = "" Then
    '        MsgBox("A co mám jako hledat?", MsgBoxStyle.OKOnly + MsgBoxStyle.Question, "Oops!")
    '        Exit Sub
    '    End If
    '    pomnumber = CHposition
    '    CHrec.MoveFirst()
    '    CHposition = 1
    '    Do
    '        If Txt_name.Text = CHrec.Fields("Name").Value Then
    '            Exit Do
    '        End If
    '        CHrec.MoveNext()
    '        CHposition = CHposition + 1
    '    Loop Until CHrec.EOF
    '    If CHrec.EOF Then
    '        MsgBox("Postava " & Txt_name.Text & " nebyla nalezena.", MsgBoxStyle.OKOnly, "Pešek")
    '        CHposition = pomnumber
    '        Call CHonposition()
    '    End If
    '    Call FillForm()
    'End Sub

    'Private Sub Cmd_Del_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Del.Click
    '    If MsgBox("Opravdu vymazat postavu " & Txt_name.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Upozornění") = MsgBoxResult.Yes Then
    '        CHrec.Delete()
    '        CHcount = CHcount - 1
    '        If CHposition < CHcount Then
    '            CHrec.MoveNext()
    '        Else
    '            CHrec.MovePrevious()
    '            CHposition = CHposition - 1
    '        End If
    '    Else
    '        Exit Sub
    '    End If
    '    Call FillForm()
    'End Sub


    'Private Sub CHSPsubadd()
    '    Dim a As Long
    '    Dim q As Long
    '    q = Lst_spells.Items.Count
    '    If q > -1 Then
    '        CHSP.Close()
    '        CHSP.Open("select * from Chspells", Odrialink, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
    '        For a = 0 To q - 1
    '            CHSP.AddNew()
    '            CHSP.Fields("Char_ID").Value = CHrec.Fields("ID").Value
    '            CHSP.Fields("Spell").Value = VB6.GetItemString(Lst_spells, a)
    '            CHSP.Update()
    '        Next
    '        CHSP.Close()
    '        CHSP.Open("select * from Chspells where Char_ID =" & CHrec.Fields("ID").Value, Odrialink, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

    '    End If
    'End Sub


    'Private Sub CHSPsubupd()
    '    Dim a As Long
    '    Dim b As Long
    '    Dim r As Long
    '    Dim q As Long
    '    q = Lst_spells.Items.Count

    '    Do While Not CHSP.EOF
    '        r = 0
    '        For b = 0 To q - 1
    '            If CHSP.Fields("Spell").Value = VB6.GetItemString(Lst_spells, b) Then
    '                r = 1
    '            End If
    '        Next
    '        If r = 0 Then
    '            CHSP.Delete()
    '        End If
    '        CHSP.MoveNext()
    '    Loop
    '    For a = 0 To q - 1

    '        r = 0
    '        If Not (CHSP.BOF And CHSP.EOF) Then

    '            CHSP.MoveFirst()
    '            Do While Not CHSP.EOF
    '                If CHSP.Fields("Spell").Value = VB6.GetItemString(Lst_spells, a) Then
    '                    r = 1
    '                End If
    '                CHSP.MoveNext()
    '            Loop
    '        End If
    '        If r = 0 Then
    '            CHSP.AddNew()
    '            CHSP.Fields("Char_ID").Value = CHrec.Fields("ID").Value
    '            CHSP.Fields("Spell").Value = VB6.GetItemString(Lst_spells, a)
    '            CHSP.Update()
    '        End If
    '    Next

    'End Sub


    'Private Sub CHSKsubadd()
    '    Dim c As Long
    '    Dim a As Long
    '    Dim q As Long
    '    q = Lst_skills.Items.Count
    '    If q > -1 Then
    '        CHSK.Close()
    '        CHSK.Open("select * from Chskills", Odrialink, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
    '        For a = 0 To q - 1
    '            CHSK.AddNew()
    '            CHSK.Fields("Char_ID").Value = CHrec.Fields("ID").Value
    '            For c = 1 To Len(VB6.GetItemString(Lst_skills, a)) - 2
    '                If Mid(VB6.GetItemString(Lst_skills, a), c, 3) = "   " Then
    '                    CHSK.Fields("Skill").Value = Mid(VB6.GetItemString(Lst_skills, a), 1, c - 1)
    '                    CHSK.Fields("Level_of_knowledge").Value = Mid(VB6.GetItemString(Lst_skills, a), c + 3, Len(VB6.GetItemString(Lst_skills, a)) - (c + 2))
    '                End If
    '            Next
    '            CHSK.Update()
    '        Next
    '        CHSK.Close()
    '        CHSK.Open("select * from Chskills where Char_ID =" & CHrec.Fields("ID").Value, Odrialink, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

    '    End If
    'End Sub

    'Private Sub CHSKsubupd()
    '    Dim a As Long
    '    Dim str2 As String
    '    Dim str1 As String
    '    Dim c As Long
    '    Dim b As Long
    '    Dim r As Long
    '    Dim q As Long
    '    q = Lst_skills.Items.Count

    '    Do While Not CHSK.EOF
    '        r = 0
    '        For b = 0 To q - 1
    '            For c = 1 To Len(VB6.GetItemString(Lst_skills, b)) - 2
    '                If Mid(VB6.GetItemString(Lst_skills, b), c, 3) = "   " Then
    '                    str1 = Mid(VB6.GetItemString(Lst_skills, b), 1, c - 1)
    '                    str2 = Mid(VB6.GetItemString(Lst_skills, b), c + 3, Len(VB6.GetItemString(Lst_skills, b)) - (c + 2))
    '                End If
    '            Next
    '            If CHSK.Fields("Skill").Value = str1 And CHSK.Fields("Level_of_knowledge").Value = str2 Then
    '                r = 1
    '            End If
    '        Next
    '        If r = 0 Then
    '            CHSK.Delete()
    '        End If
    '        CHSK.MoveNext()
    '    Loop
    '    For a = 0 To q - 1

    '        r = 0
    '        For c = 1 To Len(VB6.GetItemString(Lst_skills, a)) - 2
    '            If Mid(VB6.GetItemString(Lst_skills, a), c, 3) = "   " Then
    '                str1 = Mid(VB6.GetItemString(Lst_skills, a), 1, c - 1)
    '                str2 = Mid(VB6.GetItemString(Lst_skills, a), c + 3, Len(VB6.GetItemString(Lst_skills, a)) - (c + 2))
    '            End If
    '        Next
    '        If Not (CHSK.BOF And CHSK.EOF) Then


    '            CHSK.MoveFirst()
    '            Do While Not CHSK.EOF

    '                If CHSK.Fields("Skill").Value = str1 And CHSK.Fields("Level_of_knowledge").Value = str2 Then
    '                    r = 1
    '                End If
    '                CHSK.MoveNext()
    '            Loop
    '        End If
    '        If r = 0 Then
    '            CHSK.AddNew()
    '            CHSK.Fields("Char_ID").Value = CHrec.Fields("ID").Value
    '            CHSK.Fields("Skill").Value = str1
    '            CHSK.Fields("Level_of_knowledge").Value = str2
    '            CHSK.Update()
    '        End If
    '    Next

    'End Sub

    'Private Sub CHELsubadd()
    '    Dim c As Long
    '    Dim a As Long
    '    Dim q As Long
    '    q = Lst_res.Items.Count
    '    If q > -1 Then
    '        CHEL.Close()
    '        CHEL.Open("select * from Chresistances", Odrialink, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
    '        For a = 0 To q - 1
    '            CHEL.AddNew()
    '            CHEL.Fields("Char_ID").Value = CHrec.Fields("ID").Value
    '            For c = 1 To Len(VB6.GetItemString(Lst_res, a)) - 2
    '                If Mid(VB6.GetItemString(Lst_res, a), c, 3) = "   " Then
    '                    CHEL.Fields("Resistance_to").Value = Mid(VB6.GetItemString(Lst_res, a), 1, c - 1)
    '                    CHEL.Fields("Percent").Value = CShort(Mid(VB6.GetItemString(Lst_res, a), c + 3, Len(VB6.GetItemString(Lst_res, a)) - (c + 3)))
    '                End If
    '            Next
    '            CHEL.Update()
    '        Next
    '        CHEL.Close()
    '        CHEL.Open("select * from Chresistances where Char_ID =" & CHrec.Fields("ID").Value, Odrialink, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

    '    End If
    'End Sub

    'Private Sub CHELsubupd()
    '    Dim a As Long
    '    Dim str2 As String
    '    Dim str1 As String
    '    Dim c As Long
    '    Dim b As Long
    '    Dim r As Long
    '    Dim q As Long
    '    q = Lst_res.Items.Count

    '    Do While Not CHEL.EOF
    '        r = 0
    '        For b = 0 To q - 1
    '            For c = 1 To Len(VB6.GetItemString(Lst_res, b)) - 2
    '                If Mid(VB6.GetItemString(Lst_res, b), c, 3) = "   " Then
    '                    str1 = Mid(VB6.GetItemString(Lst_res, b), 1, c - 1)
    '                    str2 = Mid(VB6.GetItemString(Lst_res, b), c + 3, Len(VB6.GetItemString(Lst_res, b)) - (c + 3))
    '                End If
    '            Next
    '            If CHEL.Fields("Resistance_to").Value = str1 Then
    '                r = 1
    '            End If
    '        Next
    '        If r = 0 Then
    '            CHEL.Delete()
    '        End If
    '        CHEL.MoveNext()
    '    Loop
    '    For a = 0 To q - 1

    '        r = 0
    '        For c = 1 To Len(VB6.GetItemString(Lst_res, a)) - 2
    '            If Mid(VB6.GetItemString(Lst_res, a), c, 3) = "   " Then
    '                str1 = Mid(VB6.GetItemString(Lst_res, a), 1, c - 1)
    '                str2 = Mid(VB6.GetItemString(Lst_res, a), c + 3, Len(VB6.GetItemString(Lst_res, a)) - (c + 3))
    '            End If
    '        Next
    '        If Not (CHEL.BOF And CHEL.EOF) Then


    '            CHEL.MoveFirst()
    '            Do While Not CHEL.EOF

    '                If CHEL.Fields("Resistance_to").Value = str1 And CHEL.Fields("Percent").Value = str2 Then
    '                    r = 1
    '                End If
    '                CHEL.MoveNext()
    '            Loop
    '        End If
    '        If r = 0 Then
    '            CHEL.AddNew()
    '            CHEL.Fields("Char_ID").Value = CHrec.Fields("ID").Value
    '            CHEL.Fields("Resistance_to").Value = str1
    '            CHEL.Fields("Percent").Value = str2
    '            CHEL.Update()
    '        End If
    '    Next
    'End Sub



    'Private Sub CHITsubadd()
    '    Dim a As Long
    '    Dim q As Long
    '    q = Lst_items.Items.Count
    '    If q > -1 Then
    '        CHIT.Close()
    '        CHIT.Open("select * from Chitem", Odrialink, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
    '        For a = 0 To q - 1
    '            CHIT.AddNew()
    '            CHIT.Fields("Char_ID").Value = CHrec.Fields("ID").Value
    '            CHIT.Fields("Item").Value = VB6.GetItemString(Lst_items, a)
    '            CHIT.Update()
    '        Next
    '        CHIT.Close()
    '        CHIT.Open("select * from Chitem where Char_ID =" & CHrec.Fields("ID").Value, Odrialink, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

    '    End If
    'End Sub


    'Private Sub CHITsubupd()
    '    Dim a As Long
    '    Dim b As Long
    '    Dim r As Long
    '    Dim q As Long
    '    q = Lst_items.Items.Count

    '    Do While Not CHIT.EOF
    '        r = 0
    '        For b = 0 To q - 1
    '            If CHIT.Fields("Item").Value = VB6.GetItemString(Lst_items, b) Then
    '                r = 1
    '            End If
    '        Next
    '        If r = 0 Then
    '            CHIT.Delete()
    '        End If
    '        CHIT.MoveNext()
    '    Loop
    '    For a = 0 To q - 1

    '        r = 0
    '        If Not (CHIT.BOF And CHIT.EOF) Then

    '            CHIT.MoveFirst()
    '            Do While Not CHIT.EOF
    '                If CHIT.Fields("Item").Value = VB6.GetItemString(Lst_items, a) Then
    '                    r = 1
    '                End If
    '                CHIT.MoveNext()
    '            Loop
    '        End If
    '        If r = 0 Then
    '            CHIT.AddNew()
    '            CHIT.Fields("Char_ID").Value = CHrec.Fields("ID").Value
    '            CHIT.Fields("Item").Value = VB6.GetItemString(Lst_items, a)
    '            CHIT.Update()
    '        End If
    '    Next

    'End Sub



    'Private Sub CHWEsubadd()
    '    Dim c As Long
    '    Dim a As Long
    '    Dim q As Long
    '    q = Lst_weap.Items.Count
    '    If q > -1 Then
    '        CHWE.Close()
    '        CHWE.Open("select * from Chweapons", Odrialink, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
    '        For a = 0 To q - 1
    '            CHWE.AddNew()
    '            CHWE.Fields("Char_ID").Value = CHrec.Fields("ID").Value
    '            For c = 1 To Len(VB6.GetItemString(Lst_weap, a)) - 2
    '                If Mid(VB6.GetItemString(Lst_weap, a), c, 3) = "   " Then
    '                    CHWE.Fields("Weapon").Value = Mid(VB6.GetItemString(Lst_weap, a), 1, c - 1)
    '                    CHWE.Fields("Special_bonus").Value = Mid(VB6.GetItemString(Lst_weap, a), c + 3, Len(VB6.GetItemString(Lst_weap, a)) - (c + 2))
    '                End If
    '            Next
    '            CHWE.Update()
    '        Next
    '        CHWE.Close()
    '        CHWE.Open("select * from Chweapons where Char_ID =" & CHrec.Fields("ID").Value, Odrialink, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

    '    End If
    'End Sub

    'Private Sub CHWEsubupd()
    '    Dim a As Long
    '    Dim str2 As String
    '    Dim str1 As String
    '    Dim c As Long
    '    Dim b As Long
    '    Dim r As Long
    '    Dim q As Long
    '    q = Lst_weap.Items.Count

    '    Do While Not CHWE.EOF
    '        r = 0
    '        For b = 0 To q - 1
    '            For c = 1 To Len(VB6.GetItemString(Lst_weap, b)) - 2
    '                If Mid(VB6.GetItemString(Lst_weap, b), c, 3) = "   " Then
    '                    str1 = Mid(VB6.GetItemString(Lst_weap, b), 1, c - 1)
    '                    str2 = Mid(VB6.GetItemString(Lst_weap, b), c + 3, Len(VB6.GetItemString(Lst_weap, b)) - (c + 2))
    '                End If
    '            Next
    '            If CHWE.Fields("Weapon").Value = str1 And CHWE.Fields("Special_bonus").Value = str2 Then
    '                r = 1
    '            End If
    '        Next
    '        If r = 0 Then
    '            CHWE.Delete()
    '        End If
    '        CHWE.MoveNext()
    '    Loop
    '    For a = 0 To q - 1

    '        r = 0
    '        For c = 1 To Len(VB6.GetItemString(Lst_weap, a)) - 2
    '            If Mid(VB6.GetItemString(Lst_weap, a), c, 3) = "   " Then
    '                str1 = Mid(VB6.GetItemString(Lst_weap, a), 1, c - 1)
    '                str2 = Mid(VB6.GetItemString(Lst_weap, a), c + 3, Len(VB6.GetItemString(Lst_weap, a)) - (c + 2))
    '            End If
    '        Next
    '        If Not (CHWE.BOF And CHWE.EOF) Then


    '            CHWE.MoveFirst()
    '            Do While Not CHWE.EOF

    '                If CHWE.Fields("Weapon").Value = str1 And CHWE.Fields("Special_bonus").Value Then
    '                    r = 1
    '                End If
    '                CHWE.MoveNext()
    '            Loop
    '        End If
    '        If r = 0 Then
    '            CHWE.AddNew()
    '            CHWE.Fields("Char_ID").Value = CHrec.Fields("ID").Value
    '            CHWE.Fields("Weapon").Value = str1
    '            CHWE.Fields("Special_bonus").Value = str2
    '            CHWE.Update()
    '        End If
    '    Next

    'End Sub

    Private Sub Cmd_da_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_da.Click
        Dim a As Object
        If Lst_pos.Text <> "" Then
            For a = 0 To Lst_pos.Items.Count
                If VB6.GetItemString(Lst_pos, a) = Lst_pos.Text Then
                    Lst_pos.Items.RemoveAt((a))
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Cmd_dcs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_dcs.Click
        Dim a As Object
        If Lst_csk.Text <> "" Then
            For a = 0 To Lst_csk.Items.Count
                If VB6.GetItemString(Lst_csk, a) = Lst_csk.Text Then
                    Lst_csk.Items.RemoveAt((a))
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Cmd_dp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_dp.Click
        Dim a As Object
        If Lst_psi.Text <> "" Then
            For a = 0 To Lst_psi.Items.Count
                If VB6.GetItemString(Lst_psi, a) = Lst_psi.Text Then
                    Lst_psi.Items.RemoveAt((a))
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub Cmd_dws_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_dws.Click
        Dim a As Object
        If Lst_wsm.Text <> "" Then
            For a = 0 To Lst_wsm.Items.Count
                If VB6.GetItemString(Lst_wsm, a) = Lst_wsm.Text Then
                    Lst_wsm.Items.RemoveAt((a))
                    Exit For
                End If
            Next
        End If
        If Lst_wsr.Text <> "" Then
            For a = 0 To Lst_wsr.Items.Count
                If VB6.GetItemString(Lst_wsr, a) = Lst_wsr.Text Then
                    Lst_wsr.Items.RemoveAt((a))
                    Exit For
                End If
            Next
        End If
        If Lst_wst.Text <> "" Then
            For a = 0 To Lst_wst.Items.Count
                If VB6.GetItemString(Lst_wst, a) = Lst_wst.Text Then
                    Lst_wst.Items.RemoveAt((a))
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub tc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tc.SelectedIndexChanged

    End Sub
End Class