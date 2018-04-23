# How to customize grid lines, grid snapping of the chart range control client


This example demonstrates how the grid lines and grid snapping of the chart within the range control's viewport can be customized at runtime.


<h3>Description</h3>

To access the client options of the chart inside the range control's viewport, use the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRangeControl_ClientOptionstopic">RangeControl.ClientOptions</a>&nbsp;property.&nbsp;In this example, the chart&nbsp;control contains data with date-time arguments, so &nbsp;this property returns an object of the&nbsp;<strong>ChartRangeControlClientDateTimeOptions&nbsp;</strong>type. <br /><br />To access the grid properties (e.g., <strong>SnapSpacing</strong>, SnapAlignment, <strong>GridSpacing</strong>,<strong> GridAlignment</strong>) of the chart range control client, access the <strong>ChartRangeControlClientDateTimeGridOptions</strong> object using the <strong>ChartRangeControlClientDateTimeOptions</strong>.<strong>RangeControlDateTimeGridOptions&nbsp;</strong>property.

<br/>


