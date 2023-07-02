using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalADOdotNET.BS_Layer;

namespace FinalADOdotNET
{
    public partial class fLogin : Form
    {

        #region Biến
        
        BL_Login dbLogin = new BL_Login();

        #endregion

        #region Khởi tạo 


        public fLogin()
        {
            InitializeComponent();
        }

        #endregion


        #region Hàm xử lí 

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = this.txtUserName.Text.Trim();
            string passWord = this.txtPassWord.Text.Trim();
            if (Login(userName, passWord))
            {
                fMain f = new fMain();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }

        public bool Login(string userName, string passWord)
        {
            return dbLogin.Login(userName, passWord);
        }

        #endregion

        #region Events 

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình!","Thông báo" , MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        #endregion

    }
}
