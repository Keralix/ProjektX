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
    public partial class FrmSveZupanije : Form
    {
        Logika repozitorij;
        public static string rezultat { get; set; }
        public FrmSveZupanije()
        {
            //biranje mjesta kod izmjene i uvozenja mjesta
            InitializeComponent();
            repozitorij = new Logika();
            rezultat = null;
            try
            {
                List<Zupanija> zupanijaList = repozitorij.DohvatiZupanije();
                foreach (Zupanija zupanija in zupanijaList)
                {
                    dataZupanije.Rows.Add(zupanija.id, zupanija.naziv);

                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            rezultat = dataZupanije.SelectedRows[0].Cells[1].Value.ToString();
            this.Close();
        }
    }
}
