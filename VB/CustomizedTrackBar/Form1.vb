Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Drawing

Namespace CustomizedTrackBar
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

        Private Sub customTrackBar1_Properties_DrawingTick(ByVal sender As Object, ByVal e As EventArgs) Handles customTrackBar1.Properties.DrawingTickEvent
            Dim ee As CustomizedTrackBar.DrawingTickEventArgs = TryCast(e, DrawingTickEventArgs)
            Dim tbObject As TrackBarObjectInfoArgs = ee.TrackBarObject
            Dim vi As CustomizedTrackBar.CustomTrackBarViewInfo = TryCast(tbObject.ViewInfo, CustomizedTrackBar.CustomTrackBarViewInfo)
            vi.RepositoryItem.TickDisplayText = ee.TickCount.ToString()
        End Sub

        Private Sub customRangeTrackBar1_Properties_DrawingTick(ByVal sender As Object, ByVal e As EventArgs) Handles customRangeTrackBar1.Properties.DrawingTickEvent
            Dim ee As CustomizedRangeTrackBar.DrawingTickEventArgs = TryCast(e, CustomizedRangeTrackBar.DrawingTickEventArgs)
            Dim tbObject As TrackBarObjectInfoArgs = ee.TrackBarObject
            Dim vi As CustomizedRangeTrackBar.CustomRangeTrackBarViewInfo = TryCast(tbObject.ViewInfo, CustomizedRangeTrackBar.CustomRangeTrackBarViewInfo)
            vi.RepositoryItem.TickDisplayText = Math.Pow(ee.TickCount, 2).ToString()
        End Sub
	End Class
End Namespace
