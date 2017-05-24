using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOpdracht
{
    public class Rekening
    {
        //link bank.cs met rekening.cs.
        public string voornaam { get; }
        public string achternaam { get; }
        public string adres { get; }
        public string postcode { get; }
        public decimal Saldo { get; set; }
        public decimal salaris { get; set; }
        public int Nr { get; }

        public Rekening (string Voornaam, string Achternaam, string Adres, string Postcode, int Startsaldo, int Salaris,int Rekeningnummer)
        {
            voornaam = Voornaam;
            achternaam = Achternaam;
            adres = Adres;
            postcode = Postcode;
            Saldo = Startsaldo;
            salaris = Salaris;
            Nr = Rekeningnummer;
        }

        public bool GeldStorten(decimal v)
        {
            if(v <= 0)
            {
                return false;
            }
            Saldo += v;
            return true;
        }

        public bool GeldOpnemen(decimal v)
        {
            if (v <= 0)
            {
                return false;
            }
            if (Saldo - v < -(salaris/2))
            {
                return false;
            }
            Saldo -= v;
            return true;
        }

        public bool GeldOvermaken(Rekening rekening, decimal v)
        {
            return GeldOpnemen(v) && rekening.GeldStorten(v);
        }
        public override string ToString()
        {
            return achternaam + " , " + voornaam + " , " + Nr + " , " + Saldo;
        }
    }
}
