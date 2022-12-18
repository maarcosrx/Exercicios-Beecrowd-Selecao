namespace Beecrowd1036 {
    public class Program {
        public static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');

            double a = double.Parse(valores[0]);
            double b = double.Parse(valores[1]);
            double c = double.Parse(valores[2]);

            double delta = Math.Pow(b, 2) - (4 * a * c);            
            double raizDelta = Math.Sqrt(delta);
            double x1 = (-b + raizDelta) / (2 * a);
            double x2 = (-b - raizDelta) / (2 * a);         

            if(a != 0 && delta > 0) {
                Console.WriteLine($"R1 = {x1:F5}");
                Console.WriteLine($"R2 = {x2:F5}");
            } else {
                Console.WriteLine("Impossivel calcular");
            } 
        }
    }
}