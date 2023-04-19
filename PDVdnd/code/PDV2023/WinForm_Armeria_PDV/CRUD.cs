using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Back_CRUDs_BD;
using Middle_Armeria_PDV;

namespace WinForm_Armeria_PDV
{
    public partial class CRUD : Form

    {
        Producto prod = new Producto(); //un tipo de producto vacio. 
        CRUDs_BD bd;//para utilizar la conexión a la bd
        int identificador = 0;

        public CRUD()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                int celdas = e.RowIndex;//Al index donde le dimos click, (se llama e)
                //En cada campo, de la tabla, en la variable creada, en la celda de la posición del campo
                txtnombre.Text = dgridEquipamiento.Rows[celdas].Cells[1].Value.ToString();
                txtprecio.Text = dgridEquipamiento.Rows[celdas].Cells[2].Value.ToString();
                txtcodbarras.Text = dgridEquipamiento.Rows[celdas].Cells[3].Value.ToString();
                comboTipo.SelectedItem = dgridEquipamiento.Rows[celdas].Cells[4].Value.ToString();
                txtimagen.Text = dgridEquipamiento.Rows[celdas].Cells[5].Value.ToString();
                //pictureBoxImagen.ImageLocation = "..\\..\\..\\fotosProductos\\" + txtImagen.Text;//para recargar la foto. 
                this.identificador = (int)dgridEquipamiento.Rows[celdas].Cells[0].Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tipo valorTipo;
            switch (comboTipo.SelectedItem.ToString())
            {
                case "ESPADA":
                    valorTipo = Tipo.ESPADA;
                    break;
                case "HACHA":
                    valorTipo = Tipo.HACHA;
                    break;
                case "LANZA":
                    valorTipo = Tipo.LANZA;
                    break;
                case "ESCUDO":
                    valorTipo = Tipo.ESCUDO;
                    break;
                case "ARMADURA":
                    valorTipo = Tipo.ARMADURA;
                    break;
                default:
                    valorTipo = Tipo.ESPADA;
                    break;
            }
            bool resultado = prod.crear(txtnombre.Text, int.Parse(txtprecio.Text), txtcodbarras.Text, txtimagen.Text, valorTipo);
            if (resultado == false)
            {
                MessageBox.Show("Error al registrar producto. Verifique los datos. " + Producto.msgError);
            }
            else
            {
                MessageBox.Show("Producto registrado con éxito. ");
            }
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Tipo valorTipo;
            switch (comboTipo.SelectedItem.ToString())
            {
                case "ESPADA":
                    valorTipo = Tipo.ESPADA;
                    break;
                case "HACHA":
                    valorTipo = Tipo.HACHA;
                    break;
                case "LANZA":
                    valorTipo = Tipo.LANZA;
                    break;
                case "ESCUDO":
                    valorTipo = Tipo.ESCUDO;
                    break;
                case "ARMADURA":
                    valorTipo = Tipo.ARMADURA;
                    break;
                default:
                    valorTipo = Tipo.ESPADA;
                    break;
            }
            bool resultado = prod.modificar(txtnombre.Text, int.Parse(txtprecio.Text), txtcodbarras.Text, txtimagen.Text, valorTipo, this.identificador);
            if (resultado == false)
            {
                MessageBox.Show("ERROR AL MODIFICAR PRODUCTO" + Producto.msgError);
            }
            else
            {
                MessageBox.Show("PRODUCTO MODIFICADO CON ÉXITO");
            }
            this.limpiarForm(false);
            this.CRUD_Load(sender, e);
        }
        private void CRUD_Load(object sender, EventArgs e)
        {
            this.cargarDatos();
        }

        public void cargarDatos()
        {
            dgridEquipamiento.Rows.Clear();
            List<object[]> datos = prod.consultarTodos();
            for (int i = 0; i < datos.Count; i++)
            {
                dgridEquipamiento.Rows.Add(datos[i]);

            }
        }
        public void limpiarForm(bool habilitar)
        {
            if (habilitar)
            {
                txtnombre.Enabled = true;
                txtnombre.Clear();
                txtcodbarras.Enabled = true;
                txtcodbarras.Clear();
                txtprecio.Enabled = true;
                txtprecio.Clear();
                txtimagen.Enabled = true;
                txtimagen.Clear();
                //buttonExaminar.Enabled = true;
                //buttonGuardar.Enabled = true;

            }
            else
            {
                txtnombre.Enabled = false;
                txtnombre.Clear();
                txtcodbarras.Enabled = false;
                txtcodbarras.Clear();
                txtprecio.Enabled = false;
                txtprecio.Clear();
                txtimagen.Enabled = false;
                txtimagen.Clear();
                //buttonExaminar.Enabled = false;
                //buttonGuardar.Enabled = false;
            }
        }

        
    }
}
