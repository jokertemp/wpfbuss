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
    /// Window4.xaml 的交互逻辑
    /// </summary>
    public partial class Window4 : Window
    {
        string connectionString = "Initial Catalog=Business;User ID=admin;Password=123456";
        public Window4()
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
                sql = $"UPDATE 收入表 SET 日期 = '{model.Date.ToString("yyyy-MM-dd")}', 金额 = {model.Amount}, 记录人 = '{model.Recorder}', 备注 = '{model.Note}' , 收入ID = '{model.Id}'WHERE 收入ID = '{model.YId}'";
            }
            else if (ExpenseRadioButton.IsChecked == true)
            {
                sql = $"UPDATE 支出表 SET 日期 = '{model.Date.ToString("yyyy-MM-dd")}', 金额 = {model.Amount}, 记录人 = '{model.Recorder}', 备注 = '{model.Note}',支出ID = '{model.Id}' WHERE 支出ID = '{model.YId}'";
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
