namespace ExercicioMultiplicacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o primeiro número");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double multiplicao = numero1 * numero2;

            Console.WriteLine("A multiplicação " + multiplicao.ToString("0.00"));

        }
    }
}
