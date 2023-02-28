using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.Windows;

namespace Q412037 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            lookUpEdit.ItemsSource = new List<Item> {
                new Item { ID = 012, ShortName = "UP", LongName = "United Package"},
                new Item { ID = 123, ShortName = "FS", LongName = "Federal Shipping"},
                new Item { ID = 234, ShortName = "SE", LongName = "Speedy Express"},
            };
        }
        void lookUpEdit_SubstituteDisplayFilter(object sender, DevExpress.Xpf.Editors.Helpers.SubstituteDisplayFilterEventArgs e) {
            if (string.IsNullOrEmpty(e.DisplayText))
                return;
            var shortNameFilter = CriteriaOperator.Parse("Contains(ShortName,?)", e.DisplayText);
            var idFilter = CriteriaOperator.Parse("Contains(ID,?)", e.DisplayText);
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
