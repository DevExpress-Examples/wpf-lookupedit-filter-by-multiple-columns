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
