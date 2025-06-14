using System.Web;

namespace WinFormsApp1
{
    partial class frmImpresionCarnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImpresionCarnet));
            pictureBox1 = new PictureBox();
            lblNombre = new Label();
            lblApellido = new Label();
            btnImprimir = new Button();
            lblDni = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(112, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(352, 133);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "NOMBRE";
            lblNombre.Click += label1_Click;
            // 
            // lblApellido
            // 
            lblApellido.AccessibleName = "lblApellido";
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(352, 76);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(60, 15);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "APELLIDO";
            lblApellido.Click += label1_Click_1;
            // 
            // btnImprimir
            // 
            btnImprimir.AccessibleDescription = "btnImprimir";
            btnImprimir.AccessibleName = "btnImprimir";
            btnImprimir.Location = new Point(215, 244);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(106, 44);
            btnImprimir.TabIndex = 30;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblDni
            // 
            lblDni.AccessibleDescription = "lblDni";
            lblDni.AccessibleName = "lblDni";
            lblDni.AutoSize = true;
            lblDni.Location = new Point(352, 189);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 31;
            lblDni.Text = "DNI";
            lblDni.Click += label1_Click_2;
            // 
            // frmImpresionCarnet
            // 
            AccessibleDescription = "lblNombre";
            AccessibleName = "lblNombre";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 317);
            Controls.Add(lblDni);
            Controls.Add(btnImprimir);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(pictureBox1);
            Name = "frmImpresionCarnet";
            Text = "Imprimir Carnet";
            Load += frmImpresionCarnet_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblNombre;
        private Label lblApellido;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btnImprimir;
        private Label lblDni;

        public string Nombre
        {
            set { lblNombre.Text = value; }
        }

        public string Apellido
        {
            set { lblApellido.Text = value; }
        }
        public string Dni
        {
            set { lblDni.Text = value; }
        }
    }
}