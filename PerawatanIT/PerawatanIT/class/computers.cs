using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PerawatanIT
{
    class computers : IDisposable
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

/*        internal string a()
        {
            string resultID = null;
            cmd.CommandText = "SELECT id FROM computers "
                + "WHERE id LIKE 'PC-%' ORDER BY id DESC LIMIT 1";
            cmd.Connection = c.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            if (!dr.HasRows)
            {
                resultID = "PC-0001";
            }
            else
            {
                string src = Convert.ToString(dr["id"]).Substring(4);
                int X = Convert.ToInt32(src) + 1;
                switch (X.ToString().Length)
                {
                    case 1:
                        resultID = string.Format("PC-000{0}", X);
                        break;
                    case 2:
                        resultID = string.Format("PC-00{0}", X);
                        break;
                    case 3:
                        resultID = string.Format("PC-0{0}", X);
                        break;
                    case 4:
                        resultID = string.Format("PC-{0}", X);
                        break;
                }
            }
            c.Close();
            return resultID;
        }*/

        internal void i(object computername, object location, object user, object status)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("compname", MySqlDbType.VarChar).Value = computername;
                cmd.Parameters.Add("loc", MySqlDbType.VarChar).Value = location;
                cmd.Parameters.Add("user", MySqlDbType.VarChar).Value = user;
                cmd.Parameters.Add("status", MySqlDbType.Bit).Value = status;

                cmd.Connection = c.Open();
                cmd.CommandText = "INSERT INTO computers (computername, location, user, status) "
                    + "VALUES(?compname, ?loc, ?user, ?status)";

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

        internal void u(object computername, object location, object user, object status)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("compname", MySqlDbType.VarChar).Value = computername;
                cmd.Parameters.Add("loc", MySqlDbType.VarChar).Value = location;
                cmd.Parameters.Add("user", MySqlDbType.VarChar).Value = user;
                cmd.Parameters.Add("status", MySqlDbType.Bit).Value = status;

                cmd.Connection = c.Open();
                cmd.CommandText = "UPDATE computers SET location = ?loc, user = ?user, status = ?status "
                    + "WHERE computername = ?compname";

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
                cmd.Parameters.Add("comp", MySqlDbType.VarChar).Value = pk;

                cmd.Connection = c.Open();
                cmd.CommandText = "DELETE FROM computers WHERE computername = ?comp";

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

        internal void v(object pk, ComboBox location, TextBox user, CheckBox status)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("comp", MySqlDbType.VarChar).Value = pk;

                cmd.Connection = c.Open();
                cmd.CommandText = "SELECT * FROM computers WHERE computername = ?comp";
                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                if (dr.HasRows)
                {
                    location.SelectedItem = Convert.ToString(dr["location"]);
                    user.Text = Convert.ToString(dr["user"]);
                    status.Checked = Convert.ToBoolean(dr["status"]);

                }
                dr.Close();

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
            cmd.CommandText = "SELECT computername AS \"Nama Komputer\", location AS \"Lokasi\", user AS \"User\", status AS \"Status\" "
                + "FROM computers ORDER BY computername, location";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            c.Close();
            return da;
        }

        internal MySqlDataAdapter DAShowInstalled(object komputer)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.Add("komputer", MySqlDbType.VarChar).Value = komputer;

            cmd.Connection = c.Open();
            cmd.CommandText = "SELECT installation.id, tipe, category, items.description, serialno, installdate, uninstalldate FROM installation " 
                + "INNER JOIN items ON installation.itemid = items.id " 
                + "INNER JOIN category ON items.category = category.description "
                + "WHERE computername = ?komputer "
                + "ORDER BY tipe, category, items.description";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            c.Close();
            return da;
        }
    }
}