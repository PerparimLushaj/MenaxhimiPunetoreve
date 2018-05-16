using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punetori
{
    class Punetori
    {
        public static List<Punetori_Detajet> punetoret = new List<Punetori_Detajet>();
        public static List<Punetori_Pagat> pagat = new List<Punetori_Pagat>();

        public static void RegjistroPunetorin(string nrpersonal, string emri, string mbiemri, DateTime datelindja, string Kompania, Pozita _pozita)
        {
            Punetori_Detajet p = new Punetori_Detajet();
            p.NumriPersonal = nrpersonal;
            p.Emri = emri;
            p.Mbiemri = mbiemri;
            p.Datelindja = datelindja;

            p.Kompania = Kompania;
            p.PozitaNeKompani = _pozita;



            punetoret.Add(p);

        }
        public static void RegjistroPagen(Punetori_Detajet punetori, int muaji, int viti, decimal rroga)
        {
            Punetori_Pagat pg = new Punetori_Detajet();
            //pg.Punetori = punetori;
            pg.muaji = muaji;
            pg.viti = viti;
            pg.Rroga = rroga;
            pagat.Add(pg);
            punetori.muaji = muaji;
            punetori.viti = viti;
            punetori.Rroga = rroga;
        }

        public static string ListaPunetoreve()
        {
            string sb = "";
            for (int i = 0; i < punetoret.Count; i++)
            {
                string s = "\r\n" + punetoret[i].NumriPersonal + "\t\t\t" + punetoret[i].Emri + "\t\t" + punetoret[i].Mbiemri + "\t\t" + punetoret[i].Rroga.ToString();
                sb += s + "\n\n";
            }
            return sb.ToString();
            
        }
        public static double NumriIpunetoreve()
        {
            double s = 0;
            s = punetoret.Count();
            return s;
        }

    }
}
