namespace WinFormsApp1
{
    partial class frmClub
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
            btnRegistrarNoSocio = new Button();
            btnRegistrarSocio = new Button();
            btnCobrar = new Button();
            btnListarVencimientos = new Button();
            SuspendLayout();
            // 
            // btnRegistrarNoSocio
            // 
            btnRegistrarNoSocio.ImeMode = ImeMode.NoControl;
            btnRegistrarNoSocio.Location = new Point(106, 68);
            btnRegistrarNoSocio.Name = "btnRegistrarNoSocio";
            btnRegistrarNoSocio.Size = new Size(120, 48);
            btnRegistrarNoSocio.TabIndex = 7;
            btnRegistrarNoSocio.Text = "Registrar No Socio";
            btnRegistrarNoSocio.UseVisualStyleBackColor = true;
            btnRegistrarNoSocio.Click += btnRegistrarNoSocio_Click;
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.ImeMode = ImeMode.NoControl;
            btnRegistrarSocio.Location = new Point(508, 306);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(120, 48);
            btnRegistrarSocio.TabIndex = 8;
            btnRegistrarSocio.Text = "Registrar Socio";
            btnRegistrarSocio.UseVisualStyleBackColor = true;
            // 
            // btnCobrar
            // 
            btnCobrar.ImeMode = ImeMode.NoControl;
            btnCobrar.Location = new Point(106, 306);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(120, 48);
            btnCobrar.TabIndex = 9;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = true;
            // 
            // btnListarVencimientos
            // 
            btnListarVencimientos.ImeMode = ImeMode.NoControl;
            btnListarVencimientos.Location = new Point(508, 68);
            btnListarVencimientos.Name = "btnListarVencimientos";
            btnListarVencimientos.Size = new Size(120, 48);
            btnListarVencimientos.TabIndex = 10;
            btnListarVencimientos.Text = "Listar Vencimientos";
            btnListarVencimientos.UseVisualStyleBackColor = true;
            // 
            // frmClub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListarVencimientos);
            Controls.Add(btnCobrar);
            Controls.Add(btnRegistrarSocio);
            Controls.Add(btnRegistrarNoSocio);
            Name = "frmClub";
            Text = "Club";
            Load += Club_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarNoSocio;
        private Button btnRegistrarSocio;
        private Button btnCobrar;
        private Button btnListarVencimientos;
    }
}