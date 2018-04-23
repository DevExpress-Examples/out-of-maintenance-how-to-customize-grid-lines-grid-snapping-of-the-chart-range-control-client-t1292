Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace DateTimeChartRangeControlClient
	Partial Public Class Form1
		Inherits Form

		Private Const daysForYear As Integer = 30

		Public Sub New()
			InitializeComponent()

			' Call the InitializeChart method. 
			InitializeChart()

			' Specify a Chart control as the Range control client. 
			rangeControl1.Client = chartControl1

			' Access the date-time grid options of the chart range control client.
			Dim clientOptions = CType(rangeControl1.ClientOptions, ChartRangeControlClientDateTimeOptions)
			Dim gridOptions As ChartRangeControlClientDateTimeGridOptions = clientOptions.RangeControlDateTimeGridOptions

			' Specify the manual grid mode of the chart range control client. 
			gridOptions.GridMode = ChartRangeControlClientGridMode.Manual

			' Customize snap and grid properties of the chart range control client.            
			gridOptions.SnapOffset = 2
			gridOptions.SnapSpacing = 7
			gridOptions.SnapAlignment = DateTimeGridAlignment.Day
			gridOptions.GridSpacing = 7
			gridOptions.GridAlignment = DateTimeGridAlignment.Day
			gridOptions.GridOffset = 1

			' Format labels of the chart range control client.
			gridOptions.LabelFormat = "D"
		End Sub

		Private Sub InitializeChart()

			Dim baseDate As New DateTime(2000, 1, 1)
			Dim rnd As New Random()
			Dim series As New Series("Series", ViewType.Bar)

			For dayCount As Integer = 0 To daysForYear - 1
				Dim argument As DateTime = baseDate.AddDays(dayCount)
				Dim value As Double = rnd.Next(50, 100)
				Dim seriesPoint = New SeriesPoint(argument, value)
				series.Points.Add(seriesPoint)
			Next dayCount
			chartControl1.Series.Add(series)
		End Sub
	End Class
End Namespace
