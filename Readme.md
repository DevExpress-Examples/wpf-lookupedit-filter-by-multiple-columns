<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128644788/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5210)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF LookUpEdit - Filter by Multiple Columns

This example allows users to filter the [LookUpEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.LookUpEdit)'s data by multiple columns.

![image](https://user-images.githubusercontent.com/65009440/221863952-78bcfa6f-f926-433a-9833-c98050403a27.png)

To filter by multiple columns when a user types directly in the edit box, handle the [LookUpEditBase.SubstituteDisplayFilter](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.LookUpEditBase.SubstituteDisplayFilter) event. In the event handler, create criteria operators for the required columns, use the `GroupOperator` to combine the created operators, and assign this operator to the `DisplayFilter` property.

The alternative way to search by multiple columns in the `LookUpEdit` is to use the [SearchLookUpEditStyleSettings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.SearchLookUpEditStyleSettings) class, as demonstrated in the following article: [Create a SearchLookUpEdit and Bind it to Data](https://docs.devexpress.com/wpf/10748/controls-and-libraries/data-editors/getting-started/how-to-create-a-searchlookupedit-and-bind-it-to-data).

## Files to Review

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))

## Documentation

* [SearchLookUpEditStyleSettings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.SearchLookUpEditStyleSettings)
* [LookUpEditBase.SubstituteDisplayFilter](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.LookUpEditBase.SubstituteDisplayFilter)

## More Examples

* [WPF LookUpEdit - Customize the Embedded Data Grid](https://github.com/DevExpress-Examples/wpf-lookupedit-customize-the-embedded-data-grid)
* [WPF LookUpEdit - Display a TreeList as Popup Content](https://github.com/DevExpress-Examples/wpf-lookupedit-display-treelist-as-popup-content)
* [WPF Data Grid - Filter a Column's LookUpEdit Based on the Value in Another Column](https://github.com/DevExpress-Examples/wpf-data-grid-filter-column-lookupedit-based-on-value-in-another-column)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-lookupedit-filter-by-multiple-columns&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-lookupedit-filter-by-multiple-columns&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
