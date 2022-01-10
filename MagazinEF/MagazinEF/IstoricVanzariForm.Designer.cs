namespace MagazinEF {
    partial class IstoricVanzariForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IstoricVanzariForm));
            this.dataGridVanzari = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVanzari)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVanzari
            // 
            this.dataGridVanzari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVanzari.Location = new System.Drawing.Point(12, 12);
            this.dataGridVanzari.Name = "dataGridVanzari";
            this.dataGridVanzari.RowHeadersWidth = 51;
            this.dataGridVanzari.RowTemplate.Height = 24;
            this.dataGridVanzari.Size = new System.Drawing.Size(776, 413);
            this.dataGridVanzari.TabIndex = 0;
           
            // 
            // IstoricVanzariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridVanzari);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IstoricVanzariForm";
            this.Text = "IstoricVanzariForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVanzari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVanzari;
    }
}