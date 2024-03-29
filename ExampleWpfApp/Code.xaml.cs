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
using System.Windows.Shapes;

namespace ExampleWpfApp
{
    /// <summary>
    /// Логика взаимодействия для Code.xaml
    /// </summary>
    public partial class Code : Window
    {
        public static string sendedCode;
        public Code()
        {
            InitializeComponent();
        }
        private void AcceptBtn_Click(object sender, RoutedEventArgs e)
        {
            if (sendedCode == CodeTB.Text)
            {
                Console.WriteLine("Все хорошо!!");
                MessageBox.Show("Вход успешен");
            }
            else
            {
                MessageBox.Show("Вы не ввели код или он неправильный");
            }
        }
    }
}
