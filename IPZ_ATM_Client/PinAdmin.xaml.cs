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
    /// Логика взаимодействия для PinAdmin.xaml
    /// </summary>
    public partial class PinAdmin : Window
    {
        public PinAdmin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pinadmin.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinadmin.Password += b.Content.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (pinadmin.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinadmin.Password += b.Content.ToString();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (pinadmin.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinadmin.Password += b.Content.ToString();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (pinadmin.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinadmin.Password += b.Content.ToString();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (pinadmin.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinadmin.Password += b.Content.ToString();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (pinadmin.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinadmin.Password += b.Content.ToString();
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (pinadmin.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinadmin.Password += b.Content.ToString();
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (pinadmin.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinadmin.Password += b.Content.ToString();
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (pinadmin.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinadmin.Password += b.Content.ToString();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (pinadmin.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinadmin.Password += b.Content.ToString();
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            pinadmin.Password = "";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (pinadmin.Password.Length > 0)
            {
                pinadmin.Password = pinadmin.Password.Substring(0, pinadmin.Password.Length - 1);
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            String NumberAdmin = numberadmin.Text;
            String PinAdmin = pinadmin.Password;

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `admin` WHERE `number` = @UN AND `pin` = @UP", db.GetConnection());
            command.Parameters.Add("@UN", MySqlDbType.Int64).Value = NumberAdmin;
            command.Parameters.Add("@UP", MySqlDbType.Int64).Value = PinAdmin;

            adapter.SelectCommand = command;
            adapter.Fill(table);

        
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Успішний вхід!", "Повідомлення");
                MenuAdmin MenuAdmin = new MenuAdmin();
                this.Close();
                MenuAdmin.Show();
            }
            else
            {
                MessageBox.Show("Не правильний номер  або ПІН-код адміністратора!", "Повідомлення");
                pinadmin.Password = "";
                numberadmin.Text = "";
            }
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

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вихід із системи успішно виконанно!", "Повідомлення");
            Main Main = new Main();
            this.Close();
            Main.Show();
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {

        }
    }
}
