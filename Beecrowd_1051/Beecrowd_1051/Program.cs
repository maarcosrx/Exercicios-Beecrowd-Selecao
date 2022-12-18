using System.Globalization;

namespace Beecrowd1051 {
    public class Program {
        public static void Main(string[] args) {

            double renda = double.Parse(Console.ReadLine());

            if (renda >= 0.00 && renda <= 2000.00) {
                Console.WriteLine("Isento");
            } else if (renda >= 2000.01 && renda <= 3000.00) {
                double calculo = (renda - 2000.00) * 0.08;
                Console.WriteLine($"R$ {calculo:F2}");
            } else if (renda >= 3000.01 && renda <= 4500.00) {
                double calculo = (renda - 3000);
                double calculo2 = renda - (2000 + calculo);
                double imposto = (calculo2 * 0.08) + (calculo * 0.18);
                Console.WriteLine($"R$ {imposto:F2}");
            } else if (renda > 4500.00) {
                double calculo = renda - 4500;
                double calculo2 = renda - (calculo + 3000);
                double calculo3 = renda - (calculo + calculo2 + 2000);
                double imposto = (calculo * 0.28) + (calculo2 * 0.18) + (calculo3 * 0.08);
                Console.WriteLine($"R$ {imposto:F2}");
            }
        }
    }
}