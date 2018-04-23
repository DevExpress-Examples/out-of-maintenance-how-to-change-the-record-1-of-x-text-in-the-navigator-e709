Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraEditors.Controls

Namespace LocalizedText
	Public Class MyLocalizer
		Inherits Localizer
		Public Overrides Function GetLocalizedString(ByVal id As StringId) As String
			Select Case id
				Case StringId.NavigatorTextStringFormat
					Return "Item {0} of {1}"
			End Select
			Return MyBase.GetLocalizedString(id)
		End Function
	End Class
End Namespace
