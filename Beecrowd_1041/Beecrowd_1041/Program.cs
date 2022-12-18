namespace Beecrowd1041 {
    public class Program {
        public static void Main(string[] args) {
            string[] pontos = Console.ReadLine().Split(' ');

            double pontoX = double.Parse(pontos[0]);
            double pontoY = double.Parse(pontos[1]);

            if (pontoX == 0.0 && pontoY == 0.0) {
                Console.WriteLine("Origem");
            } else if (pontoX == 0.0) {
                Console.WriteLine("Eixo Y");
            } else if (pontoY == 0.0) {
                Console.WriteLine("Eixo X");
            } else if (pontoX > 0 && pontoY > 0) {
                Console.WriteLine("Q1");
            } else if (pontoX < 0 && pontoY > 0) {
                Console.WriteLine("Q2");
            } else if (pontoX < 0 && pontoY < 0) {
                Console.WriteLine("Q3");
            } else if (pontoX > 0 && pontoY < 0) {
                Console.WriteLine("Q4");
            }
        }
    }
}