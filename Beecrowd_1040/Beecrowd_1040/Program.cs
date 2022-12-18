namespace Beecrowd1040 {
    public class Program {
        public static void Main(string[] args) {

            string[] notas = Console.ReadLine().Split();
            double n1 = double.Parse(notas[0]);
            double n2 = double.Parse(notas[1]);
            double n3 = double.Parse(notas[2]);
            double n4 = double.Parse(notas[3]);

            double mediaNotas = Math.Round((((n1 * 2) + (n2 * 3) + (n3 * 4) + n4) / 10), 1);
            Console.WriteLine($"Media: {mediaNotas:F1}");
            if (mediaNotas >= 7.0) {
                Console.WriteLine("Aluno aprovado.");
            } else if (mediaNotas < 5.0) {
                Console.WriteLine("Aluno reprovado.");
            } else if (mediaNotas >= 5.0 && mediaNotas <= 6.9) {
                Console.WriteLine("Aluno em exame.");

                double notaDoExame = double.Parse(Console.ReadLine());
                double mediaFinal = (notaDoExame + mediaNotas) / 2;
                Console.WriteLine($"Nota do exame: {notaDoExame:F1}");

                if (mediaFinal >= 5) {
                    Console.WriteLine("Aluno aprovado.");
                } else {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine($"Media final: {mediaFinal:F1}");
            }
        }
    }
}