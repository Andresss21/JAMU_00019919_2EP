using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial02
{
    class order
    {
        public int idOrder { get; set; }
        public string createdate { get; set; }
        public int idProduct { get; set; }
        public int idAdress { get; set; }


        public order()
        {
            idOrder = 0;
            createdate = ""; 
            idProduct = 0;
            idAdress = 0;
            

        }
    }
}
