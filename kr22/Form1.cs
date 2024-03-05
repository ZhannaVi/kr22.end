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
    public partial class Form1 : Form
    {
        private Form1 form1;
        public Form1()
        {
            InitializeComponent();
        }

        private void avtbtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            DialogResult result = loginForm.ShowDialog();
        }

        private void contactsForYourMotherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tph_numb tph_Numb = new tph_numb();
            DialogResult result = tph_Numb.ShowDialog();
        }

        private void продукцияMenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            DialogResult dialogResult = products.ShowDialog();
        }

        private void ПшелToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ты точно хочешь лишиться единственного, что тебя может радовать?", "Останься..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
