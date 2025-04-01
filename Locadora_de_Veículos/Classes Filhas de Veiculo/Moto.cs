using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_de_Veículos
{
    public class Moto : Veiculo
    {

        Veiculo override CriarVeiculo(string modelo, string marca, int ano, double valorBaseDiariaAluguel)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            ValorBaseDiariaAluguel = valorBaseDiariaAluguel;
        }
        
        public override double CalcularAluguel(int dias)
        {
            return ValorBaseDiariaAluguel = (ValorBaseDiariaAluguel * dias) * 0.9;
        }

    }
}
