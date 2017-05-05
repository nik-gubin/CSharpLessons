using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13
{
    class Program
    {
        static void Main(string[] args)
        {
            //AttachedADO();
            DeattachedADO();
        }

        private static void DeattachedADO()
        {
            string connString = ConfigurationManager.ConnectionStrings["TestConnString1"].ConnectionString;
            SQLiteConnection connection = new SQLiteConnection(connString);
            connection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from books", connection);
            
            DataSet data = new DataSet();
            adapter.Fill(data, "Book");
            connection.Close();

            DataTable books = data.Tables["Book"];
            foreach (DataColumn item in books.Columns)
            {
                Console.WriteLine("{0} {1}", item.ColumnName,item.DataType);
            }
            foreach (DataRow item in books.Rows)
            {
                Console.WriteLine("{0} {1} {2}", item["id"], item["author"], item["title"]);
            }

            DataRow nRow = books.NewRow();
            nRow["author"] = "Достоевский";
            nRow["title"] = "Обломов";
            books.Rows.Add(nRow);

            SQLiteCommandBuilder com = new SQLiteCommandBuilder(adapter);
            adapter.Update(data,"Book");



        }

        private static void AttachedADO()
        {
            string connString = ConfigurationManager.ConnectionStrings["TestConnString1"].ConnectionString;
            SQLiteConnection connection = new SQLiteConnection(connString);
            // SQLiteConnection connection = new SQLiteConnection("Data Source=test.db");
            connection.Open();
            SQLiteCommand command = connection.CreateCommand();
            //command.CommandText = "create table  books(id integer primary key autoincrement,"
            //    + " author nvarchar(20) not null, title nvarchar(20) not null)";
            //command.ExecuteNonQuery();

            command.CommandText = "insert into books (author,title) values ('Толстой','Война и мир')";
            int r = command.ExecuteNonQuery();
            Console.WriteLine("Update rows {0}", r);

            string a = Console.ReadLine();


            //   command.CommandText = "select id,author,title from books where author='" + a + "'";
            command.CommandText = "select id,author,title from books where author=@a1";
            command.Parameters.Add(new SQLiteParameter("a1", a));
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                // int count = reader.GetInt32(3);
                string tilte = reader[2].ToString();
                string author = reader["author"].ToString();
                Console.WriteLine("{0} {1} {2}", id, author, tilte);
            }
            connection.Close();
        }
    }
}
