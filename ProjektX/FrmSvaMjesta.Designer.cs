namespace ProjektX
{
    partial class FrmSvaMjesta
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
            this.dataMjesta = new System.Windows.Forms.DataGridView();
            this.broj_pu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivMjesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zupanija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnOdaberi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataMjesta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataMjesta
            // 
            this.dataMjesta.AllowUserToAddRows = false;
            this.dataMjesta.AllowUserToDeleteRows = false;
            this.dataMjesta.AllowUserToOrderColumns = true;
            this.dataMjesta.AllowUserToResizeColumns = false;
            this.dataMjesta.AllowUserToResizeRows = false;
            this.dataMjesta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataMjesta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataMjesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMjesta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.broj_pu,
            this.nazivMjesta,
            this.Zupanija});
            this.dataMjesta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataMjesta.Location = new System.Drawing.Point(12, 12);
            this.dataMjesta.MultiSelect = false;
            this.dataMjesta.Name = "dataMjesta";
            this.dataMjesta.ReadOnly = true;
            this.dataMjesta.RowHeadersVisible = false;
            this.dataMjesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataMjesta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMjesta.Size = new System.Drawing.Size(370, 280);
            this.dataMjesta.TabIndex = 2;
            // 
            // broj_pu
            // 
            this.broj_pu.HeaderText = "Poštanski broj";
            this.broj_pu.Name = "broj_pu";
            this.broj_pu.Width = 98;
            // 
            // nazivMjesta
            // 
            this.nazivMjesta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nazivMjesta.HeaderText = "Naziv";
            this.nazivMjesta.Name = "nazivMjesta";
            this.nazivMjesta.Width = 59;
            // 
            // Zupanija
            // 
            this.Zupanija.HeaderText = "Županija";
            this.Zupanija.Name = "Zupanija";
            this.Zupanija.Width = 73;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(12, 310);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 3;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(307, 310);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(75, 23);
            this.btnOdaberi.TabIndex = 4;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // FrmSvaMjesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 354);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.dataMjesta);
            this.Name = "FrmSvaMjesta";
            this.Text = "FrmSvaMjesta";
            ((System.ComponentModel.ISupportInitialize)(this.dataMjesta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMjesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn broj_pu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivMjesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zupanija;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnOdaberi;
    }
}