namespace MagazinEF {
    partial class ActualizareForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizareForm));
            this.labelProdus = new System.Windows.Forms.Label();
            this.lblSale = new System.Windows.Forms.Label();
            this.txtCantitate = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProdus
            // 
            this.labelProdus.AutoSize = true;
            this.labelProdus.Location = new System.Drawing.Point(32, 53);
            this.labelProdus.Name = "labelProdus";
            this.labelProdus.Size = new System.Drawing.Size(50, 16);
            this.labelProdus.TabIndex = 3;
            this.labelProdus.Text = "Produs";
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Location = new System.Drawing.Point(32, 137);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(128, 16);
            this.lblSale.TabIndex = 4;
            this.lblSale.Text = "Adaugare (cantitate)";
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(35, 156);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(152, 22);
            this.txtCantitate.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Magenta;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(44, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 48);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Adaugare";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Magenta;
            this.btnCancel.Location = new System.Drawing.Point(202, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 48);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ActualizareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 324);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.lblSale);
            this.Controls.Add(this.labelProdus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActualizareForm";
            this.Text = "ActualizareForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProdus;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.MaskedTextBox txtCantitate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}