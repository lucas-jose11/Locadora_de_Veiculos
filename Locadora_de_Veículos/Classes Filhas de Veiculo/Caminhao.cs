using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_de_Veículos
{
    public class Caminhao : Veiculo
    {

        public Caminhao(string modelo, string marca, int ano, double valorBaseDiario)
        : base(modelo, marca, ano, valorBaseDiario)
        {
            // Aqui você pode adicionar lógica específica do caminhao, se necessário
        }

        public override double CalcularAluguel(int dias)
        {
            return ValorBaseDiariaAluguel = ValorBaseDiariaAluguel * 1.2;
        }
    }


}