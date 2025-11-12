

namespace Construtores
{
    public class Carro
    {
        public string Marca;
        public string Modelo;
        public int Ano;

public Carro(string m, string modelo, int ano)
        {
            Marca = m;
            Modelo = modelo;
            Ano = ano;

        }

        public void ExibirDados()
        {

            Console.WriteLine($"Marca do carro: {Marca}, seu modelo: {Modelo} e seu lancamento em {Ano}");

        }

    }
}