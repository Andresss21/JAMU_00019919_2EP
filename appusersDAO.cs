using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial02
{
    class appusersDAO
    {
        public static List<appusers> getList()
        {
            string sql = "select * from appuser";

            DataTable dt = conexion.makeconsult(sql);

            List<appusers> lista = new List<appusers>();
            foreach (DataRow fila in dt.Rows)
            {
                appusers u = new appusers();
                u.idUser = Convert.ToInt32(fila[0].ToString());
                u.fullname = fila[1].ToString();
                u.username = fila[2].ToString();
                u.password = fila[3].ToString();
                u.usertype = Convert.ToBoolean(fila[4].ToString());
                lista.Add(u);
            }
            return lista;
        }

       

        public static void addnew(string fullname, string username, string password, string usertype)
        {
            string sql = String.Format(
                "INSERT INTO APPUSER (fullname, username, password, userType)" +
                "values ('{0}', '{1}', '{2}', '{3}');",
                fullname, username, password, usertype);

            conexion.makeaction(sql);
        }

      

        public static void delete(int idUser)
        {
            string sql = String.Format(
                "DELETE FROM APPUSER WHERE idUser ='{0}'; ",
                idUser);

            conexion.makeaction(sql);
        }

       

    }
}
