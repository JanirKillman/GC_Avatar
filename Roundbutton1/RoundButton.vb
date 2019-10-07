Imports System.Drawing.Drawing2D

Public Class RoundButton
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        setstyle(ControlStyles.ResizeRedraw, "True")
    End Sub

    'UserControl overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'RoundButton
        '
        Me.Name = "RoundButton"

    End Sub

#End Region

    Public Enum State
        Active
        Inactive
    End Enum

    Private currentCaption As String
    Private currentState As State

    Public ReadOnly Property ButtonState() As State
        Get
            ButtonState = currentState
        End Get
    End Property

    Protected Overrides Sub onpaint(ByVal pe As PaintEventArgs)
        Dim roundPath As New GraphicsPath()
        Dim R As New Rectangle(0, 0, Me.Width, Me.Height)
        roundPath.AddEllipse(R)
        Me.Region = New Region(roundPath)
        pe.Graphics.DrawEllipse(New Pen(Color.Black, 5), R)
        Dim fnt As Font
        If currentState = State.Active Then
            If Me.BackColor.Equals(Color.Silver) Then Me.BackColor = Color.Green
            fnt = New Font("Verdana", 24, FontStyle.Bold)
        Else
            fnt = New Font("Verdana", 14, FontStyle.Regular)
        End If
        Dim X As Integer = (Me.Width - pe.Graphics.MeasureString(currentCaption, fnt).Width) / 2
        Dim Y As Integer = (Me.Height - pe.Graphics.MeasureString(currentCaption, fnt).Height) / 2
        pe.Graphics.DrawString(currentCaption, fnt, Brushes.Black, X, Y)
    End Sub

    Private Sub RoundButton_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim G As Graphics
        G = Me.CreateGraphics
        Dim roundPath As New GraphicsPath()
        Dim R As New Rectangle(0, 0, Me.Width, Me.Height)
        roundPath.AddEllipse(R)
        Me.Region = New Region(roundPath)
        Me.CreateGraphics.DrawEllipse(New Pen(Color.Black, 5), R)
    End Sub

    Private Sub RoundButton_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        If currentState = State.Active Then
            Me.BackColor = Color.Green
        End If
    End Sub

    Private Sub RoundButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MouseLeave
        If currentState = State.Active Then
            Me.BackColor = Color.Red
        End If
    End Sub

End Class
