Option Strict Off
Option Explicit On
Imports System.Data.OleDb
Friend Class Frm_SPCHoose
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
	Public WithEvents Lst_AllS As System.Windows.Forms.ListBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_SPCHoose))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Lst_AllS = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'Lst_AllS
        '
        Me.Lst_AllS.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Lst_AllS.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lst_AllS.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lst_AllS.ForeColor = System.Drawing.Color.Yellow
        Me.Lst_AllS.ItemHeight = 14
        Me.Lst_AllS.Location = New System.Drawing.Point(0, 0)
        Me.Lst_AllS.Name = "Lst_AllS"
        Me.Lst_AllS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lst_AllS.Size = New System.Drawing.Size(209, 410)
        Me.Lst_AllS.TabIndex = 0
        '
        'Frm_SPCHoose
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.ClientSize = New System.Drawing.Size(207, 421)
        Me.Controls.Add(Me.Lst_AllS)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.MaximizeBox = False
        Me.Name = "Frm_SPCHoose"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Vyber Kouzlo"
        Me.ResumeLayout(False)

    End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As Frm_SPCHoose
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As Frm_SPCHoose
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New Frm_SPCHoose()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
    Private pomrc As New OleDbCommand
    Private pomda As New OleDbDataAdapter
    Private pomse As New DataSet
    Private a As Integer
	
	Private Sub Frm_SPCHoose_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        pomrc.Connection = Odrialink2
        pomrc.CommandText = "select Orig_name from Spells order by Orig_name"
        pomda.SelectCommand = pomrc
        pomda.Fill(pomse, "se")
        For a = 0 To pomse.Tables("se").Rows.Count - 1
            Lst_AllS.Items.Add((pomse.Tables("se").Rows(a)("Orig_name").ToString))
        Next a

	End Sub
	
    Private Sub Lst_AllS_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Lst_AllS.SelectedIndexChanged
        If Lst_AllS.Text <> "" Then
            Transtr = Lst_AllS.Text
        End If
        Me.Close()

    End Sub
End Class