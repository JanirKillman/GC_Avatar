Option Strict Off
Option Explicit On
Friend Class Frm_Pass
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
	Public WithEvents Txt_Pass As System.Windows.Forms.TextBox
	Public WithEvents Lbl_Pass As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Pass))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Txt_Pass = New System.Windows.Forms.TextBox
        Me.Lbl_Pass = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Txt_Pass
        '
        Me.Txt_Pass.AcceptsReturn = True
        Me.Txt_Pass.AutoSize = False
        Me.Txt_Pass.BackColor = System.Drawing.Color.Red
        Me.Txt_Pass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Pass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Txt_Pass.ForeColor = System.Drawing.Color.Green
        Me.Txt_Pass.Location = New System.Drawing.Point(56, 24)
        Me.Txt_Pass.MaxLength = 0
        Me.Txt_Pass.Name = "Txt_Pass"
        Me.Txt_Pass.PasswordChar = Microsoft.VisualBasic.ChrW(35)
        Me.Txt_Pass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Pass.Size = New System.Drawing.Size(233, 25)
        Me.Txt_Pass.TabIndex = 0
        Me.Txt_Pass.Text = ""
        '
        'Lbl_Pass
        '
        Me.Lbl_Pass.BackColor = System.Drawing.Color.Red
        Me.Lbl_Pass.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lbl_Pass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lbl_Pass.ForeColor = System.Drawing.Color.Green
        Me.Lbl_Pass.Location = New System.Drawing.Point(8, 24)
        Me.Lbl_Pass.Name = "Lbl_Pass"
        Me.Lbl_Pass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lbl_Pass.Size = New System.Drawing.Size(49, 25)
        Me.Lbl_Pass.TabIndex = 1
        Me.Lbl_Pass.Text = "Heslo:"
        '
        'Frm_Pass
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(297, 71)
        Me.Controls.Add(Me.Txt_Pass)
        Me.Controls.Add(Me.Lbl_Pass)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Pass"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "GC SECURITY"
        Me.ResumeLayout(False)

    End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As Frm_Pass
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As Frm_Pass
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New Frm_Pass()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	Private x As Short
	
	
	Private Sub Frm_Pass_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		x = 0
	End Sub
	
	Private Sub Txt_Pass_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Pass.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		
		If KeyAscii = System.Windows.Forms.Keys.Return Then
			KeyAscii = 0
			If Txt_Pass.Text = "omnipotence" Then
                Me.Close()
			Else
				x = x + 1
				If x = 3 Then
                    MsgBox("Očividně neznáte heslo, přístup k programu zamítnut.", MsgBoxStyle.Exclamation, "Kickass")
					End
				Else
					Txt_Pass.Text = ""
				End If
			End If
		End If
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
End Class