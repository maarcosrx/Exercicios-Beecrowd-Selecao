namespace Beecrowd1044 {
    public class Program {
        public static void Main(string[] args) {
            string[] valores = Console.ReadLine().Split(' ');
            
            double valor1 = double.Parse(valores[0]);
            double valor2 = double.Parse(valores[1]);

            if(valor2 % valor1 == 0 || valor1 % valor2 == 0) {
                Console.WriteLine("Sao Multiplos");
            } else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}