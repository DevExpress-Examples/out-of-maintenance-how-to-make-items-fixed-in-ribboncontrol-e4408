Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barButtonItem4, Me.barButtonItem5, Me.barButtonItem6, Me.barButtonItem7, Me.barButtonItem8, Me.barButtonItem9, Me.barButtonItem10, Me.barButtonItem11, Me.barButtonItem12, Me.barButtonItem13, Me.barButtonItem14, Me.barButtonItem15, Me.barButtonItem16, Me.barButtonItem17})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 19
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1, Me.ribbonPage2, Me.ribbonPage3, Me.ribbonPage4})
			Me.ribbonControl1.Size = New System.Drawing.Size(837, 144)
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "New"
			Me.barButtonItem1.Id = 1
			Me.barButtonItem1.LargeGlyph = My.Resources.new_document_32_h
			Me.barButtonItem1.Name = "barButtonItem1"
'			Me.barButtonItem1.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barButtonItem1_ItemClick);
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "Save"
			Me.barButtonItem2.Id = 2
            Me.barButtonItem2.LargeGlyph = My.Resources.folder_open_32_h
			Me.barButtonItem2.Name = "barButtonItem2"
'			Me.barButtonItem2.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barButtonItem2_ItemClick);
			' 
			' barButtonItem3
			' 
			Me.barButtonItem3.Caption = "Mail"
			Me.barButtonItem3.Id = 3
			Me.barButtonItem3.LargeGlyph = My.Resources.mail_32_h
			Me.barButtonItem3.Name = "barButtonItem3"
			' 
			' barButtonItem4
			' 
			Me.barButtonItem4.Caption = "Home"
			Me.barButtonItem4.Id = 4
			Me.barButtonItem4.LargeGlyph = My.Resources.home_green_32_h
			Me.barButtonItem4.Name = "barButtonItem4"
			' 
			' barButtonItem5
			' 
			Me.barButtonItem5.Caption = "Refresh"
			Me.barButtonItem5.Id = 5
			Me.barButtonItem5.LargeGlyph = My.Resources.history_32_h
			Me.barButtonItem5.Name = "barButtonItem5"
			' 
			' barButtonItem6
			' 
			Me.barButtonItem6.Caption = "Left"
			Me.barButtonItem6.Id = 6
			Me.barButtonItem6.LargeGlyph = My.Resources.arrowleft_green_32_h
			Me.barButtonItem6.Name = "barButtonItem6"
			' 
			' barButtonItem7
			' 
			Me.barButtonItem7.Caption = "Right"
			Me.barButtonItem7.Id = 7
			Me.barButtonItem7.LargeGlyph = My.Resources.arrowright_green_32_h
			Me.barButtonItem7.Name = "barButtonItem7"
			' 
			' barButtonItem8
			' 
			Me.barButtonItem8.Caption = "Stop"
			Me.barButtonItem8.Id = 8
			Me.barButtonItem8.LargeGlyph = My.Resources.stop_32_h
			Me.barButtonItem8.Name = "barButtonItem8"
			' 
			' barButtonItem9
			' 
			Me.barButtonItem9.Caption = "Properties"
			Me.barButtonItem9.Id = 9
			Me.barButtonItem9.LargeGlyph = My.Resources.properties_doc_32_h
			Me.barButtonItem9.Name = "barButtonItem9"
			' 
			' barButtonItem10
			' 
			Me.barButtonItem10.Caption = "View"
			Me.barButtonItem10.Id = 10
			Me.barButtonItem10.LargeGlyph = My.Resources.views_32_h
			Me.barButtonItem10.Name = "barButtonItem10"
			' 
			' barButtonItem11
			' 
			Me.barButtonItem11.Caption = "Copy"
			Me.barButtonItem11.Id = 11
			Me.barButtonItem11.LargeGlyph = My.Resources.copy_clipboard_32_h
			Me.barButtonItem11.Name = "barButtonItem11"
			' 
			' barButtonItem12
			' 
			Me.barButtonItem12.Caption = "Paste"
			Me.barButtonItem12.Id = 12
			Me.barButtonItem12.LargeGlyph = My.Resources.paste_clipboard_32_h
			Me.barButtonItem12.Name = "barButtonItem12"
			' 
			' barButtonItem13
			' 
			Me.barButtonItem13.Caption = "Cut"
			Me.barButtonItem13.Id = 13
			Me.barButtonItem13.LargeGlyph = My.Resources.cut_clipboard_32_h
			Me.barButtonItem13.Name = "barButtonItem13"
			' 
			' barButtonItem14
			' 
			Me.barButtonItem14.Caption = "Preview"
			Me.barButtonItem14.Id = 14
			Me.barButtonItem14.LargeGlyph = My.Resources.print_preview_32_h
			Me.barButtonItem14.Name = "barButtonItem14"
			' 
			' barButtonItem15
			' 
			Me.barButtonItem15.Caption = "Print"
			Me.barButtonItem15.Id = 15
			Me.barButtonItem15.LargeGlyph = My.Resources.print_32_h
			Me.barButtonItem15.Name = "barButtonItem15"
			' 
			' barButtonItem16
			' 
			Me.barButtonItem16.Caption = "Save layout"
			Me.barButtonItem16.Id = 17
			Me.barButtonItem16.LargeGlyph = My.Resources.save_32_h
			Me.barButtonItem16.Name = "barButtonItem16"
