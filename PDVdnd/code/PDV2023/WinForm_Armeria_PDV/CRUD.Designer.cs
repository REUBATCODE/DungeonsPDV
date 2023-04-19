namespace WinForm_Armeria_PDV
{
    partial class CRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD));
            label_armeria = new Label();
            pictureBox_npc_tienda = new PictureBox();
            dgridEquipamiento = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colCodBarras = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colImagen = new DataGridViewImageColumn();
            txt_id = new TextBox();
            txtnombre = new TextBox();
            txtprecio = new TextBox();
            txtcodbarras = new TextBox();
            txtimagen = new TextBox();
            comboTipo = new ComboBox();
            btnGuardar = new Button();
            btnBorrar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_npc_tienda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgridEquipamiento).BeginInit();
            SuspendLayout();
            // 
            // label_armeria
            // 
            label_armeria.BackColor = Color.Transparent;
            label_armeria.BorderStyle = BorderStyle.Fixed3D;
            label_armeria.Font = new Font("Anton", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_armeria.ForeColor = Color.White;
            label_armeria.Location = new Point(986, 9);
            label_armeria.Name = "label_armeria";
            label_armeria.Size = new Size(389, 134);
            label_armeria.TabIndex = 0;
            label_armeria.Text = "ARMERÍA DUNGEONS AND DRAGONS";
            label_armeria.TextAlign = ContentAlignment.MiddleCenter;
            label_armeria.Click += label1_Click;
            // 
            // pictureBox_npc_tienda
            // 
            pictureBox_npc_tienda.BackColor = Color.Transparent;
            pictureBox_npc_tienda.BackgroundImage = (Image)resources.GetObject("pictureBox_npc_tienda.BackgroundImage");
            pictureBox_npc_tienda.Location = new Point(-27, 105);
            pictureBox_npc_tienda.Name = "pictureBox_npc_tienda";
            pictureBox_npc_tienda.Size = new Size(360, 553);
            pictureBox_npc_tienda.TabIndex = 1;
            pictureBox_npc_tienda.TabStop = false;
            // 
            // dgridEquipamiento
            // 
            dgridEquipamiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridEquipamiento.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colPrecio, colCodBarras, colTipo, colImagen });
            dgridEquipamiento.Location = new Point(339, 9);
            dgridEquipamiento.Name = "dgridEquipamiento";
            dgridEquipamiento.RowTemplate.Height = 25;
            dgridEquipamiento.Size = new Size(641, 616);
            dgridEquipamiento.TabIndex = 2;
            dgridEquipamiento.CellContentClick += dataGridView1_CellContentClick;
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
            // colCodBarras
            // 
            colCodBarras.HeaderText = "CÓDIGO DE BARRAS";
            colCodBarras.Name = "colCodBarras";
            // 
            // colTipo
            // 
            colTipo.HeaderText = "TIPO";
            colTipo.Name = "colTipo";
            // 
            // colImagen
            // 
            colImagen.HeaderText = "IMAGEN";
            colImagen.ImageLayout = DataGridViewImageCellLayout.Stretch;
            colImagen.Name = "colImagen";
            colImagen.Resizable = DataGridViewTriState.True;
            colImagen.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.MediumPurple;
            txt_id.Font = new Font("Kanit Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txt_id.ForeColor = SystemColors.InactiveBorder;
            txt_id.Location = new Point(986, 210);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(389, 25);
            txt_id.TabIndex = 3;
            txt_id.Text = "ID DEL PRODUCTO";
            txt_id.TextAlign = HorizontalAlignment.Center;
            // 
            // txtnombre
            // 
            txtnombre.BackColor = Color.MediumPurple;
            txtnombre.Font = new Font("Kanit Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txtnombre.ForeColor = SystemColors.InactiveBorder;
            txtnombre.Location = new Point(986, 241);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(389, 25);
            txtnombre.TabIndex = 4;
            txtnombre.Text = "NOMBRE";
            txtnombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txtprecio
            // 
            txtprecio.BackColor = Color.MediumPurple;
            txtprecio.Font = new Font("Kanit Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txtprecio.ForeColor = SystemColors.InactiveBorder;
            txtprecio.Location = new Point(986, 272);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(389, 25);
            txtprecio.TabIndex = 5;
            txtprecio.Text = "PRECIO";
            txtprecio.TextAlign = HorizontalAlignment.Center;
            // 
            // txtcodbarras
            // 
            txtcodbarras.BackColor = Color.MediumPurple;
            txtcodbarras.Font = new Font("Kanit Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txtcodbarras.ForeColor = SystemColors.InactiveBorder;
            txtcodbarras.Location = new Point(986, 303);
            txtcodbarras.Name = "txtcodbarras";
            txtcodbarras.Size = new Size(389, 25);
            txtcodbarras.TabIndex = 6;
            txtcodbarras.Text = "CÓDIGO DE BARRAS";
            txtcodbarras.TextAlign = HorizontalAlignment.Center;
            // 
            // txtimagen
            // 
            txtimagen.BackColor = Color.MediumPurple;
            txtimagen.Font = new Font("Kanit Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            txtimagen.ForeColor = SystemColors.InactiveBorder;
            txtimagen.Location = new Point(986, 334);
            txtimagen.Name = "txtimagen";
            txtimagen.Size = new Size(389, 25);
            txtimagen.TabIndex = 7;
            txtimagen.Text = "IMAGEN";
            txtimagen.TextAlign = HorizontalAlignment.Center;
            // 
            // comboTipo
            // 
            comboTipo.BackColor = Color.MediumPurple;
            comboTipo.Font = new Font("Kanit Black", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            comboTipo.ForeColor = SystemColors.InactiveBorder;
            comboTipo.FormattingEnabled = true;
            comboTipo.Items.AddRange(new object[] { "ESPADA", "HACHA", "LANZA", "ESCUDO", "ARMADURA" });
            comboTipo.Location = new Point(986, 365);
            comboTipo.Name = "comboTipo";
            comboTipo.Size = new Size(389, 27);
            comboTipo.TabIndex = 8;
            comboTipo.Text = "TIPO DE PRODUCTO";
            comboTipo.SelectedIndexChanged += comboTipo_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(192, 255, 192);
            btnGuardar.BackgroundImage = (Image)resources.GetObject("btnGuardar.BackgroundImage");
            btnGuardar.Font = new Font("Anton", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.FromArgb(255, 255, 128);
            btnGuardar.Location = new Point(1035, 398);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 140);
            btnGuardar.TabIndex = 12;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += button1_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackgroundImage = (Image)resources.GetObject("btnBorrar.BackgroundImage");
            btnBorrar.Location = new Point(1193, 565);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(140, 60);
            btnBorrar.TabIndex = 13;
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(192, 255, 192);
            btnModificar.BackgroundImage = (Image)resources.GetObject("btnModificar.BackgroundImage");
            btnModificar.Font = new Font("Anton", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.FromArgb(255, 255, 128);
            btnModificar.Location = new Point(1193, 398);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(140, 140);
            btnModificar.TabIndex = 14;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // CRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(146, 149, 138);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1387, 637);
            Controls.Add(btnModificar);
            Controls.Add(btnBorrar);
            Controls.Add(btnGuardar);
            Controls.Add(comboTipo);
            Controls.Add(txtimagen);
            Controls.Add(txtcodbarras);
            Controls.Add(txtprecio);
            Controls.Add(txtnombre);
            Controls.Add(txt_id);
            Controls.Add(dgridEquipamiento);
            Controls.Add(pictureBox_npc_tienda);
            Controls.Add(label_armeria);
            Name = "CRUD";
            Text = "Caja";
            Load += CRUD_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_npc_tienda).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgridEquipamiento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_armeria;
        private PictureBox pictureBox_npc_tienda;
        private DataGridView dgridEquipamiento;
        private TextBox txt_id;
        private TextBox txtnombre;
        private TextBox txtprecio;
        private TextBox txtcodbarras;
        private TextBox txtimagen;
        private ComboBox comboTipo;
        private Button btnGuardar;
        private Button btnBorrar;
        private Button btnModificar;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colCodBarras;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewImageColumn colImagen;
    }
}