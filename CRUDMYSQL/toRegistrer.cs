using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace CRUDMYSQL
{
    internal class toRegistrer
    {
        public int registrerUser(usuarios usuario)
        {
            string ConStr = "port=3306; Database= tiendita; Data Source= localhost; User Id= root; Password=";
            MySqlConnection conn = new MySqlConnection(ConStr);

            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }

            string sql = "insert into usuarios (usuario, passwords, nombre) " +
                    "VALUES (@usuario, @passwords, @nombre)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
            cmd.Parameters.AddWithValue("@passwords", usuario.Passwords);
            cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);



            int result = cmd.ExecuteNonQuery();
            return result;

        }
        public bool ifExitUser(string usuario)
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

            string sqly = "select * from usuarios Where usuario like @usuario";

            MySqlCommand cm = new MySqlCommand(sqly, conn);
            cm.Parameters.AddWithValue("@usuario", usuario);

            reader = cm.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public usuarios forUser(string usuario)
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

            string sqly = "select id, usuario, passwords from usuarios Where usuario like @usuario";

            MySqlCommand cm = new MySqlCommand(sqly, conn);
            cm.Parameters.AddWithValue("@usuario", usuario);

            reader = cm.ExecuteReader();

            usuarios usr = null;

            while (reader.Read())
            {
                usr = new usuarios();
                usr.Id = int.Parse(reader["id"].ToString());
                usr.Usuario = reader["usuario"].ToString();
                usr.Passwords = reader["passwords"].ToString();
                usr.Nombre = reader["nombre"].ToString();
            }
            return usr;

        }
    }
}
