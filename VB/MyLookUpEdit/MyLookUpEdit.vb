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
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Grid.LookUp

Namespace Q412037
	Public Class MyLookUpEdit
		Inherits LookUpEdit

'INSTANT VB NOTE: The field columnsToFilter was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private columnsToFilter_Conflict As New List(Of ColumnItem)()
		Public Property ColumnsToFilter() As List(Of ColumnItem)
			Get
				Return columnsToFilter_Conflict
			End Get
			Set(ByVal value As List(Of ColumnItem))
				columnsToFilter_Conflict = value
			End Set
		End Property
		Protected Overrides Function CreateEditStrategy() As EditStrategyBase
			Return New MyLookUpEditStrategy(Me)
		End Function
	End Class
	Public Class ColumnItem
		Public Property FieldName() As String
	End Class
End Namespace
