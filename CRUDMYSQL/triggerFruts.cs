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
    public partial class triggerFruts : Form
    {
        public triggerFruts()
        {
            InitializeComponent();
            LoadTable(null);
        }

        private void triggerFruts_Load(object sender, EventArgs e)
        {

        }

        private void LoadTable(string data)
        {
            List<tggrFruts> list = new List<tggrFruts>();

            Control ctl = new Control();
            dataGridView1.DataSource = ctl.queryTriggerFruts(data);
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            RegisterFruts rf = new RegisterFruts();
            rf.Visible = true;
            this.Visible = false;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
