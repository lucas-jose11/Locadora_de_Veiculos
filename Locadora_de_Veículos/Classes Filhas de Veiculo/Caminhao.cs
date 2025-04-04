using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_de_Veículos
{
    public class Caminhao : Veiculo
    {

        public override Veiculo CriarVeiculo(string modelo, string marca, int ano, double valorBaseDiariaAluguel)
        {
            return new Caminhao()
            {
                Modelo = modelo,
                Marca = marca,
                Ano = ano,
                ValorBaseDiariaAluguel = valorBaseDiariaAluguel
            };
        }


        public override double CalcularAluguel(int dias)
        {
            return base.CalcularAluguel(dias) * 1.2;
        }

    }


}