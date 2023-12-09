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
    public partial class FrmKijenti : Form
    {
        Logika repo;
        string rezultat;
        public FrmKijenti()
        {
            //forma za kreiranje klijenata
            repo = new Logika();
            InitializeComponent();
            List<Mjesto> mjestaList = repo.DohvatiMjesta();
            cbMjesto.Items.Add("Unesi novo mjesto");
            foreach (Mjesto mjesto in mjestaList)
            {
                cbMjesto.Items.Add(mjesto.naziv);
            }
            btnUnesi.Enabled = true;
            btnUnesi.Visible = true;
            cbMjesto.SelectedIndexChanged += CbZupanija_SelectedIndexChanged;
        }

        public FrmKijenti(Klijent klijent)
        {
            //forma za kreiranje klijenata
            repo = new Logika();
            InitializeComponent();
            List<Mjesto> mjestaList = repo.DohvatiMjesta();
            cbMjesto.Items.Add("Unesi novo mjesto");
            foreach (Mjesto mjesto in mjestaList)
            {
                cbMjesto.Items.Add(mjesto.naziv);
            }
            txtID.Text = klijent.id.ToString();
            txtID.ReadOnly = true;
            txtNaziv.Text = klijent.naziv;
            txtTelefon.Text = klijent.telefon;
            cbMjesto.Text = repo.PronadjiMjestoId(klijent.mjesto_id);
            btnIzmjeni.Enabled = true;
            btnIzmjeni.Visible = true;
            cbMjesto.SelectedIndexChanged += CbZupanija_SelectedIndexChanged;
        }
        private void CbZupanija_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cbMjesto.SelectedItem== "Unesi novo mjesto")
            {
                using(Form dodajMjesto=new FrmMjesto())
                {
                    dodajMjesto.ShowDialog();
                    rezultat = FrmMjesto.naziv;
                    if (!string.IsNullOrEmpty(rezultat))
                    {
                        cbMjesto.Items.Add(rezultat);
                        cbMjesto.Text = rezultat;
                    }
                }
                
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (txtNaziv.Text != "" && txtTelefon.Text != "" && cbMjesto.SelectedItem != null)
            {
                try
                {
                    int id = int.Parse(txtID.Text);
                    if (repo.PostojiLiKlijent(id))
                    {
                        MessageBox.Show("Korisnik sa unesenim ID-om vec postoji");
                    }
                    else
                    { if (txtNaziv.Text.Length < 7) MessageBox.Show("Naziv mora biti dulji od 6 znakova");
                        else
                        {
                            Klijent noviKlijent = new Klijent(id, txtNaziv.Text, repo.PronadjiMjestoImenom(cbMjesto.SelectedItem.ToString()), txtTelefon.Text);
                            repo.DodajKlijenta(noviKlijent);
                            this.Close();
                        } 
                    }
                }
                catch(FormatException) { MessageBox.Show("ID mora biti cijeli broj."); }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
            else { MessageBox.Show("Svi podatci moraju biti uneseni"); }
        }

        private void btnMjesta_Click(object sender, EventArgs e)
        {
            using (Form odaberiMjesto = new FrmSvaMjesta())
            {
                odaberiMjesto.ShowDialog();
                rezultat = FrmSvaMjesta.rezultat;
                if(!string.IsNullOrEmpty(rezultat)) cbMjesto.Text = rezultat;

            }
            
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtNaziv.Text != "" && txtTelefon.Text != "" && cbMjesto.SelectedItem != null)
            {
                try
                {
                    int id = int.Parse(txtID.Text);
                    if (txtNaziv.Text.Length < 7) MessageBox.Show("Naziv mora biti dulji od 6 znakova");
                    else
                    {
                        Klijent noviKlijent = new Klijent(id, txtNaziv.Text, repo.PronadjiMjestoImenom(cbMjesto.SelectedItem.ToString()), txtTelefon.Text);
                        repo.IzmjeniKlijenta(noviKlijent);
                        this.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else { MessageBox.Show("Svi podatci moraju biti uneseni"); }
        }
    }
}
