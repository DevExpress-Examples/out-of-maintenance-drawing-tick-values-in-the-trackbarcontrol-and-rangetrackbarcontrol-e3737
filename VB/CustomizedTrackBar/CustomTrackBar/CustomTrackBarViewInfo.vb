Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.LookAndFeel

Namespace CustomizedTrackBar
	Friend Class CustomTrackBarViewInfo
		Inherits TrackBarViewInfo
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)
		End Sub

		Public ReadOnly Property RepositoryItem() As RepositoryItemCustomTrackBar
			Get
				Return TryCast(Me.Item, RepositoryItemCustomTrackBar)
			End Get
		End Property

		Public Overrides Function GetTrackPainter() As TrackBarObjectPainter
			'if (IsPrinting)
			'    return new TrackBarObjectPainter();
			'if (this.LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.WindowsXP)
			'    return new WindowsXPTrackBarObjectPainter();
			'if (this.LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.Skin)
			Return New SkinCustomTrackBarObjectPainter(LookAndFeel.ActiveLookAndFeel)
			'if (this.LookAndFeel.ActiveStyle == ActiveLookAndFeelStyle.Office2003)
			'    return new Office2003TrackBarObjectPainter();
			'return new TrackBarObjectPainter();
		End Function
	End Class
End Namespace
