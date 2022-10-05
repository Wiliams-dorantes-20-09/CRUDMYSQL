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


namespace CRUDMYSQL
{
    public partial class registrerDairy : Form
    {
        public registrerDairy()
        {
            InitializeComponent();
            LoadTable(null);
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string ConStr = "port=3306; Database= tiendita; Data Source= localhost; User Id= root; Password=";
            MySqlDataReader reader;
            MySqlConnection conn = new MySqlConnection(ConStr);

            try
            {
                conn.Open();

            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }

            String code = txtCodigo.Text;
            LoadTable(code);

            string sql = "SELECT id, codigo, nombre, descripcion, precio_publico, existencias FROM daily WHERE codigo LIKE '" + code + "' LIMIT 1";


            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtId.Text = reader.GetString(0);
                        txtCodigo.Text = reader.GetString(1);
                        txtNombre.Text = reader.GetString(2);
                        txtDescripcion.Text = reader.GetString(3);
                        txtPrecioPublico.Text = reader.GetString(4);
                        txtExistencias.Text = reader.GetString(5);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void registrerDairy_Load(object sender, EventArgs e)
        {

        }

        private void clean()
        {
            txtId.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecioPublico.Text = "";
            txtExistencias.Text = "";
        }

        private void LoadTable(string data)
        {
            List<daily> list = new List<daily>();

            Control ctl = new Control();
            dataGridView1.DataSource = ctl.queryDaily(data);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string ConStr = "port=3306; Database= tiendita; Data Source= localhost; User Id= root; Password=";
            MySqlDataReader reader;
            MySqlConnection conn = new MySqlConnection(ConStr);

            try
            {
                conn.Open();

            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
            try
            {
                String codigo = txtCodigo.Text;
                String nombre = txtNombre.Text;
                String descripcion = txtDescripcion.Text;
                double precio_publico = double.Parse(txtPrecioPublico.Text);
                int existencias = int.Parse(txtExistencias.Text);

                if (codigo != "" && nombre != "" && descripcion != "" && precio_publico > 0 && existencias > 0)
                {

                    string sql = "START TRANSACTION; INSERT INTO daily (codigo, nombre, descripcion, precio_publico, existencias) " +
                        "VALUES ('" + codigo + "', '" + nombre + "','" + descripcion + "','" + precio_publico + "','" + existencias + "'); commit;";

                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro guardado");
                        clean();
                        LoadTable(null);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al guardar: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Datos incorrectos: " + fex.Message);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string ConStr = "port=3306; Database= tiendita; Data Source= localhost; User Id= root; Password=";
            MySqlDataReader reader;
            MySqlConnection conn = new MySqlConnection(ConStr);

            try
            {
                conn.Open();

            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }

            String id = txtId.Text;
            String codigo = txtCodigo.Text;
            String nombre = txtNombre.Text;
            String descripcion = txtDescripcion.Text;
            double precio_publico = double.Parse(txtPrecioPublico.Text);
            int existencias = int.Parse(txtExistencias.Text);

            string sql = "START TRANSACTION; UPDATE daily SET codigo='" + codigo + "', nombre='" + nombre + "', descripcion='" + descripcion +
                "', precio_publico='" + precio_publico + "', existencias='" + existencias + "' WHERE id='" + id + "'; commit;";

            Control ctl = new Control();
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro modificado");
                clean();
                LoadTable(null);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            string ConStr = "port=3306; Database= tiendita; Data Source= localhost; User Id= root; Password=";
            MySqlDataReader reader;
            MySqlConnection conn = new MySqlConnection(ConStr);

            try
            {
                conn.Open();

            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }

            String id = txtId.Text;

            string sql = "START TRANSACTION; DELETE FROM daily WHERE id='" + id + "'; commit;";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conn);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado");
                clean();
                LoadTable(null);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Optios op = new Optios();
            op.Visible = true;
            this.Visible = false;
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            triggerDaily td = new triggerDaily();
            td.Visible = true;
            this.Visible = false;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
