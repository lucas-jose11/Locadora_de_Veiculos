using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace Locadora_de_Veículos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Locadora locadora = new Locadora();

            int op = -1;
            while (op != 5)
            {
                op = locadora.MenuLocadora(op);
                locadora.InicializarListas();

                //try catch pra caso nulo
                Console.Clear();
                switch (op)
                {
                    case 1:
                        locadora.RegistrarVeiculo();
                        break;

                    case 2:
                        locadora.VisualizarVeiculos();
                        Console.WriteLine("\n=========================");
                        Console.WriteLine("Aperte QUALQUER tecla para voltar ao menu.");
                        Console.WriteLine("=========================");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        locadora.AlugarVeiculo();
                        break;

                    case 4:
                        locadora.DevolverVeiculo();
                        break;

                    case 5:
                        Console.WriteLine("Volte sempre!");
                        break;
                }
            }


        }
    }
}

/*
Uma locadora de veículos precisa gerenciar diferentes tipos de automóveis disponíveis para aluguel. 
Cada veículo tem características específicas e um método para calcular o custo do aluguel com base em sua categoria. 
Seu desafio é modelar esse sistema utilizando herança, polimorfismo e interfaces.

Requisitos do Exercício
      1.    Criar uma interface IVeiculo que deve ter:
          • Método CalcularAluguel(int dias), que retorna o custo total do aluguel com base na categoria do veículo 
           e na quantidade de dias alugados.
      2.    Criar uma classe base Veiculo que implementa IVeiculo e contém:
          • Modelo
          • Marca
          • Ano
          • Valor base diário do aluguel
          • Método CalcularAluguel(int dias) (será sobrescrito pelas classes filhas).
      3.    Criar pelo menos três classes filhas que herdam de Veiculo e sobrescrevem CalcularAluguel(int dias):
          • Carro: custo do aluguel é valor base diário x dias.
          • Moto: custo do aluguel tem um desconto de 10% sobre o total.
          • Caminhao: custo do aluguel tem um acréscimo de 20% sobre o total.
      4.    Criar um programa principal (Main) que:
          • Cadastre pelo menos um veículo de cada tipo.
          • Exiba o modelo, marca, ano e custo do aluguel para um determinado número de dias.


Exemplo de Saída Esperada:

Veículo: Corolla | Marca: Toyota | Ano: 2022 | Custo por 5 dias: R$ 1.500,00
Veículo: XRE 300 | Marca: Honda | Ano: 2021 | Custo por 5 dias: R$ 675,00
Veículo: Scania R450 | Marca: Scania | Ano: 2020 | Custo por 5 dias: R$ 3.000,00
*/