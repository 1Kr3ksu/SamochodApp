using System;
using System.Collections.Generic;
using System.Text;

namespace SamochodApp
{
   public class Samochod
    {
        private string marka;

        private string model;
        
        private int IloscDrzwi;

        private double pojemnoscSilnika;

        private double srednieSpalanie;

        private static int iloscSamochodow = 0;

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        public string Model
        {
            get { return marka; }
            set { marka = value; }
        }

        public int iloscDrzwi
        {
            get { return IloscDrzwi; }
            set { IloscDrzwi = value; }
        }

        public double PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { pojemnoscSilnika = value; }
        }

        public double SrednieSpalanie
        {
            get { return srednieSpalanie; }
            set { srednieSpalanie = value; }
        }

        public Samochod()
        {
            marka = "Nieznana";
            model = "Nieznany";
            iloscDrzwi = 0;
            pojemnoscSilnika = 0.0;
            srednieSpalanie = 0.0;
            iloscSamochodow++;

        }
        
        public Samochod(string marka, string model, int iloscDrzwi,
            double pojemnoscSilnika, double srednieSpalanie)
        {
            this.marka = marka;
            this.model = model;
            this.iloscDrzwi = iloscDrzwi;
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.srednieSpalanie = srednieSpalanie;
            iloscSamochodow++;
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return srednieSpalanie * dlugoscTrasy / 100.0;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }

        public void WypiszInformacje()
        {
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Ilosc drzwi: " + iloscDrzwi);
            Console.WriteLine("Pojemnosc silnika: " + pojemnoscSilnika);
            Console.WriteLine("Srednie spalanie: " + srednieSpalanie);
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine("Ilosc samochodow:" + iloscSamochodow);
        }
    }
}
