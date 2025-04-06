using Locadora_de_Veículos.Interface;

namespace Locadora_de_Veículos
{
    public abstract class Veiculo : IVeiculo
    {
        private string _modelo;

        private string _marca;

        private int _ano;

        private double _valorBaseDiariaAluguel;

        private bool _status;

        private double _valorAluguelAPagar;


        public string Modelo
        {
            get { return _modelo; }
            set
            {
                if (!(String.IsNullOrEmpty(value)))
                {
                    _modelo = value;
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
            get { return _ano; }
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
            get { return _valorBaseDiariaAluguel; }
            set { _valorBaseDiariaAluguel = value; }
        }

        public bool Status
        {
            get { return _status; }
            set {  _status = value;}
        }

        public double ValorAluguelAPagar
        {
            get { return _valorAluguelAPagar; }
            set { _valorAluguelAPagar = value; }
        }


        public virtual double CalcularAluguel(int dias)
        {
            return ValorAluguelAPagar = ValorBaseDiariaAluguel * dias;
        }
        
        public virtual Veiculo CriarVeiculo(string modelo, string marca, int ano, double valorDiaria, bool status, double valorAluguelAPagar)
        {
            throw new NotImplementedException("Método deve ser sobrescrito pelas subclasses.");
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo} || Marca: {Marca} || Ano: {Ano} || Disponibilidade: {((Status) ? "Disponível" : "Alugado")} || Valor para aluguel diária: R${ValorBaseDiariaAluguel:F2}.");
        }

        public virtual void ExibirInformacoesAlugados()
        {
            Console.WriteLine($"Modelo: {Modelo} || Marca: {Marca} || Ano: {Ano} || Disponibilidade: {((Status) ? "Disponível" : "Alugado")} || VALOR A PAGAR PELA ALUGAÇÃO: R${ValorAluguelAPagar:F2}.");
        }
    }
}