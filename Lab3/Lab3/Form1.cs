using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using ConnectionToSQL.Helper;

namespace Lab3
{
    public partial class UserForm : Form
    {
        MyDatabaseConnection DBConnection = new MyDatabaseConnection();
        MySqlCommand Command;
        MySqlDataAdapter DA; // MySqlDataAdapter Class. Represents a set of data commands and a database connection that are used to fill a dataset and update a MySQL database.
                            // This class cannot be inherited.
        DataTable DT; // The DataTable class in C# ADO.NET is a database table representation and provides a collection of columns and rows to store data in a grid form.

        //  SqlConnection Connection = new SqlConnection("datasource=localhost;port=3306;username=root;password=admin");
        //  SqlCommand Cmd = new SqlCommand();
        //   SqlDataReader DataReader;
        public UserForm()
        {
            InitializeComponent();
            DBConnection.Connect();
            //     DBHelper.EstablishConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection.Connection.Open();
                Command = new MySqlCommand("Select * From автор", DBConnection.Connection);
                Command.ExecuteNonQuery();//ExecuteNonQuery used for executing queries that does not return any data. It is used to execute the sql statements like update, insert, delete etc.
                                          //ExecuteNonQuery executes the command and returns the number of rows affected.
                DT = new DataTable();
                DA = new MySqlDataAdapter(Command);
                DA.Fill(DT);
                DataGVUE.DataSource = DT.DefaultView;
                DBConnection.Connection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }            /*   try
               {
                   string MyConnection2 = "datasource=localhost;port=3307;database=Библиотека;username=root;password=root";
                   //Display query  
                   string Query = "select * from Автор;";
                   MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                   MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                   //  MyConn2.Open();  
                   //For offline connection we weill use  MySqlDataAdapter class.  
                   MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                   MyAdapter.SelectCommand = MyCommand2;
                   DataTable dTable = new DataTable();
                   MyAdapter.Fill(dTable);
                   DataGVUE.DataSource = dTable; // here i have assign dTable object to the dataGridView1 object to display data.               
                   MessageBox.Show("S", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);                                   // MyConn2.Close();  
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }*/
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

            try
            {
                DBConnection.Connection.Open();
                Command = new MySqlCommand("Select * From автор", DBConnection.Connection);
                Command.ExecuteNonQuery();//ExecuteNonQuery used for executing queries that does not return any data. It is used to execute the sql statements like update, insert, delete etc.
                                          //ExecuteNonQuery executes the command and returns the number of rows affected.
                DT = new DataTable();
                DA = new MySqlDataAdapter(Command);
                DA.Fill(DT);
                DataGVUE.DataSource = DT.DefaultView;
                DBConnection.Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }           

            /*      public static class DBHelper
              {
                  // private static readonly object DataGVUE;

                  // private static readonly object DataGVUE;
                  private static MySqlConnection Connection;
                  private static MySqlCommand Cmd = null;
                  private static DataTable dt;
                  private static MySqlDataAdapter DA;

                  public static void EstablishConnection()
                  {
                      // String ConnectionString = "Server=127.0.0.1;User=root;Database=Библиотека;Password=admin;";
                      try
                      {
                          MySqlConnectionStringBuilder Builder = new MySqlConnectionStringBuilder();
                          Builder.Server = "127.0.0.1";

                          Builder.UserID = "root";
                          Builder.Password = "admin";
                          Builder.Database = "Библиотека";
                          Builder.SslMode = MySqlSslMode.None;
                          Connection = new MySqlConnection(Builder.ToString());
                          MessageBox.Show("Database connection successfull", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);

                         // MySqlConnection Connection = new MySqlConnection();

                  //  DBHelper.EstablishConnection();
                  string SelectQuery = "Select * From книга";
                  DataTable Table = new DataTable();
                  MySqlDataAdapter Adapter = new MySqlDataAdapter(SelectQuery, Connection);
                  Adapter.Fill(Table);
                  DataGVUE.
                  /* 
                              try
                              {
                                  MySqlConnection Connection = new MySqlConnection("datasource=localhost;port=3307;username=root;password=");
                                  MySqlDataAdapter adapter = new MySqlDataAdapter("Select * From Библиотека.Автор", Connection);
                                  Connection.Open();

                                  DataSet dts = new DataSet();
                                  adapter.Fill(dts, "Автор");
                                  DataGVUE.DataSource = dts.Tables["Автор"];
                                  Connection.Close();
                              }
                              catch (Exception ex)
                              {
                                  MessageBox.Show(ex.Message);
                              }
                  */

        }

        private void DataGVUE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

    /*  public void LoadUser()
      {
          int i = 0;
          DataGVUE.Rows.Clear();
          Cmd = new SqlCommand("SELECT * FROM tbUser");
          Con.Open();
          DataReader = Cmd.ExecuteReader();
          while (DataReader.Read())
          {
              i++;
              DataGVU.Rows.Add(i, DataReader[0].ToString(), DataReader[1].ToString(), DataReader[2].ToString(), DataReader[3].ToString());
          }
          DataReader.Close();
          Con.Close();



      }*/

/*   public static class DBHelper
   {
      // private static readonly object DataGVUE;

       // private static readonly object DataGVUE;
       private static MySqlConnection Connection;
       private static MySqlCommand Cmd = null;
       private static DataTable dt;
       private static MySqlDataAdapter DA;

       public static void EstablishConnection()
       {
          // String ConnectionString = "Server=127.0.0.1;User=root;Database=Библиотека;Password=admin;";
           try
           {
               MySqlConnectionStringBuilder Builder = new MySqlConnectionStringBuilder();
               Builder.Server = "127.0.0.1";

               Builder.UserID = "root";
               Builder.Password = "admin";
               Builder.Database = "Библиотека";
               Builder.SslMode = MySqlSslMode.None;
               Connection = new MySqlConnection(Builder.ToString());
               MessageBox.Show("Database connection successfull", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);

//                Connection.Open();
             //  Cmd = MySqlCommand("Select * From Автор");

               //  String SQL = "Select * From Автор";
               //
               //  MySqlCommand Command = new MySqlCommand(SQL, Connection);
               //   string Name = Command.ExecuteScalar().ToString();

               //   Console.WriteLine(Name);

               /*DataSet dts = new DataSet();
               DA.Fill(dts, "Автор");
               DataGVUE.Fill = dts.Tables["Автор"];*/

// Connection.Close(); 


/*     }
     catch (Exception)
     {
         MessageBox.Show("Connection Failed");
     }

 }*/

/*  private static MySqlCommand MySqlCommand(string v)
  {
      throw new NotImplementedException();
  }*/



//  }




//  Cmd = MySqlCommand("Select * from Автор");