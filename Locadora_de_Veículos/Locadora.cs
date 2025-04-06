using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Locadora_de_Veículos
{
    public class Locadora
    {

        public List<Carro> carros = new List<Carro>
        {
            new Carro()
            {
                Modelo = "Tá-lento",
                Marca = "Bentiví",
                Ano = 2019,
                ValorBaseDiariaAluguel = 100,
                Status = true,
                ValorAluguelAPagar = 0
            },
            

            new Carro()
            {
                Modelo = "Turva Poça",
                Marca = "Carrão",
                Ano = 2012,
                ValorBaseDiariaAluguel = 200,
                Status = false,
                ValorAluguelAPagar = 0
            }


        };

        public List<Moto> motos = new List<Moto>
        {
            new Moto()
            {
                Modelo = "Konti",
                Marca = "Sapon",
                Ano = 2022,
                ValorBaseDiariaAluguel = 130,
                Status = true,
                ValorAluguelAPagar = 0
            },

            new Moto()
            {
                Modelo = "Corre/Rápido",
                Marca = "Velozzzz",
                Ano = 2017,
                ValorBaseDiariaAluguel = 100,
                Status = true,
                ValorAluguelAPagar = 0
            }
        };

        public List<Caminhao> caminhoes = new List<Caminhao>
        {
            new Caminhao()
            {
                Modelo = "Betoneira",
                Marca = "Indústria Boa",
                Ano = 1989,
                ValorBaseDiariaAluguel = 250,
                Status = false,
                ValorAluguelAPagar = 0
            },

            new Caminhao()
            {
                Modelo = "Faísca",
                Marca = "Fanticamente",
                Ano = 1993,
                ValorBaseDiariaAluguel = 350,
                Status = true,
                ValorAluguelAPagar = 0
            }
        };

        public void InicializarListas()
        {
            foreach (var carro in carros)
            {
                todosOsVeiculos.Add(carro);
            }

            foreach (var moto in motos)
            {
                todosOsVeiculos.Add(moto);
            }

            foreach (var caminhao in caminhoes)
            {
                todosOsVeiculos.Add(caminhao);
            }

        }

        public List<Veiculo> todosOsVeiculos = new List<Veiculo>();

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
            Console.WriteLine("[4] - Devolver veículo");
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

                    if (string.IsNullOrEmpty(modelo))
                        throw new Exception("Campo do modelo nulo!");

                    Console.WriteLine("Marca do veículo:");
                    string marca = Console.ReadLine();

                    if (string.IsNullOrEmpty(marca))
                        throw new Exception("Campo do modelo nulo!");

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
                        todosOsVeiculos.Add(carro);
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
                        todosOsVeiculos.Add(moto);
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
                        todosOsVeiculos.Add(caminhao);
                    }

                    Console.WriteLine("Veículo registrado com sucesso! Voltando ao menu...");
                    Thread.Sleep(1800);
                    Console.Clear();
                    break;
                }
                catch (Exception e)
                {
                    Console.Clear();
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
            Console.WriteLine("");
        }

        public void AlugarVeiculo()
        {
            try
            {
                Console.WriteLine("\nVEÍCULOS DISPONÍVEIS:");
                VisualizarVeiculos();

                Console.WriteLine("\nDigite o NOME do veículo que quer alugar");
                string veiculoParaAlugar = Console.ReadLine();

                if (string.IsNullOrEmpty(veiculoParaAlugar))
                    throw new Exception("Digite o nome do veículo.");

                Veiculo veiculoPraAlugar = todosOsVeiculos.FirstOrDefault(v =>
                    v.Modelo.Equals(veiculoParaAlugar, StringComparison.OrdinalIgnoreCase) &&
                    v.Status);

                if (veiculoPraAlugar == null)
                {
                    Console.WriteLine(">>>>>>>>>>>>>>>><<<<<<<<<<<<<<<<");
                    Console.WriteLine("Veículo inexistente ou já alugado");
                    Console.WriteLine("Pressione QUALQUER tecla para voltar");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine($"\nPor quantos dias quer alugar o {veiculoParaAlugar}? (Máx 14 dias)");
                int daysToRent = EscolhaEntreOsNumeros(1, 14);

                veiculoPraAlugar.Status = false;
                veiculoPraAlugar.ValorAluguelAPagar = veiculoPraAlugar.CalcularAluguel(daysToRent);

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