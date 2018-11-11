using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Wpf
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Human h=(Human)this.FindResource("human");
            MessageBox.Show(h.Child.name);
        }
    }
 
    //public class Human
    //{
    //    public string name { get; set; }
    //    public Human chile { set; get; }
    //}

    public class stringtohuman : UriTypeConverter
    {
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            if(value is string)
            {
                Human h = new Human();
                h.name = value as string;
                return h;
            }
            return base.ConvertFrom(context, culture, value);
        }
    }
}
