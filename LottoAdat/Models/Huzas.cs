using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoSzimulator.Models
{
    public class Huzas
    {
        public int Id { get; set; }
        public int Szam1 { get; set; }
        public int Szam2 { get; set; }
        public int Szam3 { get; set; }
        public int Szam4 { get; set; }
        public int Szam5 { get; set; }
        
        public Huzas()
        {
        }

        public Huzas(string sor)
        {
            string[] tomb = sor.Trim().Split(";");

            if (tomb.Length == 5)
            {
                int[] tombSz = new int[5];

                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        tombSz[i] = Convert.ToInt32(tomb[i]);
                    }
                    catch (Exception)
                    {

                        throw new Exception();
                    }

                    if ((tombSz[i] < 1) || (tombSz[i] > 90)) throw new Exception();

                }

                HashSet<int> halmaz = new HashSet<int>();
                if (halmaz.Count() != 5) throw new Exception();

                Szam1 = tombSz[0];
                Szam2 = tombSz[1];
                Szam3 = tombSz[2];
                Szam4 = tombSz[3];
                Szam5 = tombSz[4];
            }
            else
            {
                throw new Exception();
            }
        }
    }

}
