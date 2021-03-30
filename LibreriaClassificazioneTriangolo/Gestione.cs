using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClassificazioneTriangolo
{
    public class Gestione
    {
        public static double Perimetro(double lato1, double lato2, double lato3)
        {
            return lato1 + lato2 + lato3;
        }
        public static double Area(double lato1, double lato2, double lato3)
        {
            double semip = (Perimetro(lato1, lato2, lato3)) / 2;
            return (Math.Sqrt(semip)) * (semip - lato1) * (semip - lato2) * (semip - lato3);
        }
    }
}
