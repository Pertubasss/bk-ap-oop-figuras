
namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>> Tipo do triângulo <<<");

            double[] lados = LerLados();

            var triangulo = new Triangulo(lados[0], lados[1], lados[2]);
            var tipo = triangulo.TipoTriangulo();

            Console.WriteLine($"O triângulo é {tipo}.");

        }

        static double[] LerLados()
        {
            double[] ladosTriangulo = new double[3];

            Console.WriteLine("Digite o comprimento dos lados do triângulo");

            for (int i = 0; i < 3; i++)
            {
                bool numValido = false;

                while (!numValido)
                {
                    Console.Write($"Lado {i + 1}: ");
                    numValido = double.TryParse(Console.ReadLine(), out ladosTriangulo[i]) && ladosTriangulo[i] > 0;

                    if (!numValido)
                        Console.WriteLine("Valor inválido. Digite um número válido.");
                }
            }

            return ladosTriangulo;
        }
    }
}
