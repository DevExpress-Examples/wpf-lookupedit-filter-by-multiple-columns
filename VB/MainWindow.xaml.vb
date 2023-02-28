Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.Windows

Namespace Q412037

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.lookUpEdit.ItemsSource = New List(Of Item) From {New Item With {.ID = 012, .ShortName = "UP", .LongName = "United Package"}, New Item With {.ID = 123, .ShortName = "FS", .LongName = "Federal Shipping"}, New Item With {.ID = 234, .ShortName = "SE", .LongName = "Speedy Express"}}
        End Sub

        Private Sub lookUpEdit_SubstituteDisplayFilter(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.Helpers.SubstituteDisplayFilterEventArgs)
            If String.IsNullOrEmpty(e.DisplayText) Then Return
            Dim shortNameFilter = CriteriaOperator.Parse("Contains(ShortName,?)", e.DisplayText)
            Dim idFilter = CriteriaOperator.Parse("Contains(ID,?)", e.DisplayText)
            e.DisplayFilter = New GroupOperator(GroupOperatorType.Or, idFilter, shortNameFilter, e.DisplayFilter)
            e.Handled = True
        End Sub
    End Class

    Public Class Item

        Public Property ID As Integer

        Public Property ShortName As String

        Public Property LongName As String
    End Class
End Namespace
