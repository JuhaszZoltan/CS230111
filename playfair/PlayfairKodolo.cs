using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace playfair
{
    internal class PlayfairKodolo
    {
        public char[,] Kulcstabla { get; set; }

        public (int S, int O) Index (char karakter)
        {
            for (int s = 0; s < Kulcstabla.GetLength(0); s++)
            {
                for (int o = 0; o < Kulcstabla.GetLength(1); o++)
                {
                    if (Kulcstabla[s, o] == karakter) return (s, o);
                }
            }
            return (-1, -1);
        }

        public string KodolBetupar(string betupar)
        {
            (int b1s, int b1o) = Index(betupar[0]);
            (int b2s, int b2o) = Index(betupar[1]);

            char k1, k2;

            if (b1s == b2s)
            {
                if (b1o < Kulcstabla.GetLength(1) - 1) k1 = Kulcstabla[b1s, b1o + 1];
                else k1 = Kulcstabla[b1s, 0];
                if (b2o < Kulcstabla.GetLength(1) - 1) k2 = Kulcstabla[b2s, b2o + 1];
                else k2 = Kulcstabla[b2s, 0];
            }
            else if (b1o == b2o)
            {
                if (b1s < Kulcstabla.GetLength(0) - 1) k1 = Kulcstabla[b1s + 1, b1o];
                else k1 = Kulcstabla[0, b1o];
                if (b2s < Kulcstabla.GetLength(0) - 1) k2 = Kulcstabla[b2s + 1, b2o];
                else k2 = Kulcstabla[0, b2o];
            }
            else
            {
                k1 = Kulcstabla[b1s, b2o];
                k2 = Kulcstabla[b2s, b1o];
            }
            return $"{k1}{k2}";
        }

        public PlayfairKodolo(string file)
        {
            Kulcstabla = new char[5, 5];

            using StreamReader sr = new(file);
            int si = 0;
            while (!sr.EndOfStream)
            {
                string teljesSor = sr.ReadLine()!;
                for (int oi = 0; oi < teljesSor.Length; oi++)
                {
                    Kulcstabla[si, oi] = teljesSor[oi];
                }
                si++;
            }
        }
    }
}
