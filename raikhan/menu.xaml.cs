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

namespace raikhan
{
    /// <summary>
    /// Логика взаимодействия для menu.xaml
    /// </summary>
    public partial class menu : Window
    {
        public menu()
        {
            InitializeComponent();
        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            findme b = new findme();
            b.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            addme a = new addme();
            a.Show();
        }
    }
}
