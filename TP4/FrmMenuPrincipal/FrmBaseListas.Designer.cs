
namespace Formularios
{
    partial class FrmBaseListas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaseListas));
            this.dgv_Vehiculos = new System.Windows.Forms.DataGridView();
            this.cmb_CantidadPuertas = new System.Windows.Forms.ComboBox();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_TipoDeCombustible = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_TipoDeTransmision = new System.Windows.Forms.Label();
            this.cmb_TipoDeCombustible = new System.Windows.Forms.ComboBox();
            this.cmb_TipoDeTransmision = new System.Windows.Forms.ComboBox();
            this.cmb_Color = new System.Windows.Forms.ComboBox();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.btn_Exportar = new System.Windows.Forms.Button();
            this.lbl_CantidadDePuertas = new System.Windows.Forms.Label();
            this.lbl_TipoVehiculo = new System.Windows.Forms.Label();
            this.cmb_TipoVehiculo = new System.Windows.Forms.ComboBox();
            this.lbl_Errores = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.cmb_MarcaMotocicleta = new System.Windows.Forms.ComboBox();
            this.pnl_Filtros = new System.Windows.Forms.Panel();
            this.txt_PrecioHasta = new System.Windows.Forms.TextBox();
            this.txt_KmHasta = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Km = new System.Windows.Forms.Label();
            this.cmb_MarcaAutomovil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.lbl_Seleccione = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GuardarCambios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vehiculos)).BeginInit();
            this.pnl_Filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_GuardarCambios
            // 
            this.pb_GuardarCambios.Location = new System.Drawing.Point(884, 9);
            // 
            // lbl_GuardarCambios
            // 
            this.lbl_GuardarCambios.Location = new System.Drawing.Point(911, 9);
            // 
            // dgv_Vehiculos
            // 
            this.dgv_Vehiculos.AllowUserToAddRows = false;
            this.dgv_Vehiculos.AllowUserToDeleteRows = false;
            this.dgv_Vehiculos.AllowUserToResizeColumns = false;
            this.dgv_Vehiculos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Vehiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Vehiculos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Vehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Vehiculos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Vehiculos.GridColor = System.Drawing.Color.Black;
            this.dgv_Vehiculos.Location = new System.Drawing.Point(12, 176);
            this.dgv_Vehiculos.MultiSelect = false;
            this.dgv_Vehiculos.Name = "dgv_Vehiculos";
            this.dgv_Vehiculos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Vehiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Vehiculos.RowTemplate.Height = 25;
            this.dgv_Vehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Vehiculos.ShowCellErrors = false;
            this.dgv_Vehiculos.ShowCellToolTips = false;
            this.dgv_Vehiculos.ShowEditingIcon = false;
            this.dgv_Vehiculos.ShowRowErrors = false;
            this.dgv_Vehiculos.Size = new System.Drawing.Size(947, 276);
            this.dgv_Vehiculos.TabIndex = 0;
            this.dgv_Vehiculos.TabStop = false;
            this.dgv_Vehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Vehiculos_CellContentClick_1);
            // 
            // cmb_CantidadPuertas
            // 
            this.cmb_CantidadPuertas.BackColor = System.Drawing.Color.White;
            this.cmb_CantidadPuertas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_CantidadPuertas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CantidadPuertas.FormattingEnabled = true;
            this.cmb_CantidadPuertas.Location = new System.Drawing.Point(538, 44);
            this.cmb_CantidadPuertas.Name = "cmb_CantidadPuertas";
            this.cmb_CantidadPuertas.Size = new System.Drawing.Size(62, 23);
            this.cmb_CantidadPuertas.TabIndex = 1;
            this.cmb_CantidadPuertas.Visible = false;
            this.cmb_CantidadPuertas.SelectedIndexChanged += new System.EventHandler(this.cmb_CantidadPuertas_SelectedIndexChanged);
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Marca.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Marca.Location = new System.Drawing.Point(62, 57);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(43, 15);
            this.lbl_Marca.TabIndex = 6;
            this.lbl_Marca.Text = "Marca";
            // 
            // lbl_TipoDeCombustible
            // 
            this.lbl_TipoDeCombustible.AutoSize = true;
            this.lbl_TipoDeCombustible.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TipoDeCombustible.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TipoDeCombustible.Location = new System.Drawing.Point(224, 21);
            this.lbl_TipoDeCombustible.Name = "lbl_TipoDeCombustible";
            this.lbl_TipoDeCombustible.Size = new System.Drawing.Size(118, 15);
            this.lbl_TipoDeCombustible.TabIndex = 7;
            this.lbl_TipoDeCombustible.Text = "Tipo de Combustible";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Calibri", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.Location = new System.Drawing.Point(395, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(94, 39);
            this.lbl_Titulo.TabIndex = 8;
            this.lbl_Titulo.Text = "Titulo";
            // 
            // lbl_TipoDeTransmision
            // 
            this.lbl_TipoDeTransmision.AutoSize = true;
            this.lbl_TipoDeTransmision.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TipoDeTransmision.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TipoDeTransmision.Location = new System.Drawing.Point(230, 52);
            this.lbl_TipoDeTransmision.Name = "lbl_TipoDeTransmision";
            this.lbl_TipoDeTransmision.Size = new System.Drawing.Size(112, 15);
            this.lbl_TipoDeTransmision.TabIndex = 9;
            this.lbl_TipoDeTransmision.Text = "Tipo de Tranmisión";
            // 
            // cmb_TipoDeCombustible
            // 
            this.cmb_TipoDeCombustible.BackColor = System.Drawing.Color.White;
            this.cmb_TipoDeCombustible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_TipoDeCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoDeCombustible.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_TipoDeCombustible.FormattingEnabled = true;
            this.cmb_TipoDeCombustible.Location = new System.Drawing.Point(348, 13);
            this.cmb_TipoDeCombustible.Name = "cmb_TipoDeCombustible";
            this.cmb_TipoDeCombustible.Size = new System.Drawing.Size(118, 23);
            this.cmb_TipoDeCombustible.TabIndex = 4;
            this.cmb_TipoDeCombustible.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoDeCombustible_SelectedIndexChanged);
            // 
            // cmb_TipoDeTransmision
            // 
            this.cmb_TipoDeTransmision.BackColor = System.Drawing.Color.White;
            this.cmb_TipoDeTransmision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_TipoDeTransmision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoDeTransmision.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_TipoDeTransmision.FormattingEnabled = true;
            this.cmb_TipoDeTransmision.Location = new System.Drawing.Point(348, 46);
            this.cmb_TipoDeTransmision.Name = "cmb_TipoDeTransmision";
            this.cmb_TipoDeTransmision.Size = new System.Drawing.Size(118, 23);
            this.cmb_TipoDeTransmision.TabIndex = 5;
            this.cmb_TipoDeTransmision.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoDeTransmision_SelectedIndexChanged);
            // 
            // cmb_Color
            // 
            this.cmb_Color.BackColor = System.Drawing.Color.White;
            this.cmb_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Color.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Color.FormattingEnabled = true;
            this.cmb_Color.Location = new System.Drawing.Point(538, 13);
            this.cmb_Color.Name = "cmb_Color";
            this.cmb_Color.Size = new System.Drawing.Size(101, 23);
            this.cmb_Color.TabIndex = 6;
            this.cmb_Color.SelectedIndexChanged += new System.EventHandler(this.cmb_Color_SelectedIndexChanged);
            // 
            // lbl_Color
            // 
            this.lbl_Color.AutoSize = true;
            this.lbl_Color.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Color.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Color.Location = new System.Drawing.Point(495, 21);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(37, 15);
            this.lbl_Color.TabIndex = 13;
            this.lbl_Color.Text = "Color";
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Exportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exportar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Exportar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Exportar.Location = new System.Drawing.Point(855, 140);
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(104, 30);
            this.btn_Exportar.TabIndex = 14;
            this.btn_Exportar.Text = "EXPORTAR";
            this.btn_Exportar.UseVisualStyleBackColor = false;
            this.btn_Exportar.Visible = false;
            this.btn_Exportar.Click += new System.EventHandler(this.btn_Exportar_Click);
            // 
            // lbl_CantidadDePuertas
            // 
            this.lbl_CantidadDePuertas.AutoSize = true;
            this.lbl_CantidadDePuertas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CantidadDePuertas.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CantidadDePuertas.Location = new System.Drawing.Point(482, 52);
            this.lbl_CantidadDePuertas.Name = "lbl_CantidadDePuertas";
            this.lbl_CantidadDePuertas.Size = new System.Drawing.Size(49, 15);
            this.lbl_CantidadDePuertas.TabIndex = 15;
            this.lbl_CantidadDePuertas.Text = "Puertas";
            this.lbl_CantidadDePuertas.Visible = false;
            // 
            // lbl_TipoVehiculo
            // 
            this.lbl_TipoVehiculo.AutoSize = true;
            this.lbl_TipoVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TipoVehiculo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TipoVehiculo.Location = new System.Drawing.Point(8, 21);
            this.lbl_TipoVehiculo.Name = "lbl_TipoVehiculo";
            this.lbl_TipoVehiculo.Size = new System.Drawing.Size(96, 15);
            this.lbl_TipoVehiculo.TabIndex = 17;
            this.lbl_TipoVehiculo.Text = "Tipo de Vehículo";
            // 
            // cmb_TipoVehiculo
            // 
            this.cmb_TipoVehiculo.BackColor = System.Drawing.Color.White;
            this.cmb_TipoVehiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_TipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoVehiculo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_TipoVehiculo.FormattingEnabled = true;
            this.cmb_TipoVehiculo.Location = new System.Drawing.Point(111, 13);
            this.cmb_TipoVehiculo.Name = "cmb_TipoVehiculo";
            this.cmb_TipoVehiculo.Size = new System.Drawing.Size(101, 23);
            this.cmb_TipoVehiculo.TabIndex = 0;
            this.cmb_TipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoVehiculo_SelectedIndexChanged);
            // 
            // lbl_Errores
            // 
            this.lbl_Errores.AutoSize = true;
            this.lbl_Errores.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Errores.ForeColor = System.Drawing.Color.Red;
            this.lbl_Errores.Location = new System.Drawing.Point(12, 154);
            this.lbl_Errores.Name = "lbl_Errores";
            this.lbl_Errores.Size = new System.Drawing.Size(89, 19);
            this.lbl_Errores.TabIndex = 18;
            this.lbl_Errores.Text = "Excepciones";
            this.lbl_Errores.Visible = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "NombreArchivo";
            this.saveFileDialog.Filter = "CSV files (*.csv)|*.csv|Excel Files|*.xls;*.xlsx";
            // 
            // cmb_MarcaMotocicleta
            // 
            this.cmb_MarcaMotocicleta.BackColor = System.Drawing.Color.White;
            this.cmb_MarcaMotocicleta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_MarcaMotocicleta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MarcaMotocicleta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_MarcaMotocicleta.FormattingEnabled = true;
            this.cmb_MarcaMotocicleta.Location = new System.Drawing.Point(111, 49);
            this.cmb_MarcaMotocicleta.Name = "cmb_MarcaMotocicleta";
            this.cmb_MarcaMotocicleta.Size = new System.Drawing.Size(101, 23);
            this.cmb_MarcaMotocicleta.TabIndex = 2;
            this.cmb_MarcaMotocicleta.Visible = false;
            this.cmb_MarcaMotocicleta.SelectedIndexChanged += new System.EventHandler(this.cmb_MarcaMotocicleta_SelectedIndexChanged);
            // 
            // pnl_Filtros
            // 
            this.pnl_Filtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnl_Filtros.Controls.Add(this.txt_PrecioHasta);
            this.pnl_Filtros.Controls.Add(this.txt_KmHasta);
            this.pnl_Filtros.Controls.Add(this.lbl_Precio);
            this.pnl_Filtros.Controls.Add(this.lbl_Km);
            this.pnl_Filtros.Controls.Add(this.cmb_MarcaAutomovil);
            this.pnl_Filtros.Controls.Add(this.cmb_MarcaMotocicleta);
            this.pnl_Filtros.Controls.Add(this.lbl_CantidadDePuertas);
            this.pnl_Filtros.Controls.Add(this.lbl_Marca);
            this.pnl_Filtros.Controls.Add(this.cmb_TipoVehiculo);
            this.pnl_Filtros.Controls.Add(this.cmb_TipoDeTransmision);
            this.pnl_Filtros.Controls.Add(this.cmb_Color);
            this.pnl_Filtros.Controls.Add(this.cmb_TipoDeCombustible);
            this.pnl_Filtros.Controls.Add(this.lbl_TipoVehiculo);
            this.pnl_Filtros.Controls.Add(this.lbl_TipoDeCombustible);
            this.pnl_Filtros.Controls.Add(this.lbl_TipoDeTransmision);
            this.pnl_Filtros.Controls.Add(this.lbl_Color);
            this.pnl_Filtros.Controls.Add(this.cmb_CantidadPuertas);
            this.pnl_Filtros.Location = new System.Drawing.Point(12, 54);
            this.pnl_Filtros.Name = "pnl_Filtros";
            this.pnl_Filtros.Size = new System.Drawing.Size(877, 80);
            this.pnl_Filtros.TabIndex = 19;
            // 
            // txt_PrecioHasta
            // 
            this.txt_PrecioHasta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_PrecioHasta.Location = new System.Drawing.Point(765, 13);
            this.txt_PrecioHasta.Name = "txt_PrecioHasta";
            this.txt_PrecioHasta.Size = new System.Drawing.Size(100, 23);
            this.txt_PrecioHasta.TabIndex = 24;
            this.txt_PrecioHasta.TextChanged += new System.EventHandler(this.txt_PrecioHasta_TextChanged);
            // 
            // txt_KmHasta
            // 
            this.txt_KmHasta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_KmHasta.Location = new System.Drawing.Point(765, 44);
            this.txt_KmHasta.Name = "txt_KmHasta";
            this.txt_KmHasta.Size = new System.Drawing.Size(100, 23);
            this.txt_KmHasta.TabIndex = 23;
            this.txt_KmHasta.TextChanged += new System.EventHandler(this.txt_KmHasta_TextChanged);
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Precio.Location = new System.Drawing.Point(680, 21);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(79, 15);
            this.lbl_Precio.TabIndex = 21;
            this.lbl_Precio.Text = "Precio, hasta";
            // 
            // lbl_Km
            // 
            this.lbl_Km.AutoSize = true;
            this.lbl_Km.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Km.Location = new System.Drawing.Point(655, 52);
            this.lbl_Km.Name = "lbl_Km";
            this.lbl_Km.Size = new System.Drawing.Size(104, 15);
            this.lbl_Km.TabIndex = 19;
            this.lbl_Km.Text = "Kilómetros, hasta";
            // 
            // cmb_MarcaAutomovil
            // 
            this.cmb_MarcaAutomovil.BackColor = System.Drawing.Color.White;
            this.cmb_MarcaAutomovil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_MarcaAutomovil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MarcaAutomovil.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_MarcaAutomovil.FormattingEnabled = true;
            this.cmb_MarcaAutomovil.Location = new System.Drawing.Point(111, 49);
            this.cmb_MarcaAutomovil.Name = "cmb_MarcaAutomovil";
            this.cmb_MarcaAutomovil.Size = new System.Drawing.Size(101, 23);
            this.cmb_MarcaAutomovil.TabIndex = 18;
            this.cmb_MarcaAutomovil.Visible = false;
            this.cmb_MarcaAutomovil.SelectedIndexChanged += new System.EventHandler(this.cmb_MarcaAutomovil_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Filtrar por:";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Agregar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Agregar.Location = new System.Drawing.Point(543, 140);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(98, 30);
            this.btn_Agregar.TabIndex = 57;
            this.btn_Agregar.Text = "AGREGAR";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Visible = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Eliminar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Eliminar.Location = new System.Drawing.Point(751, 140);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(98, 30);
            this.btn_Eliminar.TabIndex = 56;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Visible = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Modificar.Enabled = false;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Modificar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Modificar.Location = new System.Drawing.Point(647, 141);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(98, 30);
            this.btn_Modificar.TabIndex = 55;
            this.btn_Modificar.Text = "MODIFICAR";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Visible = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // lbl_Seleccione
            // 
            this.lbl_Seleccione.AutoSize = true;
            this.lbl_Seleccione.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Seleccione.Location = new System.Drawing.Point(12, 137);
            this.lbl_Seleccione.Name = "lbl_Seleccione";
            this.lbl_Seleccione.Size = new System.Drawing.Size(228, 13);
            this.lbl_Seleccione.TabIndex = 58;
            this.lbl_Seleccione.Text = "- Haga doble click para seleccionar un vehículo.";
            // 
            // FrmBaseListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 465);
            this.Controls.Add(this.lbl_Seleccione);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Errores);
            this.Controls.Add(this.btn_Exportar);
            this.Controls.Add(this.dgv_Vehiculos);
            this.Controls.Add(this.pnl_Filtros);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBaseListas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes - VLMOTORS";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.Controls.SetChildIndex(this.lbl_Titulo, 0);
            this.Controls.SetChildIndex(this.pnl_Filtros, 0);
            this.Controls.SetChildIndex(this.dgv_Vehiculos, 0);
            this.Controls.SetChildIndex(this.btn_Exportar, 0);
            this.Controls.SetChildIndex(this.lbl_Errores, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbl_GuardarCambios, 0);
            this.Controls.SetChildIndex(this.pb_GuardarCambios, 0);
            this.Controls.SetChildIndex(this.btn_Modificar, 0);
            this.Controls.SetChildIndex(this.btn_Eliminar, 0);
            this.Controls.SetChildIndex(this.btn_Agregar, 0);
            this.Controls.SetChildIndex(this.lbl_Seleccione, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pb_GuardarCambios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vehiculos)).EndInit();
            this.pnl_Filtros.ResumeLayout(false);
            this.pnl_Filtros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        public System.Windows.Forms.DataGridView dgv_Vehiculos;
        public System.Windows.Forms.ComboBox cmb_CantidadPuertas;
        public System.Windows.Forms.Label lbl_Marca;
        public System.Windows.Forms.Label lbl_TipoDeCombustible;
        public System.Windows.Forms.Label lbl_Titulo;
        public System.Windows.Forms.Label lbl_TipoDeTransmision;
        public System.Windows.Forms.ComboBox cmb_TipoDeCombustible;
        public System.Windows.Forms.ComboBox cmb_TipoDeTransmision;
        public System.Windows.Forms.ComboBox cmb_Color;
        public System.Windows.Forms.Label lbl_Color;
        public System.Windows.Forms.Button btn_Exportar;
        public System.Windows.Forms.Label lbl_CantidadDePuertas;
        public System.Windows.Forms.Label lbl_TipoVehiculo;
        public System.Windows.Forms.ComboBox cmb_TipoVehiculo;
        public System.Windows.Forms.Label lbl_Errores;
        public System.Windows.Forms.ComboBox cmb_MarcaMotocicleta;
        public System.Windows.Forms.ComboBox cmb_MarcaAutomovil;
        public System.Windows.Forms.TextBox txt_PrecioHasta;
        public System.Windows.Forms.TextBox txt_KmHasta;
        public System.Windows.Forms.Label lbl_Precio;
        public System.Windows.Forms.Label lbl_Km;
        public System.Windows.Forms.Panel pnl_Filtros;
        public System.Windows.Forms.Button btn_Agregar;
        public System.Windows.Forms.Button btn_Eliminar;
        public System.Windows.Forms.Button btn_Modificar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_Seleccione;
    }
}