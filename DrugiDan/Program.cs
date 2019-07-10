using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugiDan


{

    /// <summary>
    /// 
    /// vjezba nasljedjivanje ---->
    /// 
    /// 
    /// </summary>
    //class Zaposlenik {

    //    public string Ime;
    //    public string Prezime;
    //    public string Email;

    //    public void IspisiPunoIme() {

    //        Console.WriteLine(Ime + " " + Prezime);
    //    }
    //}



    //class ZaposlenikPoSatu:Zaposlenik {
    //    public float Satnica;
    //    public void IspisiPlacu(int sati)
    //    {

    //        Console.WriteLine("Placa iznosi:" + (sati * Satnica));

    //    }
    //}

    //class Direktor:ZaposlenikPoSatu {
    //    public int BrojVozila;

    //}

    //class Vozilo {

    //    public string Model;
    //    public int BK;
    //    public int Cijena;


    //}
    //class Auto:Vozilo {
    //    public string Marka;
    //    public int Godiste;

    //}
    //class Bager:Vozilo {
    //    public string Boja;

    //}

    class Program
    {
        static void Main(string[] args)
        {
            Doktor d = new Doktor();
            d.SetIme("");
            d.SetPrezime(null);
            Console.WriteLine(d.GetPrezime());


            //nasljeđivanje
            //Zaposlenik z1 = new Zaposlenik();
            //z1.Ime = "Marko";
            //z1.Prezime = "Markovic";
            //z1.Email = "Marko.markovic@gmail.com";
            //z1.IspisiPunoIme();
            //ZaposlenikPoSatu z2 = new ZaposlenikPoSatu();

            //z2.Satnica = 20;
            //z2.IspisiPlacu(6);
            //Direktor x = new Direktor();
            //x.Ime = "Ime";
            //x.Prezime = "Prezime";
            //x.IspisiPunoIme();

            //Vozilo v = new Vozilo();
            //v.IspisiLokaciju();
            //Tenk t = new Tenk();
            //t.SmanjiSnaguStita();
            //t.PovecajSnaguStita(2);
            //t.IspisiLokaciju();
            //BacacRaketa b = new BacacRaketa();
            //b.IspisiLokaciju();
            //Vojnik h = new Vojnik();
            //h.Pucaj();
            //h.IspisiEnergijuILokaciju();
            //Raketist r = new Raketist();
            //int energija = r.DohvatiEnergiju();
            //Console.WriteLine(energija);
            //Snajperist s = new Snajperist();
            //int l;
            //int n;
            //s.DohvatiLokaciju(out l, out n);
            //Vozilo x = new Tenk();
            // Doktor kata = new Doktor();
            // kata.Ime = "kata";
            // kata.Prezime = "prez";
            // kata.Godine = 2;


            // Kardiolog pero = new Kardiolog();
            // pero.Ime = "pero";
            // pero.Prezime = "prezime";
            // pero.Godine = 5;


            // Pumolog pumo = new Pumolog();
            // pumo.Ime = "pumo";
            // pumo.Prezime = "prez";
            // pumo.Godine = 5;


            //Doktor[] doktori = new Doktor[3];
            // doktori[0] = kata;
            // doktori[1] = pero;
            // doktori[2] = pumo;

            // Console.WriteLine("Ovo su doktori");
            // foreach (var doktor in doktori) {

            //     doktor.PredstaviSe();
            // }

            //Vojnik snajperist = new Snajperist();
            //Vojnik raketist = new Raketist();
            //snajperist.BrzinaKretanja = 10;
            //snajperist.Energija = 20;
            //snajperist.x = 2;
            //snajperist.y = 3;
            //raketist.BrzinaKretanja = 10;
            //raketist.Energija = 40;
            //raketist.x = 10;
            //raketist.y = 50;
            //Vozilo tenk = new Tenk();
            //tenk.Energija = 2;
            //tenk.x = 4;
            //tenk.y = 5;
            //Vozilo kamion = new Kamion();
            //kamion.Energija = 33;
            //kamion.x = 2;
            //kamion.y = 3;

            //Vojnik[] vojnici = new Vojnik[2];
            //vojnici[0] = snajperist;
            //vojnici[1] = raketist;
            //foreach (var v in vojnici) {
            //    v.IspisiEnergijuILokaciju();
            //}

            //Vozilo[] vozila = new Vozilo[2];
            //vozila[0] = kamion;
            //vozila[1] = tenk;

            //foreach (var v in vozila) {
            //    v.IspisiLokaciju();

            //}

            


            Console.ReadLine();
        }

    }
}
