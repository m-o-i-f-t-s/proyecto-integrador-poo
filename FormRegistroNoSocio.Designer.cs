namespace WinFormsApp1
{
    partial class FormRegistroNoSocio
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
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtDni = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            cboAptoFisico = new ComboBox();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(304, 81);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "NOMBRE";
            txtNombre.Size = new Size(154, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 84);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 136);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(304, 133);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "APELLIDO";
            txtApellido.Size = new Size(154, 23);
            txtApellido.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(215, 187);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 5;
            label3.Text = "Dni";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(304, 184);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "DNI";
            txtDni.Size = new Size(154, 23);
            txtDni.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 245);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(304, 242);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PlaceholderText = "TELEFONO";
            txtTelefono.Size = new Size(154, 23);
            txtTelefono.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 301);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(304, 298);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "INGRESE EL EMAIL";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(215, 366);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 10;
            label6.Text = "AptoFisico";
            // 
            // cboAptoFisico
            // 
            cboAptoFisico.FormattingEnabled = true;
            cboAptoFisico.Items.AddRange(new object[] { "Si", "No" });
            cboAptoFisico.Location = new Point(304, 366);
            cboAptoFisico.Name = "cboAptoFisico";
            cboAptoFisico.Size = new Size(121, 23);
            cboAptoFisico.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(533, 163);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(106, 44);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // FormRegistroNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "FormRegistroNoSocio";
            Text = "frmRegistroNoSocio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtDni;
        private Label label4;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
        private ComboBox cboAptoFisico;
        private Button btnRegistrar;
    }
}