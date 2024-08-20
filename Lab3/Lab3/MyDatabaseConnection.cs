using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Lab3
{
    class MyDatabaseConnection
    {
        public MySqlConnection Connection;
        public void Connect()
        {
           // компания_дмитрия

              Connection = new MySqlConnection("Datasource=127.0.0.1;username=root;password=;database=компания_дмитрия");
        }
    }
}
