using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PerawatanIT
{
    class items : IDisposable
    {
        connection c = new connection();
        MySqlCommand cmd = new MySqlCommand();

        public void Dispose()
        {
            if (c != null)
            {
                c.Dispose();
                c = null;
            }
            if (cmd != null)
            {
                cmd.Dispose();
                cmd = null;
            }
        }

        internal string a(object kategori)
        {
            string cat = kategori.ToString().Substring(0, 1);
            string resultID = null;
            cmd.CommandText = string.Format("SELECT itemid FROM items " 
                + "WHERE itemid LIKE '{0}-%' ORDER BY itemid DESC LIMIT 1", cat);
            cmd.Connection = c.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (!dr.HasRows)
            {
                resultID = string.Format("{0}-0001", cat);
            }
            else
            {
                string src = Convert.ToString(dr["id"]).Substring(2);
                int X = Convert.ToInt32(src) + 1;
                switch (X.ToString().Length)
                {
                    case 1:
                        resultID = string.Format("{0}-000{1}", cat, X);
                        break;
                    case 2:
                        resultID = string.Format("{0}-00{1}", cat, X);
                        break;
                    case 3:
                        resultID = string.Format("{0}-0{1}", cat, X);
                        break;
                    case 4:
                        resultID = string.Format("{0}-{1}", cat, X);
                        break;
                }
            }
            c.Close();
            return resultID;
        }

        internal void i(object id, object kategori, object description, object status)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("id", MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("kategori", MySqlDbType.VarChar).Value = kategori;
                cmd.Parameters.Add("desc", MySqlDbType.VarChar).Value = description;
                cmd.Parameters.Add("status", MySqlDbType.Bit).Value = status;

                cmd.Connection = c.Open();
                cmd.CommandText = "INSERT INTO items (itemid, category, description, status) "
                    + "VALUES(?id, ?kategori, ?desc, ?status)";

                cmd.ExecuteNonQuery();

                Program.MsgInfo("Data berhasil disimpan.");

            }
            catch (Exception ex)
            {
                Program.MsgError(ex.Message);
            }
            finally
            {
                c.Close();
            }
        }

        internal void u(object id, object kategori, object description, object status)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("id", MySqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("kategori", MySqlDbType.VarChar).Value = kategori;
                cmd.Parameters.Add("desc", MySqlDbType.VarChar).Value = description;
                cmd.Parameters.Add("status", MySqlDbType.Bit).Value = status;

                cmd.Connection = c.Open();
                cmd.CommandText = "UPDATE items SET category = ?kategori, "
                    + "description = ?desc, status = ?status "
                    + "WHERE itemid = ?id";

                cmd.ExecuteNonQuery();

                Program.MsgInfo("Data berhasil diubah.");

            }
            catch (Exception ex)
            {
                Program.MsgError(ex.Message);
            }
            finally
            {
                c.Close();
            }
        }

        internal void d(object pk)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("id", MySqlDbType.VarChar).Value = pk;

                cmd.Connection = c.Open();
                cmd.CommandText = "DELETE FROM items WHERE itemid = ?id";

                cmd.ExecuteNonQuery();

                Program.MsgInfo("Data berhasil dihapus.");
            }
            catch (Exception ex)
            {
                Program.MsgError(ex.Message);
            }
            finally
            {
                c.Close();
            }
        }

        internal void v(object pk, ComboBox kategori, TextBox description, CheckBox status)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("id", MySqlDbType.VarChar).Value = pk;

                cmd.Connection = c.Open();
                cmd.CommandText = "SELECT * FROM items WHERE itemid = ?id";
                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                if (dr.HasRows)
                {
                    kategori.SelectedValue = Convert.ToString(dr["category"]);
                    description.Text = Convert.ToString(dr["description"]);
                    status.Checked = Convert.ToBoolean(dr["status"]);
                }

            }
            catch (Exception ex)
            {
                Program.MsgError(ex.Message);
            }
            finally
            {
                c.Close();
            }
        }

        internal MySqlDataAdapter DAShow()
        {
            cmd.Connection = c.Open();
            cmd.CommandText = "SELECT itemid AS \"ID\", "
                + "category AS \"Kategori\", " 
                + "description AS \"Nama\", " 
                + "status AS \"Status\" "
                + "FROM items " //INNER JOIN category ON items.category = category.id " 
                + "ORDER BY description";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            c.Close();
            return da;
        }

    }
}