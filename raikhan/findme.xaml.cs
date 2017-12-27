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
using System.Windows.Shapes;

namespace raikhan
{
    /// <summary>
    /// Логика взаимодействия для findme.xaml
    /// </summary>
    public partial class findme : Window
    {
        public findme()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connectingString = @"Server=localhost;DATABASE=STORE_KEEPING;UID=root;PASSWORD=root;";
            MySqlConnection connection = new MySqlConnection(connectingString);
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                string Bcode = find.Text;
               // string store_keeper_Password = passBoxPwd.Password;
                MySqlCommand cmd = new MySqlCommand("select * from barcode_table where barcode = '" + Bcode + "'", connection);
                cmd.CommandType = CommandType.Text;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    connection.Close();
                    dtGrid.DataContext = dt;

                }
                else
                {
                    MessageBox.Show("Такого баркода нет!");
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
    }
}
