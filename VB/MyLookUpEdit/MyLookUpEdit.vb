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
Imports System.Collections.Generic
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Grid.LookUp

Namespace Q412037

    Public Class MyLookUpEdit
        Inherits LookUpEdit

        Private columnsToFilterField As List(Of ColumnItem) = New List(Of ColumnItem)()

        Public Property ColumnsToFilter As List(Of ColumnItem)
            Get
                Return columnsToFilterField
            End Get

            Set(ByVal value As List(Of ColumnItem))
                columnsToFilterField = value
            End Set
        End Property

        Protected Overrides Function CreateEditStrategy() As EditStrategyBase
            Return New MyLookUpEditStrategy(Me)
        End Function
    End Class

    Public Class ColumnItem

        Public Property FieldName As String
    End Class
End Namespace
