using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ProjektX
{
    public partial class FrmMain : Form
    {
        Logika repozitorij;
        List<Zupanija> zupanijaList;
        List<Mjesto> mjestaList;
        public FrmMain()
        {
            InitializeComponent();
            repozitorij=new Logika();
                UcitajZupanije();
                UcitajMjesta();
                UcitajKlijente();
        }

        public void UcitajZupanije() 
        {
            try 
            {
                zupanijaList = repozitorij.DohvatiZupanije();
                foreach (Zupanija zupanija in zupanijaList)
                {
                    dataZupanije.Rows.Add(zupanija.id, zupanija.naziv);

                }
            }
            catch (Exception ex) {MessageBox.Show(ex.Message);}


        }
        public void UcitajMjesta() 
        {
            try
            {
                mjestaList = repozitorij.DohvatiMjesta();
                foreach (Mjesto mjesto in mjestaList)
                {
                    string zupanijaNaziv = null;
                    foreach (Zupanija zupanija in zupanijaList)
                    {
                        
                        if ( zupanija.id == mjesto.zupanija_id)
                        {
                            zupanijaNaziv = zupanija.naziv;
                            break;
                        }
                    }
                   
                    dataMjesta.Rows.Add(mjesto.broj_pu, mjesto.naziv, zupanijaNaziv);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
        }
        public void UcitajKlijente()
        {
            try 
            {
                List<Klijent> klijentiList = repozitorij.DohvatiKlijente();
                foreach (Klijent klijent in klijentiList)
                {

                    string mjestoNaziv = null;
                    foreach (Mjesto mjesto in mjestaList)
                    {
                        if (mjesto.broj_pu == klijent.mjesto_id)
                        {
                            mjestoNaziv = mjesto.naziv;
                            break;
                        }
                    }
                    dataKlijenti.Rows.Add(klijent.id, klijent.naziv, mjestoNaziv, klijent.telefon);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnDodajKlijenta_Click(object sender, EventArgs e)
        {
            Form dodajKlijenta = new FrmKijenti();
            try
            {
                dodajKlijenta.ShowDialog();
                dataKlijenti.Rows.Clear();
                UcitajKlijente();
            }
            catch(Exception ex) {MessageBox.Show(ex.Message);}

            
            

        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            dataKlijenti.Rows.Clear();
            if (txtPretraga.Text != "")
            {
                try
                {
                    List<Klijent> klijeniList = repozitorij.DohvatiKlijente();
                    foreach (Klijent klijent in klijeniList)
                    {
                        if (klijent.naziv.Contains(txtPretraga.Text)) //provjerava dali klijent sadrzi tekst iz pretrage
                        {
                            string mjesto = repozitorij.PronadjiMjestoId(klijent.mjesto_id);
                            dataKlijenti.Rows.Add(klijent.id, klijent.naziv, mjesto, klijent.telefon);
                        }

                    }
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }

            }
            else
            {
                try
                {
                    UcitajKlijente();
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            }

        }

        private void btnObrisiKlijenta_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da zelite obrisati klijenta?", "Upozorenje", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes) 
            {
                try
                {
                    repozitorij.ObrisiKlijenta(int.Parse(dataKlijenti.SelectedRows[0].Cells[0].Value.ToString()));
                    dataKlijenti.Rows.Clear();
                    UcitajKlijente();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnIzmjeniKlijenta_Click(object sender, EventArgs e)
        {
            try
            {
                int mjesto = repozitorij.PronadjiMjestoImenom(dataKlijenti.SelectedRows[0].Cells[2].Value.ToString());
                Klijent klijent = new Klijent(int.Parse(dataKlijenti.SelectedRows[0].Cells[0].Value.ToString()), dataKlijenti.SelectedRows[0].Cells[1].Value.ToString(), mjesto, dataKlijenti.SelectedRows[0].Cells[3].Value.ToString());
                Form izmjeniKlijent = new FrmKijenti(klijent);
                izmjeniKlijent.ShowDialog();
                dataKlijenti.Rows.Clear();
                UcitajKlijente();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message) ; }

        }

        private void btnObrisiiMjesto_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da zelite obrisati mjesto ? ", "Upozorenje", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (repozitorij.KoristiLiSeMjesto(int.Parse(dataMjesta.SelectedRows[0].Cells[0].Value.ToString())))
                    {
                        MessageBox.Show("Nemozete birsati mjesto koje se koristi");
                    }
                    else
                    {
                        repozitorij.ObrisiMjesto(int.Parse(dataMjesta.SelectedRows[0].Cells[0].Value.ToString()));
                        dataMjesta.Rows.Clear();
                        UcitajMjesta();
                    }
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
                

            }
        }

        private void btnDodajMjesto_Click(object sender, EventArgs e)
        {
            Form dodajMjesto = new FrmMjesto();
            if (dodajMjesto.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dataMjesta.Rows.Clear();
                    UcitajMjesta();
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }

            }
        }

        private void btnIzmjeniMjesto_Click(object sender, EventArgs e)
        {
            try
            {
                int zupanija = repozitorij.PronadjiZupanijuImenom(dataMjesta.SelectedRows[0].Cells[2].Value.ToString());
                Mjesto izmjenjenoMjesto = new Mjesto(int.Parse(dataMjesta.SelectedRows[0].Cells[0].Value.ToString()), dataMjesta.SelectedRows[0].Cells[1].Value.ToString(), zupanija);
                Form izmjeniMjesto = new FrmMjesto(izmjenjenoMjesto);
                izmjeniMjesto.ShowDialog();
                dataMjesta.Rows.Clear();
                UcitajMjesta();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument1 = new PrintDocument();
            try
            {
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDocument1.Print();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int rowHeight = 20;
            int columnWidth = 150;
            //Naslovi stupaca
            e.Graphics.DrawString("ID", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 50);
            e.Graphics.DrawString("Naziv", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 200, 50);
            e.Graphics.DrawString("Mjesto", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 350, 50);
            e.Graphics.DrawString("Telefon", new Font("Arial", 10,FontStyle.Bold), Brushes.Black, 500, 50);
            //pocetak teksta
            int x = 50;
            int y = 70;
            foreach (DataGridViewRow row in dataKlijenti.Rows)
            {
                foreach (DataGridViewColumn column in dataKlijenti.Columns)
                {
                    e.Graphics.DrawString(row.Cells[column.Index].Value.ToString(), new Font("Arial", 10), Brushes.Black, x, y);
                    x += columnWidth;
                }
                x = 50;
                y += rowHeight;
            }
        }

        private void btnUvezi_Click(object sender, EventArgs e)
        {
            
            if (repozitorij.DalSuKlijentiPrazni())
                {
                try
                {
                    //UvOz zupanije
                    
                    OpenFileDialog izaberiZupanije = new OpenFileDialog();
                    izaberiZupanije.Title = "Izaberi zupaniju xml";
                    izaberiZupanije.InitialDirectory = @"C:\";
                    izaberiZupanije.Filter = "XML Files(*.xml)|*.xml";
                    if (izaberiZupanije.ShowDialog() == DialogResult.OK)
                    {
                        string zupanijePutanja = izaberiZupanije.FileName;
                        repozitorij.UveziZupanije(zupanijePutanja);
                        dataZupanije.Rows.Clear();
                        UcitajZupanije();
                    }
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
                try
                {    //Uvoz mjesta
                    OpenFileDialog izaberiMjesta = new OpenFileDialog();
                    izaberiMjesta.Title = "Izaberi mjesto xml";
                    izaberiMjesta.InitialDirectory = @"C:\";
                    izaberiMjesta.Filter = "XML Files(*.xml)|*.xml";
                    if (izaberiMjesta.ShowDialog() == DialogResult.OK)
                    {
                        string mjestaPutanja = izaberiMjesta.FileName;
                        repozitorij.UveziMjesta(mjestaPutanja);
                        dataMjesta.Rows.Clear();
                        UcitajMjesta();
                    }
                    MessageBox.Show("Liste su uvezene");
                }   
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                MessageBox.Show("Lista klijenata mora biti prazna");
            }
        }
    }
}
