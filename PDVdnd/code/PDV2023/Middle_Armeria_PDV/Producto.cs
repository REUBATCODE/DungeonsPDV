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

        //var static de msg de error
        public static string msgError;

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
            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            vals.Add(new ValoresAInsertar(nom));
            vals.Add(new ValoresAInsertar(desc));
            vals.Add(new ValoresAInsertar(precio.ToString(), false));
            vals.Add(new ValoresAInsertar(cod_barras));
            vals.Add(new ValoresAInsertar(imagen));
            vals.Add(new ValoresAInsertar(tipo.ToString()));


            bool resultado = this.bd.insertar("equipamiento", nombresCampos, vals);
            //validar el resultado
            if (resultado == false)
                Producto.msgError = this.bd.msgError;
            return resultado;
        }//crear

        public bool modificar(string nom, string desc, int precio, string cod_barras, string imagen, Tipo tipo, int id)
        {
            List<string> nombresCampos = new List<string>()
            {
                "nombre", "descripcion", "precio", "cod_barras", "imagen", "tipo"
            };
            List<ValoresAInsertar> vals = new List<ValoresAInsertar>();
            vals.Add(new ValoresAInsertar(nom));
            vals.Add(new ValoresAInsertar(desc));
            vals.Add(new ValoresAInsertar(precio.ToString(), false));
            vals.Add(new ValoresAInsertar(cod_barras));
            vals.Add(new ValoresAInsertar(imagen));
            vals.Add(new ValoresAInsertar(tipo.ToString()));


            bool resultado = this.bd.modificar("equipamiento", nombresCampos, vals, id);
            //validar el resultado
            if (resultado == false)
                Producto.msgError = this.bd.msgError;
            return resultado;
        }//modificar

        public bool borrar(int id) 
        {
            bool res = this.bd.borrar("equipamiento", id);
            if(res == false)
                Producto.msgError = this.bd.msgError;
            return res; 
        }//borrar

        public List<object[]> consultarTodos() 
        {
            return this.bd.consulta("equipamiento");
        }//consultar todo

        public int consultarPrecio(int id) 
        {
            int precio = 0;
            List<object[]> res = this.bd.consulta("equipamiento", "id=" + id);
            //validamos que traiga un elemento la lista
            if(res.Count==1) 
            {
                object[] tempo = res[0];
                precio = int.Parse(tempo[3].ToString());
            }
            else
            {
                Producto.msgError=this.bd.msgError;
                precio = -1;
            }
            return precio;
        }//consultar precio por id

        public Producto consultarPorCodBarras(string codBarras)
        {
            Producto prodResultado = new Producto();
            List<object[]> res = this.bd.consulta("equipamiento", "cod_barras=" + codBarras);
            //validamos que traiga un elemento la lista
            if (res.Count == 1)
            {
                Tipo tipoTexto;
                object[] tempo = res[0];
                precio = int.Parse(tempo[3].ToString());
                prodResultado.id = int.Parse(tempo[0].ToString());
                prodResultado.nombre = tempo[1].ToString();
                prodResultado.precio = int.Parse(tempo[2].ToString());
                prodResultado.cod_barras = tempo[3].ToString();
                prodResultado.imagen = tempo[4].ToString();

                switch(tempo[5].ToString())
                {
                    case "ESPADA":
                        tipoTexto = Tipo.ESPADA;
                        break;
                    case "HACHA":
                        tipoTexto = Tipo.HACHA;
                        break;
                    case "LANZA":
                        tipoTexto = Tipo.LANZA;
                        break;
                    case "ESCUDO":
                        tipoTexto = Tipo.ESCUDO;
                        break;
                    case "ARMADURA":
                        tipoTexto = Tipo.ARMADURA;
                        break;
                    default:
                        tipoTexto= Tipo.ESPADA;
                        break;
                }
                prodResultado.tipo = tipoTexto;
            }
            else
            {
                Producto.msgError = "Código de barras no existe en catalogo de productos."+this.bd.msgError;
                prodResultado = null;
            }

            return prodResultado;
        }//consultar producto por cod barras.

    }
}
