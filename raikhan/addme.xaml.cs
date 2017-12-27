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

    public partial class addme : Window
    {
        public addme()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connectingString = "Server = localhost; DATABASE= STORE_KEEPING;UID=root; PASSWORD=root;  ";
        MySqlConnection connection = new MySqlConnection(connectingString);
        connection.Open();
            DateTime times = DateTime.Now;
            string date_of_supply = times.ToString("yyyy-MM-dd H:mm:ss");
            string barcode = bcode.Text;
            string providering_company = company.Text;
            string name_of_product = product.Text;
            int amount_of_product = Convert.ToInt32(amount.Text);
            int balance =Convert.ToInt32(bal.Text);
            MySqlCommand cmd = new MySqlCommand("insert into stock_base (barcode,providering_company,name_of_product,amount_of_product,balance,date_of_supply)"+
            "value ('" +barcode+"',"+"'"+providering_company+"',"+"'"+name_of_product+"','"+amount_of_product+"'"+",'"+balance+"'"+",'"+date_of_supply+"');",connection);
        DataTable dt = new DataTable();
        dt.Load(reader: cmd.ExecuteReader());
        connection.Close();
        
        this.Close();
        }
    }
}
