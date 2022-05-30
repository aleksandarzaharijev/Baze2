using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBaze2
{
    #region Banka
    public class BankaPregled
    {
        public int Id;
        public string AdresaCentrale;
        public string WebAdresa;
        public string Ime;
        public string Email;

        public BankaPregled() {}

        public BankaPregled(int id, string adresaCentrale, string webAdresa, string ime, string email)
        {
            Id = id;
            AdresaCentrale = adresaCentrale;
            WebAdresa = webAdresa;
            Ime = ime;
            Email = email;
        }
    }

    public class BankaBasic
    {
        public int Id;
        public string AdresaCentrale;
        public string WebAdresa;
        public string Ime;
        public string Email;
        
        public virtual IList<Devizni_racunBasic> Devizni_Racuni { get; set; }
        public virtual IList<Dinarski_racunBasic> Dinarski_Racuni { get; set; }
        public virtual IList<Banka_telefoniBasic> Banka_Telefoni { get; set; }
        public virtual IList<FilijalaBasic> Lista_Filijala { get; set; }

        public BankaBasic()
        {
            Devizni_Racuni = new List<Devizni_racunBasic>();
            Dinarski_Racuni = new List<Dinarski_racunBasic>();
            Banka_Telefoni = new List<Banka_telefoniBasic>();
            Lista_Filijala = new List<FilijalaBasic>();
        }
        public BankaBasic(int id, string adresaCentrale, string webAdresa, string ime, string email)
        {
            Id = id;
            AdresaCentrale = adresaCentrale;
            WebAdresa = webAdresa;
            Ime = ime;
            Email = email;

        }

        public override string ToString()
        {
            return Ime + " " + AdresaCentrale + " " + WebAdresa + " " + Email;
        }

    }


    #endregion

    #region Banka_telefoni
    public class Banka_telefoniPregled
    {
        public int id;

        public string Broj_Telefona;
        public Banka_telefoniPregled() { }
        public Banka_telefoniPregled(int id, string broj_Telefona)

        {
            this.id = id;
            Broj_Telefona = broj_Telefona;
        }

    }
    public class Banka_telefoniBasic
    {
        public BankaBasic bankab;
        public int id;

        public string Broj_Telefona;
        public Banka_telefoniBasic() { }

        public Banka_telefoniBasic( int id, string broj_Telefona)
        {
          
            this.id = id;
            broj_Telefona = Broj_Telefona;
        }
      
        public override string ToString()
        {
            return Broj_Telefona;
        }

    }

    #endregion

    #region Bankomat

    public class BankomatPregled
    {
        public int Id;
        public string Lokacija;
        public string NazivProizvodjaca;

        public bool Status;
        public DateTime DatumPoslednjegServisa;

        public BankomatPregled()
        {

        }

        public BankomatPregled(int id, string lokacija, string nazivProizvodjaca, bool status, DateTime datumPoslednjegServisa)
        {
            Id = id;
            Lokacija = lokacija;
            NazivProizvodjaca = nazivProizvodjaca;
            Status = status;
            DatumPoslednjegServisa = datumPoslednjegServisa;
        }
    }
    public class BankomatBasic
    {
        public int Id;
        public string Lokacija;
        public string NazivProizvodjaca;

        public bool Status;
        public DateTime DatumPoslednjegServisa;

        public virtual IList<Bankomat_komentariBasic> Komentari { get; set; }
        public virtual IList<TransakcijaBasic> Transakcije { get; set; }

        public BankomatBasic()
        {
            Komentari = new List<Bankomat_komentariBasic>();
            Transakcije = new List<TransakcijaBasic>();

        }

        public BankomatBasic(int id, string lokacija, string nazivProizvodjaca, bool status, DateTime datumPoslednjegServisa)
        {
            Id = id;
            Lokacija = lokacija;
            NazivProizvodjaca = nazivProizvodjaca;
            Status = status;
            DatumPoslednjegServisa = datumPoslednjegServisa;
        }

        public override string ToString()
        {
            return Lokacija + " " + NazivProizvodjaca + " " + Status + " " + DatumPoslednjegServisa.ToString();
        }

    }
    #endregion

    #region Bankomat_komentari
    public class Bankomat_komentariPregled
    {
        public int Id;
        public string DodatniKomentari;

        public Bankomat_komentariPregled() { }
        public Bankomat_komentariPregled(int id, string dodatniKomentari)
        {
            Id = id;
            DodatniKomentari = dodatniKomentari;
        }
    }

    public class Bankomat_komentariBasic
    {
        public int Id;
        public string DodatniKomentari;

        public Bankomat_komentariBasic() { }

        public Bankomat_komentariBasic(int id, string dodatniKomentari)
        {
            Id = id;
            DodatniKomentari = dodatniKomentari;
        }

        public override string ToString()
        {
            return DodatniKomentari;
        }
    }
    #endregion

    #region Debitna_kartica
    public class Debitna_karticaPregled
    {
        public int Id;
        public DateTime Datum_izdavanja;
        public DateTime Datum_isteka_vazenja;
        public int DnevniLimit;

        public Debitna_karticaPregled()
        {

        }
        public Debitna_karticaPregled(int id, DateTime datum_izdavanja, DateTime datum_isteka_vazenja, int dnevniLimit)
        {
            Id = id;
            Datum_izdavanja = datum_izdavanja;
            Datum_isteka_vazenja = datum_isteka_vazenja;
            DnevniLimit = dnevniLimit;
        }
    }

    public class Debitna_karticaBasic
    {
        public int Id;
        public DateTime Datum_izdavanja;
        public DateTime Datum_isteka_vazenja;
        public int DnevniLimit;

        public Debitna_karticaBasic()
        {

        }
        public Debitna_karticaBasic(int id, DateTime datum_izdavanja, DateTime datum_isteka_vazenja, int dnevniLimit)
        {
            Id = id;
            Datum_izdavanja = datum_izdavanja;
            Datum_isteka_vazenja = datum_isteka_vazenja;
            DnevniLimit = dnevniLimit;
        }
        public override string ToString()
        {
            return Datum_izdavanja.ToString() + " " + Datum_isteka_vazenja.ToString() + " " + DnevniLimit;
        }
    }

    #endregion

    #region Devizni racun

    public class Devizni_racunPregled {

        public int Id;

        public DateTime DatumOtvaranja;

        public int Saldo;

        public string Valuta;

        public Devizni_racunPregled()
        {

        }
        public Devizni_racunPregled(int id, DateTime datumOtvaranja, int saldo, string valuta)
        {
            Id = id;
            DatumOtvaranja = datumOtvaranja;
            Saldo = saldo;
            Valuta = valuta;
        }
    }
    public class Devizni_racunBasic
    {

        public int Id;

        public DateTime DatumOtvaranja;

        public int Saldo;

        public string Valuta;

        public virtual IList<Devizni_racun_licaBasic> Devizni_Racun_Lica { get; set; }

        public virtual IList<Debitna_karticaBasic> Debitne_kartice { get; set; }

        public virtual IList<Kreditna_karticaBasic> Kreditne_kartice { get; set; }

        public Devizni_racunBasic()
        {
            Devizni_Racun_Lica = new List<Devizni_racun_licaBasic>();
            Debitne_kartice = new List<Debitna_karticaBasic>();
            Kreditne_kartice = new List<Kreditna_karticaBasic>();

        }

        public Devizni_racunBasic(int id, DateTime datumOtvaranja, int saldo, string valuta)
        {
            Id = id;
            DatumOtvaranja = datumOtvaranja;
            Saldo = saldo;
            Valuta = valuta;
        }
        public override string ToString()
        {
            return Valuta + " " + Saldo;
        }
    }
    #endregion

    #region Devizni racun lica
    public class Devizni_racun_licaPregled
    {
        public int Id;
        public string Imena_Lica;

        public Devizni_racun_licaPregled()
        {

        }
        public Devizni_racun_licaPregled(int id, string imena_Lica)
        {
            Id = id;
            Imena_Lica = imena_Lica;
        }
    }
    public class Devizni_racun_licaBasic
    {
        public int Id;
        public string Imena_Lica;

        public Devizni_racun_licaBasic()
        {

        }
        public Devizni_racun_licaBasic(int id, string imena_Lica)
        {
            Id = id;
            Imena_Lica = imena_Lica;
        }
        public override string ToString()
        {
            return Imena_Lica;

        }
    }
    #endregion

    #region Dinarski racun
    public class Dinarski_racunPregled
        {
        public int Id;

        public DateTime DatumOtvaranja;

        public int Saldo;

        public Dinarski_racunPregled()
        {

        }
        public Dinarski_racunPregled(int id, DateTime datumOtvaranja, int saldo)
        {
            Id = id;
            DatumOtvaranja = datumOtvaranja;
            Saldo = saldo;
        }
    }
    public class Dinarski_racunBasic {
        public int Id;

        public DateTime DatumOtvaranja;

        public int Saldo;
        public virtual IList<Dinarski_racun_licaBasic> Dinarski_Racun_Lica { get; set; }

        public virtual IList<Debitna_karticaBasic> Debitne_kartice { get; set; }

        public virtual IList<Kreditna_karticaBasic> Kreditne_kartice { get; set; }

        public Dinarski_racunBasic()
        {
            Dinarski_Racun_Lica = new List<Dinarski_racun_licaBasic>();
            Debitne_kartice = new List<Debitna_karticaBasic>();
            Kreditne_kartice = new List<Kreditna_karticaBasic>();
        }

        public Dinarski_racunBasic(int id, DateTime datumOtvaranja, int saldo)
        {
            Id = id;
            DatumOtvaranja = datumOtvaranja;
            Saldo = saldo;
        }
        public override string ToString()
        {
            return Saldo + " "+ DatumOtvaranja.ToString();
        }
    }

    #endregion

    #region Dinarski racun lica
    public class Dinarski_racun_licaPregled
    {
        public int Id;
        public string Imena_Lica;

        public Dinarski_racun_licaPregled()
        {

        }
        public Dinarski_racun_licaPregled(int id, string imena_Lica)
        {
            Id = id;
            Imena_Lica = imena_Lica;
        }
       
    }

    public class Dinarski_racun_licaBasic
    {
        public int Id;
        public string Imena_Lica;

        public Dinarski_racun_licaBasic()
        {

        }
        public Dinarski_racun_licaBasic(int id, string imena_Lica)
        {
            Id = id;
            Imena_Lica = imena_Lica;
        }
        public override string ToString()
        {
            return Imena_Lica;

        }

    }
    #endregion

    #region Filijala
    public class FilijalaPregled
    {
        public  int Id;
        public string Adresa;
        public string BrojTelefona;
        public  string RadnoVreme;

        public FilijalaPregled()
        {

        }
        public FilijalaPregled(int id, string adresa, string brojTelefona, string radnoVreme)
        {
            Id = id;
            Adresa = adresa;
            BrojTelefona = brojTelefona;
            RadnoVreme = radnoVreme;
        }
    }
    public class FilijalaBasic
    {
        public int Id;
        public string Adresa;
        public string BrojTelefona;
        public string RadnoVreme;
        public virtual IList<BankomatBasic> Bankomati { get; set; }
        public FilijalaBasic()
        {
            
            Bankomati = new List<BankomatBasic>();

        }

        public FilijalaBasic(int id, string adresa, string brojTelefona, string radnoVreme)
        {
            Id = id;
            Adresa = adresa;
            BrojTelefona = brojTelefona;
            RadnoVreme = radnoVreme;
            
        }
        public override string ToString()
        {
            return Adresa + " " + BrojTelefona + " " + RadnoVreme;
        }
    }
    #endregion

    #region Klijent
    public class KlijentBasic
    {
        public int Id;

        public string Naziv;

        public string Adresa;

        public string Email;

        public string Broj_Telefona;
        public virtual IList<Klijent_komentariBasic> Klijent_Komentari { get; set; }

        public virtual IList<Pravna_licaBasic> Pravna_Lica { get; set; }

        public virtual IList<Fizicka_licaBasic> Fizicka_Lica { get; set; }

        public virtual IList<Devizni_racunBasic> Devizni_Racuni { get; set; }

        public virtual IList<Dinarski_racunBasic> Dinarski_Racuni { get; set; }
        public KlijentBasic(int id, string naziv, string adresa, string email, string broj_Telefona)
        {
            Id = id;
            Naziv = naziv;
            Adresa = adresa;
            Email = email;
            Broj_Telefona = broj_Telefona;
        }
        public KlijentBasic()
        {
            Klijent_Komentari = new List<Klijent_komentariBasic>();

            Pravna_Lica = new List<Pravna_licaBasic>();

            Fizicka_Lica = new List<Fizicka_licaBasic>();

            Devizni_Racuni = new List<Devizni_racunBasic>();

            Dinarski_Racuni = new List<Dinarski_racunBasic>();

        }
    }
        public class Fizicka_licaBasic:KlijentBasic
        {
            public string Ime;

            public string Prezime;

            public string Ime_roditelja;

            public int Broj_Licne_Karte;

            public string Mesto_Izdavanja;

            public DateTime Datum_Rodjenja;

            public int JMBG;

            public Fizicka_licaBasic():base()
            {

            }
            public Fizicka_licaBasic(string ime, string prezime, string ime_roditelja, int broj_Licne_Karte, string mesto_Izdavanja, DateTime datum_Rodjenja, int jMBG, int id, string naziv, string adresa, string email, string broj_Telefona) :base( id,  naziv,  adresa,  email,broj_Telefona)
            {
                Ime = ime;
                Prezime = prezime;
                Ime_roditelja = ime_roditelja;
                Broj_Licne_Karte = broj_Licne_Karte;
                Mesto_Izdavanja = mesto_Izdavanja;
                Datum_Rodjenja = datum_Rodjenja;
                JMBG = jMBG;
            }
            public override string ToString()
            {
                return Ime + " " + Prezime + " " + JMBG;
            }
        }
    public class Pravna_licaBasic : KlijentBasic
    {
        public int PoreskiBroj;

        public Pravna_licaBasic() : base()
        {

        }
        public Pravna_licaBasic(int poreskiBroj, int id, string naziv, string adresa, string email, string broj_Telefona) : base(id, naziv, adresa, email, broj_Telefona)

        {
            PoreskiBroj = poreskiBroj;
        }
        public override string ToString()
        {
            return PoreskiBroj + " " + Email;
        }
    }

    public class KlijentPregled
    {
        public int Id;

        public string Naziv;

        public string Adresa;

        public string Email;

        public string Broj_Telefona;

        public KlijentPregled()
        {

        }
        public KlijentPregled(int id, string naziv, string adresa, string email, string broj_Telefona)
        {
            Id = id;
            Naziv = naziv;
            Adresa = adresa;
            Email = email;
            Broj_Telefona = broj_Telefona;
        }

    }
    public class Fizicka_licaPregled:KlijentPregled
    {
        public string Ime;

        public string Prezime;

        public string Ime_roditelja;

        public int Broj_Licne_Karte;

        public string Mesto_Izdavanja;

        public DateTime Datum_Rodjenja;

        public int JMBG;

        public Fizicka_licaPregled():base()
        {

        }
        public Fizicka_licaPregled(string ime, string prezime, string ime_roditelja, int broj_Licne_Karte, string mesto_Izdavanja, DateTime datum_Rodjenja, int jMBG, int id, string naziv, string adresa, string email, string broj_Telefona) : base(id, naziv, adresa, email, broj_Telefona)
        {
            Ime = ime;
            Prezime = prezime;
            Ime_roditelja = ime_roditelja;
            Broj_Licne_Karte = broj_Licne_Karte;
            Mesto_Izdavanja = mesto_Izdavanja;
            Datum_Rodjenja = datum_Rodjenja;
            JMBG = jMBG;
        }

    }
    public class Pravna_licaPregled:KlijentPregled
    {
        public int PoreskiBroj;

        public Pravna_licaPregled() : base()
        {

        }
        public Pravna_licaPregled(int poreskiBroj, int id, string naziv, string adresa, string email, string broj_Telefona) : base(id, naziv, adresa, email, broj_Telefona)

        {
            PoreskiBroj = poreskiBroj;
        }
    }

    #endregion

    #region Klijent komentari
    public class Klijent_komentariPregled
    {
        public int Id;

        public string Dodatni_komentar;

        public Klijent_komentariPregled()
        {

        }
        public Klijent_komentariPregled(int id, string dodatni_komentar)
        {
            Id = id;
            Dodatni_komentar = dodatni_komentar;
        }

    }
    public class Klijent_komentariBasic
    {
        public int Id;

        public  string Dodatni_komentar;

        public Klijent_komentariBasic()
        {

        }
        public Klijent_komentariBasic(int id, string dodatni_komentar)
        {
            Id = id;
            Dodatni_komentar = dodatni_komentar;
        }
        public override string ToString()
        {
            return Dodatni_komentar;
        }
    }
    #endregion

    #region Kreditna kartica

    public class Kreditna_karticaPregled {
        public int Id;
        public DateTime Datum_izdavanja;
        public DateTime Datum_isteka_vazenja;
        public DateTime Rok_vracanja_duga;
        public int DnevniLimit;
        public int MesecnoZaduzenje;

        public Kreditna_karticaPregled()
        {

        }
        public Kreditna_karticaPregled(int id, DateTime datum_izdavanja, DateTime datum_isteka_vazenja, DateTime rok_vracanja_duga, int dnevniLimit, int mesecnoZaduzenje)
        {
            Id = id;
            Datum_izdavanja = datum_izdavanja;
            Datum_isteka_vazenja = datum_isteka_vazenja;
            Rok_vracanja_duga = rok_vracanja_duga;
            DnevniLimit = dnevniLimit;
            MesecnoZaduzenje = mesecnoZaduzenje;
        }
    }

    public class Kreditna_karticaBasic
    {
        public int Id;
        public DateTime Datum_izdavanja;
        public DateTime Datum_isteka_vazenja;
        public DateTime Rok_vracanja_duga;
        public int DnevniLimit;
        public int MesecnoZaduzenje;
        public virtual IList<Dinarski_racunBasic> Dinarski_Racuni { get; set; }
        public virtual IList<Devizni_racunBasic> Devizni_Racuni { get; set; }

        public Kreditna_karticaBasic()
        {
            Dinarski_Racuni = new List<Dinarski_racunBasic>();

            Devizni_Racuni = new List<Devizni_racunBasic>();
        }

        public Kreditna_karticaBasic(int id, DateTime datum_izdavanja, DateTime datum_isteka_vazenja, DateTime rok_vracanja_duga, int dnevniLimit, int mesecnoZaduzenje)
        {
            Id = id;
            Datum_izdavanja = datum_izdavanja;
            Datum_isteka_vazenja = datum_isteka_vazenja;
            Rok_vracanja_duga = rok_vracanja_duga;
            DnevniLimit = dnevniLimit;
            MesecnoZaduzenje = mesecnoZaduzenje;
        }

        public override string ToString()

        { return DnevniLimit + " " + MesecnoZaduzenje + " " + DnevniLimit; }

    }
    #endregion

    #region Transakcija
    public class TransakcijaPregled
    {
        public int Id;
        public int Iznos;
        public DateTime DatuVremePodizanjaNovca;

        public TransakcijaPregled()
        {

        }

        public TransakcijaPregled(int id, int iznos, DateTime datuVremePodizanjaNovca)
        {
            Id = id;
            Iznos = iznos;
            DatuVremePodizanjaNovca = datuVremePodizanjaNovca;
        }
    }
    public class TransakcijaBasic
    {
        public int Id;
        public int Iznos;
        public DateTime DatuVremePodizanjaNovca;

        public TransakcijaBasic()
        {

        }

        public TransakcijaBasic(int id, int iznos, DateTime datuVremePodizanjaNovca)
        {
            Id = id;
            Iznos = iznos;
            DatuVremePodizanjaNovca = datuVremePodizanjaNovca;
        }

        public override string ToString()
        {
            return Iznos + " " + DatuVremePodizanjaNovca.ToString();
        }
    }
    #endregion
}
