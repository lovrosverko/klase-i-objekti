using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase_i_objekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();

            osoba.setIme("Pero");
            osoba.setPrezime("Perić");
            osoba.setGodinaRodjenja(1997);
            osoba.setVisina(182);
            osoba.setTezina(85);
            osoba.SetSpol('M');

            Console.WriteLine("Ime i prezime: " + osoba.getIme() 
                + " " + osoba.getPrezime() + "\n"
                + "Godina rođenja: " + osoba.getGodinaRodjenja() +"\n"
                + "Visina: " + osoba.getVisina() + "cm\n"
                + "Težina: " + osoba.getTezina() + "kg\n"
                + "Spol: " + osoba.GetSpol() +"\n");

            Osoba osoba1 = new Osoba("Ana", "Anić", 2001, 164, 62, 'Ž');

            Console.WriteLine(osoba1.ToString());

            Console.ReadKey();
        }
    }

    class Osoba
    {
        String ime, prezime;
        int godinaRodjenja, visina, tezina;
        char spol;

        public override string ToString()
        {
            string ispis = "Ime i prezime: " + this.getIme()
                + " " + this.getPrezime() + "\n"
                + "Godina rođenja: " + this.getGodinaRodjenja() + "\n"
                + "Visina: " + this.getVisina() + "cm\n"
                + "Težina: " + this.getTezina() + "kg\n"
                + "Spol: " + this.GetSpol();
            return ispis;
        }
        public Osoba()
        {

        }

        public Osoba(String ime, String prezime, int godinaRodjenja,
            int visina, int tezina, char spol)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godinaRodjenja = godinaRodjenja;
            this.visina = visina;
            this.tezina = tezina;
            this.spol = spol;
        }

        public char GetSpol()
        {
            return spol;
        }

        public void SetSpol(char value)
        {
            spol = value;
        }

        public void setIme (String ime)
        {
            this.ime = ime;
        }
        public String getIme()
        {
            return this.ime;
        }
        public void setPrezime(String prezime)
        {
            this.prezime = prezime;
        }
        public string getPrezime()
        {
            return this.prezime;
        }
        public void setGodinaRodjenja(int godinaRodjenja)
        {
            this.godinaRodjenja = godinaRodjenja;
        }
        public int getGodinaRodjenja()
        {
            return this.godinaRodjenja;
        }
        public void setVisina(int visina)
        {
            this.visina = visina;
        }
        public int getVisina()
        {
            return this.visina;
        }
        public void setTezina(int tezina)
        {
            this.tezina = tezina;
        }
        public int getTezina()
        {
            return this.tezina;
        }


    }
}
