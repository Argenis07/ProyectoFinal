
namespace ProyectoFinal
{
    partial class FrmOrdenes
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
            this.dataGridViewOrdenes = new System.Windows.Forms.DataGridView();
            this.bttndetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrdenes
            // 
            this.dataGridViewOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrdenes.Location = new System.Drawing.Point(65, 72);
            this.dataGridViewOrdenes.Name = "dataGridViewOrdenes";
            this.dataGridViewOrdenes.Size = new System.Drawing.Size(522, 282);
            this.dataGridViewOrdenes.TabIndex = 0;
            this.dataGridViewOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrdenes_CellContentClick);
            // 
            // bttndetalle
            // 
            this.bttndetalle.Location = new System.Drawing.Point(676, 113);
            this.bttndetalle.Name = "bttndetalle";
            this.bttndetalle.Size = new System.Drawing.Size(75, 23);
            this.bttndetalle.TabIndex = 1;
            this.bttndetalle.Text = "Detalle";
            this.bttndetalle.UseVisualStyleBackColor = true;
            this.bttndetalle.Click += new System.EventHandler(this.bttndetalle_Click);
            // 
            // FrmOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttndetalle);
            this.Controls.Add(this.dataGridViewOrdenes);
            this.Name = "FrmOrdenes";
            this.Text = "FrmOrdenes";
            this.Load += new System.EventHandler(this.FrmOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrdenes;
        private System.Windows.Forms.Button bttndetalle;
    }
}