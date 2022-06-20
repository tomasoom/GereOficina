using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereOficina
{
 

    public partial class Servico
    {
        public Servico(String tipo)
        {
            this.Tipo = tipo;
            this.Data = DateTime.Now;
            this.Parcelas = new HashSet<Parcela>();
        }

        public override string ToString()
        {
            return $"{this.Tipo} - {this.Data} {totalGasto()}€";
        }

        public double totalGasto()
        {
            double total = 0;
            foreach(Parcela parcela in this.Parcelas)
            {
                total += parcela.Valor;
            }
            return total;
        }
    }
}
