using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    class Irpf:Imposto
    {
        public PessoaFisica PessoaFisica { get; set; }

        public Irpf(Pessoa pessoaFisica)
        {
            if (!(pessoaFisica is PessoaFisica))
            {
                throw new ArgumentException();
            }
            else
            {
                this.PessoaFisica = (PessoaFisica)pessoaFisica;
                this.Aliquota = 0.27;
            }
        }

        public override double Calcula(double p)
        {
            return p * Aliquota;
        }
    }
}