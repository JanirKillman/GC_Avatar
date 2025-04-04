Option Strict Off
Option Explicit On
Imports System.Data.OleDb
Friend Class Frm_Vantages
    Inherits System.Windows.Forms.Form
    Private WithEvents my_sez As Form

    Private Sub Frm_VAsez_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles my_sez.Closed
        If Tsit <> "" Then
            VAposition = 0
            Do Until (VArec.Tables("va").Rows(VAposition)("Vantage") = Tsit)
                VAposition += 1
            Loop
        End If
        FillForm()
        Me.Refresh()
    End Sub

    Private Sub Cmd_Back_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Back.Click
        VAposition -= 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_First_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_First.Click
        VAposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Forward_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Forward.Click
        VAposition += 1
        Call FillForm()
    End Sub

    Private Sub Cmd_Last_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Last.Click
        VAposition = VAcount - 1
        Call FillForm()
    End Sub

    Private Sub Cmd_New_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_New.Click
        Txt_vantage.Text = ""
        Txt_typ.Text = ""
        Txt_multi.Text = ""
        Txt_cena.Text = ""
        Txt_popis.Text = ""
        Txt_vliv.Text = ""
        Cmd_Print.Enabled = False
        Cmd_Del.Enabled = False
        Txt_Num.Text = "NEW"
    End Sub

    Private Sub Frm_Vantages_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Call VArecopen()
        VAposition = 0
        ApplyColor()
        Call FillForm()
        VA = True
    End Sub


    Private Sub VArecopen()
        Dim van As New OleDbCommand
        van.Connection = Odrialink2
        Select Case VAorder
            Case Is = 1
                If VAdirect = 1 Then
                    van.CommandText = "select * from Vantages order by Vantage"
                Else
                    van.CommandText = "select * from Vantages order by Vantage desc"
                End If
            Case Is = 2
                If VAdirect = 1 Then
                    van.CommandText = "select * from Vantages order by Adv, Vantage"
                Else
                    van.CommandText = "select * from Vantages order by Adv, Vantage desc"
                End If
            Case Is = 3
                If VAdirect = 1 Then
                    van.CommandText = "select * from Vantages order by Pointcost, Vantage"
                Else
                    van.CommandText = "select * from Vantages order by Pointcost, Vantage desc"
                End If
        End Select
        VAdat.SelectCommand = van
        VArec.Clear()
        VAdat.Fill(VArec, "va")
        VAcount = VArec.Tables("va").Rows.Count
    End Sub


    Sub FillForm()


        Txt_vantage.Text = VArec.Tables("va").Rows(VAposition)("Vantage")
        If Not IsDBNull(VArec.Tables("va").Rows(VAposition)("Adv")) Then
            If VArec.Tables("va").Rows(VAposition)("Adv") = 1 Then
                Txt_typ.Text = "Advantage"
            Else
                Txt_typ.Text = "Disadvantage"
            End If
        Else
            Txt_typ.Text = ""
        End If
        If Not IsDBNull(VArec.Tables("va").Rows(VAposition)("Multitake")) Then
            If VArec.Tables("va").Rows(VAposition)("Multitake") = 1 Then
                Txt_multi.Text = "Yes"
            Else
                Txt_multi.Text = "No"
            End If
        Else
            Txt_multi.Text = ""
        End If
        If Not IsDBNull(VArec.Tables("va").Rows(VAposition)("Pointcost")) Then
            Txt_cena.Text = VArec.Tables("va").Rows(VAposition)("Pointcost")
        Else
            Txt_cena.Text = ""
        End If
        If Not IsDBNull(VArec.Tables("va").Rows(VAposition)("Popis")) Then
            Txt_popis.Text = VArec.Tables("va").Rows(VAposition)("Popis")
        Else
            Txt_popis.Text = ""
        End If
        If Not IsDBNull(VArec.Tables("va").Rows(VAposition)("Actchar")) Then
            Txt_vliv.Text = VArec.Tables("va").Rows(VAposition)("Actchar")
        Else
            Txt_vliv.Text = ""
        End If
        If VAposition = 0 Then
            Cmd_Back.Enabled = False
        Else
            Cmd_Back.Enabled = True
        End If
        Cmd_Del.Enabled = True
        Cmd_Find.Enabled = True
        If VAposition + 1 = VAcount Then
            Cmd_Forward.Enabled = False
        Else
            Cmd_Forward.Enabled = True
        End If
        Cmd_Ins.Enabled = True
        Cmd_New.Enabled = True
        Cmd_Print.Enabled = True


        Txt_Num.Text = (VAposition + 1) & "/" & VAcount

    End Sub


    Private Sub Frm_Vantages_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        VA = False
        VArec.Clear()
    End Sub


    Private Sub Txt_Num_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Num.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            If Not IsNumeric(Txt_Num.Text) Then
                MsgBox("Tady musí být číslo!", MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            If CShort(Txt_Num.Text) > VAcount Or CShort(Txt_Num.Text) < 1 Then
                MsgBox("Číslo musí být v rozsahu 1 - počet záznamů!", MsgBoxStyle.OkOnly, "Chyba")
                GoTo EventExitSub
            End If
            KeyAscii = 0
            VAposition = CShort(Txt_Num.Text) - 1
            Call FillForm()
        End If
EventExitSub:
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Cmd_Print_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Print.Click
        Dim VArint As New VAPrint
        VArint.Show()
    End Sub

    Private Sub Cmd_Order_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Order.Click
        OrderControl = "VA"
        FO = New Frm_Ordering
        FO.ShowDialog()
        FO = Nothing
        VArec.Clear()
        Call VArecopen()
        VAposition = 0
        Call FillForm()
    End Sub

    Private Sub Cmd_Ins_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Ins.Click
        If Txt_vantage.Text = "" Then
            MsgBox("Vantage musí mít jméno!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
        Mid(Txt_vantage.Text, 1, 1) = Mid(Txt_vantage.Text, 1, 1).ToUpper
        Dim tsc As New OleDbCommand
        Dim treader As OleDbDataReader
        Try
            tsc.Connection = Odrialink2
            tsc.CommandText = "select * from Vantages where Vantage = @sk"
            tsc.Parameters.AddWithValue("@sk", Txt_vantage.Text)
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
                s1 = "INSERT INTO Vantages (Vantage"
                s2 = " VALUES (@sk"
                ic.Parameters.AddWithValue("@sk", Txt_vantage.Text)

                If Txt_typ.Text <> "" Then
                    If Txt_typ.Text <> "0" And Txt_typ.Text <> "1" And Txt_typ.Text <> "Advantage" And Txt_typ.Text <> "Disadvantage" Then
                        MsgBox("Chybaný údaj v poli Typ", , "CHYBA")
                        Exit Sub
                    End If
                    If Txt_typ.Text = "Advantage" Then
                        ic.Parameters.AddWithValue("@co", "1")
                    Else
                        If Txt_typ.Text = "Disadvantage" Then
                            ic.Parameters.AddWithValue("@co", "0")
                        Else
                            ic.Parameters.AddWithValue("@co", Trim(Txt_typ.Text))
                        End If
                    End If
                    s1 = s1 & ", Adv"
                    s2 = s2 & ", @co"
                End If
                If Txt_multi.Text <> "" Then
                    If Txt_multi.Text <> "0" And Txt_multi.Text <> "1" And Txt_multi.Text <> "Yes" And Txt_multi.Text <> "No" Then
                        MsgBox("Chybaný údaj v poli Vícenásobná", , "CHYBA")
                        Exit Sub
                    End If
                    If Txt_multi.Text = "Yes" Then
                        ic.Parameters.AddWithValue("@ty", "1")
                    Else
                        If Txt_multi.Text = "No" Then
                            ic.Parameters.AddWithValue("@ty", "0")
                        Else
                            ic.Parameters.AddWithValue("@ty", Trim(Txt_multi.Text))
                        End If
                    End If
                    s1 = s1 & ", Multitake"
                    s2 = s2 & ", @ty"
                End If
                If Txt_cena.Text <> "" Then
                    ic.Parameters.AddWithValue("@wi", Trim(Txt_cena.Text))
                    s1 = s1 & ", Pointcost"
                    s2 = s2 & ", @wi"
                End If
                If Txt_popis.Text <> "" Then
                    ic.Parameters.AddWithValue("@hi", Trim(Txt_popis.Text))
                    s1 = s1 & ", Popis"
                    s2 = s2 & ", @hi"
                End If
                If Txt_vliv.Text <> "" Then
                    ic.Parameters.AddWithValue("@re", Trim(Txt_vliv.Text))
                    s1 = s1 & ", Actchar"
                    s2 = s2 & ", @re"
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
            VArec.Clear()
            VAdat.Fill(VArec, "va")
            VAcount = VArec.Tables("va").Rows.Count
            Call FillForm()
        Else
            treader.Close()
            If MsgBox("Toto místo již v databázi existuje, chcete jej přepsat?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Upozornění") = MsgBoxResult.Yes Then
                Try
                    Dim s3 As String
                    Dim uc As New OleDbCommand
                    s3 = "UPDATE Vantages set Vantage = @sk, Adv = @di, Multitake = @aa, Pointcost = @us, Popis = @hi, Actchar = @re WHERE ID = @ID"
                    uc.Parameters.AddWithValue("@sk", Txt_vantage.Text)

                    If Txt_typ.Text = "" Then
                        uc.Parameters.AddWithValue("@di", System.DBNull.Value)
                    Else
                        If Txt_typ.Text <> "0" And Txt_typ.Text <> "1" And Txt_typ.Text <> "Advantage" And Txt_typ.Text <> "Disadvantage" Then
                            MsgBox("Chybaný údaj v poli Typ", , "CHYBA")
                            Exit Sub
                        End If
                        If Txt_typ.Text = "Advantage" Then
                            uc.Parameters.AddWithValue("@di", "1")
                        Else
                            If Txt_typ.Text = "Disadvantage" Then
                                uc.Parameters.AddWithValue("@di", "0")
                            Else
                                uc.Parameters.AddWithValue("@di", Trim(Txt_typ.Text))
                            End If
                        End If
                    End If
                    If Txt_multi.Text = "" Then
                        uc.Parameters.AddWithValue("@aa", System.DBNull.Value)
                    Else
                        If Txt_multi.Text <> "0" And Txt_multi.Text <> "1" And Txt_multi.Text <> "Yes" And Txt_multi.Text <> "No" Then
                            MsgBox("Chybaný údaj v poli Vícenásobná", , "CHYBA")
                            Exit Sub
                        End If
                        If Txt_multi.Text = "Yes" Then
                            uc.Parameters.AddWithValue("@aa", "1")
                        Else
                            If Txt_multi.Text = "No" Then
                                uc.Parameters.AddWithValue("@aa", "0")
                            Else
                                uc.Parameters.AddWithValue("@aa", Trim(Txt_multi.Text))
                            End If
                        End If
                    End If
                    If Txt_cena.Text = "" Then
                        uc.Parameters.AddWithValue("@us", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@us", Trim(Txt_cena.Text))
                    End If
                    If Txt_popis.Text = "" Then
                        uc.Parameters.AddWithValue("@hi", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@hi", Trim(Txt_popis.Text))
                    End If
                    If Txt_vliv.Text = "" Then
                        uc.Parameters.AddWithValue("@re", System.DBNull.Value)
                    Else
                        uc.Parameters.AddWithValue("@re", Trim(Txt_vliv.Text))
                    End If
                    uc.Parameters.AddWithValue("@ID", VArec.Tables("va").Rows(VAposition)("ID"))
                    uc.Connection = Odrialink2
                    uc.CommandText = s3
                    uc.ExecuteScalar()
                Catch ex As Exception
                    MsgBox("Chyba updatu případu: " + ex.Message, , "Pokus o update")
                    Exit Sub
                End Try
                VArec.Clear()
                VAdat.Fill(VArec, "va")
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
        Dim ski, dif, aat, usa, his, rea As Boolean
        se.Connection = Odrialink2
        s = "SELECT * from Vantages WHERE "

        If Txt_vantage.Text <> "" Then
            s = s & "Vantage LIKE @sk"
            se.Parameters.AddWithValue("@sk", "%" & Txt_vantage.Text & "%")
            ski = True
        End If
        If Txt_typ.Text <> "" Then
            If ski Then
                s = s & " AND "
            End If
            s = s & "Adv = @di"
            If Txt_typ.Text <> "0" And Txt_typ.Text <> "1" And Txt_typ.Text <> "Advantage" And Txt_typ.Text <> "Disadvantage" Then
                MsgBox("Chybaný údaj v poli Typ", , "CHYBA")
                Exit Sub
            End If
            If Txt_typ.Text = "Advantage" Then
                se.Parameters.AddWithValue("@di", "1")
            Else
                If Txt_typ.Text = "Disadvantage" Then
                    se.Parameters.AddWithValue("@di", "0")
                Else
                    se.Parameters.AddWithValue("@di", Trim(Txt_typ.Text))
                End If
            End If
            dif = True
        End If
        If Txt_multi.Text <> "" Then
            If ski Or dif Then
                s = s & " AND "
            End If
            s = s & "Multitake = @aa"
            If Txt_multi.Text <> "0" And Txt_multi.Text <> "1" And Txt_multi.Text <> "Yes" And Txt_multi.Text <> "No" Then
                MsgBox("Chybaný údaj v poli Vícenásobná", , "CHYBA")
                Exit Sub
            End If
            If Txt_multi.Text = "Yes" Then
                se.Parameters.AddWithValue("@aa", "1")
            Else
                If Txt_multi.Text = "No" Then
                    se.Parameters.AddWithValue("@aa", "0")
                Else
                    se.Parameters.AddWithValue("@aa", Trim(Txt_multi.Text))
                End If
            End If
            aat = True
        End If
        If Txt_cena.Text <> "" Then
            If ski Or dif Or aat Then
                s = s & " AND "
            End If
            s = s & "Pointcost = @us"
            se.Parameters.AddWithValue("@us", Txt_cena.Text)
            usa = True
        End If
        If Txt_popis.Text <> "" Then
            If ski Or dif Or aat Or usa Then
                s = s & " AND "
            End If
            s = s & "Popis LIKE @hi"
            se.Parameters.AddWithValue("@hi", "%" & Txt_popis.Text & "%")
            his = True
        End If
        If Txt_vliv.Text <> "" Then
            If ski Or dif Or aat Or usa Or his Then
                s = s & " AND "
            End If
            s = s & "Actchar LIKE @re"
            se.Parameters.AddWithValue("@re", "%" & Txt_vliv.Text & "%")
            rea = True
        End If
        VAposition = 0
        If s = "SELECT * from Vantages WHERE " Then
            VArecopen()
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
                        If Txt_vantage.Text = VArec.Tables("va").Rows(VAposition)("Vantage") Then
                            Exit Do
                        End If
                        VAposition += 1
                    Loop Until VAposition + 1 = VAcount
                Else
                    VAdat.SelectCommand = se
                    VArec.Clear()
                    VAdat.Fill(VArec, "va")
                    VAcount = VArec.Tables("va").Rows.Count
                    If GC_list = 1 Then
                        If my_sez Is Nothing Then
                            my_sez = New Frm_VAsez
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
        If MsgBox("Opravdu vymazat vantage " & Txt_vantage.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Upozornění") = MsgBoxResult.Yes Then
            Try
                tsc.Connection = Odrialink2
                tsc.CommandText = "DELETE from Vantages WHERE ID = @ID"
                tsc.Parameters.AddWithValue("@ID", VArec.Tables("va").Rows(VAposition)("ID"))
                tsc.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception("Chyba při výmazu případu: " + ex.Message)
                Exit Sub
            End Try
        Else
            Exit Sub
        End If
        VArec.Clear()
        VAdat.Fill(VArec, "va")
        VAcount = VArec.Tables("va").Rows.Count
        If VAposition = VAcount Then
            VAposition -= 1
        End If
        Call FillForm()
    End Sub

    Private Sub Bt_List_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_List.Click
        If my_sez Is Nothing Then
            my_sez = New Frm_VAsez
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
        Me.BackColor = Color.FromArgb(FVV)
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
        Label1.ForeColor = Color.FromArgb(FVVF)
        Label2.ForeColor = Color.FromArgb(FVVF)
        Label3.ForeColor = Color.FromArgb(FVVF)
        Label4.ForeColor = Color.FromArgb(FVVF)
        Label5.ForeColor = Color.FromArgb(FVVF)
        Label6.ForeColor = Color.FromArgb(FVVF)
        Txt_Num.ForeColor = Color.FromArgb(FVVF)
        Txt_vantage.ForeColor = Color.FromArgb(FVVF)
        Txt_typ.ForeColor = Color.FromArgb(FVVF)
        Txt_multi.ForeColor = Color.FromArgb(FVVF)
        Txt_cena.ForeColor = Color.FromArgb(FVVF)
        Txt_popis.ForeColor = Color.FromArgb(FVVF)
        Txt_vliv.ForeColor = Color.FromArgb(FVVF)

    End Sub


End Class