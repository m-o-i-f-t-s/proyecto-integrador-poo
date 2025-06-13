namespace WinFormsApp1
{
    partial class frmRegistroSocio
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
            btnRegistrar = new Button();
            cboAptoFisico = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtDni = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            dateFechaPago = new DateTimePicker();
            label7 = new Label();
            cboEntregaCarnet = new ComboBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(600, 361);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(106, 44);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // cboAptoFisico
            // 
            cboAptoFisico.FormattingEnabled = true;
            cboAptoFisico.Items.AddRange(new object[] { "Si", "No" });
            cboAptoFisico.Location = new Point(141, 313);
            cboAptoFisico.Name = "cboAptoFisico";
            cboAptoFisico.Size = new Size(121, 23);
            cboAptoFisico.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 313);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 23;
            label6.Text = "AptoFisico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 248);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 22;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(141, 245);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "INGRESE EL EMAIL";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 192);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 20;
            label4.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(141, 189);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "TELEFONO";
            txtTelefono.Size = new Size(154, 23);
            txtTelefono.TabIndex = 19;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 134);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 18;
            label3.Text = "Dni";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(141, 131);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "DNI";
            txtDni.Size = new Size(154, 23);
            txtDni.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 83);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 16;
            label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(141, 80);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "APELLIDO";
            txtApellido.Size = new Size(154, 23);
            txtApellido.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 31);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 13;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(141, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "NOMBRE";
            txtNombre.Size = new Size(154, 23);
            txtNombre.TabIndex = 14;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // dateFechaPago
            // 
            dateFechaPago.Format = DateTimePickerFormat.Short;
            dateFechaPago.Location = new Point(459, 54);
            dateFechaPago.Name = "dateFechaPago";
            dateFechaPago.Size = new Size(106, 23);
            dateFechaPago.TabIndex = 25;
            dateFechaPago.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(459, 36);
            label7.Name = "label7";
            label7.Size = new Size(124, 15);
            label7.TabIndex = 26;
            label7.Text = "Fecha De Vencimiento";
            label7.Click += label7_Click;
            // 
            // cboEntregaCarnet
            // 
            cboEntregaCarnet.FormattingEnabled = true;
            cboEntregaCarnet.Items.AddRange(new object[] { "Si", "No" });
            cboEntregaCarnet.Location = new Point(143, 382);
            cboEntregaCarnet.Name = "cboEntregaCarnet";
            cboEntregaCarnet.Size = new Size(121, 23);
            cboEntregaCarnet.TabIndex = 28;
            cboEntregaCarnet.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 385);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 27;
            label8.Text = "Entrega Carnet";
            // 
            // frmRegistroSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboEntregaCarnet);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dateFechaPago);
            Controls.Add(btnRegistrar);
            Controls.Add(cboAptoFisico);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtDni);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "frmRegistroSocio";
            Text = "Registro Socio";
            Load += frmRegistroSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private ComboBox cboAptoFisico;
        private Label label6;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtDni;
        private Label label2;
        private TextBox txtApellido;
        private Label label1;
        private TextBox txtNombre;
        private DateTimePicker datePick;
        private Label label7;
        private DateTimePicker dateFechaPago;
        private ComboBox cboEntregaCarnet;
        private Label label8;
    }
}