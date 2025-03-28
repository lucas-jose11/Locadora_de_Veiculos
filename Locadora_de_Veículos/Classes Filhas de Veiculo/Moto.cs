using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_de_Veículos
{
    public class Moto : Veiculo
    {

        public Moto(string modelo, string marca, int ano, double valorBaseDiario)
        : base(modelo, marca, ano, valorBaseDiario)
        {
            // Aqui você pode adicionar lógica específica do moto, se necessário
        }
        public override double CalcularAluguel(int dias)
        {
            return ValorBaseDiariaAluguel = ValorBaseDiariaAluguel * 0.8;
        }
    }
}
