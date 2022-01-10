namespace MagazinEF {
    partial class GestionareForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionareForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adaugareProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produseeNoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantitateNouaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idProdusTool = new System.Windows.Forms.ToolStripTextBox();
            this.ActualizareStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.vanzareProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idVanzareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripVanzare = new System.Windows.Forms.ToolStripTextBox();
            this.vanzareProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelCautare = new System.Windows.Forms.Label();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeUtilizatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareProduseToolStripMenuItem,
            this.vanzareProduseToolStripMenuItem,
            this.listaToolStripMenuItem,
            this.stergeUtilizatoriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugareProduseToolStripMenuItem
            // 
            this.adaugareProduseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produseeNoiToolStripMenuItem,
            this.cantitateNouaToolStripMenuItem});
            this.adaugareProduseToolStripMenuItem.Name = "adaugareProduseToolStripMenuItem";
            this.adaugareProduseToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.adaugareProduseToolStripMenuItem.Text = "Adaugare Produse";
            // 
            // produseeNoiToolStripMenuItem
            // 
            this.produseeNoiToolStripMenuItem.Name = "produseeNoiToolStripMenuItem";
            this.produseeNoiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.produseeNoiToolStripMenuItem.Text = "Produsee Noi";
            this.produseeNoiToolStripMenuItem.Click += new System.EventHandler(this.produseeNoiToolStripMenuItem_Click);
            // 
            // cantitateNouaToolStripMenuItem
            // 
            this.cantitateNouaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idProdusTool,
            this.ActualizareStrip});
            this.cantitateNouaToolStripMenuItem.Name = "cantitateNouaToolStripMenuItem";
            this.cantitateNouaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cantitateNouaToolStripMenuItem.Text = "Id Cantitate Noua";
            // 
            // idProdusTool
            // 
            this.idProdusTool.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idProdusTool.Name = "idProdusTool";
            this.idProdusTool.Size = new System.Drawing.Size(100, 27);
            // 
            // ActualizareStrip
            // 
            this.ActualizareStrip.Name = "ActualizareStrip";
            this.ActualizareStrip.Size = new System.Drawing.Size(207, 26);
            this.ActualizareStrip.Text = "Actualizre Prdous";
            this.ActualizareStrip.Click += new System.EventHandler(this.ActualizareStrip_Click);
            // 
            // vanzareProduseToolStripMenuItem
            // 
            this.vanzareProduseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idVanzareToolStripMenuItem});
            this.vanzareProduseToolStripMenuItem.Name = "vanzareProduseToolStripMenuItem";
            this.vanzareProduseToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.vanzareProduseToolStripMenuItem.Text = "Vanzare Produse";
            // 
            // idVanzareToolStripMenuItem
            // 
            this.idVanzareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripVanzare,
            this.vanzareProdusToolStripMenuItem});
            this.idVanzareToolStripMenuItem.Name = "idVanzareToolStripMenuItem";
            this.idVanzareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.idVanzareToolStripMenuItem.Text = "Id Vanzare";
            // 
            // toolStripVanzare
            // 
            this.toolStripVanzare.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripVanzare.Name = "toolStripVanzare";
            this.toolStripVanzare.Size = new System.Drawing.Size(100, 27);
            // 
            // vanzareProdusToolStripMenuItem
            // 
            this.vanzareProdusToolStripMenuItem.Name = "vanzareProdusToolStripMenuItem";
            this.vanzareProdusToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vanzareProdusToolStripMenuItem.Text = "Vanzare Produs";
            this.vanzareProdusToolStripMenuItem.Click += new System.EventHandler(this.vanzareProdusToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(25, 128);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(749, 299);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefresh.Location = new System.Drawing.Point(647, 68);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(114, 37);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(25, 75);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(233, 22);
            this.textBoxSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSearch.ForeColor = System.Drawing.Color.Snow;
            this.buttonSearch.Location = new System.Drawing.Point(280, 71);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(104, 30);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelCautare
            // 
            this.labelCautare.AutoSize = true;
            this.labelCautare.Location = new System.Drawing.Point(22, 56);
            this.labelCautare.Name = "labelCautare";
            this.labelCautare.Size = new System.Drawing.Size(65, 16);
            this.labelCautare.TabIndex = 5;
            this.labelCautare.Text = "Denumire";
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.listaToolStripMenuItem.Text = "Istoric Vanzari";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // stergeUtilizatoriToolStripMenuItem
            // 
            this.stergeUtilizatoriToolStripMenuItem.Name = "stergeUtilizatoriToolStripMenuItem";
            this.stergeUtilizatoriToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.stergeUtilizatoriToolStripMenuItem.Text = "Sterge Utilizatori";
            this.stergeUtilizatoriToolStripMenuItem.Click += new System.EventHandler(this.stergeUtilizatoriToolStripMenuItem_Click);
            // 
            // GestionareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCautare);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestionareForm";
            this.Text = "Gestionare";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugareProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produseeNoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantitateNouaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vanzareProduseToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelCautare;
        private System.Windows.Forms.ToolStripTextBox idProdusTool;
        private System.Windows.Forms.ToolStripMenuItem ActualizareStrip;
        private System.Windows.Forms.ToolStripMenuItem idVanzareToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripVanzare;
        private System.Windows.Forms.ToolStripMenuItem vanzareProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeUtilizatoriToolStripMenuItem;
    }
}