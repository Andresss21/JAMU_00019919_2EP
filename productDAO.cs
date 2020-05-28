using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial02
{
    class productDAO
    {
        public static List<product> getList()
        {
            string sql = "select * from product";

            DataTable dt = conexion.makeconsult(sql);

            List<product> list = new List<product>();
            foreach (DataRow fila in dt.Rows)
            {
                product u = new product();
                u.idProduct = Convert.ToInt32(fila[0].ToString());
                u.idBusiness = Convert.ToInt32(fila[1].ToString());
                u.name = fila[2].ToString();

                list.Add(u);
            }
            return list;
        }

        public static void addnew(int idBusiness, string name)
        {
            string sql = String.Format(
                "INSERT INTO PRODUCT(idBusiness, name)" +
                "values ('{0}', '{1}');",
                idBusiness,name);

            conexion.makeaction(sql);
        }

        public static void delete(int id)
        {
            string sql = String.Format(
                "DELETE FROM product WHERE idProduct ='{0}'; ",
                id);

            conexion.makeaction(sql);
        }



    }
}
