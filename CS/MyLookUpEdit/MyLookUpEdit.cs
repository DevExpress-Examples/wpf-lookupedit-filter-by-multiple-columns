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
