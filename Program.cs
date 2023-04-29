internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Escolha operação você gostaria de fazer?");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        int operação = int.Parse(Console.ReadLine());

        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = 0.0;

        switch (operação)
        {
            case 1: 
                resultado = num1 + num2;
                Console.WriteLine($"O resultado da adição é: {resultado}");
                break;

            case 2:
                resultado = num1 - num2;
                Console.WriteLine($"O resultado da subtração é: {resultado}");
                break;

            case 3:
                resultado = num1 * num2;
                Console.WriteLine($"O resultado da subtração é: {resultado}");
                break;

            case 4: // Divisão
                if (num2 == 0.0f)
                {
                    Console.WriteLine("Não é possível dividir por zero!");
                }
                else
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"O resultado da divisão é: {resultado}");
                }
                break;

            default:
                Console.WriteLine("Operação inválida!");
                break;
        }

        Console.ReadLine();
    }
}
