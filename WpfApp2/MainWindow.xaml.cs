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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string inc = InC.Text;
            double inC = Double.Parse(inc);
            string otc = OtC.Text;
            double otC = Double.Parse(otc);
            string itemw = ItemW.Text;
            double itemW = Double.Parse(itemw);
            double Summary = Math.Ceiling(itemW / (inC - otC));
            string Sum = Convert.ToString(Summary);
            ShowSum.Text = Sum;
        }

       
    }
}
