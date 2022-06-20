using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereOficina
{
    public partial class Parcela
    {
        public Parcela(String descricao, double valor)
        {
            this.Descricao = descricao;
            this.Valor = valor;
        }

        public Parcela()
        {

        }

        public override string ToString()
        {
            return $"{this.Descricao} - {this.Valor}€";
        }

    }
}
