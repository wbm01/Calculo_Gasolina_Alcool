internal class Program
{
    private static void Main(string[] args)
    {
        double gaso, alc, total;

        Console.WriteLine("Informe o valor da gasolina: ");
        gaso = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o valor do álcool: ");
        alc = double.Parse(Console.ReadLine());

        total = (alc/gaso)*100;

        Console.WriteLine("Total: {0}", total.ToString("f2") + "%");

        if(total <= 72)
        {
            Console.WriteLine("Abasteça com álcool.");
        }
        else
        {
            Console.WriteLine("Abasteça com gasolina.");
        }
    }
}