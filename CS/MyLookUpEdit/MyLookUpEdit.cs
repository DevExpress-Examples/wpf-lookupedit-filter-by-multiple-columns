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
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Grid.LookUp;

namespace Q412037
{
    public class MyLookUpEdit : LookUpEdit
    {
        List<ColumnItem> columnsToFilter = new List<ColumnItem>();
        public List<ColumnItem> ColumnsToFilter
        {
            get
            {
                return columnsToFilter;
            }
            set
            {
                columnsToFilter = value;
            }
        }
        protected override EditStrategyBase CreateEditStrategy()
        {
            return new MyLookUpEditStrategy(this);
        }
    }
    public class ColumnItem
    {
        public string FieldName
        {
            get;
            set;
        }
    }
}
