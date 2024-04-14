using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ABBA.WILDBERDataSetTableAdapters;

namespace ABBA
{

    public partial class Buyers : Page
    {
        BUYERTableAdapter go = new BUYERTableAdapter();
        public Buyers()
        {
            InitializeComponent();
            ColourDataGrid.ItemsSource = go.GetData();
        }
    }
}