﻿using Locadora_de_Veículos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_de_Veículos
{
    public class Veiculo : IVeiculo
    {
        public void CalcularAluguel(int dias)
        {
            //será sobrescrito pelas classes filhas
        }

        private string _modelo;

        private string _marca;

        private int _ano;

        private double _valorBaseDiariaAluguel;


        public string Modelo
        {
            get { return _modelo; }
            set
            {
                if (!(String.IsNullOrEmpty(value)))
                {
                    _marca = value;
                }
                else
                    throw new Exception("Campo do Modelo nulo.");
            }
        }

        public string Marca
        {
            get { return _marca; }
            set
            {
                if (!(String.IsNullOrEmpty(value)))
                {
                    _marca = value;
                }
                else
                    throw new Exception("Campo da Marca nulo.");
            }
        }

        public int Ano
        {
            get { return _ano;}
            set 
            {
                if (!(value < 1886 || value > 2025)) 
                {
                    _ano = value;
                }
                else
                    throw new Exception("Ano do carro equivocado.");
            }
        }

        public double ValorBaseDiariaAluguel
        {
            get { return _valorBaseDiariaAluguel;}
            set
            {
                _valorBaseDiariaAluguel = value;//o value que aparece "do nada"
            }
        }


    }

}
