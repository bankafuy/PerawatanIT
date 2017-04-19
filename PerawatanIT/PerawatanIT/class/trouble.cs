using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace PerawatanIT
{
    class trouble : IDisposable
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

        internal void i(string description)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("desc", MySqlDbType.VarChar).Value = description;

                cmd.Connection = c.Open();
                cmd.CommandText = "INSERT INTO trouble (description) "
                    + "VALUES(?desc)";

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

        internal void u(object id, object description)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("id", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("desc", MySqlDbType.VarChar).Value = description;

                cmd.Connection = c.Open();
                cmd.CommandText = "UPDATE trouble SET description = ?desc "
                    + "WHERE id = ?id";

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
                cmd.Parameters.Add("id", MySqlDbType.Int32).Value = pk;

                cmd.Connection = c.Open();
                cmd.CommandText = "DELETE FROM trouble WHERE id = ?id";

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

        internal void v(object pk, System.Windows.Forms.TextBox description)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("id", MySqlDbType.Int32).Value = pk;

                cmd.Connection = c.Open();
                cmd.CommandText = "SELECT * FROM trouble WHERE id = ?id";
                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                if (dr.HasRows)
                {
                    description.Text = Convert.ToString(dr["description"]);
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
            cmd.CommandText = "SELECT id AS \"ID\", description AS \"Deskprisi\"  FROM trouble ORDER BY description";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            c.Close();
            return da;
        }

    }
}