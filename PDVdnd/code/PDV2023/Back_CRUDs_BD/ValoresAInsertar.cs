using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Back_CRUDs_BD
{
    public class ValoresAInsertar
    {
        public string valor;
        public bool llevaApostrofes;

        public ValoresAInsertar(string v, bool llevaApostrofes=true) 
        {
            this.valor = v;
            this.llevaApostrofes = llevaApostrofes;
        }   
    }
}
