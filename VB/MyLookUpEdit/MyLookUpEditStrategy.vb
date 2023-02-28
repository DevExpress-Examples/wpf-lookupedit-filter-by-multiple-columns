Imports System.Collections.Generic
Imports DevExpress.Xpf.Grid.LookUp
Imports DevExpress.Data.Filtering

Namespace Q412037

    Friend Class MyLookUpEditStrategy
        Inherits LookUpEditStrategy

        Public Sub New(ByVal editor As LookUpEdit)
            MyBase.New(editor)
        End Sub

        Protected Overrides Function CreateDisplayFilterCriteria(ByVal text As String) As CriteriaOperator
            Dim lookUp As MyLookUpEdit = CType(Editor, MyLookUpEdit)
            Dim groupOperator As GroupOperator = New GroupOperator() With {.OperatorType = GroupOperatorType.Or}
            For Each col As ColumnItem In lookUp.ColumnsToFilter
                Dim list As List(Of CriteriaOperator) = New List(Of CriteriaOperator)()
                list.Add(New OperandProperty() With {.PropertyName = col.FieldName})
                list.Add(New OperandValue() With {.Value = text})
                groupOperator.Operands.Add(New FunctionOperator(FunctionOperatorType.Contains, list))
            Next

            Return groupOperator
        End Function
    End Class
End Namespace
