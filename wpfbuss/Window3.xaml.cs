using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace wpfbuss
{
    /// <summary>
    /// Window3.xaml 的交互逻辑
    /// </summary>
    public partial class Window3 : Window
    {
        string connectionString = "Initial Catalog=Business;User ID=admin;Password=123456";
        public Window3()
        {
            InitializeComponent();
            this.DataContext = new dataModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var model = this.DataContext as dataModel;

            string sql = "";
            if (IncomeRadioButton.IsChecked == true)
            {
                sql = $"DELETE FROM 收入表 WHERE 收入ID = '{model.Id}'";
            }
            else if (ExpenseRadioButton.IsChecked == true)
            {
                sql = $"DELETE FROM 支出表 WHERE 支出ID = '{model.Id}'";
            }
            else
            {
                MessageBox.Show("未选择收入或支出表");
            }
            try
            {
                Dispose(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("输入格式有误");
            }
            this.Close();
        }
        public void Dispose(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
