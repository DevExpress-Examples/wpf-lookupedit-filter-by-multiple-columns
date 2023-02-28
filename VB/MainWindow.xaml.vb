Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid

Namespace Q412037

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim gc As GridColumn
            Me.NamelookUpEdit.ItemsSource = New List(Of Item) From {New Item With {.ID = 012, .ShortName = "q", .LongName = "aaay"}, New Item With {.ID = 123, .ShortName = "wn", .LongName = "bbbh"}, New Item With {.ID = 234, .ShortName = "e", .LongName = "cccn"}}
        End Sub
    End Class

    Public Class Item

        Public Property ID As Integer

        Public Property ShortName As String

        Public Property LongName As String
    End Class
End Namespace
