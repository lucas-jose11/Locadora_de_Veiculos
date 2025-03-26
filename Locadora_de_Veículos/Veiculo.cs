using Locadora_de_Veículos.Interface;
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


        //se eu quiser que o usuário escreva:
        public string Modelo
        {
            get { return _modelo; }
            set
            {
                _modelo = value; //fzr o compade digitar o nome?
            }
        }

        public string Marca
        {
            get { return _marca; }
            set
            {
                _marca = value; //marca tbm?
            }
        }

        public int Ano
        {
            get { return _ano;}
            set 
            {
                _ano = value; //já é implicito no C# o get set
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
