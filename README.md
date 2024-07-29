# Creating a Stacked Column Chart for Global Smartphone Shipments

A [Stacked column chart](https://help.syncfusion.com/maui/cartesian-charts/stackedcolumn) comprises columns stacked on top of one another, allowing a comparison of the total and the relative contribution of each sub-category. In this case, the columns represent the quarterly smartphone shipments for 2022, while the line chart illustrates the market share of smartphones in 2022.

Simultaneously, the [Line Chart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts/chart-types/maui-line-chart) will provide a clear illustration of the market share of smartphones in 2022, offering a comprehensive view of the smartphone industry landscape throughout the year.

## Multiple y-axes to the chart
We’ll create a distinct y-axis for the line chart. This process begins with generating a y-axis and assigning a unique name. This name is subsequently bound to the line series, establishing a connection between them.

The versatility of the Cartesian Charts enables us to create multiple series, each having its own dedicated x- and y-axes. To improve the chart’s readability, modify the CrossesAt property, which will position the y-axis at the end of the chart (values are in percentages).


## Customizing the tooltip using a template
We can also customize the tooltip using a tooltip template. First, create a date template using the brand name and market share, and then bind this template to the tooltip using the `TooltipTemplate` property.

## Troubleshooting
#### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

<img width="930" alt="StackedColumn" src="https://github.com/SyncfusionExamples/Creating-a-Stacked-Column-Chart-for-Global-Smartphone-Shipments/assets/102796134/d384b86e-2793-4cf3-a570-b45495d91434">

For a step-by-step procedure, refer to the [Visualize .NET MAUI Stacked Column Chart for global smart phone shipments.](https://www.syncfusion.com/blogs/post/maui-stacked-column-chart-phone)

