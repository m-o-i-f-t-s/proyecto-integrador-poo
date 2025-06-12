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
            lblNombre.Location = new Point(362, 122);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "NOMBRE";
            lblNombre.Click += label1_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(362, 66);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(60, 15);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "APELLIDO";
            lblApellido.Click += label1_Click_1;
            // 
            // frmImpresionCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(pictureBox1);
            Name = "frmImpresionCarnet";
            Text = "frmImpresionCarnet";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblNombre;
        private Label lblApellido;
    }
}