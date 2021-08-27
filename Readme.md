<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574197/14.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T129232)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to customize grid lines, grid snapping of the chart range control client


This example demonstrates how the grid lines and grid snapping of the chart within the range control's viewport can be customized at runtime.


<h3>Description</h3>

To access the client options of the chart inside the range control's viewport, use the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraEditorsRangeControl_ClientOptionstopic">RangeControl.ClientOptions</a>&nbsp;property.&nbsp;In this example, the chart&nbsp;control contains data with date-time arguments, so &nbsp;this property returns an object of the&nbsp;<strong>ChartRangeControlClientDateTimeOptions&nbsp;</strong>type. <br /><br />To access the grid properties (e.g., <strong>SnapSpacing</strong>, SnapAlignment, <strong>GridSpacing</strong>,<strong> GridAlignment</strong>) of the chart range control client, access the <strong>ChartRangeControlClientDateTimeGridOptions</strong> object using the <strong>ChartRangeControlClientDateTimeOptions</strong>.<strong>RangeControlDateTimeGridOptions&nbsp;</strong>property.

<br/>


