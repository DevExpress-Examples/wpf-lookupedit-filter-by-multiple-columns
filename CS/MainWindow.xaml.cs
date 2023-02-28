using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.Windows;

namespace Q412037 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            lookUpEdit.ItemsSource = new List<Item> {
                new Item { ID = 012, ShortName = "q", LongName = "aaay"},
                new Item { ID = 123, ShortName = "wn", LongName = "bbbh"},
                new Item { ID = 234, ShortName = "e", LongName = "cccn"},
            };
        }
        void lookUpEdit_SubstituteDisplayFilter(object sender, DevExpress.Xpf.Editors.Helpers.SubstituteDisplayFilterEventArgs e) {
            if (string.IsNullOrEmpty(e.DisplayText))
                return;
            var shortNameFilter = CriteriaOperator.Parse("StartsWith(ShortName,?)", e.DisplayText);
            var idFilter = CriteriaOperator.Parse("StartsWith(ID,?)", e.DisplayText);
            e.DisplayFilter = new GroupOperator(GroupOperatorType.Or, idFilter, shortNameFilter, e.DisplayFilter);
            e.Handled = true;
        }
    }
    public class Item {
        public int ID { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
    }
}
