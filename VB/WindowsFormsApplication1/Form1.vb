Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits RibbonForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim creator As New FixedItemCreator(Ribbon)
			creator.AddItem(barButtonItem1)
			creator.AddItem(barButtonItem2)
		End Sub

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			MessageBox.Show("Open item is clicked")
		End Sub

		Private Sub barButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem2.ItemClick
			MessageBox.Show("Save item is clicked")
		End Sub

		Private Sub barButtonItem16_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem16.ItemClick
			Ribbon.SaveLayoutToXml("ribbon.xml")
		End Sub

		Private Sub barButtonItem17_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem17.ItemClick
			If System.IO.File.Exists("ribbon.xml") Then
				Ribbon.RestoreLayoutFromXml("ribbon.xml")
			End If
		End Sub
	End Class
End Namespace
