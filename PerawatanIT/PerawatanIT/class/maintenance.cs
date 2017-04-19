using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PerawatanIT
{
    class maintenance : IDisposable
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

        internal void i(object computername, object maintenancedate, object mb, object proces, 
            object hdd, object dvd, object vga, object ps, object casing, object keyboard, object mouse, object nic,
            object os, object av, object lastupdate, object notes, object username)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("computername", MySqlDbType.VarChar).Value = computername;
                cmd.Parameters.Add("maintenancedate", MySqlDbType.Date).Value = maintenancedate;
                cmd.Parameters.Add("motherboard", MySqlDbType.Bit, 1).Value = mb;
                cmd.Parameters.Add("processor", MySqlDbType.Bit, 1).Value = proces;
                cmd.Parameters.Add("hdd", MySqlDbType.Bit, 1).Value = hdd;
                cmd.Parameters.Add("discdrive", MySqlDbType.Bit, 1).Value = dvd;
                cmd.Parameters.Add("vga", MySqlDbType.Bit, 1).Value = vga;
                cmd.Parameters.Add("powersupply", MySqlDbType.Bit, 1).Value = ps;
                cmd.Parameters.Add("casing", MySqlDbType.Bit, 1).Value = casing;
                cmd.Parameters.Add("keyboard", MySqlDbType.Bit, 1).Value = keyboard;
                cmd.Parameters.Add("mouse", MySqlDbType.Bit, 1).Value = mouse;
                cmd.Parameters.Add("lancard", MySqlDbType.Bit, 1).Value = nic;
                cmd.Parameters.Add("os", MySqlDbType.Bit, 1).Value = os;
                cmd.Parameters.Add("av", MySqlDbType.Bit, 1).Value = av;
                cmd.Parameters.Add("avlastupdate", MySqlDbType.Date).Value = lastupdate;
                cmd.Parameters.Add("notes", MySqlDbType.Text).Value = notes;
                cmd.Parameters.Add("username", MySqlDbType.VarChar).Value = username;
                cmd.Connection = c.Open();
                cmd.CommandText = "INSERT INTO maintenance "
                    + "VALUES(null, ?computername, ?maintenancedate, ?motherboard, ?processor, " 
                    + "?hdd, ?discdrive, ?vga, ?powersupply, ?casing, ?keyboard, ?mouse, ?lancard, " 
                    + "?os, ?av, ?avlastupdate, ?notes, ?username)";

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

        internal void u(object id, object computername, object maintenancedate, object mb, object proces,
            object hdd, object dvd, object vga, object ps, object casing, object keyboard, object mouse, object nic,
            object os, object av, object lastupdate, object notes, object username)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("id", MySqlDbType.Int32).Value = id;
                cmd.Parameters.Add("computername", MySqlDbType.VarChar).Value = computername;
                cmd.Parameters.Add("maintenancedate", MySqlDbType.Date).Value = maintenancedate;
                cmd.Parameters.Add("motherboard", MySqlDbType.Bit, 1).Value = mb;
                cmd.Parameters.Add("processor", MySqlDbType.Bit, 1).Value = proces;
                cmd.Parameters.Add("hdd", MySqlDbType.Bit, 1).Value = hdd;
                cmd.Parameters.Add("discdrive", MySqlDbType.Bit, 1).Value = dvd;
                cmd.Parameters.Add("vga", MySqlDbType.Bit, 1).Value = vga;
                cmd.Parameters.Add("powersupply", MySqlDbType.Bit, 1).Value = ps;
                cmd.Parameters.Add("casing", MySqlDbType.Bit, 1).Value = casing;
                cmd.Parameters.Add("keyboard", MySqlDbType.Bit, 1).Value = keyboard;
                cmd.Parameters.Add("mouse", MySqlDbType.Bit, 1).Value = mouse;
                cmd.Parameters.Add("lancard", MySqlDbType.Bit, 1).Value = nic;
                cmd.Parameters.Add("os", MySqlDbType.Bit, 1).Value = os;
                cmd.Parameters.Add("av", MySqlDbType.Bit, 1).Value = av;
                cmd.Parameters.Add("avlastupdate", MySqlDbType.Date).Value = lastupdate;
                cmd.Parameters.Add("notes", MySqlDbType.Text).Value = notes;
                cmd.Parameters.Add("username", MySqlDbType.VarChar).Value = username;

                cmd.Connection = c.Open();
                cmd.CommandText = "UPDATE maintenance SET "
                    + "computername = ?computername, "
                    + "maintenancedate = ?maintenancedate, "
                    + "motherboard = ?motherboard, "
                    + "processor = ?processor, "
                    + "hdd = ?hdd, "
                    + "discdrive = ?discdrive, " 
                    + "vga = ?vga, "
                    + "powersupply = ?powersupply, "
                    + "casing = ?casing, "
                    + "keyboard = ?keyboard, "
                    + "mouse = ?mouse, "
                    + "lancard = ?lancard, "
                    + "os = ?os, " 
                    + "av = ?av, " 
                    + "avlastupdate = ?avlastupdate, " 
                    + "notes = ?notes, " 
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
                cmd.CommandText = "DELETE FROM maintenance WHERE id = ?id";

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

        internal void v(object pk, TextBox computername, DateTimePicker maintenancedate, CheckBox mb,
            CheckBox process, CheckBox hdd, CheckBox dvd, CheckBox vga, CheckBox ps, CheckBox casing, CheckBox keyboard, 
            CheckBox mouse, CheckBox nic, CheckBox os, CheckBox av, DateTimePicker lastupdate, TextBox notes)
        {
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.Add("id", MySqlDbType.Int32).Value = pk;

                cmd.Connection = c.Open();
                cmd.CommandText = "SELECT * FROM maintenance WHERE id = ?id";
                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                if (dr.HasRows)
                {
                    computername.Text = Convert.ToString(dr["computername"]);
                    maintenancedate.Value = Convert.ToDateTime(dr["maintenancedate"]);
                    mb.Checked = Convert.ToBoolean(dr["motherboard"]);
                    process.Checked = Convert.ToBoolean(dr["processor"]);
                    hdd.Checked = Convert.ToBoolean(dr["hdd"]);
                    dvd.Checked = Convert.ToBoolean(dr["discdrive"]);
                    vga.Checked = Convert.ToBoolean(dr["vga"]);
                    ps.Checked = Convert.ToBoolean(dr["powersupply"]);
                    casing.Checked = Convert.ToBoolean(dr["casing"]);
                    keyboard.Checked = Convert.ToBoolean(dr["keyboard"]);
                    mouse.Checked = Convert.ToBoolean(dr["mouse"]);
                    nic.Checked = Convert.ToBoolean(dr["lancard"]);
                    os.Checked = Convert.ToBoolean(dr["os"]);
                    av.Checked = Convert.ToBoolean(dr["av"]);
                    lastupdate.Value = Convert.ToDateTime(dr["avlastupdate"]);
                    notes.Text = Convert.ToString(dr["notes"]);
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
            cmd.CommandText = "SELECT id AS \"ID\", "
                + "computers.computername AS \"Nama Komputer\", "
                + "computers.location AS \"Location\", "
                + "maintenancedate AS \"Tgl Perawatan\", "
                + "motherboard AS \"Motherboard\", "
                + "processor AS \"Processor\", "
                + "hdd AS \"Harddisk\", "
                + "discdrive AS \"DVD / VCD\", "
                + "vga AS \"VGA\", "
                + "powersupply AS \"Power Supply\", "
                + "casing AS \"Casing\", "
                + "keyboard AS \"Keyboard\", "
                + "mouse AS \"Mouse\", "
                + "lancard AS \"LAN Card\", "
                + "os AS \"Sistem Operasi\", "
                + "av AS \"Anti Virus\", "
                + "avlastupdate AS \"Terkhir Update\", "
                + "notes AS \"Catatan\", "
                + "username AS \"Input By\" "
                + "FROM maintenance "
                + "INNER JOIN computers ON maintenance.computername = computers.computername "
                + "WHERE maintenance.computername = ?id ";

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            c.Close();
            return da;
        }

    }
}