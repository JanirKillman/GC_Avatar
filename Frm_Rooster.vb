Imports System.Data.oledb

Public Class Frm_Rooster
    Inherits System.Windows.Forms.Form
    Private t As Int16
    Dim mm As New MM
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb4 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb5 As System.Windows.Forms.RadioButton
    Friend WithEvents TbY As System.Windows.Forms.TextBox
    Friend WithEvents TbM As System.Windows.Forms.TextBox
    Friend WithEvents TbD As System.Windows.Forms.TextBox
    Friend WithEvents TbH As System.Windows.Forms.TextBox
    Friend WithEvents TbMi As System.Windows.Forms.TextBox
    Friend WithEvents BtKont As System.Windows.Forms.Button
    Friend WithEvents BtRep As System.Windows.Forms.Button
    Friend WithEvents BtAct As System.Windows.Forms.Button
    Friend WithEvents LbRoosters As System.Windows.Forms.ListBox
    Friend WithEvents BtDel As System.Windows.Forms.Button
    Friend WithEvents BtCus As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Rooster))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Rb1 = New System.Windows.Forms.RadioButton
        Me.Rb2 = New System.Windows.Forms.RadioButton
        Me.Rb3 = New System.Windows.Forms.RadioButton
        Me.Rb4 = New System.Windows.Forms.RadioButton
        Me.Rb5 = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.TbY = New System.Windows.Forms.TextBox
        Me.TbM = New System.Windows.Forms.TextBox
        Me.TbD = New System.Windows.Forms.TextBox
        Me.TbH = New System.Windows.Forms.TextBox
        Me.TbMi = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.BtKont = New System.Windows.Forms.Button
        Me.BtRep = New System.Windows.Forms.Button
        Me.BtAct = New System.Windows.Forms.Button
        Me.LbRoosters = New System.Windows.Forms.ListBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtDel = New System.Windows.Forms.Button
        Me.BtCus = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kokrhání"
        '
        'Rb1
        '
        Me.Rb1.Checked = True
        Me.Rb1.Location = New System.Drawing.Point(144, 32)
        Me.Rb1.Name = "Rb1"
        Me.Rb1.Size = New System.Drawing.Size(104, 16)
        Me.Rb1.TabIndex = 1
        Me.Rb1.TabStop = True
        Me.Rb1.Text = "1 - Greed"
        '
        'Rb2
        '
        Me.Rb2.Location = New System.Drawing.Point(144, 48)
        Me.Rb2.Name = "Rb2"
        Me.Rb2.Size = New System.Drawing.Size(104, 16)
        Me.Rb2.TabIndex = 2
        Me.Rb2.Text = "2 - Havranův let"
        '
        'Rb3
        '
        Me.Rb3.Location = New System.Drawing.Point(144, 64)
        Me.Rb3.Name = "Rb3"
        Me.Rb3.Size = New System.Drawing.Size(104, 16)
        Me.Rb3.TabIndex = 3
        Me.Rb3.Text = "3 - Donkey"
        '
        'Rb4
        '
        Me.Rb4.Location = New System.Drawing.Point(144, 80)
        Me.Rb4.Name = "Rb4"
        Me.Rb4.Size = New System.Drawing.Size(104, 16)
        Me.Rb4.TabIndex = 4
        Me.Rb4.Text = "4 - Dědek"
        '
        'Rb5
        '
        Me.Rb5.Location = New System.Drawing.Point(144, 96)
        Me.Rb5.Name = "Rb5"
        Me.Rb5.Size = New System.Drawing.Size(104, 16)
        Me.Rb5.TabIndex = 5
        Me.Rb5.Text = "5 - Habet"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nastavit"
        '
        'TbY
        '
        Me.TbY.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbY.Location = New System.Drawing.Point(72, 32)
        Me.TbY.MaxLength = 4
        Me.TbY.Name = "TbY"
        Me.TbY.Size = New System.Drawing.Size(40, 20)
        Me.TbY.TabIndex = 7
        '
        'TbM
        '
        Me.TbM.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbM.Location = New System.Drawing.Point(72, 48)
        Me.TbM.MaxLength = 2
        Me.TbM.Name = "TbM"
        Me.TbM.Size = New System.Drawing.Size(40, 20)
        Me.TbM.TabIndex = 8
        '
        'TbD
        '
        Me.TbD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbD.Location = New System.Drawing.Point(72, 64)
        Me.TbD.MaxLength = 2
        Me.TbD.Name = "TbD"
        Me.TbD.Size = New System.Drawing.Size(40, 20)
        Me.TbD.TabIndex = 9
        '
        'TbH
        '
        Me.TbH.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbH.Location = New System.Drawing.Point(72, 80)
        Me.TbH.MaxLength = 2
        Me.TbH.Name = "TbH"
        Me.TbH.Size = New System.Drawing.Size(40, 20)
        Me.TbH.TabIndex = 10
        '
        'TbMi
        '
        Me.TbMi.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbMi.Location = New System.Drawing.Point(72, 96)
        Me.TbMi.MaxLength = 2
        Me.TbMi.Name = "TbMi"
        Me.TbMi.Size = New System.Drawing.Size(40, 20)
        Me.TbMi.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Rok"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Měsíc"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Den"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Hodina"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Minuta"
        '
        'BtKont
        '
        Me.BtKont.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtKont.Location = New System.Drawing.Point(152, 112)
        Me.BtKont.Name = "BtKont"
        Me.BtKont.Size = New System.Drawing.Size(88, 24)
        Me.BtKont.TabIndex = 17
        Me.BtKont.Text = "Kontinuální"
        '
        'BtRep
        '
        Me.BtRep.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtRep.Location = New System.Drawing.Point(152, 136)
        Me.BtRep.Name = "BtRep"
        Me.BtRep.Size = New System.Drawing.Size(88, 24)
        Me.BtRep.TabIndex = 18
        Me.BtRep.Text = "Opakované"
        '
        'BtAct
        '
        Me.BtAct.ForeColor = System.Drawing.Color.Lime
        Me.BtAct.Location = New System.Drawing.Point(152, 160)
        Me.BtAct.Name = "BtAct"
        Me.BtAct.Size = New System.Drawing.Size(88, 24)
        Me.BtAct.TabIndex = 19
        Me.BtAct.Text = "Aktivovat"
        '
        'LbRoosters
        '
        Me.LbRoosters.BackColor = System.Drawing.Color.Navy
        Me.LbRoosters.ForeColor = System.Drawing.Color.Yellow
        Me.LbRoosters.Location = New System.Drawing.Point(8, 136)
        Me.LbRoosters.Name = "LbRoosters"
        Me.LbRoosters.Size = New System.Drawing.Size(120, 95)
        Me.LbRoosters.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Aktivní"
        '
        'BtDel
        '
        Me.BtDel.ForeColor = System.Drawing.Color.Red
        Me.BtDel.Location = New System.Drawing.Point(152, 184)
        Me.BtDel.Name = "BtDel"
        Me.BtDel.Size = New System.Drawing.Size(88, 24)
        Me.BtDel.TabIndex = 22
        Me.BtDel.Text = "Smazat"
        '
        'BtCus
        '
        Me.BtCus.ForeColor = System.Drawing.Color.Aqua
        Me.BtCus.Location = New System.Drawing.Point(152, 208)
        Me.BtCus.Name = "BtCus"
        Me.BtCus.Size = New System.Drawing.Size(88, 24)
        Me.BtCus.TabIndex = 23
        Me.BtCus.Text = "Customizovat"
        '
        'Frm_Rooster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(248, 238)
        Me.Controls.Add(Me.BtCus)
        Me.Controls.Add(Me.BtDel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LbRoosters)
        Me.Controls.Add(Me.BtAct)
        Me.Controls.Add(Me.BtRep)
        Me.Controls.Add(Me.BtKont)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbMi)
        Me.Controls.Add(Me.TbH)
        Me.Controls.Add(Me.TbD)
        Me.Controls.Add(Me.TbM)
        Me.Controls.Add(Me.TbY)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Rb5)
        Me.Controls.Add(Me.Rb4)
        Me.Controls.Add(Me.Rb3)
        Me.Controls.Add(Me.Rb2)
        Me.Controls.Add(Me.Rb1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Frm_Rooster"
        Me.Text = "GC_Kohout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Frm_Rooster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim u As String
        Dim z As Int16
        Check_Roosters()
        TbY.Text = Year(Today)
        TbM.Text = Month(Today)
        TbD.Text = Microsoft.VisualBasic.DateAndTime.Day(Today)
        TbH.Text = "6"
        TbMi.Text = "15"
        t = 1
        For z = 1 To 5
            u = GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Kohouti", z, "")
            If u <> "" Then
                Select Case z
                    Case Is = 1
                        Rb1.Text = "1 - " & Mid(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Kokrhani", 1, ""), 1, 12)
                    Case Is = 2
                        Rb2.Text = "2 - " & Mid(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Kokrhani", 2, ""), 1, 12)
                    Case Is = 3
                        Rb3.Text = "3 - " & Mid(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Kokrhani", 3, ""), 1, 12)
                    Case Is = 4
                        Rb4.Text = "4 - " & Mid(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Kokrhani", 4, ""), 1, 12)
                    Case Is = 5
                        Rb5.Text = "5 - " & Mid(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Kokrhani", 5, ""), 1, 12)
                End Select
            End If
        Next
    End Sub

    Private Sub Check_Roosters()
        Dim x As Int16
        LbRoosters.Items.Clear()
        If GCR.Tables("R") Is Nothing Then
            x = 0
        Else
            For x = 0 To (GCR.Tables("R").Rows.Count - 1)
                LbRoosters.Items.Add(CStr(GCR.Tables("R").Rows(x)("TimeR")) & " " & GCR.Tables("R").Rows(x)("Rooster") & " " & GCR.Tables("R").Rows(x)("TypeR"))
            Next
            If GCR.Tables("R").Rows.Count > 0 Then
                TAlarm = GCR.Tables("R").Rows(0)("TimeR")
            Else
                TAlarm = ""
            End If
        End If
    End Sub

    Private Sub BtKont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtKont.Click
        If BtKont.ForeColor.ToArgb = System.Drawing.Color.Yellow.ToArgb Then
            BtKont.ForeColor = System.Drawing.Color.Red
            If BtRep.ForeColor.ToArgb = System.Drawing.Color.Red.ToArgb Then
                BtRep.ForeColor = System.Drawing.Color.Yellow
            End If
        Else
            BtKont.ForeColor = System.Drawing.Color.Yellow
        End If
    End Sub

    Private Sub BtRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtRep.Click
        If BtRep.ForeColor.ToArgb = System.Drawing.Color.Yellow.ToArgb Then
            BtRep.ForeColor = System.Drawing.Color.Red
            If BtKont.ForeColor.ToArgb = System.Drawing.Color.Red.ToArgb Then
                BtKont.ForeColor = System.Drawing.Color.Yellow
            End If
        Else
            BtRep.ForeColor = System.Drawing.Color.Yellow
        End If
    End Sub

    Private Sub BtAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtAct.Click
        'Dim a, b, c, d, e As Int16
        'a= 
        If Len(TbY.Text) < 4 Or CInt(TbY.Text) < Year(Today) Or CInt(TbY.Text) > 2050 Then
            MsgBox("Chybný rok", , "Chyba")
            Exit Sub
        End If
        If CInt(TbM.Text) < 1 Or CInt(TbM.Text) > 12 Then
            MsgBox("Chybný měsíc", , "Chyba")
            Exit Sub
        End If
        If CInt(TbD.Text) < 1 Or CInt(TbD.Text) > 31 Then
            MsgBox("Chybný den", , "Chyba")
            Exit Sub
        End If
        If CInt(TbH.Text) < 0 Or CInt(TbH.Text) > 23 Then
            MsgBox("Chybná hodina", , "Chyba")
            Exit Sub
        End If
        If CInt(TbMi.Text) < 0 Or CInt(TbMi.Text) > 59 Then
            MsgBox("Chybná minuta", , "Chyba")
            Exit Sub
        End If
        Dim tc As New OleDbCommand
        Dim tr As OleDbDataReader
        Try
            tc.Connection = Odrialink2
            tc.CommandText = "select * from Roosters where TimeR = @tm"
            tc.Parameters.AddWithValue("@tm", CDate(CInt(TbD.Text) & "." & CInt(TbM.Text) & "." & CInt(TbY.Text) & " " & CInt(TbH.Text) & ":" & CInt(TbMi.Text) & ":00"))
            tr = tc.ExecuteReader
        Catch ex As Exception
            MsgBox("Chyba při čtení databáze." + ex.Message, , "Chyba")
            tr.Close()
            Exit Sub
        End Try
        If Not tr.HasRows Then
            tr.Close()
            Dim i As New OleDbCommand
            Dim s, rt, xx As String
            Try
                s = "INSERT INTO Roosters (TimeR, Rooster, TypeR) VALUES (@Ti, @Ro, @Ty)"
                xx = CInt(TbD.Text) & "." & CInt(TbM.Text) & "." & CInt(TbY.Text) & " " & CInt(TbH.Text) & ":" & CInt(TbMi.Text) & ":00"
                i.Parameters.AddWithValue("@Ti", xx)
                i.Parameters.AddWithValue("@Ro", t)
                If BtKont.ForeColor.ToArgb = System.Drawing.Color.Red.ToArgb Then
                    rt = "C"
                Else
                    If BtRep.ForeColor.ToArgb = System.Drawing.Color.Red.ToArgb Then
                        rt = "R"
                    Else
                        rt = "N"
                    End If
                End If
                i.Parameters.AddWithValue("@Ty", rt)
                i.Connection = Odrialink2
                i.CommandText = s
                i.ExecuteScalar()
            Catch ex As Exception
                MsgBox("Chyba při zápiso do databáze." + ex.Message, , "Chyba")
                tr.Close()
                Exit Sub
            End Try
            GCR.Clear()
            GCRdat.Fill(GCR, "R")
            Check_Roosters()
        Else
            tr.Close()
            MsgBox("Jeden stejný kohout již na smetišti je!", MsgBoxStyle.Exclamation, "Chyba")
            Exit Sub
        End If
    End Sub

    Private Sub Rb1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb1.CheckedChanged
        If Rb1.Checked = True Then
            t = 1
        End If
    End Sub

    Private Sub Rb2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb2.CheckedChanged
        If Rb2.Checked = True Then
            t = 2
        End If
    End Sub

    Private Sub Rb3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb3.CheckedChanged
        If Rb3.Checked = True Then
            t = 3
        End If
    End Sub

    Private Sub Rb4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb4.CheckedChanged
        If Rb4.Checked = True Then
            t = 4
        End If
    End Sub

    Private Sub Rb5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rb5.CheckedChanged
        If Rb5.Checked = True Then
            t = 5
        End If
    End Sub

    Private Sub BtDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtDel.Click
        If LbRoosters.Text <> "" Then
            If MsgBox("Opravdu chcete zastřelit kohouta " & LbRoosters.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Potvrzení") = MsgBoxResult.No Then
                Exit Sub
            End If
            Try
                Dim rd As New OleDbCommand
                rd.Connection = Odrialink2
                rd.CommandText = "DELETE from Roosters WHERE TimeR = @Tim"
                rd.Parameters.AddWithValue("@Tim", Mid(LbRoosters.Text, 1, Len(LbRoosters.Text) - 4))
                rd.ExecuteScalar()
            Catch ex As Exception
                Throw New Exception("Chyba při výmazu případu: " + ex.Message)
                Exit Sub
            End Try
            MsgBox("Byl zastřelen kohout " & LbRoosters.Text & ".")
            GCR.Clear()
            GCRdat.Fill(GCR, "R")
            Check_Roosters()
        End If
    End Sub

    Private Sub BtCus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCus.Click
        OpenFileDialog1.Filter = "Skladby (*.mp3)|*.mp3"
        OpenFileDialog1.Title = "Vyber nové kokrhání pro kohouta " & t
        OpenFileDialog1.ShowDialog()
        SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Kohouti", t, OpenFileDialog1.FileName)
        mm.ListSingleNoChar(OpenFileDialog1.FileName)
        SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Kokrhani", t, Song)
        Select Case t
            Case Is = 1
                Rb1.Text = "1 - " & Mid(Song, 1, 12)
            Case Is = 2
                Rb2.Text = "2 - " & Mid(Song, 1, 12)
            Case Is = 3
                Rb3.Text = "3 - " & Mid(Song, 1, 12)
            Case Is = 4
                Rb4.Text = "4 - " & Mid(Song, 1, 12)
            Case Is = 5
                Rb5.Text = "5 - " & Mid(Song, 1, 12)
        End Select
    End Sub
End Class
