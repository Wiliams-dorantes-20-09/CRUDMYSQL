using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDMYSQL
{
    public partial class triggerProducts : Form
    {
        public triggerProducts()
        {
            InitializeComponent();
            LoadTable(null);
        }

        private void triggerProducts_Load(object sender, EventArgs e)
        {

        }

        private void LoadTable(string data)
        {
            List<tggrProducts> list = new List<tggrProducts>();

            Control ctl = new Control();
            dataGridView1.DataSource = ctl.queryTriggerProductos(data);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            RegisterProducts rp = new RegisterProducts();
            rp.Visible = true;
            this.Visible = false;
        }
    }
}
