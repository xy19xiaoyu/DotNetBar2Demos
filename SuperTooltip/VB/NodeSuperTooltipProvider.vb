Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

' Wrapper class so SuperTooltips can be displayed for node objects.
' Regular Windows Forms Controls are supported automatically.
Public Class NodeSuperTooltipProvider
    Inherits System.ComponentModel.Component
    Implements DevComponents.DotNetBar.ISuperTooltipInfoProvider

    Dim m_Node As TreeNode

    Public Sub New(ByVal node As TreeNode)
        m_Node = node
    End Sub

    ' Call this method to show tooltip for given node.
    Public Sub Show()
        RaiseEvent DisplayTooltip(Me, New EventArgs)
    End Sub

    ' Call this method to hide tooltip for given node.
    Public Sub Hide()
        RaiseEvent HideTooltip(Me, New EventArgs)
    End Sub

#Region " ISuperTooltipInfoProvider Implementation "
    ' Returns screen coordinates of object.
    Public ReadOnly Property ComponentRectangle() As System.Drawing.Rectangle Implements DevComponents.DotNetBar.ISuperTooltipInfoProvider.ComponentRectangle
        Get
            Dim r As Rectangle = m_Node.Bounds
            r.Location = m_Node.TreeView.PointToScreen(r.Location)
            Return r
        End Get
    End Property

    Public Event DisplayTooltip(ByVal sender As Object, ByVal e As EventArgs) Implements DevComponents.DotNetBar.ISuperTooltipInfoProvider.DisplayTooltip
    Public Event HideTooltip(ByVal sender As Object, ByVal e As EventArgs) Implements DevComponents.DotNetBar.ISuperTooltipInfoProvider.HideTooltip
#End Region
End Class
