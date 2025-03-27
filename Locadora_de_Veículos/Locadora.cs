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
        }

        public void VisualizarVeiculos()
        {

        }




    }
}
