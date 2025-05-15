namespace WinFormsApp1
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            btnLogin = new Button();
            txtPass = new TextBox();
            txtUser = new TextBox();
            pictureBox1 = new PictureBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.ImeMode = ImeMode.NoControl;
            btnLogin.Location = new Point(430, 204);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 48);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "INICIAR SESION";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(415, 148);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(155, 23);
            txtPass.TabIndex = 8;
            txtPass.Text = "CONTRASEÑA";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(415, 93);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(155, 23);
            txtUser.TabIndex = 7;
            txtUser.Text = "USUARIO";
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(231, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            Name = "FrmLogin";
            Text = "Iniciar Sesión";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin;
        private TextBox txtPass;
        private TextBox txtUser;
        private PictureBox pictureBox1;
        private FileSystemWatcher fileSystemWatcher1;
    }
}
