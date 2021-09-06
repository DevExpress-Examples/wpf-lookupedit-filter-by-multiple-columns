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
Imports DevExpress.Xpf.Grid.LookUp
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpf.Grid

Namespace Q412037
	Public Class MyLookUpEditStrategy
		Inherits LookUpEditStrategy

		Public Sub New(ByVal editor As LookUpEdit)
			MyBase.New(editor)
		End Sub

		Public Overrides Sub UpdateDisplayFilter()
			Editor.Dispatcher.BeginInvoke(New Action(Sub() ItemsProvider.SetDisplayFilterCriteria(CreateDisplayFilterCriteria(AutoSearchText), Me.CurrentDataViewHandle)))

		End Sub
		Protected Function CreateDisplayFilterCriteria(ByVal text As String) As CriteriaOperator
			Dim lookUp As MyLookUpEdit = CType(Editor, MyLookUpEdit)
			Dim groupOperator As New GroupOperator() With {.OperatorType = GroupOperatorType.Or}
			For Each col As ColumnItem In lookUp.ColumnsToFilter
				Dim list As New List(Of CriteriaOperator)()
				list.Add(New OperandProperty() With {.PropertyName = col.FieldName})
				list.Add(New OperandValue() With {.Value = text})
				groupOperator.Operands.Add(New FunctionOperator(FunctionOperatorType.Contains, list))
			Next col
			Return groupOperator
		End Function
	End Class
End Namespace
