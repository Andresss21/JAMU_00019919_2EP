using System.Data;
using Npgsql;

namespace Parcial02
{
    class conexion
    {
        private static string chainconn = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=password;Database=parcialDos";

        public static DataTable makeconsult(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(chainconn);
            DataSet ds = new DataSet();

            conn.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(ds);
            conn.Close();

            return ds.Tables[0];
        }

        public static void makeaction(string sql)
        {
            NpgsqlConnection conn = new NpgsqlConnection(chainconn);

            conn.Open();
            NpgsqlCommand nc = new NpgsqlCommand(sql, conn);
            nc.ExecuteNonQuery();
            conn.Close();
        }

    }
}
