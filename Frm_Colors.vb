Imports System.Drawing
Imports System.Drawing.Color
Public Class Frm_Colors
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents mb As System.Windows.Forms.Button
    Friend WithEvents mf As System.Windows.Forms.Button
    Friend WithEvents mb2 As System.Windows.Forms.Button
    Friend WithEvents mf2 As System.Windows.Forms.Button
    Friend WithEvents mf3 As System.Windows.Forms.Button
    Friend WithEvents mf4 As System.Windows.Forms.Button
    Friend WithEvents ci As System.Windows.Forms.Button
    Friend WithEvents cd As System.Windows.Forms.Button
    Friend WithEvents cf As System.Windows.Forms.Button
    Friend WithEvents cn As System.Windows.Forms.Button
    Friend WithEvents cp As System.Windows.Forms.Button
    Friend WithEvents co As System.Windows.Forms.Button
    Friend WithEvents ce As System.Windows.Forms.Button
    Friend WithEvents cfo As System.Windows.Forms.Button
    Friend WithEvents fa As System.Windows.Forms.Button
    Friend WithEvents faf As System.Windows.Forms.Button
    Friend WithEvents fb As System.Windows.Forms.Button
    Friend WithEvents fbf As System.Windows.Forms.Button
    Friend WithEvents fef As System.Windows.Forms.Button
    Friend WithEvents fe As System.Windows.Forms.Button
    Friend WithEvents fevf As System.Windows.Forms.Button
    Friend WithEvents fev As System.Windows.Forms.Button
    Friend WithEvents fcf As System.Windows.Forms.Button
    Friend WithEvents fc As System.Windows.Forms.Button
    Friend WithEvents fif As System.Windows.Forms.Button
    Friend WithEvents fi As System.Windows.Forms.Button
    Friend WithEvents fitf As System.Windows.Forms.Button
    Friend WithEvents fit As System.Windows.Forms.Button
    Friend WithEvents fpf As System.Windows.Forms.Button
    Friend WithEvents fp As System.Windows.Forms.Button
    Friend WithEvents flf As System.Windows.Forms.Button
    Friend WithEvents fl As System.Windows.Forms.Button
    Friend WithEvents fnf As System.Windows.Forms.Button
    Friend WithEvents fn As System.Windows.Forms.Button
    Friend WithEvents fof As System.Windows.Forms.Button
    Friend WithEvents fo As System.Windows.Forms.Button
    Friend WithEvents fpaf As System.Windows.Forms.Button
    Friend WithEvents fpa As System.Windows.Forms.Button
    Friend WithEvents fpef As System.Windows.Forms.Button
    Friend WithEvents fpe As System.Windows.Forms.Button
    Friend WithEvents fsf As System.Windows.Forms.Button
    Friend WithEvents fs As System.Windows.Forms.Button
    Friend WithEvents fskf As System.Windows.Forms.Button
    Friend WithEvents fsk As System.Windows.Forms.Button
    Friend WithEvents fspf As System.Windows.Forms.Button
    Friend WithEvents fsp As System.Windows.Forms.Button
    Friend WithEvents fwf As System.Windows.Forms.Button
    Friend WithEvents fw As System.Windows.Forms.Button
    Friend WithEvents fslf As System.Windows.Forms.Button
    Friend WithEvents fsl As System.Windows.Forms.Button
    Friend WithEvents frf As System.Windows.Forms.Button
    Friend WithEvents fr As System.Windows.Forms.Button
    Friend WithEvents fnof As System.Windows.Forms.Button
    Friend WithEvents fno As System.Windows.Forms.Button
    Friend WithEvents fcrf As System.Windows.Forms.Button
    Friend WithEvents fcr As System.Windows.Forms.Button
    Friend WithEvents farf As System.Windows.Forms.Button
    Friend WithEvents far As System.Windows.Forms.Button
    Friend WithEvents fpsf As System.Windows.Forms.Button
    Friend WithEvents fps As System.Windows.Forms.Button
    Friend WithEvents fruf As System.Windows.Forms.Button
    Friend WithEvents fru As System.Windows.Forms.Button
    Friend WithEvents fefef As System.Windows.Forms.Button
    Friend WithEvents fefe As System.Windows.Forms.Button
    Friend WithEvents BtSAV As System.Windows.Forms.Button
    Friend WithEvents BtLOAD As System.Windows.Forms.Button
    Public WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents fvff As System.Windows.Forms.Button
    Friend WithEvents fv As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Colors))
        Me.mb = New System.Windows.Forms.Button
        Me.mf = New System.Windows.Forms.Button
        Me.mb2 = New System.Windows.Forms.Button
        Me.mf2 = New System.Windows.Forms.Button
        Me.mf3 = New System.Windows.Forms.Button
        Me.mf4 = New System.Windows.Forms.Button
        Me.ci = New System.Windows.Forms.Button
        Me.cd = New System.Windows.Forms.Button
        Me.cf = New System.Windows.Forms.Button
        Me.cn = New System.Windows.Forms.Button
        Me.cp = New System.Windows.Forms.Button
        Me.co = New System.Windows.Forms.Button
        Me.ce = New System.Windows.Forms.Button
        Me.cfo = New System.Windows.Forms.Button
        Me.fa = New System.Windows.Forms.Button
        Me.faf = New System.Windows.Forms.Button
        Me.fb = New System.Windows.Forms.Button
        Me.fbf = New System.Windows.Forms.Button
        Me.fef = New System.Windows.Forms.Button
        Me.fe = New System.Windows.Forms.Button
        Me.fevf = New System.Windows.Forms.Button
        Me.fev = New System.Windows.Forms.Button
        Me.fcf = New System.Windows.Forms.Button
        Me.fc = New System.Windows.Forms.Button
        Me.fif = New System.Windows.Forms.Button
        Me.fi = New System.Windows.Forms.Button
        Me.fitf = New System.Windows.Forms.Button
        Me.fit = New System.Windows.Forms.Button
        Me.fpf = New System.Windows.Forms.Button
        Me.fp = New System.Windows.Forms.Button
        Me.flf = New System.Windows.Forms.Button
        Me.fl = New System.Windows.Forms.Button
        Me.fnf = New System.Windows.Forms.Button
        Me.fn = New System.Windows.Forms.Button
        Me.fof = New System.Windows.Forms.Button
        Me.fo = New System.Windows.Forms.Button
        Me.fpaf = New System.Windows.Forms.Button
        Me.fpa = New System.Windows.Forms.Button
        Me.fpef = New System.Windows.Forms.Button
        Me.fpe = New System.Windows.Forms.Button
        Me.fsf = New System.Windows.Forms.Button
        Me.fs = New System.Windows.Forms.Button
        Me.fskf = New System.Windows.Forms.Button
        Me.fsk = New System.Windows.Forms.Button
        Me.fspf = New System.Windows.Forms.Button
        Me.fsp = New System.Windows.Forms.Button
        Me.fwf = New System.Windows.Forms.Button
        Me.fw = New System.Windows.Forms.Button
        Me.fslf = New System.Windows.Forms.Button
        Me.fsl = New System.Windows.Forms.Button
        Me.frf = New System.Windows.Forms.Button
        Me.fr = New System.Windows.Forms.Button
        Me.fnof = New System.Windows.Forms.Button
        Me.fno = New System.Windows.Forms.Button
        Me.fcrf = New System.Windows.Forms.Button
        Me.fcr = New System.Windows.Forms.Button
        Me.farf = New System.Windows.Forms.Button
        Me.far = New System.Windows.Forms.Button
        Me.fpsf = New System.Windows.Forms.Button
        Me.fps = New System.Windows.Forms.Button
        Me.fruf = New System.Windows.Forms.Button
        Me.fru = New System.Windows.Forms.Button
        Me.fefef = New System.Windows.Forms.Button
        Me.fefe = New System.Windows.Forms.Button
        Me.BtSAV = New System.Windows.Forms.Button
        Me.BtLOAD = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.fvff = New System.Windows.Forms.Button
        Me.fv = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'mb
        '
        Me.mb.Location = New System.Drawing.Point(8, 8)
        Me.mb.Name = "mb"
        Me.mb.Size = New System.Drawing.Size(104, 24)
        Me.mb.TabIndex = 0
        Me.mb.Text = "MAIN BACK 1"
        '
        'mf
        '
        Me.mf.BackColor = System.Drawing.SystemColors.ControlText
        Me.mf.Location = New System.Drawing.Point(8, 56)
        Me.mf.Name = "mf"
        Me.mf.Size = New System.Drawing.Size(104, 24)
        Me.mf.TabIndex = 1
        Me.mf.Text = "MAIN FORE 1"
        Me.mf.UseVisualStyleBackColor = False
        '
        'mb2
        '
        Me.mb2.BackColor = System.Drawing.SystemColors.Control
        Me.mb2.Location = New System.Drawing.Point(8, 32)
        Me.mb2.Name = "mb2"
        Me.mb2.Size = New System.Drawing.Size(104, 24)
        Me.mb2.TabIndex = 2
        Me.mb2.Text = "MAIN BACK 2"
        Me.mb2.UseVisualStyleBackColor = False
        '
        'mf2
        '
        Me.mf2.BackColor = System.Drawing.Color.Green
        Me.mf2.Location = New System.Drawing.Point(8, 80)
        Me.mf2.Name = "mf2"
        Me.mf2.Size = New System.Drawing.Size(104, 24)
        Me.mf2.TabIndex = 3
        Me.mf2.Text = "MAIN FORE 2"
        Me.mf2.UseVisualStyleBackColor = False
        '
        'mf3
        '
        Me.mf3.BackColor = System.Drawing.Color.Yellow
        Me.mf3.Location = New System.Drawing.Point(8, 104)
        Me.mf3.Name = "mf3"
        Me.mf3.Size = New System.Drawing.Size(104, 24)
        Me.mf3.TabIndex = 4
        Me.mf3.Text = "MAIN FORE 3"
        Me.mf3.UseVisualStyleBackColor = False
        '
        'mf4
        '
        Me.mf4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mf4.Location = New System.Drawing.Point(8, 128)
        Me.mf4.Name = "mf4"
        Me.mf4.Size = New System.Drawing.Size(104, 24)
        Me.mf4.TabIndex = 5
        Me.mf4.Text = "MAIN FORE 4"
        Me.mf4.UseVisualStyleBackColor = False
        '
        'ci
        '
        Me.ci.BackColor = System.Drawing.Color.Green
        Me.ci.Location = New System.Drawing.Point(8, 152)
        Me.ci.Name = "ci"
        Me.ci.Size = New System.Drawing.Size(104, 24)
        Me.ci.TabIndex = 6
        Me.ci.Text = "VLOŽIT"
        Me.ci.UseVisualStyleBackColor = False
        '
        'cd
        '
        Me.cd.BackColor = System.Drawing.Color.Red
        Me.cd.Location = New System.Drawing.Point(8, 176)
        Me.cd.Name = "cd"
        Me.cd.Size = New System.Drawing.Size(104, 24)
        Me.cd.TabIndex = 7
        Me.cd.Text = "SMAZAT"
        Me.cd.UseVisualStyleBackColor = False
        '
        'cf
        '
        Me.cf.BackColor = System.Drawing.Color.Yellow
        Me.cf.Location = New System.Drawing.Point(8, 200)
        Me.cf.Name = "cf"
        Me.cf.Size = New System.Drawing.Size(104, 24)
        Me.cf.TabIndex = 8
        Me.cf.Text = "NAJÍT"
        Me.cf.UseVisualStyleBackColor = False
        '
        'cn
        '
        Me.cn.BackColor = System.Drawing.Color.White
        Me.cn.Location = New System.Drawing.Point(8, 224)
        Me.cn.Name = "cn"
        Me.cn.Size = New System.Drawing.Size(104, 24)
        Me.cn.TabIndex = 9
        Me.cn.Text = "NOVÉ"
        Me.cn.UseVisualStyleBackColor = False
        '
        'cp
        '
        Me.cp.BackColor = System.Drawing.Color.Cyan
        Me.cp.Location = New System.Drawing.Point(8, 248)
        Me.cp.Name = "cp"
        Me.cp.Size = New System.Drawing.Size(104, 24)
        Me.cp.TabIndex = 10
        Me.cp.Text = "TISK"
        Me.cp.UseVisualStyleBackColor = False
        '
        'co
        '
        Me.co.BackColor = System.Drawing.Color.Fuchsia
        Me.co.Location = New System.Drawing.Point(8, 272)
        Me.co.Name = "co"
        Me.co.Size = New System.Drawing.Size(104, 24)
        Me.co.TabIndex = 11
        Me.co.Text = "ŘAZENÍ"
        Me.co.UseVisualStyleBackColor = False
        '
        'ce
        '
        Me.ce.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ce.Location = New System.Drawing.Point(8, 296)
        Me.ce.Name = "ce"
        Me.ce.Size = New System.Drawing.Size(104, 24)
        Me.ce.TabIndex = 12
        Me.ce.Text = "EXIT"
        Me.ce.UseVisualStyleBackColor = False
        '
        'cfo
        '
        Me.cfo.BackColor = System.Drawing.SystemColors.ControlText
        Me.cfo.Location = New System.Drawing.Point(8, 320)
        Me.cfo.Name = "cfo"
        Me.cfo.Size = New System.Drawing.Size(104, 24)
        Me.cfo.TabIndex = 13
        Me.cfo.Text = "CMD FORE"
        Me.cfo.UseVisualStyleBackColor = False
        '
        'fa
        '
        Me.fa.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fa.Location = New System.Drawing.Point(128, 8)
        Me.fa.Name = "fa"
        Me.fa.Size = New System.Drawing.Size(104, 24)
        Me.fa.TabIndex = 14
        Me.fa.Text = "ARTEFAKTY"
        Me.fa.UseVisualStyleBackColor = False
        '
        'faf
        '
        Me.faf.BackColor = System.Drawing.SystemColors.ControlText
        Me.faf.Location = New System.Drawing.Point(232, 8)
        Me.faf.Name = "faf"
        Me.faf.Size = New System.Drawing.Size(104, 24)
        Me.faf.TabIndex = 15
        Me.faf.Text = "FORE"
        Me.faf.UseVisualStyleBackColor = False
        '
        'fb
        '
        Me.fb.BackColor = System.Drawing.Color.Green
        Me.fb.Location = New System.Drawing.Point(128, 32)
        Me.fb.Name = "fb"
        Me.fb.Size = New System.Drawing.Size(104, 24)
        Me.fb.TabIndex = 16
        Me.fb.Text = "BESTIE"
        Me.fb.UseVisualStyleBackColor = False
        '
        'fbf
        '
        Me.fbf.BackColor = System.Drawing.Color.Yellow
        Me.fbf.Location = New System.Drawing.Point(232, 32)
        Me.fbf.Name = "fbf"
        Me.fbf.Size = New System.Drawing.Size(104, 24)
        Me.fbf.TabIndex = 17
        Me.fbf.Text = "FORE"
        Me.fbf.UseVisualStyleBackColor = False
        '
        'fef
        '
        Me.fef.BackColor = System.Drawing.Color.Yellow
        Me.fef.Location = New System.Drawing.Point(232, 56)
        Me.fef.Name = "fef"
        Me.fef.Size = New System.Drawing.Size(104, 24)
        Me.fef.TabIndex = 19
        Me.fef.Text = "FORE"
        Me.fef.UseVisualStyleBackColor = False
        '
        'fe
        '
        Me.fe.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fe.Location = New System.Drawing.Point(128, 56)
        Me.fe.Name = "fe"
        Me.fe.Size = New System.Drawing.Size(104, 24)
        Me.fe.TabIndex = 18
        Me.fe.Text = "ELEMENTY"
        Me.fe.UseVisualStyleBackColor = False
        '
        'fevf
        '
        Me.fevf.BackColor = System.Drawing.SystemColors.ControlText
        Me.fevf.Location = New System.Drawing.Point(232, 80)
        Me.fevf.Name = "fevf"
        Me.fevf.Size = New System.Drawing.Size(104, 24)
        Me.fevf.TabIndex = 21
        Me.fevf.Text = "FORE"
        Me.fevf.UseVisualStyleBackColor = False
        '
        'fev
        '
        Me.fev.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fev.Location = New System.Drawing.Point(128, 80)
        Me.fev.Name = "fev"
        Me.fev.Size = New System.Drawing.Size(104, 24)
        Me.fev.TabIndex = 20
        Me.fev.Text = "UDÁLOSTI"
        Me.fev.UseVisualStyleBackColor = False
        '
        'fcf
        '
        Me.fcf.BackColor = System.Drawing.SystemColors.ControlText
        Me.fcf.Location = New System.Drawing.Point(232, 104)
        Me.fcf.Name = "fcf"
        Me.fcf.Size = New System.Drawing.Size(104, 24)
        Me.fcf.TabIndex = 23
        Me.fcf.Text = "FORE"
        Me.fcf.UseVisualStyleBackColor = False
        '
        'fc
        '
        Me.fc.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fc.Location = New System.Drawing.Point(128, 104)
        Me.fc.Name = "fc"
        Me.fc.Size = New System.Drawing.Size(104, 24)
        Me.fc.TabIndex = 22
        Me.fc.Text = "POSTAVY"
        Me.fc.UseVisualStyleBackColor = False
        '
        'fif
        '
        Me.fif.BackColor = System.Drawing.SystemColors.ControlText
        Me.fif.Location = New System.Drawing.Point(232, 128)
        Me.fif.Name = "fif"
        Me.fif.Size = New System.Drawing.Size(104, 24)
        Me.fif.TabIndex = 25
        Me.fif.Text = "FORE"
        Me.fif.UseVisualStyleBackColor = False
        '
        'fi
        '
        Me.fi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.fi.Location = New System.Drawing.Point(128, 128)
        Me.fi.Name = "fi"
        Me.fi.Size = New System.Drawing.Size(104, 24)
        Me.fi.TabIndex = 24
        Me.fi.Text = "INFO"
        Me.fi.UseVisualStyleBackColor = False
        '
        'fitf
        '
        Me.fitf.BackColor = System.Drawing.SystemColors.ControlText
        Me.fitf.Location = New System.Drawing.Point(232, 152)
        Me.fitf.Name = "fitf"
        Me.fitf.Size = New System.Drawing.Size(104, 24)
        Me.fitf.TabIndex = 27
        Me.fitf.Text = "FORE"
        Me.fitf.UseVisualStyleBackColor = False
        '
        'fit
        '
        Me.fit.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.fit.Location = New System.Drawing.Point(128, 152)
        Me.fit.Name = "fit"
        Me.fit.Size = New System.Drawing.Size(104, 24)
        Me.fit.TabIndex = 26
        Me.fit.Text = "ITEMY"
        Me.fit.UseVisualStyleBackColor = False
        '
        'fpf
        '
        Me.fpf.BackColor = System.Drawing.SystemColors.ControlText
        Me.fpf.Location = New System.Drawing.Point(232, 176)
        Me.fpf.Name = "fpf"
        Me.fpf.Size = New System.Drawing.Size(104, 24)
        Me.fpf.TabIndex = 29
        Me.fpf.Text = "FORE"
        Me.fpf.UseVisualStyleBackColor = False
        '
        'fp
        '
        Me.fp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fp.Location = New System.Drawing.Point(128, 176)
        Me.fp.Name = "fp"
        Me.fp.Size = New System.Drawing.Size(104, 24)
        Me.fp.TabIndex = 28
        Me.fp.Text = "CENNÍK"
        Me.fp.UseVisualStyleBackColor = False
        '
        'flf
        '
        Me.flf.BackColor = System.Drawing.SystemColors.ControlText
        Me.flf.Location = New System.Drawing.Point(232, 200)
        Me.flf.Name = "flf"
        Me.flf.Size = New System.Drawing.Size(104, 24)
        Me.flf.TabIndex = 31
        Me.flf.Text = "FORE"
        Me.flf.UseVisualStyleBackColor = False
        '
        'fl
        '
        Me.fl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.fl.Location = New System.Drawing.Point(128, 200)
        Me.fl.Name = "fl"
        Me.fl.Size = New System.Drawing.Size(104, 24)
        Me.fl.TabIndex = 30
        Me.fl.Text = "JAZYKY"
        Me.fl.UseVisualStyleBackColor = False
        '
        'fnf
        '
        Me.fnf.BackColor = System.Drawing.SystemColors.ControlText
        Me.fnf.Location = New System.Drawing.Point(232, 224)
        Me.fnf.Name = "fnf"
        Me.fnf.Size = New System.Drawing.Size(104, 24)
        Me.fnf.TabIndex = 33
        Me.fnf.Text = "FORE"
        Me.fnf.UseVisualStyleBackColor = False
        '
        'fn
        '
        Me.fn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fn.Location = New System.Drawing.Point(128, 224)
        Me.fn.Name = "fn"
        Me.fn.Size = New System.Drawing.Size(104, 24)
        Me.fn.TabIndex = 32
        Me.fn.Text = "NÁRODY"
        Me.fn.UseVisualStyleBackColor = False
        '
        'fof
        '
        Me.fof.BackColor = System.Drawing.SystemColors.ControlText
        Me.fof.Location = New System.Drawing.Point(232, 248)
        Me.fof.Name = "fof"
        Me.fof.Size = New System.Drawing.Size(104, 24)
        Me.fof.TabIndex = 35
        Me.fof.Text = "FORE"
        Me.fof.UseVisualStyleBackColor = False
        '
        'fo
        '
        Me.fo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fo.Location = New System.Drawing.Point(128, 248)
        Me.fo.Name = "fo"
        Me.fo.Size = New System.Drawing.Size(104, 24)
        Me.fo.TabIndex = 34
        Me.fo.Text = "ORGANISACE"
        Me.fo.UseVisualStyleBackColor = False
        '
        'fpaf
        '
        Me.fpaf.BackColor = System.Drawing.SystemColors.ControlText
        Me.fpaf.Location = New System.Drawing.Point(232, 272)
        Me.fpaf.Name = "fpaf"
        Me.fpaf.Size = New System.Drawing.Size(104, 24)
        Me.fpaf.TabIndex = 37
        Me.fpaf.Text = "FORE"
        Me.fpaf.UseVisualStyleBackColor = False
        '
        'fpa
        '
        Me.fpa.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fpa.Location = New System.Drawing.Point(128, 272)
        Me.fpa.Name = "fpa"
        Me.fpa.Size = New System.Drawing.Size(104, 24)
        Me.fpa.TabIndex = 36
        Me.fpa.Text = "HESLA"
        Me.fpa.UseVisualStyleBackColor = False
        '
        'fpef
        '
        Me.fpef.BackColor = System.Drawing.SystemColors.ControlText
        Me.fpef.Location = New System.Drawing.Point(232, 296)
        Me.fpef.Name = "fpef"
        Me.fpef.Size = New System.Drawing.Size(104, 24)
        Me.fpef.TabIndex = 39
        Me.fpef.Text = "FORE"
        Me.fpef.UseVisualStyleBackColor = False
        '
        'fpe
        '
        Me.fpe.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fpe.Location = New System.Drawing.Point(128, 296)
        Me.fpe.Name = "fpe"
        Me.fpe.Size = New System.Drawing.Size(104, 24)
        Me.fpe.TabIndex = 38
        Me.fpe.Text = "OSOBY"
        Me.fpe.UseVisualStyleBackColor = False
        '
        'fsf
        '
        Me.fsf.BackColor = System.Drawing.SystemColors.ControlText
        Me.fsf.Location = New System.Drawing.Point(448, 8)
        Me.fsf.Name = "fsf"
        Me.fsf.Size = New System.Drawing.Size(104, 24)
        Me.fsf.TabIndex = 41
        Me.fsf.Text = "FORE"
        Me.fsf.UseVisualStyleBackColor = False
        '
        'fs
        '
        Me.fs.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.fs.Location = New System.Drawing.Point(344, 8)
        Me.fs.Name = "fs"
        Me.fs.Size = New System.Drawing.Size(104, 24)
        Me.fs.TabIndex = 40
        Me.fs.Text = "MÍSTA"
        Me.fs.UseVisualStyleBackColor = False
        '
        'fskf
        '
        Me.fskf.BackColor = System.Drawing.SystemColors.ControlText
        Me.fskf.Location = New System.Drawing.Point(448, 32)
        Me.fskf.Name = "fskf"
        Me.fskf.Size = New System.Drawing.Size(104, 24)
        Me.fskf.TabIndex = 43
        Me.fskf.Text = "FORE"
        Me.fskf.UseVisualStyleBackColor = False
        '
        'fsk
        '
        Me.fsk.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fsk.Location = New System.Drawing.Point(344, 32)
        Me.fsk.Name = "fsk"
        Me.fsk.Size = New System.Drawing.Size(104, 24)
        Me.fsk.TabIndex = 42
        Me.fsk.Text = "SKILLY"
        Me.fsk.UseVisualStyleBackColor = False
        '
        'fspf
        '
        Me.fspf.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fspf.Location = New System.Drawing.Point(448, 56)
        Me.fspf.Name = "fspf"
        Me.fspf.Size = New System.Drawing.Size(104, 24)
        Me.fspf.TabIndex = 45
        Me.fspf.Text = "FORE"
        Me.fspf.UseVisualStyleBackColor = False
        '
        'fsp
        '
        Me.fsp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fsp.Location = New System.Drawing.Point(344, 56)
        Me.fsp.Name = "fsp"
        Me.fsp.Size = New System.Drawing.Size(104, 24)
        Me.fsp.TabIndex = 44
        Me.fsp.Text = "KOUZLA"
        Me.fsp.UseVisualStyleBackColor = False
        '
        'fwf
        '
        Me.fwf.BackColor = System.Drawing.SystemColors.ControlText
        Me.fwf.Location = New System.Drawing.Point(448, 80)
        Me.fwf.Name = "fwf"
        Me.fwf.Size = New System.Drawing.Size(104, 24)
        Me.fwf.TabIndex = 47
        Me.fwf.Text = "FORE"
        Me.fwf.UseVisualStyleBackColor = False
        '
        'fw
        '
        Me.fw.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fw.Location = New System.Drawing.Point(344, 80)
        Me.fw.Name = "fw"
        Me.fw.Size = New System.Drawing.Size(104, 24)
        Me.fw.TabIndex = 46
        Me.fw.Text = "ZBRANě"
        Me.fw.UseVisualStyleBackColor = False
        '
        'fslf
        '
        Me.fslf.BackColor = System.Drawing.SystemColors.ControlText
        Me.fslf.Location = New System.Drawing.Point(448, 104)
        Me.fslf.Name = "fslf"
        Me.fslf.Size = New System.Drawing.Size(104, 24)
        Me.fslf.TabIndex = 49
        Me.fslf.Text = "FORE"
        Me.fslf.UseVisualStyleBackColor = False
        '
        'fsl
        '
        Me.fsl.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fsl.Location = New System.Drawing.Point(344, 104)
        Me.fsl.Name = "fsl"
        Me.fsl.Size = New System.Drawing.Size(104, 24)
        Me.fsl.TabIndex = 48
        Me.fsl.Text = "SLOVNÍK"
        Me.fsl.UseVisualStyleBackColor = False
        '
        'frf
        '
        Me.frf.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.frf.Location = New System.Drawing.Point(448, 128)
        Me.frf.Name = "frf"
        Me.frf.Size = New System.Drawing.Size(104, 24)
        Me.frf.TabIndex = 51
        Me.frf.Text = "FORE"
        Me.frf.UseVisualStyleBackColor = False
        '
        'fr
        '
        Me.fr.BackColor = System.Drawing.Color.Maroon
        Me.fr.Location = New System.Drawing.Point(344, 128)
        Me.fr.Name = "fr"
        Me.fr.Size = New System.Drawing.Size(104, 24)
        Me.fr.TabIndex = 50
        Me.fr.Text = "RASY"
        Me.fr.UseVisualStyleBackColor = False
        '
        'fnof
        '
        Me.fnof.BackColor = System.Drawing.SystemColors.ControlText
        Me.fnof.Location = New System.Drawing.Point(448, 152)
        Me.fnof.Name = "fnof"
        Me.fnof.Size = New System.Drawing.Size(104, 24)
        Me.fnof.TabIndex = 53
        Me.fnof.Text = "FORE"
        Me.fnof.UseVisualStyleBackColor = False
        '
        'fno
        '
        Me.fno.BackColor = System.Drawing.Color.Cyan
        Me.fno.Location = New System.Drawing.Point(344, 152)
        Me.fno.Name = "fno"
        Me.fno.Size = New System.Drawing.Size(104, 24)
        Me.fno.TabIndex = 52
        Me.fno.Text = "POZNÁMKY"
        Me.fno.UseVisualStyleBackColor = False
        '
        'fcrf
        '
        Me.fcrf.BackColor = System.Drawing.SystemColors.ControlText
        Me.fcrf.Location = New System.Drawing.Point(448, 176)
        Me.fcrf.Name = "fcrf"
        Me.fcrf.Size = New System.Drawing.Size(104, 24)
        Me.fcrf.TabIndex = 55
        Me.fcrf.Text = "FORE"
        Me.fcrf.UseVisualStyleBackColor = False
        '
        'fcr
        '
        Me.fcr.BackColor = System.Drawing.Color.Green
        Me.fcr.Location = New System.Drawing.Point(344, 176)
        Me.fcr.Name = "fcr"
        Me.fcr.Size = New System.Drawing.Size(104, 24)
        Me.fcr.TabIndex = 54
        Me.fcr.Text = "CLASSRULE"
        Me.fcr.UseVisualStyleBackColor = False
        '
        'farf
        '
        Me.farf.BackColor = System.Drawing.SystemColors.ControlText
        Me.farf.Location = New System.Drawing.Point(448, 200)
        Me.farf.Name = "farf"
        Me.farf.Size = New System.Drawing.Size(104, 24)
        Me.farf.TabIndex = 57
        Me.farf.Text = "FORE"
        Me.farf.UseVisualStyleBackColor = False
        '
        'far
        '
        Me.far.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.far.Location = New System.Drawing.Point(344, 200)
        Me.far.Name = "far"
        Me.far.Size = New System.Drawing.Size(104, 24)
        Me.far.TabIndex = 56
        Me.far.Text = "UMěNÍ"
        Me.far.UseVisualStyleBackColor = False
        '
        'fpsf
        '
        Me.fpsf.BackColor = System.Drawing.SystemColors.ControlText
        Me.fpsf.Location = New System.Drawing.Point(448, 224)
        Me.fpsf.Name = "fpsf"
        Me.fpsf.Size = New System.Drawing.Size(104, 24)
        Me.fpsf.TabIndex = 59
        Me.fpsf.Text = "FORE"
        Me.fpsf.UseVisualStyleBackColor = False
        '
        'fps
        '
        Me.fps.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fps.Location = New System.Drawing.Point(344, 224)
        Me.fps.Name = "fps"
        Me.fps.Size = New System.Drawing.Size(104, 24)
        Me.fps.TabIndex = 58
        Me.fps.Text = "PSIONICS"
        Me.fps.UseVisualStyleBackColor = False
        '
        'fruf
        '
        Me.fruf.BackColor = System.Drawing.SystemColors.ControlText
        Me.fruf.Location = New System.Drawing.Point(448, 248)
        Me.fruf.Name = "fruf"
        Me.fruf.Size = New System.Drawing.Size(104, 24)
        Me.fruf.TabIndex = 61
        Me.fruf.Text = "FORE"
        Me.fruf.UseVisualStyleBackColor = False
        '
        'fru
        '
        Me.fru.BackColor = System.Drawing.Color.Green
        Me.fru.Location = New System.Drawing.Point(344, 248)
        Me.fru.Name = "fru"
        Me.fru.Size = New System.Drawing.Size(104, 24)
        Me.fru.TabIndex = 60
        Me.fru.Text = "PRAVIDLA"
        Me.fru.UseVisualStyleBackColor = False
        '
        'fefef
        '
        Me.fefef.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.fefef.Location = New System.Drawing.Point(448, 272)
        Me.fefef.Name = "fefef"
        Me.fefef.Size = New System.Drawing.Size(104, 24)
        Me.fefef.TabIndex = 63
        Me.fefef.Text = "FORE"
        Me.fefef.UseVisualStyleBackColor = False
        '
        'fefe
        '
        Me.fefe.BackColor = System.Drawing.Color.Purple
        Me.fefe.Location = New System.Drawing.Point(344, 272)
        Me.fefe.Name = "fefe"
        Me.fefe.Size = New System.Drawing.Size(104, 24)
        Me.fefe.TabIndex = 62
        Me.fefe.Text = "EFEKTIVITA"
        Me.fefe.UseVisualStyleBackColor = False
        '
        'BtSAV
        '
        Me.BtSAV.Location = New System.Drawing.Point(8, 368)
        Me.BtSAV.Name = "BtSAV"
        Me.BtSAV.Size = New System.Drawing.Size(168, 40)
        Me.BtSAV.TabIndex = 64
        Me.BtSAV.Text = "SAVE PROFILE"
        '
        'BtLOAD
        '
        Me.BtLOAD.Location = New System.Drawing.Point(192, 368)
        Me.BtLOAD.Name = "BtLOAD"
        Me.BtLOAD.Size = New System.Drawing.Size(168, 40)
        Me.BtLOAD.TabIndex = 65
        Me.BtLOAD.Text = "LOAD PROFILE"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmd_Exit.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(384, 368)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Exit.Size = New System.Drawing.Size(168, 40)
        Me.Cmd_Exit.TabIndex = 66
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'fvff
        '
        Me.fvff.BackColor = System.Drawing.SystemColors.ControlText
        Me.fvff.Location = New System.Drawing.Point(448, 296)
        Me.fvff.Name = "fvff"
        Me.fvff.Size = New System.Drawing.Size(104, 24)
        Me.fvff.TabIndex = 68
        Me.fvff.Text = "FORE"
        Me.fvff.UseVisualStyleBackColor = False
        '
        'fv
        '
        Me.fv.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fv.Location = New System.Drawing.Point(344, 296)
        Me.fv.Name = "fv"
        Me.fv.Size = New System.Drawing.Size(104, 24)
        Me.fv.TabIndex = 67
        Me.fv.Text = "VANTAGE"
        Me.fv.UseVisualStyleBackColor = False
        '
        'Frm_Colors
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(560, 414)
        Me.Controls.Add(Me.fvff)
        Me.Controls.Add(Me.fv)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.BtLOAD)
        Me.Controls.Add(Me.BtSAV)
        Me.Controls.Add(Me.fefef)
        Me.Controls.Add(Me.fefe)
        Me.Controls.Add(Me.fruf)
        Me.Controls.Add(Me.fru)
        Me.Controls.Add(Me.fpsf)
        Me.Controls.Add(Me.fps)
        Me.Controls.Add(Me.farf)
        Me.Controls.Add(Me.far)
        Me.Controls.Add(Me.fcrf)
        Me.Controls.Add(Me.fcr)
        Me.Controls.Add(Me.fnof)
        Me.Controls.Add(Me.fno)
        Me.Controls.Add(Me.frf)
        Me.Controls.Add(Me.fr)
        Me.Controls.Add(Me.fslf)
        Me.Controls.Add(Me.fsl)
        Me.Controls.Add(Me.fwf)
        Me.Controls.Add(Me.fw)
        Me.Controls.Add(Me.fspf)
        Me.Controls.Add(Me.fsp)
        Me.Controls.Add(Me.fskf)
        Me.Controls.Add(Me.fsk)
        Me.Controls.Add(Me.fsf)
        Me.Controls.Add(Me.fs)
        Me.Controls.Add(Me.fpef)
        Me.Controls.Add(Me.fpe)
        Me.Controls.Add(Me.fpaf)
        Me.Controls.Add(Me.fpa)
        Me.Controls.Add(Me.fof)
        Me.Controls.Add(Me.fo)
        Me.Controls.Add(Me.fnf)
        Me.Controls.Add(Me.fn)
        Me.Controls.Add(Me.flf)
        Me.Controls.Add(Me.fl)
        Me.Controls.Add(Me.fpf)
        Me.Controls.Add(Me.fp)
        Me.Controls.Add(Me.fitf)
        Me.Controls.Add(Me.fit)
        Me.Controls.Add(Me.fif)
        Me.Controls.Add(Me.fi)
        Me.Controls.Add(Me.fcf)
        Me.Controls.Add(Me.fc)
        Me.Controls.Add(Me.fevf)
        Me.Controls.Add(Me.fev)
        Me.Controls.Add(Me.fef)
        Me.Controls.Add(Me.fe)
        Me.Controls.Add(Me.fbf)
        Me.Controls.Add(Me.fb)
        Me.Controls.Add(Me.faf)
        Me.Controls.Add(Me.fa)
        Me.Controls.Add(Me.cfo)
        Me.Controls.Add(Me.ce)
        Me.Controls.Add(Me.co)
        Me.Controls.Add(Me.cp)
        Me.Controls.Add(Me.cn)
        Me.Controls.Add(Me.cf)
        Me.Controls.Add(Me.cd)
        Me.Controls.Add(Me.ci)
        Me.Controls.Add(Me.mf4)
        Me.Controls.Add(Me.mf3)
        Me.Controls.Add(Me.mf2)
        Me.Controls.Add(Me.mb2)
        Me.Controls.Add(Me.mf)
        Me.Controls.Add(Me.mb)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Frm_Colors"
        Me.Text = "GC_AVATAR Color adjustment"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub ColSel()
        ColorDialog1.ShowDialog()
        ColVal = ColorDialog1.Color.ToArgb
    End Sub

    Private Sub mb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mb.Click
        ColVal = mb.BackColor.ToArgb
        ColSel()
        If ColVal <> mb.BackColor.ToArgb Then
            CChang = 1
            mb.BackColor = Color.FromArgb(ColVal)
            BtSAV.BackColor = Color.FromArgb(ColVal)
            BtLOAD.BackColor = Color.FromArgb(ColVal)
            Me.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            MB1 = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub mb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mb2.Click
        ColVal = mb2.BackColor.ToArgb
        ColSel()
        If ColVal <> mb2.BackColor.ToArgb Then
            CChang = 1
            mb2.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            MB22 = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub mf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mf.Click
        ColVal = mf.BackColor.ToArgb
        ColSel()
        If ColVal <> mf.BackColor.ToArgb Then
            CChang = 1
            mf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            MF1 = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub mf2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mf2.Click
        ColVal = mf2.BackColor.ToArgb
        ColSel()
        If ColVal <> mf2.BackColor.ToArgb Then
            CChang = 1
            mf2.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            MF22 = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub mf3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mf3.Click
        ColVal = mf3.BackColor.ToArgb
        ColSel()
        If ColVal <> mf3.BackColor.ToArgb Then
            CChang = 1
            mf3.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            MF33 = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub mf4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mf4.Click
        ColVal = mf4.BackColor.ToArgb
        ColSel()
        If ColVal <> mf4.BackColor.ToArgb Then
            CChang = 1
            mf4.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            MF44 = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub ci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ci.Click
        ColVal = ci.BackColor.ToArgb
        ColSel()
        If ColVal <> ci.BackColor.ToArgb Then
            CChang = 1
            ci.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            COI = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub cd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cd.Click
        ColVal = cd.BackColor.ToArgb
        ColSel()
        If ColVal <> cd.BackColor.ToArgb Then
            CChang = 1
            cd.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            COD = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub cf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cf.Click
        ColVal = cf.BackColor.ToArgb
        ColSel()
        If ColVal <> cf.BackColor.ToArgb Then
            CChang = 1
            cf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            COF = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub cn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cn.Click
        ColVal = cn.BackColor.ToArgb
        ColSel()
        If ColVal <> cn.BackColor.ToArgb Then
            CChang = 1
            cn.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            CON = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub cp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cp.Click
        ColVal = cp.BackColor.ToArgb
        ColSel()
        If ColVal <> cp.BackColor.ToArgb Then
            CChang = 1
            cp.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            COP = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub co_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles co.Click
        ColVal = co.BackColor.ToArgb
        ColSel()
        If ColVal <> co.BackColor.ToArgb Then
            CChang = 1
            co.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            COO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub ce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ce.Click
        ColVal = ce.BackColor.ToArgb
        ColSel()
        If ColVal <> ce.BackColor.ToArgb Then
            CChang = 1
            ce.BackColor = Color.FromArgb(ColVal)
            Cmd_Exit.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            COE = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub cfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cfo.Click
        ColVal = cfo.BackColor.ToArgb
        ColSel()
        If ColVal <> cfo.BackColor.ToArgb Then
            CChang = 1
            cfo.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            COFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fa.Click
        ColVal = fa.BackColor.ToArgb
        ColSel()
        If ColVal <> fa.BackColor.ToArgb Then
            CChang = 1
            fa.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FAB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub faf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles faf.Click
        ColVal = faf.BackColor.ToArgb
        ColSel()
        If ColVal <> faf.BackColor.ToArgb Then
            CChang = 1
            faf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FAFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fb.Click
        ColVal = fb.BackColor.ToArgb
        ColSel()
        If ColVal <> fb.BackColor.ToArgb Then
            CChang = 1
            fb.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FBB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fbf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fbf.Click
        ColVal = fbf.BackColor.ToArgb
        ColSel()
        If ColVal <> fbf.BackColor.ToArgb Then
            CChang = 1
            fbf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FBFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fe.Click
        ColVal = fe.BackColor.ToArgb
        ColSel()
        If ColVal <> fe.BackColor.ToArgb Then
            CChang = 1
            fe.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FEB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fef.Click
        ColVal = fef.BackColor.ToArgb
        ColSel()
        If ColVal <> fef.BackColor.ToArgb Then
            CChang = 1
            fef.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FEFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fev.Click
        ColVal = fev.BackColor.ToArgb
        ColSel()
        If ColVal <> fev.BackColor.ToArgb Then
            CChang = 1
            fev.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FVB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fevf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fevf.Click
        ColVal = fevf.BackColor.ToArgb
        ColSel()
        If ColVal <> fevf.BackColor.ToArgb Then
            CChang = 1
            fevf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FVF = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fc.Click
        ColVal = fc.BackColor.ToArgb
        ColSel()
        If ColVal <> fc.BackColor.ToArgb Then
            CChang = 1
            fc.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FCHB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fcf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fcf.Click
        ColVal = fcf.BackColor.ToArgb
        ColSel()
        If ColVal <> fcf.BackColor.ToArgb Then
            CChang = 1
            fcf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FCHF = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fi.Click
        ColVal = fi.BackColor.ToArgb
        ColSel()
        If ColVal <> fi.BackColor.ToArgb Then
            CChang = 1
            fi.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FIB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fif.Click
        ColVal = fif.BackColor.ToArgb
        ColSel()
        If ColVal <> fif.BackColor.ToArgb Then
            CChang = 1
            fif.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FIFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fit.Click
        ColVal = fit.BackColor.ToArgb
        ColSel()
        If ColVal <> fit.BackColor.ToArgb Then
            CChang = 1
            fit.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FTB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fitf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fitf.Click
        ColVal = fitf.BackColor.ToArgb
        ColSel()
        If ColVal <> fitf.BackColor.ToArgb Then
            CChang = 1
            fitf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FTF = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fp.Click
        ColVal = fp.BackColor.ToArgb
        ColSel()
        If ColVal <> fp.BackColor.ToArgb Then
            CChang = 1
            fp.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FCEB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fpf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fpf.Click
        ColVal = fpf.BackColor.ToArgb
        ColSel()
        If ColVal <> fpf.BackColor.ToArgb Then
            CChang = 1
            fpf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FCEF = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fl.Click
        ColVal = fl.BackColor.ToArgb
        ColSel()
        If ColVal <> fl.BackColor.ToArgb Then
            CChang = 1
            fl.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FLB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub flf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flf.Click
        ColVal = flf.BackColor.ToArgb
        ColSel()
        If ColVal <> flf.BackColor.ToArgb Then
            CChang = 1
            flf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FLFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fn.Click
        ColVal = fn.BackColor.ToArgb
        ColSel()
        If ColVal <> fn.BackColor.ToArgb Then
            CChang = 1
            fn.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FNB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fnf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fnf.Click
        ColVal = fnf.BackColor.ToArgb
        ColSel()
        If ColVal <> fnf.BackColor.ToArgb Then
            CChang = 1
            fnf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FNFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fo.Click
        ColVal = fo.BackColor.ToArgb
        ColSel()
        If ColVal <> fo.BackColor.ToArgb Then
            CChang = 1
            fo.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FOB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fof_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fof.Click
        ColVal = fof.BackColor.ToArgb
        ColSel()
        If ColVal <> fof.BackColor.ToArgb Then
            CChang = 1
            fof.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FOFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fpa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fpa.Click
        ColVal = fpa.BackColor.ToArgb
        ColSel()
        If ColVal <> fpa.BackColor.ToArgb Then
            CChang = 1
            fpa.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FPAB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fpaf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fpaf.Click
        ColVal = fpaf.BackColor.ToArgb
        ColSel()
        If ColVal <> fpaf.BackColor.ToArgb Then
            CChang = 1
            fpaf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FPAFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fpe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fpe.Click
        ColVal = fpe.BackColor.ToArgb
        ColSel()
        If ColVal <> fpe.BackColor.ToArgb Then
            CChang = 1
            fpe.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FPEB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fpef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fpef.Click
        ColVal = fpef.BackColor.ToArgb
        ColSel()
        If ColVal <> fpef.BackColor.ToArgb Then
            CChang = 1
            fpef.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FPEFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fs.Click
        ColVal = fs.BackColor.ToArgb
        ColSel()
        If ColVal <> fs.BackColor.ToArgb Then
            CChang = 1
            fs.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FMB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fsf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fsf.Click
        ColVal = fsf.BackColor.ToArgb
        ColSel()
        If ColVal <> fsf.BackColor.ToArgb Then
            CChang = 1
            fsf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FMFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fsk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fsk.Click
        ColVal = fsk.BackColor.ToArgb
        ColSel()
        If ColVal <> fsk.BackColor.ToArgb Then
            CChang = 1
            fsk.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FSKB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fskf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fskf.Click
        ColVal = fskf.BackColor.ToArgb
        ColSel()
        If ColVal <> fskf.BackColor.ToArgb Then
            CChang = 1
            fskf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FSKFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fsp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fsp.Click
        ColVal = fsp.BackColor.ToArgb
        ColSel()
        If ColVal <> fsp.BackColor.ToArgb Then
            CChang = 1
            fsp.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FSPB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fspf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fspf.Click
        ColVal = fspf.BackColor.ToArgb
        ColSel()
        If ColVal <> fspf.BackColor.ToArgb Then
            CChang = 1
            fspf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FSPFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fw.Click
        ColVal = fw.BackColor.ToArgb
        ColSel()
        If ColVal <> fw.BackColor.ToArgb Then
            CChang = 1
            fw.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FWB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fwf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwf.Click
        ColVal = fwf.BackColor.ToArgb
        ColSel()
        If ColVal <> fwf.BackColor.ToArgb Then
            CChang = 1
            fwf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FWFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fsl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fsl.Click
        ColVal = fsl.BackColor.ToArgb
        ColSel()
        If ColVal <> fsl.BackColor.ToArgb Then
            CChang = 1
            fsl.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FWOB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fslf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fslf.Click
        ColVal = fslf.BackColor.ToArgb
        ColSel()
        If ColVal <> fslf.BackColor.ToArgb Then
            CChang = 1
            fslf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FWOFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fr.Click
        ColVal = fr.BackColor.ToArgb
        ColSel()
        If ColVal <> fr.BackColor.ToArgb Then
            CChang = 1
            fr.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FRB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub frf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frf.Click
        ColVal = frf.BackColor.ToArgb
        ColSel()
        If ColVal <> frf.BackColor.ToArgb Then
            CChang = 1
            frf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FRFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fno.Click
        ColVal = fno.BackColor.ToArgb
        ColSel()
        If ColVal <> fno.BackColor.ToArgb Then
            CChang = 1
            fno.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FNOB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fnof_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fnof.Click
        ColVal = fnof.BackColor.ToArgb
        ColSel()
        If ColVal <> fnof.BackColor.ToArgb Then
            CChang = 1
            fnof.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FNOFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fcr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fcr.Click
        ColVal = fcr.BackColor.ToArgb
        ColSel()
        If ColVal <> fcr.BackColor.ToArgb Then
            CChang = 1
            fcr.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FCRB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fcrf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fcrf.Click
        ColVal = fcrf.BackColor.ToArgb
        ColSel()
        If ColVal <> fcrf.BackColor.ToArgb Then
            CChang = 1
            fcrf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FCRFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub far_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles far.Click
        ColVal = far.BackColor.ToArgb
        ColSel()
        If ColVal <> far.BackColor.ToArgb Then
            CChang = 1
            far.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FUB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub farf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles farf.Click
        ColVal = farf.BackColor.ToArgb
        ColSel()
        If ColVal <> farf.BackColor.ToArgb Then
            CChang = 1
            farf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FUF = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fps.Click
        ColVal = fps.BackColor.ToArgb
        ColSel()
        If ColVal <> fps.BackColor.ToArgb Then
            CChang = 1
            fps.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FPSB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fpsf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fpsf.Click
        ColVal = fpsf.BackColor.ToArgb
        ColSel()
        If ColVal <> fpsf.BackColor.ToArgb Then
            CChang = 1
            fpsf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FPSFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fru.Click
        ColVal = fru.BackColor.ToArgb
        ColSel()
        If ColVal <> fru.BackColor.ToArgb Then
            CChang = 1
            fru.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FRUB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fruf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fruf.Click
        ColVal = fruf.BackColor.ToArgb
        ColSel()
        If ColVal <> fruf.BackColor.ToArgb Then
            CChang = 1
            fruf.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FRUFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fefe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fefe.Click
        ColVal = fefe.BackColor.ToArgb
        ColSel()
        If ColVal <> fefe.BackColor.ToArgb Then
            CChang = 1
            fefe.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FEFB = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fefef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fefef.Click
        ColVal = fefef.BackColor.ToArgb
        ColSel()
        If ColVal <> fefef.BackColor.ToArgb Then
            CChang = 1
            fefef.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FEFFO = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub BtLOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtLOAD.Click
        OpenFileDialog1.Filter = ("Profily|*.pro")
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            ProFILE = OpenFileDialog1.FileName
            GC_ReadProfile()
            Color_Apply()
        End If
    End Sub

    Private Sub Color_Apply()
        mb.BackColor = Color.FromArgb(MB1)
        BtSAV.BackColor = Color.FromArgb(MB1)
        BtLOAD.BackColor = Color.FromArgb(MB1)
        Me.BackColor = Color.FromArgb(MB1)
        mb2.BackColor = Color.FromArgb(MB22)
        mf.BackColor = Color.FromArgb(MF1)
        mf2.BackColor = Color.FromArgb(MF22)
        mf3.BackColor = Color.FromArgb(MF33)
        mf4.BackColor = Color.FromArgb(MF44)
        ci.BackColor = Color.FromArgb(COI)
        cd.BackColor = Color.FromArgb(COD)
        cf.BackColor = Color.FromArgb(COF)
        cn.BackColor = Color.FromArgb(CON)
        cp.BackColor = Color.FromArgb(COP)
        co.BackColor = Color.FromArgb(COO)
        ce.BackColor = Color.FromArgb(COE)
        Cmd_Exit.BackColor = Color.FromArgb(COE)
        cfo.BackColor = Color.FromArgb(COFO)
        fa.BackColor = Color.FromArgb(FAB)
        faf.BackColor = Color.FromArgb(FAFO)
        fb.BackColor = Color.FromArgb(FBB)
        fbf.BackColor = Color.FromArgb(FBFO)
        fe.BackColor = Color.FromArgb(FEB)
        fef.BackColor = Color.FromArgb(FEFO)
        fev.BackColor = Color.FromArgb(FVB)
        fevf.BackColor = Color.FromArgb(FVF)
        fc.BackColor = Color.FromArgb(FCHB)
        fcf.BackColor = Color.FromArgb(FCHF)
        fi.BackColor = Color.FromArgb(FIB)
        fif.BackColor = Color.FromArgb(FIFO)
        fit.BackColor = Color.FromArgb(FTB)
        fitf.BackColor = Color.FromArgb(FTF)
        fp.BackColor = Color.FromArgb(FCEB)
        fpf.BackColor = Color.FromArgb(FCEF)
        fl.BackColor = Color.FromArgb(FLB)
        flf.BackColor = Color.FromArgb(FLFO)
        fn.BackColor = Color.FromArgb(FNB)
        fnf.BackColor = Color.FromArgb(FNFO)
        fo.BackColor = Color.FromArgb(FOB)
        fof.BackColor = Color.FromArgb(FOFO)
        fpa.BackColor = Color.FromArgb(FPAB)
        fpaf.BackColor = Color.FromArgb(FPAFO)
        fpe.BackColor = Color.FromArgb(FPEB)
        fpef.BackColor = Color.FromArgb(FPEFO)
        fs.BackColor = Color.FromArgb(FMB)
        fsf.BackColor = Color.FromArgb(FMFO)
        fsk.BackColor = Color.FromArgb(FSKB)
        fskf.BackColor = Color.FromArgb(FSKFO)
        fsp.BackColor = Color.FromArgb(FSPB)
        fspf.BackColor = Color.FromArgb(FSPFO)
        fw.BackColor = Color.FromArgb(FWB)
        fwf.BackColor = Color.FromArgb(FWFO)
        fsl.BackColor = Color.FromArgb(FWOB)
        fslf.BackColor = Color.FromArgb(FWOFO)
        fr.BackColor = Color.FromArgb(FRB)
        frf.BackColor = Color.FromArgb(FRFO)
        fno.BackColor = Color.FromArgb(FNOB)
        fnof.BackColor = Color.FromArgb(FNOFO)
        fcr.BackColor = Color.FromArgb(FCRB)
        fcrf.BackColor = Color.FromArgb(FCRFO)
        far.BackColor = Color.FromArgb(FUB)
        farf.BackColor = Color.FromArgb(FUF)
        fps.BackColor = Color.FromArgb(FPSB)
        fpsf.BackColor = Color.FromArgb(FPSFO)
        fru.BackColor = Color.FromArgb(FRUB)
        fruf.BackColor = Color.FromArgb(FRUFO)
        fef.BackColor = Color.FromArgb(FEFB)
        fefef.BackColor = Color.FromArgb(FEFFO)
        fv.BackColor = Color.FromArgb(FVV)
        fvff.BackColor = Color.FromArgb(FVVF)
        Me.Refresh()
    End Sub

    Private Sub BtSAV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSAV.Click
        Dim Veta As String
        Veta = MB1 & "|" & MB22 & "|" & MF1 & "|" & MF22 & "|" & MF33 & "|" & MF44 & "|" & COI & "|" & COF & "|" & COD & "|" & CON & "|" & COP & "|" & COO & "|" & COE & "|" & COFO & "|" & FAB & "|" & FAFO & "|" & FBB & "|" & FBFO & "|" & FEB & "|" & FEFO & "|" & FVB & "|" & fvf & "|" & FCHB & "|" & FCHF & "|" & FIB & "|" & FIFO & "|" & FTB & "|" & FTF & "|" & FCEB & "|" & FCEF & "|" & FLB & "|" & FLFO & "|" & FNB & "|" & FNFO & "|" & FOB & "|" & FOFO & "|" & FPAB & "|" & FPAFO & "|" & FPEB & "|" & FPEFO & "|" & FMB & "|" & FMFO & "|" & FSKB & "|" & FSKFO & "|" & FSPB & "|" & FSPFO & "|" & FWB & "|" & FWFO & "|" & FWOB & "|" & FWOFO & "|" & FRB & "|" & FRFO & "|" & FNOB & "|" & FNOFO & "|" & FCRB & "|" & FCRFO & "|" & FUB & "|" & FUF & "|" & FPSB & "|" & FPSFO & "|" & FRUB & "|" & FRUFO & "|" & FEFB & "|" & FEFFO & "|" & FVV & "|" & FVVF & "|"
        SaveFileDialog1.Filter = "Profily|*.pro"
        SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.FileName <> "" Then
            FileOpen(2, SaveFileDialog1.FileName, OpenMode.Output)
            PrintLine(2, Veta)
            SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Profily", "Aktuální", SaveFileDialog1.FileName)
            FileClose(2)
        End If
    End Sub

    Private Sub Frm_Colors_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'defi()
        If ProFILE <> "" Then
            Color_Apply()
        End If
    End Sub

    Sub defi()
        MB1 = mb.BackColor.ToArgb
        MB22 = mb2.BackColor.ToArgb
        MF1 = mf.BackColor.ToArgb
        MF22 = mf2.BackColor.ToArgb
        MF33 = mf3.BackColor.ToArgb
        MF44 = mf4.BackColor.ToArgb
        COI = ci.BackColor.ToArgb
        COD = cd.BackColor.ToArgb
        COF = cf.BackColor.ToArgb
        CON = cn.BackColor.ToArgb
        COP = cp.BackColor.ToArgb
        COO = co.BackColor.ToArgb
        COE = ce.BackColor.ToArgb
        COFO = cfo.BackColor.ToArgb
        FAB = fa.BackColor.ToArgb
        FAFO = faf.BackColor.ToArgb
        FBB = fb.BackColor.ToArgb
        FBFO = fbf.BackColor.ToArgb
        FEB = fe.BackColor.ToArgb
        FEFO = fef.BackColor.ToArgb
        FVB = fev.BackColor.ToArgb
        FVF = fevf.BackColor.ToArgb
        FCHB = fc.BackColor.ToArgb
        FCHF = fcf.BackColor.ToArgb
        FIB = fi.BackColor.ToArgb
        FIFO = fif.BackColor.ToArgb
        FTB = fit.BackColor.ToArgb
        FTF = fitf.BackColor.ToArgb
        FCEB = fp.BackColor.ToArgb
        FCEF = fpf.BackColor.ToArgb
        FLB = fl.BackColor.ToArgb
        FLFO = flf.BackColor.ToArgb
        FNB = fn.BackColor.ToArgb
        FNFO = fnf.BackColor.ToArgb
        FOB = fo.BackColor.ToArgb
        FOFO = fof.BackColor.ToArgb
        FPAB = fpa.BackColor.ToArgb
        FPAFO = fpaf.BackColor.ToArgb
        FPEB = fpe.BackColor.ToArgb
        FPEFO = fpef.BackColor.ToArgb
        FMB = fs.BackColor.ToArgb
        FMFO = fsf.BackColor.ToArgb
        FSKB = fsk.BackColor.ToArgb
        FSKFO = fskf.BackColor.ToArgb
        FSPB = fsp.BackColor.ToArgb
        FSPFO = fspf.BackColor.ToArgb
        FWB = fw.BackColor.ToArgb
        FWFO = fwf.BackColor.ToArgb
        FWOB = fsl.BackColor.ToArgb
        FWOFO = fslf.BackColor.ToArgb
        FRB = fr.BackColor.ToArgb
        FRFO = frf.BackColor.ToArgb
        FNOB = fno.BackColor.ToArgb
        FNOFO = fnof.BackColor.ToArgb
        FCRB = fcr.BackColor.ToArgb
        FCRFO = fcrf.BackColor.ToArgb
        FUB = far.BackColor.ToArgb
        FUF = farf.BackColor.ToArgb
        FPSB = fps.BackColor.ToArgb
        FPSFO = fpsf.BackColor.ToArgb
        FRUB = fru.BackColor.ToArgb
        FRUFO = fruf.BackColor.ToArgb
        FEFB = fef.BackColor.ToArgb
        FEFFO = fefef.BackColor.ToArgb
        FVV = fv.BackColor.ToArgb
        FVVF = fvff.BackColor.ToArgb
    End Sub

    Private Sub fv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fv.Click
        ColVal = fv.BackColor.ToArgb
        ColSel()
        If ColVal <> fv.BackColor.ToArgb Then
            CChang = 1
            fv.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FVV = ColVal
        Else
            ColVal = ""
        End If
    End Sub

    Private Sub fvff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fvff.Click
        ColVal = fvff.BackColor.ToArgb
        ColSel()
        If ColVal <> fvff.BackColor.ToArgb Then
            CChang = 1
            fvff.BackColor = Color.FromArgb(ColVal)
            Me.Refresh()
            FVVF = ColVal
        Else
            ColVal = ""
        End If
    End Sub
End Class
