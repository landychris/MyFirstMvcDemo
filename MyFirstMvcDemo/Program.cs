using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstMvcDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login login = new Login();
            login.ShowDialog();
            if(login.DialogResult == DialogResult.OK)
            {
                login.Dispose();
                Application.Run(new Main()); //打开主窗口
            }
            else
            {
                return;
            } 
        }
    }
}
