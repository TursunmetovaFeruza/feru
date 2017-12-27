using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace raikhan
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }




        private void LOG_IN1_Click(object sender, RoutedEventArgs e)

        /* string connectingString = "Server = localhost; DATABASE= STORE_KEEPING;UID=root; PASSWORD=root;  ";
        MySqlConnection connection = new MySqlConnection(connectingString);
        connection.Open();
        string login = textBoxUser.Text;
        string password = passBoxPwd.Password;
        MySqlCommand cmd = new MySqlCommand("select * from authorization where store_keeper_login = \'" + login + "\' and store_keeper_password=\'" + password + "\'", connection);
        DataTable dt = new DataTable();
        dt.Load(cmd.ExecuteReader());
        connection.Close();
        //dtGrid.DataContext = dt;
        // Window1 a = new Window1();
        //a.Show();
        //this.Close();
        */


        {
            string connectingString = @"Server=localhost;DATABASE=STORE_KEEPING;UID=root;PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(connectingString);
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string store_keeper_login = textBoxUser.Text;
                string store_keeper_Password = passBoxPwd.Password;
                MySqlCommand cmd = new MySqlCommand("select * from authorization where store_keeper_login = '" + store_keeper_login + "' and store_keeper_Password = '" + store_keeper_Password + "'", connection);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count > 0)
                {

                   menu a = new menu();
                    a.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Введите пароль или логин повторно!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);



            }
            finally
            {
                connection.Close();
            }
            
        }

        private void EXIT_Click(object sender, RoutedEventArgs e)
        {

        }
    }


}




      

       