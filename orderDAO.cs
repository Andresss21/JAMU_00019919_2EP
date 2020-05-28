using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial02
{
    class orderDAO
    {
        public static List<order> getList()
        {
            string sql = "select * from apporder";

            DataTable dt = conexion.makeconsult(sql);

            List<order> list = new List<order>();
            foreach (DataRow fila in dt.Rows)
            {
                order u = new order();
                u.idOrder = Convert.ToInt32(fila[0].ToString());
                u.createdate =fila[1].ToString();
                u.idProduct = Convert.ToInt32(fila[2].ToString());
                u.idAdress = Convert.ToInt32(fila[3].ToString());

                list.Add(u);
            }
            return list;
        }

        public static void addnew(int idproduct, int idaddress)
        {
            string sql = String.Format(
                "INSERT INTO APPORDER(createDate, idProduct, idAddress)" +
                "values (CURRENT_DATE,'{0}', '{1}');",
                idproduct, idaddress);

            conexion.makeaction(sql);
        }

        public static void delete(int id)
        {
            string sql = String.Format(
                "DELETE FROM APPORDER WHERE idOrder ='{0}'; ",
                id);

            conexion.makeaction(sql);
        }

    }
}
