using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial02
{
    public class business
    {   
        public int idBusiness { get; set; }
        public string name { get; set; }

        public string description { get; set; }


        public business()
        {
            idBusiness = 0;
            name = "";
            description = "";
        }

    }

    
}
