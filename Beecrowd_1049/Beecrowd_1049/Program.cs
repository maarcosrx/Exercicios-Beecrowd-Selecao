namespace Beecrowd1049 {
    public class Program {
        public static void Main(string[] args) {

            string dado1 = Console.ReadLine();
            string dado2 = Console.ReadLine();
            string dado3 = Console.ReadLine();

            if(dado1 == "vertebrado" && dado2 == "ave" && dado3 == "carnivoro") {
                Console.WriteLine("aguia");
            }else if(dado1 == "vertebrado" && dado2 == "ave" && dado3 == "onivoro") {
                Console.WriteLine("pomba");
            }
            if(dado1 == "vertebrado" && dado2 == "mamifero" && dado3 == "onivoro") {
                Console.WriteLine("homem");
            }else if(dado1 == "vertebrado" && dado2 == "mamifero" && dado3 == "herbivoro") {
                Console.WriteLine("vaca");
            }
            if(dado1 == "invertebrado" && dado2 == "inseto" && dado3 == "hematofago") {
                Console.WriteLine("pulga");
            }else if(dado1 == "invertebrado" && dado2 == "inseto" && dado3 == "herbivoro") {
                Console.WriteLine("lagarta");
            }
            if(dado1 == "invertebrado" && dado2 == "anelideo" && dado3 == "hematofago") {
                Console.WriteLine("sanguessuga");
            } else if(dado1 == "invertebrado" && dado2 == "anelideo" && dado3 == "onivoro") {
                Console.WriteLine("minhoca");
            }
        }
    }
}