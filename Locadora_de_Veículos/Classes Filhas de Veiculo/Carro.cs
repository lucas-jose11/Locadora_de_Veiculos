using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_de_Veículos
{
    public class Carro : Veiculo
    {

        public Carro(string modelo, string marca, int ano, double valorBaseDiario)
        : base(modelo, marca, ano, valorBaseDiario)
        {
            // Aqui você pode adicionar lógica específica do Carro, se necessário
        }



        public override double CalcularAluguel(int dias) //oq o dias fará? é quantos dias a pessoa quiser? ela temq falar?
        {
            return ValorBaseDiariaAluguel = ValorBaseDiariaAluguel;
        }
    }
}
