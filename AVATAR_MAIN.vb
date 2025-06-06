Option Strict Off
Option Explicit On 
Imports System.Object
Imports System.MarshalByRefObject
Imports System.Drawing.Image
Imports System.Drawing.Bitmap
Imports System.Drawing.Imaging.Metafile
Imports System.Windows.Forms.Control
Imports System.IO
Imports System.Data.oledb
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Imports System.Data.Common

Friend Class AVATAR_MAIN
    Inherits System.Windows.Forms.Form
    Private WithEvents AM_Colors As Form
    Private WithEvents GC_Rooster As Form
    Public Kil As New Killman
    Public WithEvents Cmd_Vantages As System.Windows.Forms.Button
    Dim MM As New MM
#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()


        'This call is required by the Windows Form Designer.
        InitializeComponent()
        M_Main.Main()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        Odrialink2.Close()
        Odrialink2.Dispose()
        If MsgBox("Zvýšit číslo verze databáze?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Důležité") = MsgBoxResult.Yes Then
            Versionnumber += 1
            SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Database", "Version", Versionnumber)
            Rename(OPath, VB6.GetPath & "\Odria " & Mid(CStr(Versionnumber), 1, 1) & "." & Mid(CStr(Versionnumber), 2, 2) & ".mdb")
        End If
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
    Public WithEvents VScroll1 As System.Windows.Forms.VScrollBar
    Public WithEvents HScroll1 As System.Windows.Forms.HScrollBar
    Public WithEvents Cmd_Arts As System.Windows.Forms.Button
    Public WithEvents Cmd_PSI As System.Windows.Forms.Button
    Public WithEvents Cmd_ClassRules As System.Windows.Forms.Button
    Public WithEvents Cmd_we As System.Windows.Forms.Button
    Public WithEvents Cmd_Rul As System.Windows.Forms.Button
    Public WithEvents Cmd_Not As System.Windows.Forms.Button
    Public WithEvents Cmd_Rac As System.Windows.Forms.Button
    Public WithEvents Pic_Main As System.Windows.Forms.Panel
    Public WithEvents Lst_Images As System.Windows.Forms.ListBox
    Public WithEvents Lst_Categories As System.Windows.Forms.ListBox
    Public WithEvents Cmd_Slov As System.Windows.Forms.Button
    Public WithEvents Cmd_Zbra As System.Windows.Forms.Button
    Public WithEvents Cmd_Spells As System.Windows.Forms.Button
    Public WithEvents Cmd_Dov As System.Windows.Forms.Button
    Public WithEvents Cmd_Site As System.Windows.Forms.Button
    Public WithEvents Cmd_Osob As System.Windows.Forms.Button
    Public WithEvents Cmd_Hesla As System.Windows.Forms.Button
    Public WithEvents Cmd_Org As System.Windows.Forms.Button
    Public WithEvents Cmd_Nat As System.Windows.Forms.Button
    Public WithEvents Cmd_Jaz As System.Windows.Forms.Button
    Public WithEvents Cmd_Price As System.Windows.Forms.Button
    Public WithEvents Cmd_Items As System.Windows.Forms.Button
    Public WithEvents Cmd_Info As System.Windows.Forms.Button
    Public WithEvents Cmd_Post As System.Windows.Forms.Button
    Public WithEvents Cmd_Uda As System.Windows.Forms.Button
    Public WithEvents Cmd_Elem As System.Windows.Forms.Button
    Public WithEvents Cmd_Bestie As System.Windows.Forms.Button
    Public WithEvents Cmd_Art As System.Windows.Forms.Button
    Public WithEvents Tim1 As System.Windows.Forms.Timer
    Public WithEvents Cmd_Exit As System.Windows.Forms.Button
    Public WithEvents GC_Cmdline As System.Windows.Forms.TextBox
    Public WithEvents Cmb_Tables As System.Windows.Forms.ComboBox
    Public WithEvents Txt_Search As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Line2 As System.Windows.Forms.Label
    Public WithEvents Lbl_Time As System.Windows.Forms.Label
    Public WithEvents Lbl_Commandline As System.Windows.Forms.Label
    Public WithEvents Lbl_OnTable As System.Windows.Forms.Label
    Public WithEvents Lbl_Search As System.Windows.Forms.Label
    Public WithEvents Line1 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bbh As System.Windows.Forms.Button
    Friend WithEvents bbm As System.Windows.Forms.Button
    Friend WithEvents bbrl As System.Windows.Forms.Button
    Friend WithEvents bbrm As System.Windows.Forms.Button
    Friend WithEvents bbrh As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bcl As System.Windows.Forms.Button
    Friend WithEvents bcm As System.Windows.Forms.Button
    Friend WithEvents bch As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents bel As System.Windows.Forms.Button
    Friend WithEvents bem As System.Windows.Forms.Button
    Friend WithEvents beh As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents bfl As System.Windows.Forms.Button
    Friend WithEvents bfm As System.Windows.Forms.Button
    Friend WithEvents bfh As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents bnl As System.Windows.Forms.Button
    Friend WithEvents bnm As System.Windows.Forms.Button
    Friend WithEvents bnh As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents bol As System.Windows.Forms.Button
    Friend WithEvents bom As System.Windows.Forms.Button
    Friend WithEvents boh As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents bsl As System.Windows.Forms.Button
    Friend WithEvents bsm As System.Windows.Forms.Button
    Friend WithEvents bsh As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents bul As System.Windows.Forms.Button
    Friend WithEvents bum As System.Windows.Forms.Button
    Friend WithEvents buh As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents bpal As System.Windows.Forms.Button
    Friend WithEvents bpam As System.Windows.Forms.Button
    Friend WithEvents bpah As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents bpol As System.Windows.Forms.Button
    Friend WithEvents bpom As System.Windows.Forms.Button
    Friend WithEvents bpoh As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents bpel As System.Windows.Forms.Button
    Friend WithEvents bpem As System.Windows.Forms.Button
    Friend WithEvents bpeh As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents bt1l As System.Windows.Forms.Button
    Friend WithEvents bt1m As System.Windows.Forms.Button
    Friend WithEvents bt1h As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents bt2l As System.Windows.Forms.Button
    Friend WithEvents bt2m As System.Windows.Forms.Button
    Friend WithEvents bt2h As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents bt3l As System.Windows.Forms.Button
    Friend WithEvents bt3m As System.Windows.Forms.Button
    Friend WithEvents bt3h As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Public WithEvents Picture2 As System.Windows.Forms.PictureBox
    Friend WithEvents bbl As System.Windows.Forms.Button
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btc As System.Windows.Forms.Button
    Friend WithEvents btd As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents BtRoo As System.Windows.Forms.Button
    Friend WithEvents pbDupli As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AVATAR_MAIN))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.VScroll1 = New System.Windows.Forms.VScrollBar
        Me.HScroll1 = New System.Windows.Forms.HScrollBar
        Me.Cmd_Arts = New System.Windows.Forms.Button
        Me.Cmd_PSI = New System.Windows.Forms.Button
        Me.Cmd_ClassRules = New System.Windows.Forms.Button
        Me.Cmd_we = New System.Windows.Forms.Button
        Me.Cmd_Rul = New System.Windows.Forms.Button
        Me.Cmd_Not = New System.Windows.Forms.Button
        Me.Cmd_Rac = New System.Windows.Forms.Button
        Me.Pic_Main = New System.Windows.Forms.Panel
        Me.pbDupli = New System.Windows.Forms.PictureBox
        Me.Picture2 = New System.Windows.Forms.PictureBox
        Me.Lst_Images = New System.Windows.Forms.ListBox
        Me.Lst_Categories = New System.Windows.Forms.ListBox
        Me.Cmd_Slov = New System.Windows.Forms.Button
        Me.Cmd_Zbra = New System.Windows.Forms.Button
        Me.Cmd_Spells = New System.Windows.Forms.Button
        Me.Cmd_Dov = New System.Windows.Forms.Button
        Me.Cmd_Site = New System.Windows.Forms.Button
        Me.Cmd_Osob = New System.Windows.Forms.Button
        Me.Cmd_Hesla = New System.Windows.Forms.Button
        Me.Cmd_Org = New System.Windows.Forms.Button
        Me.Cmd_Nat = New System.Windows.Forms.Button
        Me.Cmd_Jaz = New System.Windows.Forms.Button
        Me.Cmd_Price = New System.Windows.Forms.Button
        Me.Cmd_Items = New System.Windows.Forms.Button
        Me.Cmd_Info = New System.Windows.Forms.Button
        Me.Cmd_Post = New System.Windows.Forms.Button
        Me.Cmd_Uda = New System.Windows.Forms.Button
        Me.Cmd_Elem = New System.Windows.Forms.Button
        Me.Cmd_Bestie = New System.Windows.Forms.Button
        Me.Cmd_Art = New System.Windows.Forms.Button
        Me.Tim1 = New System.Windows.Forms.Timer(Me.components)
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.GC_Cmdline = New System.Windows.Forms.TextBox
        Me.Cmb_Tables = New System.Windows.Forms.ComboBox
        Me.Txt_Search = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Line2 = New System.Windows.Forms.Label
        Me.Lbl_Time = New System.Windows.Forms.Label
        Me.Lbl_Commandline = New System.Windows.Forms.Label
        Me.Lbl_OnTable = New System.Windows.Forms.Label
        Me.Lbl_Search = New System.Windows.Forms.Label
        Me.Line1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.bbh = New System.Windows.Forms.Button
        Me.bbm = New System.Windows.Forms.Button
        Me.bbl = New System.Windows.Forms.Button
        Me.bbrl = New System.Windows.Forms.Button
        Me.bbrm = New System.Windows.Forms.Button
        Me.bbrh = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.bcl = New System.Windows.Forms.Button
        Me.bcm = New System.Windows.Forms.Button
        Me.bch = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.bel = New System.Windows.Forms.Button
        Me.bem = New System.Windows.Forms.Button
        Me.beh = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.bfl = New System.Windows.Forms.Button
        Me.bfm = New System.Windows.Forms.Button
        Me.bfh = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.bnl = New System.Windows.Forms.Button
        Me.bnm = New System.Windows.Forms.Button
        Me.bnh = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.bol = New System.Windows.Forms.Button
        Me.bom = New System.Windows.Forms.Button
        Me.boh = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.bsl = New System.Windows.Forms.Button
        Me.bsm = New System.Windows.Forms.Button
        Me.bsh = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.bul = New System.Windows.Forms.Button
        Me.bum = New System.Windows.Forms.Button
        Me.buh = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.bpal = New System.Windows.Forms.Button
        Me.bpam = New System.Windows.Forms.Button
        Me.bpah = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.bpol = New System.Windows.Forms.Button
        Me.bpom = New System.Windows.Forms.Button
        Me.bpoh = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.bpel = New System.Windows.Forms.Button
        Me.bpem = New System.Windows.Forms.Button
        Me.bpeh = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.bt1l = New System.Windows.Forms.Button
        Me.bt1m = New System.Windows.Forms.Button
        Me.bt1h = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.bt2l = New System.Windows.Forms.Button
        Me.bt2m = New System.Windows.Forms.Button
        Me.bt2h = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.bt3l = New System.Windows.Forms.Button
        Me.bt3m = New System.Windows.Forms.Button
        Me.bt3h = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.btc = New System.Windows.Forms.Button
        Me.btd = New System.Windows.Forms.Button
        Me.BtRoo = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Cmd_Vantages = New System.Windows.Forms.Button
        Me.Pic_Main.SuspendLayout()
        CType(Me.pbDupli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VScroll1
        '
        Me.VScroll1.Cursor = System.Windows.Forms.Cursors.Default
        Me.VScroll1.LargeChange = 300
        Me.VScroll1.Location = New System.Drawing.Point(1877, 144)
        Me.VScroll1.Maximum = 33066
        Me.VScroll1.Name = "VScroll1"
        Me.VScroll1.Size = New System.Drawing.Size(17, 860)
        Me.VScroll1.SmallChange = 30
        Me.VScroll1.TabIndex = 40
        Me.VScroll1.TabStop = True
        '
        'HScroll1
        '
        Me.HScroll1.Cursor = System.Windows.Forms.Cursors.Default
        Me.HScroll1.LargeChange = 300
        Me.HScroll1.Location = New System.Drawing.Point(272, 1004)
        Me.HScroll1.Maximum = 33066
        Me.HScroll1.Name = "HScroll1"
        Me.HScroll1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HScroll1.Size = New System.Drawing.Size(1603, 17)
        Me.HScroll1.SmallChange = 30
        Me.HScroll1.TabIndex = 39
        Me.HScroll1.TabStop = True
        '
        'Cmd_Arts
        '
        Me.Cmd_Arts.AutoEllipsis = True
        Me.Cmd_Arts.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Arts.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Arts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Arts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Arts.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Arts.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Arts.Location = New System.Drawing.Point(813, 90)
        Me.Cmd_Arts.Name = "Cmd_Arts"
        Me.Cmd_Arts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Arts.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Arts.TabIndex = 37
        Me.Cmd_Arts.Text = "Umění"
        Me.Cmd_Arts.UseVisualStyleBackColor = False
        '
        'Cmd_PSI
        '
        Me.Cmd_PSI.AutoEllipsis = True
        Me.Cmd_PSI.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_PSI.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_PSI.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_PSI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_PSI.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_PSI.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_PSI.Location = New System.Drawing.Point(1353, 90)
        Me.Cmd_PSI.Name = "Cmd_PSI"
        Me.Cmd_PSI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_PSI.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_PSI.TabIndex = 36
        Me.Cmd_PSI.Text = "Psionics"
        Me.Cmd_PSI.UseVisualStyleBackColor = False
        '
        'Cmd_ClassRules
        '
        Me.Cmd_ClassRules.AutoEllipsis = True
        Me.Cmd_ClassRules.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_ClassRules.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_ClassRules.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_ClassRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_ClassRules.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_ClassRules.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_ClassRules.Location = New System.Drawing.Point(633, 90)
        Me.Cmd_ClassRules.Name = "Cmd_ClassRules"
        Me.Cmd_ClassRules.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_ClassRules.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_ClassRules.TabIndex = 35
        Me.Cmd_ClassRules.Text = "ClassRule"
        Me.Cmd_ClassRules.UseVisualStyleBackColor = False
        '
        'Cmd_we
        '
        Me.Cmd_we.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_we.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_we.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_we.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_we.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_we.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_we.Location = New System.Drawing.Point(1713, 90)
        Me.Cmd_we.Name = "Cmd_we"
        Me.Cmd_we.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_we.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_we.TabIndex = 34
        Me.Cmd_we.Text = "Efektivita"
        Me.Cmd_we.UseVisualStyleBackColor = False
        '
        'Cmd_Rul
        '
        Me.Cmd_Rul.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Rul.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Rul.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Rul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Rul.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Rul.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Rul.Location = New System.Drawing.Point(1533, 90)
        Me.Cmd_Rul.Name = "Cmd_Rul"
        Me.Cmd_Rul.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Rul.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Rul.TabIndex = 33
        Me.Cmd_Rul.Text = "Pravidla"
        Me.Cmd_Rul.UseVisualStyleBackColor = False
        '
        'Cmd_Not
        '
        Me.Cmd_Not.AutoEllipsis = True
        Me.Cmd_Not.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Not.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Not.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Not.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Not.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Not.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Not.Location = New System.Drawing.Point(453, 90)
        Me.Cmd_Not.Name = "Cmd_Not"
        Me.Cmd_Not.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Not.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Not.TabIndex = 32
        Me.Cmd_Not.Text = "Poznámky"
        Me.Cmd_Not.UseVisualStyleBackColor = False
        '
        'Cmd_Rac
        '
        Me.Cmd_Rac.AutoEllipsis = True
        Me.Cmd_Rac.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Rac.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Rac.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Rac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Rac.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Rac.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Rac.Location = New System.Drawing.Point(273, 90)
        Me.Cmd_Rac.Name = "Cmd_Rac"
        Me.Cmd_Rac.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Rac.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Rac.TabIndex = 31
        Me.Cmd_Rac.Text = "Rasy"
        Me.Cmd_Rac.UseVisualStyleBackColor = False
        '
        'Pic_Main
        '
        Me.Pic_Main.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Pic_Main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pic_Main.Controls.Add(Me.pbDupli)
        Me.Pic_Main.Controls.Add(Me.Picture2)
        Me.Pic_Main.Cursor = System.Windows.Forms.Cursors.Default
        Me.Pic_Main.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pic_Main.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Pic_Main.Location = New System.Drawing.Point(272, 144)
        Me.Pic_Main.Name = "Pic_Main"
        Me.Pic_Main.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Pic_Main.Size = New System.Drawing.Size(1605, 860)
        Me.Pic_Main.TabIndex = 28
        Me.Pic_Main.TabStop = True
        '
        'pbDupli
        '
        Me.pbDupli.Location = New System.Drawing.Point(32, 312)
        Me.pbDupli.Name = "pbDupli"
        Me.pbDupli.Size = New System.Drawing.Size(136, 208)
        Me.pbDupli.TabIndex = 39
        Me.pbDupli.TabStop = False
        Me.pbDupli.Visible = False
        '
        'Picture2
        '
        Me.Picture2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Picture2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture2.Location = New System.Drawing.Point(0, 2)
        Me.Picture2.Name = "Picture2"
        Me.Picture2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture2.Size = New System.Drawing.Size(1601, 856)
        Me.Picture2.TabIndex = 38
        Me.Picture2.TabStop = False
        '
        'Lst_Images
        '
        Me.Lst_Images.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Lst_Images.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_Images.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lst_Images.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lst_Images.ItemHeight = 17
        Me.Lst_Images.Location = New System.Drawing.Point(16, 525)
        Me.Lst_Images.Name = "Lst_Images"
        Me.Lst_Images.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_Images.Size = New System.Drawing.Size(227, 276)
        Me.Lst_Images.TabIndex = 27
        '
        'Lst_Categories
        '
        Me.Lst_Categories.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Lst_Categories.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_Categories.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lst_Categories.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lst_Categories.ItemHeight = 17
        Me.Lst_Categories.Location = New System.Drawing.Point(16, 266)
        Me.Lst_Categories.Name = "Lst_Categories"
        Me.Lst_Categories.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_Categories.Size = New System.Drawing.Size(227, 208)
        Me.Lst_Categories.TabIndex = 26
        '
        'Cmd_Slov
        '
        Me.Cmd_Slov.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Slov.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Slov.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Slov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Slov.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Slov.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Slov.Location = New System.Drawing.Point(1713, 50)
        Me.Cmd_Slov.Name = "Cmd_Slov"
        Me.Cmd_Slov.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Slov.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Slov.TabIndex = 25
        Me.Cmd_Slov.Text = "Slovník"
        Me.Cmd_Slov.UseVisualStyleBackColor = False
        '
        'Cmd_Zbra
        '
        Me.Cmd_Zbra.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Zbra.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Zbra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Zbra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Zbra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Zbra.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Zbra.Location = New System.Drawing.Point(1533, 50)
        Me.Cmd_Zbra.Name = "Cmd_Zbra"
        Me.Cmd_Zbra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Zbra.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Zbra.TabIndex = 24
        Me.Cmd_Zbra.Text = "Zbraně"
        Me.Cmd_Zbra.UseVisualStyleBackColor = False
        '
        'Cmd_Spells
        '
        Me.Cmd_Spells.AutoEllipsis = True
        Me.Cmd_Spells.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Spells.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Spells.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Spells.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Spells.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Spells.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Spells.Location = New System.Drawing.Point(1353, 50)
        Me.Cmd_Spells.Name = "Cmd_Spells"
        Me.Cmd_Spells.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Spells.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Spells.TabIndex = 23
        Me.Cmd_Spells.Text = "Kouzla"
        Me.Cmd_Spells.UseVisualStyleBackColor = False
        '
        'Cmd_Dov
        '
        Me.Cmd_Dov.AutoEllipsis = True
        Me.Cmd_Dov.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Dov.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Dov.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Dov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Dov.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Dov.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Dov.Location = New System.Drawing.Point(1173, 50)
        Me.Cmd_Dov.Name = "Cmd_Dov"
        Me.Cmd_Dov.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Dov.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Dov.TabIndex = 22
        Me.Cmd_Dov.Text = "Skilly"
        Me.Cmd_Dov.UseVisualStyleBackColor = False
        '
        'Cmd_Site
        '
        Me.Cmd_Site.AutoEllipsis = True
        Me.Cmd_Site.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Site.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Site.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Site.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Site.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Site.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Site.Location = New System.Drawing.Point(993, 50)
        Me.Cmd_Site.Name = "Cmd_Site"
        Me.Cmd_Site.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Site.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Site.TabIndex = 21
        Me.Cmd_Site.Text = "Místa"
        Me.Cmd_Site.UseVisualStyleBackColor = False
        '
        'Cmd_Osob
        '
        Me.Cmd_Osob.AutoEllipsis = True
        Me.Cmd_Osob.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Osob.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Osob.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Osob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Osob.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Osob.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Osob.Location = New System.Drawing.Point(813, 50)
        Me.Cmd_Osob.Name = "Cmd_Osob"
        Me.Cmd_Osob.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Osob.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Osob.TabIndex = 20
        Me.Cmd_Osob.Text = "Osoby"
        Me.Cmd_Osob.UseVisualStyleBackColor = False
        '
        'Cmd_Hesla
        '
        Me.Cmd_Hesla.AutoEllipsis = True
        Me.Cmd_Hesla.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Hesla.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Hesla.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Hesla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Hesla.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Hesla.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Hesla.Location = New System.Drawing.Point(633, 50)
        Me.Cmd_Hesla.Name = "Cmd_Hesla"
        Me.Cmd_Hesla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Hesla.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Hesla.TabIndex = 19
        Me.Cmd_Hesla.Text = "Hesla"
        Me.Cmd_Hesla.UseVisualStyleBackColor = False
        '
        'Cmd_Org
        '
        Me.Cmd_Org.AutoEllipsis = True
        Me.Cmd_Org.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Org.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Org.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Org.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Org.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Org.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Org.Location = New System.Drawing.Point(453, 50)
        Me.Cmd_Org.Name = "Cmd_Org"
        Me.Cmd_Org.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Org.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Org.TabIndex = 18
        Me.Cmd_Org.Text = "Organizace"
        Me.Cmd_Org.UseVisualStyleBackColor = False
        '
        'Cmd_Nat
        '
        Me.Cmd_Nat.AutoEllipsis = True
        Me.Cmd_Nat.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Nat.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Nat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Nat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Nat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Nat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Nat.Location = New System.Drawing.Point(273, 50)
        Me.Cmd_Nat.Name = "Cmd_Nat"
        Me.Cmd_Nat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Nat.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Nat.TabIndex = 17
        Me.Cmd_Nat.Text = "Národy"
        Me.Cmd_Nat.UseVisualStyleBackColor = False
        '
        'Cmd_Jaz
        '
        Me.Cmd_Jaz.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Jaz.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Jaz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Jaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Jaz.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Jaz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Jaz.Location = New System.Drawing.Point(1713, 10)
        Me.Cmd_Jaz.Name = "Cmd_Jaz"
        Me.Cmd_Jaz.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Jaz.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Jaz.TabIndex = 16
        Me.Cmd_Jaz.Text = "Jazyky"
        Me.Cmd_Jaz.UseVisualStyleBackColor = False
        '
        'Cmd_Price
        '
        Me.Cmd_Price.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Price.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Price.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Price.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Price.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Price.Location = New System.Drawing.Point(1533, 10)
        Me.Cmd_Price.Name = "Cmd_Price"
        Me.Cmd_Price.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Price.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Price.TabIndex = 15
        Me.Cmd_Price.Text = "Cenník"
        Me.Cmd_Price.UseVisualStyleBackColor = False
        '
        'Cmd_Items
        '
        Me.Cmd_Items.AutoEllipsis = True
        Me.Cmd_Items.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Items.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Items.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Items.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Items.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Items.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Items.Location = New System.Drawing.Point(1353, 10)
        Me.Cmd_Items.Name = "Cmd_Items"
        Me.Cmd_Items.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Items.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Items.TabIndex = 14
        Me.Cmd_Items.Text = "Itemy"
        Me.Cmd_Items.UseVisualStyleBackColor = False
        '
        'Cmd_Info
        '
        Me.Cmd_Info.AutoEllipsis = True
        Me.Cmd_Info.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Info.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Info.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Info.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Info.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Info.Location = New System.Drawing.Point(1173, 10)
        Me.Cmd_Info.Name = "Cmd_Info"
        Me.Cmd_Info.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Info.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Info.TabIndex = 13
        Me.Cmd_Info.Text = "Info"
        Me.Cmd_Info.UseVisualStyleBackColor = False
        '
        'Cmd_Post
        '
        Me.Cmd_Post.AutoEllipsis = True
        Me.Cmd_Post.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Post.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Post.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Post.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Post.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Post.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Post.Location = New System.Drawing.Point(993, 10)
        Me.Cmd_Post.Name = "Cmd_Post"
        Me.Cmd_Post.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Post.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Post.TabIndex = 12
        Me.Cmd_Post.Text = "Postavy"
        Me.Cmd_Post.UseVisualStyleBackColor = False
        '
        'Cmd_Uda
        '
        Me.Cmd_Uda.AutoEllipsis = True
        Me.Cmd_Uda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Uda.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Uda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Uda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Uda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Uda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Uda.Location = New System.Drawing.Point(813, 10)
        Me.Cmd_Uda.Name = "Cmd_Uda"
        Me.Cmd_Uda.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Uda.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Uda.TabIndex = 11
        Me.Cmd_Uda.Text = "Události"
        Me.Cmd_Uda.UseVisualStyleBackColor = False
        '
        'Cmd_Elem
        '
        Me.Cmd_Elem.AutoEllipsis = True
        Me.Cmd_Elem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Elem.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Elem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Elem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Elem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Elem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Elem.Location = New System.Drawing.Point(633, 10)
        Me.Cmd_Elem.Name = "Cmd_Elem"
        Me.Cmd_Elem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Elem.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Elem.TabIndex = 10
        Me.Cmd_Elem.Text = "Elementy"
        Me.Cmd_Elem.UseVisualStyleBackColor = False
        '
        'Cmd_Bestie
        '
        Me.Cmd_Bestie.AutoEllipsis = True
        Me.Cmd_Bestie.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Bestie.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Bestie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Bestie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Bestie.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Bestie.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Bestie.Location = New System.Drawing.Point(453, 10)
        Me.Cmd_Bestie.Name = "Cmd_Bestie"
        Me.Cmd_Bestie.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Bestie.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Bestie.TabIndex = 9
        Me.Cmd_Bestie.Text = "Bestie"
        Me.Cmd_Bestie.UseVisualStyleBackColor = False
        '
        'Cmd_Art
        '
        Me.Cmd_Art.AutoEllipsis = True
        Me.Cmd_Art.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Art.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Art.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Art.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Art.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Art.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Art.Location = New System.Drawing.Point(273, 10)
        Me.Cmd_Art.Margin = New System.Windows.Forms.Padding(0)
        Me.Cmd_Art.Name = "Cmd_Art"
        Me.Cmd_Art.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Art.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Art.TabIndex = 8
        Me.Cmd_Art.Text = "Artefakty"
        Me.Cmd_Art.UseVisualStyleBackColor = False
        '
        'Tim1
        '
        Me.Tim1.Enabled = True
        Me.Tim1.Interval = 1000
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmd_Exit.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.Cmd_Exit.FlatAppearance.BorderSize = 2
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Exit.Location = New System.Drawing.Point(16, 1065)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Exit.Size = New System.Drawing.Size(227, 86)
        Me.Cmd_Exit.TabIndex = 6
        Me.Cmd_Exit.Text = "EXIT"
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'GC_Cmdline
        '
        Me.GC_Cmdline.AcceptsReturn = True
        Me.GC_Cmdline.BackColor = System.Drawing.Color.Black
        Me.GC_Cmdline.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GC_Cmdline.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GC_Cmdline.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GC_Cmdline.ForeColor = System.Drawing.Color.Green
        Me.GC_Cmdline.Location = New System.Drawing.Point(272, 1065)
        Me.GC_Cmdline.MaxLength = 0
        Me.GC_Cmdline.Multiline = True
        Me.GC_Cmdline.Name = "GC_Cmdline"
        Me.GC_Cmdline.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GC_Cmdline.Size = New System.Drawing.Size(1605, 41)
        Me.GC_Cmdline.TabIndex = 4
        '
        'Cmb_Tables
        '
        Me.Cmb_Tables.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Cmb_Tables.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmb_Tables.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmb_Tables.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmb_Tables.Items.AddRange(New Object() {"All Tables", "Artifacts", "Beasts", "Elements", "Events", "Characters", "Info", "Items", "Languages", "Nations", "Organisations", "Passwords", "Personel", "Pricelist", "Sites", "Skills", "Spells", "Weapons", "Wocabulary", "Races", "Notes", "ClassRule", "Art", "Psionics", "Rules", "Efficiency"})
        Me.Cmb_Tables.Location = New System.Drawing.Point(8, 158)
        Me.Cmb_Tables.Name = "Cmb_Tables"
        Me.Cmb_Tables.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmb_Tables.Size = New System.Drawing.Size(243, 31)
        Me.Cmb_Tables.TabIndex = 3
        '
        'Txt_Search
        '
        Me.Txt_Search.AcceptsReturn = True
        Me.Txt_Search.BackColor = System.Drawing.Color.Navy
        Me.Txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Search.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Search.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Search.Location = New System.Drawing.Point(8, 72)
        Me.Txt_Search.MaxLength = 0
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Search.Size = New System.Drawing.Size(243, 25)
        Me.Txt_Search.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(16, 488)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(227, 33)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "IMAGE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(24, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(211, 33)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "VIEW"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Line2
        '
        Me.Line2.AutoEllipsis = True
        Me.Line2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Line2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Line2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Line2.Location = New System.Drawing.Point(273, 90)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(180, 40)
        Me.Line2.TabIndex = 41
        '
        'Lbl_Time
        '
        Me.Lbl_Time.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Time.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lbl_Time.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lbl_Time.ForeColor = System.Drawing.Color.Yellow
        Me.Lbl_Time.Location = New System.Drawing.Point(16, 841)
        Me.Lbl_Time.Name = "Lbl_Time"
        Me.Lbl_Time.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl_Time.Size = New System.Drawing.Size(227, 39)
        Me.Lbl_Time.TabIndex = 7
        Me.Lbl_Time.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbl_Commandline
        '
        Me.Lbl_Commandline.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Commandline.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lbl_Commandline.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lbl_Commandline.ForeColor = System.Drawing.Color.Green
        Me.Lbl_Commandline.Location = New System.Drawing.Point(272, 1033)
        Me.Lbl_Commandline.Name = "Lbl_Commandline"
        Me.Lbl_Commandline.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl_Commandline.Size = New System.Drawing.Size(304, 25)
        Me.Lbl_Commandline.TabIndex = 5
        Me.Lbl_Commandline.Text = "GC COMMANDLINE"
        '
        'Lbl_OnTable
        '
        Me.Lbl_OnTable.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_OnTable.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lbl_OnTable.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lbl_OnTable.ForeColor = System.Drawing.Color.Yellow
        Me.Lbl_OnTable.Location = New System.Drawing.Point(8, 115)
        Me.Lbl_OnTable.Name = "Lbl_OnTable"
        Me.Lbl_OnTable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl_OnTable.Size = New System.Drawing.Size(243, 36)
        Me.Lbl_OnTable.TabIndex = 2
        Me.Lbl_OnTable.Text = "ON TABLE"
        Me.Lbl_OnTable.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Lbl_Search
        '
        Me.Lbl_Search.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Search.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lbl_Search.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lbl_Search.ForeColor = System.Drawing.Color.Yellow
        Me.Lbl_Search.Location = New System.Drawing.Point(8, 32)
        Me.Lbl_Search.Name = "Lbl_Search"
        Me.Lbl_Search.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl_Search.Size = New System.Drawing.Size(243, 37)
        Me.Lbl_Search.TabIndex = 0
        Me.Lbl_Search.Text = "SEARCH"
        Me.Lbl_Search.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.SystemColors.WindowText
        Me.Line1.Location = New System.Drawing.Point(257, 16)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(3, 1029)
        Me.Line1.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(456, 448)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "B"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'bbh
        '
        Me.bbh.BackColor = System.Drawing.SystemColors.Control
        Me.bbh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bbh.Location = New System.Drawing.Point(456, 448)
        Me.bbh.Name = "bbh"
        Me.bbh.Size = New System.Drawing.Size(24, 24)
        Me.bbh.TabIndex = 44
        Me.bbh.Text = "H"
        Me.bbh.UseVisualStyleBackColor = False
        Me.bbh.Visible = False
        '
        'bbm
        '
        Me.bbm.BackColor = System.Drawing.SystemColors.Control
        Me.bbm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bbm.Location = New System.Drawing.Point(456, 448)
        Me.bbm.Name = "bbm"
        Me.bbm.Size = New System.Drawing.Size(24, 24)
        Me.bbm.TabIndex = 45
        Me.bbm.Text = "M"
        Me.bbm.UseVisualStyleBackColor = False
        Me.bbm.Visible = False
        '
        'bbl
        '
        Me.bbl.BackColor = System.Drawing.SystemColors.Control
        Me.bbl.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bbl.Location = New System.Drawing.Point(456, 448)
        Me.bbl.Name = "bbl"
        Me.bbl.Size = New System.Drawing.Size(24, 24)
        Me.bbl.TabIndex = 46
        Me.bbl.Text = "L"
        Me.bbl.UseVisualStyleBackColor = False
        Me.bbl.Visible = False
        '
        'bbrl
        '
        Me.bbrl.BackColor = System.Drawing.SystemColors.Control
        Me.bbrl.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bbrl.Location = New System.Drawing.Point(456, 448)
        Me.bbrl.Name = "bbrl"
        Me.bbrl.Size = New System.Drawing.Size(24, 24)
        Me.bbrl.TabIndex = 50
        Me.bbrl.Text = "L"
        Me.bbrl.UseVisualStyleBackColor = False
        Me.bbrl.Visible = False
        '
        'bbrm
        '
        Me.bbrm.BackColor = System.Drawing.SystemColors.Control
        Me.bbrm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bbrm.Location = New System.Drawing.Point(456, 448)
        Me.bbrm.Name = "bbrm"
        Me.bbrm.Size = New System.Drawing.Size(24, 24)
        Me.bbrm.TabIndex = 49
        Me.bbrm.Text = "M"
        Me.bbrm.UseVisualStyleBackColor = False
        Me.bbrm.Visible = False
        '
        'bbrh
        '
        Me.bbrh.BackColor = System.Drawing.SystemColors.Control
        Me.bbrh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bbrh.Location = New System.Drawing.Point(456, 448)
        Me.bbrh.Name = "bbrh"
        Me.bbrh.Size = New System.Drawing.Size(24, 24)
        Me.bbrh.TabIndex = 48
        Me.bbrh.Text = "H"
        Me.bbrh.UseVisualStyleBackColor = False
        Me.bbrh.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(456, 448)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "BR"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Visible = False
        '
        'bcl
        '
        Me.bcl.BackColor = System.Drawing.SystemColors.Control
        Me.bcl.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bcl.Location = New System.Drawing.Point(456, 448)
        Me.bcl.Name = "bcl"
        Me.bcl.Size = New System.Drawing.Size(24, 24)
        Me.bcl.TabIndex = 54
        Me.bcl.Text = "L"
        Me.bcl.UseVisualStyleBackColor = False
        Me.bcl.Visible = False
        '
        'bcm
        '
        Me.bcm.BackColor = System.Drawing.SystemColors.Control
        Me.bcm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bcm.Location = New System.Drawing.Point(456, 448)
        Me.bcm.Name = "bcm"
        Me.bcm.Size = New System.Drawing.Size(24, 24)
        Me.bcm.TabIndex = 53
        Me.bcm.Text = "M"
        Me.bcm.UseVisualStyleBackColor = False
        Me.bcm.Visible = False
        '
        'bch
        '
        Me.bch.BackColor = System.Drawing.SystemColors.Control
        Me.bch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bch.Location = New System.Drawing.Point(456, 448)
        Me.bch.Name = "bch"
        Me.bch.Size = New System.Drawing.Size(24, 24)
        Me.bch.TabIndex = 52
        Me.bch.Text = "H"
        Me.bch.UseVisualStyleBackColor = False
        Me.bch.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(456, 448)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "C"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.Visible = False
        '
        'bel
        '
        Me.bel.BackColor = System.Drawing.SystemColors.Control
        Me.bel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bel.Location = New System.Drawing.Point(456, 448)
        Me.bel.Name = "bel"
        Me.bel.Size = New System.Drawing.Size(24, 24)
        Me.bel.TabIndex = 58
        Me.bel.Text = "L"
        Me.bel.UseVisualStyleBackColor = False
        Me.bel.Visible = False
        '
        'bem
        '
        Me.bem.BackColor = System.Drawing.SystemColors.Control
        Me.bem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bem.Location = New System.Drawing.Point(456, 448)
        Me.bem.Name = "bem"
        Me.bem.Size = New System.Drawing.Size(24, 24)
        Me.bem.TabIndex = 57
        Me.bem.Text = "M"
        Me.bem.UseVisualStyleBackColor = False
        Me.bem.Visible = False
        '
        'beh
        '
        Me.beh.BackColor = System.Drawing.SystemColors.Control
        Me.beh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.beh.Location = New System.Drawing.Point(456, 448)
        Me.beh.Name = "beh"
        Me.beh.Size = New System.Drawing.Size(24, 24)
        Me.beh.TabIndex = 56
        Me.beh.Text = "H"
        Me.beh.UseVisualStyleBackColor = False
        Me.beh.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(456, 448)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "E"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.Visible = False
        '
        'bfl
        '
        Me.bfl.BackColor = System.Drawing.SystemColors.Control
        Me.bfl.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bfl.Location = New System.Drawing.Point(456, 448)
        Me.bfl.Name = "bfl"
        Me.bfl.Size = New System.Drawing.Size(24, 24)
        Me.bfl.TabIndex = 62
        Me.bfl.Text = "L"
        Me.bfl.UseVisualStyleBackColor = False
        Me.bfl.Visible = False
        '
        'bfm
        '
        Me.bfm.BackColor = System.Drawing.SystemColors.Control
        Me.bfm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bfm.Location = New System.Drawing.Point(456, 448)
        Me.bfm.Name = "bfm"
        Me.bfm.Size = New System.Drawing.Size(24, 24)
        Me.bfm.TabIndex = 61
        Me.bfm.Text = "M"
        Me.bfm.UseVisualStyleBackColor = False
        Me.bfm.Visible = False
        '
        'bfh
        '
        Me.bfh.BackColor = System.Drawing.SystemColors.Control
        Me.bfh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bfh.Location = New System.Drawing.Point(456, 448)
        Me.bfh.Name = "bfh"
        Me.bfh.Size = New System.Drawing.Size(24, 24)
        Me.bfh.TabIndex = 60
        Me.bfh.Text = "H"
        Me.bfh.UseVisualStyleBackColor = False
        Me.bfh.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(456, 448)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "F"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label7.Visible = False
        '
        'bnl
        '
        Me.bnl.BackColor = System.Drawing.SystemColors.Control
        Me.bnl.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bnl.Location = New System.Drawing.Point(456, 448)
        Me.bnl.Name = "bnl"
        Me.bnl.Size = New System.Drawing.Size(24, 24)
        Me.bnl.TabIndex = 66
        Me.bnl.Text = "L"
        Me.bnl.UseVisualStyleBackColor = False
        Me.bnl.Visible = False
        '
        'bnm
        '
        Me.bnm.BackColor = System.Drawing.SystemColors.Control
        Me.bnm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bnm.Location = New System.Drawing.Point(456, 448)
        Me.bnm.Name = "bnm"
        Me.bnm.Size = New System.Drawing.Size(24, 24)
        Me.bnm.TabIndex = 65
        Me.bnm.Text = "M"
        Me.bnm.UseVisualStyleBackColor = False
        Me.bnm.Visible = False
        '
        'bnh
        '
        Me.bnh.BackColor = System.Drawing.SystemColors.Control
        Me.bnh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bnh.Location = New System.Drawing.Point(456, 448)
        Me.bnh.Name = "bnh"
        Me.bnh.Size = New System.Drawing.Size(24, 24)
        Me.bnh.TabIndex = 64
        Me.bnh.Text = "H"
        Me.bnh.UseVisualStyleBackColor = False
        Me.bnh.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(456, 448)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 16)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "N"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label8.Visible = False
        '
        'bol
        '
        Me.bol.BackColor = System.Drawing.SystemColors.Control
        Me.bol.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bol.Location = New System.Drawing.Point(456, 448)
        Me.bol.Name = "bol"
        Me.bol.Size = New System.Drawing.Size(24, 24)
        Me.bol.TabIndex = 70
        Me.bol.Text = "L"
        Me.bol.UseVisualStyleBackColor = False
        Me.bol.Visible = False
        '
        'bom
        '
        Me.bom.BackColor = System.Drawing.SystemColors.Control
        Me.bom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bom.Location = New System.Drawing.Point(456, 448)
        Me.bom.Name = "bom"
        Me.bom.Size = New System.Drawing.Size(24, 24)
        Me.bom.TabIndex = 69
        Me.bom.Text = "M"
        Me.bom.UseVisualStyleBackColor = False
        Me.bom.Visible = False
        '
        'boh
        '
        Me.boh.BackColor = System.Drawing.SystemColors.Control
        Me.boh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.boh.Location = New System.Drawing.Point(456, 448)
        Me.boh.Name = "boh"
        Me.boh.Size = New System.Drawing.Size(24, 24)
        Me.boh.TabIndex = 68
        Me.boh.Text = "H"
        Me.boh.UseVisualStyleBackColor = False
        Me.boh.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(456, 448)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 16)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "O"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label9.Visible = False
        '
        'bsl
        '
        Me.bsl.BackColor = System.Drawing.SystemColors.Control
        Me.bsl.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bsl.Location = New System.Drawing.Point(456, 448)
        Me.bsl.Name = "bsl"
        Me.bsl.Size = New System.Drawing.Size(24, 24)
        Me.bsl.TabIndex = 74
        Me.bsl.Text = "L"
        Me.bsl.UseVisualStyleBackColor = False
        Me.bsl.Visible = False
        '
        'bsm
        '
        Me.bsm.BackColor = System.Drawing.SystemColors.Control
        Me.bsm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bsm.Location = New System.Drawing.Point(456, 448)
        Me.bsm.Name = "bsm"
        Me.bsm.Size = New System.Drawing.Size(24, 24)
        Me.bsm.TabIndex = 73
        Me.bsm.Text = "M"
        Me.bsm.UseVisualStyleBackColor = False
        Me.bsm.Visible = False
        '
        'bsh
        '
        Me.bsh.BackColor = System.Drawing.SystemColors.Control
        Me.bsh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bsh.Location = New System.Drawing.Point(456, 448)
        Me.bsh.Name = "bsh"
        Me.bsh.Size = New System.Drawing.Size(24, 24)
        Me.bsh.TabIndex = 72
        Me.bsh.Text = "H"
        Me.bsh.UseVisualStyleBackColor = False
        Me.bsh.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(456, 448)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 16)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "S"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label10.Visible = False
        '
        'bul
        '
        Me.bul.BackColor = System.Drawing.SystemColors.Control
        Me.bul.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bul.Location = New System.Drawing.Point(456, 448)
        Me.bul.Name = "bul"
        Me.bul.Size = New System.Drawing.Size(24, 24)
        Me.bul.TabIndex = 78
        Me.bul.Text = "L"
        Me.bul.UseVisualStyleBackColor = False
        Me.bul.Visible = False
        '
        'bum
        '
        Me.bum.BackColor = System.Drawing.SystemColors.Control
        Me.bum.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bum.Location = New System.Drawing.Point(456, 448)
        Me.bum.Name = "bum"
        Me.bum.Size = New System.Drawing.Size(24, 24)
        Me.bum.TabIndex = 77
        Me.bum.Text = "M"
        Me.bum.UseVisualStyleBackColor = False
        Me.bum.Visible = False
        '
        'buh
        '
        Me.buh.BackColor = System.Drawing.SystemColors.Control
        Me.buh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.buh.Location = New System.Drawing.Point(456, 448)
        Me.buh.Name = "buh"
        Me.buh.Size = New System.Drawing.Size(24, 24)
        Me.buh.TabIndex = 76
        Me.buh.Text = "H"
        Me.buh.UseVisualStyleBackColor = False
        Me.buh.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(456, 448)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 16)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "U"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label11.Visible = False
        '
        'bpal
        '
        Me.bpal.BackColor = System.Drawing.SystemColors.Control
        Me.bpal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bpal.Location = New System.Drawing.Point(456, 448)
        Me.bpal.Name = "bpal"
        Me.bpal.Size = New System.Drawing.Size(24, 24)
        Me.bpal.TabIndex = 82
        Me.bpal.Text = "L"
        Me.bpal.UseVisualStyleBackColor = False
        Me.bpal.Visible = False
        '
        'bpam
        '
        Me.bpam.BackColor = System.Drawing.SystemColors.Control
        Me.bpam.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bpam.Location = New System.Drawing.Point(456, 448)
        Me.bpam.Name = "bpam"
        Me.bpam.Size = New System.Drawing.Size(24, 24)
        Me.bpam.TabIndex = 81
        Me.bpam.Text = "M"
        Me.bpam.UseVisualStyleBackColor = False
        Me.bpam.Visible = False
        '
        'bpah
        '
        Me.bpah.BackColor = System.Drawing.SystemColors.Control
        Me.bpah.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bpah.Location = New System.Drawing.Point(456, 448)
        Me.bpah.Name = "bpah"
        Me.bpah.Size = New System.Drawing.Size(24, 24)
        Me.bpah.TabIndex = 80
        Me.bpah.Text = "H"
        Me.bpah.UseVisualStyleBackColor = False
        Me.bpah.Visible = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(456, 448)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "PANT"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label12.Visible = False
        '
        'bpol
        '
        Me.bpol.BackColor = System.Drawing.SystemColors.Control
        Me.bpol.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bpol.Location = New System.Drawing.Point(456, 448)
        Me.bpol.Name = "bpol"
        Me.bpol.Size = New System.Drawing.Size(24, 24)
        Me.bpol.TabIndex = 86
        Me.bpol.Text = "L"
        Me.bpol.UseVisualStyleBackColor = False
        Me.bpol.Visible = False
        '
        'bpom
        '
        Me.bpom.BackColor = System.Drawing.SystemColors.Control
        Me.bpom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bpom.Location = New System.Drawing.Point(456, 448)
        Me.bpom.Name = "bpom"
        Me.bpom.Size = New System.Drawing.Size(24, 24)
        Me.bpom.TabIndex = 85
        Me.bpom.Text = "M"
        Me.bpom.UseVisualStyleBackColor = False
        Me.bpom.Visible = False
        '
        'bpoh
        '
        Me.bpoh.BackColor = System.Drawing.SystemColors.Control
        Me.bpoh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bpoh.Location = New System.Drawing.Point(456, 448)
        Me.bpoh.Name = "bpoh"
        Me.bpoh.Size = New System.Drawing.Size(24, 24)
        Me.bpoh.TabIndex = 84
        Me.bpoh.Text = "H"
        Me.bpoh.UseVisualStyleBackColor = False
        Me.bpoh.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Yellow
        Me.Label13.Location = New System.Drawing.Point(456, 448)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 16)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "P ON"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label13.Visible = False
        '
        'bpel
        '
        Me.bpel.BackColor = System.Drawing.SystemColors.Control
        Me.bpel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bpel.Location = New System.Drawing.Point(456, 448)
        Me.bpel.Name = "bpel"
        Me.bpel.Size = New System.Drawing.Size(24, 24)
        Me.bpel.TabIndex = 90
        Me.bpel.Text = "L"
        Me.bpel.UseVisualStyleBackColor = False
        Me.bpel.Visible = False
        '
        'bpem
        '
        Me.bpem.BackColor = System.Drawing.SystemColors.Control
        Me.bpem.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bpem.Location = New System.Drawing.Point(456, 448)
        Me.bpem.Name = "bpem"
        Me.bpem.Size = New System.Drawing.Size(24, 24)
        Me.bpem.TabIndex = 89
        Me.bpem.Text = "M"
        Me.bpem.UseVisualStyleBackColor = False
        Me.bpem.Visible = False
        '
        'bpeh
        '
        Me.bpeh.BackColor = System.Drawing.SystemColors.Control
        Me.bpeh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bpeh.Location = New System.Drawing.Point(456, 448)
        Me.bpeh.Name = "bpeh"
        Me.bpeh.Size = New System.Drawing.Size(24, 24)
        Me.bpeh.TabIndex = 88
        Me.bpeh.Text = "H"
        Me.bpeh.UseVisualStyleBackColor = False
        Me.bpeh.Visible = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Yellow
        Me.Label14.Location = New System.Drawing.Point(456, 448)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 16)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "PEE"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label14.Visible = False
        '
        'bt1l
        '
        Me.bt1l.BackColor = System.Drawing.SystemColors.Control
        Me.bt1l.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bt1l.Location = New System.Drawing.Point(456, 448)
        Me.bt1l.Name = "bt1l"
        Me.bt1l.Size = New System.Drawing.Size(24, 24)
        Me.bt1l.TabIndex = 94
        Me.bt1l.Text = "L"
        Me.bt1l.UseVisualStyleBackColor = False
        Me.bt1l.Visible = False
        '
        'bt1m
        '
        Me.bt1m.BackColor = System.Drawing.SystemColors.Control
        Me.bt1m.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bt1m.Location = New System.Drawing.Point(456, 448)
        Me.bt1m.Name = "bt1m"
        Me.bt1m.Size = New System.Drawing.Size(24, 24)
        Me.bt1m.TabIndex = 93
        Me.bt1m.Text = "M"
        Me.bt1m.UseVisualStyleBackColor = False
        Me.bt1m.Visible = False
        '
        'bt1h
        '
        Me.bt1h.BackColor = System.Drawing.SystemColors.Control
        Me.bt1h.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bt1h.Location = New System.Drawing.Point(456, 448)
        Me.bt1h.Name = "bt1h"
        Me.bt1h.Size = New System.Drawing.Size(24, 24)
        Me.bt1h.TabIndex = 92
        Me.bt1h.Text = "H"
        Me.bt1h.UseVisualStyleBackColor = False
        Me.bt1h.Visible = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Yellow
        Me.Label15.Location = New System.Drawing.Point(456, 448)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 16)
        Me.Label15.TabIndex = 91
        Me.Label15.Text = "T1"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label15.Visible = False
        '
        'bt2l
        '
        Me.bt2l.BackColor = System.Drawing.SystemColors.Control
        Me.bt2l.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bt2l.Location = New System.Drawing.Point(456, 448)
        Me.bt2l.Name = "bt2l"
        Me.bt2l.Size = New System.Drawing.Size(24, 24)
        Me.bt2l.TabIndex = 98
        Me.bt2l.Text = "L"
        Me.bt2l.UseVisualStyleBackColor = False
        Me.bt2l.Visible = False
        '
        'bt2m
        '
        Me.bt2m.BackColor = System.Drawing.SystemColors.Control
        Me.bt2m.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bt2m.Location = New System.Drawing.Point(456, 448)
        Me.bt2m.Name = "bt2m"
        Me.bt2m.Size = New System.Drawing.Size(24, 24)
        Me.bt2m.TabIndex = 97
        Me.bt2m.Text = "M"
        Me.bt2m.UseVisualStyleBackColor = False
        Me.bt2m.Visible = False
        '
        'bt2h
        '
        Me.bt2h.BackColor = System.Drawing.SystemColors.Control
        Me.bt2h.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bt2h.Location = New System.Drawing.Point(456, 448)
        Me.bt2h.Name = "bt2h"
        Me.bt2h.Size = New System.Drawing.Size(24, 24)
        Me.bt2h.TabIndex = 96
        Me.bt2h.Text = "H"
        Me.bt2h.UseVisualStyleBackColor = False
        Me.bt2h.Visible = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Yellow
        Me.Label16.Location = New System.Drawing.Point(456, 448)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 16)
        Me.Label16.TabIndex = 95
        Me.Label16.Text = "T2"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label16.Visible = False
        '
        'bt3l
        '
        Me.bt3l.BackColor = System.Drawing.SystemColors.Control
        Me.bt3l.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bt3l.Location = New System.Drawing.Point(456, 448)
        Me.bt3l.Name = "bt3l"
        Me.bt3l.Size = New System.Drawing.Size(24, 24)
        Me.bt3l.TabIndex = 102
        Me.bt3l.Text = "L"
        Me.bt3l.UseVisualStyleBackColor = False
        Me.bt3l.Visible = False
        '
        'bt3m
        '
        Me.bt3m.BackColor = System.Drawing.SystemColors.Control
        Me.bt3m.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bt3m.Location = New System.Drawing.Point(456, 448)
        Me.bt3m.Name = "bt3m"
        Me.bt3m.Size = New System.Drawing.Size(24, 24)
        Me.bt3m.TabIndex = 101
        Me.bt3m.Text = "M"
        Me.bt3m.UseVisualStyleBackColor = False
        Me.bt3m.Visible = False
        '
        'bt3h
        '
        Me.bt3h.BackColor = System.Drawing.SystemColors.Control
        Me.bt3h.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bt3h.Location = New System.Drawing.Point(456, 448)
        Me.bt3h.Name = "bt3h"
        Me.bt3h.Size = New System.Drawing.Size(24, 24)
        Me.bt3h.TabIndex = 100
        Me.bt3h.Text = "H"
        Me.bt3h.UseVisualStyleBackColor = False
        Me.bt3h.Visible = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Yellow
        Me.Label17.Location = New System.Drawing.Point(456, 448)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 16)
        Me.Label17.TabIndex = 99
        Me.Label17.Text = "T3"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label17.Visible = False
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Yellow
        Me.Label18.Location = New System.Drawing.Point(456, 448)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 16)
        Me.Label18.TabIndex = 103
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label18.Visible = False
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Yellow
        Me.Label19.Location = New System.Drawing.Point(456, 448)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 16)
        Me.Label19.TabIndex = 104
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label19.Visible = False
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Yellow
        Me.Label20.Location = New System.Drawing.Point(456, 448)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 16)
        Me.Label20.TabIndex = 105
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label20.Visible = False
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Yellow
        Me.Label21.Location = New System.Drawing.Point(456, 448)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 16)
        Me.Label21.TabIndex = 108
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label21.Visible = False
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Yellow
        Me.Label22.Location = New System.Drawing.Point(456, 448)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 16)
        Me.Label22.TabIndex = 107
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label22.Visible = False
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Yellow
        Me.Label23.Location = New System.Drawing.Point(456, 448)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 16)
        Me.Label23.TabIndex = 106
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label23.Visible = False
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Yellow
        Me.Label24.Location = New System.Drawing.Point(456, 448)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(56, 16)
        Me.Label24.TabIndex = 111
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label24.Visible = False
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Yellow
        Me.Label25.Location = New System.Drawing.Point(456, 448)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 16)
        Me.Label25.TabIndex = 110
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label25.Visible = False
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Yellow
        Me.Label26.Location = New System.Drawing.Point(456, 448)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(56, 16)
        Me.Label26.TabIndex = 109
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label26.Visible = False
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Yellow
        Me.Label27.Location = New System.Drawing.Point(456, 448)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 16)
        Me.Label27.TabIndex = 114
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label27.Visible = False
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Yellow
        Me.Label28.Location = New System.Drawing.Point(456, 448)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(56, 16)
        Me.Label28.TabIndex = 113
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label28.Visible = False
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Yellow
        Me.Label29.Location = New System.Drawing.Point(456, 448)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(56, 16)
        Me.Label29.TabIndex = 112
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label29.Visible = False
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Yellow
        Me.Label30.Location = New System.Drawing.Point(456, 448)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 16)
        Me.Label30.TabIndex = 117
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label30.Visible = False
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Yellow
        Me.Label31.Location = New System.Drawing.Point(456, 448)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(56, 16)
        Me.Label31.TabIndex = 116
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label31.Visible = False
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Yellow
        Me.Label32.Location = New System.Drawing.Point(456, 448)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(56, 16)
        Me.Label32.TabIndex = 115
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label32.Visible = False
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Yellow
        Me.Label33.Location = New System.Drawing.Point(456, 448)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(56, 16)
        Me.Label33.TabIndex = 120
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label33.Visible = False
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Yellow
        Me.Label34.Location = New System.Drawing.Point(456, 448)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(56, 16)
        Me.Label34.TabIndex = 119
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label34.Visible = False
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Yellow
        Me.Label35.Location = New System.Drawing.Point(456, 448)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(56, 16)
        Me.Label35.TabIndex = 118
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label35.Visible = False
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Yellow
        Me.Label36.Location = New System.Drawing.Point(456, 448)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(56, 16)
        Me.Label36.TabIndex = 123
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label36.Visible = False
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Yellow
        Me.Label37.Location = New System.Drawing.Point(456, 448)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(56, 16)
        Me.Label37.TabIndex = 122
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label37.Visible = False
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Yellow
        Me.Label38.Location = New System.Drawing.Point(456, 448)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(56, 16)
        Me.Label38.TabIndex = 121
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label38.Visible = False
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Yellow
        Me.Label39.Location = New System.Drawing.Point(456, 448)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(56, 16)
        Me.Label39.TabIndex = 126
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label39.Visible = False
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Yellow
        Me.Label40.Location = New System.Drawing.Point(456, 448)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(56, 16)
        Me.Label40.TabIndex = 125
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label40.Visible = False
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Yellow
        Me.Label41.Location = New System.Drawing.Point(456, 448)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(56, 16)
        Me.Label41.TabIndex = 124
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label41.Visible = False
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Yellow
        Me.Label42.Location = New System.Drawing.Point(456, 448)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(56, 16)
        Me.Label42.TabIndex = 129
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label42.Visible = False
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Yellow
        Me.Label43.Location = New System.Drawing.Point(456, 448)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(56, 16)
        Me.Label43.TabIndex = 128
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label43.Visible = False
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Yellow
        Me.Label44.Location = New System.Drawing.Point(456, 448)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(56, 16)
        Me.Label44.TabIndex = 127
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label44.Visible = False
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Yellow
        Me.Label45.Location = New System.Drawing.Point(456, 448)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(56, 16)
        Me.Label45.TabIndex = 132
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label45.Visible = False
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Yellow
        Me.Label46.Location = New System.Drawing.Point(456, 448)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(56, 16)
        Me.Label46.TabIndex = 131
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label46.Visible = False
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Yellow
        Me.Label47.Location = New System.Drawing.Point(456, 448)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(56, 16)
        Me.Label47.TabIndex = 130
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label47.Visible = False
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Yellow
        Me.Label48.Location = New System.Drawing.Point(456, 448)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(56, 16)
        Me.Label48.TabIndex = 135
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label48.Visible = False
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Yellow
        Me.Label49.Location = New System.Drawing.Point(456, 448)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(56, 16)
        Me.Label49.TabIndex = 134
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label49.Visible = False
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Yellow
        Me.Label50.Location = New System.Drawing.Point(456, 448)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(56, 16)
        Me.Label50.TabIndex = 133
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label50.Visible = False
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Yellow
        Me.Label51.Location = New System.Drawing.Point(456, 448)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(56, 16)
        Me.Label51.TabIndex = 138
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label51.Visible = False
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Yellow
        Me.Label52.Location = New System.Drawing.Point(456, 448)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(56, 16)
        Me.Label52.TabIndex = 137
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label52.Visible = False
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Yellow
        Me.Label53.Location = New System.Drawing.Point(456, 448)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(56, 16)
        Me.Label53.TabIndex = 136
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label53.Visible = False
        '
        'Label54
        '
        Me.Label54.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Yellow
        Me.Label54.Location = New System.Drawing.Point(456, 448)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(56, 16)
        Me.Label54.TabIndex = 141
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label54.Visible = False
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Yellow
        Me.Label55.Location = New System.Drawing.Point(456, 448)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(56, 16)
        Me.Label55.TabIndex = 140
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label55.Visible = False
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Yellow
        Me.Label56.Location = New System.Drawing.Point(456, 448)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(56, 16)
        Me.Label56.TabIndex = 139
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label56.Visible = False
        '
        'Label57
        '
        Me.Label57.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Yellow
        Me.Label57.Location = New System.Drawing.Point(456, 448)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(56, 16)
        Me.Label57.TabIndex = 144
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label57.Visible = False
        '
        'Label58
        '
        Me.Label58.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Yellow
        Me.Label58.Location = New System.Drawing.Point(456, 448)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(56, 16)
        Me.Label58.TabIndex = 143
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label58.Visible = False
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.Yellow
        Me.Label59.Location = New System.Drawing.Point(456, 448)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(56, 16)
        Me.Label59.TabIndex = 142
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label59.Visible = False
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Yellow
        Me.Label60.Location = New System.Drawing.Point(456, 448)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(56, 16)
        Me.Label60.TabIndex = 147
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label60.Visible = False
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.Yellow
        Me.Label61.Location = New System.Drawing.Point(456, 448)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(56, 16)
        Me.Label61.TabIndex = 146
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label61.Visible = False
        '
        'Label62
        '
        Me.Label62.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.Yellow
        Me.Label62.Location = New System.Drawing.Point(456, 448)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(56, 16)
        Me.Label62.TabIndex = 145
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label62.Visible = False
        '
        'Label63
        '
        Me.Label63.BackColor = System.Drawing.Color.Transparent
        Me.Label63.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.Yellow
        Me.Label63.Location = New System.Drawing.Point(456, 448)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(120, 16)
        Me.Label63.TabIndex = 148
        Me.Label63.Text = "SOURCE"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label63.Visible = False
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.Color.Transparent
        Me.Label64.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label64.ForeColor = System.Drawing.Color.Yellow
        Me.Label64.Location = New System.Drawing.Point(456, 448)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(224, 16)
        Me.Label64.TabIndex = 149
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label64.Visible = False
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.Color.Navy
        Me.Label65.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Yellow
        Me.Label65.Location = New System.Drawing.Point(456, 448)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(64, 16)
        Me.Label65.TabIndex = 150
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label65.Visible = False
        '
        'btc
        '
        Me.btc.BackColor = System.Drawing.SystemColors.Control
        Me.btc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btc.Location = New System.Drawing.Point(456, 448)
        Me.btc.Name = "btc"
        Me.btc.Size = New System.Drawing.Size(80, 16)
        Me.btc.TabIndex = 151
        Me.btc.Text = "CHOOSE"
        Me.btc.UseVisualStyleBackColor = False
        Me.btc.Visible = False
        '
        'btd
        '
        Me.btd.BackColor = System.Drawing.SystemColors.Control
        Me.btd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btd.Location = New System.Drawing.Point(456, 448)
        Me.btd.Name = "btd"
        Me.btd.Size = New System.Drawing.Size(80, 16)
        Me.btd.TabIndex = 152
        Me.btd.Text = "DELETE"
        Me.btd.UseVisualStyleBackColor = False
        Me.btd.Visible = False
        '
        'BtRoo
        '
        Me.BtRoo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtRoo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtRoo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtRoo.Image = CType(resources.GetObject("BtRoo.Image"), System.Drawing.Image)
        Me.BtRoo.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtRoo.Location = New System.Drawing.Point(8, 0)
        Me.BtRoo.Name = "BtRoo"
        Me.BtRoo.Size = New System.Drawing.Size(32, 32)
        Me.BtRoo.TabIndex = 153
        Me.BtRoo.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(40, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 32)
        Me.Button2.TabIndex = 154
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(72, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 32)
        Me.Button3.TabIndex = 155
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(104, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 32)
        Me.Button4.TabIndex = 156
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(149, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 32)
        Me.Button5.TabIndex = 157
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(181, 0)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(32, 32)
        Me.Button6.TabIndex = 158
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(213, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(32, 32)
        Me.Button7.TabIndex = 159
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Cmd_Vantages
        '
        Me.Cmd_Vantages.AutoEllipsis = True
        Me.Cmd_Vantages.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cmd_Vantages.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Vantages.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Cmd_Vantages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Vantages.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Cmd_Vantages.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Vantages.Location = New System.Drawing.Point(1173, 90)
        Me.Cmd_Vantages.Name = "Cmd_Vantages"
        Me.Cmd_Vantages.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Vantages.Size = New System.Drawing.Size(180, 40)
        Me.Cmd_Vantages.TabIndex = 160
        Me.Cmd_Vantages.Text = "Vantages"
        Me.Cmd_Vantages.UseVisualStyleBackColor = False
        '
        'AVATAR_MAIN
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1914, 1174)
        Me.Controls.Add(Me.Cmd_Vantages)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtRoo)
        Me.Controls.Add(Me.btd)
        Me.Controls.Add(Me.btc)
        Me.Controls.Add(Me.Label65)
        Me.Controls.Add(Me.Label64)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.Label60)
        Me.Controls.Add(Me.Label61)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.Label59)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.bt3l)
        Me.Controls.Add(Me.bt3m)
        Me.Controls.Add(Me.bt3h)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.bt2l)
        Me.Controls.Add(Me.bt2m)
        Me.Controls.Add(Me.bt2h)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.bt1l)
        Me.Controls.Add(Me.bt1m)
        Me.Controls.Add(Me.bt1h)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.bpel)
        Me.Controls.Add(Me.bpem)
        Me.Controls.Add(Me.bpeh)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.bpol)
        Me.Controls.Add(Me.bpom)
        Me.Controls.Add(Me.bpoh)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.bpal)
        Me.Controls.Add(Me.bpam)
        Me.Controls.Add(Me.bpah)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.bul)
        Me.Controls.Add(Me.bum)
        Me.Controls.Add(Me.buh)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.bsl)
        Me.Controls.Add(Me.bsm)
        Me.Controls.Add(Me.bsh)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.bol)
        Me.Controls.Add(Me.bom)
        Me.Controls.Add(Me.boh)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.bnl)
        Me.Controls.Add(Me.bnm)
        Me.Controls.Add(Me.bnh)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.bfl)
        Me.Controls.Add(Me.bfm)
        Me.Controls.Add(Me.bfh)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bel)
        Me.Controls.Add(Me.bem)
        Me.Controls.Add(Me.beh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bcl)
        Me.Controls.Add(Me.bcm)
        Me.Controls.Add(Me.bch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bbrl)
        Me.Controls.Add(Me.bbrm)
        Me.Controls.Add(Me.bbrh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bbl)
        Me.Controls.Add(Me.bbm)
        Me.Controls.Add(Me.bbh)
        Me.Controls.Add(Me.VScroll1)
        Me.Controls.Add(Me.HScroll1)
        Me.Controls.Add(Me.Cmd_Arts)
        Me.Controls.Add(Me.Cmd_PSI)
        Me.Controls.Add(Me.Cmd_ClassRules)
        Me.Controls.Add(Me.Cmd_we)
        Me.Controls.Add(Me.Cmd_Rul)
        Me.Controls.Add(Me.Cmd_Not)
        Me.Controls.Add(Me.Cmd_Rac)
        Me.Controls.Add(Me.Pic_Main)
        Me.Controls.Add(Me.Lst_Images)
        Me.Controls.Add(Me.Lst_Categories)
        Me.Controls.Add(Me.Cmd_Slov)
        Me.Controls.Add(Me.Cmd_Zbra)
        Me.Controls.Add(Me.Cmd_Spells)
        Me.Controls.Add(Me.Cmd_Dov)
        Me.Controls.Add(Me.Cmd_Site)
        Me.Controls.Add(Me.Cmd_Osob)
        Me.Controls.Add(Me.Cmd_Hesla)
        Me.Controls.Add(Me.Cmd_Org)
        Me.Controls.Add(Me.Cmd_Nat)
        Me.Controls.Add(Me.Cmd_Jaz)
        Me.Controls.Add(Me.Cmd_Price)
        Me.Controls.Add(Me.Cmd_Items)
        Me.Controls.Add(Me.Cmd_Info)
        Me.Controls.Add(Me.Cmd_Post)
        Me.Controls.Add(Me.Cmd_Uda)
        Me.Controls.Add(Me.Cmd_Elem)
        Me.Controls.Add(Me.Cmd_Bestie)
        Me.Controls.Add(Me.Cmd_Art)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.GC_Cmdline)
        Me.Controls.Add(Me.Txt_Search)
        Me.Controls.Add(Me.Cmb_Tables)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.Lbl_Time)
        Me.Controls.Add(Me.Lbl_Commandline)
        Me.Controls.Add(Me.Lbl_OnTable)
        Me.Controls.Add(Me.Lbl_Search)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Label3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "AVATAR_MAIN"
        Me.Opacity = 0.9
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC AVATAR - Odria Surveyor v 5.25 running with DB "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Pic_Main.ResumeLayout(False)
        CType(Me.pbDupli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As AVATAR_MAIN
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As AVATAR_MAIN
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New AVATAR_MAIN()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal value As AVATAR_MAIN)
            m_vb6FormDefInstance = value
        End Set
    End Property
