
namespace Locadora_de_Veículos
{
    public class Carro : Veiculo
    {
        public override Veiculo CriarVeiculo(string modelo, string marca, int ano, double valorBaseDiariaAluguel, bool disponibilidade, double valorAluguelAPagar)
        {
            return new Carro()
            {
                Modelo = modelo,
                Marca = marca,
                Ano = ano,
                ValorBaseDiariaAluguel = valorBaseDiariaAluguel,
                Status = disponibilidade,
                ValorAluguelAPagar = 0
            };
        }
       
        public override double CalcularAluguel(int dias)
        {
            return ValorAluguelAPagar = ValorBaseDiariaAluguel * dias;
        }
    }
}