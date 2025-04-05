﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_de_Veículos
{
    public class Caminhao : Veiculo
    {

        public override Veiculo CriarVeiculo(string modelo, string marca, int ano, double valorBaseDiariaAluguel, bool disponibilidade, double valorAluguelAPagar)
        {
            return new Caminhao()
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
            return base.CalcularAluguel(dias) * 1.2;
        }

    }


}