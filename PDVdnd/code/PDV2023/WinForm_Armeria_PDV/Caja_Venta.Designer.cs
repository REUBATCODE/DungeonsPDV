namespace WinForm_Armeria_PDV
{
    partial class Caja_Venta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja_Venta));
            txtCodBarras = new TextBox();
            numericCantidad = new NumericUpDown();
            btnAgregar = new Button();
            dGridVentas = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colSubtotal = new DataGridViewTextBoxColumn();
            lblCodBarras = new Label();
            txtSubtotal = new TextBox();
            txtIva = new TextBox();
            txtTotal = new TextBox();
            lblSubtotal = new Label();
            lblIva = new Label();
            lblTotal = new Label();
            txtEfectivo = new TextBox();
            lblEfectivo = new Label();
            btnPagar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dGridVentas).BeginInit();
            SuspendLayout();
            // 
            // txtCodBarras
            // 
            txtCodBarras.BackColor = Color.Snow;
            txtCodBarras.Location = new Point(12, 82);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.Size = new Size(458, 23);
            txtCodBarras.TabIndex = 0;
            // 
            // numericCantidad
            // 
            numericCantidad.BackColor = Color.SeaShell;
            numericCantidad.Location = new Point(476, 82);
            numericCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericCantidad.Name = "numericCantidad";
            numericCantidad.Size = new Size(39, 23);
            numericCantidad.TabIndex = 1;
            numericCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.Control;
            btnAgregar.BackgroundImage = (Image)resources.GetObject("btnAgregar.BackgroundImage");
            btnAgregar.Location = new Point(521, 51);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(55, 55);
            btnAgregar.TabIndex = 2;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dGridVentas
            // 
            dGridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGridVentas.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colPrecio, colCantidad, colSubtotal });
            dGridVentas.Location = new Point(12, 111);
            dGridVentas.Name = "dGridVentas";
            dGridVentas.RowTemplate.Height = 25;
            dGridVentas.Size = new Size(564, 242);
            dGridVentas.TabIndex = 3;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            // 
            // colNombre
            // 
            colNombre.HeaderText = "NOMBRE";
            colNombre.Name = "colNombre";
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "PRECIO";
            colPrecio.Name = "colPrecio";
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "CANTIDAD";
            colCantidad.Name = "colCantidad";
            // 
            // colSubtotal
            // 
            colSubtotal.HeaderText = "SUBTOTAL";
            colSubtotal.Name = "colSubtotal";
            // 
            // lblCodBarras
            // 
            lblCodBarras.AutoSize = true;
            lblCodBarras.BackColor = Color.Transparent;
            lblCodBarras.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodBarras.ForeColor = SystemColors.ButtonHighlight;
            lblCodBarras.Location = new Point(12, 51);
            lblCodBarras.Name = "lblCodBarras";
            lblCodBarras.Size = new Size(199, 20);
            lblCodBarras.TabIndex = 4;
            lblCodBarras.Text = "REGISTRAR PRODUCTO";
            // 
            // txtSubtotal
            // 
            txtSubtotal.BackColor = Color.Snow;
            txtSubtotal.Location = new Point(457, 359);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(119, 23);
            txtSubtotal.TabIndex = 5;
            // 
            // txtIva
            // 
            txtIva.BackColor = Color.Snow;
            txtIva.Location = new Point(457, 388);
            txtIva.Name = "txtIva";
            txtIva.Size = new Size(119, 23);
            txtIva.TabIndex = 6;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = Color.Snow;
            txtTotal.Location = new Point(457, 417);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(119, 23);
            txtTotal.TabIndex = 7;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.BackColor = Color.Transparent;
            lblSubtotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtotal.ForeColor = SystemColors.ButtonHighlight;
            lblSubtotal.Location = new Point(382, 361);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(93, 20);
            lblSubtotal.TabIndex = 8;
            lblSubtotal.Text = "SUBTOTAL";
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.BackColor = Color.Transparent;
            lblIva.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblIva.ForeColor = SystemColors.ButtonHighlight;
            lblIva.Location = new Point(419, 388);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(36, 20);
            lblIva.TabIndex = 9;
            lblIva.Text = "IVA";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = SystemColors.ButtonHighlight;
            lblTotal.Location = new Point(405, 414);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(59, 20);
            lblTotal.TabIndex = 10;
            lblTotal.Text = "TOTAL";
            // 
            // txtEfectivo
            // 
            txtEfectivo.BackColor = Color.Snow;
            txtEfectivo.Location = new Point(12, 359);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.Size = new Size(119, 23);
            txtEfectivo.TabIndex = 11;
            // 
            // lblEfectivo
            // 
            lblEfectivo.AutoSize = true;
            lblEfectivo.BackColor = Color.Transparent;
            lblEfectivo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEfectivo.ForeColor = SystemColors.ButtonHighlight;
            lblEfectivo.Location = new Point(137, 356);
            lblEfectivo.Name = "lblEfectivo";
            lblEfectivo.Size = new Size(89, 20);
            lblEfectivo.TabIndex = 12;
            lblEfectivo.Text = "EFECTIVO";
            // 
            // btnPagar
            // 
            btnPagar.BackColor = SystemColors.Control;
            btnPagar.BackgroundImage = (Image)resources.GetObject("btnPagar.BackgroundImage");
            btnPagar.Location = new Point(200, 359);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(55, 55);
            btnPagar.TabIndex = 13;
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Control;
            btnCancelar.BackgroundImage = (Image)resources.GetObject("btnCancelar.BackgroundImage");
            btnCancelar.Location = new Point(200, 481);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(55, 55);
            btnCancelar.TabIndex = 14;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // Caja_Venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(586, 584);
            Controls.Add(btnCancelar);
            Controls.Add(btnPagar);
            Controls.Add(lblEfectivo);
            Controls.Add(txtEfectivo);
            Controls.Add(lblTotal);
            Controls.Add(lblIva);
            Controls.Add(lblSubtotal);
            Controls.Add(txtTotal);
            Controls.Add(txtIva);
            Controls.Add(txtSubtotal);
            Controls.Add(lblCodBarras);
            Controls.Add(dGridVentas);
            Controls.Add(btnAgregar);
            Controls.Add(numericCantidad);
            Controls.Add(txtCodBarras);
            Name = "Caja_Venta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caja Venta";
            ((System.ComponentModel.ISupportInitialize)numericCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dGridVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodBarras;
        private NumericUpDown numericCantidad;
        private Button btnAgregar;
        private DataGridView dGridVentas;
        private Label lblCodBarras;
        private TextBox txtSubtotal;
        private TextBox txtIva;
        private TextBox txtTotal;
        private Label lblSubtotal;
        private Label lblIva;
        private Label lblTotal;
        private TextBox txtEfectivo;
        private Label lblEfectivo;
        private Button btnPagar;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colSubtotal;
    }
}