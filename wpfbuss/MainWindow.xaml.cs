using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpfbuss
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 获取用户输入的用户名和密码
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            // 预设的用户名和密码
            string correctUsername = "admin";
            string correctPassword = "123456";

            // 验证用户名和密码
            if (username == correctUsername && password == correctPassword)
            {



                // 创建主界面的实例
                Window1 window1 = new Window1();

                // 显示主界面
                window1.Show();

                // 关闭登录窗口
                this.Close();
            }
            else
            {
                // 显示错误消息
                MessageBox.Show("用户名或密码错误，请重新输入！");
            }
        }

    }
}