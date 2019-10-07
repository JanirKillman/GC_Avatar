Imports System.Data.OleDb
Public Class Frm_Waid
    Inherits System.Windows.Forms.Form
    Public Kil As New Killman
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents bm As System.Windows.Forms.Button
    Friend WithEvents bs As System.Windows.Forms.Button
    Friend WithEvents bz As System.Windows.Forms.Button
    Friend WithEvents bc As System.Windows.Forms.Button
    Friend WithEvents lb As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Waid))
        Me.bm = New System.Windows.Forms.Button
        Me.bs = New System.Windows.Forms.Button
        Me.bz = New System.Windows.Forms.Button
        Me.bc = New System.Windows.Forms.Button
        Me.lb = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'bm
        '
        Me.bm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bm.Location = New System.Drawing.Point(32, 24)
        Me.bm.Name = "bm"
        Me.bm.Size = New System.Drawing.Size(136, 32)
        Me.bm.TabIndex = 0
        Me.bm.Text = "NA BLÍZKO"
        '
        'bs
        '
        Me.bs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bs.Location = New System.Drawing.Point(32, 112)
        Me.bs.Name = "bs"
        Me.bs.Size = New System.Drawing.Size(136, 32)
        Me.bs.TabIndex = 1
        Me.bs.Text = "STřELNÁ/VRHACÍ"
        '
        'bz
        '
        Me.bz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bz.Location = New System.Drawing.Point(32, 200)
        Me.bz.Name = "bz"
        Me.bz.Size = New System.Drawing.Size(136, 32)
        Me.bz.TabIndex = 2
        Me.bz.Text = "ZBROJ/ŠTÍT"
        '
        'bc
        '
        Me.bc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bc.Location = New System.Drawing.Point(32, 280)
        Me.bc.Name = "bc"
        Me.bc.Size = New System.Drawing.Size(136, 32)
        Me.bc.TabIndex = 3
        Me.bc.Text = "CANCEL"
        '
        'lb
        '
        Me.lb.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(64, Byte), CType(0, Byte))
        Me.lb.Location = New System.Drawing.Point(0, 24)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(200, 303)
        Me.lb.TabIndex = 4
        Me.lb.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "VYBER ZBRAÒ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frm_Waid
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(64, Byte), CType(0, Byte))
        Me.ClientSize = New System.Drawing.Size(200, 326)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.bc)
        Me.Controls.Add(Me.bz)
        Me.Controls.Add(Me.bs)
        Me.Controls.Add(Me.bm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Waid"
        Me.Text = "Weapon aid tool"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private typ As String
    Private sq As New DataSet
    Private Sub bc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bc.Click
        Me.Close()
    End Sub

    Private Sub bm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bm.Click
        Hideall()
        Dim tq As New OleDbCommand
        Dim dq As New OleDbDataAdapter
        Dim a, b As Int16
        tq.Connection = Odrialink2
        tq.CommandText = "select * from Weapons_parameters"
        dq.SelectCommand = tq
        sq.Clear()
        dq.Fill(sq, "o")
        b = sq.Tables("o").Rows.Count
        For a = 0 To b - 1
            lb.Items.Add(sq.Tables("o").Rows(a)("Weapon"))
        Next
        typ = "wep"
    End Sub

    Sub Hideall()
        bm.Visible = False
        bs.Visible = False
        bz.Visible = False
        bc.Visible = False
        lb.Visible = True
    End Sub

    Private Sub bs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bs.Click
        Hideall()
        Dim tq As New OleDbCommand
        Dim dq As New OleDbDataAdapter
        Dim a, b As Int16
        tq.Connection = Odrialink2
        tq.CommandText = "select * from Ranged_Weapons_parameters"
        dq.SelectCommand = tq
        sq.Clear()
        dq.Fill(sq, "o")
        b = sq.Tables("o").Rows.Count
        For a = 0 To b - 1
            lb.Items.Add(sq.Tables("o").Rows(a)("Weapon"))
        Next
        typ = "shot"
    End Sub

    Private Sub bz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bz.Click
        Hideall()
        Dim tq As New OleDbCommand
        Dim dq As New OleDbDataAdapter
        Dim a, b As Int16
        tq.Connection = Odrialink2
        tq.CommandText = "select * from Armor_parameters"
        dq.SelectCommand = tq
        sq.Clear()
        dq.Fill(sq, "o")
        b = sq.Tables("o").Rows.Count
        For a = 0 To b - 1
            lb.Items.Add(sq.Tables("o").Rows(a)("Armor"))
        Next
        typ = "arm"
    End Sub

    Private Sub lb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb.SelectedIndexChanged
        Dim a, b As Int16
        Select Case typ
            Case Is = "wep"
                b = sq.Tables("o").Rows.Count
                For a = 0 To b - 1
                    If lb.Text = sq.Tables("o").Rows(a)("Weapon") Then
                        Exit For
                    End If
                Next
                FWe.Txt_Typg.Text = "melee"
                FWe.Txt_typ.Text = sq.Tables("o").Rows(a)("Weapon")
                FWe.Txt_UC.Text = sq.Tables("o").Rows(a)("Zasaznost")
                FWe.Txt_pru.Text = sq.Tables("o").Rows(a)("Pruraznost")
                FWe.Txt_drt.Text = sq.Tables("o").Rows(a)("Drtivost")
                FWe.Txt_ut.Text = sq.Tables("o").Rows(a)("Nicivost")
                FWe.Txt_OC.Text = sq.Tables("o").Rows(a)("OC")
                FWe.Txt_len.Text = sq.Tables("o").Rows(a)("Delka")
                FWe.Txt_ini.Text = sq.Tables("o").Rows(a)("Iniciativa")
                FWe.Txt_silm.Text = sq.Tables("o").Rows(a)("Silove_minimum")
                FWe.Txt_typd.Text = sq.Tables("o").Rows(a)("Typ_zbrane")
                FWe.Txt_rem.Text = sq.Tables("o").Rows(a)("Poznamka")
                FWe.Txt_we.Text = sq.Tables("o").Rows(a)("Vaha")
                FWe.Txt_awe.Text = sq.Tables("o").Rows(a)("Aktvaha")
            Case Is = "pro"
                b = sq.Tables("o").Rows.Count
                For a = 0 To b - 1
                    If lb.Text = sq.Tables("o").Rows(a)("Weap_name") Then
                        Exit For
                    End If
                Next
                FWe.Txt_UC.Text = CInt(FWe.Txt_UC.Text) + CInt(sq.Tables("o").Rows(a)("Zas"))
                FWe.Txt_zas2.Text = CInt(FWe.Txt_zas2.Text) + CInt(sq.Tables("o").Rows(a)("Zas2"))
                FWe.Txt_zas3.Text = CInt(FWe.Txt_zas3.Text) + CInt(sq.Tables("o").Rows(a)("Zas3"))
                If FWe.Txt_pru.Text = "*0" Then
                    FWe.Txt_pru.Text = "0"
                Else
                    FWe.Txt_pru.Text = CInt(FWe.Txt_pru.Text) + CInt(sq.Tables("o").Rows(a)("Pru"))
                End If
                FWe.Txt_drt.Text = CInt(FWe.Txt_drt.Text) + CInt(sq.Tables("o").Rows(a)("Drt"))

            Case Is = "shot"
                b = sq.Tables("o").Rows.Count
                For a = 0 To b - 1
                    If lb.Text = sq.Tables("o").Rows(a)("Weapon") Then
                        Exit For
                    End If
                Next
                FWe.Txt_Typg.Text = "ranged"
                FWe.Txt_typ.Text = sq.Tables("o").Rows(a)("Weapon")
                FWe.Txt_UC.Text = sq.Tables("o").Rows(a)("Short_acc")
                FWe.Txt_zas2.Text = sq.Tables("o").Rows(a)("Effic_acc")
                FWe.Txt_zas3.Text = sq.Tables("o").Rows(a)("Max_acc")
                FWe.Txt_ran.Text = sq.Tables("o").Rows(a)("Short_range")
                FWe.Txt_ran2.Text = sq.Tables("o").Rows(a)("Effic_range")
                FWe.Txt_ran3.Text = sq.Tables("o").Rows(a)("Max_range")
                FWe.Txt_pru.Text = sq.Tables("o").Rows(a)("Pruraz")
                FWe.Txt_drt.Text = sq.Tables("o").Rows(a)("Drtivost")
                FWe.Txt_ut.Text = sq.Tables("o").Rows(a)("Nicivost")
                FWe.Txt_ini.Text = sq.Tables("o").Rows(a)("Inic")
                FWe.Txt_typd.Text = sq.Tables("o").Rows(a)("Typ_zbrane")
                FWe.Txt_rem.Text = sq.Tables("o").Rows(a)("Poznamka")
                FWe.Txt_we.Text = sq.Tables("o").Rows(a)("Vaha")
                FWe.Txt_awe.Text = sq.Tables("o").Rows(a)("Aktvaha")
                If FWe.Txt_ran3.Text > "-" Then
                    Dim xstr As Int16
                    xstr = InputBox("Síla zbrane?", "Zadej číslo")
                    FWe.Txt_ran.Text = Mid(FWe.Txt_ran.Text, 5, 5)
                    FWe.Txt_ran.Text = CInt(CDbl(FWe.Txt_ran.Text) * xstr)
                    FWe.Txt_ran2.Text = Mid(FWe.Txt_ran2.Text, 5, 5)
                    FWe.Txt_ran2.Text = CInt(CDbl(FWe.Txt_ran2.Text) * xstr)
                    FWe.Txt_ran3.Text = Mid(FWe.Txt_ran3.Text, 5, 5)
                    FWe.Txt_ran3.Text = CInt(CDbl(FWe.Txt_ran3.Text) * xstr)
                    If Not FWe.Txt_pru.Text = "0" Then
                        Dim at As Int16
                        at = CInt(Kil.AttBonus(CShort(xstr)))
                        FWe.Txt_pru.Text = CInt(FWe.Txt_pru.Text) + at
                        FWe.Txt_drt.Text = CInt(CInt(FWe.Txt_drt.Text) + (at / 2) + 0.001)
                    End If
                    FWe.Txt_spec.Text = "Síla " & xstr
                End If
                If FWe.Txt_ran.Text = "-" Then
                    If MsgBox("Projektil?", MsgBoxStyle.YesNo, "Dotaz") = MsgBoxResult.Yes Then
                        lb.Items.Clear()
                        Dim tq As New OleDbCommand
                        Dim dq As New OleDbDataAdapter
                        Dim f, g As Int16
                        tq.Connection = Odrialink2
                        tq.CommandText = "select * from Weapons where Rang3 > @rr"
                        tq.Parameters.AddWithValue("@rr", "-")
                        dq.SelectCommand = tq
                        sq.Clear()
                        dq.Fill(sq, "o")
                        g = sq.Tables("o").Rows.Count
                        For f = 0 To g - 1
                            lb.Items.Add(sq.Tables("o").Rows(f)("Weap_name"))
                        Next
                        typ = "pro"
                        Exit Sub
                    End If
                End If
            Case Is = "arm"
                b = sq.Tables("o").Rows.Count
                For a = 0 To b - 1
                    If lb.Text = sq.Tables("o").Rows(a)("Armor") Then
                        Exit For
                    End If
                Next
                FWe.Txt_Typg.Text = "armor"
                FWe.Txt_typ.Text = sq.Tables("o").Rows(a)("Armor")
                FWe.Txt_sek.Text = sq.Tables("o").Rows(a)("Secne")
                FWe.Txt_bod.Text = sq.Tables("o").Rows(a)("Bodne")
                FWe.Txt_drc.Text = sq.Tables("o").Rows(a)("Drtive")
                FWe.Txt_omg.Text = sq.Tables("o").Rows(a)("Omega")
                FWe.Txt_mag.Text = sq.Tables("o").Rows(a)("Resistence")
                FWe.Txt_hp.Text = sq.Tables("o").Rows(a)("HP")
                FWe.Txt_rem.Text = sq.Tables("o").Rows(a)("Poznamky")
                FWe.Txt_we.Text = sq.Tables("o").Rows(a)("Vaha")
            Case Is = "mat"
                b = sq.Tables("o").Rows.Count()
                For a = 0 To b - 1
                    If lb.Text = sq.Tables("o").Rows(a)("Material") Then
                        Exit For
                    End If
                Next
                FWe.Txt_stuff.Text = sq.Tables("o").Rows(a)("Material")
                Select Case FWe.Txt_Typg.Text
                    Case Is = "melee"
                        Dim scree As Double
                        FWe.Txt_UC.Text = CInt(CDbl(FWe.Txt_UC.Text) * CDbl(sq.Tables("o").Rows(a)("Zas")))
                        FWe.Txt_pru.Text = CInt(CDbl(FWe.Txt_pru.Text) * CDbl(sq.Tables("o").Rows(a)("Pru")))
                        FWe.Txt_drt.Text = CInt(CDbl(FWe.Txt_drt.Text) * CDbl(sq.Tables("o").Rows(a)("Drt")))
                        FWe.Txt_ut.Text = CInt(CDbl(FWe.Txt_ut.Text) * CDbl(sq.Tables("o").Rows(a)("Nic")))
                        FWe.Txt_OC.Text = CInt(CDbl(FWe.Txt_OC.Text) * CDbl(sq.Tables("o").Rows(a)("OC")))
                        FWe.Txt_ini.Text = CInt(CDbl(FWe.Txt_ini.Text) / CDbl(sq.Tables("o").Rows(a)("Ini")))
                        scree = CDbl(FWe.Txt_we.Text) - CDbl(FWe.Txt_awe.Text)
                        FWe.Txt_awe.Text = (CDbl(FWe.Txt_awe.Text) / 100) * sq.Tables("o").Rows(a)("Weight")
                        FWe.Txt_we.Text = CDbl(FWe.Txt_awe.Text) + scree
                        FWe.Txt_price.Text = CDbl(FWe.Txt_awe.Text) * sq.Tables("o").Rows(a)("Cost")
                    Case Is = "ranged"
                        Dim scree As Double
                        FWe.Txt_UC.Text = CInt(CDbl(FWe.Txt_UC.Text) * CDbl(sq.Tables("o").Rows(a)("Zas")))
                        FWe.Txt_zas2.Text = CInt(CDbl(FWe.Txt_zas2.Text) * CDbl(sq.Tables("o").Rows(a)("Zas")))
                        If FWe.Txt_zas3.Text > "-" Then
                            FWe.Txt_zas3.Text = CInt(CDbl(FWe.Txt_zas3.Text) * CDbl(sq.Tables("o").Rows(a)("Zas")))
                        End If
                        FWe.Txt_pru.Text = CInt(CDbl(FWe.Txt_pru.Text) * CDbl(sq.Tables("o").Rows(a)("Pru")))
                        FWe.Txt_drt.Text = CInt(CDbl(FWe.Txt_drt.Text) * CDbl(sq.Tables("o").Rows(a)("Drt")))
                        If FWe.Txt_ut.Text > "-" Then
                            FWe.Txt_ut.Text = CInt(CDbl(FWe.Txt_ut.Text) * CDbl(sq.Tables("o").Rows(a)("Nic")))
                        End If
                        If FWe.Txt_ini.Text > "-" Then
                            FWe.Txt_ini.Text = CInt(CDbl(FWe.Txt_ini.Text) / CDbl(sq.Tables("o").Rows(a)("Ini")))
                        End If
                        scree = CDbl(FWe.Txt_we.Text) - CDbl(FWe.Txt_awe.Text)
                        FWe.Txt_awe.Text = (CDbl(FWe.Txt_awe.Text) / 100) * sq.Tables("o").Rows(a)("Weight")
                        FWe.Txt_we.Text = CDbl(FWe.Txt_awe.Text) + scree
                        FWe.Txt_price.Text = CDbl(FWe.Txt_awe.Text) * sq.Tables("o").Rows(a)("Cost")
                    Case Is = "armor"
                        FWe.Txt_sek.Text = CInt(CDbl(FWe.Txt_sek.Text) * CDbl(sq.Tables("o").Rows(a)("Zbroj")))
                        FWe.Txt_bod.Text = CInt(CDbl(FWe.Txt_bod.Text) * CDbl(sq.Tables("o").Rows(a)("Zbroj")))
                        FWe.Txt_drc.Text = CInt(CDbl(FWe.Txt_drc.Text) * CDbl(sq.Tables("o").Rows(a)("Zbroj")))
                        FWe.Txt_mag.Text = CInt(CDbl(FWe.Txt_mag.Text) * CDbl(sq.Tables("o").Rows(a)("Zbroj")))
                        FWe.Txt_hp.Text = CInt(CDbl(FWe.Txt_hp.Text) * CDbl(sq.Tables("o").Rows(a)("Zbroj")))
                        FWe.Txt_we.Text = (CDbl(FWe.Txt_we.Text) / 100) * sq.Tables("o").Rows(a)("Weight")
                        FWe.Txt_price.Text = CDbl(FWe.Txt_we.Text) * sq.Tables("o").Rows(a)("Cost")
                End Select
                Me.Close()
        End Select
        If Not typ = "mat" Then
            If MsgBox("Speciální materiál?", MsgBoxStyle.YesNo, "Dotaz") = MsgBoxResult.Yes Then
                Matrosh()
            Else
                Me.Close()
            End If
        End If

    End Sub

    Sub Matrosh()
        Dim tq As New OleDbCommand
        Dim dq As New OleDbDataAdapter
        Dim a, b As Int16
        tq.Connection = Odrialink2
        tq.CommandText = "select * from Materials"
        dq.SelectCommand = tq
        sq.Clear()
        dq.Fill(sq, "o")
        b = sq.Tables("o").Rows.Count
        lb.Items.Clear()
        For a = 0 To b - 1
            lb.Items.Add(sq.Tables("o").Rows(a)("Material"))
        Next
        typ = "mat"
    End Sub
End Class
