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
    public partial class triggerDaily : Form
    {
        public triggerDaily()
        {
            InitializeComponent();
            LoadTable(null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadTable(string data)
        {
            List<triggerDaily> list = new List<triggerDaily>();

            Control ctl = new Control();
            dataGridView1.DataSource = ctl.queryTriggerDaily(data);
        }

        private void triggerDaily_Load(object sender, EventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            registrerDairy rd = new registrerDairy();
            rd.Visible = true;
            this.Visible = false;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
