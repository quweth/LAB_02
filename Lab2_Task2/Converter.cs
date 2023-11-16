using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Converter
    {
        private double x; // usd to uah 
        private double y; // eur to uah
        private double z; // pln to uah
        private double g; // uah
        private double h; // uah to usd
        private double c; // uah to eur
        private double d; // uah to pln

        public double X
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }
        public double Y
        {
            set
            {
                y = value;
            }
            get
            {
                return y;
            }
        }
        public double Z
        {
            set
            {
                z = value;
            }
            get
            {
                return z;
            }
        }
        public double G
        {
            set
            {
                g = value;
            }
            get
            {
                return g;
            }
        }
        public double H
        {
            set
            {
                h = value;
            }
            get
            {
                return h;
            }
        }
        public double C
        {
            set
            {
                c = value;
            }
            get
            {
                return c;
            }
        }
        public double D
        {
            set
            {
                d = value;
            }
            get
            {
                return d;
            }
        }
    }
}
