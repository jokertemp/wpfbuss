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
using System.Data.SqlClient;
using System.Data;

namespace wpfbuss
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {   //数据库字符串
        string connectionString = "Initial Catalog=Business;User ID=admin;Password=123456";

        public Window1()
        {
            InitializeComponent();
            

        }
        private DataTable GetData(string sql)
        {
            // 创建一个DataTable来存储数据
            DataTable dataTable = new DataTable();
            
            // SQL查询语句，你需要修改为你的实际查询
           // string sql = "SELECT * FROM 支出表 ";

            // 创建SqlConnection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // 创建SqlCommand
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // 打开连接
                    connection.Open();

                    // 执行查询并填充到DataTable
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }

            return dataTable;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 获取数据
            DataTable dataTable = GetData("SELECT * FROM 支出表 ");

            // 绑定到DataGrid
            dataGrid.ItemsSource = dataTable.DefaultView;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // 获取数据
            DataTable dataTable = GetData("SELECT * FROM 收入表 ");

            // 绑定到DataGrid
            dataGrid.ItemsSource = dataTable.DefaultView;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            // 显示主界面
            window2.Show();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            Window2 window2 = new Window2();
            // 显示主界面
            window2.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            // 显示主界面
            window2.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            // 获取数据
            DataTable dataTable = GetData("SELECT * FROM 员工信息表 ");

            // 绑定到DataGrid
            dataGrid.ItemsSource = dataTable.DefaultView;
        }
    }
}
