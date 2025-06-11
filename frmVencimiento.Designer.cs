namespace WinFormsApp1
{
    partial class frmVencimiento
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
            dbgrdVencimiento = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dbgrdVencimiento).BeginInit();
            SuspendLayout();
            // 
            // dbgrdVencimiento
            // 
            dbgrdVencimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dbgrdVencimiento.Location = new Point(123, 174);
            dbgrdVencimiento.Name = "dbgrdVencimiento";
            dbgrdVencimiento.RowTemplate.Height = 25;
            dbgrdVencimiento.Size = new Size(555, 103);
            dbgrdVencimiento.TabIndex = 1;
            dbgrdVencimiento.CellContentClick += dbgrdVencimiento_CellContentClick;
            // 
            // frmVencimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dbgrdVencimiento);
            Name = "frmVencimiento";
            Text = "Lista De Vencimientos";
            Load += frmVencimiento_Load;
            ((System.ComponentModel.ISupportInitialize)dbgrdVencimiento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dbgrdVencimiento;
    }
}