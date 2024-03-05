using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kr22
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void auth_btn_Click(object sender, EventArgs e)
        {

            if (logintxt.Text != "admin" || pastxt.Text != "QweRt098")
            {
                logintxt.Clear();
                pastxt.Clear();
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Вы успешно авторизовались!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Auth_class.auth = true;
                this.Close();
            }
        }
    }
}
