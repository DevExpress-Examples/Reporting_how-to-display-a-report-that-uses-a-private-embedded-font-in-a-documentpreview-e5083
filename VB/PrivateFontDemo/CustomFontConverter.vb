﻿Imports DevExpress.Utils.Serializing
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Web

Namespace PrivateFontDemo
	Public Class CustomFontConverter
		Inherits PrintingSystemXmlSerializer.FontConverter

		Protected Overrides Function CreateObject(ByVal values() As String) As Object
			Dim font As Font = TryCast(MyBase.CreateObject(values), Font)
			If values.Length > 0 Then
				Dim fontFamily As FontFamily = CustomFontsHelper.GetFamily(values(0))
				If fontFamily IsNot Nothing Then
					Return New Font(fontFamily, font.Size, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont)
				End If
			End If
			Return font
		End Function
	End Class
End Namespace