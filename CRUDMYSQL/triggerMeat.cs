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
    public partial class triggerMeat : Form
    {
        public triggerMeat()
        {
            InitializeComponent();
            LoadTable(null);
        }

        private void triggerMeat_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void LoadTable(string data)
        {
            List<triggerMeat> list = new List<triggerMeat>();

            Control ctl = new Control();
            dataGridView1.DataSource = ctl.queryTriggerMeat(data);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            registrerMeat rm = new registrerMeat();
            rm.Visible = true;
            this.Visible = false;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
