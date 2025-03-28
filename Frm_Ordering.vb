Option Strict Off
Option Explicit On
Friend Class Frm_Ordering
	Inherits System.Windows.Forms.Form
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
	Public WithEvents CHck_ses As System.Windows.Forms.CheckBox
	Public WithEvents CHck_vze As System.Windows.Forms.CheckBox
	Public WithEvents Opt_type As System.Windows.Forms.RadioButton
	Public WithEvents Opt_date As System.Windows.Forms.RadioButton
	Public WithEvents Opt_name As System.Windows.Forms.RadioButton
	Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Ordering))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CHck_ses = New System.Windows.Forms.CheckBox
        Me.CHck_vze = New System.Windows.Forms.CheckBox
        Me.Opt_type = New System.Windows.Forms.RadioButton
        Me.Opt_date = New System.Windows.Forms.RadioButton
        Me.Opt_name = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'CHck_ses
        '
        Me.CHck_ses.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CHck_ses.Checked = True
        Me.CHck_ses.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHck_ses.Cursor = System.Windows.Forms.Cursors.Default
        Me.CHck_ses.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CHck_ses.ForeColor = System.Drawing.Color.Black
        Me.CHck_ses.Location = New System.Drawing.Point(152, 120)
        Me.CHck_ses.Name = "CHck_ses"
        Me.CHck_ses.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CHck_ses.Size = New System.Drawing.Size(97, 25)
        Me.CHck_ses.TabIndex = 6
        Me.CHck_ses.Text = "Sestupně"
        Me.CHck_ses.UseVisualStyleBackColor = False
        '
        'CHck_vze
        '
        Me.CHck_vze.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CHck_vze.Checked = True
        Me.CHck_vze.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHck_vze.Cursor = System.Windows.Forms.Cursors.Default
        Me.CHck_vze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CHck_vze.ForeColor = System.Drawing.Color.Black
        Me.CHck_vze.Location = New System.Drawing.Point(152, 80)
        Me.CHck_vze.Name = "CHck_vze"
        Me.CHck_vze.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CHck_vze.Size = New System.Drawing.Size(97, 25)
        Me.CHck_vze.TabIndex = 5
        Me.CHck_vze.Text = "Vzestupně"
        Me.CHck_vze.UseVisualStyleBackColor = False
        '
        'Opt_type
        '
        Me.Opt_type.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Opt_type.Checked = True
        Me.Opt_type.Cursor = System.Windows.Forms.Cursors.Default
        Me.Opt_type.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Opt_type.ForeColor = System.Drawing.Color.Black
        Me.Opt_type.Location = New System.Drawing.Point(16, 128)
        Me.Opt_type.Name = "Opt_type"
        Me.Opt_type.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Opt_type.Size = New System.Drawing.Size(113, 25)
        Me.Opt_type.TabIndex = 3
        Me.Opt_type.TabStop = True
        Me.Opt_type.Text = "Ceny"
        Me.Opt_type.UseVisualStyleBackColor = False
        '
        'Opt_date
        '
        Me.Opt_date.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Opt_date.Checked = True
        Me.Opt_date.Cursor = System.Windows.Forms.Cursors.Default
        Me.Opt_date.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Opt_date.ForeColor = System.Drawing.Color.Black
        Me.Opt_date.Location = New System.Drawing.Point(16, 96)
        Me.Opt_date.Name = "Opt_date"
        Me.Opt_date.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Opt_date.Size = New System.Drawing.Size(137, 25)
        Me.Opt_date.TabIndex = 2
        Me.Opt_date.TabStop = True
        Me.Opt_date.Text = "Typu"
        Me.Opt_date.UseVisualStyleBackColor = False
        '
        'Opt_name
        '
        Me.Opt_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Opt_name.Checked = True
        Me.Opt_name.Cursor = System.Windows.Forms.Cursors.Default
        Me.Opt_name.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Opt_name.ForeColor = System.Drawing.Color.Black
        Me.Opt_name.Location = New System.Drawing.Point(16, 64)
        Me.Opt_name.Name = "Opt_name"
        Me.Opt_name.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Opt_name.Size = New System.Drawing.Size(129, 25)
        Me.Opt_name.TabIndex = 1
        Me.Opt_name.TabStop = True
        Me.Opt_name.Text = "Vantage"
        Me.Opt_name.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(152, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(57, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Směr:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(105, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Řadit podle:"
        '
        'Frm_Ordering
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(263, 182)
        Me.Controls.Add(Me.CHck_ses)
        Me.Controls.Add(Me.CHck_vze)
        Me.Controls.Add(Me.Opt_type)
        Me.Controls.Add(Me.Opt_date)
        Me.Controls.Add(Me.Opt_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.Name = "Frm_Ordering"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "řazení"
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Frm_Ordering
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Frm_Ordering
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Frm_Ordering
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As Frm_Ordering)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region

    Private Sub Frm_Ordering_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
        OrderControl = ""
    End Sub

    Private Sub CHck_ses_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CHck_ses.CheckStateChanged
        If CHck_ses.CheckState = 1 Then
            Select Case OrderControl
                Case Is = "SP"
                    SPdirect = 2
                Case Is = "BE"
                    BEdirect = 2
                Case Is = "NA"
                    NAdirect = 2
                Case Is = "SK"
                    SKdirect = 2
                Case Is = "IT"
                    ITdirect = 2
                Case Is = "OG"
                    OGdirect = 2
                Case Is = "AR"
                    ARdirect = 2
                Case Is = "WE"
                    WEdirect = 2
                Case Is = "CH"
                    CHdirect = 2
                Case Is = "EV"
                    EVdirect = 2
                Case Is = "PE"
                    PEdirect = 2
                Case Is = "SI"
                    SIdirect = 2
                Case Is = "IO"
                    IOdirect = 2
                Case Is = "WO"
                    WOdirect = 2
                Case Is = "LA"
                    LAdirect = 2
                Case Is = "PR"
                    PRdirect = 2
                Case Is = "RA"
                    RAdirect = 2
                Case Is = "NO"
                    NOdirect = 2
                Case Is = "RU"
                    RUdirect = 2
                Case Is = "CR"
                    CRdirect = 2
                Case Is = "PS"
                    PSdirect = 2
                Case Is = "AT"
                    ATdirect = 2
                Case Is = "VA"
                    VAdirect = 2
            End Select
            CHck_vze.CheckState = System.Windows.Forms.CheckState.Unchecked
            Me.Refresh()
        Else
            If CHck_vze.CheckState = 0 Then
                CHck_ses.CheckState = System.Windows.Forms.CheckState.Checked
            End If
        End If

    End Sub

    Private Sub CHck_vze_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CHck_vze.CheckStateChanged
        If CHck_vze.CheckState = 1 Then
            Select Case OrderControl
                Case Is = "SP"
                    SPdirect = 1
                Case Is = "BE"
                    BEdirect = 1
                Case Is = "NA"
                    NAdirect = 1
                Case Is = "SK"
                    SKdirect = 1
                Case Is = "IT"
                    ITdirect = 1
                Case Is = "OG"
                    OGdirect = 1
                Case Is = "AR"
                    ARdirect = 1
                Case Is = "WE"
                    WEdirect = 1
                Case Is = "CH"
                    CHdirect = 1
                Case Is = "EV"
                    EVdirect = 1
                Case Is = "PE"
                    PEdirect = 1
                Case Is = "SI"
                    SIdirect = 1
                Case Is = "IO"
                    IOdirect = 1
                Case Is = "WO"
                    WOdirect = 1
                Case Is = "LA"
                    LAdirect = 1
                Case Is = "PR"
                    PRdirect = 1
                Case Is = "RA"
                    RAdirect = 1
                Case Is = "NO"
                    NOdirect = 1
                Case Is = "RU"
                    RUdirect = 1
                Case Is = "CR"
                    CRdirect = 1
                Case Is = "PS"
                    PSdirect = 1
                Case Is = "AT"
                    ATdirect = 1
                Case Is = "VA"
                    VAdirect = 1
            End Select
            CHck_ses.CheckState = System.Windows.Forms.CheckState.Unchecked
            Me.Refresh()
        Else
            If CHck_ses.CheckState = 0 Then
                CHck_vze.CheckState = System.Windows.Forms.CheckState.Checked
            End If
        End If
    End Sub

    Private Sub Opt_date_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Opt_date.CheckedChanged
        If eventSender.Checked Then
            Select Case OrderControl
                Case Is = "SP"
                    SPorder = 2
                Case Is = "BE"
                    BEorder = 2
                Case Is = "NA"
                    NAorder = 2
                Case Is = "SK"
                    SKorder = 2
                Case Is = "IT"
                    ITorder = 2
                Case Is = "OG"
                    OGorder = 2
                Case Is = "AR"
                    ARorder = 2
                Case Is = "WE"
                    WEorder = 2
                Case Is = "CH"
                    CHorder = 2
                Case Is = "EV"
                    EVorder = 2
                Case Is = "PE"
                    PEorder = 2
                Case Is = "SI"
                    SIorder = 2
                Case Is = "IO"
                    IOorder = 2
                Case Is = "WO"
                    WOorder = 2
                Case Is = "LA"
                    LAorder = 2
                Case Is = "PR"
                    PRorder = 2
                Case Is = "RA"
                    RAorder = 2
                Case Is = "NO"
                    NOorder = 2
                Case Is = "RU"
                    RUorder = 2
                Case Is = "CR"
                    CRorder = 2
                Case Is = "PS"
                    PSorder = 2
                Case Is = "AT"
                    ATorder = 2
                Case Is = "VA"
                    VAorder = 2
            End Select
        End If
    End Sub

    Private Sub Opt_name_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Opt_name.CheckedChanged
        If eventSender.Checked Then
            Select Case OrderControl
                Case Is = "SP"
                    SPorder = 1
                Case Is = "BE"
                    BEorder = 1
                Case Is = "NA"
                    NAorder = 1
                Case Is = "SK"
                    SKorder = 1
                Case Is = "IT"
                    ITorder = 1
                Case Is = "OG"
                    OGorder = 1
                Case Is = "AR"
                    ARorder = 1
                Case Is = "WE"
                    WEorder = 1
                Case Is = "CH"
                    CHorder = 1
                Case Is = "EV"
                    EVorder = 1
                Case Is = "PE"
                    PEorder = 1
                Case Is = "SI"
                    SIorder = 1
                Case Is = "IO"
                    IOorder = 1
                Case Is = "WO"
                    WOorder = 1
                Case Is = "LA"
                    LAorder = 1
                Case Is = "PR"
                    PRorder = 1
                Case Is = "RA"
                    RAorder = 1
                Case Is = "NO"
                    NOorder = 1
                Case Is = "RU"
                    RUorder = 1
                Case Is = "CR"
                    CRorder = 1
                Case Is = "PS"
                    PSorder = 1
                Case Is = "AT"
                    ATorder = 1
                Case Is = "VA"
                    VAorder = 1
            End Select
        End If
    End Sub

    Private Sub Opt_type_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Opt_type.CheckedChanged
        If eventSender.Checked Then
            Select Case OrderControl
                Case Is = "SP"
                    SPorder = 3
                Case Is = "BE"
                    BEorder = 3
                Case Is = "NA"
                    NAorder = 3
                Case Is = "SK"
                    SKorder = 3
                Case Is = "IT"
                    ITorder = 3
                Case Is = "OG"
                    OGorder = 3
                Case Is = "AR"
                    ARorder = 3
                Case Is = "WE"
                    WEorder = 3
                Case Is = "CH"
                    CHorder = 3
                Case Is = "EV"
                    EVorder = 3
                Case Is = "PE"
                    PEorder = 3
                Case Is = "SI"
                    SIorder = 3
                Case Is = "WO"
                    WOorder = 3
                Case Is = "PR"
                    PRorder = 3
                Case Is = "RA"
                    RAorder = 3
                Case Is = "CR"
                    CRorder = 3
                Case Is = "PS"
                    PSorder = 3
                Case Is = "AT"
                    ATorder = 3
                Case Is = "VA"
                    VAorder = 3
            End Select
        End If
    End Sub
End Class