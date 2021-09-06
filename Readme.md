<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128644788/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5210)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [MyLookUpEdit.cs](./CS/MyLookUpEdit/MyLookUpEdit.cs) (VB: [MyLookUpEdit.vb](./VB/MyLookUpEdit/MyLookUpEdit.vb))
* [MyLookUpEditStrategy.cs](./CS/MyLookUpEdit/MyLookUpEditStrategy.cs) (VB: [MyLookUpEditStrategy.vb](./VB/MyLookUpEdit/MyLookUpEditStrategy.vb))
<!-- default file list end -->
# How to filter a LookUpEdit by multiple columns


<p>The easiest way to search by multiple columns in LookUpEdit is to use the <strong>SearchLookUpEditStyleSettings</strong> class as demonstrated in the <a href="https://documentation.devexpress.com/#wpf/customdocument10748">How to: Create a SearchLookUpEdit and Bind it to Data</a> article.<br /><br />If you would like to filter by multiple columns when a user types directly in the edit box instead, create a LookUpEditStrategy descendant and override the UpdateDisplayFilter method where the filter criteria is set.</p>

<br/>


