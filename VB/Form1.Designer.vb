Imports Microsoft.VisualBasic
Imports System
Namespace DateTimeChartRangeControlClient
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
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			Me.rangeControl1 = New DevExpress.XtraEditors.RangeControl()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rangeControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			Me.chartControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.chartControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.chartControl1.Location = New System.Drawing.Point(0, -1)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chartControl1.Size = New System.Drawing.Size(592, 164)
			Me.chartControl1.TabIndex = 0
			' 
			' rangeControl1
			' 
			Me.rangeControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.rangeControl1.Location = New System.Drawing.Point(0, 169)
			Me.rangeControl1.Name = "rangeControl1"
			Me.rangeControl1.Size = New System.Drawing.Size(592, 119)
			Me.rangeControl1.TabIndex = 1
			Me.rangeControl1.Text = "rangeControl1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(592, 290)
			Me.Controls.Add(Me.rangeControl1)
			Me.Controls.Add(Me.chartControl1)
			Me.Name = "Form1"
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rangeControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControl1 As DevExpress.XtraCharts.ChartControl
		Private rangeControl1 As DevExpress.XtraEditors.RangeControl
	End Class
End Namespace

