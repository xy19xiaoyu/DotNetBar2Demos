Imports DevComponents.Tree
Imports DevComponents.Tree.Display
Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class RedNodeRenderer
    Inherits NodeSystemRenderer

    Public Overloads Overrides Sub DrawNodeBackground(ByVal e As NodeRendererEventArgs)
        ' We'll reuse some functionality from ElementStyle implementation so we get background as defined by style
        Dim path As GraphicsPath = ElementStyleDisplay.GetBackgroundPath(e.Style, e.NodeBounds)

        If e.Node.IsMouseOver Then
            Dim brush As SolidBrush = New SolidBrush(Color.Orange)
            e.Graphics.FillPath(brush, path)
            brush.Dispose()
        Else
            Dim brush As SolidBrush = New SolidBrush(Color.Red)
            e.Graphics.FillPath(brush, path)
            brush.Dispose()
        End If

        ' Allow any events to fire, no need to call if you base.DrawNodeBackground is called
        MyBase.OnRenderNodeBackground(e)
    End Sub
End Class
