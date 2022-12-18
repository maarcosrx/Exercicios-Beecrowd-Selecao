namespace Beecrowd1046 {
    public class Program {
        public static void Main(string[] args) {

            string[] tempoJogo = Console.ReadLine().Split(' ');

            double horaInicial = double.Parse(tempoJogo[0]);
            double horaFinal = double.Parse(tempoJogo[1]);
            double hora = 24;

            if(horaInicial > horaFinal) {
                hora = hora - horaInicial + horaFinal;
                Console.WriteLine($"O JOGO DUROU {hora} HORA(S)");
            }else if(horaInicial < horaFinal) {
                hora = horaFinal - hora + hora - horaInicial;
                Console.WriteLine($"O JOGO DUROU {hora} HORA(S)");
            }else if(horaInicial == horaFinal) {
                Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            }

        }
    }
}