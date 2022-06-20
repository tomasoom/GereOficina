using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereOficina
{
    public partial class Cliente
    {
        public Cliente(String nomeCliente, String NIF)
        {
            this.Nome = nomeCliente;
            this.NIF = NIF;
            this.Carros = new HashSet<Carro>();
        }

        public override string ToString()
        {
            return $"{this.Nome} ({this.IdCliente})   {this.NIF} nºCarros: {this.Carros.Count()}";
        }

        public double totalGasto()
        {
            double total = 0;
            foreach(Carro carro in this.Carros)
            {
                total += carro.totalGasto();
            }
            return total;
        }
    }
}
