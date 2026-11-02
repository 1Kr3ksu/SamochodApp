using SamochodApp;

Samochod s1 = new Samochod();
s1.WypiszInformacje();

s1.Marka = "Fiat";
s1.Model = "126p";
s1.iloscDrzwi = 2;
s1.PojemnoscSilnika = 650;
s1.SrednieSpalanie = 6.0;
s1.WypiszInformacje();

Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);
s2.WypiszInformacje();

double kosztPrzejazdu = s2.ObliczKosztPrzejazdu(30.5, 4.85);
Console.WriteLine("Koszt przejazdu: " + kosztPrzejazdu);

Samochod.WypiszIloscSamochodow();
Console.ReadKey();
