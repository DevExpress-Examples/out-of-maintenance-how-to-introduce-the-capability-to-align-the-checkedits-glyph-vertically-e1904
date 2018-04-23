Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace Q240157
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			For i As Integer = 0 To 9
				dataTable1.Rows.Add(i Mod 2 = 0, i Mod 2 = 1)
			Next i
		End Sub
	End Class
End Namespace