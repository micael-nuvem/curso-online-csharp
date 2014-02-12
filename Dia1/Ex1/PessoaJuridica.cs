using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    class PessoaJuridica : Pessoa
    {
        public string cnpj { get; set; }

        public Endereco endereco { get; set; }

        public PessoaJuridica(string nome, string cnpj)
        {
            this.nome = nome;
            this.cnpj = cnpj;
        }

        internal void setEndereco(Endereco end)
        {
            this.endereco = end;
        }

        internal string getCNPJ()
        {
            return cnpj;
        }

        internal static bool ValidaCNPJ(string p)
        {
            return true;
        }
    }
}