using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace ExampleWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string login = "admin";
        private string password = "admin";
        public MainWindow()
        {
            InitializeComponent();
        }
        List<string> contents = new List<string>() { "Милкризу", "Лизи пизи смоук"};
        List<Brush> colors = new List<Brush>() { Brushes.HotPink, Brushes.Blue };
        int indexPosition = 0;
        private void SimpleBtn_Click(object sender, RoutedEventArgs e)
        {
            indexPosition++;
            SimpleBtn.Background = colors[indexPosition % colors.Count()];
            SimpleBtn.Content = contents[indexPosition % contents.Count()];

            if (password != "171519")
            {
                MessageBox.Show("Вы успешно авторизовались!");
            }
            else
            {

            }
            
        }

        private void SimpleTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            SimpleLb.Content = SimpleTB.Text;
        }
    }


}
