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

namespace IPZ_ATM_Client
{
    /// <summary>
    /// Логика взаимодействия для CashAdmin.xaml
    /// </summary>
    public partial class CashAdmin : Window
    {
        public CashAdmin()
        {
            InitializeComponent();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MenuAdmin menuadmin = new MenuAdmin();
            this.Close();
            menuadmin.Show();
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {

        }

        private  void Button_Click_11(object sender, RoutedEventArgs e)
        {
            int cash = Convert.ToInt32(cashadmin.Text);
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `balance`", db.GetConnection());
            db.openConnection();
            string balanc = command.ExecuteScalar().ToString();
            MySqlCommand command_2 = new MySqlCommand("UPDATE `balance` SET `balance` = @balance", db.GetConnection());
            int cash_2 = Convert.ToInt32(balanc);
            cash = cash + cash_2;
            command_2.Parameters.AddWithValue("balance", cash);
            command_2.ExecuteNonQueryAsync();
            db.closeConnection();
            MessageBox.Show("Операція здійснена успішно!");
            MenuAdmin menu = new MenuAdmin();
            this.Close();
            menu.Show();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            Main main = new Main();
            this.Close();
            main.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashadmin.Text += b.Content.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashadmin.Text += b.Content.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashadmin.Text += b.Content.ToString();
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashadmin.Text += b.Content.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashadmin.Text += b.Content.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashadmin.Text += b.Content.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashadmin.Text += b.Content.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashadmin.Text += b.Content.ToString();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashadmin.Text += b.Content.ToString();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashadmin.Text += b.Content.ToString();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            cashadmin.Text = "";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (cashadmin.Text.Length > 0)
            {
                cashadmin.Text = cashadmin.Text.Substring(0, cashadmin.Text.Length - 1);
            }
        }
    }
}
