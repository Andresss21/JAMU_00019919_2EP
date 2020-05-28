using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial02
{
    class address
    {
        public int idaddress { get; set; }
        public int idUser { get; set; }
        public string addresss { get; set; }


        public address()
        {
            idaddress = 0;
            idUser = 0;
            addresss = "";

        }
    }
}
