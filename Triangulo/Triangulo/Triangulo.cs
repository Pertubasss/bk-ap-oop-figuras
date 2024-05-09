
namespace Triangulo
{
    public class Triangulo(double lado1, double lado2, double lado3)
    {
        public double Lado1 { get; set; } = lado1;
        public double Lado2 { get; set; } = lado2;
        public double Lado3 { get; set; } = lado3;

        public bool VerificarTriangulo()
        {
            return Lado1 + Lado2 > Lado3 
                && Lado1 + Lado3 > Lado2 
                && Lado2 + Lado3 > Lado1;
        }

        public string TipoTriangulo()
        {
            if (!VerificarTriangulo())
                return "Não é um triangulo!";

            if (Lado1 == Lado2 && Lado2 == Lado3)
            {
                return "Equilátero";
            }

            else if (Lado1 == Lado2 || Lado1 == Lado3 || Lado2 == Lado3)
            {
                return "Isósceles";
            }

            else
            {
                return "Escaleno";
            }
        }
    }
}
