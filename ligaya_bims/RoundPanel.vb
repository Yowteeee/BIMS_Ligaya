Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports System.ComponentModel

Public Class RoundedPanel
    Inherits Panel

    Private _borderRadius As Integer = 20
    Private _borderColor As Color = Color.Black
    Private _borderThickness As Integer = 2

    <Category("Appearance")>
    <Description("The radius of the rounded corners")>
    <DefaultValue(20)>
    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(ByVal value As Integer)
            If value >= 0 Then
                _borderRadius = value
                Me.Invalidate() ' Redraw the panel
            End If
        End Set
    End Property

    <Category("Appearance")>
    <Description("The color of the border")>
    <DefaultValue(GetType(Color), "Black")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(ByVal value As Color)
            _borderColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    <Description("The thickness of the border")>
    <DefaultValue(2)>
    Public Property BorderThickness As Integer
        Get
            Return _borderThickness
        End Get
        Set(ByVal value As Integer)
            If value >= 0 Then
                _borderThickness = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        Me.DoubleBuffered = True
        Me.BackColor = Color.White
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim graphics As Graphics = e.Graphics
        graphics.SmoothingMode = SmoothingMode.AntiAlias

        ' Create rounded rectangle path
        Dim path As GraphicsPath = GetRoundedRectanglePath(Me.ClientRectangle, _borderRadius)

        ' Set the region to clip child controls
        Me.Region = New Region(path)

        ' Fill the panel background
        Using brush As New SolidBrush(Me.BackColor)
            graphics.FillPath(brush, path)
        End Using

        ' Draw the border
        If _borderThickness > 0 Then
            Using pen As New Pen(_borderColor, _borderThickness)
                graphics.DrawPath(pen, path)
            End Using
        End If

        path.Dispose()
    End Sub

    Protected Overrides Sub OnResize(ByVal eventargs As EventArgs)
        MyBase.OnResize(eventargs)
        Me.Invalidate()
    End Sub

    Private Function GetRoundedRectanglePath(ByVal rect As Rectangle, ByVal radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        If radius <= 0 Then
            path.AddRectangle(rect)
            Return path
        End If

        Dim diameter As Integer = radius * 2

        ' Ensure diameter doesn't exceed rectangle dimensions
        diameter = Math.Min(diameter, Math.Min(rect.Width, rect.Height))

        ' Adjust rectangle for border thickness
        If _borderThickness > 0 Then
            rect = New Rectangle(
                rect.X + _borderThickness \ 2,
                rect.Y + _borderThickness \ 2,
                rect.Width - _borderThickness,
                rect.Height - _borderThickness
            )
        End If

        ' Top left arc
        path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90)

        ' Top right arc
        path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90)

        ' Bottom right arc
        path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90)

        ' Bottom left arc
        path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90)

        path.CloseFigure()
        Return path
    End Function
End Class
