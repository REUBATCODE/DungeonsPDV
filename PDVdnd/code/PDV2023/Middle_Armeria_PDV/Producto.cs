using Back_CRUDs_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_Armeria_PDV
{
    public class Producto
    {
        //propiedades de la clase
        public string nombre;
        public string descripcion;
        public int precio;
        public string cod_barras;
        public string imagen;
        public Tipo tipo;
        public int id;

        //vars para reutilizar el crud
        CRUDs_BD bd;

        public Producto() 
        {
            //crear una instancia de MySql a la bd
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "dnd_armeria");
        }
        //---MÉTODOS---//
        public bool crear(string nom, string desc, int precio, string cod_barras, string imagen, Tipo tipo)
        {
            List<string> nombresCampos = new List<string>()
            {
                "nombre", "descripcion", "precio", "cod_barras", "imagen", "tipo"
            };

            return this.bd.insertar("equipamiento", )
        }
    }
}
