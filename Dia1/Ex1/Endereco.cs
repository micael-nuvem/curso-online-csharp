using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    class Endereco
    {
        public string rua { get; set; }
        public string bairro { get; set; }
        public int numero { get; set; }
        public bool ativo { get; set; }

        public void setRua(string rua)
        {
            this.rua = rua;
        }

        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }

        internal void setNumero(int numero)
        {
            this.numero = numero;
        }

        internal void setAtivo(bool ativo)
        {
            this.ativo = ativo;
        }
    }
}