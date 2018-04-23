Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.ComponentModel
Imports DevExpress.XtraEditors

Namespace CustomizedTrackBar
	Friend Class CustomTrackBar
		Inherits TrackBarControl
		Shared Sub New()
			RepositoryItemCustomTrackBar.RegisterCustomTrackBar()
		End Sub

		Public Sub New()
			MyBase.New()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemCustomTrackBar.CustomTrackBarName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemCustomTrackBar
			Get
				Return TryCast(MyBase.Properties, RepositoryItemCustomTrackBar)
			End Get
		End Property
	End Class
End Namespace
