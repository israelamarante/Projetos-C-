using System ;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu(); // chamando a função() aqui na main e conta por 6segundos
        }

        static void Menu() {

            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo desejar contar?");

            string data = Console.ReadLine().ToLower(); //ToLower coloca tudo da variavel em minusculo
            char type =  char.Parse (data.Substring(data.Length -1 , 1)); // length conta a strings
            int time = int.Parse (data.Substring(0,data.Length -1));
            int multiplier = 1;

           // if (type == "m")
             //   multiplier = 60;

            if (time == 0)
                 System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart (int time){
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }
        static void Start( int time )
        {
            int currentTime = 0; //quero que comece contar de zero obs:currentTime é tempo atual

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); // Thread faz com que ele dorma a cada contagem ou seja espere
            }

            Console.Clear();
            Console.WriteLine("stopwatch finalizado..");
            Thread.Sleep(2500);
            Menu();
        }
    }
}