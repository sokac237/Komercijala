using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace blokirajx
{
    class Global
    {

        private static string ImePrezime = "";
        public static string Korisnik
        {
            get { return ImePrezime; }
            set { ImePrezime = value; }
        }

        private static string IDkoirsnika = "";
        public static string KorisnikID
        {
            get { return IDkoirsnika; }
            set { IDkoirsnika = value; }
        }

        private static string flag = "1";
        public static string Flag
        {
            get { return flag; }
            set { flag = value; }
        }

        private static string dobavljac = "";
        public static string dobavljacID
        {
            get { return dobavljac; }
            set { dobavljac = value; }
        }

        private static string oznaka = "";
        public static string oznaci
        {
            get { return oznaka; }
            set { oznaka = value; }
        }

        private static string IDakcije = "";
        public static string akcijaZagID
        {
            get { return IDakcije; }
            set { IDakcije = value; }
        }

        private static string sifraAkcije = "";
        public static string akcijaSifra
        {
            get { return sifraAkcije; }
            set { sifraAkcije = value; }
        }

        private static string brojAkcije = "";
        public static string akcijaBroj
        {
            get { return brojAkcije; }
            set { brojAkcije = value; }
        }


        private static string akcija13partner = "";
        public static string akcija13dobavljac
        {
            get { return akcija13partner; }
            set { akcija13partner = value; }
        }
    }
}
