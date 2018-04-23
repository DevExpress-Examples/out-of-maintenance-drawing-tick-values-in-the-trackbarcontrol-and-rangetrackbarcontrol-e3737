Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.ComponentModel
Imports DevExpress.XtraEditors

Namespace CustomizedRangeTrackBar
	Friend Class CustomRangeTrackBar
		Inherits RangeTrackBarControl
		Shared Sub New()
			RepositoryItemCustomRangeTrackBar.RegisterCustomRangeTrackBar()
		End Sub
		Public Sub New()
			MyBase.New()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemCustomRangeTrackBar.CustomRangeTrackBarName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemCustomRangeTrackBar
			Get
				Return TryCast(MyBase.Properties, RepositoryItemCustomRangeTrackBar)
			End Get
		End Property
	End Class
End Namespace
