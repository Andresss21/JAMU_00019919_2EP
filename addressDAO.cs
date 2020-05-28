using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial02
{
    class addressDAO
    {
        public static List<address> getList()
        {
            string sql = "select * from address";

            DataTable dt = conexion.makeconsult(sql);

            List<address> list = new List<address>();
            foreach (DataRow fila in dt.Rows)
            {
                address u = new address();
                u.idaddress = Convert.ToInt32(fila[0].ToString());
                u.idUser = Convert.ToInt32(fila[1].ToString());
                u.addresss = fila[2].ToString();

                list.Add(u);
            }
            return list;
        }

        public static void addnew( int idUser, string addresss)
        {
            string sql = String.Format(
                "INSERT INTO ADDRESS(idUser, address) " +
                "values ('{0}', '{1}');",
                idUser, addresss);

            conexion.makeaction(sql);
        }

        public static void delete(int id)
        {
            string sql = String.Format(
                "DELETE FROM ADDRESS WHERE idaddress = '{0}'; ",
                id);

            conexion.makeaction(sql);
        }

    }
}
