namespace ProjektX
{
    public class Klijent
    {
        public int id {  get; set; }
        public string naziv { get; set; }
        public int mjesto_id {  get; set; }
        public string telefon { get; set; }
        public Klijent(int id, string naziv, int mjesto_id, string telefon)
        {
            this.id = id;
            this.naziv = naziv;
            this.mjesto_id = mjesto_id;
            this.telefon = telefon;
        }
    }
}