'			Me.barButtonItem16.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barButtonItem16_ItemClick);
			' 
			' barButtonItem17
			' 
			Me.barButtonItem17.Caption = "Restore layout"
			Me.barButtonItem17.Id = 18
			Me.barButtonItem17.LargeGlyph = My.Resources.up_folder_32_h
			Me.barButtonItem17.Name = "barButtonItem17"
'			Me.barButtonItem17.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.barButtonItem17_ItemClick);
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup3})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "Main Page"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem1)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem2)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "File"
			' 
			' ribbonPageGroup2
			' 
			Me.ribbonPageGroup2.ItemLinks.Add(Me.barButtonItem3)
			Me.ribbonPageGroup2.ItemLinks.Add(Me.barButtonItem4)
			Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
			Me.ribbonPageGroup2.Text = "Mail"
			' 
			' ribbonPageGroup3
			' 
			Me.ribbonPageGroup3.ItemLinks.Add(Me.barButtonItem5)
			Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
			Me.ribbonPageGroup3.Text = "History"
			' 
			' ribbonPage2
			' 
			Me.ribbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup4, Me.ribbonPageGroup5})
			Me.ribbonPage2.Name = "ribbonPage2"
			Me.ribbonPage2.Text = "Service"
			' 
			' ribbonPageGroup4
			' 
			Me.ribbonPageGroup4.ItemLinks.Add(Me.barButtonItem11)
			Me.ribbonPageGroup4.ItemLinks.Add(Me.barButtonItem12)
			Me.ribbonPageGroup4.ItemLinks.Add(Me.barButtonItem13)
			Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
			Me.ribbonPageGroup4.Text = "Edit"
			' 
			' ribbonPageGroup5
			' 
			Me.ribbonPageGroup5.ItemLinks.Add(Me.barButtonItem14)
			Me.ribbonPageGroup5.ItemLinks.Add(Me.barButtonItem15)
			Me.ribbonPageGroup5.Name = "ribbonPageGroup5"
			Me.ribbonPageGroup5.Text = "Print"
			' 
			' ribbonPage3
			' 
			Me.ribbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup7})
			Me.ribbonPage3.Name = "ribbonPage3"
			Me.ribbonPage3.Text = "View"
			' 
			' ribbonPageGroup7
			' 
			Me.ribbonPageGroup7.ItemLinks.Add(Me.barButtonItem9)
			Me.ribbonPageGroup7.ItemLinks.Add(Me.barButtonItem10)
			Me.ribbonPageGroup7.Name = "ribbonPageGroup7"
			Me.ribbonPageGroup7.Text = "View"
			' 
			' ribbonPage4
			' 
			Me.ribbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup8, Me.ribbonPageGroup6})
			Me.ribbonPage4.Name = "ribbonPage4"
			Me.ribbonPage4.Text = "Tools"
			' 
			' ribbonPageGroup8
			' 
			Me.ribbonPageGroup8.ItemLinks.Add(Me.barButtonItem6)
			Me.ribbonPageGroup8.ItemLinks.Add(Me.barButtonItem7)
			Me.ribbonPageGroup8.ItemLinks.Add(Me.barButtonItem8)
			Me.ribbonPageGroup8.Name = "ribbonPageGroup8"
			Me.ribbonPageGroup8.Text = "Naviation"
			' 
			' ribbonPageGroup6
			' 
			Me.ribbonPageGroup6.ItemLinks.Add(Me.barButtonItem16)
			Me.ribbonPageGroup6.ItemLinks.Add(Me.barButtonItem17)
			Me.ribbonPageGroup6.Name = "ribbonPageGroup6"
			Me.ribbonPageGroup6.Text = "Layout"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(837, 477)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "Form1"
			Me.Ribbon = Me.ribbonControl1
			Me.Text = "Main form"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private WithEvents barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem4 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem5 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem6 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem7 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem8 As DevExpress.XtraBars.BarButtonItem
		Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private barButtonItem9 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem10 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem11 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem12 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem13 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem14 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem15 As DevExpress.XtraBars.BarButtonItem
		Private WithEvents barButtonItem16 As DevExpress.XtraBars.BarButtonItem
		Private WithEvents barButtonItem17 As DevExpress.XtraBars.BarButtonItem
		Private ribbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
	End Class
End Namespace

