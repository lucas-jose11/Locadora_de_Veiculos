
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