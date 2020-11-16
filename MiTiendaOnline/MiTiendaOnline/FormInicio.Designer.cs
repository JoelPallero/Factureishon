namespace MiTiendaOnline
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.TabControlCompra = new System.Windows.Forms.TabControl();
            this.TabProductos = new System.Windows.Forms.TabPage();
            this.CmbAloeVera = new System.Windows.Forms.ComboBox();
            this.CmbAlmendra = new System.Windows.Forms.ComboBox();
            this.CmbManzanilla = new System.Windows.Forms.ComboBox();
            this.CmbCoco = new System.Windows.Forms.ComboBox();
            this.AgregarAlCarrito = new System.Windows.Forms.PictureBox();
            this.LblPrecioAloeVera = new System.Windows.Forms.Label();
            this.LblNombreAloeVera = new System.Windows.Forms.Label();
            this.LblPrecioAlmendra = new System.Windows.Forms.Label();
            this.LblNombreAlmendras = new System.Windows.Forms.Label();
            this.LblPrecioManzanilla = new System.Windows.Forms.Label();
            this.LblNombreManzanilla = new System.Windows.Forms.Label();
            this.LblPrecioCoco = new System.Windows.Forms.Label();
            this.LblNombreCoco = new System.Windows.Forms.Label();
            this.PicAceitePepino = new System.Windows.Forms.PictureBox();
            this.PicAceiteBerenjena = new System.Windows.Forms.PictureBox();
            this.PicAeitelimon = new System.Windows.Forms.PictureBox();
            this.PicAceiteNaranja = new System.Windows.Forms.PictureBox();
            this.PicAceiteAloeVera = new System.Windows.Forms.PictureBox();
            this.PicAceiteAlmendras = new System.Windows.Forms.PictureBox();
            this.PicAceiteManzanilla = new System.Windows.Forms.PictureBox();
            this.PicAceiteCoco = new System.Windows.Forms.PictureBox();
            this.TabCarrito = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodSeguridad = new System.Windows.Forms.TextBox();
            this.CmbTarjetas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNrosTarjeta = new System.Windows.Forms.TextBox();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.LblPrecioFinalFacturado = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.DTProductosCarrito = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabControlCompra.SuspendLayout();
            this.TabProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgregarAlCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAceitePepino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAceiteBerenjena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAeitelimon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAceiteNaranja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAceiteAloeVera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAceiteAlmendras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAceiteManzanilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAceiteCoco)).BeginInit();
            this.TabCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTProductosCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlCompra
            // 
            this.TabControlCompra.Controls.Add(this.TabProductos);
            this.TabControlCompra.Controls.Add(this.TabCarrito);
            this.TabControlCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlCompra.Location = new System.Drawing.Point(0, 0);
            this.TabControlCompra.Name = "TabControlCompra";
            this.TabControlCompra.SelectedIndex = 0;
            this.TabControlCompra.Size = new System.Drawing.Size(798, 501);
            this.TabControlCompra.TabIndex = 0;
            // 
            // TabProductos
            // 
            this.TabProductos.Controls.Add(this.CmbAloeVera);
            this.TabProductos.Controls.Add(this.CmbAlmendra);
            this.TabProductos.Controls.Add(this.CmbManzanilla);
            this.TabProductos.Controls.Add(this.CmbCoco);
            this.TabProductos.Controls.Add(this.AgregarAlCarrito);
            this.TabProductos.Controls.Add(this.LblPrecioAloeVera);
            this.TabProductos.Controls.Add(this.LblNombreAloeVera);
            this.TabProductos.Controls.Add(this.LblPrecioAlmendra);
            this.TabProductos.Controls.Add(this.LblNombreAlmendras);
            this.TabProductos.Controls.Add(this.LblPrecioManzanilla);
            this.TabProductos.Controls.Add(this.LblNombreManzanilla);
            this.TabProductos.Controls.Add(this.LblPrecioCoco);
            this.TabProductos.Controls.Add(this.LblNombreCoco);
            this.TabProductos.Controls.Add(this.PicAceitePepino);
            this.TabProductos.Controls.Add(this.PicAceiteBerenjena);
            this.TabProductos.Controls.Add(this.PicAeitelimon);
            this.TabProductos.Controls.Add(this.PicAceiteNaranja);
            this.TabProductos.Controls.Add(this.PicAceiteAloeVera);
            this.TabProductos.Controls.Add(this.PicAceiteAlmendras);
            this.TabProductos.Controls.Add(this.PicAceiteManzanilla);
            this.TabProductos.Controls.Add(this.PicAceiteCoco);
            this.TabProductos.Location = new System.Drawing.Point(4, 22);
            this.TabProductos.Name = "TabProductos";
            this.TabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.TabProductos.Size = new System.Drawing.Size(790, 475);
            this.TabProductos.TabIndex = 0;
            this.TabProductos.Text = "Productos";
            this.TabProductos.UseVisualStyleBackColor = true;
            // 
            // CmbAloeVera
            // 
            this.CmbAloeVera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAloeVera.FormattingEnabled = true;
            this.CmbAloeVera.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CmbAloeVera.Location = new System.Drawing.Point(700, 199);
            this.CmbAloeVera.Name = "CmbAloeVera";
            this.CmbAloeVera.Size = new System.Drawing.Size(50, 21);
            this.CmbAloeVera.TabIndex = 34;
            // 
            // CmbAlmendra
            // 
            this.CmbAlmendra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAlmendra.FormattingEnabled = true;
            this.CmbAlmendra.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CmbAlmendra.Location = new System.Drawing.Point(513, 199);
            this.CmbAlmendra.Name = "CmbAlmendra";
            this.CmbAlmendra.Size = new System.Drawing.Size(50, 21);
            this.CmbAlmendra.TabIndex = 33;
            // 
            // CmbManzanilla
            // 
            this.CmbManzanilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbManzanilla.FormattingEnabled = true;
            this.CmbManzanilla.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CmbManzanilla.Location = new System.Drawing.Point(326, 199);
            this.CmbManzanilla.Name = "CmbManzanilla";
            this.CmbManzanilla.Size = new System.Drawing.Size(50, 21);
            this.CmbManzanilla.TabIndex = 32;
            // 
            // CmbCoco
            // 
            this.CmbCoco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCoco.FormattingEnabled = true;
            this.CmbCoco.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CmbCoco.Location = new System.Drawing.Point(130, 199);
            this.CmbCoco.Name = "CmbCoco";
            this.CmbCoco.Size = new System.Drawing.Size(50, 21);
            this.CmbCoco.TabIndex = 31;
            // 
            // AgregarAlCarrito
            // 
            this.AgregarAlCarrito.Image = ((System.Drawing.Image)(resources.GetObject("AgregarAlCarrito.Image")));
            this.AgregarAlCarrito.Location = new System.Drawing.Point(700, 236);
            this.AgregarAlCarrito.Name = "AgregarAlCarrito";
            this.AgregarAlCarrito.Size = new System.Drawing.Size(50, 50);
            this.AgregarAlCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AgregarAlCarrito.TabIndex = 30;
            this.AgregarAlCarrito.TabStop = false;
            this.AgregarAlCarrito.Click += new System.EventHandler(this.AgregarAlCarrito_Click);
            // 
            // LblPrecioAloeVera
            // 
            this.LblPrecioAloeVera.AutoSize = true;
            this.LblPrecioAloeVera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioAloeVera.Location = new System.Drawing.Point(597, 200);
            this.LblPrecioAloeVera.Name = "LblPrecioAloeVera";
            this.LblPrecioAloeVera.Size = new System.Drawing.Size(46, 16);
            this.LblPrecioAloeVera.TabIndex = 15;
            this.LblPrecioAloeVera.Text = "$ 1670";
            // 
            // LblNombreAloeVera
            // 
            this.LblNombreAloeVera.AutoSize = true;
            this.LblNombreAloeVera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreAloeVera.Location = new System.Drawing.Point(597, 174);
            this.LblNombreAloeVera.Name = "LblNombreAloeVera";
            this.LblNombreAloeVera.Size = new System.Drawing.Size(128, 16);
            this.LblNombreAloeVera.TabIndex = 14;
            this.LblNombreAloeVera.Text = "Aceite de Aloe Vera";
            // 
            // LblPrecioAlmendra
            // 
            this.LblPrecioAlmendra.AutoSize = true;
            this.LblPrecioAlmendra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioAlmendra.Location = new System.Drawing.Point(410, 200);
            this.LblPrecioAlmendra.Name = "LblPrecioAlmendra";
            this.LblPrecioAlmendra.Size = new System.Drawing.Size(46, 16);
            this.LblPrecioAlmendra.TabIndex = 13;
            this.LblPrecioAlmendra.Text = "$ 1390";
            // 
            // LblNombreAlmendras
            // 
            this.LblNombreAlmendras.AutoSize = true;
            this.LblNombreAlmendras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreAlmendras.Location = new System.Drawing.Point(410, 174);
            this.LblNombreAlmendras.Name = "LblNombreAlmendras";
            this.LblNombreAlmendras.Size = new System.Drawing.Size(126, 16);
            this.LblNombreAlmendras.TabIndex = 12;
            this.LblNombreAlmendras.Text = "Aceite de Almendra";
            // 
            // LblPrecioManzanilla
            // 
            this.LblPrecioManzanilla.AutoSize = true;
            this.LblPrecioManzanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioManzanilla.Location = new System.Drawing.Point(223, 200);
            this.LblPrecioManzanilla.Name = "LblPrecioManzanilla";
            this.LblPrecioManzanilla.Size = new System.Drawing.Size(46, 16);
            this.LblPrecioManzanilla.TabIndex = 11;
            this.LblPrecioManzanilla.Text = "$ 1900";
            // 
            // LblNombreManzanilla
            // 
            this.LblNombreManzanilla.AutoSize = true;
            this.LblNombreManzanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreManzanilla.Location = new System.Drawing.Point(223, 174);
            this.LblNombreManzanilla.Name = "LblNombreManzanilla";
            this.LblNombreManzanilla.Size = new System.Drawing.Size(132, 16);
            this.LblNombreManzanilla.TabIndex = 10;
            this.LblNombreManzanilla.Text = "Aceite de Manzanilla";
            // 
            // LblPrecioCoco
            // 
            this.LblPrecioCoco.AutoSize = true;
            this.LblPrecioCoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioCoco.Location = new System.Drawing.Point(27, 200);
            this.LblPrecioCoco.Name = "LblPrecioCoco";
            this.LblPrecioCoco.Size = new System.Drawing.Size(39, 16);
            this.LblPrecioCoco.TabIndex = 9;
            this.LblPrecioCoco.Text = "$ 950";
            // 
            // LblNombreCoco
            // 
            this.LblNombreCoco.AutoSize = true;
            this.LblNombreCoco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreCoco.Location = new System.Drawing.Point(27, 174);
            this.LblNombreCoco.Name = "LblNombreCoco";
            this.LblNombreCoco.Size = new System.Drawing.Size(100, 16);
            this.LblNombreCoco.TabIndex = 8;
            this.LblNombreCoco.Text = "Aceite de Coco";
            // 
            // PicAceitePepino
            // 
            this.PicAceitePepino.BackColor = System.Drawing.Color.Silver;
            this.PicAceitePepino.Location = new System.Drawing.Point(600, 317);
            this.PicAceitePepino.Name = "PicAceitePepino";
            this.PicAceitePepino.Size = new System.Drawing.Size(150, 150);
            this.PicAceitePepino.TabIndex = 7;
            this.PicAceitePepino.TabStop = false;
            // 
            // PicAceiteBerenjena
            // 
            this.PicAceiteBerenjena.BackColor = System.Drawing.Color.Silver;
            this.PicAceiteBerenjena.Location = new System.Drawing.Point(413, 329);
            this.PicAceiteBerenjena.Name = "PicAceiteBerenjena";
            this.PicAceiteBerenjena.Size = new System.Drawing.Size(150, 150);
            this.PicAceiteBerenjena.TabIndex = 6;
            this.PicAceiteBerenjena.TabStop = false;
            // 
            // PicAeitelimon
            // 
            this.PicAeitelimon.BackColor = System.Drawing.Color.Silver;
            this.PicAeitelimon.Location = new System.Drawing.Point(226, 317);
            this.PicAeitelimon.Name = "PicAeitelimon";
            this.PicAeitelimon.Size = new System.Drawing.Size(150, 150);
            this.PicAeitelimon.TabIndex = 5;
            this.PicAeitelimon.TabStop = false;
            // 
            // PicAceiteNaranja
            // 
            this.PicAceiteNaranja.BackColor = System.Drawing.Color.Silver;
            this.PicAceiteNaranja.Location = new System.Drawing.Point(30, 317);
            this.PicAceiteNaranja.Name = "PicAceiteNaranja";
            this.PicAceiteNaranja.Size = new System.Drawing.Size(150, 150);
            this.PicAceiteNaranja.TabIndex = 4;
            this.PicAceiteNaranja.TabStop = false;
            // 
            // PicAceiteAloeVera
            // 
            this.PicAceiteAloeVera.Image = ((System.Drawing.Image)(resources.GetObject("PicAceiteAloeVera.Image")));
            this.PicAceiteAloeVera.Location = new System.Drawing.Point(600, 21);
            this.PicAceiteAloeVera.Name = "PicAceiteAloeVera";
            this.PicAceiteAloeVera.Size = new System.Drawing.Size(150, 150);
            this.PicAceiteAloeVera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicAceiteAloeVera.TabIndex = 3;
            this.PicAceiteAloeVera.TabStop = false;
            // 
            // PicAceiteAlmendras
            // 
            this.PicAceiteAlmendras.Image = ((System.Drawing.Image)(resources.GetObject("PicAceiteAlmendras.Image")));
            this.PicAceiteAlmendras.Location = new System.Drawing.Point(413, 21);
            this.PicAceiteAlmendras.Name = "PicAceiteAlmendras";
            this.PicAceiteAlmendras.Size = new System.Drawing.Size(150, 150);
            this.PicAceiteAlmendras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicAceiteAlmendras.TabIndex = 2;
            this.PicAceiteAlmendras.TabStop = false;
            // 
            // PicAceiteManzanilla
            // 
            this.PicAceiteManzanilla.Image = ((System.Drawing.Image)(resources.GetObject("PicAceiteManzanilla.Image")));
            this.PicAceiteManzanilla.Location = new System.Drawing.Point(226, 21);
            this.PicAceiteManzanilla.Name = "PicAceiteManzanilla";
            this.PicAceiteManzanilla.Size = new System.Drawing.Size(150, 150);
            this.PicAceiteManzanilla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicAceiteManzanilla.TabIndex = 1;
            this.PicAceiteManzanilla.TabStop = false;
            // 
            // PicAceiteCoco
            // 
            this.PicAceiteCoco.Image = ((System.Drawing.Image)(resources.GetObject("PicAceiteCoco.Image")));
            this.PicAceiteCoco.Location = new System.Drawing.Point(30, 21);
            this.PicAceiteCoco.Name = "PicAceiteCoco";
            this.PicAceiteCoco.Size = new System.Drawing.Size(150, 150);
            this.PicAceiteCoco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicAceiteCoco.TabIndex = 0;
            this.PicAceiteCoco.TabStop = false;
            // 
            // TabCarrito
            // 
            this.TabCarrito.Controls.Add(this.label2);
            this.TabCarrito.Controls.Add(this.TxtCodSeguridad);
            this.TabCarrito.Controls.Add(this.CmbTarjetas);
            this.TabCarrito.Controls.Add(this.label1);
            this.TabCarrito.Controls.Add(this.TxtNrosTarjeta);
            this.TabCarrito.Controls.Add(this.BtnPagar);
            this.TabCarrito.Controls.Add(this.LblPrecioFinalFacturado);
            this.TabCarrito.Controls.Add(this.label17);
            this.TabCarrito.Controls.Add(this.DTProductosCarrito);
            this.TabCarrito.Location = new System.Drawing.Point(4, 22);
            this.TabCarrito.Name = "TabCarrito";
            this.TabCarrito.Padding = new System.Windows.Forms.Padding(3);
            this.TabCarrito.Size = new System.Drawing.Size(790, 475);
            this.TabCarrito.TabIndex = 1;
            this.TabCarrito.Text = "Carrito";
            this.TabCarrito.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Código de Seguridad:";
            // 
            // TxtCodSeguridad
            // 
            this.TxtCodSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodSeguridad.Location = new System.Drawing.Point(707, 135);
            this.TxtCodSeguridad.Name = "TxtCodSeguridad";
            this.TxtCodSeguridad.Size = new System.Drawing.Size(75, 23);
            this.TxtCodSeguridad.TabIndex = 33;
            this.TxtCodSeguridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNrosTarjeta_KeyPress);
            // 
            // CmbTarjetas
            // 
            this.CmbTarjetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTarjetas.FormattingEnabled = true;
            this.CmbTarjetas.Items.AddRange(new object[] {
            "Visa",
            "Amex",
            "Cabal",
            "Naranja",
            "Queseyo"});
            this.CmbTarjetas.Location = new System.Drawing.Point(638, 52);
            this.CmbTarjetas.Name = "CmbTarjetas";
            this.CmbTarjetas.Size = new System.Drawing.Size(144, 21);
            this.CmbTarjetas.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nro de Tarjeta:";
            // 
            // TxtNrosTarjeta
            // 
            this.TxtNrosTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNrosTarjeta.Location = new System.Drawing.Point(520, 100);
            this.TxtNrosTarjeta.Name = "TxtNrosTarjeta";
            this.TxtNrosTarjeta.Size = new System.Drawing.Size(262, 23);
            this.TxtNrosTarjeta.TabIndex = 12;
            this.TxtNrosTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNrosTarjeta_KeyPress);
            // 
            // BtnPagar
            // 
            this.BtnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPagar.Location = new System.Drawing.Point(523, 197);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(262, 65);
            this.BtnPagar.TabIndex = 11;
            this.BtnPagar.Text = "Pagar";
            this.BtnPagar.UseVisualStyleBackColor = true;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // LblPrecioFinalFacturado
            // 
            this.LblPrecioFinalFacturado.AutoSize = true;
            this.LblPrecioFinalFacturado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioFinalFacturado.Location = new System.Drawing.Point(441, 431);
            this.LblPrecioFinalFacturado.Name = "LblPrecioFinalFacturado";
            this.LblPrecioFinalFacturado.Size = new System.Drawing.Size(72, 20);
            this.LblPrecioFinalFacturado.TabIndex = 10;
            this.LblPrecioFinalFacturado.Text = "0000000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(387, 431);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 20);
            this.label17.TabIndex = 9;
            this.label17.Text = "Total:";
            // 
            // DTProductosCarrito
            // 
            this.DTProductosCarrito.AllowUserToAddRows = false;
            this.DTProductosCarrito.AllowUserToDeleteRows = false;
            this.DTProductosCarrito.AllowUserToResizeColumns = false;
            this.DTProductosCarrito.AllowUserToResizeRows = false;
            this.DTProductosCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DTProductosCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio,
            this.Cantidad,
            this.PrecioTotal});
            this.DTProductosCarrito.Location = new System.Drawing.Point(8, 38);
            this.DTProductosCarrito.Name = "DTProductosCarrito";
            this.DTProductosCarrito.ReadOnly = true;
            this.DTProductosCarrito.RowHeadersVisible = false;
            this.DTProductosCarrito.Size = new System.Drawing.Size(505, 381);
            this.DTProductosCarrito.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.HeaderText = "Producto";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 200;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio Unitario";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.HeaderText = "$ PrecioTotal";
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.ReadOnly = true;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 501);
            this.Controls.Add(this.TabControlCompra);
            this.MaximumSize = new System.Drawing.Size(814, 540);
            this.MinimumSize = new System.Drawing.Size(814, 540);
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInicio";
            this.TabControlCompra.ResumeLayout(false);
            this.TabProductos.ResumeLayout(false);
            this.TabProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgregarAlCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAceitePepino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAceiteBerenjena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAeitelimon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAceiteNaranja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAceiteAloeVera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAceiteAlmendras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAceiteManzanilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAceiteCoco)).EndInit();
            this.TabCarrito.ResumeLayout(false);
            this.TabCarrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTProductosCarrito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlCompra;
        private System.Windows.Forms.TabPage TabProductos;
        private System.Windows.Forms.TabPage TabCarrito;
        private System.Windows.Forms.PictureBox PicAceiteAloeVera;
        private System.Windows.Forms.PictureBox PicAceiteAlmendras;
        private System.Windows.Forms.PictureBox PicAceiteManzanilla;
        private System.Windows.Forms.PictureBox PicAceiteCoco;
        private System.Windows.Forms.Label LblPrecioAloeVera;
        private System.Windows.Forms.Label LblNombreAloeVera;
        private System.Windows.Forms.Label LblPrecioAlmendra;
        private System.Windows.Forms.Label LblNombreAlmendras;
        private System.Windows.Forms.Label LblPrecioManzanilla;
        private System.Windows.Forms.Label LblNombreManzanilla;
        private System.Windows.Forms.Label LblPrecioCoco;
        private System.Windows.Forms.Label LblNombreCoco;
        private System.Windows.Forms.Label LblPrecioFinalFacturado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView DTProductosCarrito;
        private System.Windows.Forms.PictureBox AgregarAlCarrito;
        private System.Windows.Forms.ComboBox CmbManzanilla;
        private System.Windows.Forms.ComboBox CmbCoco;
        private System.Windows.Forms.ComboBox CmbAloeVera;
        private System.Windows.Forms.ComboBox CmbAlmendra;
        private System.Windows.Forms.PictureBox PicAceitePepino;
        private System.Windows.Forms.PictureBox PicAceiteBerenjena;
        private System.Windows.Forms.PictureBox PicAeitelimon;
        private System.Windows.Forms.PictureBox PicAceiteNaranja;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodSeguridad;
        private System.Windows.Forms.ComboBox CmbTarjetas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNrosTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
    }
}