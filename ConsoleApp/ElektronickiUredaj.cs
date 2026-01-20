namespace ConsoleApp
{
    internal class ElektronickiUredaj
    {
        public string Naziv { get; set; }
        public string Proizvodac { get; set; }
        public int GodinaProizvodnje { get; set; }
        public ElektronickiUredaj(string naziv, string proizvodac, int GodProizvodnje)
        {
            Naziv = naziv;
            Proizvodac = proizvodac;
            GodinaProizvodnje = GodProizvodnje;
        }

        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}, Proizvođač: {Proizvodac}, Godina proizvodnje: {GodinaProizvodnje} g.");
        }
    }
}
