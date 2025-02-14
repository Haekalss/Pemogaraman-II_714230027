﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace P11_714230027
{
    internal class Koneksi
    {
        string connectionstring = "Server=localhost;Database=pemrog2ulbi;Uid=root;Pwd=ini_passwordnyabaruyaa14;";
        MySqlConnection kon;



        public void OpenConnection()
        {
            kon = new MySqlConnection(connectionstring);
            kon.Open();
        }

        public MySqlConnection GetConnection()
        {
            return kon;
        }
        public void CloseConnection()
        {
            kon.Close();
        }

        public void ExecetueQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, kon);
            command.ExecuteNonQuery();
        }

        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionstring);
            DataSet data = new DataSet(); 

            adapter.Fill(data);
            object datatable = data.Tables[0];
            return datatable;
        }

        public MySqlDataReader reader(string query)
        { 
            MySqlCommand cmd = new MySqlCommand(query, kon);
            MySqlDataReader dr = cmd.ExecuteReader(); 
            return dr; 
        }
    }
}
