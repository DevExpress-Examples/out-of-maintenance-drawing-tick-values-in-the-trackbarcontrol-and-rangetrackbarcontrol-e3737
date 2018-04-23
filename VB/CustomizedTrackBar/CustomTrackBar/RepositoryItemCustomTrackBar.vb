Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing

Namespace CustomizedTrackBar
	'The attribute that points to the registration method 
	<UserRepositoryItem("RegisterCustomTrackBar")> _
	Friend Class RepositoryItemCustomTrackBar
		Inherits RepositoryItemTrackBar
		Private Shared ReadOnly drawingTick As Object = New Object()
		Private tickDisplayText_Renamed As String

		' Static constructor should call registration method
		Shared Sub New()
			RegisterCustomTrackBar()
		End Sub

		Public Const CustomTrackBarName As String = "CustomTrackBar"
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return CustomTrackBarName
			End Get
		End Property

		Public Shared Sub RegisterCustomTrackBar()
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomTrackBarName, GetType(CustomTrackBar), GetType(RepositoryItemCustomTrackBar), GetType(CustomTrackBarViewInfo), New TrackBarPainter(), True))
		End Sub

        Public Custom Event DrawingTickEvent As EventHandler
            AddHandler(ByVal value As EventHandler)
                Events.AddHandler(RepositoryItemCustomTrackBar.drawingTick, value)
            End AddHandler
            RemoveHandler(ByVal value As EventHandler)
                Events.AddHandler(RepositoryItemCustomTrackBar.drawingTick, value)
            End RemoveHandler
            RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
            End RaiseEvent
        End Event

		Protected Friend Overridable Sub OnDrawingTick(ByVal e As EventArgs)
			Dim handler As EventHandler = CType(Events(RepositoryItemCustomTrackBar.drawingTick), EventHandler)
			If handler IsNot Nothing Then
				handler(GetEventSender(), e)
			End If
		End Sub

		Public Property TickDisplayText() As String
			Set(ByVal value As String)
				tickDisplayText_Renamed = value
				RaisePropertiesChanged(EventArgs.Empty)
			End Set
			Get
				Return tickDisplayText_Renamed
			End Get
		End Property

		' Override the Assign method
		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			BeginUpdate()
			MyBase.Assign(item)
			Dim source As RepositoryItemCustomTrackBar = TryCast(item, RepositoryItemCustomTrackBar)
			If source Is Nothing Then
				Return
			End If
			Me.TickDisplayText = source.TickDisplayText
			EndUpdate()
			Events.AddHandler(RepositoryItemCustomTrackBar.drawingTick, source.Events(RepositoryItemCustomTrackBar.drawingTick))
		End Sub
	End Class

	Public Class DrawingTickEventArgs
		Inherits EventArgs
		Private trackBarObject_Renamed As TrackBarObjectInfoArgs
		Private tickCount_Renamed As Integer

		Public Sub New(ByVal _trackBarObject As TrackBarObjectInfoArgs, ByVal _tickCount As Integer)
			trackBarObject_Renamed = _trackBarObject
			tickCount_Renamed = _tickCount
		End Sub

		Public ReadOnly Property TrackBarObject() As TrackBarObjectInfoArgs
			Get
				Return trackBarObject_Renamed
			End Get
		End Property
		Public ReadOnly Property TickCount() As Integer
			Get
				Return tickCount_Renamed
			End Get
		End Property
	End Class
End Namespace
