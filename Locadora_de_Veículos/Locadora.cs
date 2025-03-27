using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Locadora_de_Veículos
{
    public class Locadora
    {
        //lista de veiculos, criar uns já
        public List<Veiculo> listaVeiculos = new List<Veiculo>
        {
            new Veiculo("Caminhao-1", "Chevrolet", 2011, 1250), //como saber se é carro, caminhao ou moto?
            new Veiculo("Moto-2", "Corolla", 1932, 300),
            new Veiculo("Carro-3", "Renault", 2000, 750),

        };

        //solução seria criar 3 listas diferentes?

        public int MenuLocadora(int op)
        {
            Console.WriteLine("Bem-vindo a Locadora de Veículos da Rua.");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("");
            Console.WriteLine("[1] - Registrar veículo");
            Console.WriteLine("[2] - Visualizar veículos");
            Console.WriteLine("[3] - SAIR");
            op = int.Parse(Console.ReadLine());
            return op;
        }

        public void RegistrarVeiculo()
        {
            //Veículo: Corolla | Marca: Toyota | Ano: 2022 | Custo por 5 dias: R$ 1.500,00
            //tipo do veículo e seus atributos
            //try catch pra tentar colocar nulo no int ou string 

            Console.WriteLine(">>>>>>>REGISTRANDO VEÍCULO NO BANCO DE DADOS<<<<<<<");
            Console.WriteLine("");

            Console.WriteLine("Qual é o tipo de veículo?");

            
            Console.WriteLine("Modelo (nome) do veículo:");
            string nomeVeiculo = Console.ReadLine();

            Console.WriteLine("Marca do veículo:");
            string marcaVeiculo = Console.ReadLine();

            Console.WriteLine("Ano do veículo");
            int anoVeiculo = int.Parse(Console.ReadLine());

            Console.WriteLine("Aluguel para diária, utilizar padrão \"XX,XX\":");
            double valorDiaria = double.Parse(Console.ReadLine());


        }

        public void VisualizarVeiculos()
        {
            //foreach na listaVeiculos com o metodo que criei na Classe Veiculo
        }




    }
}
