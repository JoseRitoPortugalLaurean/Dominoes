class Dominoes
{
    public int d1;
    public int d2;

    public Dominoes(int d1, int d2)
    {
        this.d1 = d1;
        this.d2 = d2;
    }

    public static int operator +(Dominoes a, Dominoes b)
    {
        int suma = a.d1 + a.d2 + b.d1 + b.d2;
        return suma;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Dominoes d1 = new Dominoes (0,1);
        Dominoes d2 = new Dominoes (2,3);
        int Total = d1 + d2;
        Console.WriteLine(Total);
    }
}

// Dominio d1 = new Dominio (0,1);
// Dominio d2 = new Dominio (2,3);
// int Total = d1 + d2;
//

// 
// 
// 
// 
