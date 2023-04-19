using System.Threading.Tasks;
using System.Windows.Forms;
using Middle_Armeria_PDV;

namespace WinForm_Armeria_PDV
{
    public partial class Caja_Venta : Form
    {
        //instancia de producto
        Producto prodAVender;
        Venta venta;

        public Caja_Venta()
        {
            InitializeComponent();
            prodAVender = new Producto();
            venta = new Venta();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //vamos a consultar en productos por el cod de barras del txtCodBarras
            Producto res = prodAVender.consultarPorCodBarras(txtCodBarras.Text);
            //validas si existe
            if (res == null)
            {
                MessageBox.Show("Producto no existe en el catálogo.");
            }
            else
            {
                //si existe el producto, vamos a crear un renglon en el data grid
                dGridVentas.Rows.Add(new object[] { res.id, res.nombre, numericCantidad.Value, res.precio * int.Parse(numericCantidad.Value.ToString()) });
                //en la ultima columna, vamos a poner la multiplicacion de cantidad por precio del prod
                //limpiamos txtCodBarras
                txtCodBarras.Clear();
                numericCantidad.Value = 1;

                int col = dGridVentas.ColumnCount - 1;
                int subtotal = 0;
                //totalizar la venta
                for (int i = 1; i < dGridVentas.Rows.Count; i++)
                {
                    subtotal += int.Parse(dGridVentas.Rows[i].Cells[col].Value.ToString());
                }
                txtTotal.Text = subtotal.ToString();
            }

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //preparamos las vars para registrar las ventas
            List<ProductoAVender> prodsAVender = new List<ProductoAVender>();
            for(int i = 0; i< dGridVentas.Rows.Count-1; i++)
            {
                    //agregar un ProductoAVender a la lista
                    ProductoAVender prodVender = new ProductoAVender(int.Parse(dGridVentas.Rows[i].Cells[0].Value.ToString()), int.Parse(dGridVentas.Rows[i].Cells[3].Value.ToString()));
                    prodsAVender.Add(prodVender);
            }

            int cambio = int.Parse(((venta.registrarVenta(1, int.Parse(txtTotal.Text), int.Parse(txtEfectivo.Text), prodsAVender))).ToString());
            //si hay error
            if(cambio == -1)
            {
                MessageBox.Show("Error al registrar la venta", Venta.msgError);
            }
            else
            {
                MessageBox.Show("Registrada correctamente", "Su cambio es $" + cambio + "Vuelva pronto.");
            }
        }
    }
}