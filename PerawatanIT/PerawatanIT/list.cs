using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PerawatanIT
{
    class list
    {
        connection c = new connection();
        MySqlCommand cmd = new MySqlCommand();

        internal void ListCategory(ComboBox cbo)
        {
            try
            {
                DataTable dt = new DataTable();
                cmd.Connection = c.Open();
                cmd.CommandText = "SELECT description FROM category WHERE status = '1' ORDER BY description";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr[0] = "-";
                dt.Rows.InsertAt(dr, 0);
                cbo.DataSource = dt;
                cbo.DisplayMember = "description";
                cbo.ValueMember = "description";
                cbo.AutoCompleteMode = AutoCompleteMode.Append;
                cbo.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Program.MsgError(ex.Message);
            }
        }

        internal void ListItem(ComboBox cbo, object kategori)
        {
            try
            {
                DataTable dt = new DataTable();
                cmd.Parameters.Clear();
                cmd.Parameters.Add("kategori", MySqlDbType.VarChar).Value = kategori;

                cmd.Connection = c.Open();
                cmd.CommandText = "SELECT id, description FROM items " 
                    + "WHERE status = '1' AND category = ?kategori " 
                    + "ORDER BY description";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr[0] = "-";
                dr[1] = "- SELECT -";
                dt.Rows.InsertAt(dr, 0);
                cbo.DataSource = dt;
                cbo.DisplayMember = "description";
                cbo.ValueMember = "id";
                cbo.AutoCompleteMode = AutoCompleteMode.Append;
                cbo.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Program.MsgError(ex.Message);
            }
        }

        internal void ListTrouble(ComboBox cbo)
        {
            try
            {
                DataTable dt = new DataTable();
                cmd.Connection = c.Open();
                cmd.CommandText = "SELECT id, description FROM trouble ORDER BY description";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr[0] = "0";
                dr[1] = "- SELECT -";
                dt.Rows.InsertAt(dr, 0);
                cbo.DataSource = dt;
                cbo.DisplayMember = "description";
                cbo.ValueMember = "id";
                cbo.AutoCompleteMode = AutoCompleteMode.Append;
                cbo.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Program.MsgError(ex.Message);
            }
        }


    }
}
