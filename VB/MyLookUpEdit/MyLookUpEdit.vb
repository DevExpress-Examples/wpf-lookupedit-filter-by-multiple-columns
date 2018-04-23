Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Grid.LookUp

Namespace Q412037
	Public Class MyLookUpEdit
		Inherits LookUpEdit
		Private columnsToFilter_Renamed As New List(Of ColumnItem)()
		Public Property ColumnsToFilter() As List(Of ColumnItem)
			Get
				Return columnsToFilter_Renamed
			End Get
			Set(ByVal value As List(Of ColumnItem))
				columnsToFilter_Renamed = value
			End Set
		End Property
		Protected Overrides Function CreateEditStrategy() As EditStrategyBase
			Return New MyLookUpEditStrategy(Me)
		End Function
	End Class
	Public Class ColumnItem
		Private privateFieldName As String
		Public Property FieldName() As String
			Get
				Return privateFieldName
			End Get
			Set(ByVal value As String)
				privateFieldName = value
			End Set
		End Property
	End Class
End Namespace
