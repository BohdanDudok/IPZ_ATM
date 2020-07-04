using MySql.Data.MySqlClient;
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

namespace IPZ_ATM_Client
{
    public partial class Cash : Window
    {
        int cash_money = 10000;
        public Cash()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashuser.Text += b.Content.ToString();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashuser.Text += b.Content.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashuser.Text += b.Content.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Menu Menu = new Menu();
            this.Close();
            Menu.Show();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {

            int cash = Convert.ToInt32(cashuser.Text);
            DB db = new DB();
            iduser idus = new iduser();
            int ID = idus.getiduser();
            String id = Convert.ToString(ID);

            MySqlCommand command = new MySqlCommand("SELECT `balance` FROM `users` WHERE `id` = @ID", db.GetConnection());
            command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
            db.openConnection();
            string balanc_user = command.ExecuteScalar().ToString();         
            int cash_user = Convert.ToInt32(balanc_user);
            Menu menu = new Menu();
            if (cash <= cash_user) {
                cash_user = cash_user - cash;
                MySqlCommand command_2 = new MySqlCommand("UPDATE `users` SET `balance` = @balance WHERE  `id` = @ID", db.GetConnection());
                command_2.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;
                command_2.Parameters.AddWithValue("balance", cash_user);
                command_2.ExecuteNonQueryAsync();
                db.closeConnection();
                MessageBox.Show("Операція здійснена успішно!");
                
                MySqlCommand command_3 = new MySqlCommand("SELECT * FROM `balance`", db.GetConnection());
                db.openConnection();
                string balanc_bankomat = command_3.ExecuteScalar().ToString();
                MySqlCommand command_4 = new MySqlCommand("UPDATE `balance` SET `balance` = @balance", db.GetConnection());
                int cash_bankomat = Convert.ToInt32(balanc_bankomat);
                cash_bankomat = cash_bankomat - cash;
                command_4.Parameters.AddWithValue("balance", cash_bankomat);
                command_4.ExecuteNonQueryAsync();
                db.closeConnection();
                this.Close();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Недостатньо коштів!");
                this.Close();
                menu.Show();
            }
            
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вихід із системи успішно виконанно!");
            Main Main = new Main();
            this.Close();
            Main.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashuser.Text += b.Content.ToString();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashuser.Text += b.Content.ToString();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            cashuser.Text = "";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (cashuser.Text.Length > 0)
            {
                cashuser.Text = cashuser.Text.Substring(0, cashuser.Text.Length - 1);
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashuser.Text += b.Content.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashuser.Text += b.Content.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashuser.Text += b.Content.ToString();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashuser.Text += b.Content.ToString();
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            cashuser.Text += b.Content.ToString();
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
