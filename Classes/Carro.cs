using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereOficina
{
    public partial class Carro
    {
        public Carro(String matriculaCarro)
        {
            this.Matricula = matriculaCarro;
            this.Servicos = new HashSet<Servico>();

        }

        public override string ToString()
        {
            return $"{this.Matricula}  {totalGasto()}€";
        }

        public double totalGasto()
        {
            double total = 0;
            
            foreach(Servico servico in this.Servicos)
            {
                total += servico.totalGasto();
            }

            return total;
        }
    }
}
