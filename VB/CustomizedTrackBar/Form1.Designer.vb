Imports Microsoft.VisualBasic
Imports System
Namespace CustomizedTrackBar
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.customTrackBar1 = New CustomizedTrackBar.CustomTrackBar()
			Me.customRangeTrackBar1 = New CustomizedRangeTrackBar.CustomRangeTrackBar()
			CType(Me.customTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customTrackBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customRangeTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customRangeTrackBar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' customTrackBar1
			' 
			Me.customTrackBar1.Dock = System.Windows.Forms.DockStyle.Top
			Me.customTrackBar1.EditValue = Nothing
			Me.customTrackBar1.Location = New System.Drawing.Point(0, 0)
			Me.customTrackBar1.Name = "customTrackBar1"
			Me.customTrackBar1.Properties.TickDisplayText = "3"
'			Me.customTrackBar1.Properties.DrawingTick += New System.EventHandler(Me.customTrackBar1_Properties_DrawingTick);
			Me.customTrackBar1.Size = New System.Drawing.Size(415, 45)
			Me.customTrackBar1.TabIndex = 3
			' 
			' customRangeTrackBar1
			' 
			Me.customRangeTrackBar1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.customRangeTrackBar1.EditValue = New DevExpress.XtraEditors.Repository.TrackBarRange(0, 0)
			Me.customRangeTrackBar1.Location = New System.Drawing.Point(0, 68)
			Me.customRangeTrackBar1.Name = "customRangeTrackBar1"
			Me.customRangeTrackBar1.Properties.TickDisplayText = "7"
'			Me.customRangeTrackBar1.Properties.DrawingTick += New System.EventHandler(Me.customRangeTrackBar1_Properties_DrawingTick);
			Me.customRangeTrackBar1.Size = New System.Drawing.Size(415, 45)
			Me.customRangeTrackBar1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(415, 113)
			Me.Controls.Add(Me.customTrackBar1)
			Me.Controls.Add(Me.customRangeTrackBar1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.customTrackBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customRangeTrackBar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customRangeTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		#End Region

		Private WithEvents customRangeTrackBar1 As CustomizedRangeTrackBar.CustomRangeTrackBar
		Private WithEvents customTrackBar1 As CustomTrackBar


	End Class
End Namespace

