using System;
using System.Collections.Generic;
using System.Text;

namespace _02_AdatvedelemEsKonstruktorok
{
    internal class Bankszamla
    {
        private string szamlaszam;
        private double egyenleg;
        private double hitelKeret;
        public string Szamlaszam{ 
            get { return szamlaszam; } }
        public double Egyenleg { get { return egyenleg; } }
        public double HitelKeret {
            get { return hitelKeret; }
            set
            {
                if (value < 0)
                {
                    hitelKeret = 0;
                }
                else
                {
                    hitelKeret = value;
                }
            }

        } 
        public Bankszamla(string szamlaszam)
        {
            this.szamlaszam = szamlaszam;
            this.egyenleg = 0;
            this.hitelKeret = 50000;
        }
        public Bankszamla(string szamlaszam, double induloEgyenleg, double hitelKeret):this(szamlaszam) {
            this.egyenleg = induloEgyenleg;
            this.hitelKeret = hitelKeret;
        }
        public void Befizetes(double osszeg)
        {
            if (osszeg > 0)
            {
                this.egyenleg += osszeg;
            }
        }
        public bool Kivetel(double osszeg)
        {
            if (egyenleg-osszeg>= -(hitelKeret))
            {
                egyenleg -= osszeg;
                return true;
            }
            return false;
        }
    }
}
