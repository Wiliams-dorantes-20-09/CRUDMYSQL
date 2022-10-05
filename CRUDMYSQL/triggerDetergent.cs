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
    public partial class triggerDetergent : Form
    {
        public triggerDetergent()
        {
            InitializeComponent();
            LoadTable(null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadTable(string data)
        {
            List<triggerDetergent> list = new List<triggerDetergent>();

            Control ctl = new Control();
            dataGridView1.DataSource = ctl.queryTriggerDetergent(data);
        }

        private void triggerDetergent_Load(object sender, EventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            registrerDetergent rde = new registrerDetergent();
            rde.Visible = true;
            this.Visible = false;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
