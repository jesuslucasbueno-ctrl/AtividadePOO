namespace AtividadePOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Veiculo[] veiculos =
        [
            new Carro("Fusca", 1978),
            new Moto("BMW", 2024),
            new Caminhao("Mercedes Benz", 2015)
        ];


        foreach (var veiculo in veiculos)
        {
            veiculo.Ligar();
            veiculo.Acelerar();
            Console.WriteLine("--------------------");
        }
    }
}