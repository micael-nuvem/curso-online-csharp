using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    public class Pessoa
    {
        public string nome { get; set; }

        public int ano { get; set; }


        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setAno(int ano)
        {
            this.ano = ano;
        }

        public int getAno()
        {
            return ano;
        }

        public string getNome()
        {
            return nome;
        }

        public bool EhPessoaFisica()
        {
            return (this is PessoaFisica);
        }
    }
}