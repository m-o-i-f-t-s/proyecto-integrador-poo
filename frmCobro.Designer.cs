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
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(105, 166);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 30;
            label7.Text = "Nuevo Vencimiento";
            // 
            // dateFechaPago
            // 
            dateFechaPago.Format = DateTimePickerFormat.Short;
            dateFechaPago.Location = new Point(242, 166);
            dateFechaPago.Name = "dateFechaPago";
            dateFechaPago.Size = new Size(106, 23);
            dateFechaPago.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 81);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 27;
            label1.Text = "Dni Socio";
            label1.Click += label1_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(194, 78);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Dni Socio";
            txtDni.Size = new Size(154, 23);
            txtDni.TabIndex = 28;
            // 
            // btnCobrar
            // 
            btnCobrar.Location = new Point(242, 297);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(106, 44);
            btnCobrar.TabIndex = 31;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = true;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // frmCobro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}