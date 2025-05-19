using System;

struct Retangulo
{
    public double Largura;
    public double Altura;

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public double CalcularArea()
    {
        return Largura * Altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (Largura + Altura);
    }
}

struct Data
{
    public int Dia;
    public int Mes;
    public int Ano;

    public Data(int dia, int mes, int ano)
    {
        Dia = dia;
        Mes = mes;
        Ano = ano;
    }

    public bool DataValida()
    {
        return DateTime.TryParse($"{Ano}-{Mes}-{Dia}", out _);
    }
}

struct Cor
{
    public byte R;
    public byte G;
    public byte B;

    public Cor(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;
    }

    public string ParaHexadecimal()
    {
        return $"#{R:X2}{G:X2}{B:X2}";
    }
}

struct Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public Produto(string nome, double preco, int quantidade)
    {
        Nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    public double ValorTotalEstoque()
    {
        return Preco * Quantidade;
    }
}

class Program
{
    static void Main()
    {
        var ret = new Retangulo(10, 5);
        Console.WriteLine($"Área: {ret.CalcularArea()}");
        Console.WriteLine($"Perímetro: {ret.CalcularPerimetro()}");

        var data = new Data(29, 2, 2024);
        Console.WriteLine($"Data válida: {data.DataValida()}");

        var cor = new Cor(255, 0, 127);
        Console.WriteLine($"Cor em hexadecimal: {cor.ParaHexadecimal()}");

        var produto = new Produto("Teclado", 150.00, 20);
        Console.WriteLine($"Valor total em estoque: R${produto.ValorTotalEstoque():F2}");
    }
}