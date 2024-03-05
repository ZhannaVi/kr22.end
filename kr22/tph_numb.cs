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
    public partial class tph_numb : Form
    {
        public tph_numb()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            DialogResult result = form1.ShowDialog();
        }
    }
}
