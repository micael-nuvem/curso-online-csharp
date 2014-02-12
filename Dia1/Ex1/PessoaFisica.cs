using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public string RG { get; set; }


        public PessoaFisica(string nome)
        {
            this.nome = nome;
        }

        public void setCPF(string cpf)
        {
            this.CPF = cpf;
        }

        public void setNascimento(int nascimento)
        {
            this.ano = nascimento;
        }

        public void setRG(string rg)
        {
            this.RG = rg;
        }

        internal string getCPF()
        {
            return CPF;
        }

        internal static bool ValidaCPF(string p)
        {
            return true;
        }

        public int getIdade()
        {
            return DateTime.Now.Year - ano;
        }
    }
}