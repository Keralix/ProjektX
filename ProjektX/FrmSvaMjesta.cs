using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektX
{
    public partial class FrmSvaMjesta : Form
    {
       //biranje mjesta kod kreiranja i uvozenja klijenata
        Logika repozitorij;
        public static string rezultat { get; set; }
        public FrmSvaMjesta()
        {
            InitializeComponent();
            rezultat = null;
            try
            {
                repozitorij = new Logika();
                List<Mjesto> mjestaList = repozitorij.DohvatiMjesta();
                foreach (Mjesto mjesto in mjestaList)
                {
                    string zupanija = repozitorij.PronadjiZupanijuID(mjesto.zupanija_id);
                    dataMjesta.Rows.Add(mjesto.broj_pu, mjesto.naziv, zupanija);
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            rezultat = dataMjesta.SelectedRows[0].Cells[1].Value.ToString();
            this.Close();
        }
    }
}
