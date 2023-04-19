using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_Armeria_PDV
{
    public class ProductoAVender
    {
        public int productoId;
        public int cantidad;
        //public llevaapostrofes

        public ProductoAVender(int prodId, int cant)
        {
            this.productoId = prodId;
            this.cantidad = cant;
        }
    }
}
