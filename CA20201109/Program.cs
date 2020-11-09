using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CA20201109
{
    class Program
    {
        static SqlConnection conn;
        static void Main(string[] args)
        {
            conn = new SqlConnection(
                @"Server=(localdb)\MSSQLLocalDB;" +
                @"AttachDbFilename=|DataDirectory|\Res\teszt2.mdf;");

            conn.Open();

            //new SqlCommand("INSERT INTO emberek (orszagId, nev) VALUES (1, 'Zsofika');", conn).ExecuteNonQuery();

            var sqlcmd = new SqlCommand("SELECT * FROM emberek;", conn);

            var r = sqlcmd.ExecuteReader();
            while (r.Read())
                Console.WriteLine(r[2]);

            conn.Close();

            Console.ReadKey();
        }
    }
}
