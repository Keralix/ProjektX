namespace ProjektX
{
    public class Zupanija
    {
        public int id {  get; set; }
        public string naziv { get; set; }
        public Zupanija(int id, string naziv)
        {
            this.id = id;
            this.naziv = naziv;
        }
    }
}
