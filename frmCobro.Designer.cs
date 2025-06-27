namespace WinFormsApp1
{
    partial class frmCobro
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
            lblVencimiento = new Label();
            dateFechaPago = new DateTimePicker();
            label1 = new Label();
            txtDni = new TextBox();
            btnCobrar = new Button();
            lblTotal = new Label();
            txtMonto = new TextBox();
            cboCuotas = new ComboBox();
            lblCuotas = new Label();
            btnBuscar = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            chkTarjeta = new RadioButton();
            chkEfectivo = new RadioButton();
            lblMedio = new Label();
            lblTituloCobro = new Label();
            SuspendLayout();
            // 
            // lblVencimiento
            // 
            lblVencimiento.AccessibleName = "lblVencimiento";
            lblVencimiento.AutoSize = true;
            lblVencimiento.Location = new Point(491, 81);
            lblVencimiento.Name = "lblVencimiento";
            lblVencimiento.Size = new Size(111, 15);
            lblVencimiento.TabIndex = 30;
            lblVencimiento.Text = "Nuevo Vencimiento";
            lblVencimiento.Visible = false;
            lblVencimiento.Click += lblVencimiento_Click;
            // 
            // dateFechaPago
            // 
            dateFechaPago.AccessibleName = "dateFechaPago";
            dateFechaPago.Format = DateTimePickerFormat.Short;
            dateFechaPago.Location = new Point(608, 78);
            dateFechaPago.Name = "dateFechaPago";
            dateFechaPago.Size = new Size(106, 23);
            dateFechaPago.TabIndex = 29;
            dateFechaPago.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 87);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 27;
            label1.Text = "Dni";
            label1.Click += label1_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(100, 84);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingrese Dni";
            txtDni.Size = new Size(154, 23);
            txtDni.TabIndex = 28;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // btnCobrar
            // 
            btnCobrar.Location = new Point(378, 362);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(106, 44);
            btnCobrar.TabIndex = 31;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = true;
            btnCobrar.Visible = false;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AccessibleDescription = "";
            lblTotal.AccessibleName = "lblTotal";
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(491, 141);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 15);
            lblTotal.TabIndex = 32;
            lblTotal.Text = "Total $";
            lblTotal.TextAlign = ContentAlignment.TopCenter;
            lblTotal.Visible = false;
            // 
            // txtMonto
            // 
            txtMonto.AccessibleDescription = "";
            txtMonto.AccessibleName = "txtMonto";
            txtMonto.Location = new Point(537, 138);
            txtMonto.Name = "txtMonto";
            txtMonto.PlaceholderText = "Ingrese Monto a cobrar";
            txtMonto.Size = new Size(154, 23);
            txtMonto.TabIndex = 33;
            txtMonto.Visible = false;
            txtMonto.TextChanged += textBox1_TextChanged;
            txtMonto.KeyPress += txtMonto_KeyPress;
            // 
            // cboCuotas
            // 
            cboCuotas.AccessibleName = "cboCuotas";
            cboCuotas.AutoCompleteCustomSource.AddRange(new string[] { "1", "3", "6" });
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1", "3", "6" });
            cboCuotas.Location = new Point(608, 269);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(128, 23);
            cboCuotas.TabIndex = 36;
            cboCuotas.Visible = false;
            // 
            // lblCuotas
            // 
            lblCuotas.AccessibleDescription = "";
            lblCuotas.AccessibleName = "lblCuotas";
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(491, 272);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(111, 15);
            lblCuotas.TabIndex = 37;
            lblCuotas.Text = "Cantidad de Cuotas";
            lblCuotas.TextAlign = ContentAlignment.TopCenter;
            lblCuotas.Visible = false;
            // 
            // btnBuscar
            // 
            btnBuscar.AccessibleName = "btnBuscar";
            btnBuscar.Location = new Point(260, 81);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(58, 26);
            btnBuscar.TabIndex = 38;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AccessibleName = "lblNombre";
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(54, 242);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 39;
            lblNombre.Text = "Nombre";
            lblNombre.Visible = false;
            // 
            // lblApellido
            // 
            lblApellido.AccessibleName = "lblApellido";
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(54, 169);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 41;
            lblApellido.Text = "Apellido";
            lblApellido.Visible = false;
            lblApellido.Click += label2_Click;
            // 
            // txtApellido
            // 
            txtApellido.AccessibleDescription = "";
            txtApellido.AccessibleName = "txtApeliido";
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(131, 166);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(141, 23);
            txtApellido.TabIndex = 42;
            txtApellido.Visible = false;
            // 
            // txtNombre
            // 
            txtNombre.AccessibleDescription = "";
            txtNombre.AccessibleName = "txtNombre";
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(131, 238);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(141, 23);
            txtNombre.TabIndex = 43;
            txtNombre.Visible = false;
            // 
            // chkTarjeta
            // 
            chkTarjeta.AccessibleName = "chkTarjeta";
            chkTarjeta.AutoSize = true;
            chkTarjeta.Location = new Point(603, 209);
            chkTarjeta.Name = "chkTarjeta";
            chkTarjeta.Size = new Size(60, 19);
            chkTarjeta.TabIndex = 44;
            chkTarjeta.TabStop = true;
            chkTarjeta.Text = "Tarjeta";
            chkTarjeta.UseVisualStyleBackColor = true;
            chkTarjeta.Visible = false;
            chkTarjeta.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // chkEfectivo
            // 
            chkEfectivo.AccessibleName = "chkEfectivo";
            chkEfectivo.AutoSize = true;
            chkEfectivo.Location = new Point(669, 209);
            chkEfectivo.Name = "chkEfectivo";
            chkEfectivo.Size = new Size(67, 19);
            chkEfectivo.TabIndex = 45;
            chkEfectivo.TabStop = true;
            chkEfectivo.Text = "Efectivo";
            chkEfectivo.UseVisualStyleBackColor = true;
            chkEfectivo.Visible = false;
            // 
            // lblMedio
            // 
            lblMedio.AccessibleDescription = "";
            lblMedio.AccessibleName = "lblMedio";
            lblMedio.AutoSize = true;
            lblMedio.Location = new Point(491, 211);
            lblMedio.Name = "lblMedio";
            lblMedio.Size = new Size(87, 15);
            lblMedio.TabIndex = 46;
            lblMedio.Text = "Medio de Pago";
            lblMedio.TextAlign = ContentAlignment.TopCenter;
            lblMedio.Visible = false;
            // 
            // lblTituloCobro
            // 
            lblTituloCobro.AutoSize = true;
            lblTituloCobro.Location = new Point(580, 38);
            lblTituloCobro.Name = "lblTituloCobro";
            lblTituloCobro.Size = new Size(47, 15);
            lblTituloCobro.TabIndex = 47;
            lblTituloCobro.Text = "TITULO";
            lblTituloCobro.Visible = false;
            // 
            // frmCobro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTituloCobro);
            Controls.Add(lblMedio);
            Controls.Add(chkEfectivo);
            Controls.Add(chkTarjeta);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(btnBuscar);
            Controls.Add(lblCuotas);
            Controls.Add(cboCuotas);
            Controls.Add(lblTotal);
            Controls.Add(txtMonto);
            Controls.Add(btnCobrar);
            Controls.Add(lblVencimiento);
            Controls.Add(dateFechaPago);
            Controls.Add(label1);
            Controls.Add(txtDni);
            Name = "frmCobro";
            Text = "Cobro";
            Load += frmCobro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVencimiento;
        private DateTimePicker dateFechaPago;
        private Label label1;
        private TextBox txtDni;
        private Button btnCobrar;
        private Label lblTotal;
        private TextBox txtMonto;
        private ComboBox cboCuotas;
        private Label lblCuotas;
        private Button btnBuscar;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private RadioButton chkTarjeta;
        private RadioButton chkEfectivo;
        private Label label2;
        private Label lblMedio;
        private Label lblTituloCobro;
    }
}