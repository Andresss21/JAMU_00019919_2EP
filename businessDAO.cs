using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial02
{
    class businessDAO
    {

        public static List<business> getList()
        {
            string sql = "select * from business";

            DataTable dt = conexion.makeconsult(sql);

            List<business> list = new List<business>();
            foreach (DataRow fila in dt.Rows)
            {
                business u = new business();
                u.idBusiness = Convert.ToInt32(fila[0].ToString());
                u.name = fila[1].ToString();
                u.description = fila[2].ToString();
               
                list.Add(u);
            }
            return list;
        }

        public static void addnew(string name, string description)
        {
            string sql = String.Format(
                "INSERT INTO BUSINESS(name, description)" +
                "values ('{0}', '{1}');",
                name, description);

            conexion.makeaction(sql);
        }

        public static void delete(int id)
        {
            string sql = String.Format(
                "DELETE FROM BUSINESS WHERE idBusiness ='{0}'; ",
                id);

            conexion.makeaction(sql);
        }

    }
}
