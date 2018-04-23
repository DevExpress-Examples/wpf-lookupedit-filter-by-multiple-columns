Imports Microsoft.VisualBasic
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
			NamelookUpEdit.ItemsSource = New List(Of Item) (New Item() {New Item With {.ID = 012, .ShortName = "q", .LongName = "aaay"}, New Item With {.ID = 123, .ShortName = "wn", .LongName = "bbbh"}, New Item With {.ID = 234, .ShortName = "e", .LongName = "cccn"}})
		End Sub
	End Class
	Public Class Item
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateShortName As String
		Public Property ShortName() As String
			Get
				Return privateShortName
			End Get
			Set(ByVal value As String)
				privateShortName = value
			End Set
		End Property
		Private privateLongName As String
		Public Property LongName() As String
			Get
				Return privateLongName
			End Get
			Set(ByVal value As String)
				privateLongName = value
			End Set
		End Property
	End Class
End Namespace
