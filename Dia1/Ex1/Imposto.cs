using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    public abstract class Imposto
    {
        public double Aliquota { get; set; }

        public abstract double Calcula(double p);
    }
}