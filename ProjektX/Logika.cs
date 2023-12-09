using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Data.OleDb;
using System.Threading;
using System.Runtime;

namespace ProjektX
{
    public class Logika
    {
        public List<Zupanija> DohvatiZupanije()
        {
            string commandStr = "SELECT * FROM Zupanije";
            Baza baza = new Baza();
            baza.Connect();
            OleDbDataReader rdr = baza.Read(commandStr);
            List<Zupanija> rezultat = Enumerable.Empty<Zupanija>().ToList();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Zupanija zupanija = new Zupanija(int.Parse(rdr[0].ToString()), rdr[1].ToString());
                    rezultat.Add(zupanija);
                }
            }
            baza.Dissconect();
            return rezultat;
        }
        public List<Mjesto> DohvatiMjesta()
        {
            string commandStr = "SELECT * FROM Mjesta";
            Baza baza = new Baza();
            baza.Connect();
            OleDbDataReader rdr = baza.Read(commandStr);
            List<Mjesto> rezultat = Enumerable.Empty<Mjesto>().ToList();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Mjesto mjesto = new Mjesto(int.Parse(rdr[0].ToString()), rdr[1].ToString(), int.Parse(rdr[2].ToString()));
                    rezultat.Add(mjesto);
                }
            }
            baza.Dissconect();
            return rezultat;
        }
        public List<Klijent> DohvatiKlijente()
        {
            string commandStr = "SELECT * FROM Klijenti";
            Baza baza = new Baza();
            baza.Connect();
            OleDbDataReader rdr = baza.Read(commandStr);
            List<Klijent> rezultat = Enumerable.Empty<Klijent>().ToList();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    Klijent klijent = new Klijent(int.Parse(rdr[0].ToString()), rdr[1].ToString(), int.Parse(rdr[2].ToString()), rdr[3].ToString());
                    rezultat.Add(klijent);
                }
            }
            baza.Dissconect();
            return rezultat;
        }
        public void DodajKlijenta(Klijent noviKlijent)
        {
            string commandStr = $"INSERT INTO Klijenti VALUES ({noviKlijent.id},'{noviKlijent.naziv}',{noviKlijent.mjesto_id},'{noviKlijent.telefon}')";
            Baza baza = new Baza();
            baza.Connect();
            baza.Insert(commandStr);
            baza.Dissconect();
        }
        public void DodajMjesto(Mjesto novoMjesto)
        {
            string commandStr = $"INSERT INTO Mjesta VALUES ({novoMjesto.broj_pu},'{novoMjesto.naziv}',{novoMjesto.zupanija_id})";
            Baza baza = new Baza();
            baza.Connect();
            baza.Insert(commandStr);
            baza.Dissconect();
        }
        public void DodajZupaniju(Zupanija novaZupanija)
        {
            string commandStr = $"INSERT INTO Zupanije VALUES ({novaZupanija.id},'{novaZupanija.naziv}')";
            Baza baza = new Baza();
            baza.Connect();
            baza.Insert(commandStr);
            baza.Dissconect();
        }
        public void ObrisiKlijenta(int idKlijenta)
        {
            string commandStr = $"DELETE FROM Klijenti WHERE ID = {idKlijenta}";
            Baza baza = new Baza();
            baza.Connect();
            baza.Insert(commandStr);
            baza.Dissconect();
        }
        public void ObrisiMjesto(int puMjesto)
        {
            string commandStr = $"DELETE FROM Mjesta WHERE broj_pu = {puMjesto}";
            Baza baza = new Baza();
            baza.Connect();
            baza.Insert(commandStr);
            baza.Dissconect();
        }
        public void IzmjeniKlijenta(Klijent izmjeKlijent)
        {
            string commandStr = $"UPDATE Klijenti SET naziv = '{izmjeKlijent.naziv}',mjesto_id = {izmjeKlijent.mjesto_id}," +
                $"telefon='{izmjeKlijent.telefon}' WHERE ID = {izmjeKlijent.id}";
            Baza baza = new Baza();
            baza.Connect();
            baza.Insert(commandStr);
            baza.Dissconect();
        }
        public void IzmjeniMjesto(Mjesto mjesto) 
        {
            string commandStr = $"UPDATE Mjesta SET naziv = '{mjesto.naziv}',zupanija_id = {mjesto.zupanija_id}" +
                $"WHERE broj_pu = {mjesto.broj_pu}";
            Baza baza = new Baza();
            baza.Connect();
            baza.Insert(commandStr);
            baza.Dissconect();
        }
        public bool KoristiLiSeMjesto(int mjestID)
        {
            string commandStr = $"SELECT * FROM Klijenti WHERE mjesto_id ={mjestID}";
            Baza baza = new Baza();
            baza.Connect();
            bool rezultat = false;
            OleDbDataReader rdr = baza.Read(commandStr);
            if (rdr.HasRows)
            {
                rezultat = true;
            }
            baza.Dissconect();
            return rezultat;
        }
        public bool DalSuKlijentiPrazni() 
        {
            bool rezultat = true;
            string commandStr = "SELECT * FROM Klijenti";
            Baza baza = new Baza();
            baza.Connect();
            OleDbDataReader rdr = baza.Read(commandStr);
            if (rdr.HasRows)
            {
                rezultat = false;
            }
            return rezultat;
        }
        public bool PostojiLiKlijent(int id)
        {
            bool rezultat = false;
            string commandStr = $"SELECT * FROM Klijenti WHERE ID = {id}";
            Baza baza = new Baza();
            baza.Connect();
            OleDbDataReader rdr = baza.Read(commandStr);
            if (rdr.HasRows)
            {
                rezultat = true;
            }
            return rezultat;
        }
        public string PronadjiZupanijuID(int zupanija_id)
        {
            string commandStr = $"SELECT naziv FROM Zupanije WHERE ID={zupanija_id}";
            Baza baza = new Baza();
            baza.Connect();
            OleDbDataReader rdr = baza.Read(commandStr);
            string rezultat = "";
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    rezultat = rdr[0].ToString();
                }
            }
            return rezultat;
        }
        public int PronadjiZupanijuImenom(string ime)
        {
            string commandStr = $"SELECT ID FROM Zupanije WHERE naziv='{ime}'";
            Baza baza = new Baza();
            baza.Connect();
            OleDbDataReader rdr = baza.Read(commandStr);
            int rezultat = 0;
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    rezultat = int.Parse(rdr[0].ToString());
                }
            }
            return rezultat;
        }
        public int PronadjiMjestoImenom(string ime)
        {
            string commandStr = $"SELECT broj_pu FROM Mjesta WHERE naziv='{ime}'";
            Baza baza = new Baza();
            baza.Connect();
            OleDbDataReader rdr = baza.Read(commandStr);
            int rezultat = 0;
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    rezultat = int.Parse(rdr[0].ToString());
                }
            }
            return rezultat;
        }
        public string PronadjiMjestoId(int id)
        {
            string commandStr = $"SELECT naziv FROM Mjesta WHERE broj_pu={id}";
            Baza baza = new Baza();
            baza.Connect();
            OleDbDataReader rdr = baza.Read(commandStr);
            string rezultat = null;
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    rezultat = rdr[0].ToString();
                }
            }
            return rezultat;
        }
        public void UveziZupanije(string path)
        {
            //kopira sadrzaj izabrane xml datoteke zupanija u zupanije.xml
            //kod uvoza zupanija
            XmlDocument zupanijeXML = new XmlDocument();
            zupanijeXML.Load(path);
            if (zupanijeXML.DocumentElement.Name == "zupanije")
            {
                foreach (XmlNode node in zupanijeXML.DocumentElement.ChildNodes)
                {
                    Zupanija zup = new Zupanija(int.Parse(node.Attributes["id"].Value), node.Attributes["naziv"].Value);
                    DodajZupaniju(zup);
                }
            }
            else
            {
                MessageBox.Show("Odabrana datoteka nije ispravnog sadrzaja");
            }
        }
        public void UveziMjesta(string  path)
        {
            //kopira sadrzaj xml datoteke mjesta kod uvoza u mjesta.xml
            XmlDocument mjestoXML = new XmlDocument();
            mjestoXML.Load(path);
            if (mjestoXML.DocumentElement.Name == "mjesta")
            {
                foreach (XmlNode node in mjestoXML.DocumentElement.ChildNodes)
                {
                    Mjesto misto = new Mjesto(int.Parse(node.Attributes["broj_pu"].Value), node.Attributes["naziv"].Value, int.Parse(node.Attributes["zupanija_id"].Value));
                    DodajMjesto(misto);
                }
            }
            else
            {
                MessageBox.Show("Odabrana datoteka nije ispravnog sadrzaja");
            }
        }
    }
}
