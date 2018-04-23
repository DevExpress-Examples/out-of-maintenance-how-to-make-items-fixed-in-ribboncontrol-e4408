Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon

Namespace WindowsFormsApplication1
	Public Class FixedItemCreator
		Private fixedItems As New List(Of BarItem)()
		Private Ribbon As RibbonControl

		Public Sub New(ByVal ribbon As RibbonControl)
			fixedItems = New List(Of BarItem)()
			Me.Ribbon = ribbon
			AddHandler Me.Ribbon.SelectedPageChanged, AddressOf Ribbon_SelectedPageChanged
		End Sub

		Private Sub Ribbon_SelectedPageChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim absentItems As New List(Of BarItem)()
			For Each fixedItem As BarItem In fixedItems
				Dim founded As Boolean = False
				For Each group As RibbonPageGroup In Ribbon.SelectedPage.Groups

					For Each itemLink As BarItemLink In group.ItemLinks
                        If itemLink.Item.Equals(fixedItem) Then
                            founded = True
                        End If

					Next itemLink
				Next group
				If (Not founded) Then
					absentItems.Add(fixedItem)
				End If
			Next fixedItem

			For Each absentItem As BarItem In absentItems
				Dim patternGroup As RibbonPageGroup = (TryCast(absentItem.Links(0).LinkedObject, RibbonPageGroupItemLinkCollection)).PageGroup
				Dim currentGroup As RibbonPageGroup = Nothing
				For Each group As RibbonPageGroup In Ribbon.SelectedPage.Groups
					If group.Text = patternGroup.Text Then
						currentGroup = group
						Exit For
					End If
				Next group
				If currentGroup Is Nothing Then
					currentGroup = New RibbonPageGroup()
					currentGroup.Text = patternGroup.Text
					If patternGroup.Page.Groups.IndexOf(patternGroup) >= Ribbon.SelectedPage.Groups.Count Then
						Ribbon.SelectedPage.Groups.Add(currentGroup)
					Else
						Ribbon.SelectedPage.Groups.Insert(patternGroup.Page.Groups.IndexOf(patternGroup), currentGroup)
					End If

				End If
				currentGroup.ItemLinks.Add(absentItem)
			Next absentItem
		End Sub

		Public Sub AddItem(ByVal item As BarItem)
			If (Not fixedItems.Contains(item)) Then
				fixedItems.Add(item)
			End If
		End Sub
	End Class
End Namespace
