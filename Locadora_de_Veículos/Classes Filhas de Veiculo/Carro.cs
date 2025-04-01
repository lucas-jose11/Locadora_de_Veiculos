using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_de_Veículos
{
    public class Carro : Veiculo
    {
        public override Veiculo CriarVeiculo(string modelo, string marca, int ano, double valorBaseDiariaAluguel)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            ValorBaseDiariaAluguel = valorBaseDiariaAluguel;
        }

       

        public override double CalcularAluguel(int dias) //oq o dias fará? é quantos dias a pessoa quiser? ela temq falar?
        {
            return ValorBaseDiariaAluguel = ValorBaseDiariaAluguel * dias; //o desconto é no total dos dias
        }

    }
}
