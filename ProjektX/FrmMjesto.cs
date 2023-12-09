using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektX
{
    public partial class FrmMjesto : Form
    {
        public static string naziv { get; set; }
        private Logika repo;
        public FrmMjesto()
        {
            repo = new Logika();
            InitializeComponent();
            List<Zupanija> zupanije = repo.DohvatiZupanije();
            foreach(Zupanija zupanija in zupanije)
            {
                cbZupanija.Items.Add(zupanija.naziv);
            }
            btnUnesi.Visible = true;
        }
        public FrmMjesto(Mjesto mjesto)
        {
            repo = new Logika();
            InitializeComponent();
            List<Zupanija> zupanije = repo.DohvatiZupanije();
            foreach (Zupanija zupanija in zupanije)
            {
                cbZupanija.Items.Add(zupanija.naziv);

                if (zupanija.id == mjesto.zupanija_id) cbZupanija.SelectedItem = zupanija.naziv;
            }
            txtID.Text = mjesto.broj_pu.ToString();
            txtNaziv.Text = mjesto.naziv;
            txtID.ReadOnly = true;
            btnIzmjeni.Visible = false;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZupanije_Click(object sender, EventArgs e)
        {
            string rezultat;
            using (Form zupanijeForm = new FrmSveZupanije())
            {
                rezultat = FrmSveZupanije.rezultat;
                if(!string.IsNullOrEmpty(rezultat))
                {
                    cbZupanija.Text = rezultat;
                }
            }
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (txtID.Text != null && txtNaziv.Text != null && cbZupanija.SelectedItem.ToString() != null)
                try 
                { 
                    int id = int.Parse(txtID.Text);
                    if (txtNaziv.Text.Length < 3)
                    {
                        MessageBox.Show("Naziv mora biti dulji od 2 znaka");
                    }
                    else
                    {
                        naziv = txtNaziv.Text;
                        Mjesto novoMjesto = new Mjesto(id, naziv,repo.PronadjiZupanijuImenom(cbZupanija.SelectedItem.ToString()));
                        repo.DodajMjesto(novoMjesto);
                        MessageBox.Show("Novo mjesto je dodano.");
                        this.Close();
                    }
                } 
                catch (FormatException) 
                {
                    MessageBox.Show("ID mora biti cijeli broj.");
                }
                catch(Exception ex) {  MessageBox.Show(ex.Message); }
            else MessageBox.Show("Svi podatci moraju biti uneseni");
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            if (txtID.Text != null && txtNaziv.Text != null && cbZupanija.SelectedItem.ToString() != null)
                try
                {
                    int id = int.Parse(txtID.Text);
                    if (txtNaziv.Text.Length < 3)
                    {
                        MessageBox.Show("Naziv mora biti dulji od 2 znaka");
                    }
                    else
                    {
                        Mjesto novoMjesto = new Mjesto(id, txtNaziv.Text, repo.PronadjiZupanijuImenom(cbZupanija.SelectedItem.ToString()));
                        repo.IzmjeniMjesto(novoMjesto);
                        MessageBox.Show("Mjesto je izmjenjeno.");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            else MessageBox.Show("Svi podatci moraju biti uneseni");
        }
    }
}
