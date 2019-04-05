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


