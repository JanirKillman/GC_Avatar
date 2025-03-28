Option Strict Off
Option Explicit On 
Imports System.Data.OleDb
Friend Class Frm_Artifacts
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
    Public WithEvents Txt_his As System.Windows.Forms.TextBox
    Public WithEvents Txt_pow As System.Windows.Forms.TextBox
    Public WithEvents Txt_pop As System.Windows.Forms.TextBox
    Public WithEvents Txt_prop As System.Windows.Forms.TextBox
    Public WithEvents Txt_site As System.Windows.Forms.TextBox
    Public WithEvents Txt_ak As System.Windows.Forms.TextBox
    Public WithEvents Txt_art As System.Windows.Forms.TextBox
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
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents Bt_List As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Artifacts))
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
        Me.Txt_his = New System.Windows.Forms.TextBox
        Me.Txt_pow = New System.Windows.Forms.TextBox
        Me.Txt_pop = New System.Windows.Forms.TextBox
        Me.Txt_prop = New System.Windows.Forms.TextBox
        Me.Txt_site = New System.Windows.Forms.TextBox
        Me.Txt_ak = New System.Windows.Forms.TextBox
        Me.Txt_art = New System.Windows.Forms.TextBox
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
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Bt_List = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Cmd_Last
        '
        Me.Cmd_Last.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Last.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Last.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Last.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Last.Image = CType(resources.GetObject("Cmd_Last.Image"), System.Drawing.Image)
        Me.Cmd_Last.Location = New System.Drawing.Point(408, 480)
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
        Me.Cmd_Forward.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Forward.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Forward.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Forward.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Forward.Image = CType(resources.GetObject("Cmd_Forward.Image"), System.Drawing.Image)
        Me.Cmd_Forward.Location = New System.Drawing.Point(368, 480)
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
        Me.Cmd_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_Back.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Back.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Back.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Back.Image = CType(resources.GetObject("Cmd_Back.Image"), System.Drawing.Image)
        Me.Cmd_Back.Location = New System.Drawing.Point(192, 480)
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
        Me.Cmd_First.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_First.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_First.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_First.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_First.Image = CType(resources.GetObject("Cmd_First.Image"), System.Drawing.Image)
        Me.Cmd_First.Location = New System.Drawing.Point(152, 480)
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
        Me.Cmd_Exit.Location = New System.Drawing.Point(552, 464)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Exit.Size = New System.Drawing.Size(224, 57)
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
        Me.Cmd_Ins.Location = New System.Drawing.Point(664, 240)
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
        Me.Cmd_Del.Location = New System.Drawing.Point(664, 272)
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
        Me.Cmd_Find.Location = New System.Drawing.Point(664, 304)
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
        Me.Cmd_New.Location = New System.Drawing.Point(664, 352)
        Me.Cmd_New.Name = "Cmd_New"
        Me.Cmd_New.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_New.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_New.TabIndex = 17
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
        Me.Cmd_Print.Location = New System.Drawing.Point(664, 384)
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
        Me.Cmd_Order.Location = New System.Drawing.Point(664, 416)
        Me.Cmd_Order.Name = "Cmd_Order"
        Me.Cmd_Order.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Order.Size = New System.Drawing.Size(113, 33)
        Me.Cmd_Order.TabIndex = 15
        Me.Cmd_Order.Text = "ŘAZENÍ"
        Me.ToolTip1.SetToolTip(Me.Cmd_Order, "Změnit parametry řazení kouzel")
        Me.Cmd_Order.UseVisualStyleBackColor = False
        '
        'Txt_his
        '
        Me.Txt_his.AcceptsReturn = True
        Me.Txt_his.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_his.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_his.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_his.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_his.Location = New System.Drawing.Point(432, 32)
        Me.Txt_his.MaxLength = 0
        Me.Txt_his.Multiline = True
        Me.Txt_his.Name = "Txt_his"
        Me.Txt_his.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_his.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_his.Size = New System.Drawing.Size(344, 193)
        Me.Txt_his.TabIndex = 40
        '
        'Txt_pow
        '
        Me.Txt_pow.AcceptsReturn = True
        Me.Txt_pow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_pow.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_pow.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pow.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_pow.Location = New System.Drawing.Point(128, 176)
        Me.Txt_pow.MaxLength = 0
        Me.Txt_pow.Multiline = True
        Me.Txt_pow.Name = "Txt_pow"
        Me.Txt_pow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_pow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_pow.Size = New System.Drawing.Size(289, 49)
        Me.Txt_pow.TabIndex = 38
        '
        'Txt_pop
        '
        Me.Txt_pop.AcceptsReturn = True
        Me.Txt_pop.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_pop.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_pop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pop.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_pop.Location = New System.Drawing.Point(128, 120)
        Me.Txt_pop.MaxLength = 0
        Me.Txt_pop.Multiline = True
        Me.Txt_pop.Name = "Txt_pop"
        Me.Txt_pop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_pop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_pop.Size = New System.Drawing.Size(289, 49)
        Me.Txt_pop.TabIndex = 36
        '
        'Txt_prop
        '
        Me.Txt_prop.AcceptsReturn = True
        Me.Txt_prop.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_prop.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_prop.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_prop.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_prop.Location = New System.Drawing.Point(128, 96)
        Me.Txt_prop.MaxLength = 0
        Me.Txt_prop.Name = "Txt_prop"
        Me.Txt_prop.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_prop.Size = New System.Drawing.Size(289, 19)
        Me.Txt_prop.TabIndex = 34
        '
        'Txt_site
        '
        Me.Txt_site.AcceptsReturn = True
        Me.Txt_site.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_site.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_site.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_site.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_site.Location = New System.Drawing.Point(128, 72)
        Me.Txt_site.MaxLength = 0
        Me.Txt_site.Name = "Txt_site"
        Me.Txt_site.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_site.Size = New System.Drawing.Size(289, 19)
        Me.Txt_site.TabIndex = 32
        '
        'Txt_ak
        '
        Me.Txt_ak.AcceptsReturn = True
        Me.Txt_ak.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_ak.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ak.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ak.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_ak.Location = New System.Drawing.Point(128, 48)
        Me.Txt_ak.MaxLength = 0
        Me.Txt_ak.Name = "Txt_ak"
        Me.Txt_ak.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_ak.Size = New System.Drawing.Size(289, 19)
        Me.Txt_ak.TabIndex = 30
        '
        'Txt_art
        '
        Me.Txt_art.AcceptsReturn = True
        Me.Txt_art.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_art.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_art.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_art.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Txt_art.Location = New System.Drawing.Point(104, 8)
        Me.Txt_art.MaxLength = 0
        Me.Txt_art.Name = "Txt_art"
        Me.Txt_art.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_art.Size = New System.Drawing.Size(313, 19)
        Me.Txt_art.TabIndex = 28
        '
        'Txt_Num
        '
        Me.Txt_Num.AcceptsReturn = True
        Me.Txt_Num.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Num.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Num.Font = New System.Drawing.Font("Arial", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Num.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Num.Location = New System.Drawing.Point(232, 480)
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
        Me.Lst_spells.Location = New System.Drawing.Point(8, 264)
        Me.Lst_spells.Name = "Lst_spells"
        Me.Lst_spells.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_spells.Size = New System.Drawing.Size(177, 158)
        Me.Lst_spells.TabIndex = 11
        '
        'Lst_skills
        '
        Me.Lst_skills.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lst_skills.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_skills.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_skills.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Lst_skills.ItemHeight = 14
        Me.Lst_skills.Location = New System.Drawing.Point(184, 264)
        Me.Lst_skills.Name = "Lst_skills"
        Me.Lst_skills.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_skills.Size = New System.Drawing.Size(177, 158)
        Me.Lst_skills.TabIndex = 10
        '
        'Lst_res
        '
        Me.Lst_res.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lst_res.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_res.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_res.ForeColor = System.Drawing.Color.Yellow
        Me.Lst_res.ItemHeight = 14
        Me.Lst_res.Location = New System.Drawing.Point(360, 264)
        Me.Lst_res.Name = "Lst_res"
        Me.Lst_res.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_res.Size = New System.Drawing.Size(177, 158)
        Me.Lst_res.TabIndex = 9
        '
        'Cmd_as
        '
        Me.Cmd_as.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_as.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_as.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_as.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_as.Image = CType(resources.GetObject("Cmd_as.Image"), System.Drawing.Image)
        Me.Cmd_as.Location = New System.Drawing.Point(48, 432)
        Me.Cmd_as.Name = "Cmd_as"
        Me.Cmd_as.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_as.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_as.TabIndex = 8
        Me.Cmd_as.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_as.UseVisualStyleBackColor = False
        '
        'Cmd_ds
        '
        Me.Cmd_ds.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_ds.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ds.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ds.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ds.Image = CType(resources.GetObject("Cmd_ds.Image"), System.Drawing.Image)
        Me.Cmd_ds.Location = New System.Drawing.Point(88, 432)
        Me.Cmd_ds.Name = "Cmd_ds"
        Me.Cmd_ds.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ds.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_ds.TabIndex = 7
        Me.Cmd_ds.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_ds.UseVisualStyleBackColor = False
        '
        'Cmd_ak
        '
        Me.Cmd_ak.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_ak.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ak.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ak.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ak.Image = CType(resources.GetObject("Cmd_ak.Image"), System.Drawing.Image)
        Me.Cmd_ak.Location = New System.Drawing.Point(224, 432)
        Me.Cmd_ak.Name = "Cmd_ak"
        Me.Cmd_ak.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ak.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_ak.TabIndex = 6
        Me.Cmd_ak.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_ak.UseVisualStyleBackColor = False
        '
        'Cmd_dk
        '
        Me.Cmd_dk.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_dk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_dk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_dk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_dk.Image = CType(resources.GetObject("Cmd_dk.Image"), System.Drawing.Image)
        Me.Cmd_dk.Location = New System.Drawing.Point(264, 432)
        Me.Cmd_dk.Name = "Cmd_dk"
        Me.Cmd_dk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_dk.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_dk.TabIndex = 5
        Me.Cmd_dk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_dk.UseVisualStyleBackColor = False
        '
        'Cmd_ar
        '
        Me.Cmd_ar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_ar.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ar.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ar.Image = CType(resources.GetObject("Cmd_ar.Image"), System.Drawing.Image)
        Me.Cmd_ar.Location = New System.Drawing.Point(400, 432)
        Me.Cmd_ar.Name = "Cmd_ar"
        Me.Cmd_ar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ar.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_ar.TabIndex = 4
        Me.Cmd_ar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_ar.UseVisualStyleBackColor = False
        '
        'Cmd_dr
        '
        Me.Cmd_dr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_dr.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_dr.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_dr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_dr.Image = CType(resources.GetObject("Cmd_dr.Image"), System.Drawing.Image)
        Me.Cmd_dr.Location = New System.Drawing.Point(440, 432)
        Me.Cmd_dr.Name = "Cmd_dr"
        Me.Cmd_dr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_dr.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_dr.TabIndex = 3
        Me.Cmd_dr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_dr.UseVisualStyleBackColor = False
        '
        'Cmd_ss
        '
        Me.Cmd_ss.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_ss.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ss.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ss.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ss.Image = CType(resources.GetObject("Cmd_ss.Image"), System.Drawing.Image)
        Me.Cmd_ss.Location = New System.Drawing.Point(128, 432)
        Me.Cmd_ss.Name = "Cmd_ss"
        Me.Cmd_ss.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ss.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_ss.TabIndex = 2
        Me.Cmd_ss.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_ss.UseVisualStyleBackColor = False
        '
        'Cmd_sk
        '
        Me.Cmd_sk.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_sk.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_sk.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_sk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_sk.Image = CType(resources.GetObject("Cmd_sk.Image"), System.Drawing.Image)
        Me.Cmd_sk.Location = New System.Drawing.Point(304, 432)
        Me.Cmd_sk.Name = "Cmd_sk"
        Me.Cmd_sk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_sk.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_sk.TabIndex = 1
        Me.Cmd_sk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_sk.UseVisualStyleBackColor = False
        '
        'Cmd_sr
        '
        Me.Cmd_sr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cmd_sr.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_sr.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_sr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_sr.Image = CType(resources.GetObject("Cmd_sr.Image"), System.Drawing.Image)
        Me.Cmd_sr.Location = New System.Drawing.Point(480, 432)
        Me.Cmd_sr.Name = "Cmd_sr"
        Me.Cmd_sr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_sr.Size = New System.Drawing.Size(25, 25)
        Me.Cmd_sr.TabIndex = 0
        Me.Cmd_sr.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_sr.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(432, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(137, 17)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Historie:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(113, 17)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Síly"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(113, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Popis"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(121, 17)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Majetek"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Místo výskytu"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Známý též jako"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Artefakt"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(48, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Sesílá kouzla"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(184, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(185, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Posiluje/dává dovednosti"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(376, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(137, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Zvyšuje resistence"
        '
        'Bt_List
        '
        Me.Bt_List.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Bt_List.Image = CType(resources.GetObject("Bt_List.Image"), System.Drawing.Image)
        Me.Bt_List.Location = New System.Drawing.Point(552, 240)
        Me.Bt_List.Name = "Bt_List"
        Me.Bt_List.Size = New System.Drawing.Size(96, 208)
        Me.Bt_List.TabIndex = 49
        Me.Bt_List.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Frm_Artifacts
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 530)
        Me.Controls.Add(Me.Bt_List)
        Me.Controls.Add(Me.Txt_his)
        Me.Controls.Add(Me.Txt_pow)
        Me.Controls.Add(Me.Txt_pop)
        Me.Controls.Add(Me.Txt_prop)
        Me.Controls.Add(Me.Txt_site)
        Me.Controls.Add(Me.Txt_ak)
        Me.Controls.Add(Me.Txt_art)
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
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
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
        Me.Name = "Frm_Artifacts"
        Me.Opacity = 0.9
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC AVATAR - Odria Artifacts"
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Frm_Artifacts
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Frm_Artifacts
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Frm_Artifacts
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As Frm_Artifacts)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region
    Private TLock As String
    Private Sub Frm_ARsez_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles my_sez.Closed
        If Tartif <> "" Then
            ARposition = 0
            Do Until ARrec.Tables("ar").Rows(ARposition)("ID") = Tartif
                ARposition += 1
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
        ARposition -= 1
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
        ARposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Forward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Forward.Click
        ARposition += 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Last_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Last.Click
        ARposition = ARcount - 1
        Call FillForm()
    End Sub

    Private Sub Cmd_New_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_New.Click
        Txt_art.Text = ""
        Txt_ak.Text = ""
        Txt_site.Text = ""
        Txt_prop.Text = ""
        Txt_pop.Text = ""
        Txt_pow.Text = ""
        Txt_his.Text = ""
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

    Private Sub Frm_Artifacts_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call ARrecopen()
        ARposition = 0
        ApplyColor()
        Call FillForm()
        AR = True
    End Sub


    Private Sub ARrecopen()
        Dim isc As New OleDbCommand
        isc.Connection = Odrialink2
        Select Case ARorder
            Case Is = 1
                If ARdirect = 1 Then
                    isc.CommandText = "select * from Artifacts order by Artifact"
                Else
                    isc.CommandText = "select * from Artifacts order by Artifact desc"
                End If
            Case Is = 2
                If ARdirect = 1 Then
                    isc.CommandText = "select * from Artifacts order by Site"
                Else
                    isc.CommandText = "select * from Artifacts order by Site desc"
                End If
            Case Is = 3
                If ARdirect = 1 Then
                    isc.CommandText = "select * from Artifacts order by Property_of"
                Else
                    isc.CommandText = "select * from Artifacts order by Property_of desc"
                End If
        End Select
        ARdat.SelectCommand = isc
        ARrec.Clear()
        ARdat.Fill(ARrec, "ar")
        ARcount = ARrec.Tables("ar").Rows.Count
    End Sub


    Sub FillForm()

        Dim spe As New OleDbCommand
        Dim ski As New OleDbCommand
        Dim ele As New OleDbCommand
        Dim a, b, c As Int16
        Dim ax, bx, cx As Int16
        Txt_art.Text = ARrec.Tables("ar").Rows(ARposition)("Artifact")
        If Not IsDBNull(ARrec.Tables("ar").Rows(ARposition)("Also_known")) Then
            Txt_ak.Text = ARrec.Tables("ar").Rows(ARposition)("Also_known")
        Else
            Txt_ak.Text = ""
        End If
        If Not IsDBNull(ARrec.Tables("ar").Rows(ARposition)("Lookout")) Then
            Txt_pop.Text = ARrec.Tables("ar").Rows(ARposition)("Lookout")
        Else
            Txt_pop.Text = ""
        End If
        If Not IsDBNull(ARrec.Tables("ar").Rows(ARposition)("Site")) Then
            Txt_site.Text = ARrec.Tables("ar").Rows(ARposition)("Site")
        Else
            Txt_site.Text = ""
        End If
        If Not IsDBNull(ARrec.Tables("ar").Rows(ARposition)("Property_of")) Then
            Txt_prop.Text = ARrec.Tables("ar").Rows(ARposition)("Property_of")
        Else
            Txt_prop.Text = ""
        End If
        If Not IsDBNull(ARrec.Tables("ar").Rows(ARposition)("Powers")) Then
            Txt_pow.Text = ARrec.Tables("ar").Rows(ARposition)("Powers")
        Else
            Txt_pow.Text = ""
        End If
        If Not IsDBNull(ARrec.Tables("ar").Rows(ARposition)("History")) Then
            Txt_his.Text = ARrec.Tables("ar").Rows(ARposition)("History")
        Else
            Txt_his.Text = ""
        End If
        spe.Connection = Odrialink2
        ski.Connection = Odrialink2
        ele.Connection = Odrialink2
        Lst_spells.Items.Clear()
        Lst_skills.Items.Clear()
        Lst_res.Items.Clear()
        spe.CommandText = "select * from Aspells where Art_ID = " & ARrec.Tables("ar").Rows(ARposition)("ID")
        ARSPdat.SelectCommand = spe
        ARSP.Clear()
        ARSPdat.Fill(ARSP, "ar")
        ax = ARSP.Tables("ar").Rows.Count
        a = 0
        If ax > 0 Then
            Do
                Lst_spells.Items.Add((ARSP.Tables("ar").Rows(a)("Spell")))
                a += 1
            Loop Until a = ax
            Cmd_ds.Enabled = True
            Cmd_ss.Enabled = True
        Else
            Cmd_ds.Enabled = False
            Cmd_ss.Enabled = False
        End If
        ski.CommandText = "select * from Askills where A_ID = " & ARrec.Tables("ar").Rows(ARposition)("ID")
        ARSKdat.SelectCommand = ski
        ARSK.Clear()
        ARSKdat.Fill(ARSK, "ar")
        bx = ARSK.Tables("ar").Rows.Count
        b = 0
        If bx > 0 Then
            Do
                Lst_skills.Items.Add((ARSK.Tables("ar").Rows(b)("Skill") & "   " & ARSK.Tables("ar").Rows(b)("Knowledge")))
                b += 1
            Loop Until b = bx
            Cmd_dk.Enabled = True
            Cmd_sk.Enabled = True
        Else
            Cmd_dk.Enabled = False
            Cmd_sk.Enabled = False
        End If
        ele.CommandText = "select * from Aresistance where A_ID = " & ARrec.Tables("ar").Rows(ARposition)("ID")
        ARELdat.SelectCommand = ele
        AREL.Clear()
        ARELdat.Fill(AREL, "el")
        cx = AREL.Tables("el").Rows.Count
        c = 0
        If cx > 0 Then
            Do
                Lst_res.Items.Add((AREL.Tables("el").Rows(c)("Resistance_to") & "   " & AREL.Tables("el").Rows(c)("Percent") & "%"))
                c += 1
            Loop Until c = cx
            Cmd_dr.Enabled = True
            Cmd_sr.Enabled = True
        Else
            Cmd_dr.Enabled = False
            Cmd_sr.Enabled = False
        End If
        If ARposition = 0 Then
            Cmd_Back.Enabled = False
        Else
            Cmd_Back.Enabled = True
        End If
        Cmd_Del.Enabled = True
        Cmd_Find.Enabled = True
        If ARposition + 1 = ARcount Then
            Cmd_Forward.Enabled = False
        Else
            Cmd_Forward.Enabled = True
        End If
        Cmd_Ins.Enabled = True
        Cmd_New.Enabled = True
        Cmd_Print.Enabled = True


        Txt_Num.Text = (ARposition + 1) & "/" & ARcount

    End Sub


    Private Sub Frm_Artifacts_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        AR = False
        ARSP.Clear()
        ARSK.Clear()
        AREL.Clear()
        ARrec.Clear()
    End Sub

    Private Sub Txt_Num_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Num.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Not IsNumeric(Txt_Num.Text) Then
                MsgBox("Tady musí být číslo!", MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            If CShort(Txt_Num.Text) > ARcount Or CShort(Txt_Num.Text) < 1 Then
                MsgBox("Číslo musí být v rozsahu 1 - počet záznamů!", MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            KeyAscii = 0
            ARposition = CShort(Txt_Num.Text) - 1
            Call FillForm()
        End If
EventExitSub:
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Cmd_Print_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Print.Click
        Dim ARrint As New ARPrint
        Dim a As Integer
        Try
            Dim tsc As New OleDbCommand
            tsc.Connection = Odrialink2
            tsc.CommandText = "DELETE * from ArTemp"
            tsc.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Chyba při výmazu případu: " + ex.Message)
            Exit Sub
        End Try
        For a = 0 To ARcount - 1
            Try
                Dim ic As New OleDbCommand
                Dim s1, s2 As String
                s1 = "INSERT INTO ArTemp (ID, Artifact"
                s2 = " VALUES (@ID, @Item_name"
                ic.Parameters.AddWithValue("@ID", ARrec.Tables("ar").Rows(a)("ID"))
                ic.Parameters.AddWithValue("@Item_name", ARrec.Tables("ar").Rows(a)("Artifact"))
                If Not IsDBNull(ARrec.Tables("ar").Rows(a)("Also_known")) Then
                    ic.Parameters.AddWithValue("@Also_known", ARrec.Tables("ar").Rows(a)("Also_known"))
                    s1 = s1 & ", Also_known"
                    s2 = s2 & ", @Also_known"
                End If
                If Not IsDBNull(ARrec.Tables("ar").Rows(a)("Site")) Then
                    ic.Parameters.AddWithValue("@Site", ARrec.Tables("ar").Rows(a)("Site"))
                    s1 = s1 & ", Site"
                    s2 = s2 & ", @Site"
                End If
                If Not IsDBNull(ARrec.Tables("ar").Rows(a)("Property_of")) Then
                    ic.Parameters.AddWithValue("@Property_of", ARrec.Tables("ar").Rows(a)("Property_of"))
                    s1 = s1 & ", Property_of"
                    s2 = s2 & ", @Property_of"
                End If
                If Not IsDBNull(ARrec.Tables("ar").Rows(a)("Lookout")) Then
                    ic.Parameters.AddWithValue("@Lookout", ARrec.Tables("ar").Rows(a)("Lookout"))
                    s1 = s1 & ", Lookout"
                    s2 = s2 & ", @Lookout"
                End If
                If Not IsDBNull(ARrec.Tables("ar").Rows(a)("Powers")) Then
                    ic.Parameters.AddWithValue("@Powers", ARrec.Tables("ar").Rows(a)("Powers"))
                    s1 = s1 & ", Powers"
                    s2 = s2 & ", @Powers"
                End If
                If Not IsDBNull(ARrec.Tables("ar").Rows(a)("History")) Then
                    ic.Parameters.AddWithValue("@History", ARrec.Tables("ar").Rows(a)("History"))
                    s1 = s1 & ", History"
                    s2 = s2 & ", @History"
                End If
                Dim spe As New OleDbCommand
                Dim ski As New OleDbCommand
                Dim ele As New OleDbCommand
                Dim u, b, c As Int16
                Dim ax, bx, cx As Int16
                spe.Connection = Odrialink2
                ski.Connection = Odrialink2
                ele.Connection = Odrialink2
                spe.CommandText = "select * from Aspells where Art_ID = " & ARrec.Tables("ar").Rows(a)("ID")
                ARSPdat.SelectCommand = spe
                ARSP.Clear()
                ARSPdat.Fill(ARSP, "sp")
                ax = ARSP.Tables("sp").Rows.Count
                u = 0
                If ax > 0 Then
                    Dim gu As String
                    gu = ""
                    Do
                        If u > 0 Then
                            gu = gu & ", "
                        End If
                        gu = gu & ARSP.Tables("sp").Rows(u)("Spell")
                        u += 1
                    Loop Until u = ax
                    ic.Parameters.AddWithValue("@Spelly", gu)
                    s1 = s1 & ", Spelly"
                    s2 = s2 & ", @Spelly"
                End If
                ski.CommandText = "select * from Askills where A_ID = " & ARrec.Tables("ar").Rows(a)("ID")
                ARSKdat.SelectCommand = ski
                ARSK.Clear()
                ARSKdat.Fill(ARSK, "sk")
                bx = ARSK.Tables("sk").Rows.Count
                b = 0
                If bx > 0 Then
                    Dim gu As String
                    gu = ""
                    Do
                        If b > 0 Then
                            gu = gu & ", "
                        End If
                        gu = gu & ARSK.Tables("sk").Rows(b)("Skill")
                        If Mid(ARSK.Tables("sk").Rows(b)("Knowledge"), 1, 1) = "+" Or "-" Then
                            gu = gu & " o "
                        Else
                            gu = gu & " "
                        End If
                        gu = gu & ARSK.Tables("sk").Rows(b)("Knowledge")
                        b += 1
                    Loop Until b = bx
                    ic.Parameters.AddWithValue("@Skilly", gu)
                    s1 = s1 & ", Skilly"
                    s2 = s2 & ", @Skilly"
                End If
                ele.CommandText = "select * from Aresistance where A_ID = " & ARrec.Tables("ar").Rows(a)("ID")
                ARELdat.SelectCommand = ele
                AREL.Clear()
                ARELdat.Fill(AREL, "el")
                cx = AREL.Tables("el").Rows.Count
                c = 0
                If cx > 0 Then
                    Dim gu As String
                    gu = ""
                    Do
                        If c > 0 Then
                            gu = gu & ", "
                        End If
                        gu = gu & AREL.Tables("el").Rows(c)("Resistance_to") & " " & AREL.Tables("el").Rows(c)("Percent") & "%"
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
        isc.CommandText = "select * from ArTemp order by ID"
        da.SelectCommand = isc
        Tseta.Clear()
        da.Fill(Tseta, "Ar")
        ARrint.Show()
    End Sub

    Private Sub Cmd_Order_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Order.Click
        OrderControl = "AR"
        FO = New Frm_Ordering
        FO.ShowDialog()
        FO = Nothing
        ARrec.Clear()
        Call ARrecopen()
        ARposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Ins_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Ins.Click

        If Txt_art.Text = "" Then
            MsgBox("Artefakt musí mít jméno!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        Dim tsc As New OleDbCommand
        Dim treader As OleDbDataReader
        Try
            tsc.Connection = Odrialink2
            tsc.CommandText = "select * from Artifacts where Artifact = @it"
            tsc.Parameters.AddWithValue("@it", Txt_art.Text)
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
                s1 = "INSERT INTO Artifacts (Artifact"
                s2 = " VALUES (@Item_name"
                ic.Parameters.AddWithValue("@Item_name", Trim(Txt_art.Text))
                If Txt_ak.Text <> "" Then
                    ic.Parameters.AddWithValue("@Type", Trim(Txt_ak.Text))
                    s1 = s1 & ", Also_known"
                    s2 = s2 & ", @Type"
                End If
                If Txt_pop.Text <> "" Then
                    ic.Parameters.AddWithValue("@Looking", Trim(Txt_pop.Text))
                    s1 = s1 & ", Lookout"
                    s2 = s2 & ", @Looking"
                End If
                If Txt_prop.Text <> "" Then
                    ic.Parameters.AddWithValue("@Special_powers", Trim(Txt_prop.Text))
                    s1 = s1 & ", Property_of"
                    s2 = s2 & ", @Special_powers"
                End If
                If Txt_site.Text <> "" Then
                    ic.Parameters.AddWithValue("@Daily_MG", Trim(Txt_site.Text))
                    s1 = s1 & ", Site"
                    s2 = s2 & ", @Daily_MG"
                End If
                If Txt_pow.Text <> "" Then
                    ic.Parameters.AddWithValue("@EP_SP", Trim(Txt_pow.Text))
                    s1 = s1 & ", Powers"
                    s2 = s2 & ", @EP_SP"
                End If
                If Txt_his.Text <> "" Then
                    ic.Parameters.AddWithValue("@EP_SP_type", Trim(Txt_his.Text))
                    s1 = s1 & ", History"
                    s2 = s2 & ", @EP_SP_type"
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
            ARrec.Clear()
            ARdat.Fill(ARrec, "ar")
            ARcount = ARrec.Tables("ar").Rows.Count
            Dim tsd As New OleDbCommand
            Dim trdeader As OleDbDataReader
            Try
                tsd.Connection = Odrialink2
                tsd.CommandText = "select ID from Artifacts where Artifact = @it"
                tsd.Parameters.AddWithValue("@it", Txt_art.Text)
                trdeader = tsd.ExecuteReader
                trdeader.Read()
                TLock = trdeader.GetInt32(0)
                trdeader.Close()
            Catch ex As Exception
                MsgBox("Chyba při čtení databáze: " + ex.Message, , "CHYBA")
                trdeader.Close()
                Exit Sub
            End Try
            Call ARSPsubadd()
            Call ARSKsubadd()
            Call ARELsubadd()
            Call FillForm()
        Else
            treader.Close()
            If MsgBox("Artefakt tohoto jména již v databázi existuje, chcete ho přepsat?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Upozornění") = MsgBoxResult.Yes Then
                Try

                    Dim s3 As String
                    Dim uc As New OleDbCommand
                    s3 = "UPDATE Artifacts set Artifact = @Art, Also_known = @Type, Site = @Site, Property_of = @Prop, Lookout = @Look, Powers = @Pow, History = @His WHERE ID = @ID"
                    uc.Parameters.AddWithValue("@Art", Trim(Txt_art.Text))
                    If Txt_ak.Text = "" Then
                        uc.Parameters.AddWithValue("@Type", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Type", Txt_ak.Text)
                    End If
                    If Txt_pop.Text = "" Then
                        uc.Parameters.AddWithValue("@Look", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Look", Txt_pop.Text)
                    End If
                    If Txt_prop.Text = "" Then
                        uc.Parameters.AddWithValue("@Prop", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Prop", Txt_prop.Text)
                    End If
                    If Txt_site.Text = "" Then
                        uc.Parameters.AddWithValue("@Site", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Site", Txt_site.Text)
                    End If
                    If Txt_pow.Text = "" Then
                        uc.Parameters.AddWithValue("@Pow", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@Pow", Txt_pow.Text)
                    End If
                    If Txt_his.Text = "" Then
                        uc.Parameters.AddWithValue("@His", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@His", Txt_his.Text)
                    End If
                    Call ARSPsubupd()
                    Call ARSKsubupd()
                    Call ARELsubupd()
                    uc.Parameters.AddWithValue("@ID", ARrec.Tables("ar").Rows(ARposition)("ID"))
                    uc.Connection = Odrialink2
                    uc.CommandText = s3
                    uc.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Chyba při zápisu do databáze: " + ex.Message, , "CHYBA")
                    Exit Sub
                End Try
                ARrec.Clear()
                ARdat.Fill(ARrec, "ar")
                Call FillForm()
            Else
                Exit Sub
            End If
        End If

    End Sub

    Private Sub Cmd_Find_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Find.Click
        Dim ARse As New OleDbCommand
        Dim ARre As OleDbDataReader
        Dim s As String
        Dim q1 As Long
        Dim na, cz, ma, vy, dos, ro, za As Boolean
        ARse.Connection = Odrialink2
        s = "SELECT * from Artifacts WHERE "
        If Txt_art.Text <> "" Then
            s = s & "Artifact LIKE @Item_name"
            ARse.Parameters.AddWithValue("@Item_name", "%" & Trim(Txt_art.Text) & "%")
            na = True
        End If
        If Txt_ak.Text <> "" Then
            If na Then
                s = s & " AND "
            End If
            s = s & "Also_known LIKE @Type"
            ARse.Parameters.AddWithValue("@Type", "%" & Trim(Txt_ak.Text) & "%")
            cz = True
        End If
        If Txt_pop.Text <> "" Then
            If na Or cz Then
                s = s & " AND "
            End If
            s = s & "Lookout LIKE @Looking"
            ARse.Parameters.AddWithValue("@Looking", "%" & Trim(Txt_pop.Text) & "%")
            ma = True
        End If
        If Txt_pow.Text <> "" Then
            If na Or cz Or ma Then
                s = s & " AND "
            End If
            s = s & "Powers LIKE @Special_powers"
            ARse.Parameters.AddWithValue("@Special_powers", "%" & Trim(Txt_pow.Text) & "%")
            vy = True
        End If
        If Txt_site.Text <> "" Then
            If na Or cz Or ma Or vy Then
                s = s & " AND "
            End If
            s = s & "Site = @Daily_MG"
            ARse.Parameters.AddWithValue("@Daily_MG", Trim(Txt_site.Text))
            dos = True
        End If
        If Txt_prop.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Then
                s = s & " AND "
            End If
            s = s & "Property_of = @EP_SP"
            ARse.Parameters.AddWithValue("@EP_SP", Trim(Txt_prop.Text))
            ro = True
        End If
        If Txt_his.Text <> "" Then
            If na Or cz Or ma Or vy Or dos Or ro Then
                s = s & " AND "
            End If
            s = s & "History LIKE @EP_SP_type"
            ARse.Parameters.AddWithValue("@EP_SP_type", "%" & Trim(Txt_his.Text) & "%")
            za = True
        End If
        ARposition = 0
        If s = "SELECT * from Artifacts WHERE " Then
            ARrecopen()
            FillForm()
            Exit Sub
        End If
        Try
            ARse.CommandText = s
            ARre = ARse.ExecuteReader
            If ARre.HasRows Then
                q1 = 0
                While ARre.Read()
                    q1 += 1
                End While
                ARre.Close()
                ARdat.SelectCommand = ARse
                ARrec.Clear()
                ARdat.Fill(ARrec, "ar")
                ARcount = ARrec.Tables("ar").Rows.Count
                If GC_list = 1 Then
                    If my_sez Is Nothing Then
                        my_sez = New Frm_ARsez
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
                ARre.Close()
                MsgBox("Žádný záznam neodpovídá zvoleným parametrům.", , "Nenalezeno")
                Exit Sub
            End If
            ARre.Close()
        Catch ex As Exception
            MsgBox("Chyba při čtení databáze." + ex.Message, , "Chyba")
            Exit Sub
        End Try
        Call FillForm()
    End Sub

    Private Sub Cmd_Del_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Del.Click
        Dim tsc As New OleDbCommand
        If MsgBox("Opravdu vymazat artefakt " & Txt_art.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Upozornění") = MsgBoxResult.Yes Then
            Try
                tsc.Connection = Odrialink2
                tsc.CommandText = "DELETE from Artifacts WHERE ID = @ID"
                tsc.Parameters.AddWithValue("@ID", ARrec.Tables("ar").Rows(ARposition)("ID"))
                tsc.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception("Chyba při výmazu případu: " + ex.Message)
                Exit Sub
            End Try
        Else
            Exit Sub
        End If
        ARrec.Clear()
        ARdat.Fill(ARrec, "ar")
        ARcount = ARrec.Tables("ar").Rows.Count
        If ARposition = ARcount Then
            ARposition -= 1
        End If
        Call FillForm()
    End Sub


    Private Sub ARSPsubadd()
        Dim a As Long
        Dim q As Long
        q = Lst_spells.Items.Count
        If q > -1 Then
            Dim gr As String
            gr = "INSERT INTO Aspells (Art_ID, Spell) VALUES (@Ar_ID, @Spell)"

            For a = 0 To q - 1
                Dim g As New OleDbCommand
                g.Parameters.AddWithValue("@Ar_ID", TLock)
                g.Parameters.AddWithValue("@Spell", VB6.GetItemString(Lst_spells, a))
                g.Connection = Odrialink2
                g.CommandText = gr
                g.ExecuteScalar()
                g.Dispose()
            Next
        End If
    End Sub


    Private Sub ARSPsubupd()
        Dim a As Long
        Dim q As Long
        Dim h As New OleDbCommand
        Try
            h.Connection = Odrialink2
            h.CommandText = "DELETE from Aspells WHERE Ar_ID = @ii"
            h.Parameters.AddWithValue("@ii", ARrec.Tables("ar").Rows(ARposition)("ID"))
            h.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Chyba při výmazu případu: " + ex.Message)
            Exit Sub
        End Try
        q = Lst_spells.Items.Count
        If q > -1 Then
            Dim gr As String
            gr = "INSERT INTO Aspells (Art_ID, Spell) VALUES (@Ar_ID, @Spell)"

            For a = 0 To q - 1
                Dim g As New OleDbCommand
                g.Parameters.AddWithValue("@Ar_ID", ARrec.Tables("ar").Rows(ARposition)("ID"))
                g.Parameters.AddWithValue("@Spell", VB6.GetItemString(Lst_spells, a))
                g.Connection = Odrialink2
                g.CommandText = gr
                g.ExecuteScalar()
                g.Dispose()
            Next
        End If

    End Sub


    Private Sub ARSKsubadd()
        Dim c As Long
        Dim a As Long
        Dim q As Long
        q = Lst_skills.Items.Count
        If q > -1 Then
            Dim gr As String
            gr = "INSERT INTO Askills (A_ID, Skill, Knowledge) VALUES (@Ar_ID, @Skill, @Know)"

            For a = 0 To q - 1
                Dim g As New OleDbCommand
                g.Parameters.AddWithValue("@Ar_ID", TLock)
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

    Private Sub ARSKsubupd()
        Dim a As Long
        Dim q As Long
        Dim c As Long
        Dim h As New OleDbCommand
        Try
            h.Connection = Odrialink2
            h.CommandText = "DELETE from Askills WHERE A_ID = @ii"
            h.Parameters.AddWithValue("@ii", ARrec.Tables("ar").Rows(ARposition)("ID"))
            h.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Chyba při výmazu případu: " + ex.Message)
            Exit Sub
        End Try
        q = Lst_skills.Items.Count
        If q > -1 Then
            Dim gr As String
            gr = "INSERT INTO Askills (A_ID, Skill, Knowledge) VALUES (@Ar_ID, @Skill, @Know)"

            For a = 0 To q - 1
                Dim g As New OleDbCommand
                g.Parameters.AddWithValue("@Ar_ID", ARrec.Tables("ar").Rows(ARposition)("ID"))
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

    Private Sub ARELsubadd()
        Dim c As Long
        Dim a As Long
        Dim q As Long
        q = Lst_res.Items.Count
        If q > -1 Then
            Dim gr As String
            gr = "INSERT INTO Aresistance (A_ID, Resistance_to, Percent) VALUES (@Ar_ID, @Rest, @Per)"

            For a = 0 To q - 1
                Dim g As New OleDbCommand
                g.Parameters.AddWithValue("@Ar_ID", TLock)
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

    Private Sub ARELsubupd()
        Dim c As Long
        Dim a As Long
        Dim q As Long
        Dim h As New OleDbCommand
        Try
            h.Connection = Odrialink2
            h.CommandText = "DELETE from Aresistance WHERE A_ID = @ii"
            h.Parameters.AddWithValue("@ii", ARrec.Tables("ar").Rows(ARposition)("ID"))
            h.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Chyba při výmazu případu: " + ex.Message)
            Exit Sub
        End Try
        q = Lst_res.Items.Count
        If q > -1 Then
            Dim gr As String
            gr = "INSERT INTO Aresistance (A_ID, Resistance_to, Percent) VALUES (@Ar_ID, @Rest, @Per)"

            For a = 0 To q - 1
                Dim g As New OleDbCommand
                g.Parameters.AddWithValue("@Ar_ID", ARrec.Tables("ar").Rows(ARposition)("ID"))
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
            my_sez = New Frm_ARsez
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
        Me.BackColor = Color.FromArgb(FAB)
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
        Label1.ForeColor = Color.FromArgb(FAFO)
        Label2.ForeColor = Color.FromArgb(FAFO)
        Label3.ForeColor = Color.FromArgb(FAFO)
        Label4.ForeColor = Color.FromArgb(FAFO)
        Label5.ForeColor = Color.FromArgb(FAFO)
        Label6.ForeColor = Color.FromArgb(FAFO)
        Label7.ForeColor = Color.FromArgb(FAFO)
        Label8.ForeColor = Color.FromArgb(FAFO)
        Label9.ForeColor = Color.FromArgb(FAFO)
        Label10.ForeColor = Color.FromArgb(FAFO)
        Txt_Num.ForeColor = Color.FromArgb(FAFO)
        Txt_art.ForeColor = Color.FromArgb(FAFO)
        Txt_ak.ForeColor = Color.FromArgb(FAFO)
        Txt_pop.ForeColor = Color.FromArgb(FAFO)
        Txt_pow.ForeColor = Color.FromArgb(FAFO)
        Txt_site.ForeColor = Color.FromArgb(FAFO)
        Txt_prop.ForeColor = Color.FromArgb(FAFO)
        Txt_his.ForeColor = Color.FromArgb(FAFO)
        Lst_spells.ForeColor = Color.FromArgb(FSPFO)
        Lst_spells.BackColor = Color.FromArgb(FSPB)
        Lst_skills.ForeColor = Color.FromArgb(FSKFO)
        Lst_skills.BackColor = Color.FromArgb(FSKB)
        Lst_res.ForeColor = Color.FromArgb(FEFO)
        Lst_res.BackColor = Color.FromArgb(FEB)
    End Sub
End Class