namespace ProjektX
{
    partial class FrmMain
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabKlijenti = new System.Windows.Forms.TabPage();
            this.btnIzmjeniKlijenta = new System.Windows.Forms.Button();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.btnObrisiKlijenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnDodajKlijenta = new System.Windows.Forms.Button();
            this.dataKlijenti = new System.Windows.Forms.DataGridView();
            this.klijentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoKlijenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMjesta = new System.Windows.Forms.TabPage();
            this.btnIzmjeniMjesto = new System.Windows.Forms.Button();
            this.btnObrisiiMjesto = new System.Windows.Forms.Button();
            this.btnDodajMjesto = new System.Windows.Forms.Button();
            this.dataMjesta = new System.Windows.Forms.DataGridView();
            this.broj_pu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivMjesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zupanija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabZupanije = new System.Windows.Forms.TabPage();
            this.dataZupanije = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUvezi = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabKlijenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKlijenti)).BeginInit();
            this.tabMjesta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMjesta)).BeginInit();
            this.tabZupanije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataZupanije)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabKlijenti);
            this.tabControl.Controls.Add(this.tabMjesta);
            this.tabControl.Controls.Add(this.tabZupanije);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(525, 360);
            this.tabControl.TabIndex = 0;
            // 
            // tabKlijenti
            // 
            this.tabKlijenti.Controls.Add(this.btnIzmjeniKlijenta);
            this.tabKlijenti.Controls.Add(this.btnIspisi);
            this.tabKlijenti.Controls.Add(this.btnObrisiKlijenta);
            this.tabKlijenti.Controls.Add(this.label1);
            this.tabKlijenti.Controls.Add(this.txtPretraga);
            this.tabKlijenti.Controls.Add(this.btnDodajKlijenta);
            this.tabKlijenti.Controls.Add(this.dataKlijenti);
            this.tabKlijenti.Location = new System.Drawing.Point(4, 22);
            this.tabKlijenti.Name = "tabKlijenti";
            this.tabKlijenti.Padding = new System.Windows.Forms.Padding(3);
            this.tabKlijenti.Size = new System.Drawing.Size(517, 334);
            this.tabKlijenti.TabIndex = 0;
            this.tabKlijenti.Text = "Klijenti";
            this.tabKlijenti.UseVisualStyleBackColor = true;
            // 
            // btnIzmjeniKlijenta
            // 
            this.btnIzmjeniKlijenta.Location = new System.Drawing.Point(284, 300);
            this.btnIzmjeniKlijenta.Name = "btnIzmjeniKlijenta";
            this.btnIzmjeniKlijenta.Size = new System.Drawing.Size(75, 23);
            this.btnIzmjeniKlijenta.TabIndex = 6;
            this.btnIzmjeniKlijenta.Text = "Izmjeni";
            this.btnIzmjeniKlijenta.UseVisualStyleBackColor = true;
            this.btnIzmjeniKlijenta.Click += new System.EventHandler(this.btnIzmjeniKlijenta_Click);
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(6, 300);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(75, 23);
            this.btnIspisi.TabIndex = 5;
            this.btnIspisi.Text = "Ispisi";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // btnObrisiKlijenta
            // 
            this.btnObrisiKlijenta.Location = new System.Drawing.Point(133, 300);
            this.btnObrisiKlijenta.Name = "btnObrisiKlijenta";
            this.btnObrisiKlijenta.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiKlijenta.TabIndex = 4;
            this.btnObrisiKlijenta.Text = "Obrisi";
            this.btnObrisiKlijenta.UseVisualStyleBackColor = true;
            this.btnObrisiKlijenta.Click += new System.EventHandler(this.btnObrisiKlijenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pretrazivanje";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(346, 6);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(165, 20);
            this.txtPretraga.TabIndex = 2;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // btnDodajKlijenta
            // 
            this.btnDodajKlijenta.Location = new System.Drawing.Point(436, 300);
            this.btnDodajKlijenta.Name = "btnDodajKlijenta";
            this.btnDodajKlijenta.Size = new System.Drawing.Size(75, 23);
            this.btnDodajKlijenta.TabIndex = 1;
            this.btnDodajKlijenta.Text = "Dodaj";
            this.btnDodajKlijenta.UseVisualStyleBackColor = true;
            this.btnDodajKlijenta.Click += new System.EventHandler(this.btnDodajKlijenta_Click);
            // 
            // dataKlijenti
            // 
            this.dataKlijenti.AllowUserToAddRows = false;
            this.dataKlijenti.AllowUserToDeleteRows = false;
            this.dataKlijenti.AllowUserToOrderColumns = true;
            this.dataKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKlijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.klijentID,
            this.imePrezime,
            this.mjestoKlijenta,
            this.telefon});
            this.dataKlijenti.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataKlijenti.Location = new System.Drawing.Point(6, 32);
            this.dataKlijenti.MultiSelect = false;
            this.dataKlijenti.Name = "dataKlijenti";
            this.dataKlijenti.RowHeadersVisible = false;
            this.dataKlijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataKlijenti.Size = new System.Drawing.Size(505, 262);
            this.dataKlijenti.TabIndex = 0;
            // 
            // klijentID
            // 
            this.klijentID.HeaderText = "ID";
            this.klijentID.Name = "klijentID";
            // 
            // imePrezime
            // 
            this.imePrezime.HeaderText = "Ime i Prezime";
            this.imePrezime.Name = "imePrezime";
            this.imePrezime.Width = 200;
            // 
            // mjestoKlijenta
            // 
            this.mjestoKlijenta.HeaderText = "Mjesto";
            this.mjestoKlijenta.Name = "mjestoKlijenta";
            // 
            // telefon
            // 
            this.telefon.HeaderText = "Telefon";
            this.telefon.Name = "telefon";
            // 
            // tabMjesta
            // 
            this.tabMjesta.Controls.Add(this.btnUvezi);
            this.tabMjesta.Controls.Add(this.btnIzmjeniMjesto);
            this.tabMjesta.Controls.Add(this.btnObrisiiMjesto);
            this.tabMjesta.Controls.Add(this.btnDodajMjesto);
            this.tabMjesta.Controls.Add(this.dataMjesta);
            this.tabMjesta.Location = new System.Drawing.Point(4, 22);
            this.tabMjesta.Name = "tabMjesta";
            this.tabMjesta.Padding = new System.Windows.Forms.Padding(3);
            this.tabMjesta.Size = new System.Drawing.Size(517, 334);
            this.tabMjesta.TabIndex = 1;
            this.tabMjesta.Text = "Mjesta";
            this.tabMjesta.UseVisualStyleBackColor = true;
            // 
            // btnIzmjeniMjesto
            // 
            this.btnIzmjeniMjesto.Location = new System.Drawing.Point(142, 305);
            this.btnIzmjeniMjesto.Name = "btnIzmjeniMjesto";
            this.btnIzmjeniMjesto.Size = new System.Drawing.Size(75, 23);
            this.btnIzmjeniMjesto.TabIndex = 9;
            this.btnIzmjeniMjesto.Text = "Izmjeni";
            this.btnIzmjeniMjesto.UseVisualStyleBackColor = true;
            this.btnIzmjeniMjesto.Click += new System.EventHandler(this.btnIzmjeniMjesto_Click);
            // 
            // btnObrisiiMjesto
            // 
            this.btnObrisiiMjesto.Location = new System.Drawing.Point(6, 305);
            this.btnObrisiiMjesto.Name = "btnObrisiiMjesto";
            this.btnObrisiiMjesto.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiiMjesto.TabIndex = 8;
            this.btnObrisiiMjesto.Text = "Obrisi";
            this.btnObrisiiMjesto.UseVisualStyleBackColor = true;
            this.btnObrisiiMjesto.Click += new System.EventHandler(this.btnObrisiiMjesto_Click);
            // 
            // btnDodajMjesto
            // 
            this.btnDodajMjesto.Location = new System.Drawing.Point(301, 305);
            this.btnDodajMjesto.Name = "btnDodajMjesto";
            this.btnDodajMjesto.Size = new System.Drawing.Size(75, 23);
            this.btnDodajMjesto.TabIndex = 7;
            this.btnDodajMjesto.Text = "Dodaj";
            this.btnDodajMjesto.UseVisualStyleBackColor = true;
            this.btnDodajMjesto.Click += new System.EventHandler(this.btnDodajMjesto_Click);
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
            this.dataMjesta.Location = new System.Drawing.Point(6, 6);
            this.dataMjesta.Name = "dataMjesta";
            this.dataMjesta.RowHeadersVisible = false;
            this.dataMjesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataMjesta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMjesta.Size = new System.Drawing.Size(505, 280);
            this.dataMjesta.TabIndex = 1;
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
            // tabZupanije
            // 
            this.tabZupanije.Controls.Add(this.dataZupanije);
            this.tabZupanije.Location = new System.Drawing.Point(4, 22);
            this.tabZupanije.Name = "tabZupanije";
            this.tabZupanije.Padding = new System.Windows.Forms.Padding(3);
            this.tabZupanije.Size = new System.Drawing.Size(517, 334);
            this.tabZupanije.TabIndex = 2;
            this.tabZupanije.Text = "Županije";
            this.tabZupanije.UseVisualStyleBackColor = true;
            // 
            // dataZupanije
            // 
            this.dataZupanije.AllowUserToAddRows = false;
            this.dataZupanije.AllowUserToDeleteRows = false;
            this.dataZupanije.AllowUserToOrderColumns = true;
            this.dataZupanije.AllowUserToResizeColumns = false;
            this.dataZupanije.AllowUserToResizeRows = false;
            this.dataZupanije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataZupanije.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataZupanije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataZupanije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv});
            this.dataZupanije.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataZupanije.Location = new System.Drawing.Point(6, 6);
            this.dataZupanije.Name = "dataZupanije";
            this.dataZupanije.RowHeadersVisible = false;
            this.dataZupanije.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataZupanije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataZupanije.Size = new System.Drawing.Size(505, 280);
            this.dataZupanije.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 43;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.Width = 59;
            // 
            // btnUvezi
            // 
            this.btnUvezi.Location = new System.Drawing.Point(436, 305);
            this.btnUvezi.Name = "btnUvezi";
            this.btnUvezi.Size = new System.Drawing.Size(75, 23);
            this.btnUvezi.TabIndex = 10;
            this.btnUvezi.Text = "Uvezi ";
            this.btnUvezi.UseVisualStyleBackColor = true;
            this.btnUvezi.Click += new System.EventHandler(this.btnUvezi_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 381);
            this.Controls.Add(this.tabControl);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabKlijenti.ResumeLayout(false);
            this.tabKlijenti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKlijenti)).EndInit();
            this.tabMjesta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMjesta)).EndInit();
            this.tabZupanije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataZupanije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabKlijenti;
        private System.Windows.Forms.TabPage tabMjesta;
        private System.Windows.Forms.TabPage tabZupanije;
        private System.Windows.Forms.DataGridView dataZupanije;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridView dataMjesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn broj_pu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivMjesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zupanija;
        private System.Windows.Forms.DataGridView dataKlijenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn klijentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoKlijenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.Button btnDodajKlijenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnIzmjeniKlijenta;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.Button btnObrisiKlijenta;
        private System.Windows.Forms.Button btnIzmjeniMjesto;
        private System.Windows.Forms.Button btnObrisiiMjesto;
        private System.Windows.Forms.Button btnDodajMjesto;
        private System.Windows.Forms.Button btnUvezi;
    }
}

