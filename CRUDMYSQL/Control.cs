using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CRUDMYSQL
{
    internal class Control
    {
        public int registrer(usuarios usuario)
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
            string sql = "START TRANSACTION; insert into usuarios (usuario, passwords, nombre)values (@usuario, @passwords, @nombre); commit;";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
            cmd.Parameters.AddWithValue("@passwords", usuario.Passwords);
            cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);

            int result = cmd.ExecuteNonQuery();

            return result;
        }

        public string ctrlRegistrer(usuarios usuario)
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

            Control ctrl = new Control();
            string response = "";
            if (string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Passwords) || string.IsNullOrEmpty(usuario.Contpasswords)
                || string.IsNullOrEmpty(usuario.Nombre))
            {
                System.Windows.Forms.MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                if (usuario.Passwords == usuario.Contpasswords)
                {
                    if (ctrl.ifExitUser(usuario.Usuario))
                    {
                        System.Windows.Forms.MessageBox.Show("El usuario ya existe");
                    }
                    else
                    {
                        usuario.Passwords = usuario.Contpasswords;
                        ctrl.registrer(usuario);
                        System.Windows.Forms.MessageBox.Show("Usuario agregado satisfactoriamente");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("la contraseña no coincide");
                }

            }
            return response;
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

            string sqly = "select id from usuarios Where usuario like @usuario";
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
            MySqlConnection conn = new MySqlConnection(ConStr);
            try
            {
                conn.Open();

            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }

            string sqly = "select id, passwords, nombre from usuarios Where usuario like @usuario";
            MySqlCommand cm = new MySqlCommand(sqly, conn);
            cm.Parameters.AddWithValue("@usuario", usuario);

            MySqlDataReader reader = cm.ExecuteReader();
            usuarios usr = null;
            while (reader.Read())
            {
                usr = new usuarios();
                usr.Id = int.Parse(reader["id"].ToString());
                usr.Passwords = reader["passwords"].ToString();
                usr.Nombre = reader["nombre"].ToString();
            }
            return usr;
        }

        public string ctrlLogin(string usuario, string passwords)
        {
            Control ctrl = new Control();
            string response = "";
            usuarios dataUser = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(passwords))
            {
                response = "Debe llenar todos los campos";
            }
            else
            {
                dataUser = ctrl.forUser(usuario);
                if (dataUser == null)
                {
                    response = "El usuario no existe";
                }
                else
                {
                    if (dataUser.Passwords != passwords)
                    {
                        response = "El usuario y/o contraseña no existen";
                    }
                }
            }
            return response;
        }

        public List<object> query(string data)
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
            string sql;

            List<object> list = new List<object>();
            if (data == null)
            {
                sql = " SELECT id, codigo, nombre, descripcion, precio_publico, existencias FROM fruts order by nombre asc";
            }
            else
            {
                sql = " SELECT id, codigo, nombre, descripcion, precio_publico, existencias FROM fruts where codigo like '%" + data +
                    "%'or nombre like '%" + data + "%' or  descripcion like '%" + data + "%'or precio_publico like '%" + data + "%'or" +
                    " descripcion like '%" + data + "%' order by n";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    fruts ft = new fruts();
                    ft.Id = int.Parse(reader["id"].ToString());
                    ft.Codigo = reader["codigo"].ToString();
                    ft.Nombre = reader["nombre"].ToString();
                    ft.Descripcion = reader["descripcion"].ToString();
                    ft.Precio_publico = double.Parse(reader["precio_publico"].ToString());
                    ft.Existencias = int.Parse(reader["existencias"].ToString());
                    list.Add(ft);
                }
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error", ex.Message);
            }
            return list;
        }

        public List<object> querySoda(string data)
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
            string sql;

            List<object> list = new List<object>();
            if (data == null)
            {
                sql = " SELECT id, codigo, nombre, descripcion, precio_publico, existencias FROM productos order by nombre asc";
            }
            else
            {
                sql = " SELECT id, codigo, nombre, descripcion, precio_publico, existencias FROM productos where codigo like '%" + data +
                    "%'or nombre like '%" + data + "%' or  descripcion like '%" + data + "%'or precio_publico like '%" + data + "%'or" +
                    " descripcion like '%" + data + "%' order by nombre asc";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    productSoda ps = new productSoda();
                    ps.Id = int.Parse(reader["id"].ToString());
                    ps.Codigo = reader["codigo"].ToString();
                    ps.Nombre = reader["nombre"].ToString();
                    ps.Descripcion = reader["descripcion"].ToString();
                    ps.Precio_publico = double.Parse(reader["precio_publico"].ToString());
                    ps.Existencias = int.Parse(reader["existencias"].ToString());
                    list.Add(ps);
                }
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error", ex.Message);
            }
            return list;
        }

        public List<object> queryMeat(string data)
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
            string sql;

            List<object> list = new List<object>();
            if (data == null)
            {
                sql = " SELECT id, codigo, nombre, descripcion, precio_publico, existencias FROM meat order by nombre asc";
            }
            else
            {
                sql = " SELECT id, codigo, nombre, descripcion, precio_publico, existencias FROM meat where codigo like '%" + data +
                    "%'or nombre like '%" + data + "%' or  descripcion like '%" + data + "%'or precio_publico like '%" + data + "%'or" +
                    " descripcion like '%" + data + "%' order by nombre asc";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    meat mt = new meat();
                    mt.Id = int.Parse(reader["id"].ToString());
                    mt.Codigo = reader["codigo"].ToString();
                    mt.Nombre = reader["nombre"].ToString();
                    mt.Descripcion = reader["descripcion"].ToString();
                    mt.Precio_publico = double.Parse(reader["precio_publico"].ToString());
                    mt.Existencias = int.Parse(reader["existencias"].ToString());
                    list.Add(mt);
                }
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error", ex.Message);
            }
            return list;
        }

        public List<object> queryDaily(string data)
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
            string sql;

            List<object> list = new List<object>();
            if (data == null)
            {
                sql = " SELECT id, codigo, nombre, descripcion, precio_publico, existencias FROM daily order by nombre asc";
            }
            else
            {
                sql = " SELECT id, codigo, nombre, descripcion, precio_publico, existencias FROM daily where codigo like '%" + data +
                    "%'or nombre like '%" + data + "%' or  descripcion like '%" + data + "%'or precio_publico like '%" + data + "%'or" +
                    " descripcion like '%" + data + "%' order by nombre asc";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    daily dy = new daily();
                    dy.Id = int.Parse(reader["id"].ToString());
                    dy.Codigo = reader["codigo"].ToString();
                    dy.Nombre = reader["nombre"].ToString();
                    dy.Descripcion = reader["descripcion"].ToString();
                    dy.Precio_publico = double.Parse(reader["precio_publico"].ToString());
                    dy.Existencias = int.Parse(reader["existencias"].ToString());
                    list.Add(dy);
                }
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error", ex.Message);
            }
            return list;
        }

        public List<object> queryDetergent(string data)
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
            string sql;

            List<object> list = new List<object>();
            if (data == null)
            {
                sql = " SELECT id, codigo, nombre, descripcion, precio_publico, existencias FROM detergent order by nombre asc";
            }
            else
            {
                sql = " SELECT id, codigo, nombre, descripcion, precio_publico, existencias FROM detergent where codigo like '%" + data +
                    "%'or nombre like '%" + data + "%' or  descripcion like '%" + data + "%'or precio_publico like '%" + data + "%'or" +
                    " descripcion like '%" + data + "%' order by nombre asc";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    fruts ft = new fruts();
                    ft.Id = int.Parse(reader["id"].ToString());
                    ft.Codigo = reader["codigo"].ToString();
                    ft.Nombre = reader["nombre"].ToString();
                    ft.Descripcion = reader["descripcion"].ToString();
                    ft.Precio_publico = double.Parse(reader["precio_publico"].ToString());
                    ft.Existencias = int.Parse(reader["existencias"].ToString());
                    list.Add(ft);
                }
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error", ex.Message);
            }
            return list;
        }

        public List<object> queryTriggerProductos(string data)
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
            string sql;

            List<object> list = new List<object>();
            if (data == null)
            {
                sql = " SELECT id, accion, fecha FROM trigger_product order by id asc";
            }
            else
            {
                sql = " SELECT id, codigo, nombre, descripcion, precio_publico, existencias FROM detergent where codigo like '%" + data +
                    "%'or nombre like '%" + data + "%' or  descripcion like '%" + data + "%'or precio_publico like '%" + data + "%'or" +
                    " descripcion like '%" + data + "%' order by nombre asc";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tggrProducts tp = new tggrProducts();
                    tp.Id = int.Parse(reader["id"].ToString());
                    tp.Accion = reader["accion"].ToString();
                    tp.Fecha = reader["fecha"].ToString();

                    list.Add(tp);
                }
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error", ex.Message);
            }
            return list;
        }

        public List<object> queryTriggerFruts(string data)
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
            string sql;

            List<object> list = new List<object>();
            if (data == null)
            {
                sql = " SELECT id, accion, fecha FROM trigger_fruts order by id asc";
            }
            else
            {
                sql = " SELECT id, codigo, nombre, descripcion, precio_publico, existencias FROM detergent where codigo like '%" + data +
                    "%'or nombre like '%" + data + "%' or  descripcion like '%" + data + "%'or precio_publico like '%" + data + "%'or" +
                    " descripcion like '%" + data + "%' order by nombre asc";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tggrFruts tf = new tggrFruts();
                    tf.Id = int.Parse(reader["id"].ToString());
                    tf.Accion = reader["accion"].ToString();
                    tf.Fecha = reader["fecha"].ToString();

                    list.Add(tf);
                }
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error", ex.Message);
            }
            return list;
        }

        public List<object> queryTriggerMeat(string data)
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
            string sql;

            List<object> list = new List<object>();
            if (data == null)
            {
                sql = " SELECT id, accion, fecha FROM trigger_meat order by id asc";
            }
            else
            {
                sql = " SELECT id, codigo, nombre, descripcion, precio_publico, existencias FROM detergent where codigo like '%" + data +
                    "%'or nombre like '%" + data + "%' or  descripcion like '%" + data + "%'or precio_publico like '%" + data + "%'or" +
                    " descripcion like '%" + data + "%' order by nombre asc";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tggrMeat tm = new tggrMeat();
                    tm.Id = int.Parse(reader["id"].ToString());
                    tm.Accion = reader["accion"].ToString();
                    tm.Fecha = reader["fecha"].ToString();

                    list.Add(tm);
                }
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error", ex.Message);
            }
            return list;
        }

        public List<object> queryTriggerDaily(string data)
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
            string sql;

            List<object> list = new List<object>();
            if (data == null)
            {
                sql = " SELECT id, accion, fecha FROM trigger_daily order by id asc";
            }
            else
            {
                sql = " SELECT id, codigo, nombre, descripcion, precio_publico, existencias FROM detergent where codigo like '%" + data +
                    "%'or nombre like '%" + data + "%' or  descripcion like '%" + data + "%'or precio_publico like '%" + data + "%'or" +
                    " descripcion like '%" + data + "%' order by nombre asc";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tggrDaily td = new tggrDaily();
                    td.Id = int.Parse(reader["id"].ToString());
                    td.Accion = reader["accion"].ToString();
                    td.Fecha = reader["fecha"].ToString();

                    list.Add(td);
                }
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error", ex.Message);
            }
            return list;
        }

        public List<object> queryTriggerDetergent(string data)
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
            string sql;

            List<object> list = new List<object>();
            if (data == null)
            {
                sql = " SELECT id, accion, fecha FROM trigger_detergent order by id asc";
            }
            else
            {
                sql = " SELECT id, codigo, nombre, descripcion, precio_publico, existencias FROM detergent where codigo like '%" + data +
                    "%'or nombre like '%" + data + "%' or  descripcion like '%" + data + "%'or precio_publico like '%" + data + "%'or" +
                    " descripcion like '%" + data + "%' order by nombre asc";
            }

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tggrdetergent td = new tggrdetergent();
                    td.Id = int.Parse(reader["id"].ToString());
                    td.Accion = reader["accion"].ToString();
                    td.Fecha = reader["fecha"].ToString();

                    list.Add(td);
                }
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Error", ex.Message);
            }
            return list;
        }

    }
}