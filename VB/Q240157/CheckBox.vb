Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports System.ComponentModel
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports System.Drawing
Imports DevExpress.Skins
Imports System

Namespace DXSample.Editors
	Public Class MyCheckEdit
		Inherits CheckEdit
		Shared Sub New()
			RepositoryItemMyCheckEdit.RegisterMyCheckEdit()
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyCheckEdit.MyCheckEditName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyCheckEdit
			Get
				Return CType(MyBase.Properties, RepositoryItemMyCheckEdit)
			End Get
		End Property
	End Class

	<UserRepositoryItem("RegisterMyCheckEdit")> _
	Public Class RepositoryItemMyCheckEdit
		Inherits RepositoryItemCheckEdit
		Shared Sub New()
			RegisterMyCheckEdit()
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub

		Friend Const MyCheckEditName As String = "MyCheckEdit"

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return MyCheckEditName
			End Get
		End Property

		Public Shared Sub RegisterMyCheckEdit()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(MyCheckEditName, GetType(MyCheckEdit), GetType(RepositoryItemMyCheckEdit), GetType(MyCheckEditViewInfo), New CheckEditPainter(), True))
		End Sub

		Private fVerticalGlyphAlignment As VerticalGlyphAlignment
		Public Property VerticalGlyphAlignment() As VerticalGlyphAlignment
			Get
				Return fVerticalGlyphAlignment
			End Get
			Set(ByVal value As VerticalGlyphAlignment)
				If VerticalGlyphAlignment = value Then
					Return
				End If
				fVerticalGlyphAlignment = value
				OnPropertiesChanged()
			End Set
		End Property

		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			BeginUpdate()
			Try
				MyBase.Assign(item)
				Dim source As RepositoryItemMyCheckEdit = TryCast(item, RepositoryItemMyCheckEdit)
				If source Is Nothing Then
					Return
				End If
				VerticalGlyphAlignment = source.VerticalGlyphAlignment
			Finally
				EndUpdate()
			End Try
		End Sub
	End Class

	Public Class MyFlatCheckObjectPainter
		Inherits FlatCheckObjectPainter
		Implements ICaptionCalculationMethodsProvider
		Public Sub New()
			MyBase.New()
		End Sub

		Public Overrides Overloads Function CalcObjectBounds(ByVal e As ObjectInfoArgs) As Rectangle
			MyBase.CalcObjectBounds(e)
			Return ReCalcObjectBounds(e, Me)
		End Function

		Public Shared Function ReCalcObjectBounds(ByVal e As ObjectInfoArgs, ByVal instance As ICaptionCalculationMethodsProvider) As Rectangle
			Dim ee As MyCheckObjectInfoArgs = TryCast(e, MyCheckObjectInfoArgs)
			If ee IsNot Nothing Then
				Dim glyphRect As Rectangle = ee.GlyphRect
				Dim captionRect As Rectangle = ee.CaptionRect
				If ee.GlyphAlignment = HorzAlignment.Center AndAlso ee.VerticalGlyphAlignment <> VerticalGlyphAlignment.Center Then
					Dim cSize As Size = instance.CalcCaptionSize(ee)
					captionRect = e.Bounds
					captionRect.Width = Math.Min(cSize.Width, captionRect.Width)
					ee.CaptionRect = captionRect
				End If
				captionRect.X = (ee.Bounds.Width - captionRect.Width) / 2
				Select Case ee.VerticalGlyphAlignment
					Case VerticalGlyphAlignment.Top
						glyphRect.Y = 2
						captionRect.Y = glyphRect.Height - 4
					Case VerticalGlyphAlignment.Bottom
						glyphRect.Y = ee.GlyphRect.Height + 2
						captionRect.Y = 2
						captionRect.Height -= glyphRect.Height + 2
					Case Else
						Return ee.Bounds
				End Select
				ee.GlyphRect = glyphRect
				ee.CaptionRect = captionRect
			End If
			Return e.Bounds
		End Function

		Public Overrides Overloads Function CalcObjectMinBounds(ByVal e As ObjectInfoArgs) As Rectangle
			MyBase.CalcObjectMinBounds(e)
			Return ReCalcObjectMinBounds(e)
		End Function

		Public Shared Function ReCalcObjectMinBounds(ByVal e As ObjectInfoArgs) As Rectangle
			Dim ee As MyCheckObjectInfoArgs = TryCast(e, MyCheckObjectInfoArgs)
			If ee IsNot Nothing AndAlso ee.VerticalGlyphAlignment <> VerticalGlyphAlignment.Center Then
				ee.Bounds = New Rectangle(ee.Bounds.X, ee.Bounds.Y, ee.Bounds.Width, ee.Bounds.Height * 2 + 2)
			End If
			Return ee.Bounds
		End Function

		Protected Overrides Function CanDrawCaption(ByVal e As CheckObjectInfoArgs) As Boolean
			Dim ee As MyCheckObjectInfoArgs = TryCast(e, MyCheckObjectInfoArgs)
			If ee Is Nothing Then
				Return MyBase.CanDrawCaption(e)
			Else
				Return CanDrawCaptionEx(ee)
			End If
		End Function

		Public Shared Function CanDrawCaptionEx(ByVal ee As MyCheckObjectInfoArgs) As Boolean
			Return Not(ee.GlyphAlignment = HorzAlignment.Center AndAlso ee.VerticalGlyphAlignment = VerticalGlyphAlignment.Center)
		End Function

		#Region "ICaptionCalculationMethodsProvider Members"

		Private Function CalcCaptionSize(ByVal e As CheckObjectInfoArgs) As Size Implements ICaptionCalculationMethodsProvider.CalcCaptionSize
			Return CalcCaptionSize(e)
		End Function

		Private Function CalcCaptionRect(ByVal halign As HorzAlignment, ByVal bounds As Rectangle, ByVal caption As Rectangle, ByVal glyph As Rectangle) As Rectangle Implements ICaptionCalculationMethodsProvider.CalcCaptionRect
			Return CalcCaptionRect(halign, bounds, caption, glyph)
		End Function

		#End Region
	End Class

	Public Class MySkinCheckObjectPainter
		Inherits SkinCheckObjectPainter
		Implements ICaptionCalculationMethodsProvider
		Public Sub New(ByVal provider As ISkinProvider)
			MyBase.New(provider)
		End Sub

		Public Overrides Overloads Function CalcObjectBounds(ByVal e As ObjectInfoArgs) As Rectangle
			MyBase.CalcObjectBounds(e)
			Return MyFlatCheckObjectPainter.ReCalcObjectBounds(e, Me)
		End Function

		Public Overrides Overloads Function CalcObjectMinBounds(ByVal e As ObjectInfoArgs) As Rectangle
			MyBase.CalcObjectMinBounds(e)
			Return MyFlatCheckObjectPainter.ReCalcObjectMinBounds(e)
		End Function

		Protected Overrides Function CanDrawCaption(ByVal e As CheckObjectInfoArgs) As Boolean
			Dim ee As MyCheckObjectInfoArgs = TryCast(e, MyCheckObjectInfoArgs)
			If ee Is Nothing Then
				Return MyBase.CanDrawCaption(e)
			Else
				Return MyFlatCheckObjectPainter.CanDrawCaptionEx(ee)
			End If
		End Function

		Public Overrides Overloads Sub DrawCaption(ByVal e As ObjectInfoArgs)
			MyBase.DrawCaption(e)
		End Sub

		#Region "ICaptionCalculationMethodsProvider Members"

		Private Function CalcCaptionSize(ByVal e As CheckObjectInfoArgs) As Size Implements ICaptionCalculationMethodsProvider.CalcCaptionSize
			Return CalcCaptionSize(e)
		End Function

		Private Function CalcCaptionRect(ByVal halign As HorzAlignment, ByVal bounds As Rectangle, ByVal caption As Rectangle, ByVal glyph As Rectangle) As Rectangle Implements ICaptionCalculationMethodsProvider.CalcCaptionRect
			Return CalcCaptionRect(halign, bounds, caption, glyph)
		End Function

		#End Region
	End Class

	Public Class MyCheckObjectInfoArgs
		Inherits CheckObjectInfoArgs
		Public Sub New(ByVal style As AppearanceObject)
			MyBase.New(style)
		End Sub

		Private fVerticalGlyphAlignment As VerticalGlyphAlignment
		Public Property VerticalGlyphAlignment() As VerticalGlyphAlignment
			Get
				Return fVerticalGlyphAlignment
			End Get
			Set(ByVal value As VerticalGlyphAlignment)
				fVerticalGlyphAlignment = value
			End Set
		End Property

		Public Overrides Sub Assign(ByVal info As ObjectInfoArgs)
			MyBase.Assign(info)
			Dim source As MyCheckObjectInfoArgs = TryCast(info, MyCheckObjectInfoArgs)
			If source Is Nothing Then
				Return
			End If
			VerticalGlyphAlignment = source.VerticalGlyphAlignment
		End Sub
	End Class

	Public Enum VerticalGlyphAlignment
		Top
		Center
		Bottom
	End Enum

	Public Class MyCheckEditViewInfo
		Inherits CheckEditViewInfo
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)
		End Sub

		Protected Overrides Sub UpdateCheckProperties(ByVal e As CheckObjectInfoArgs)
			MyBase.UpdateCheckProperties(e)
			Dim ee As MyCheckObjectInfoArgs = TryCast(e, MyCheckObjectInfoArgs)
			If ee Is Nothing Then
				Return
			End If
			ee.VerticalGlyphAlignment = Item.VerticalGlyphAlignment
		End Sub

		Public Shadows ReadOnly Property Item() As RepositoryItemMyCheckEdit
			Get
				Return CType(MyBase.Item, RepositoryItemMyCheckEdit)
			End Get
		End Property

		Protected Overrides Function CreateCheckArgs() As CheckObjectInfoArgs
			Return New MyCheckObjectInfoArgs(PaintAppearance)
		End Function

		Protected Overrides Function CreateCheckPainter() As CheckObjectPainter
			If IsPrinting Then
				Return New MyFlatCheckObjectPainter()
			End If
			Return New MySkinCheckObjectPainter(LookAndFeel)
		End Function
	End Class

	Public Interface ICaptionCalculationMethodsProvider
		Function CalcCaptionSize(ByVal e As CheckObjectInfoArgs) As Size
		Function CalcCaptionRect(ByVal halign As HorzAlignment, ByVal bounds As Rectangle, ByVal caption As Rectangle, ByVal glyph As Rectangle) As Rectangle
	End Interface
End Namespace