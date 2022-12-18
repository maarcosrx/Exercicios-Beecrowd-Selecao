namespace Beecrowd1038 {
    public class Program {
        public static void Main(string[] args) {

            string[] lanche = Console.ReadLine().Split(' ');  
            int cod = int.Parse(lanche[0]);
            int qnt = int.Parse(lanche[1]);
            double preco;

            if(cod == 1) {
                preco = 4.00;
                Console.WriteLine($"Total: R$ {qnt*preco:F2}");
            }else if(cod == 2) {
                preco = 4.50;
                Console.WriteLine($"Total: R$ {qnt*preco:F2}");
            }else if(cod == 3) {
                preco = 5.00;
                Console.WriteLine($"Total: R$ {qnt*preco:F2}");
            }else if(cod == 4) {
                preco = 2.00;
                Console.WriteLine($"Total: R$ {qnt*preco:F2}");
            }else if(cod == 5) {
                preco = 1.50;
                Console.WriteLine($"Total: R$ {qnt*preco:F2}");
            }
        }
    }
}