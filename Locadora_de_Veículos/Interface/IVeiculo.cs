using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_de_Veículos.Interface
{
    public interface IVeiculo
    {
        double CalcularAluguel(int dias);
        //retorna o custo total do aluguel com base na categoria do veículo e na quantidade de dias alugados

        Veiculo CriarVeiculo(string modelo, string marca, int ano, double valorBaseDiariaAluguel, bool status, double valorAluguelAPagar);             
        
    }
}
