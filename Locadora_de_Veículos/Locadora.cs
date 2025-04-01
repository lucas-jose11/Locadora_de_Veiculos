using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Locadora_de_Veículos
{
    public class Locadora
    {
        //lista de veiculos, criar uns já
        //public List<Veiculo> listaVeiculos = new List<Veiculo>
        //{
        //    new Veiculo("Caminhao-1", "Chevrolet", 2011, 1250), //como saber se é carro, caminhao ou moto?
        //    new Veiculo("Moto-2", "Corolla", 1932, 300),
        //    new Veiculo("Carro-3", "Renault", 2000, 750),

        //};

        public List<Carro> carros = new List<Carro>();

        public List<Moto> motos = new List<Moto>();

        public List<Caminhao> caminhoes = new List<Caminhao>();

        //solução seria criar 3 listas diferentes?

        public int MenuLocadora(int op)
        {
            Console.WriteLine("Bem-vindo a Locadora de Veículos da Rua.");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("");
            Console.WriteLine("[1] - Registrar veículo");
            Console.WriteLine("[2] - Visualizar veículos");
            Console.WriteLine("[3] - Alugar veículo");
            Console.WriteLine("[4] - SAIR"); 
            //tem opcao pra pedir pra alugar carro? 
            op = EscolhaEntreOsNumeros(1, 4);
            return op;
        }

        public void RegistrarVeiculo()
        {
            //Veículo: Corolla | Marca: Toyota | Ano: 2022 | Custo por 5 dias: R$ 1.500,00
            //tipo do veículo e seus atributos
            //try catch pra tentar colocar nulo no int ou string 
            //fzr loop pra começar dnv caso erre algo

            try
            {
                Console.WriteLine(">>>>>>>REGISTRANDO VEÍCULO NO BANCO DE DADOS<<<<<<<");
                Console.WriteLine("");

                Console.WriteLine("Modelo (nome) do veículo:");
                string nomeVeiculo = Console.ReadLine();

                Console.WriteLine("Marca do veículo:");
                string marcaVeiculo = Console.ReadLine();

                Console.WriteLine("Ano do veículo");
                int anoVeiculo = int.Parse(Console.ReadLine());

                Console.WriteLine("Aluguel para diária, utilizar padrão \"XX,XX\":");
                double valorDiaria = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual o tipo do veículo?\n1- Carro || 2- Moto || 3- Caminhão");
                int tipoVeiculo = EscolhaEntreOsNumeros(1, 3);

                if (!(string.IsNullOrEmpty(nomeVeiculo)) || !(string.IsNullOrEmpty(marcaVeiculo)) || anoVeiculo == null || valorDiaria == null)

                switch (tipoVeiculo) //fzr o veiculo assim? n tem outro jeito para conseguir cadastrar sem switch case?
                {
                    case 1:
                        Carro novoCarro = new Veiculo(nomeVeiculo, marcaVeiculo, anoVeiculo, valorDiaria);
                        carros.Add(novoCarro);
                        break;

                    case 2:
                        Moto novaMoto = new Veiculo(nomeVeiculo, marcaVeiculo, anoVeiculo, valorDiaria);
                        motos.Add(novaMoto);
                        break;

                    case 3:
                        Caminhao novoCaminhao = new Veiculo(nomeVeiculo, marcaVeiculo, anoVeiculo, valorDiaria);
                        caminhoes.Add(novoCaminhao);
                        break;
                }

            }
            catch (Exception e)
            {
                
                Console.WriteLine($"{e.Message}");
                Console.WriteLine("ERRO, FAÇA CORRETAMENTE");
                RegistrarVeiculo();
            }

        }

        public void VisualizarVeiculos()
        {
            //foreach na listaVeiculos com o metodo que criei na Classe Veiculo

            Console.WriteLine(">>>>>VEÍCULOS REGISTRADOS<<<<<");

            Console.WriteLine("\n=====================================");
            Console.WriteLine("VEÍCULOS TIPO CARRO:");

            foreach (var carro in carros)
            {
                carro.ExibirInformacoes();

            }

            Console.WriteLine("\n=====================================");
            Console.WriteLine("VEÍCULOS TIPO MOTO:");

            foreach (var moto in motos)
            {
            }

            Console.WriteLine("\n=====================================");
            Console.WriteLine("VEÍCULOS TIPO CAMINHÃO:");

            foreach (var caminhao in caminhoes)
            {

            }

        }

        public void AlugarCarro()
        {
            //qual nome do veiculo que quer alugar, qnts dias quer alugar e se n tiver nome assim falar
        }


        public int EscolhaEntreOsNumeros(int a, int b)
        {
            Console.WriteLine($"Escreva um número inteiro entre {a} e {b}.");
            int resposta = int.Parse(Console.ReadLine());

            if (resposta >= a && resposta <= b)
                return resposta;
            else
            {
                Console.WriteLine("\nEscolha um número válido!");
                return EscolhaEntreOsNumeros(a, b);
            }
        }


    }
}