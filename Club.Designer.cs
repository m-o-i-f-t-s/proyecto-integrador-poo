﻿namespace WinFormsApp1
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
            btnEmitirCarnet = new Button();
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
            btnRegistrarSocio.Location = new Point(509, 68);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(120, 48);
            btnRegistrarSocio.TabIndex = 8;
            btnRegistrarSocio.Text = "Registrar Socio";
            btnRegistrarSocio.UseVisualStyleBackColor = true;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
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
            btnCobrar.Click += btnCobrar_Click;
            // 
            // btnListarVencimientos
            // 
            btnListarVencimientos.ImeMode = ImeMode.NoControl;
            btnListarVencimientos.Location = new Point(317, 306);
            btnListarVencimientos.Name = "btnListarVencimientos";
            btnListarVencimientos.Size = new Size(120, 48);
            btnListarVencimientos.TabIndex = 10;
            btnListarVencimientos.Text = "Lista Vencimientos";
            btnListarVencimientos.UseVisualStyleBackColor = true;
            btnListarVencimientos.Click += btnListarVencimientos_Click;
            // 
            // btnEmitirCarnet
            // 
            btnEmitirCarnet.ImeMode = ImeMode.NoControl;
            btnEmitirCarnet.Location = new Point(509, 306);
            btnEmitirCarnet.Name = "btnEmitirCarnet";
            btnEmitirCarnet.Size = new Size(120, 48);
            btnEmitirCarnet.TabIndex = 11;
            btnEmitirCarnet.Text = "Emitir Carnet";
            btnEmitirCarnet.UseVisualStyleBackColor = true;
            btnEmitirCarnet.Click += btnEmitirCarnet_Click;
            // 
            // frmClub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEmitirCarnet);
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
        private Button btnEmitirCarnet;
    }
}