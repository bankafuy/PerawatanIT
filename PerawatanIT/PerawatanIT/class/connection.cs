using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace PerawatanIT
{
    class connection : IDisposable
    {

        MySqlConnection connect = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();

        public void Dispose()
        {
            if (connect != null)
            {
                connect.Dispose();
                connect = null;
            }
            if (cmd != null)
            {
                cmd.Dispose();
                cmd = null;
            }
        }

        public MySqlConnection Open()
        {
            string MyDB = System.IO.File.ReadLines(".\\config.ini").Skip(0).Take(1).First();

            connect = new MySqlConnection(MyDB) { ConnectionString = MyDB };
            if (connect != null)
                connect.Close();

            connect.Open();

            return connect;
        }

        public MySqlConnection Close()
        {
            connect.Close();
            return connect;
        }

    }
}
