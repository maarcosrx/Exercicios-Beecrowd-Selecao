namespace Beecrowd1042 {
    public class Program {
        public static void Main(string[] args) {

            string[] numeros = Console.ReadLine().Split();

            int dadoA = int.Parse(numeros[0]);
            int dadoB = int.Parse(numeros[1]);
            int dadoC = int.Parse(numeros[2]);

            int dadoD = dadoA;
            int dadoE = dadoB;
            int dadoF = dadoC;

            if (dadoD > dadoE && dadoD > dadoF) {
                int aux = dadoD;
                dadoD = dadoF;
                dadoF = aux;
            } else if (dadoE > dadoD && dadoE > dadoF) {
                int aux = dadoE;
                dadoE = dadoF;
                dadoF = aux;
            }

            if (dadoD > dadoE) {
                int aux = dadoD;
                dadoD = dadoE;
                dadoE = aux;
            }

            Console.WriteLine($"{dadoD}\n{dadoE}\n{dadoF}\n\n{dadoA}\n{dadoB}\n{dadoC}");
        }
    }
}