using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PerawatanIT
{
    class category : IDisposable
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

        internal void i(object tipe, object description, object avail)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("desc", MySqlDbType.VarChar).Value = description;
                cmd.Parameters.Add("tipe", MySqlDbType.VarChar).Value = tipe;
                cmd.Parameters.Add("status", MySqlDbType.Bit).Value = avail;

                cmd.Connection = c.Open();
                cmd.CommandText = "INSERT INTO category (description, tipe, status) "
                    + "VALUES(?desc, ?tipe, ?status)";

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

        internal void u(object tipe, object description, object avail)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("desc", MySqlDbType.VarChar).Value = description;
                cmd.Parameters.Add("tipe", MySqlDbType.VarChar).Value = tipe;
                cmd.Parameters.Add("status", MySqlDbType.Bit).Value = avail;

                cmd.Connection = c.Open();
                cmd.CommandText = "UPDATE category SET tipe = ?tipe, status = ?status "
                    + "WHERE description = ?desc";

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
                cmd.Parameters.Add("desc", MySqlDbType.VarChar).Value = pk;

                cmd.Connection = c.Open();
                cmd.CommandText = "DELETE FROM category WHERE description = ?desc";

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

        internal void v(object pk, ComboBox tipe, CheckBox status)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("desc", MySqlDbType.VarChar).Value = pk;

                cmd.Connection = c.Open();
                cmd.CommandText = "SELECT * FROM category WHERE description = ?desc";
                MySqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    tipe.SelectedItem = Convert.ToString(dr["tipe"]);
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
            cmd.CommandText = "SELECT tipe AS \"Tipe\", description AS \"Deskprisi\", status AS \"Status\" FROM category ORDER BY tipe, description";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            c.Close();
            return da;
        }

    }
}
