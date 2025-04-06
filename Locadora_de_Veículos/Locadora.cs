
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
                Modelo = "CorreRápido",
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
                Marca = "Trilegal",
                Ano = 1993,
                ValorBaseDiariaAluguel = 350,
                Status = true,
                ValorAluguelAPagar = 0
            }
        };

        public List<Veiculo> todosOsVeiculos = new List<Veiculo>();

        public List<Veiculo> veiculosAlugados = new List<Veiculo>();

        public void InicializarListas()
        {
            foreach (Veiculo carro in carros)
                todosOsVeiculos.Add(carro);

            foreach (Veiculo moto in motos)
                todosOsVeiculos.Add(moto);

            foreach (Veiculo caminhao in caminhoes)
                todosOsVeiculos.Add(caminhao);
        }

        public int MenuLocadora(int op)
        {
            if (op == -2)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("!!!Escolha um número válido!!!");
                Console.WriteLine("-------------------------");
            }

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
                        throw new Exception("Valor inválido. Digite um número positivo no campo da diária.");

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

                    Console.WriteLine("Veículo registrado com sucesso! Aperte QUALQUER tecla para voltar ao menu.");
                    Console.ReadKey();
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
            Console.WriteLine(">>>>>>> VEÍCULOS REGISTRADOS <<<<<<<");

            Console.WriteLine("\n=====================================");
            Console.WriteLine("VEÍCULOS TIPO CARRO:");

            foreach (var carro in carros)
                carro.ExibirInformacoes();


            Console.WriteLine("\n=====================================");
            Console.WriteLine("VEÍCULOS TIPO MOTO:");

            foreach (var moto in motos)
                moto.ExibirInformacoes();


            Console.WriteLine("\n=====================================");
            Console.WriteLine("VEÍCULOS TIPO CAMINHÃO:");

            foreach (var caminhao in caminhoes)
                caminhao.ExibirInformacoes();
        }

        public void AlugarVeiculo()
        {
            try
            {
                Console.WriteLine(">>>>>>> VEÍCULOS DISPONÍVEIS <<<<<<<");
                VisualizarVeiculos();

                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Digite o NOME do veículo que quer alugar");
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
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine($"\nPor quantos dias quer alugar o {veiculoParaAlugar}? (Máx 14 dias)");
                int daysToRent = EscolhaEntreOsNumeros(1, 14);

                veiculoPraAlugar.Status = false;
                veiculoPraAlugar.ValorAluguelAPagar = veiculoPraAlugar.CalcularAluguel(daysToRent);

                veiculosAlugados.Add(veiculoPraAlugar);

                Console.WriteLine("");
                Console.WriteLine("=============================================");
                Console.WriteLine($"Aluguel confirmado!" +
                                 $"\nVeículo: {veiculoPraAlugar.Modelo}" +
                                 $"\nValor total: R${veiculoPraAlugar.ValorAluguelAPagar:F2}" +
                                 $"\nPressione qualquer tecla para continuar...");
                Console.WriteLine("=============================================");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
                Console.WriteLine("Recarregando...");
                Thread.Sleep(1500);
                AlugarVeiculo();
            }
        }

        public void DevolverVeiculo()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("=== DEVOLUÇÃO DE VEÍCULO ===");

                if (veiculosAlugados.Count == 0)
                {
                    Console.WriteLine("\nNenhum veículo alugado no momento. Aperte QUALQUER tecla para voltar.");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("\nVEÍCULOS ALUGADOS:");
                Console.WriteLine("=================================");
                foreach (var veiculo in veiculosAlugados)
                {
                    veiculo.ExibirInformacoesAlugados();
                    Console.WriteLine("---------------------------------");
                }

                Console.Write("\nDigite o modelo do veículo a devolver: ");
                string modelo = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(modelo))
                    throw new Exception("Modelo não pode ser vazio.");

                Veiculo veiculoParaDevolver = veiculosAlugados
                    .FirstOrDefault(v => v.Modelo.Equals(modelo, StringComparison.OrdinalIgnoreCase));

                if (veiculoParaDevolver == null)
                {
                    Console.WriteLine("\nVeículo não encontrado na lista de alugados!");
                    Console.ReadKey();
                    return;
                }

                veiculoParaDevolver.Status = true;
                veiculoParaDevolver.ValorAluguelAPagar = 0;

                veiculosAlugados.Remove(veiculoParaDevolver);

                Console.WriteLine($"\nVeículo {veiculoParaDevolver.Modelo} devolvido com sucesso!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}");
                Console.ReadKey();
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
                    Console.Clear();
                    return MenuLocadora(-2);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Aperte QUALQUER tecla para continuar.");
                Console.ReadKey();
                Console.Clear();
                return MenuLocadora(-1);
            }
        }
    }
}