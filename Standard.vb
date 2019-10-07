Option Strict Off
Option Explicit On 
Imports System.Data.OleDb
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Imports System.Data.Common

Module M_Main
    'Public Odrialink As New ADODB.Connection
    Public Odrialink2 As OleDbConnection
    'Public Odrialink3 As OracleConnection = ConnectionFactory.GetConnection()
    'Public ODrec As New ADODB.Recordset
    Public SPrec As New DataSet
    Public SPdat As New OleDbDataAdapter
    Public BErec As New DataSet
    Public BEdat As New OleDbDataAdapter
    Public NArec As New DataSet
    Public NAdat As New OleDbDataAdapter
    Public ELrec As New DataSet
    Public ELdat As New OleDbDataAdapter
    Public SKrec As New DataSet
    Public SKdat As New OleDbDataAdapter
    Public ITrec As New DataSet
    Public ITdat As New OleDbDataAdapter
    Public OGrec As New DataSet
    Public OGdat As New OleDbDataAdapter
    Public ARrec As New DataSet
    Public ARdat As New OleDbDataAdapter
    Public WErec As New DataSet
    Public WEdat As New OleDbDataAdapter
    Public CHrec As New DataSet
    Public CHdat As New OleDbDataAdapter
    Public EVrec As New DataSet
    Public EVdat As New OleDbDataAdapter
    Public PErec As New DataSet
    Public PEdat As New OleDbDataAdapter
    Public SIrec As New DataSet
    Public SIdat As New OleDbDataAdapter
    Public IOrec As New DataSet
    Public IOdat As New OleDbDataAdapter
    Public WOrec As New DataSet
    Public WOdat As New OleDbDataAdapter
    Public LArec As New DataSet
    Public LAdat As New OleDbDataAdapter
    Public PRrec As New DataSet
    Public PRdat As New OleDbDataAdapter
    Public PArec As New DataSet
    Public PAdat As New OleDbDataAdapter
    Public RArec As New DataSet
    Public RAdat As New OleDbDataAdapter
    Public NOrec As New DataSet
    Public NOdat As New OleDbDataAdapter
    Public RUrec As New DataSet
    Public RUdat As New OleDbDataAdapter
    Public EFrec As New DataSet
    Public EFdat As New OleDbDataAdapter
    Public CRrec As New DataSet
    Public CRdat As New OleDbDataAdapter
    Public PSrec As New DataSet
    Public PSdat As New OleDbDataAdapter
    Public ATrec As New DataSet
    Public ATdat As New OleDbDataAdapter
    Public VArec As New DataSet
    Public VAdat As New OleDbDataAdapter
    'Public pomrec As New ADODB.Recordset
    Public ITSP As New DataSet
    Public ITSPdat As New OleDbDataAdapter
    Public ITSK As New DataSet
    Public ITSKdat As New OleDbDataAdapter
    Public ITEL As New DataSet
    Public ITELdat As New OleDbDataAdapter
    Public ARSP As New DataSet
    Public ARSPdat As New OleDbDataAdapter
    Public ARSK As New DataSet
    Public ARSKdat As New OleDbDataAdapter
    Public AREL As New DataSet
    Public ARELdat As New OleDbDataAdapter
    Public WESP As New DataSet
    Public WESPdat As New OleDbDataAdapter
    Public WESK As New DataSet
    Public WESKdat As New OleDbDataAdapter
    Public WEEL As New DataSet
    Public WEELdat As New OleDbDataAdapter
    Public PEAR As New DataSet
    Public PEARdat As New OleDbDataAdapter
    Public GCR As New DataSet
    Public GCRdat As New OleDbDataAdapter
    Public CHSP As New DataSet
    Public CHSPdat As New OleDbDataAdapter
    Public CHSK As New DataSet
    Public CHSKdat As New OleDbDataAdapter
    Public CHEL As New DataSet
    Public CHELdat As New OleDbDataAdapter
    Public CHIT As New DataSet
    Public CHITdat As New OleDbDataAdapter
    Public CHWE As New DataSet
    Public CHWEdat As New OleDbDataAdapter
    Public CHCS As New DataSet
    Public CHCSdat As New OleDbDataAdapter
    Public CHAD As New DataSet
    Public CHADdat As New OleDbDataAdapter
    Public CHWS As New DataSet
    Public CHWSdat As New OleDbDataAdapter
    Public CHPS As New DataSet
    Public CHPSdat As New OleDbDataAdapter
    Public Tset, Tsetw, Tseta As New DataSet
    Public Transtr, OPath, QTable, Tspell, PI, Ttit, Tday, Tmonth, Tskill, Titem, Tski, Tweap, Tinf, Tpri, Tlan, Tsit, Twoc, Trule, Tnote, Tart, Tcr, Trac, Torg, Tper, Tartif, Tnar, Tef, Tpa, Tbe, Tcha, Tvan As String
    Public Tyear, Tepoch, TAlarm, TApu, Song As String
    Public WIQ, ColVal, MB1, MB22, MF1, MF22, MF33, MF44, COI, COF, COD, CON, COP, COO, COE, COFO, FAB, FAFO, FBB, FBFO, FEB, FEFO, FVB, FVF, FCHB, FCHF, FIB, FIFO, FTB, FTF, FCEB, FCEF, FLB, FLFO, FNB, FNFO, FOB, FOFO, FPAB, FPAFO, FPEB, FPEFO, FMB, FMFO, FSKB, FSKFO, FSPB, FSPFO, FWB, FWFO, FWOB, FWOFO, FRB, FRFO, FNOB, FNOFO, FCRB, FCRFO, FUB, FUF, FPSB, FPSFO, FRUB, FRUFO, FEFB, FEFFO, FVV, FVVF As String
    Public CR, RU, RA, PR, WO, SI, EV, WE, OG, SK, NA, SP, BE, EL, IT, AR, CH, PE, IO, LA, PA, NO, EF, PS, VA As Boolean
    Public Smycka As Boolean
    Public PaB, PaBR, PaC, PaE, PaN, PaF, PaO, PaPa, PaPo, PaPe, PaS, PaU, PaT1, PaT2, PaT3 As String
	Public AT As Boolean
    Public SPcount, SPposition, SPorder As Int64
	Public SPdirect As Short
    Public BEcount, BEposition, BEorder As Int64
	Public BEdirect As Short
    Public NAcount, NAposition, NAorder As Int64
	Public NAdirect As Short
    Public ELposition As Int64
	Public ELcount As Short
    Public SKcount, SKposition, SKorder As Int64
	Public SKdirect As Short
    Public ITcount, ITposition, ITorder As Int64
	Public ITdirect As Short
    Public OGcount, OGposition, OGorder As Int64
	Public OGdirect As Short
    Public ARcount, ARposition, ARorder As Int64
	Public ARdirect As Short
    Public WEcount, WEposition, WEorder As Int64
	Public WEdirect As Short
    Public CHcount, CHposition, CHorder As Int64
	Public CHdirect As Short
    Public EVcount, EVposition, EVorder As Int64
	Public EVdirect As Short
    Public PEcount, PEposition, PEorder As Int64
	Public PEdirect As Short
    Public SIcount, SIposition, SIorder As Int64
	Public SIdirect As Short
    Public IOcount, IOposition, IOorder As Int64
	Public IOdirect As Short
    Public WOcount, WOposition, WOorder As Int64
	Public WOdirect As Short
    Public LAcount, LAposition, LAorder As Int64
	Public LAdirect As Short
    Public PRcount, PRposition, PRorder As Int64
	Public PRdirect As Short
    Public PAcount, PAposition, PAorder As Int64
	Public PAdirect As Short
    Public RAcount, RAposition, RAorder As Int64
	Public RAdirect As Short
    Public NOcount, NOposition, NOorder As Int64
	Public NOdirect As Short
    Public RUcount, RUposition, RUorder As Int64
	Public RUdirect As Short
    Public EFcount, EFposition, EForder As Int64
	Public EFdirect As Short
    Public CRcount, CRposition, CRorder As Int64
	Public CRdirect As Short
    Public PScount, PSposition, PSorder As Int64
	Public PSdirect As Short
    Public ATcount, ATposition, ATorder As Int64
    Public ATdirect As Short
    Public VAcount, VAposition, VAorder As Int64
    Public VAdirect As Short
	Public GC_lrgtext_s As Short
    Public GC_lrgtext_bc As String
    Public GC_list As Short
    Public OrderControl As String
    Public MODE As String
    Public CChang As Integer
    Public OperationP, OnTable As String
    Public OldData, NewData As String
    Public Undergo As Boolean
    Public WithEvents FArt As Frm_Art
    Public WithEvents FArtif As Frm_Artifacts
    Public WithEvents FBe As Frm_Beasts
    Public WithEvents FCR As Frm_ClassRules
    Public WithEvents FEff As Frm_Efficiency
    Public WithEvents FEle As Frm_Elements
    Public WithEvents FELCH As Frm_ELCHoose
    Public WithEvents FEve As Frm_Events
    Public WithEvents FCHa As Frm_Chartab
    Public WithEvents FCHax As Frm_Characters
    Public WithEvents FIn As Frm_Info
    Public WithEvents FITCH As Frm_ITCHoose
    Public WithEvents FIt As Frm_Items
    Public WithEvents FLa As Frm_Languages
    Public WithEvents FNa As Frm_Nations
    Public WithEvents FNo As Frm_Notes
    Public WithEvents FO As Frm_Ordering
    Public WithEvents FOrg As Frm_Organizations
    Public WithEvents FPass As Frm_Passwords
    Public WithEvents FPer As Frm_Personel
    Public WithEvents FPri As Frm_Pricelist
    Public WithEvents FPsi As Frm_PSI
    Public WithEvents FRa As Frm_Races
    Public WithEvents FRu As Frm_Rules
    Public WithEvents FSi As Frm_Sites
    Public WithEvents FSKCH As Frm_SKCHoose
    Public WithEvents FSk As Frm_Skills
    Public WithEvents FSPCH As Frm_SPCHoose
    Public WithEvents FSp As Frm_Spells
    Public WithEvents FWe As Frm_Weapons
    Public WithEvents FWECH As Frm_WECHoose
    Public WithEvents FWo As Frm_Wocabulary
    Public WithEvents FVa As Frm_Vantages
    Public ProFILE As String
    Public Versionnumber As Integer


    Sub Main()
        Dim fp As New Frm_Pass
        fp.ShowDialog()
        Dim str_Renamed, pomi As String
        Versionnumber = 0
        'Versionnumber = GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Database", "Version", 0)
        If Versionnumber = 0 Then
            OPath = Dir(VB6.GetPath & "\Odria *.mdb")
            pomi = Mid(OPath, Len(OPath) - 7, 1) & Mid(OPath, Len(OPath) - 5, 2)
            Versionnumber = CInt(pomi)
        Else
            OPath = VB6.GetPath & "\Odria " & Mid(CStr(Versionnumber), 1, 1) & "." & Mid(CStr(Versionnumber), 2, 2) & ".mdb"

        End If
        str_Renamed = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & OPath & ";Persist Security Info=False;Jet OLEDB:Database Password=arconex"
        'Odrialink.Open(str_Renamed)
        Odrialink2 = New OleDbConnection(str_Renamed)
        Odrialink2.Open()
        'Try
        '    Odrialink3.Open()
        'Catch ex As Exception
        '    MsgBox("Nepovedlo se otevřít connection! " + ex.Message, , "Chyba")
        'End Try

        SPorder = 1
        SPdirect = 1
        BEorder = 1
        BEdirect = 1
        NAorder = 1
        NAdirect = 1
        SKorder = 1
        SKdirect = 1
        ITorder = 1
        ITdirect = 1
        OGorder = 1
        OGdirect = 1
        ARorder = 1
        ARdirect = 1
        WEorder = 1
        WEdirect = 1
        CHorder = 1
        CHdirect = 1
        EVorder = 1
        EVdirect = 1
        PEorder = 1
        PEdirect = 1
        SIorder = 1
        SIdirect = 1
        IOorder = 1
        IOdirect = 1
        WOorder = 1
        WOdirect = 1
        LAorder = 1
        LAdirect = 1
        PRorder = 1
        PRdirect = 1
        PAorder = 1
        PAdirect = 1
        RAorder = 1
        RAdirect = 1
        NOorder = 1
        NOdirect = 1
        RUorder = 1
        RUdirect = 1
        EForder = 1
        EFdirect = 1
        CRorder = 1
        CRdirect = 1
        PSorder = 1
        PSdirect = 1
        ATorder = 1
        ATdirect = 1
        VAorder = 1
        VAdirect = 1
        SP = False
        BE = False
        NA = False
        EL = False
        SK = False
        IT = False
        OG = False
        AR = False
        WE = False
        CH = False
        EV = False
        PE = False
        SI = False
        IO = False
        WO = False
        LA = False
        PR = False
        PA = False
        RA = False
        NO = False
        RU = False
        EF = False
        CR = False
        PS = False
        AT = False
        VA = False
        Smycka = False
        GC_list = 0
        ProFILE = GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Profily", "Aktuální", "")
        If ProFILE = "" Then
            ProFILE = VB6.GetPath & "\Default.pro"
        End If
        GC_ReadProfile()
    End Sub

    Sub DBSearch()
        Select Case QTable
            Case Is = "Artifacts"
                If AR Then
                    FArtif.Txt_art.Text = Transtr
                    Call ARSearch()
                    FArtif.Show()
                Else
                    FArtif = New Frm_Artifacts
                    FArtif.Show()
                    Do
                        System.Windows.Forms.Application.DoEvents()
                    Loop Until AR
                    FArtif.Txt_art.Text = Transtr
                    Call ARSearch()
                    FArtif.Show()
                End If
            Case Is = "Beasts"
                If BE Then
                    FBe.Txt_beastname.Text = Transtr
                    Call BESearch()
                    FBe.Show()
                Else
                    FBe = New Frm_Beasts
                    FBe.Show()
                    Do
                        System.Windows.Forms.Application.DoEvents()
                    Loop Until BE
                    FBe.Txt_beastname.Text = Transtr
                    Call BESearch()
                    FBe.Show()
                End If
            Case Is = "Elements"
                If EL Then
                    FEle.Show()
                Else
                    FEle = New Frm_Elements
                    FEle.Show()
                End If
            Case Is = "Events"
                If EV Then
                    FEve.Txt_tit.Text = Transtr
                    Call EVSearch()
                    FEve.Show()
                Else
                    FEve = New Frm_Events
                    FEve.Show()
                    Do
                        System.Windows.Forms.Application.DoEvents()
                    Loop Until EV
                    FEve.Txt_tit.Text = Transtr
                    Call EVSearch()
                    FEve.Show()
                End If
            Case Is = "Characters"
                If CH Then
                    FCHax.Txt_name.Text = Transtr
                    Call CHSearch()
                    FCHa.Show()
                Else
                    FCHax = New Frm_Characters
                    FCHa.Show()
                    Do
                        System.Windows.Forms.Application.DoEvents()
                    Loop Until CH
                    FCHax.Txt_name.Text = Transtr
                    Call CHSearch()
                    FCHa.Show()
                End If
            Case Is = "Info"
                If IO Then
                    FIn.Txt_in.Text = Transtr
                    Call IOSearch()
                    FIn.Show()
                Else
                    FIn = New Frm_Info
                    FIn.Show()
                    Do
                        System.Windows.Forms.Application.DoEvents()
                    Loop Until IO
                    FIn.Txt_in.Text = Transtr
                    Call IOSearch()
                    FIn.Show()
                End If
        End Select
    End Sub

    Sub SPSearch()
        Dim pomnumber As Long
        pomnumber = SPposition
        SPposition = 0
        Do
            If FSp.Txt_Spellname.Text = SPrec.Tables("S").Rows(SPposition)("Orig_name") Then
                Exit Do
            End If
            SPposition += 1
        Loop Until SPposition + 1 = SPcount
        If SPposition + 1 = SPcount Then
            MsgBox("Kouzlo " & FSp.Txt_Spellname.Text & " nebylo nalezeno.", MsgBoxStyle.OKOnly, "Pešek")
            SPposition = pomnumber
        End If
        Call FSp.FillForm()

    End Sub

    Sub SKSearch()
        Dim pomnumber As Long
        pomnumber = SKposition
        SKposition = 0
        Do
            If FSk.Txt_s.Text = SKrec.Tables("Sk").Rows(SKposition)("Skill") Then
                Exit Do
            End If
            SKposition += 1
        Loop Until SKposition + 1 = SKcount
        If SKposition + 1 = SKcount Then
            MsgBox("Skill " & FSk.Txt_s.Text & " nebyl nalezen.", MsgBoxStyle.OKOnly, "Pešek")
            SKposition = pomnumber
        End If
        Call FSk.FillForm()

    End Sub

    Sub ITSearch()
        Dim pomnumber As Long
        pomnumber = ITposition
        ITposition = 0
        Do
            If FIt.Txt_name.Text = ITrec.Tables("I").Rows(ITposition)("Item_name") Then
                Exit Do
            End If
            ITposition += 1
        Loop Until ITposition + 1 = ITcount
        If ITposition + 1 = ITcount Then
            MsgBox("Item " & FIt.Txt_name.Text & " nebyl nalezen.", MsgBoxStyle.OKOnly, "Pešek")
            ITposition = pomnumber
        End If
        Call FIt.FillForm()

    End Sub


    Sub WESearch()
        Dim pomnumber As Int64
        pomnumber = WEposition
        WEposition = 0
        Do
            If FWe.Txt_w.Text = WErec.Tables("W").Rows(WEposition)("Weap_name") Then
                Exit Do
            End If
            WEposition += 1
        Loop Until WEposition + 1 = WEcount
        If WEposition + 1 = WEcount Then
            MsgBox("Zbraň " & FWe.Txt_w.Text & " nebyla nalezena.", MsgBoxStyle.OkOnly, "Pešek")
            WEposition = pomnumber
        End If
        Call FWe.FillForm()

    End Sub


    Sub ARSearch()
        Dim pomnumber As Int64
        pomnumber = ARposition
        ARposition = 0
        Do
            If FArtif.Txt_art.Text = ARrec.Tables("af").Rows(ARposition)("Artifact") Then
                Exit Do
            End If
            ARposition += 1
        Loop Until ARposition + 1 = ARcount
        If ARposition + 1 = ARcount Then
            MsgBox("Artefakt " & FArtif.Txt_art.Text & " nebyl nalezen.", MsgBoxStyle.OKOnly, "Pešek")
            ARposition = pomnumber
        End If
        Call FArtif.FillForm()

    End Sub

    Sub SISearch()
        Dim pomnumber As Int64
        pomnumber = SIposition
        SIposition = 0
        Do
            If FSi.Txt_site.Text = SIrec.Tables("si").Rows(SIposition)("Site") Then
                Exit Do
            End If
            SIposition += 1
        Loop Until SIposition + 1 = SIcount
        If SIposition + 1 = SIcount Then
            MsgBox("Místo " & FSi.Txt_site.Text & " nebylo nalezeno.", MsgBoxStyle.OKOnly, "Pešek")
            SIposition = pomnumber
        End If
        Call FSi.FillForm()

    End Sub

    Sub PESearch()
        Dim pomnumber As Int64
        pomnumber = PEposition
        PEposition = 0
        Do
            If FPer.Txt_name.Text = PErec.Tables("pe").Rows(PEposition)("Name") Then
                Exit Do
            End If
            PEposition += 1
        Loop Until PEposition + 1 = PEcount
        If PEposition + 1 = PEcount Then
            MsgBox("Osoba " & FPer.Txt_name.Text & " nebyla nalezena.", MsgBoxStyle.OKOnly, "Pešek")
            PEposition = pomnumber
        End If
        Call FPer.FillForm()

    End Sub

    Sub LASearch()
        Dim pomnumber As Int64
        pomnumber = LAposition
        LAposition = 0
        Do
            If FLa.Txt_language.Text = LArec.Tables("l").Rows(LAposition)("Language") Then
                Exit Do
            End If
            LAposition += 1
        Loop Until LAposition + 1 = LAcount
        If LAposition + 1 = LAcount Then
            MsgBox("Jazyk " & FLa.Txt_language.Text & " nebyl nalezen.", MsgBoxStyle.OKOnly, "Pešek")
            LAposition = pomnumber
        End If
        Call FLa.FillForm()

    End Sub

    Sub Fill_Capitals()
        '    Dim x As Int64
        '    Dim fo As Boolean
        '    If NA = False Then
        '        NArec.Open("select * from Nations order by Kontinent, Číslo", Odrialink, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        '    End If
        '    If SI = False Then
        '        SIrec.Open("select * from Sites order by Site", Odrialink, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        '    End If
        '    NArec.MoveFirst()
        '    Do Until NArec.EOF
        '        fo = False
        '        If NArec.Fields("Hlměsto").Value <> "" And NArec.Fields("Hlměsto").Value <> "?" And NArec.Fields("Hlměsto").Value <> "hory přízraků" And NArec.Fields("Hlměsto").Value <> "hvozd" And NArec.Fields("Hlměsto").Value <> "jezero" And NArec.Fields("Hlměsto").Value <> "není" And NArec.Fields("Hlměsto").Value <> "pohoří" And NArec.Fields("Hlměsto").Value <> "prales" And NArec.Fields("Hlměsto").Value <> "prokletá pustina" And NArec.Fields("Hlměsto").Value <> "pustina" And NArec.Fields("Hlměsto").Value <> "země záhad" Then
        '            SIrec.MoveFirst()
        '            Do
        '                If NArec.Fields("Hlměsto").Value = SIrec.Fields("Site").Value Then
        '                    fo = True
        '                    Exit Do
        '                End If
        '                SIrec.MoveNext()
        '            Loop Until SIrec.EOF
        '            If fo = False Then
        '                SIrec.AddNew()
        '                SIrec.Fields("Site").Value = NArec.Fields("Hlměsto").Value
        '                SIrec.Fields("Country").Value = NArec.Fields("Jméno").Value
        '                SIrec.Fields("Type").Value = "hlavní město"
        '                SIrec.Fields("Whats_inside").Value = System.DBNull.Value
        '                SIrec.Fields("History").Value = System.DBNull.Value
        '                SIrec.Fields("Remarks").Value = System.DBNull.Value
        '                SIrec.Update()
        '            End If
        '        End If
        '        NArec.MoveNext()
        '    Loop
        '    If NA Then
        '        NArec.MoveFirst()
        '        x = 1
        '        Do While NAposition > x
        '            NArec.MoveNext()
        '            x = x + 1
        '        Loop
        '    Else
        '        NArec.Close()
        '    End If
        '    If SI Then
        '        SIrec.Requery()
        '        SIrec.MoveFirst()
        '        x = 1
        '        Do While SIposition > x
        '            SIrec.MoveNext()
        '            x = x + 1
        '        Loop
        '        Call SIcompute()
        '        Call SISearch()
        '    Else
        '        SIrec.Close()
        '    End If
    End Sub

    Sub BESearch()
        Dim pomnumber As Int64
        BEposition = 0
        Do
            If FBe.Txt_beastname.Text = BErec.Tables("be").Rows(BEposition)("B_name") Then
                Exit Do
            End If
            BEposition += 1
        Loop Until BEposition + 1 = BEcount
        If BEposition + 1 = BEcount Then
            MsgBox("Bestie " & FBe.Txt_beastname.Text & " nebyla nalezena.", MsgBoxStyle.OKOnly, "Pešek")
            BEposition = pomnumber
        End If
        Call FBe.FillForm()

    End Sub

    Sub EVSearch()
        Dim pomnumber As Long
        EVposition = 0
        Do
            If FEve.Txt_tit.Text = EVrec.Tables("E").Rows(EVposition)("Event_Title") Then
                Exit Do
            End If
            EVposition += 1
        Loop Until EVposition + 1 = EVcount
        If EVposition + 1 = EVcount Then
            MsgBox("Událost " & FEve.Txt_tit.Text & " nebyla nalezena.", MsgBoxStyle.OKOnly, "Pešek")
            EVposition = pomnumber
        End If
        Call FEve.FillForm()

    End Sub

    Sub CHSearch()
        Dim pomnumber As Int64
        CHposition = 0
        Do
            If FCHax.Txt_name.Text = CHrec.Tables("ch").Rows(CHposition)("Name") Then
                Exit Do
            End If
            CHposition += 1
        Loop Until CHposition + 1 = CHcount
        If CHposition + 1 = CHcount Then
            MsgBox("Postava " & FCHax.Txt_name.Text & " nebyla nalezena.", MsgBoxStyle.OKOnly, "Pešek")
            CHposition = pomnumber
        End If
        'Call FCHa.FillForm()

    End Sub

    Sub IOSearch()
        Dim pomnumber As Long
        pomnumber = IOposition
        IOposition = 0
        Do
            If FIn.Txt_in.Text = IOrec.Tables("io").Rows(IOposition)("Info") Then
                Exit Do
            End If
            IOposition += 1
        Loop Until IOposition + 1 = IOcount
        If IOposition + 1 = IOcount Then
            MsgBox("Info " & FIn.Txt_in.Text & " nebylo nalezeno.", MsgBoxStyle.OKOnly, "Pešek")
            IOposition = pomnumber
        End If
        Call FIn.FillForm()

    End Sub


    Sub GC_ReadProfile()
        Dim x, y As Integer
        Dim Row, Prvek As String
        FileOpen(1, ProFILE, OpenMode.Input)
        Row = LineInput(1)
        For y = 1 To 66
            x = Row.IndexOf("|")
            Prvek = Row.Substring(0, x)
            Row = Row.Remove(0, x + 1)
            Select Case y
                Case Is = 1
                    MB1 = Prvek
                Case Is = 2
                    MB22 = Prvek
                Case Is = 3
                    MF1 = Prvek
                Case Is = 4
                    MF22 = Prvek
                Case Is = 5
                    MF33 = Prvek
                Case Is = 6
                    MF44 = Prvek
                Case Is = 7
                    COI = Prvek
                Case Is = 8
                    COF = Prvek
                Case Is = 9
                    COD = Prvek
                Case Is = 10
                    CON = Prvek
                Case Is = 11
                    COP = Prvek
                Case Is = 12
                    COO = Prvek
                Case Is = 13
                    COE = Prvek
                Case Is = 14
                    COFO = Prvek
                Case Is = 15
                    FAB = Prvek
                Case Is = 16
                    FAFO = Prvek
                Case Is = 17
                    FBB = Prvek
                Case Is = 18
                    FBFO = Prvek
                Case Is = 19
                    FEB = Prvek
                Case Is = 20
                    FEFO = Prvek
                Case Is = 21
                    FVB = Prvek
                Case Is = 22
                    FVF = Prvek
                Case Is = 23
                    FCHB = Prvek
                Case Is = 24
                    FCHF = Prvek
                Case Is = 25
                    FIB = Prvek
                Case Is = 26
                    FIFO = Prvek
                Case Is = 27
                    FTB = Prvek
                Case Is = 28
                    FTF = Prvek
                Case Is = 29
                    FCEB = Prvek
                Case Is = 30
                    FCEF = Prvek
                Case Is = 31
                    FLB = Prvek
                Case Is = 32
                    FLFO = Prvek
                Case Is = 33
                    FNB = Prvek
                Case Is = 34
                    FNFO = Prvek
                Case Is = 35
                    FOB = Prvek
                Case Is = 36
                    FOFO = Prvek
                Case Is = 37
                    FPAB = Prvek
                Case Is = 38
                    FPAFO = Prvek
                Case Is = 39
                    FPEB = Prvek
                Case Is = 40
                    FPEFO = Prvek
                Case Is = 41
                    FMB = Prvek
                Case Is = 42
                    FMFO = Prvek
                Case Is = 43
                    FSKB = Prvek
                Case Is = 44
                    FSKFO = Prvek
                Case Is = 45
                    FSPB = Prvek
                Case Is = 46
                    FSPFO = Prvek
                Case Is = 47
                    FWB = Prvek
                Case Is = 48
                    FWFO = Prvek
                Case Is = 49
                    FWOB = Prvek
                Case Is = 50
                    FWOFO = Prvek
                Case Is = 51
                    FRB = Prvek
                Case Is = 52
                    FRFO = Prvek
                Case Is = 53
                    FNOB = Prvek
                Case Is = 54
                    FNOFO = Prvek
                Case Is = 55
                    FCRB = Prvek
                Case Is = 56
                    FCRFO = Prvek
                Case Is = 57
                    FUB = Prvek
                Case Is = 58
                    FUF = Prvek
                Case Is = 59
                    FPSB = Prvek
                Case Is = 60
                    FPSFO = Prvek
                Case Is = 61
                    FRUB = Prvek
                Case Is = 62
                    FRUFO = Prvek
                Case Is = 63
                    FEFB = Prvek
                Case Is = 64
                    FEFFO = Prvek
                Case Is = 65
                    FVV = Prvek
                Case Is = 66
                    FVVF = Prvek
            End Select
        Next
        FileClose(1)
    End Sub

    Sub ChangeDemon()
        Undergo = True
        Try
            Dim ic As New OleDbCommand
            Dim icc As String
            icc = "INSERT INTO CHangeLog (Coperation, Ctable, Ctime, CDataOld, CDataNew, CProcessed) VALUES (@x1, @x2, @x3, @x4, @x5, @x6)"
            ic.Parameters.AddWithValue("@x1", OperationP)
            ic.Parameters.AddWithValue("@x2", OnTable)
            ic.Parameters.AddWithValue("@x3", Now)
            If OldData = "" Then
                ic.Parameters.AddWithValue("@x4", DBNull.Value)
            Else
                ic.Parameters.AddWithValue("@x4", CStr(OldData))
            End If
            If NewData = "" Then
                ic.Parameters.AddWithValue("@x5", DBNull.Value)
            Else
                ic.Parameters.AddWithValue("@x5", CStr(NewData))
            End If
            ic.Parameters.AddWithValue("@x6", False)
            ic.Connection = Odrialink2
            ic.CommandText = icc
            ic.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Chyba při zápisu změny do databáze: " + ex.Message, , "CHYBA")
        Finally
            OperationP = ""
            OnTable = ""
            OldData = ""
            NewData = ""
            Undergo = False
        End Try
    End Sub

    Sub PrepForWiki()
        Dim SPse As New OleDbCommand
        Dim s, r, t As String
        Dim q1 As Long
        Dim Veta As String
        Dim writer As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("C:\Killman\Work\GC AVATAR v 5.0\WikiPrep.txt", False, System.Text.Encoding.UTF8)
        SPse.Connection = Odrialink2
        SPposition = 0
        's = "SELECT * from Spells WHERE Spelling_cast LIKE @Spelling_cast"
        'SPse.Parameters.AddWithValue("@Spelling_cast", "%" & "ARS" & "%")
        s = "SELECT * from Spells WHERE Spell_type LIKE @Spell_type"
        SPse.Parameters.AddWithValue("@Spell_type", "%" & "Kouzlo Morthenu" & "%")
        SPposition = 0
        Try
            SPse.CommandText = s
            q1 = 0
            SPdat.SelectCommand = SPse
            SPrec.Clear()
            SPdat.Fill(SPrec, "Sp")
            SPcount = SPrec.Tables("Sp").Rows.Count
            'FileOpen(2, "C:\Killman\Work\GC AVATAR v 5.0\WikiPrep.txt", OpenMode.Output)
            Do
                r = (SPrec.Tables("Sp").Rows(SPposition)("Orig_name"))
                t = r.Substring(0, 1) & r.Substring(1).ToLower
                Veta = "{{Kouzlo|" & t & "|" & SPrec.Tables("Sp").Rows(SPposition)("Czech_name") & "|" & SPrec.Tables("Sp").Rows(SPposition)("Magenergy") & "|" & SPrec.Tables("Sp").Rows(SPposition)("Cast_rounds") & "|" & SPrec.Tables("Sp").Rows(SPposition)("Duration") & "|" & SPrec.Tables("Sp").Rows(SPposition)("Reach") & "|" & SPrec.Tables("Sp").Rows(SPposition)("Affect") & "|" & SPrec.Tables("Sp").Rows(SPposition)("Spell_type") & " " & SPrec.Tables("Sp").Rows(SPposition)("Spelling_cast") & "|" & SPrec.Tables("Sp").Rows(SPposition)("Difficulty") & "|" & SPrec.Tables("Sp").Rows(SPposition)("Cast_time") & "|" & SPrec.Tables("Sp").Rows(SPposition)("Fatigue") & "}}"
                writer.WriteLine(Veta)
                Veta = ""
                writer.WriteLine(Veta)
                Veta = "=== Pravidlový popis ==="
                writer.WriteLine(Veta)
                Veta = SPrec.Tables("Sp").Rows(SPposition)("Texto")
                writer.WriteLine(Veta)
                Veta = ""
                writer.WriteLine(Veta)
                'Veta = "{{Vylepšení|" & SPrec.Tables("Sp").Rows(SPposition)("t1") & "|" & SPrec.Tables("Sp").Rows(SPposition)("t2") & "|" & SPrec.Tables("Sp").Rows(SPposition)("t3") & "|" & SPrec.Tables("Sp").Rows(SPposition)("t4") & "}}"
                'writer.WriteLine(Veta)
                'Veta = ""
                'writer.WriteLine(Veta)
                Veta = "=== Legenda ==="
                writer.WriteLine(Veta)
                Veta = "-needed-"
                writer.WriteLine(Veta)
                Veta = ""
                writer.WriteLine(Veta)
                Veta = "[[Kategorie:Kouzla Morthenu]]"
                writer.WriteLine(Veta)
                Veta = "________________________________________________________________________________________________________________"
                writer.WriteLine(Veta)
                q1 += 1
                SPposition += 1
            Loop While q1 < SPcount
            Veta = ""
            writer.WriteLine(Veta)
            writer.WriteLine(Veta)
            writer.WriteLine(Veta)
            writer.WriteLine(Veta)
            writer.Close()
            'FileClose(2)
        Catch ex As Exception
            MsgBox("Chyba při čtení databáze." + ex.Message, , "Chyba")
            Exit Sub
        End Try
    End Sub
End Module