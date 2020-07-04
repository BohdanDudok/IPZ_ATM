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

namespace IPZ_ATM_Client
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
        

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pinuser.Password.Length< 4)
            {
                Button b = (Button)sender;
                pinuser.Password += b.Content.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (pinuser.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinuser.Password += b.Content.ToString();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (pinuser.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinuser.Password += b.Content.ToString();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (pinuser.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinuser.Password += b.Content.ToString();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (pinuser.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinuser.Password += b.Content.ToString();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (pinuser.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinuser.Password += b.Content.ToString();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (pinuser.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinuser.Password += b.Content.ToString();
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (pinuser.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinuser.Password += b.Content.ToString();
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (pinuser.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinuser.Password += b.Content.ToString();
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (pinuser.Password.Length < 4)
            {
                Button b = (Button)sender;
                pinuser.Password += b.Content.ToString();
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            pinuser.Password = "";
        }
        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (pinuser.Password.Length > 0)
            {
                pinuser.Password = pinuser.Password.Substring(0, pinuser.Password.Length - 1);
            }
        }

        public void Button_Click_11(object sender, RoutedEventArgs e)
        {
            String NumberUser = numberuser.Text;
            String PinUser = pinuser.Password;

            DB db = new DB();
            DataTable table = new DataTable();

            

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `id` FROM `users` WHERE `number` = @UN AND `pin` = @UP", db.GetConnection());
                command.Parameters.Add("@UN", MySqlDbType.VarChar).Value = NumberUser;
                command.Parameters.Add("@UP", MySqlDbType.Int64).Value = PinUser;


                adapter.SelectCommand = command;
                adapter.Fill(table);
          

            if (table.Rows.Count > 0)
            {
                db.openConnection();
                string update = command.ExecuteScalar().ToString();
                int iduser = Convert.ToInt32(update);
                iduser idus = new iduser();
                idus.setiduser(iduser);
                db.closeConnection();
                MessageBox.Show("Успішний вхід!", "Повідомлення");
                Menu Menu = new Menu();
                this.Close();
                Menu.Show();
            }
            else
            {
                MessageBox.Show("Не правильний номер картки або ПІН-код!", "Повідомлення");
                pinuser.Password = "";
                numberuser.Text = "";
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

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вихід із системи успішно виконанно!", "Повідомлення");
            Main Main = new Main();
            this.Close();
            Main.Show();
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
           
        }
        
    }
}
