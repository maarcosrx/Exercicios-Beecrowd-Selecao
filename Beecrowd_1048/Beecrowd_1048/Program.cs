namespace Beecrowd1048 {
    public class Program {
        public static void Main(string[] args) {
            double salario = double.Parse(Console.ReadLine());

            if (salario >= 0.00 && salario <= 400.00) {
                double reajuste = salario * 0.15;
                double novoSalario = salario + reajuste;
                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
                Console.WriteLine($"Em percentual: 15 %");
            } else if (salario >= 400.01 && salario <= 800.00) {
                double reajuste2 = salario * 0.12;
                double novosalario2 = salario + reajuste2;
                Console.WriteLine($"Novo salario: {novosalario2:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste2:F2}");
                Console.WriteLine($"Em percentual: 12 %");
            } else if (salario >= 800.01 && salario <= 1200.00) {
                double reajuste3 = salario * 0.10;
                double novosalario3 = salario + reajuste3;
                Console.WriteLine($"Novo salario: {novosalario3:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste3:F2}");
                Console.WriteLine($"Em percentual: 10 %");
            } else if (salario >= 1200.01 && salario <= 2000.00) {
                double reajuste4 = salario * 0.07;
                double novosalario4 = salario + reajuste4;
                Console.WriteLine($"Novo salario: {novosalario4:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste4:F2}");
                Console.WriteLine($"Em percentual: 7 %");
            } else {
                double reajuste5 = salario * 0.04;
                double novosalario5 = salario + reajuste5;
                Console.WriteLine($"Novo salario: {novosalario5:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste5:F2}");
                Console.WriteLine($"Em percentual: 4 %");
            }

        }
    }
}