using Back_CRUDs_BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Middle_Armeria_PDV
{
    public class Venta
    {
        //campos
        DateTime fechaHora;
        public int cajeroId = 0;
        public int monto;
        public static string msgError = "";

        //vars para reutilizar el CRUD

        CRUDs_BD bd;
        public Venta()
        {
            //Crear instancia de MYSQL a mi bd
            bd = new Back_CRUDs_BD.MySql("localhost", "root", "", "dnd_armeria");
        }

        public double registrarVenta(int cajeroId, int monto, int pago, List<ProductoAVender> prodsAVender)
        {
            int res = 0;
            this.fechaHora = new DateTime();
            //registramos la venta de la tabla 'ventas'
            try
            {
                List<string> campos = new List<string>() { "fecha_hora", "cajero_id", "monto" };
                List<ValoresAInsertar> valores = new List<ValoresAInsertar>()
                {
                    new ValoresAInsertar(DateTime.Now.ToString(), true),
                    new ValoresAInsertar(this.cajeroId.ToString(), false),
                    new ValoresAInsertar(monto.ToString(), false),


                };
                //INSERT INTO 'ventas'('fecha_hora', 'cajero_id', 'monto') VALUES ('"+fechaHora.Now+"', '"+this.cajeroId+'", '"+this.monto+"');
                bool registroVenta = bd.insertar("ventas", campos, valores);
                if (registroVenta) 
                {
                    //cuando se registra la venta, obtenemos su ID (last_insert o el SELECT)
                    int ultimoIDVenta = int.Parse(bd.consulta1SoloValor("id", "ventas", " 1 ORDER BY id DESC LIMIT 1").ToString());
                    //hacemos un barrido de todos los productos a vender, en la lista prodsAVender
                    //lista de campos detalles
                    List<string> listaCamposDetalles = new List<string>() { "venta_id", "producto_id", "cantidad" };
                    
                    for (int i = 0; i < prodsAVender.Count; i++)
                    {
                        //pro cada prod en la lista, hacemos un registro en ventas_detalles
                        //$"INSERT INTO 'ventas_detalles'('venta_id', 'producto_id', 'cantidad') VALUES ({ultimoIDVenta}, {prodsAVender[i].productoId}, {prodsAVender[i].cantidad})"
                        List<ValoresAInsertar> listaValoresDetalles = new List<ValoresAInsertar>()
                        {
                        new ValoresAInsertar(ultimoIDVenta.ToString(), false),
                        new ValoresAInsertar(prodsAVender[i].productoId.ToString(), false),
                        new ValoresAInsertar(prodsAVender[i].cantidad.ToString(), false),

                        };
                        bool resDetalles = bd.insertar("venta_detalles", listaCamposDetalles, listaValoresDetalles);
                        if (resDetalles)
                        {
                            //int precio = int.Parse(bd.consulta1SoloValor("precio", "productos", "id=" + prodsAVender[i].productoId).ToString());
                            //monto += prodsAVender[i].productoId * prodsAVender[i].cantidad;
                            res = monto - pago;
                        }
                        else
                        {
                            Venta.msgError = bd.msgError;
                            return -1;
                        }
                    }
                    //si no hay error en tiempo de ejcucion... devolvemos MsgBox todo bien... y pago - monto
                    //si hay error , devolvemos -1
                }
                else
                {
                    Venta.msgError = bd.msgError;
                    return -1;
                }
                
            }
            catch (Exception)
            {
                res = -1;
                Venta.msgError = bd.msgError;
            }
            

            return res;
        }
    }
}
