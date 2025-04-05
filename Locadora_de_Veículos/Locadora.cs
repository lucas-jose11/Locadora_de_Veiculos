using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public List<Carro> carros = new List<Carro>
        {
            new Veiculo("Carrinho","CarroIndústria",2015,100,true,0)
        }

        public List<Moto> motos = new List<Moto>();

        public List<Caminhao> caminhoes = new List<Caminhao>();

        public List<Veiculo> allVehicles = new List<Veiculo>();

        public List<Veiculo> veiculosAlugados = new List<Veiculo>();


        public int MenuLocadora(int op)
        {
            Console.Clear();

            Console.WriteLine("Bem-vindo a Locadora de Veículos da Rua.");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("");
            Console.WriteLine("[1] - Registrar veículo");
            Console.WriteLine("[2] - Visualizar veículos");
            Console.WriteLine("[3] - Alugar veículo");
            Console.WriteLine("[3] - Devolver veículo");
            Console.WriteLine("[5] - SAIR");
            op = EscolhaEntreOsNumeros(1, 5);
            return op;
        }

        public void RegistrarVeiculo()
        {
            while (true) 
            {
                try
                {
                    Console.WriteLine(">>>>>>> REGISTRANDO VEÍCULO <<<<<<<");

                    Console.WriteLine("Modelo do veículo:");
                    string modelo = Console.ReadLine();

                    Console.WriteLine("Marca do veículo:");
                    string marca = Console.ReadLine();

                    Console.WriteLine("Ano do veículo:");
                    if (!int.TryParse(Console.ReadLine(), out int ano) || ano < 1886 || ano > 2025)
                        throw new Exception("Ano inválido. Digite entre 1886 e 2025.");

                    Console.WriteLine("Valor da diária (XX,XX):");
                    if (!double.TryParse(Console.ReadLine(), out double valorDiaria) || valorDiaria <= 0)
                        throw new Exception("Valor inválido. Digite um número positivo.");

                    Console.WriteLine("Tipo do veículo:\n1- Carro || 2- Moto || 3- Caminhão");
                    int escolha = EscolhaEntreOsNumeros(1, 3);

                    if (escolha == 1)
                    {
                        Carro carro = new Carro()
                        {
                            Modelo = modelo,
                            Marca = marca,
                            Ano = ano,
                            ValorBaseDiariaAluguel = valorDiaria,
                            Status = true,
                            ValorAluguelAPagar = 0
                        };
                        carros.Add(carro);
                        allVehicles.Add(carro);
                    }
                    else if (escolha == 2)
                    {
                        Moto moto = new Moto()
                        {
                            Modelo = modelo,
                            Marca = marca,
                            Ano = ano,
                            ValorBaseDiariaAluguel = valorDiaria,
                            Status = true,
                            ValorAluguelAPagar = 0
                        };
                        motos.Add(moto);
                        allVehicles.Add(moto);
                    }
                    else if (escolha == 3)
                    {
                        Caminhao caminhao = new Caminhao()
                        {
                            Modelo = modelo,
                            Marca = marca,
                            Ano = ano,
                            ValorBaseDiariaAluguel = valorDiaria,
                            Status = true,
                            ValorAluguelAPagar = 0
                        };
                        caminhoes.Add(caminhao);
                        allVehicles.Add(caminhao);
                    }

                    Console.WriteLine("Veículo registrado com sucesso! Voltando ao menu...");
                    Thread.Sleep(1800);
                    Console.Clear();
                    break; 
                }
                catch (Exception e)
                {
                    Console.WriteLine($"ERRO: {e.Message}");
                    Console.WriteLine("Tente novamente.\n");
                }
            }
        }


        public void VisualizarVeiculos()
        {
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
                moto.ExibirInformacoes();
            }

            Console.WriteLine("\n=====================================");
            Console.WriteLine("VEÍCULOS TIPO CAMINHÃO:");

            foreach (var caminhao in caminhoes)
            {
                caminhao.ExibirInformacoes();
            }
        }


        public void AlugarVeiculo()
        {
            try
            {
                Console.WriteLine("\nVEÍCULOS DISPONÍVEIS:");
                VisualizarVeiculos();

                Console.WriteLine("\nDigite o NOME do veículo que quer alugar");
                string vehicleToRent = Console.ReadLine();

                if (string.IsNullOrEmpty(vehicleToRent))
                    throw new Exception("Digite o nome do veículo.");

                Veiculo veiculoPraAlugar = carros.FirstOrDefault(v =>
                    v.Modelo.Equals(vehicleToRent, StringComparison.OrdinalIgnoreCase) &&
                    v.Status);

                if (veiculoPraAlugar == null)
                {
                    Console.WriteLine("Veículo inexistente ou já alugado");
                    Console.WriteLine("Pressione qualquer tecla para voltar");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine($"\nPor quantos dias quer alugar o {vehicleToRent}? (Máx 14 dias)");
                int daysToRent = EscolhaEntreOsNumeros(1, 14);

                // Modifica o veículo ORIGINAL
                veiculoPraAlugar.Status = false;
                veiculoPraAlugar.ValorAluguelAPagar = veiculoPraAlugar.CalcularAluguel(daysToRent);

                // Adiciona a referência do original na lista de alugados
                veiculosAlugados.Add(veiculoPraAlugar);

                Console.WriteLine("");
                Console.WriteLine($"Aluguel confirmado!" +
                                 $"\nVeículo: {veiculoPraAlugar.Modelo}" +
                                 $"\nValor total: R${veiculoPraAlugar.ValorAluguelAPagar:F2}" +
                                 $"\nPressione qualquer tecla para continuar...");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
                Console.WriteLine("Recarregando...");
                Thread.Sleep(2000);
                AlugarVeiculo();
            }
        }


        public void DevolverVeiculo()
        {
            try
            {
                Console.WriteLine("Qual veículo você quer devolver?");
                Console.WriteLine("");

                Console.WriteLine("=============================================");
                Console.WriteLine("VEÍCULOS ALUGADOS:");
                foreach (var veiculo in veiculosAlugados)
                {
                    veiculo.ExibirInformacoesAlugados();
                    Console.WriteLine("---");
                }
                
                Console.WriteLine("=============================================");

                Console.WriteLine("");
                Console.WriteLine("Qual você quer devolver?");
                string veiculoPraDevolverUsuarioResposta = Console.ReadLine();

                if (string.IsNullOrEmpty(veiculoPraDevolverUsuarioResposta))
                    throw new Exception("Digite o nome do veículo.");

                Veiculo veiculoPraDevolver = carros.FirstOrDefault(v =>
                    v.Modelo.Equals(veiculoPraDevolverUsuarioResposta, StringComparison.OrdinalIgnoreCase) &&
                    v.Status);

                Console.WriteLine("");
                Console.WriteLine("Veículo devolvido!");
                veiculoPraDevolver.Status = true;

                Console.WriteLine("");
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
                Console.ReadLine();

            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }




        public int EscolhaEntreOsNumeros(int a, int b)
        {
            try
            {
                Console.WriteLine($"Escreva um número inteiro entre {a} e {b}.");
                int resposta;

                if (!int.TryParse(Console.ReadLine(), out resposta))
                    throw new Exception("Digite um número!");

                if (resposta >= a && resposta <= b)
                    return resposta;
                else
                {
                    Console.WriteLine("\nEscolha um número válido!");
                    return EscolhaEntreOsNumeros(a, b);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return EscolhaEntreOsNumeros(a, b);
            }
        }


    }
}