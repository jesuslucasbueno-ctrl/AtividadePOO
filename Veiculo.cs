using System.Diagnostics.Contracts;

namespace AtividadePOO;

public abstract class Carro
{
    public string Modelo { get; set; }
    public int Ano { get; set; }
    
    protected Veiculo(string modelo, int ano)
    {

    Modelo = modelo;
    Ano = ano;
}

    public void Ligar()
    {
        
    }