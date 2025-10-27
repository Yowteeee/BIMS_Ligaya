Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RoundedButton
    Inherits Button

    Private _borderRadius As Integer = 15 ' Default border radius

    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(ByVal value As Integer)
            If value >= 0 Then
                _borderRadius = value
                Me.Invalidate() ' Redraw the button
            End If
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim path As New GraphicsPath()
        Dim curveSize As Integer = _borderRadius * 2
        Dim rect As New RectangleF(0, 0, Me.Width, Me.Height)

        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90)
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90)
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90)
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90)
        path.CloseFigure()

        Me.Region = New Region(path)
        MyBase.OnPaint(e)
    End Sub

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        MyBase.OnResize(e)
        Me.Invalidate()
    End Sub
End Class
