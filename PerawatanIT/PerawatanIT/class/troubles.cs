using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PerawatanIT
{
    class troubles : IDisposable
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

        internal void i(object comp, object cat, object compl, object compldate,
            object completeddate, object desc, object solution, object username)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("compname", MySqlDbType.VarChar).Value = comp;
                cmd.Parameters.Add("troubleid", MySqlDbType.Int32).Value = cat;
                cmd.Parameters.Add("complainby", MySqlDbType.VarChar).Value = compl;
                cmd.Parameters.Add("complaindate", MySqlDbType.Date).Value = compldate;
                cmd.Parameters.Add("completeddate", MySqlDbType.Date).Value = completeddate ?? DBNull.Value;
                cmd.Parameters.Add("desc", MySqlDbType.Text).Value = desc;
                cmd.Parameters.Add("solu", MySqlDbType.Text).Value = solution;
                cmd.Parameters.Add("username", MySqlDbType.VarChar).Value = username;

                cmd.Connection = c.Open();
                cmd.CommandText = "INSERT INTO troubles "
                    + "VALUES(null, ?compname, ?troubleid, ?complainby, ?complaindate, ?completeddate, ?desc, ?solu, ?username)";

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

        internal void u(object id, object comp, object cat, object compl, object compldate,
            object completeddate, object desc, object solution, object username)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("id", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("compname", MySqlDbType.VarChar).Value = comp;
                cmd.Parameters.Add("troubleid", MySqlDbType.Int32).Value = cat;
                cmd.Parameters.Add("complainby", MySqlDbType.VarChar).Value = compl;
                cmd.Parameters.Add("complaindate", MySqlDbType.Date).Value = compldate;
                cmd.Parameters.Add("completeddate", MySqlDbType.Date).Value = completeddate ?? DBNull.Value;
                cmd.Parameters.Add("desc", MySqlDbType.Text).Value = desc;
                cmd.Parameters.Add("solu", MySqlDbType.Text).Value = solution;
                cmd.Parameters.Add("username", MySqlDbType.VarChar).Value = username;

                cmd.Connection = c.Open();
                cmd.CommandText = "UPDATE troubles SET "
                    + "computername = ?compname, "
                    + "troubleid = ?troubleid, "
                    + "complainby = ?complainby, "
                    + "complaindate = ?complaindate, "
                    + "completeddate = ?completeddate, "
                    + "description = ?desc, "
                    + "solution = ?solu, "
                    + "username = ?username "
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
                cmd.CommandText = "DELETE FROM troubles WHERE id = ?id";

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

        internal void v(object pk, ComboBox troubleid, TextBox complainby, TextBox computername,
            DateTimePicker complain, DateTimePicker completed, TextBox description, TextBox solution)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("id", MySqlDbType.Int32).Value = pk;

                cmd.Connection = c.Open();
                cmd.CommandText = "SELECT * FROM troubles WHERE id = ?id";
                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                if (dr.HasRows)
                {
                    troubleid.SelectedValue = dr["troubleid"];
                    complainby.Text = Convert.ToString(dr["complainby"]);
                    computername.Text = Convert.ToString(dr["computername"]);
                    complain.Value = Convert.ToDateTime(dr["complaindate"]);
                    completed.Value = (dr["completeddate"] == DBNull.Value) ? DateTime.Now : Convert.ToDateTime(dr["completeddate"]);
                    description.Text = Convert.ToString(dr["description"]);
                    solution.Text = Convert.ToString(dr["solution"]);
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
            cmd.CommandText = "SELECT troubles.id AS \"ID\", computername AS \"Nama Komputer\", "
                + "trouble.description AS \"Kategori\", "
                + "complainby AS \"Pelapor\", "
                + "complaindate AS \"Tgl Lapor\", "
                + "completeddate AS \"Tgl Selesai\", "
                + "troubles.description AS \"Deskprisi Masalah\", "
                + "solution AS \"Solusi\", "
                + "username \"Troubleshooter\" "
                + "FROM troubles "
                + "INNER JOIN trouble ON troubles.troubleid = trouble.id "
                + "WHERE troubles.computername = ?id "
                + "ORDER BY complaindate, trouble.description, computername";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            c.Close();
            return da;
        }

    }
}