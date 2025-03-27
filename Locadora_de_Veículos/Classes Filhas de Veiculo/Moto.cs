using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_de_Veículos
{
    public class Moto : Veiculo
    {

        public void CalcularAluguel()
        {
            ValorBaseDiariaAluguel = ValorBaseDiariaAluguel * 0.8;
        }
    }
}
