using MySql.Data.MySqlClient;
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
    public partial class Optios : Form
    {
        public Optios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterFruts rf = new RegisterFruts();
            rf.Visible = true;
            this.Visible = false;
        }

        private void Optios_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterProducts rp = new RegisterProducts();
            rp.Visible = true;
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            registrerMeat rm = new registrerMeat();
            rm.Visible = true;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            registrerDairy rd = new registrerDairy();
            rd.Visible = true;
            this.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            registrerDetergent rde = new registrerDetergent();
            rde.Visible = true;
            this.Visible = false;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string ConStr = "port=3306; Database= tiendita; Data Source= localhost; User Id= root; Password= ;";

            string rute = @"D:\Documents\Visual Studio 2022\CRUDMYSQL\respaldos\respaldo_base.sql";

            MySqlConnection conn = new MySqlConnection(ConStr);
            MySqlCommand cmd = new MySqlCommand();
            MySqlBackup bkp = new MySqlBackup(cmd);

            cmd.Connection = conn;
            conn.Open();
            bkp.ExportToFile(rute);
            conn.Close();
            MessageBox.Show("Respaldo guardado satisfactoriamente");
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            loginUser lg = new loginUser();
            lg.Visible = true;
            this.Visible = false;
        }
    }
}
