namespace MagazinEF {
    partial class AddProduseNoiForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduseNoiForm));
            this.labelDenumire = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.labelDescriere = new System.Windows.Forms.Label();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.DataExpirare = new System.Windows.Forms.Label();
            this.txtexpirare = new System.Windows.Forms.DateTimePicker();
            this.Cantitate = new System.Windows.Forms.Label();
            this.txtCantitate = new System.Windows.Forms.MaskedTextBox();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDenumire
            // 
            this.labelDenumire.AutoSize = true;
            this.labelDenumire.Location = new System.Drawing.Point(40, 51);
            this.labelDenumire.Name = "labelDenumire";
            this.labelDenumire.Size = new System.Drawing.Size(65, 16);
            this.labelDenumire.TabIndex = 1;
            this.labelDenumire.Text = "Denumire";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(43, 70);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(159, 22);
            this.txtDenumire.TabIndex = 6;
            // 
            // labelDescriere
            // 
            this.labelDescriere.AutoSize = true;
            this.labelDescriere.Location = new System.Drawing.Point(40, 114);
            this.labelDescriere.Name = "labelDescriere";
            this.labelDescriere.Size = new System.Drawing.Size(66, 16);
            this.labelDescriere.TabIndex = 7;
            this.labelDescriere.Text = "Descriere";
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(43, 133);
            this.txtDescriere.Multiline = true;
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(291, 89);
            this.txtDescriere.TabIndex = 8;
            // 
            // DataExpirare
            // 
            this.DataExpirare.AutoSize = true;
            this.DataExpirare.Location = new System.Drawing.Point(40, 241);
            this.DataExpirare.Name = "DataExpirare";
            this.DataExpirare.Size = new System.Drawing.Size(86, 16);
            this.DataExpirare.TabIndex = 9;
            this.DataExpirare.Text = "DataExpirare";
            // 
            // txtexpirare
            // 
            this.txtexpirare.Location = new System.Drawing.Point(43, 260);
            this.txtexpirare.Name = "txtexpirare";
            this.txtexpirare.Size = new System.Drawing.Size(247, 22);
            this.txtexpirare.TabIndex = 10;
            // 
            // Cantitate
            // 
            this.Cantitate.AutoSize = true;
            this.Cantitate.Location = new System.Drawing.Point(40, 303);
            this.Cantitate.Name = "Cantitate";
            this.Cantitate.Size = new System.Drawing.Size(59, 16);
            this.Cantitate.TabIndex = 11;
            this.Cantitate.Text = "Cantitate";
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(43, 322);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(195, 22);
            this.txtCantitate.TabIndex = 13;
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.Color.Magenta;
            this.btnAdaugare.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdaugare.Location = new System.Drawing.Point(23, 385);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(143, 28);
            this.btnAdaugare.TabIndex = 14;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.ForeColor = System.Drawing.Color.Magenta;
            this.btnCancel.Location = new System.Drawing.Point(188, 385);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 28);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddProduseNoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.Cantitate);
            this.Controls.Add(this.txtexpirare);
            this.Controls.Add(this.DataExpirare);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.labelDescriere);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.labelDenumire);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProduseNoiForm";
            this.Text = "AddProduseNoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDenumire;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.Label labelDescriere;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.Label DataExpirare;
        private System.Windows.Forms.DateTimePicker txtexpirare;
        private System.Windows.Forms.Label Cantitate;
        private System.Windows.Forms.MaskedTextBox txtCantitate;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnCancel;
    }
}