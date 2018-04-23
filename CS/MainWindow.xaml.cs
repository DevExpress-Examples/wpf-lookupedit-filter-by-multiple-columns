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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;
using DevExpress.Xpf.Grid;

namespace Q412037 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            GridColumn gc;
            NamelookUpEdit.ItemsSource = new List<Item> {
                new Item { ID = 012, ShortName = "q", LongName = "aaay"},
                new Item { ID = 123, ShortName = "wn", LongName = "bbbh"},
                new Item { ID = 234, ShortName = "e", LongName = "cccn"},
            };
        }
    }
    public class Item {
        public int ID { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
    }
}