#End Region
    Private Sub Frm_Colors_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AM_Colors.Closed
        If CChang = 1 Then
            Prebarvi()
            Me.Refresh()
        End If
    End Sub

    Private Sub Cmd_Art_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Art.Click
        FArtif = New Frm_Artifacts
        FArtif.Show()
    End Sub

    Private Sub Cmd_Arts_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Arts.Click
        FArt = New Frm_Art
        FArt.Show()
    End Sub

    Private Sub Cmd_Bestie_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Bestie.Click
        FBe = New Frm_Beasts
        FBe.Show()
    End Sub

    Private Sub Cmd_ClassRules_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_ClassRules.Click
        FCR = New Frm_ClassRules
        FCR.Show()
    End Sub

    Private Sub Cmd_Dov_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Dov.Click
        FSk = New Frm_Skills
        FSk.Show()
    End Sub

    Private Sub Cmd_Elem_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Elem.Click
        FEle = New Frm_Elements
        FEle.Show()
    End Sub

    Private Sub Cmd_Hesla_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Hesla.Click
        FPass = New Frm_Passwords
        FPass.Show()
    End Sub

    Private Sub Cmd_Info_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Info.Click
        FIn = New Frm_Info
        FIn.Show()
    End Sub

    Private Sub Cmd_Items_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Items.Click
        FIt = New Frm_Items
        FIt.Show()
    End Sub

    Private Sub Cmd_Jaz_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Jaz.Click
        FLa = New Frm_Languages
        FLa.Show()
    End Sub

    Private Sub Cmd_Nat_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Nat.Click
        FNa = New Frm_Nations
        FNa.Show()
    End Sub

    Private Sub Cmd_Not_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Not.Click
        FNo = New Frm_Notes
        FNo.Show()
    End Sub

    Private Sub Cmd_Org_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Org.Click
        FOrg = New Frm_Organizations
        FOrg.Show()
    End Sub

    Private Sub Cmd_Osob_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Osob.Click
        FPer = New Frm_Personel
        FPer.Show()
    End Sub

    Private Sub Cmd_Post_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Post.Click
        FCHa = New Frm_Chartab
        FCHa.Show()
    End Sub

    Private Sub Cmd_Price_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Price.Click
        FPri = New Frm_Pricelist
        FPri.Show()
    End Sub

    Private Sub Cmd_PSI_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_PSI.Click
        FPsi = New Frm_PSI
        FPsi.Show()
    End Sub

    Private Sub Cmd_Rac_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Rac.Click
        FRa = New Frm_Races
        FRa.Show()
    End Sub

    Private Sub Cmd_Rul_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Rul.Click
        FRu = New Frm_Rules
        FRu.Show()
    End Sub

    Private Sub Cmd_Site_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Site.Click
        FSi = New Frm_Sites
        FSi.Show()
    End Sub

    Private Sub Cmd_Slov_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Slov.Click
        FWo = New Frm_Wocabulary
        FWo.Show()
    End Sub

    Private Sub Cmd_Spells_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Spells.Click
        FSp = New Frm_Spells
        FSp.Show()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
        End
    End Sub



    Private Sub Cmd_Uda_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Uda.Click
        FEve = New Frm_Events
        FEve.Show()
    End Sub

    Private Sub Cmd_we_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_we.Click
        FEff = New Frm_Efficiency
        FEff.Show()
    End Sub

    Private Sub Cmd_Zbra_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Zbra.Click
        FWe = New Frm_Weapons
        FWe.Show()
    End Sub

    Private Sub AVATAR_MAIN_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim I As String
        Dim D As String
        Me.Text = Me.Text & Mid(OPath, 1, Len(OPath) - 4)
        D = Dir("C:\Killman\Work\GC AVATAR v 5.0\Pictures\", FileAttribute.Directory)
        Do While D <> ""
            If D <> "." And D <> ".." Then
                Lst_Categories.Items.Add((D))
            End If
            D = Dir()
        Loop
        I = Dir("C:\Killman\Work\GC AVATAR v 5.0\Pictures\" & VB6.GetItemString(Lst_Categories, 0) & "\*.*")
        Do While I <> ""
            If I <> "." And I <> ".." Then
                Lst_Images.Items.Add((I))
            End If
            I = Dir()
        Loop
        If ProFILE <> "" Then
            Prebarvi()
        End If
        Picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Picture2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Picture2.Image = System.Drawing.Image.FromFile("C:\Killman\Work\GC AVATAR v 5.0\Pictures\" & VB6.GetItemString(Lst_Categories, 0) & "\" & VB6.GetItemString(Lst_Images, 0))

        HScroll1.Maximum = (VB6.PixelsToTwipsX(Picture2.Width) - VB6.PixelsToTwipsX(Pic_Main.Width) + HScroll1.LargeChange - 1)
        VScroll1.Maximum = (VB6.PixelsToTwipsY(Picture2.Height) - VB6.PixelsToTwipsY(Pic_Main.Height) + VScroll1.LargeChange - 1)

        If VB6.PixelsToTwipsY(Pic_Main.Height) > VB6.PixelsToTwipsY(Picture2.Height) Then VScroll1.Visible = False
        If VB6.PixelsToTwipsX(Pic_Main.Width) > VB6.PixelsToTwipsX(Picture2.Width) Then HScroll1.Visible = False
        Dim GCRc As New OleDbCommand
        Dim GCRr As OleDbDataReader
        Try
            Dim m As Image
            GCRc.Connection = Odrialink2
            GCRc.CommandText = "SELECT * FROM Roosters ORDER by TimeR"
            GCRr = GCRc.ExecuteReader
            GCRdat.SelectCommand = GCRc
            If GCRr.HasRows Then
                GCRr.Close()
                GCR.Clear()
                GCRdat.Fill(GCR, "R")
                TAlarm = CStr(GCR.Tables("R").Rows(0)("TimeR"))
                m = Image.FromFile("MISC07a.ico")
                BtRoo.Image = m
            Else
                GCRr.Close()
            End If
        Catch ex As Exception
            MsgBox("Chyba při čtení databáze." + ex.Message, , "Chyba")
            Exit Sub
        End Try
    End Sub

    Private Sub HScroll1_Change(ByVal newScrollValue As Integer)
        Picture2.Left = VB6.TwipsToPixelsX(-newScrollValue)
    End Sub

    Private Sub Lst_Categories_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Lst_Categories.SelectedIndexChanged
        Dim I As String
        Lst_Images.Items.Clear()
        I = Dir("C:\Killman\Work\GC AVATAR v 5.0\Pictures\" & Lst_Categories.Text & "\*.*")
        Do While I <> ""
            If I <> "." And I <> ".." Then
                Lst_Images.Items.Add((I))
            End If
            I = Dir()
        Loop
    End Sub

    Private Sub Lst_Images_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Lst_Images.SelectedIndexChanged
        If Lst_Categories.Text = "" Then
            Picture2.Image = System.Drawing.Image.FromFile("C:\Killman\Work\GC AVATAR v 5.0\Pictures\" & VB6.GetItemString(Lst_Categories, 0) & "\" & Lst_Images.Text)
        Else
            Picture2.Image = System.Drawing.Image.FromFile("C:\Killman\Work\GC AVATAR v 5.0\Pictures\" & Lst_Categories.Text & "\" & Lst_Images.Text)
        End If
        HScroll1.Maximum = (VB6.PixelsToTwipsX(Picture2.Width) - VB6.PixelsToTwipsX(Pic_Main.Width) + HScroll1.LargeChange - 1)
        VScroll1.Maximum = (VB6.PixelsToTwipsY(Picture2.Height) - VB6.PixelsToTwipsY(Pic_Main.Height) + VScroll1.LargeChange - 1)
        If HScroll1.Maximum < 0 Then HScroll1.Maximum = 1
        If VScroll1.Maximum < 0 Then VScroll1.Maximum = 1
        HScroll1.Value = 0
        VScroll1.Value = 0
        HScroll1.Minimum = 0
        VScroll1.Minimum = 0
        If VB6.PixelsToTwipsY(Pic_Main.Height) > VB6.PixelsToTwipsY(Picture2.Height) Then
            VScroll1.Visible = False
        Else
            VScroll1.Visible = True
        End If
        If VB6.PixelsToTwipsX(Pic_Main.Width) > VB6.PixelsToTwipsX(Picture2.Width) Then
            HScroll1.Visible = False
        Else
            HScroll1.Visible = True
        End If
    End Sub

    Private Sub Txt_Search_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Search.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Txt_Search.Text = "" Then
                MsgBox("ID10T Error - Není co hledat, vole.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            If Len(Txt_Search.Text) = 1 Then
                If MsgBox("Jseš si jistej, že chceš hledat jednopísmenný výraz?", MsgBoxStyle.YesNo, "Dotaz") = MsgBoxResult.No Then
                    GoTo EventExitSub
                End If
            End If
            If Cmb_Tables.Text = "" Then
                MsgBox("Není vybrána žádná tabulka, nevím kde to mám hledat!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            Transtr = Txt_Search.Text
            QTable = Cmb_Tables.Text
            Call DBSearch()
        End If
EventExitSub:
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub VScroll1_Change(ByVal newScrollValue As Integer)
        Picture2.Top = VB6.TwipsToPixelsY(-newScrollValue)
    End Sub


    Private Sub GC_Cmdline_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles GC_Cmdline.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim čurák As String
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            KeyAscii = 0
            čurák = GC_Cmdline.Text
            Select Case čurák
                Case Is = "set lrgtext.size 10"
                    GC_lrgtext_s = 10
                    Call REFForms()
                Case Is = "set lrgtext.size 12"
                    GC_lrgtext_s = 12
                    Call REFForms()
                Case Is = "set lrgtext.size normal"
                    GC_lrgtext_s = 8
                    Call REFForms()
                Case Is = "set lrgtext.bckcolor black"
                    GC_lrgtext_bc = "b"
                    Call REFForms()
                Case Is = "set lrgtext.bckcolor normal"
                    GC_lrgtext_bc = ""
                    Call REFForms()
                Case Is = "exe fill_capitals"
                    Call Fill_Capitals()
                Case Is = "set list.first"
                    GC_list = 1
                Case Is = "set list.normal"
                    GC_list = 0
                Case Is = "exe color.adjust"
                    AM_Colors = New Frm_Colors
                    ColVal = ""
                    CChang = 0
                    AM_Colors.ShowDialog()
                Case Is = "exe WikiList"
                    Call PrepForWiki()
                Case Is = "exe sx.command.1"
                    MassControl(1, 192, 16, 905, 65, "")
                    MassControl(1, 8, 32, 100, 420, "")
                    MassControl(2, 390, 390, 410, 410, "")
                    Label3.Location = New Point(40, 8)
                    Label4.Location = New Point(40, 72)
                    Label5.Location = New Point(40, 136)
                    Label6.Location = New Point(40, 200)
                    Label7.Location = New Point(40, 270)
                    Label8.Location = New Point(40, 344)
                    Label9.Location = New Point(40, 416)
                    Label10.Location = New Point(40, 480)
                    Label11.Location = New Point(40, 552)
                    Label12.Location = New Point(200, 8)
                    Label13.Location = New Point(200, 56)
                    Label14.Location = New Point(408, 8)
                    Label15.Location = New Point(608, 8)
                    Label16.Location = New Point(608, 56)
                    Label17.Location = New Point(816, 8)
                    bbh.Location = New Point(48, 24)
                    bbm.Location = New Point(88, 24)
                    bbl.Location = New Point(128, 24)
                    bbrh.Location = New Point(48, 88)
                    bbrm.Location = New Point(88, 88)
                    bbrl.Location = New Point(128, 88)
                    bch.Location = New Point(48, 152)
                    bcm.Location = New Point(88, 152)
                    bcl.Location = New Point(128, 152)
                    beh.Location = New Point(48, 216)
                    bem.Location = New Point(88, 216)
                    bel.Location = New Point(128, 216)
                    bfh.Location = New Point(48, 288)
                    bfm.Location = New Point(88, 288)
                    bfl.Location = New Point(128, 288)
                    bnh.Location = New Point(48, 360)
                    bnm.Location = New Point(88, 360)
                    bnl.Location = New Point(128, 360)
                    boh.Location = New Point(48, 432)
                    bom.Location = New Point(88, 432)
                    bol.Location = New Point(128, 432)
                    bsh.Location = New Point(48, 496)
                    bsm.Location = New Point(88, 496)
                    bsl.Location = New Point(128, 496)
                    buh.Location = New Point(48, 568)
                    bum.Location = New Point(88, 568)
                    bul.Location = New Point(128, 568)
                    bpah.Location = New Point(272, 8)
                    bpam.Location = New Point(312, 8)
                    bpal.Location = New Point(352, 8)
                    bpoh.Location = New Point(272, 56)
                    bpom.Location = New Point(312, 56)
                    bpol.Location = New Point(352, 56)
                    bpeh.Location = New Point(472, 8)
                    bpem.Location = New Point(512, 8)
                    bpel.Location = New Point(552, 8)
                    bt1h.Location = New Point(680, 8)
                    bt1m.Location = New Point(720, 8)
                    bt1l.Location = New Point(760, 8)
                    bt2h.Location = New Point(680, 56)
                    bt2m.Location = New Point(720, 56)
                    bt2l.Location = New Point(760, 56)
                    bt3h.Location = New Point(880, 8)
                    bt3m.Location = New Point(920, 8)
                    bt3l.Location = New Point(960, 8)
                    Label18.Location = New Point(16, 48)
                    Label19.Location = New Point(72, 48)
                    Label20.Location = New Point(128, 48)
                    Label23.Location = New Point(16, 112)
                    Label22.Location = New Point(72, 112)
                    Label21.Location = New Point(128, 112)
                    Label26.Location = New Point(16, 176)
                    Label25.Location = New Point(72, 176)
                    Label24.Location = New Point(128, 176)
                    Label41.Location = New Point(16, 240)
                    Label40.Location = New Point(72, 240)
                    Label39.Location = New Point(128, 240)
                    Label44.Location = New Point(16, 312)
                    Label43.Location = New Point(72, 312)
                    Label42.Location = New Point(128, 312)
                    Label38.Location = New Point(16, 384)
                    Label37.Location = New Point(72, 384)
                    Label36.Location = New Point(128, 384)
                    Label35.Location = New Point(16, 456)
                    Label34.Location = New Point(72, 456)
                    Label33.Location = New Point(128, 456)
                    Label32.Location = New Point(16, 520)
                    Label31.Location = New Point(72, 520)
                    Label30.Location = New Point(128, 520)
                    Label29.Location = New Point(16, 592)
                    Label28.Location = New Point(72, 592)
                    Label27.Location = New Point(128, 592)
                    Label47.Location = New Point(240, 32)
                    Label46.Location = New Point(296, 32)
                    Label45.Location = New Point(352, 32)
                    Label50.Location = New Point(240, 80)
                    Label49.Location = New Point(296, 80)
                    Label48.Location = New Point(352, 80)
                    Label53.Location = New Point(440, 32)
                    Label52.Location = New Point(496, 32)
                    Label51.Location = New Point(552, 32)
                    Label56.Location = New Point(648, 32)
                    Label55.Location = New Point(704, 32)
                    Label54.Location = New Point(760, 32)
                    Label59.Location = New Point(648, 80)
                    Label58.Location = New Point(704, 80)
                    Label57.Location = New Point(760, 80)
                    Label62.Location = New Point(848, 32)
                    Label61.Location = New Point(904, 32)
                    Label60.Location = New Point(960, 32)
                    PaB = "C:\Killman\Work\Staženo\q\Sorted\B"
                    PaBR = "C:\Killman\Work\Staženo\q\Sorted\Br"
                    PaC = "C:\Killman\Obrázky\sw\Sorted\C"
                    PaE = "C:\Killman\Obrázky\sw\Sorted\E"
                    PaN = "C:\Killman\Obrázky\sw\Sorted\Normal"
                    PaF = "C:\Killman\Obrázky\sw\Sorted\Fat"
                    PaO = "C:\Killman\Obrázky\sw\Sorted\O"
                    PaPa = "C:\Killman\Obrázky\sw\Sorted\P\Pant"
                    PaPo = "C:\Killman\Obrázky\sw\Sorted\P\Piss on"
                    PaPe = "C:\Killman\Obrázky\sw\Sorted\P\Pee"
                    PaS = "C:\Killman\Obrázky\sw\Sorted\S"
                    PaU = "C:\Killman\Obrázky\sw\Sorted\U"
                    PaT1 = "C:\Killman\Work\Staženo\q\Sorted\T\1"
                    PaT2 = "C:\Killman\Work\Staženo\q\Sorted\T\2"
                    PaT3 = "C:\Killman\Work\Staženo\q\Sorted\T\3"
                    Label18.Text = CType(Kil.GetFileCount(PaB & "\High" & "\*.*"), String)
                    Label19.Text = CType(Kil.GetFileCount(PaB & "\Mid" & "\*.*"), String)
                    Label20.Text = CType(Kil.GetFileCount(PaB & "\Low" & "\*.*"), String)
                    Label23.Text = CType(Kil.GetFileCount(PaBR & "\High" & "\*.*"), String)
                    Label22.Text = CType(Kil.GetFileCount(PaBR & "\Mid" & "\*.*"), String)
                    Label21.Text = CType(Kil.GetFileCount(PaBR & "\Low" & "\*.*"), String)
                    Label26.Text = CType(Kil.GetFileCount(PaC & "\High" & "\*.*"), String)
                    Label25.Text = CType(Kil.GetFileCount(PaC & "\Mid" & "\*.*"), String)
                    Label24.Text = CType(Kil.GetFileCount(PaC & "\Low" & "\*.*"), String)
                    Label41.Text = CType(Kil.GetFileCount(PaE & "\High" & "\*.*"), String)
                    Label40.Text = CType(Kil.GetFileCount(PaE & "\Mid" & "\*.*"), String)
                    Label39.Text = CType(Kil.GetFileCount(PaE & "\Low" & "\*.*"), String)
                    Label44.Text = CType(Kil.GetFileCount(PaF & "\High" & "\*.*"), String)
                    Label43.Text = CType(Kil.GetFileCount(PaF & "\Mid" & "\*.*"), String)
                    Label42.Text = CType(Kil.GetFileCount(PaF & "\Low" & "\*.*"), String)
                    Label38.Text = CType(Kil.GetFileCount(PaN & "\High" & "\*.*"), String)
                    Label37.Text = CType(Kil.GetFileCount(PaN & "\Mid" & "\*.*"), String)
                    Label36.Text = CType(Kil.GetFileCount(PaN & "\Low" & "\*.*"), String)
                    Label35.Text = CType(Kil.GetFileCount(PaO & "\High" & "\*.*"), String)
                    Label34.Text = CType(Kil.GetFileCount(PaO & "\Mid" & "\*.*"), String)
                    Label33.Text = CType(Kil.GetFileCount(PaO & "\Low" & "\*.*"), String)
                    Label32.Text = CType(Kil.GetFileCount(PaS & "\High" & "\*.*"), String)
                    Label31.Text = CType(Kil.GetFileCount(PaS & "\Mid" & "\*.*"), String)
                    Label30.Text = CType(Kil.GetFileCount(PaS & "\Low" & "\*.*"), String)
                    Label29.Text = CType(Kil.GetFileCount(PaU & "\High" & "\*.*"), String)
                    Label28.Text = CType(Kil.GetFileCount(PaU & "\Mid" & "\*.*"), String)
                    Label27.Text = CType(Kil.GetFileCount(PaU & "\Low" & "\*.*"), String)
                    Label47.Text = CType(Kil.GetFileCount(PaPa & "\High" & "\*.*"), String)
                    Label46.Text = CType(Kil.GetFileCount(PaPa & "\Mid" & "\*.*"), String)
                    Label45.Text = CType(Kil.GetFileCount(PaPa & "\Low" & "\*.*"), String)
                    Label50.Text = CType(Kil.GetFileCount(PaPo & "\High" & "\*.*"), String)
                    Label49.Text = CType(Kil.GetFileCount(PaPo & "\Mid" & "\*.*"), String)
                    Label48.Text = CType(Kil.GetFileCount(PaPo & "\Low" & "\*.*"), String)
                    Label53.Text = CType(Kil.GetFileCount(PaPe & "\High" & "\*.*"), String)
                    Label52.Text = CType(Kil.GetFileCount(PaPe & "\Mid" & "\*.*"), String)
                    Label51.Text = CType(Kil.GetFileCount(PaPe & "\Low" & "\*.*"), String)
                    Label56.Text = CType(Kil.GetFileCount(PaT1 & "\High" & "\*.*"), String)
                    Label55.Text = CType(Kil.GetFileCount(PaT1 & "\Mid" & "\*.*"), String)
                    Label54.Text = CType(Kil.GetFileCount(PaT1 & "\Low" & "\*.*"), String)
                    Label59.Text = CType(Kil.GetFileCount(PaT2 & "\High" & "\*.*"), String)
                    Label58.Text = CType(Kil.GetFileCount(PaT2 & "\Mid" & "\*.*"), String)
                    Label57.Text = CType(Kil.GetFileCount(PaT2 & "\Low" & "\*.*"), String)
                    Label62.Text = CType(Kil.GetFileCount(PaT3 & "\High" & "\*.*"), String)
                    Label61.Text = CType(Kil.GetFileCount(PaT3 & "\Mid" & "\*.*"), String)
                    Label60.Text = CType(Kil.GetFileCount(PaT3 & "\Low" & "\*.*"), String)
                    Label63.Location = New Point(420, 664)
                    Label64.Location = New Point(516, 664)
                    Label65.Location = New Point(740, 664)
                    btc.Location = New Point(808, 664)
                    btd.Location = New Point(920, 664)
                    FolderBrowserDialog1.ShowDialog()
                    Label64.Text = FolderBrowserDialog1.SelectedPath
                    Label65.Text = CStr(Kil.GetFileCount(Label64.Text & "\*.*"))
                    PI = Dir(Label64.Text & "\*.*")
                    Do While PI = "." Or PI = ".."
                        PI = Dir()
                    Loop
                    ShPic()
                Case Is = "exe antiduplex"
                    Dim im1, im2, pat As String
                    Dim imco1, imco2, xq As Long
                    Dim m, n As FileInfo
                    FolderBrowserDialog1.ShowDialog()
                    pat = FolderBrowserDialog1.SelectedPath
                    imco1 = 0
                    imco2 = 0
                    im1 = Dir(pat & "\*.*")
                    Do While im1 <> ""
                        imco1 += 1
                        If im1 <> "." And im1 <> ".." Then
                            m = New FileInfo(pat & "\" & im1)
                            im2 = Dir(pat & "\*.*")
                            Do While im2 <> ""
                                imco2 += 1
                                If imco2 > imco1 Then
                                    n = New FileInfo(pat & "\" & im2)
                                    If m.Length = n.Length Then
                                        Try
                                            Picture2.Image = System.Drawing.Image.FromFile(pat & "\" & im1)
                                        Catch ex As Exception
                                            MsgBox("Nezdařilo se nahrání obrázku " + im1, MsgBoxStyle.OkOnly, "Chyba")
                                        End Try
                                        HScroll1.Maximum = (VB6.PixelsToTwipsX(Picture2.Width) - VB6.PixelsToTwipsX(Pic_Main.Width) + HScroll1.LargeChange - 1)
                                        VScroll1.Maximum = (VB6.PixelsToTwipsY(Picture2.Height) - VB6.PixelsToTwipsY(Pic_Main.Height) + VScroll1.LargeChange - 1)
                                        If HScroll1.Maximum < 0 Then HScroll1.Maximum = 1
                                        If VScroll1.Maximum < 0 Then VScroll1.Maximum = 1
                                        HScroll1.Value = 0
                                        VScroll1.Value = 0
                                        HScroll1.Minimum = 0
                                        VScroll1.Minimum = 0
                                        If VB6.PixelsToTwipsY(Pic_Main.Height) > VB6.PixelsToTwipsY(Picture2.Height) Then
                                            VScroll1.Visible = False
                                        Else
                                            VScroll1.Visible = True
                                        End If
                                        If VB6.PixelsToTwipsX(Pic_Main.Width) > VB6.PixelsToTwipsX(Picture2.Width) Then
                                            HScroll1.Visible = False
                                        Else
                                            HScroll1.Visible = True
                                        End If
                                        Process.Start(pat & "\" & im2)
                                        If MsgBox("Jedná se o duplicitu?", MsgBoxStyle.YesNo, "Zkontroluj") = MsgBoxResult.Yes Then
                                            Kill(pat & "\" & im2)
                                        End If
                                    End If
                                End If
                                im2 = Dir()
                            Loop
                        End If
                        im1 = Dir(pat & "\*.*")
                        xq = 0
                        Do
                            im1 = Dir()
                            xq += 1
                        Loop Until xq = imco1
                        imco2 = 0
                    Loop
                    MsgBox("Antiduplex finished.", MsgBoxStyle.OkOnly, "OK")
                Case Is = "exe folder.integrity"
                    Dim x As Long
                    Dim pat, pre, fi, fir, xstr As String
                    FolderBrowserDialog1.ShowDialog()
                    pat = FolderBrowserDialog1.SelectedPath
                    pre = InputBox("Jaká je správná předpona?", "Dotaz")
                    If Len(pre) = 0 Or Len(pre) > 3 Then
                        MsgBox("Nesprávná předpona", , "Chyba")
                        Exit Sub
                    End If
                    fi = Dir(pat & "\*.*")
                    x = 1
                    Do While fi <> ""
                        If fi <> "." And fi <> ".." Then
                            If Mid(fi, 1, Len(pre)) <> pre Then
                                fir = pre & fi
                            Else
                                fir = fi
                            End If
                            If CType(Mid(fir, Len(pre) + 1, 6), Integer) > x Then
                                xstr = CStr(x)
                                Mid(fir, Len(pre) + 1, 6) = "000000"
                                Mid(fir, Len(pre) + 1 + (7 - Len(xstr)), xstr) = xstr
                            End If
                            If Mid(fir, Len(fir) - 3, 1) <> "." Then
                                fir = Mid(fir, 1, Len(pre) + 6) & ".jpg"
                            Else
                                If Mid(fir, Len(fir) - 2, 3) <> "jpg" And Mid(fir, Len(fir) - 2, 3) <> "gif" And Mid(fir, Len(fir) - 2, 3) <> "bmp" And Mid(fir, Len(fir) - 2, 3) <> "png" And Mid(fir, Len(fir) - 2, 3) <> "tif" Then
                                    Mid(fir, Len(fir) - 2, 3) = "jpg"
                                End If
                            End If
                            If Len(fir) > Len(pre) + 10 Then
                                fir = Mid(fir, 1, Len(pre) + 6) & Mid(fir, Len(fir) - 3, 4)
                            End If
                            If fi <> fir Then
                                FileCopy(pat & "\" & fi, pat & "\" & fir)
                                Kill(pat & "\" & fi)
                            End If
                            x += 1
                        End If
                        fi = Dir()
                    Loop
                    'Case Is = "exe oratest"
                    '    Dim Ncomm As DbCommand = Odrialink2.CreateCommand
                    '    Ncomm.CommandText = "select * from Spells"
                    '    Try
                    '        Dim rdr As DbDataReader = Ncomm.ExecuteReader
                    '        While rdr.Read
                    '            Dim sql As String = "select spellseq.nextval from dual"
                    '            Dim Mcomm As DbCommand = Odrialink3.CreateCommand
                    '            Mcomm.CommandText = sql
                    '            Dim resultNumber As Decimal = 0
                    '            Try
                    '                resultNumber = Mcomm.ExecuteScalar

                    '            Catch ex As Exception
                    '                MsgBox("Chyba pri dotazu na sekvenci", , "Chyba")
                    '            End Try
                    '            Dim Ocomm As OracleCommand = Odrialink3.CreateCommand
                    '            Ocomm.CommandText = "insert into spells(ID, sorig_name, sczech_name, smagenergy, scast_rounds, sduration, sreach, saffect, sspell_type, sspelling_cast, sdifficulty, scast_time, sfatigue, stexto, st1, st2, st3, st4, sdatecre) values (:xpk, :xon, :xcn, :xmg, :xcr, :xdu, :xre, :xaf, :xst, :xsc, :xdi, :xct, :xfa, :xte, :xt1, :xt2, :xt3, :xt4, :xdc)"
                    '            Ocomm.Parameters.Add("xpk", OracleDbType.Decimal).Value = CDbl(resultNumber)
                    '            Ocomm.Parameters.Add("xon", OracleDbType.Varchar2).Value = rdr.GetString(0)
                    '            If Not IsDBNull(rdr.GetValue(1)) Then
                    '                Ocomm.Parameters.Add("xcn", OracleDbType.Varchar2).Value = rdr.GetString(1)
                    '            Else
                    '                Ocomm.Parameters.Add("xcn", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(2)) Then
                    '                Ocomm.Parameters.Add("xmg", OracleDbType.Varchar2).Value = rdr.GetString(2)
                    '            Else
                    '                Ocomm.Parameters.Add("xmg", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(3)) Then
                    '                Ocomm.Parameters.Add("xcr", OracleDbType.Varchar2).Value = rdr.GetString(3)
                    '            Else
                    '                Ocomm.Parameters.Add("xcr", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(4)) Then
                    '                Ocomm.Parameters.Add("xdu", OracleDbType.Varchar2).Value = rdr.GetString(4)
                    '            Else
                    '                Ocomm.Parameters.Add("xdu", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(5)) Then
                    '                Ocomm.Parameters.Add("xre", OracleDbType.Varchar2).Value = rdr.GetString(5)
                    '            Else
                    '                Ocomm.Parameters.Add("xre", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(6)) Then
                    '                Ocomm.Parameters.Add("xaf", OracleDbType.Varchar2).Value = rdr.GetString(6)
                    '            Else
                    '                Ocomm.Parameters.Add("xaf", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(7)) Then
                    '                Ocomm.Parameters.Add("xst", OracleDbType.Varchar2).Value = rdr.GetString(7)
                    '            Else
                    '                Ocomm.Parameters.Add("xst", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(8)) Then
                    '                Ocomm.Parameters.Add("xsc", OracleDbType.Varchar2).Value = rdr.GetString(8)
                    '            Else
                    '                Ocomm.Parameters.Add("xsc", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(9)) Then
                    '                Ocomm.Parameters.Add("xdi", OracleDbType.Varchar2).Value = rdr.GetString(9)
                    '            Else
                    '                Ocomm.Parameters.Add("xdi", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(10)) Then
                    '                Ocomm.Parameters.Add("xct", OracleDbType.Varchar2).Value = rdr.GetString(10)
                    '            Else
                    '                Ocomm.Parameters.Add("xct", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(11)) Then
                    '                Ocomm.Parameters.Add("xfa", OracleDbType.Varchar2).Value = rdr.GetString(11)
                    '            Else
                    '                Ocomm.Parameters.Add("xfa", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(12)) Then
                    '                Ocomm.Parameters.Add("xte", OracleDbType.Varchar2).Value = rdr.GetString(12)
                    '            Else
                    '                Ocomm.Parameters.Add("xte", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(15)) Then
                    '                Ocomm.Parameters.Add("xt1", OracleDbType.Varchar2).Value = rdr.GetString(15)
                    '            Else
                    '                Ocomm.Parameters.Add("xt1", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(16)) Then
                    '                Ocomm.Parameters.Add("xt2", OracleDbType.Varchar2).Value = rdr.GetString(16)
                    '            Else
                    '                Ocomm.Parameters.Add("xt2", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(17)) Then
                    '                Ocomm.Parameters.Add("xt3", OracleDbType.Varchar2).Value = rdr.GetString(17)
                    '            Else
                    '                Ocomm.Parameters.Add("xt3", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(18)) Then
                    '                Ocomm.Parameters.Add("xt4", OracleDbType.Varchar2).Value = rdr.GetString(18)
                    '            Else
                    '                Ocomm.Parameters.Add("xt4", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            Ocomm.Parameters.Add("xdc", OracleDbType.Date).Value = rdr.GetDateTime(14)
                    '            Try
                    '                Ocomm.ExecuteNonQuery()
                    '            Catch ex As Exception
                    '                MsgBox("Chyba pri praci s Oraclem " + ex.Message, , "Chyba")

                    '            End Try
                    '        End While

                    '    Catch ex As Exception
                    '        MsgBox("Proste chyba!", , "Chyba")
                    '    End Try
                    'Case Is = "exe oranations"
                    '    Dim Ncomm As DbCommand = Odrialink2.CreateCommand
                    '    Ncomm.CommandText = "select * from Nations"
                    '    Try
                    '        Dim rdr As DbDataReader = Ncomm.ExecuteReader
                    '        While rdr.Read
                    '            Dim Ocomm As OracleCommand = Odrialink3.CreateCommand
                    '            Ocomm.CommandText = "insert into Nations(ID,NNUMBER,NCONTINENT,NNAME,NCAPITAL,NCITIZENS,NGOV,NRULER,NRCHILDS,NRPARTNER,NRACES,NDIVISION,NNEIGHBORS,NLORDS,NHAPPY,NMAGLEVEL,NRICH,NARMY,NTRAINING,NEXPERIENCE,NLANGUAGE,NEXPORT,NREMARK,NIMPORTANCE,NSIDE) values (:x1, :x2, :x3, :x4, :x5, :x6, :x7, :x8, :x9, :x10, :x11, :x12, :x13, :x14, :x15, :x16, :x17, :x18, :x19, :x20, :x21, :x22, :x23, :x24, :x25)"
                    '            Ocomm.Parameters.Add("x1", OracleDbType.Decimal).Value = rdr.GetValue(24)
                    '            Ocomm.Parameters.Add("x2", OracleDbType.Decimal).Value = rdr.GetValue(0)
                    '            If Not IsDBNull(rdr.GetValue(1)) Then
                    '                Ocomm.Parameters.Add("x3", OracleDbType.Varchar2).Value = rdr.GetString(1)
                    '            Else
                    '                Ocomm.Parameters.Add("x3", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(2)) Then
                    '                Ocomm.Parameters.Add("x4", OracleDbType.Varchar2).Value = rdr.GetString(2)
                    '            Else
                    '                Ocomm.Parameters.Add("x4", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(3)) Then
                    '                Ocomm.Parameters.Add("x5", OracleDbType.Varchar2).Value = rdr.GetString(3)
                    '            Else
                    '                Ocomm.Parameters.Add("x5", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(4)) Then
                    '                Ocomm.Parameters.Add("x6", OracleDbType.Decimal).Value = rdr.GetValue(4)
                    '            Else
                    '                Ocomm.Parameters.Add("x6", OracleDbType.Decimal).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(5)) Then
                    '                Ocomm.Parameters.Add("x7", OracleDbType.Varchar2).Value = rdr.GetString(5)
                    '            Else
                    '                Ocomm.Parameters.Add("x7", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(6)) Then
                    '                Ocomm.Parameters.Add("x8", OracleDbType.Varchar2).Value = rdr.GetString(6)
                    '            Else
                    '                Ocomm.Parameters.Add("x8", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(7)) Then
                    '                Ocomm.Parameters.Add("x9", OracleDbType.Varchar2).Value = rdr.GetString(7)
                    '            Else
                    '                Ocomm.Parameters.Add("x9", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(8)) Then
                    '                Ocomm.Parameters.Add("x10", OracleDbType.Varchar2).Value = rdr.GetString(8)
                    '            Else
                    '                Ocomm.Parameters.Add("x10", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(9)) Then
                    '                Ocomm.Parameters.Add("x11", OracleDbType.Varchar2).Value = rdr.GetString(9)
                    '            Else
                    '                Ocomm.Parameters.Add("x11", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(10)) Then
                    '                Ocomm.Parameters.Add("x12", OracleDbType.Varchar2).Value = rdr.GetString(10)
                    '            Else
                    '                Ocomm.Parameters.Add("x12", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(11)) Then
                    '                Ocomm.Parameters.Add("x13", OracleDbType.Varchar2).Value = rdr.GetString(11)
                    '            Else
                    '                Ocomm.Parameters.Add("x13", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(12)) Then
                    '                Ocomm.Parameters.Add("x14", OracleDbType.Decimal).Value = rdr.GetValue(12)
                    '            Else
                    '                Ocomm.Parameters.Add("x14", OracleDbType.Decimal).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(13)) Then
                    '                Ocomm.Parameters.Add("x15", OracleDbType.Decimal).Value = rdr.GetValue(13)
                    '            Else
                    '                Ocomm.Parameters.Add("x15", OracleDbType.Decimal).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(14)) Then
                    '                Ocomm.Parameters.Add("x16", OracleDbType.Decimal).Value = rdr.GetValue(14)
                    '            Else
                    '                Ocomm.Parameters.Add("x16", OracleDbType.Decimal).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(15)) Then
                    '                Ocomm.Parameters.Add("x17", OracleDbType.Decimal).Value = rdr.GetValue(15)
                    '            Else
                    '                Ocomm.Parameters.Add("x17", OracleDbType.Decimal).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(16)) Then
                    '                Ocomm.Parameters.Add("x18", OracleDbType.Decimal).Value = rdr.GetValue(16)
                    '            Else
                    '                Ocomm.Parameters.Add("x18", OracleDbType.Decimal).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(17)) Then
                    '                Ocomm.Parameters.Add("x19", OracleDbType.Decimal).Value = rdr.GetValue(17)
                    '            Else
                    '                Ocomm.Parameters.Add("x19", OracleDbType.Decimal).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(18)) Then
                    '                Ocomm.Parameters.Add("x20", OracleDbType.Decimal).Value = rdr.GetValue(18)
                    '            Else
                    '                Ocomm.Parameters.Add("x20", OracleDbType.Decimal).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(19)) Then
                    '                Ocomm.Parameters.Add("x21", OracleDbType.Varchar2).Value = rdr.GetString(19)
                    '            Else
                    '                Ocomm.Parameters.Add("x21", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(20)) Then
                    '                Ocomm.Parameters.Add("x22", OracleDbType.Varchar2).Value = rdr.GetString(20)
                    '            Else
                    '                Ocomm.Parameters.Add("x22", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(21)) Then
                    '                Ocomm.Parameters.Add("x23", OracleDbType.Varchar2).Value = rdr.GetString(21)
                    '            Else
                    '                Ocomm.Parameters.Add("x23", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(22)) Then
                    '                Ocomm.Parameters.Add("x24", OracleDbType.Decimal).Value = rdr.GetValue(22)
                    '            Else
                    '                Ocomm.Parameters.Add("x24", OracleDbType.Decimal).Value = DBNull.Value
                    '            End If
                    '            If Not IsDBNull(rdr.GetValue(23)) Then
                    '                Ocomm.Parameters.Add("x25", OracleDbType.Varchar2).Value = rdr.GetString(23)
                    '            Else
                    '                Ocomm.Parameters.Add("x25", OracleDbType.Varchar2).Value = DBNull.Value
                    '            End If
                    '            Try
                    '                Ocomm.ExecuteNonQuery()
                    '            Catch ex As Exception
                    '                MsgBox("Chyba pri praci s Oraclem " + ex.Message, , "Chyba")

                    '            End Try
                    '        End While

                    '    Catch ex As Exception
                    '        MsgBox("Proste chyba!", , "Chyba")
                    '    End Try
                    'Case Is = "exe oranotes"
                    '    Dim Ncomm As DbCommand = Odrialink2.CreateCommand
                    '    Ncomm.CommandText = "select * from Notes"
                    '    Try
                    '        Dim rdr As DbDataReader = Ncomm.ExecuteReader
                    '        While rdr.Read
                    '            Dim Ocomm As OracleCommand = Odrialink3.CreateCommand
                    '            Ocomm.CommandText = "insert into notes(ID, nnote_name, nnote, ndatecre) values (:xpk, :xon, :xcn, :xdc)"
                    '            Ocomm.Parameters.Add("xpk", OracleDbType.Decimal).Value = rdr.GetValue(0)
                    '            Ocomm.Parameters.Add("xon", OracleDbType.Varchar2).Value = rdr.GetString(1)
                    '            Ocomm.Parameters.Add("xcn", OracleDbType.Varchar2).Value = rdr.GetString(2)
                    '            Ocomm.Parameters.Add("xdc", OracleDbType.Date).Value = rdr.GetDateTime(3)
                    '            Try
                    '                Ocomm.ExecuteNonQuery()
                    '            Catch ex As Exception
                    '                MsgBox("Chyba pri praci s Oraclem " + ex.Message, , "Chyba")

                    '            End Try
                    '        End While

                    '    Catch ex As Exception
                    '        MsgBox("Proste chyba!", , "Chyba")
                    '    End Try
                    'Case Is = "exe oraclasskills"
                    '    Dim Ncomm As DbCommand = Odrialink2.CreateCommand
                    '    Ncomm.CommandText = "select * from Class_skills"
                    '    Try
                    '        Dim rdr As DbDataReader = Ncomm.ExecuteReader
                    '        While rdr.Read

                    '            Dim Ocomm As OracleCommand = Odrialink3.CreateCommand
                    '            Ocomm.CommandText = "update Class_skills set cdatecre=:xdc where id=:xid"
                    '            Ocomm.Parameters.Add("xdc", OracleDbType.Date).Value = rdr.GetDateTime(9)
                    '            Ocomm.Parameters.Add("xid", OracleDbType.Decimal).Value = rdr.GetValue(0)
                    '            Try
                    '                Ocomm.ExecuteNonQuery()
                    '            Catch ex As Exception
                    '                MsgBox("Chyba pri praci s Oraclem " + ex.Message, , "Chyba")

                    '            End Try
                    '        End While

                    '    Catch ex As Exception
                    '        MsgBox("Proste chyba!", , "Chyba")
                    '    End Try
                Case Is = "chck longest text"
                    Dim rx As OleDbDataReader
                    Dim rc As OleDbCommand = New OleDbCommand
                    Dim maxt, act As Double
                    maxt = 0
                    act = 0
                    rc.Connection = Odrialink2
                    rc.CommandText = "select notex from notes"
                    rx = rc.ExecuteReader
                    While rx.Read
                        act = Len(rx.GetString(0).ToString)
                        If act > maxt Then
                            maxt = act
                        End If
                    End While
                    rx.Close()
                    MsgBox(maxt)
                Case Else
                    If Mid(čurák, 1, 9) = "set alarm" Then
                        TAlarm = Mid(čurák, 11, Len(čurák) - 10) & ":00"
                    End If
            End Select
            GC_Cmdline.Text = ""
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub


    Private Sub Tim1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Tim1.Tick
        Dim D, DT As String
        Dim T As String
        D = CStr(Today)
        T = CStr(TimeOfDay)
        DT = D & " " & T
        Lbl_Time.Text = DT
        If DT = TAlarm Then
            Rooster()
        Else
            If DT > TAlarm And TAlarm <> "" Then
                TApu = TAlarm
                MoreRoosters()
            End If
        End If
        If Smycka Then
            If MM.EndOfSong Then
                MM.FileName = Mid(MM.FileName, 2, Len(MM.FileName) - 2)
                MM.Play()
            End If
        End If
    End Sub

    Sub REFForms()
        If SP Then
            Call FSp.FillForm()
        End If
    End Sub
    Private Sub HScroll1_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles HScroll1.Scroll
        Select Case eventArgs.Type
            Case System.Windows.Forms.ScrollEventType.EndScroll
                HScroll1_Change(eventArgs.NewValue)
        End Select
    End Sub
    Private Sub VScroll1_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles VScroll1.Scroll
        Select Case eventArgs.Type
            Case System.Windows.Forms.ScrollEventType.EndScroll
                VScroll1_Change(eventArgs.NewValue)
        End Select
    End Sub

    Private Sub HScroll1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HScroll1.ValueChanged
        HScroll1_Change(HScroll1.Value)
    End Sub

    Private Sub VScroll1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles VScroll1.ValueChanged
        VScroll1_Change(VScroll1.Value)
    End Sub

    Sub Prebarvi()
        Me.BackColor = Color.FromArgb(MB1)
        GC_Cmdline.BackColor = Color.FromArgb(MB22)
        Me.ForeColor = Color.FromArgb(MF1)
        Cmd_Exit.ForeColor = Color.FromArgb(MF1)
        MassControl(4, 192, 16, 905, 65, MF1)
        GC_Cmdline.ForeColor = Color.FromArgb(MF22)
        Lbl_Commandline.ForeColor = Color.FromArgb(MF22)
        Lbl_Search.ForeColor = Color.FromArgb(MF33)
        Lbl_OnTable.ForeColor = Color.FromArgb(MF33)
        Label1.ForeColor = Color.FromArgb(MF33)
        Label2.ForeColor = Color.FromArgb(MF33)
        Lbl_Time.ForeColor = Color.FromArgb(MF33)
        Txt_Search.ForeColor = Color.FromArgb(MF44)
        Cmb_Tables.ForeColor = Color.FromArgb(MF44)
        Lst_Categories.ForeColor = Color.FromArgb(MF44)
        Lst_Images.ForeColor = Color.FromArgb(MF44)
        Me.Refresh()
    End Sub

    Private Sub bpam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bpam.Click
        If Label65.Text = "0" Then Exit Sub
        Label46.Text = CStr(Portent(PaPa & "\Mid\PAM", CType(Label46.Text, Long)))
    End Sub

    Private Sub bpal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bpal.Click
        If Label65.Text = "0" Then Exit Sub
        Label45.Text = CStr(Portent(PaPa & "\Low\PAL", CType(Label45.Text, Long)))
    End Sub

    Private Sub bpah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bpah.Click
        If Label65.Text = "0" Then Exit Sub
        Label47.Text = CStr(Portent(PaPa & "\High\PAH", CType(Label47.Text, Long)))
    End Sub

    Private Sub bpol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bpol.Click
        If Label65.Text = "0" Then Exit Sub
        Label48.Text = CStr(Portent(PaPo & "\Low\POL", CType(Label48.Text, Long)))
    End Sub

    Private Sub bpeh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bpeh.Click
        If Label65.Text = "0" Then Exit Sub
        Label53.Text = CStr(Portent(PaPe & "\High\PEH", CType(Label53.Text, Long)))
    End Sub

    Private Sub bpoh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bpoh.Click
        If Label65.Text = "0" Then Exit Sub
        Label50.Text = CStr(Portent(PaPo & "\High\POH", CType(Label50.Text, Long)))
    End Sub

    Private Sub bpom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bpom.Click
        If Label65.Text = "0" Then Exit Sub
        Label49.Text = CStr(Portent(PaPo & "\Mid\POM", CType(Label49.Text, Long)))
    End Sub

    Private Sub bpem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bpem.Click
        If Label65.Text = "0" Then Exit Sub
        Label52.Text = CStr(Portent(PaPe & "\Mid\PEM", CType(Label52.Text, Long)))
    End Sub

    Private Sub bpel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bpel.Click
        If Label65.Text = "0" Then Exit Sub
        Label51.Text = CStr(Portent(PaPe & "\Low\PEL", CType(Label51.Text, Long)))
    End Sub


    Private Sub bbh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbh.Click
        If Label65.Text = "0" Then Exit Sub
        Label18.Text = CStr(Portent(PaB & "\High\BH", CType(Label18.Text, Long)))
    End Sub

    Private Sub bbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbl.Click
        If Label65.Text = "0" Then Exit Sub
        Label20.Text = CStr(Portent(PaB & "\Low\BL", CType(Label20.Text, Long)))
    End Sub

    Private Sub bbm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbm.Click
        If Label65.Text = "0" Then Exit Sub
        Label19.Text = CStr(Portent(PaB & "\Mid\BM", CType(Label19.Text, Long)))
    End Sub

    Sub ShPic()
        Try
            Picture2.Image = System.Drawing.Image.FromFile(Label64.Text & "\" & PI)
        Catch ex As Exception
            If Mid(PI, Len(PI) - 2, 3) = "jpg" Or Mid(PI, Len(PI) - 2, 3) = "gif" Or Mid(PI, Len(PI) - 2, 3) = "bmp" Or Mid(PI, Len(PI) - 2, 3) = "png" Then
                MsgBox("Obrázek " & PI & " je pravděpodobně poškozen.", MsgBoxStyle.OkOnly, "Chyba")
            Else
                MsgBox("Tohle " & PI & " není obrázek.", MsgBoxStyle.OkOnly, "Chyba")
            End If
            Exit Sub
        End Try
        HScroll1.Maximum = (VB6.PixelsToTwipsX(Picture2.Width) - VB6.PixelsToTwipsX(Pic_Main.Width) + HScroll1.LargeChange - 1)
        VScroll1.Maximum = (VB6.PixelsToTwipsY(Picture2.Height) - VB6.PixelsToTwipsY(Pic_Main.Height) + VScroll1.LargeChange - 1)
        If HScroll1.Maximum < 0 Then HScroll1.Maximum = 1
        If VScroll1.Maximum < 0 Then VScroll1.Maximum = 1
        HScroll1.Value = 0
        VScroll1.Value = 0
        HScroll1.Minimum = 0
        VScroll1.Minimum = 0
        If VB6.PixelsToTwipsY(Pic_Main.Height) > VB6.PixelsToTwipsY(Picture2.Height) Then
            VScroll1.Visible = False
        Else
            VScroll1.Visible = True
        End If
        If VB6.PixelsToTwipsX(Pic_Main.Width) > VB6.PixelsToTwipsX(Picture2.Width) Then
            HScroll1.Visible = False
        Else
            HScroll1.Visible = True
        End If
    End Sub

    Private Sub btc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btc.Click
        FolderBrowserDialog1.ShowDialog()
        Label64.Text = FolderBrowserDialog1.SelectedPath
        Label65.Text = CStr(Kil.GetFileCount(Label64.Text & "\*.*"))
        PI = Dir(Label64.Text & "\*.*")
        Do While PI = "." Or PI = ".."
            PI = Dir()
        Loop
        ShPic()
    End Sub

    Private Sub bbrh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbrh.Click
        If Label65.Text = "0" Then Exit Sub
        Label23.Text = CStr(Portent(PaBR & "\High\BRH", CType(Label23.Text, Long)))
    End Sub

    Private Sub bbrm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbrm.Click
        If Label65.Text = "0" Then Exit Sub
        Label22.Text = CStr(Portent(PaBR & "\Mid\BRM", CType(Label22.Text, Long)))
    End Sub

    Private Sub bbrl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bbrl.Click
        If Label65.Text = "0" Then Exit Sub
        Label21.Text = CStr(Portent(PaBR & "\Low\BRL", CType(Label21.Text, Long)))
    End Sub

    Private Sub bch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bch.Click
        If Label65.Text = "0" Then Exit Sub
        Label26.Text = CStr(Portent(PaC & "\High\CH", CType(Label26.Text, Long)))
    End Sub

    Private Sub bcm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcm.Click
        If Label65.Text = "0" Then Exit Sub
        Label25.Text = CStr(Portent(PaC & "\Mid\CM", CType(Label25.Text, Long)))
    End Sub

    Private Sub bcl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcl.Click
        If Label65.Text = "0" Then Exit Sub
        Label24.Text = CStr(Portent(PaC & "\Low\CL", CType(Label24.Text, Long)))
    End Sub

    Private Sub beh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beh.Click
        If Label65.Text = "0" Then Exit Sub
        Label41.Text = CStr(Portent(PaE & "\High\EH", CType(Label41.Text, Long)))
    End Sub

    Private Sub bem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bem.Click
        If Label65.Text = "0" Then Exit Sub
        Label40.Text = CStr(Portent(PaE & "\Mid\EM", CType(Label40.Text, Long)))
    End Sub

    Private Sub bel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bel.Click
        If Label65.Text = "0" Then Exit Sub
        Label39.Text = CStr(Portent(PaE & "\Low\EL", CType(Label39.Text, Long)))
    End Sub

    Private Sub bfh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bfh.Click
        If Label65.Text = "0" Then Exit Sub
        Label44.Text = CStr(Portent(PaF & "\High\FH", CType(Label44.Text, Long)))
    End Sub

    Private Sub bfm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bfm.Click
        If Label65.Text = "0" Then Exit Sub
        Label43.Text = CStr(Portent(PaF & "\Mid\FM", CType(Label43.Text, Long)))
    End Sub

    Private Sub bfl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bfl.Click
        If Label65.Text = "0" Then Exit Sub
        Label42.Text = CStr(Portent(PaF & "\Low\FL", CType(Label42.Text, Long)))
    End Sub

    Private Sub bnh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnh.Click
        If Label65.Text = "0" Then Exit Sub
        Label38.Text = CStr(Portent(PaN & "\High\NH", CType(Label38.Text, Long)))
    End Sub

    Private Sub bnm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnm.Click
        If Label65.Text = "0" Then Exit Sub
        Label37.Text = CStr(Portent(PaN & "\Mid\NM", CType(Label37.Text, Long)))
    End Sub

    Private Sub bnl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnl.Click
        If Label65.Text = "0" Then Exit Sub
        Label36.Text = CStr(Portent(PaN & "\Low\NL", CType(Label36.Text, Long)))
    End Sub

    Private Sub boh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boh.Click
        If Label65.Text = "0" Then Exit Sub
        Label35.Text = CStr(Portent(PaO & "\High\OH", CType(Label35.Text, Long)))
    End Sub

    Private Sub bom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bom.Click
        If Label65.Text = "0" Then Exit Sub
        Label34.Text = CStr(Portent(PaO & "\Mid\OM", CType(Label34.Text, Long)))
    End Sub

    Private Sub bol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bol.Click
        If Label65.Text = "0" Then Exit Sub
        Label33.Text = CStr(Portent(PaO & "\Low\OL", CType(Label33.Text, Long)))
    End Sub

    Private Sub bsh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsh.Click
        If Label65.Text = "0" Then Exit Sub
        Label32.Text = CStr(Portent(PaS & "\High\SH", CType(Label32.Text, Long)))
    End Sub

    Private Sub bsm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsm.Click
        If Label65.Text = "0" Then Exit Sub
        Label31.Text = CStr(Portent(PaS & "\Mid\SM", CType(Label31.Text, Long)))
    End Sub

    Private Sub bsl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsl.Click
        If Label65.Text = "0" Then Exit Sub
        Label30.Text = CStr(Portent(PaS & "\Low\SL", CType(Label30.Text, Long)))
    End Sub

    Private Sub buh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buh.Click
        If Label65.Text = "0" Then Exit Sub
        Label29.Text = CStr(Portent(PaU & "\High\UH", CType(Label29.Text, Long)))
    End Sub

    Private Sub bum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bum.Click
        If Label65.Text = "0" Then Exit Sub
        Label28.Text = CStr(Portent(PaU & "\Mid\UM", CType(Label28.Text, Long)))
    End Sub

    Private Sub bul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bul.Click
        If Label65.Text = "0" Then Exit Sub
        Label27.Text = CStr(Portent(PaU & "\Low\UL", CType(Label27.Text, Long)))
    End Sub

    Private Sub bt1h_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt1h.Click
        If Label65.Text = "0" Then Exit Sub
        Label56.Text = CStr(Portent(PaT1 & "\High\T1H", CType(Label56.Text, Long)))
    End Sub

    Private Sub bt1m_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt1m.Click
        If Label65.Text = "0" Then Exit Sub
        Label55.Text = CStr(Portent(PaT1 & "\Mid\T1M", CType(Label55.Text, Long)))
    End Sub

    Private Sub bt1l_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt1l.Click
        If Label65.Text = "0" Then Exit Sub
        Label54.Text = CStr(Portent(PaT1 & "\Low\T1L", CType(Label54.Text, Long)))
    End Sub

    Private Sub bt2h_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt2h.Click
        If Label65.Text = "0" Then Exit Sub
        Label59.Text = CStr(Portent(PaT2 & "\High\T2H", CType(Label59.Text, Long)))
    End Sub

    Private Sub bt2m_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt2m.Click
        If Label65.Text = "0" Then Exit Sub
        Label58.Text = CStr(Portent(PaT2 & "\Mid\T2M", CType(Label58.Text, Long)))
    End Sub

    Private Sub bt2l_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt2l.Click
        If Label65.Text = "0" Then Exit Sub
        Label57.Text = CStr(Portent(PaT2 & "\Low\T2L", CType(Label57.Text, Long)))
    End Sub

    Private Sub bt3h_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt3h.Click
        If Label65.Text = "0" Then Exit Sub
        Label62.Text = CStr(Portent(PaT3 & "\High\T3H", CType(Label62.Text, Long)))
    End Sub

    Private Sub bt3m_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt3m.Click
        If Label65.Text = "0" Then Exit Sub
        Label61.Text = CStr(Portent(PaT3 & "\Mid\T3M", CType(Label61.Text, Long)))
    End Sub

    Private Sub bt3l_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt3l.Click
        If Label65.Text = "0" Then Exit Sub
        Label60.Text = CStr(Portent(PaT3 & "\Low\T3L", CType(Label60.Text, Long)))
    End Sub

    Private Function Portent(ByRef Path As String, ByRef co As Long) As Long
        Dim po As String
        Dim cd As Long
        If DoubleCheck(Path) Then
            Portent = co
            Exit Function
        End If
        co += 1
        po = CStr(co)
        Do While Len(po) < 6
            po = "0" & po
        Loop
        FileCopy(Label64.Text & "\" & PI, Path & po & Mid(PI, Len(PI) - 3, 4))
        cd = CType(Label65.Text, Long)
        cd -= 1
        Label65.Text = CStr(cd)
        Picture2.Image.Dispose()
        Kill(Label64.Text & "\" & PI)
        If cd > 0 Then
            PI = Dir(Label64.Text & "\*.*")
            ShPic()
        End If
        Portent = co
    End Function

    Private Sub btd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btd.Click
        Dim cd As Long
        cd = CType(Label65.Text, Long)
        cd -= 1
        Label65.Text = CStr(cd)
        Picture2.Image.Dispose()
        Kill(Label64.Text & "\" & PI)
        If cd > 0 Then
            PI = Dir(Label64.Text & "\*.*")
            ShPic()
        End If
    End Sub

    Public Sub MassControl(ByRef op As Int16, ByRef tx As Integer, ByRef ty As Integer, ByRef bx As Integer, ByRef by As Integer, ByRef i1 As String)
        Dim c As Control
        For Each c In Me.Controls
            If (c.Location.X >= tx And c.Location.X <= bx) And (c.Location.Y >= ty And c.Location.Y <= by) Then
                Select Case op
                    Case Is = 1
                        c.Visible = False
                    Case Is = 2
                        c.Visible = True
                    Case Is = 3
                        c.BackColor = Color.FromArgb(i1)
                    Case Is = 4
                        c.ForeColor = Color.FromArgb(i1)
                End Select
            End If
        Next

    End Sub

    Public Sub Rooster()
        Dim P, O As String
        TApu = GCR.Tables("R").Rows(0)("TimeR")
        'MM.FileName = "C:\Mess\Music to play\Crematory\Revolution 2004\Crematory - Revolution - 03 - Greed.mp3"
        Select Case GCR.Tables("R").Rows(0)("Rooster")
            Case Is = 1
                O = GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Kohouti", 1, "")
                If O = "" Then
                    P = "Greed.mp3"
                Else
                    P = O
                End If

            Case Is = 2
                O = GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Kohouti", 2, "")
                If O = "" Then
                    P = "Havranův let.mp3"
                Else
                    P = O
                End If
            Case Is = 3
                O = GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Kohouti", 3, "")
                If O = "" Then
                    P = "Donkey.mp3"
                Else
                    P = O
                End If
            Case Is = 4
                O = GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Kohouti", 4, "")
                If O = "" Then
                    P = "Dědek.mp3"
                Else
                    P = O
                End If
            Case Is = 5
                O = GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Kohouti", 5, "")
                If O = "" Then
                    P = "Habet.mp3"
                Else
                    P = O
                End If
        End Select
        Select Case GCR.Tables("R").Rows(0)("TypeR")
            Case Is = "N"
                MoreRoosters()
                Smycka = False
            Case Is = "C"
                MoreRoosters()
                Smycka = True
            Case Is = "R"
                Dim ttt As Date
                ttt = CDate(TAlarm)
                ttt = DateAdd(DateInterval.Minute, 15, ttt)
                TAlarm = CStr(ttt)
                Smycka = False
        End Select
        MM.FileName = P
        MM.Play()
    End Sub

    Private Function DoubleCheck(ByRef di As String) As Boolean
        Dim f As New FileInfo(Label64.Text & "\" & PI)
        Dim g As FileInfo
        Dim nfl, efl As Long
        Dim w, u As String
        If Mid(di, Len(di) - 2, 1) = "\" Then
            u = Mid(di, 1, Len(di) - 2)
        Else
            u = Mid(di, 1, Len(di) - 3)
        End If
        nfl = f.Length
        w = Dir(u)
        Do While w <> ""
            If w <> "." And w <> ".." Then
                g = New FileInfo(u & "\" & w)
                efl = g.Length
                If efl = nfl Then
                    Try
                        pbDupli.Image = System.Drawing.Image.FromFile(u & "\" & w)
                        If pbDupli.Image.Width = Picture2.Image.Width And pbDupli.Image.Height = Picture2.Image.Height Then
                            Dim im As System.Drawing.Image
                            Dim wi, h As Integer
                            im = pbDupli.Image
                            wi = im.Width / Math.Max(im.Width, im.Height) * 136
                            h = im.Height / Math.Max(im.Width, im.Height) * 136
                            pbDupli.Image = im.GetThumbnailImage(wi, h, Nothing, Nothing)
                            pbDupli.Visible = True
                            If MsgBox("Duplicita?", MsgBoxStyle.YesNo, "Dotaz") = MsgBoxResult.Yes Then
                                DoubleCheck = True
                                pbDupli.Image.Dispose()
                                pbDupli.Visible = False
                                Exit Function
                            End If
                        Else
                            pbDupli.Image.Dispose()
                        End If

                    Catch ex As Exception
                        MsgBox("Chyba! Soubor divný. " + w + " " + ex.Message, , "Pokus o zobrazení")
                    End Try
                End If
            End If
            w = Dir()
        Loop
        DoubleCheck = False
    End Function

    Private Sub BtRoo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtRoo.Click
        If MM.IsPlaying Then
            MM.StopPlay()
            Smycka = False
            MoreRoosters()
        End If
        GC_Rooster = New Frm_Rooster
        GC_Rooster.ShowDialog()
    End Sub

    Public Sub MoreRoosters()
        Try
            Dim rd As New OleDbCommand
            rd.Connection = Odrialink2
            rd.CommandText = "DELETE from Roosters WHERE TimeR = @Tim"
            rd.Parameters.AddWithValue("@Tim", CDate(TApu))
            rd.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Chyba při výmazu případu: " + ex.Message)
            Exit Sub
        End Try
        Dim GCRc As New OleDbCommand
        Dim GCRr As OleDbDataReader
        Try
            Dim m As Image
            GCRc.Connection = Odrialink2
            GCRc.CommandText = "SELECT * FROM Roosters ORDER by TimeR"
            GCRr = GCRc.ExecuteReader
            If GCRr.HasRows Then

                GCRr.Close()
                GCR.Clear()
                GCRdat.Fill(GCR, "R")
                TAlarm = CStr(GCR.Tables("R").Rows(0)("TimeR"))
            Else
                GCRr.Close()
                TAlarm = ""
                m = Image.FromFile("Misc07.ico")
                BtRoo.Image = m
            End If
        Catch ex As Exception
            MsgBox("Chyba při čtení databáze." + ex.Message, , "Chyba")
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Vantages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Vantages.Click
        FVa = New Frm_Vantages
        FVa.Show()
    End Sub
End Class