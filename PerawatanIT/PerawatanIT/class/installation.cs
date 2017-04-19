using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PerawatanIT
{
    class installation : IDisposable
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

        internal void i(object komputer, object itemid, object serialno, object install, object uninstall)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("komputer", MySqlDbType.VarChar).Value = komputer;
                cmd.Parameters.Add("itemid", MySqlDbType.VarChar).Value = itemid;
                cmd.Parameters.Add("serialno", MySqlDbType.VarChar).Value = serialno;
                cmd.Parameters.Add("install", MySqlDbType.Date).Value = install ?? DBNull.Value;
                cmd.Parameters.Add("uninstall", MySqlDbType.Date).Value = uninstall ?? DBNull.Value;

                cmd.Connection = c.Open();
                cmd.CommandText = "INSERT INTO installation (computerid, itemid, serialno, installdate, uninstalldate) "
                    + "VALUES(?komputer, ?itemid, ?serialno, ?install, ?uninstall)";

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

        internal void u(object id, object serialno, object install, object uninstall)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("id", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("serialno", MySqlDbType.VarChar).Value = serialno;
                cmd.Parameters.Add("install", MySqlDbType.Date).Value = install ?? DBNull.Value;
                cmd.Parameters.Add("uninstall", MySqlDbType.Date).Value = uninstall ?? DBNull.Value;


                cmd.Connection = c.Open();
                cmd.CommandText = "UPDATE installation SET serialno = ?serialno, " 
                    + "installdate = ?install, uninstalldate = ?uninstall "
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
                cmd.CommandText = "DELETE FROM installation WHERE id = ?id";

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

        internal void v(object pk, ComboBox kategori, ComboBox item, TextBox serialno, DateTimePicker install, DateTimePicker uninstall)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("id", MySqlDbType.Int32).Value = pk;

                cmd.Connection = c.Open();
                cmd.CommandText = "SELECT itemid, category, serialno, installdate, uninstalldate FROM installation " 
                    + "INNER JOIN items ON items.id = installation.itemid "
                    + "WHERE installation.id = ?id";
                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                if (dr.HasRows)
                {
                    kategori.SelectedValue = Convert.ToString(dr["category"]);
                    item.SelectedValue = Convert.ToString(dr["itemid"]);
                    serialno.Text = Convert.ToString(dr["serialno"]);
                    install.Value = Convert.ToDateTime(dr["installdate"]);
                    uninstall.Value = Convert.ToDateTime(dr["uninstalldate"]);
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

        internal MySqlDataAdapter DAShow(object komputerid)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.Add("id", MySqlDbType.VarChar).Value = komputerid;

            cmd.Connection = c.Open();
            cmd.CommandText = "SELECT id AS \"ID\", installation.computername AS \"Nama Komputer\", " 
                + "computers.location AS \"Lokasi\", " 
                + "tipe AS \"Tipe\", "
                + "category.description AS \"Kategori\", "
                + "items.description AS \"Item\", "
                + "serialno AS \"Serial No\", "
                + "installdate AS \"Tgl Install\", "
                + "uninstalldate AS \"Tgl Uninstall\", "
                + "installation.username AS \"Diinstall Oleh\" "
                + "FROM installation "
                + "INNER JOIN computers ON computers.computername = installation.computername "
                + "INNER JOIN items ON items.itemid = installation.itemid "
                + "INNER JOIN category ON items.category = category.description "
                + "WHERE installation.computername = ?id "
                + "ORDER BY installation.computername, computers.location, tipe, category.description";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            c.Close();
            return da;
        }

    }
}