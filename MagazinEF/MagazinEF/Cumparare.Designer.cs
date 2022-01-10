namespace MagazinEF {
    partial class CumparareForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CumparareForm));
            this.labelProdus = new System.Windows.Forms.Label();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.txtCantitate = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProdus
            // 
            this.labelProdus.AutoSize = true;
            this.labelProdus.Location = new System.Drawing.Point(55, 43);
            this.labelProdus.Name = "labelProdus";
            this.labelProdus.Size = new System.Drawing.Size(50, 16);
            this.labelProdus.TabIndex = 3;
            this.labelProdus.Text = "Produs";
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Location = new System.Drawing.Point(186, 43);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(130, 16);
            this.lblCantitate.TabIndex = 4;
            this.lblCantitate.Text = "Cantitate Disponibila";
            // 
            // lblBuy
            // 
            this.lblBuy.AutoSize = true;
            this.lblBuy.Location = new System.Drawing.Point(55, 129);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(135, 16);
            this.lblBuy.TabIndex = 5;
            this.lblBuy.Text = "Cumparare (cantitate)";
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(58, 148);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(152, 22);
            this.txtCantitate.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Magenta;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(37, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 48);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Cumparare";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Magenta;
            this.btnCancel.Location = new System.Drawing.Point(170, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 48);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CumparareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 342);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.lblBuy);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.labelProdus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CumparareForm";
            this.Text = "Cumparare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProdus;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.MaskedTextBox txtCantitate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}