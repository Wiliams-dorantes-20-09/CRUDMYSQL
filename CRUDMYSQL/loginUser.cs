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
    public partial class loginUser : Form
    {
        public loginUser()
        {
            InitializeComponent();
        }


        public void clean()
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void loginUser_Load(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string passwords = txtPass.Text;
            try
            {
                Control ctl = new Control();
                string respons = ctl.ctrlLogin(usuario, passwords);
                if (respons.Length > 0)
                {
                    MessageBox.Show(respons, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clean();
                }

                else
                {
                    Optios op = new Optios();
                    op.Visible = true;
                    this.Visible = false;
                    clean();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                clean();
            }
            finally
            {

            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Registrer rs = new Registrer();
            rs.Visible = true;
            this.Visible = false;
        }
    }
}
