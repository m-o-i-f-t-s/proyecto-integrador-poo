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
            label7 = new Label();
            dateFechaPago = new DateTimePicker();
            label1 = new Label();
            txtDni = new TextBox();
            btnCobrar = new Button();
            label2 = new Label();
            txtMonto = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            cboCuotas = new ComboBox();
            label3 = new Label();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(491, 84);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 30;
            label7.Text = "Nuevo Vencimiento";
            label7.Visible = false;
            // 
            // dateFechaPago
            // 
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
            label1.Location = new Point(45, 81);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 27;
            label1.Text = "Dni";
            label1.Click += label1_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(182, 84);
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
            // label2
            // 
            label2.AccessibleDescription = "";
            label2.AccessibleName = "";
            label2.AutoSize = true;
            label2.Location = new Point(45, 147);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 32;
            label2.Text = "Precio de Actividad";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Visible = false;
            // 
            // txtMonto
            // 
            txtMonto.AccessibleDescription = "";
            txtMonto.AccessibleName = "txtMonto";
            txtMonto.Location = new Point(182, 139);
            txtMonto.Name = "txtMonto";
            txtMonto.PlaceholderText = "Ingrese Monto a cobrar";
            txtMonto.Size = new Size(154, 23);
            txtMonto.TabIndex = 33;
            txtMonto.Visible = false;
            txtMonto.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(182, 215);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 19);
            checkBox1.TabIndex = 34;
            checkBox1.Text = "Efectivo";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(45, 215);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(61, 19);
            checkBox2.TabIndex = 35;
            checkBox2.Text = "Tarjeta";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Visible = false;
            // 
            // cboCuotas
            // 
            cboCuotas.AutoCompleteCustomSource.AddRange(new string[] { "3", "6" });
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Location = new Point(182, 278);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(128, 23);
            cboCuotas.TabIndex = 36;
            cboCuotas.Visible = false;
            // 
            // label3
            // 
            label3.AccessibleDescription = "";
            label3.AccessibleName = "";
            label3.AutoSize = true;
            label3.Location = new Point(45, 286);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 37;
            label3.Text = "Cantidad de Cuotas";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Visible = false;
            // 
            // btnBuscar
            // 
            btnBuscar.AccessibleName = "btnBuscar";
            btnBuscar.Location = new Point(342, 84);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(58, 26);
            btnBuscar.TabIndex = 38;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmCobro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(label3);
            Controls.Add(cboCuotas);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(txtMonto);
            Controls.Add(btnCobrar);
            Controls.Add(label7);
            Controls.Add(dateFechaPago);
            Controls.Add(label1);
            Controls.Add(txtDni);
            Name = "frmCobro";
            Text = "Cobro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private DateTimePicker dateFechaPago;
        private Label label1;
        private TextBox txtDni;
        private Button btnCobrar;
        private Label label2;
        private TextBox txtMonto;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private ComboBox cboCuotas;
        private Label label3;
        private Button btnBuscar;
    }
}