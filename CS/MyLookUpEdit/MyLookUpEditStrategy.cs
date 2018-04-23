// Developer Express Code Central Example:
// How to filter a LookUpEdit by multiple columns
// 
// To filter a LookUpEdit by multiple columns, create a LookUpEditStrategy
// descendant and override the UpdateDisplayFilter method where the filter criteria
// is set.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5210

// Developer Express Code Central Example:
// How to filter a LookUpEdit by multiple columns
// 
// To filter a LookUpEdit by multiple columns, create a LookUpEditStrategy
// descendant and override the CreateDisplayFilterCriteria method where the filter
// criteria is generated
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5210

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpf.Grid.LookUp;
using DevExpress.Data.Filtering;
using DevExpress.Xpf.Grid;

namespace Q412037
{
    public class MyLookUpEditStrategy : LookUpEditStrategy
    {
        public MyLookUpEditStrategy(LookUpEdit editor)
            : base(editor)
        {
        }

        public override void UpdateDisplayFilter()
        {
            Editor.Dispatcher.BeginInvoke(new Action(() => ItemsProvider.SetDisplayFilterCriteria(CreateDisplayFilterCriteria(AutoSearchText), this.CurrentDataViewHandle)));

        }
        protected CriteriaOperator CreateDisplayFilterCriteria(string text)
        {
            MyLookUpEdit lookUp = (MyLookUpEdit)Editor;
            GroupOperator groupOperator = new GroupOperator() { OperatorType = GroupOperatorType.Or };
            foreach (ColumnItem col in lookUp.ColumnsToFilter)
            {
                List<CriteriaOperator> list = new List<CriteriaOperator>();
                list.Add(new OperandProperty() { PropertyName = col.FieldName });
                list.Add(new OperandValue() { Value = text });
                groupOperator.Operands.Add(new FunctionOperator(FunctionOperatorType.Contains, list));
            }
            return groupOperator;
        }
    }
}
