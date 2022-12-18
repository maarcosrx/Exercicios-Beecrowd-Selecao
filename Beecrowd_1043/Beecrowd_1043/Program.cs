namespace Beecrowd1043 {
    public class Program {
        public static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');

            double ladoa = double.Parse(valores[0]);
            double ladob = double.Parse(valores[1]);
            double ladoc = double.Parse(valores[2]);

            if(ladoa >= ladob + ladoc || ladob >= ladoa + ladoc || ladoc >= ladoa + ladob) { 
             double area = ((ladoa + ladob) * ladoc / 2);
                Console.WriteLine($"Area = {area:F1}");
            } else {
                double perimetro = ladoa + ladob + ladoc;
                Console.WriteLine($"Perimetro = {perimetro:F1}");
            }

        }
    }
}