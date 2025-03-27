using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_de_Veículos
{
    public class Caminhao : Veiculo
    {

        public void CalcularAluguel()
        {
            ValorBaseDiariaAluguel = ValorBaseDiariaAluguel * 1.2;
        }
    }


}