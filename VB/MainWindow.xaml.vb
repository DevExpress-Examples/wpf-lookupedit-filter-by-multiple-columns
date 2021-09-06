' Developer Express Code Central Example:
' How to filter a LookUpEdit by multiple columns
' 
' To filter a LookUpEdit by multiple columns, create a LookUpEditStrategy
' descendant and override the UpdateDisplayFilter method where the filter criteria
' is set.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5210

' Developer Express Code Central Example:
' How to filter a LookUpEdit by multiple columns
' 
' To filter a LookUpEdit by multiple columns, create a LookUpEditStrategy
' descendant and override the CreateDisplayFilterCriteria method where the filter
' criteria is generated
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5210

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Globalization
Imports DevExpress.Xpf.Grid

Namespace Q412037
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
			Dim gc As GridColumn
			NamelookUpEdit.ItemsSource = New List(Of Item) From {
				New Item With {
					.ID = 012,
					.ShortName = "q",
					.LongName = "aaay"
				},
				New Item With {
					.ID = 123,
					.ShortName = "wn",
					.LongName = "bbbh"
				},
				New Item With {
					.ID = 234,
					.ShortName = "e",
					.LongName = "cccn"
				}
			}
		End Sub
	End Class
	Public Class Item
		Public Property ID() As Integer
		Public Property ShortName() As String
		Public Property LongName() As String
	End Class
End Namespace
