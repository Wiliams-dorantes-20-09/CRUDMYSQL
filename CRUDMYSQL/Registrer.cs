using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Text.RegularExpressions;

namespace CRUDMYSQL
{
    public partial class Registrer : Form
    {
        public Registrer()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (validateFields()) { 
                usuarios user = new usuarios();
                user.Usuario = textBox1.Text;
                user.Passwords = textBox2.Text;
                user.Contpasswords = textBox3.Text;
                user.Nombre = textBox5.Text;
                

                if (isValidPassword(textBox2.Text) == true && isValidUser(textBox1.Text) == true && isValidName(textBox5.Text) == true) {
                    usuarios usr = new usuarios();
                    usr.Usuario = textBox1.Text;
                    usr.Passwords = textBox2.Text;
                    usr.Contpasswords = textBox3.Text;
                    usr.Nombre = textBox5.Text;
                    Control ctrl = new Control();
                    ctrl.ctrlRegistrer(usr);
                    Clean();
                }
                Clean();
            }
        }

        private void Clean()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginUser lg = new loginUser();
            lg.Visible = true;
            this.Visible = false;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registrer_Load(object sender, EventArgs e)
        {
        }

        private bool validateFields()
        {
            bool ok = true;
            if (textBox2.Text == "")
            {
                ok = false;
            }

            else if (isValidPassword(textBox2.Text) == false)
            {
                MessageBox.Show("La contraseña debe contener al menos 8 caracteres Minusculas, Mayusculas, numeros y simbolos");
            }

            if (textBox1.Text == "")
            {
                ok = false;
            }

            else if (isValidUser(textBox1.Text) == false)
            {
                MessageBox.Show("El usuario debe contener solo letras");
            }

            if (textBox1.Text == "")
            {
                ok = false;
            }

            else if (isValidName(textBox5.Text) == false)
            {
                MessageBox.Show("El nombre debe contener solo letras");
            }
            return ok;
        }

        public bool isValidPassword(string plainText)
        {
            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            Match match = regex.Match(plainText);
            return match.Success;
        }

        public bool isValidUser(string plainText)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            Match match = regex.Match(plainText);
            return match.Success;
        }

        public bool isValidName(string plainText)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+$");
            Match match = regex.Match(plainText);
            return match.Success;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
