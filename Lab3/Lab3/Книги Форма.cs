﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Книги_Форма : Form
    {

    
      /*  MyDatabaseConnection DBConnection = new MyDatabaseConnection();
        MySqlCommand Command;
        MySqlDataAdapter DA;
        DataTable DT;*/
        public Книги_Форма()
        {
            InitializeComponent();
          //  DBConnection.Connect();
        }
      }
      /*  private void Laod_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.Connection.Open();
                Command = new MySqlCommand("Select * From книга", DBConnection.Connection);
                Command.ExecuteNonQuery();
                DT = new DataTable();
                DA = new MySqlDataAdapter(Command);
                DA.Fill(DT);
                DataGVUK.DataSource = DT.DefaultView;
                DBConnection.Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }            
        }*/
    }

