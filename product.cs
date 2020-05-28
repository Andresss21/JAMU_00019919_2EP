using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial02
{
    class product
    {
        public int idProduct { get; set; }
        public int idBusiness { get; set; }
        public string name { get; set; }


        public product()
        {
            idProduct = 0;
            idBusiness = 0;
            name = "";
            
        }
    }
}
