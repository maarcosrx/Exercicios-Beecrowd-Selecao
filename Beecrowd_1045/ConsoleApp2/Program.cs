namespace Beecrowd1045 {
    public class Program {
        public static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');

            double valorA = double.Parse(valores[0]);
            double valorB = double.Parse(valores[1]);
            double valorC = double.Parse(valores[2]);

            if (valorC > valorB && valorC > valorA) {
                double aux = valorC;
                valorC = valorA;
                valorA = aux;
            }

            if (valorB > valorA && valorB > valorC) {
                double aux = valorB;
                valorB = valorA;
                valorA = aux;
            }

            if (valorC > valorB) {
                double aux = valorB;
                valorB = aux;
            }

            if (valorA >= valorB + valorC) {
                Console.WriteLine("NAO FORMA TRIANGULO");
                return;
            }

            if (valorA * valorA == valorB * valorB + valorC * valorC) {
                Console.WriteLine("TRIANGULO RETANGULO");
            } else if (valorA * valorA > valorB * valorB + valorC * valorC) {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            } else {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (valorA == valorB && valorB == valorC) {
                Console.WriteLine("TRIANGULO EQUILATERO");
            } else if (valorA == valorB || valorB == valorC || valorC == valorA) {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}