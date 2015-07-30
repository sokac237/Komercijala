using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace blokerX
{
    class DohvatiSifruID
    {


        Upiti veza = new Upiti();
        string SifraID;

        public string DohvatiIDSifra(string IDSifra, string tablica, string parametar)
        {
            DataTable podaci = new DataTable();
            //string a = "select " + IDSifra + " from " + tablica + " where " + parametar + "";
            veza.ExecuteQuery("select " + IDSifra + " from " + tablica + " where " + parametar + "", ref podaci);

            if (podaci.Rows.Count > 0)
            {
                SifraID = podaci.Rows[0][0].ToString();
            }

            return SifraID;
        }

    }
}
