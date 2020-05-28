using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial02
{
    public class appusers
    {
        public int idUser { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool usertype { get; set; }


        public appusers()
        {
            idUser = 0;
            fullname = "";
            username = "";
            password = "";
            usertype = true;
        }

    }
}
