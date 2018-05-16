using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punetori
{
    public class Punetori_Detajet : Punetori_Pagat
    {
        public string NumriPersonal { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public DateTime Datelindja { get; set; }
        public string Kompania { get; set; }
        public Pozita PozitaNeKompani { get; set; }


    }

    public enum Pozita
    {
        Punetor = 0,
        Shef = 1,
        Pastrues = 2,
        Menaxher=3

    }
}
