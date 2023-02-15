using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepteremProject
{
    class Gepterem
    {
        readonly int[,] ertekeles;
        readonly int helyDb;
        readonly string nev;
        readonly int sorDb;

        public Gepterem(string nev, int sorDb, int helyDb, int[,] ertekeles)
        {
            this.nev = nev;
            this.sorDb = sorDb;
            this.helyDb = helyDb;
            this.ertekeles = ertekeles;
        }

        public double Atlag()
        {
            double sum = 0;
            int db = 0;
            for (int i = 0; i < SorDb; i++)
            {
                for (int j = 0; j < HelyDb; j++)
                {
                    if (Ertekeles[i, j] > 0)
                    {
                        sum += Ertekeles[i, j];
                        db++;
                    }
                }
            }
            return sum / db;
        }

        public int[,] Ertekeles => ertekeles;

        public int HelyDb => helyDb;

        public string Nev => nev;

        public int SorDb => sorDb;
    }
}
