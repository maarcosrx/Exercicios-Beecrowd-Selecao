namespace Beecrowd1047 {
    public class Program {
        public static void Main(string[] args) {

            string[] tempoJogo = Console.ReadLine().Split(' ');

            int hora1 = int.Parse(tempoJogo[0]);
            int minuto1 = int.Parse(tempoJogo[1]);
            int hora2 = int.Parse(tempoJogo[2]);
            int minuto2 = int.Parse(tempoJogo[3]);

            if(hora2 > hora1 && minuto2 > minuto1) {
                int duracaoH = hora2 - hora1;
                int duracaoM = minuto2 - minuto1;
                Console.WriteLine($"O JOGO DUROU {duracaoH} HORA(S) E {duracaoM} MINUTO(S)");
            }else if(hora2 > hora1 && minuto1 > minuto2) {
                int duracaoH = hora2 - hora1 - 1;
                int duracaoM = minuto2 - minuto1 + 60;
                Console.WriteLine($"O JOGO DUROU {duracaoH} HORA(S) E {duracaoM} MINUTO(S)");
            }else if(hora2 == hora1 && minuto1 > minuto2) {
                int duracaoH = 23;
                int duracaoM = minuto2 - minuto1 + 60;
                Console.WriteLine($"O JOGO DUROU {duracaoH} HORA(S) E {duracaoM} MINUTO(S)");
            }else if(hora2 == hora1 && minuto2 > minuto1) {
                int duracaoH = 0;
                int duracaoM = minuto2 - minuto1;
                Console.WriteLine($"O JOGO DUROU {duracaoH} HORA(S) E {duracaoM} MINUTO(S)");
            }else if(hora2 > hora1 && minuto2 == minuto1) {
                int duracaoH = hora2 - hora1;
                int duracaoM = 0;
                Console.WriteLine($"O JOGO DUROU {duracaoH} HORA(S) E {duracaoM} MINUTO(S)");
            }else if(hora2 < hora1 && minuto2 == minuto1) {
                int duracaoH = hora2 - hora1 + 24;
                int duracaoM = 0;
                Console.WriteLine($"O JOGO DUROU {duracaoH} HORA(S) E {duracaoM} MINUTO(S)");
            }else if(hora2 < hora1 && minuto2 > minuto1) {
                int duracaoH = hora2 - hora1 + 24;
                int duracaoM = minuto2 - minuto1;
                Console.WriteLine($"O JOGO DUROU {duracaoH} HORA(S) E {duracaoM} MINUTO(S)");
            }else if(hora2 < hora1 && minuto2 < minuto1) {
                int duracaoH = hora2 - hora1 + 23;
                int duracaoM = minuto2 - minuto1 + 60;
                Console.WriteLine($"O JOGO DUROU {duracaoH} HORA(S) E {duracaoM} MINUTO(S)");
            } else {
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
        }
    }
}