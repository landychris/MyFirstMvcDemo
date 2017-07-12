using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstMvcDemo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);//这是最彻底的退出方式，不管什么线程都被强制退出，把程序结束的很干净。
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;    //返回一个登录成功的对话框状态
            this.Dispose();
            this.Close();    //关闭登录窗口
        }
        private void keyPress_login(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                button1_Click(sender, e);
            }
        }
    }
}
