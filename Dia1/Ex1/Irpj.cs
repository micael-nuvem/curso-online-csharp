using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    class Irpj:Imposto
    {
        public PessoaJuridica PessoaJuridica { get; set; }

        public Irpj(Pessoa pessoaJuridica)
        {
            if (!(pessoaJuridica is PessoaJuridica))
            {
                throw new ArgumentException();
            }
            else
            {
                this.PessoaJuridica = (PessoaJuridica)pessoaJuridica;
            }
        }

        public override double Calcula(double p)
        {
            return p * Aliquota;
        }
    }
}