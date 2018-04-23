Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Drawing
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel

Namespace CustomizedRangeTrackBar
	Friend Class SkinCustomRangeTrackBarObjectPainter
		Inherits SkinRangeTrackBarObjectPainter
		Public Sub New(ByVal provider As ISkinProvider)
			MyBase.New(provider)
		End Sub

		Public Overrides Overloads Sub DrawPoints(ByVal e As TrackBarObjectInfoArgs, ByVal bMirror As Boolean)
			Dim p1 As Point = Point.Empty, p2 As Point = Point.Empty
			Dim xPos As Single
			Dim tickCount As Integer
			p1.Y = e.ViewInfo.PointsRect.Y
			xPos = 0
			tickCount = 0
			Do While tickCount < e.ViewInfo.TickCount
				p1.X = CInt(Fix(e.ViewInfo.PointsRect.X + xPos + 0.01f))
				p2.X = p1.X
				If tickCount <> 0 AndAlso tickCount <> e.ViewInfo.TickCount - 1 Then
					p2.Y = p1.Y + Math.Max(e.ViewInfo.PointsRect.Height * 3 \ 4, 1)
				Else
					p2.Y = p1.Y + e.ViewInfo.PointsRect.Height
				End If
				DrawLine(e, e.ViewInfo.TrackBarHelper.RotateAndMirror(p1, e.ViewInfo.MirrorPoint.Y, bMirror), e.ViewInfo.TrackBarHelper.RotateAndMirror(p2, e.ViewInfo.MirrorPoint.Y, bMirror))
				DrawTickText(e, p1, tickCount)
				xPos += e.ViewInfo.PointsDelta
				tickCount += 1
			Loop
		End Sub

		Private Shared Sub DrawTickText(ByVal e As TrackBarObjectInfoArgs, ByVal p As Point, ByVal tickCount As Integer)
			Dim vi As CustomRangeTrackBarViewInfo = TryCast(e.ViewInfo, CustomRangeTrackBarViewInfo)
			vi.RepositoryItem.OnDrawingTick(New DrawingTickEventArgs(e, tickCount))

			' Do not attempt to display tick value in case if it wasn't specified by user
			If vi.RepositoryItem.TickDisplayText Is Nothing Then
				Return
			End If

			' Check if there's enough space to draw the tick values assuming that there should be at least 15 pixels available for drawing
			' the text
			Dim freePixels As Integer = e.Bounds.Y + e.Bounds.Height - (e.ViewInfo.PointsRect.Y + e.ViewInfo.PointsRect.Height)
			If freePixels < 10 Then
				Return
			End If

			Dim textRect As New Rectangle()
			textRect.Y = e.ViewInfo.PointsRect.Y + e.ViewInfo.PointsRect.Height + 3
			textRect.Height = freePixels - 3

			Dim font As New Font(e.Appearance.Font.FontFamily, CType(Math.Min(freePixels - 3, 7), Single), FontStyle.Regular)

            Dim strFormat As StringFormat = TryCast(e.Appearance.GetStringFormat().Clone(), StringFormat)
            strFormat.Alignment = StringAlignment.Center

			textRect.X = CInt(Fix(p.X - e.ViewInfo.PointsDelta / 2))
			textRect.Width = CInt(Fix(e.ViewInfo.PointsDelta))

			Dim strSize As SizeF = e.Graphics.MeasureString(vi.RepositoryItem.TickDisplayText, font)
			Dim overlap As Double = strSize.Width \ textRect.Width

			If overlap <= 1 Then
				e.Paint.DrawString(e.Cache, vi.RepositoryItem.TickDisplayText, font, e.Cache.GetSolidBrush(e.Appearance.ForeColor), textRect, strFormat)
			Else
				Dim range As Integer = CInt(Fix(Math.Round(overlap)))
				textRect.Width = CInt(Fix(textRect.Width * overlap))

				Dim tail As Integer = If((e.ViewInfo.TickCount Mod 2 = 0), 0, 1)

				If tickCount Mod range <> tail Then
					e.Paint.DrawString(e.Cache, vi.RepositoryItem.TickDisplayText, font, e.Cache.GetSolidBrush(e.Appearance.ForeColor), textRect, strFormat)
				End If
			End If
		End Sub
	End Class
End Namespace
