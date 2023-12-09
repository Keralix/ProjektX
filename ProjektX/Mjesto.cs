namespace ProjektX
{
    public class Mjesto
    {
        public int broj_pu { get; set; }
        public string naziv {  get; set; }
        public int zupanija_id { get; set;}
        public Mjesto(int broj_pu, string naziv, int zupanija_id)
        {
            this.broj_pu = broj_pu;
            this.naziv = naziv;
            this.zupanija_id = zupanija_id;
        }
    }
}
