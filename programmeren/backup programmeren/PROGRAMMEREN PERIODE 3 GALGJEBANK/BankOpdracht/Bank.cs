using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOpdracht
{
    public class Bank
    {
        List<Rekening> bankrekeningen = new List<Rekening>();
        private int aantalrekeningen;
        public string Naam { get; set; }

        public Bank(string banknaam)
        {
            this.Naam = banknaam;
        }

        public Rekening ZoekRekening(int rekeningNr)
        {
            foreach (Rekening rekening in bankrekeningen)
            {
                if (rekening.Nr == rekeningNr)
                {
                    return rekening;
                }
            }
            return null;
        }
        public int OpenRekening(string voornaam, string achternaam, string adres, string postcode, int startsaldo = 0, int salaris = 0)
        {
            if (startsaldo < 0) // wanneer er een negatieve startsaldo binnenkomt geef -1 terug.
            {
                return -1;
            }

            Rekening rekeningen = new Rekening(voornaam, achternaam, adres, postcode, startsaldo, salaris, aantalrekeningen);
            bankrekeningen.Add(rekeningen);
            aantalrekeningen++;
            return rekeningen.Nr;
        }

        public Rekening VerwijderRekening(int rekeningNr)
        {
            if (rekeningNr < 0)
            {
                return null;
            }
            Rekening rekening = bankrekeningen[rekeningNr];
            bankrekeningen.Remove(rekening);
            return rekening;
        }
        public decimal RenteUitkeren(int rentepercentage)
        {
            decimal totaalrente = 0;
            foreach (Rekening rekening in bankrekeningen)
            {
                if (rekening.Saldo <= 0) continue; // alleen doorgaan als dit waar is.
                decimal nieuwesaldo = rekening.Saldo * ((100m + rentepercentage) / 100m);
                decimal rentebedrag = nieuwesaldo - rekening.Saldo;
                totaalrente += rentebedrag;
                rekening.Saldo = nieuwesaldo;
            }
            return totaalrente;
        }
        public override string ToString()
        {
            string s = "\n\n---------------------\n Naam van bank: " + Naam + "\n---------------------\n";
            foreach (Rekening rekening in bankrekeningen)
            {
                s += rekening;
                s += "\n";
            }
            s += "---------------------";
            s += "\n\n";
            return s;

        }
    }
}
