namespace WinFormsApp1
{
    partial class frmCarnetNoEmitidos
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
            dbgrdNoEmitidos = new DataGridView();
            txtDni = new TextBox();
            lblDni = new Label();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dbgrdNoEmitidos).BeginInit();
            SuspendLayout();
            // 
            // dbgrdNoEmitidos
            // 
            dbgrdNoEmitidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbgrdNoEmitidos.Location = new Point(52, 50);
            dbgrdNoEmitidos.Name = "dbgrdNoEmitidos";
            dbgrdNoEmitidos.RowTemplate.Height = 25;
            dbgrdNoEmitidos.Size = new Size(696, 210);
            dbgrdNoEmitidos.TabIndex = 2;
            dbgrdNoEmitidos.CellContentClick += dbgrdNoEmitidos_CellContentClick;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(85, 321);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingrese un DNI";
            txtDni.Size = new Size(152, 23);
            txtDni.TabIndex = 3;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(52, 324);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(255, 324);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmCarnetNoEmitidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(lblDni);
            Controls.Add(txtDni);
            Controls.Add(dbgrdNoEmitidos);
            Name = "frmCarnetNoEmitidos";
            Text = "Carnet No Emitidos";
            Load += frmCarnetNoEmitidos_Load;
            ((System.ComponentModel.ISupportInitialize)dbgrdNoEmitidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dbgrdNoEmitidos;
        private TextBox txtDni;
        private Label lblDni;
        private Button btnBuscar;
    }
}