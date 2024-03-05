using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;       // EXCEL APPLICATION.
using System.Drawing;

namespace kr22
{
    public partial class Products : Form
    {
        DataSet ds;
        public Products()
        {
            InitializeComponent();
            if (Auth_class.auth == true)
            {
                exp_btn.Visible = true;
            }
            //btncheck.Click += new EventHandler(btncheck_Click);
            //dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridView1.AllowUserToAddRows = false;
            //ds = new DataSet();
        }

        private void btnhome2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            DialogResult result= form1.ShowDialog();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            prod_table.ColumnCount = 3;
            prod_table.Columns[0].Name = "Name";
            prod_table.Columns[1].Name = "Price";
            prod_table.Columns[2].Name = "Age";
            string[] row;
            string[] rowData =
            {
                    "Leage of legends","free","12+",
                    "The Sims 4","1400rub","18+",
                    "WorldOfTanks","free","18+"
            };

            for (int i = 0; i < rowData.Length; i += 3)
            {
                row = new string[]
                {
                    rowData[i],rowData[i+1],rowData[i+2]
                };
            }

            for (int i = 0; i < rowData.Length; i += 3)
            {
                row = new string[] { rowData[i], rowData[i + 1], rowData[i + 2]};
                prod_table.Rows.Add(row);
            }

            prod_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void exp_btn_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            app.SheetsInNewWorkbook = 1;
            app.Workbooks.Add();
            Excel.Worksheet ws = app.Worksheets[1];
            ws.Name = "Каталог товаров";

            ws.Cells[1,1] = prod_table.Columns[0].HeaderCell.Value;
            ws.Cells[1,2] = prod_table.Columns[1].HeaderCell.Value;
            ws.Cells[1,3] = prod_table.Columns[2].HeaderCell.Value;

            for (int i = 2; i < 5;i++)
            {
                ws.Cells[i, 1] = prod_table[0,i - 2].Value;
                ws.Cells[i, 2] = prod_table[1, i - 2].Value;
                ws.Cells[i, 3] = prod_table[2, i - 2].Value;
            }

            app.Visible = true;
        }
    }
}
