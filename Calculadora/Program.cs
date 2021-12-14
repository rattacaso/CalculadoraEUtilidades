using System;
using System.Net;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine(@"
  /$$$$$$            /$$                     /$$                 /$$                                   
 /$$__  $$          | $$                    | $$                | $$                                   
| $$  \__/  /$$$$$$ | $$  /$$$$$$$ /$$   /$$| $$  /$$$$$$   /$$$$$$$  /$$$$$$   /$$$$$$  /$$$$$$       
| $$       |____  $$| $$ /$$_____/| $$  | $$| $$ |____  $$ /$$__  $$ /$$__  $$ /$$__  $$|____  $$      
| $$        /$$$$$$$| $$| $$      | $$  | $$| $$  /$$$$$$$| $$  | $$| $$  \ $$| $$  \__/ /$$$$$$$      
| $$    $$ /$$__  $$| $$| $$      | $$  | $$| $$ /$$__  $$| $$  | $$| $$  | $$| $$      /$$__  $$      
|  $$$$$$/|  $$$$$$$| $$|  $$$$$$$|  $$$$$$/| $$|  $$$$$$$|  $$$$$$$|  $$$$$$/| $$     |  $$$$$$$      
 \______/  \_______/|__/ \_______/ \______/ |__/ \_______/ \_______/ \______/ |__/      \_______/      
                                                                                                       
                                                                                                       
                                                                                                       
");
            Console.WriteLine("SELECIONE UMA TAREFA: ");
            Console.WriteLine("");
            Console.WriteLine("        1 - Soma");
            Console.WriteLine("        2 - Subtração");
            Console.WriteLine("        3 - Multiplicação");
            Console.WriteLine("        4 - Divisão");
            Console.WriteLine("        5 - Celsius para Fahrenheit");
            Console.WriteLine("        6 - Meu endereço IP");
            Console.WriteLine("        7 - Conversor de Moeda ");
            Console.WriteLine("        99 - Sair");
            Console.WriteLine("============================================================================");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: 
                    Soma();
                    break;
                case 2: 
                    Subtracao();
                    break;
                case 3: 
                    Multiplicacao();
                    break;
                case 4: 
                    Divisao();
                    break;
                case 5:
                    CelsiusToFahrenheit();
                    break;
                case 6:
                    MeuIp();
                    break;
                case 7:ConversorMoeda();
                    break;
                case 99://Digitar 99 para sair da aplicação.
                    Console.WriteLine("Bye!");
                    System.Environment.Exit(0);
                    break;
                default: Menu();
                    break;
            }


        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine("Digite dois valores separados por espaço: ");
            string[] valores = Console.ReadLine().Split();
            float v1 = float.Parse(valores[0]);
            float v2 = float.Parse(valores[1]);

            Console.WriteLine("Resultado: " + (v1 + v2));
            Console.ReadKey();
            Menu();

        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine("Digite dois valores separados por espaço: ");
            string[] valores = Console.ReadLine().Split();
            float v1 = float.Parse(valores[0]);
            float v2 = float.Parse(valores[1]);

            Console.WriteLine("Resultado: " + (v1 - v2));
            Console.ReadKey();
            Menu();

        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite dois valores separados por espaço: ");
            string[] valores = Console.ReadLine().Split();
            float v1 = float.Parse(valores[0]);
            float v2 = float.Parse(valores[1]);

            Console.WriteLine("Resultado: " + (v1 * v2));
            Console.ReadKey();
            Menu();

        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine("Digite dois valores separados por espaço: ");
            string[] valores = Console.ReadLine().Split();
            float v1 = float.Parse(valores[0]);
            float v2 = float.Parse(valores[1]);

            Console.WriteLine("Resultado: " + (v1 / v2));
            Console.ReadKey();
            Menu();

        }
        static void CelsiusToFahrenheit ()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Informe a temperatura em graus Cº: ");
            double C = int.Parse(Console.ReadLine());
            double F = (C * 1.8) + 32;
            Console.WriteLine("Temperatura em F: {0:0.0}",F);
            Console.ReadKey();
            Menu();
        }
        static void MeuIp() 
         {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------");
            String strHostName = string.Empty;
            IPHostEntry ipEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addr = ipEntry.AddressList;

            for (int i = 0; i < addr.Length; i++)
            {
                Console.WriteLine("IP Address {0}: {1} ", i, addr[i].ToString());
            }
            Console.ReadKey();
            Menu();

        }
        static void ConversorMoeda() 
        {
            Console.Clear();
            Console.WriteLine("Informe o valor em R$: ");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Selecione a Moeda que deseja converter: ");
            Console.WriteLine("1 - Dolar");
            Console.WriteLine("2 - Libras");
            Console.WriteLine("3 - Euro");
            Console.WriteLine("4 - Menu principal");
            Console.WriteLine("");

            string tipo = Console.ReadLine();
           
            
            switch (tipo) 
            {
                case "1": valor = valor/5.69;
                    Console.WriteLine("Valor em Dolár: {0:0.0}",valor);
                    Console.ReadKey();
                    ConversorMoeda();
                    break;
                case "2":
                    valor = valor / 7.52;
                    Console.WriteLine("Valor em Libra: {0:0.0}",valor);
                    Console.ReadKey();
                    ConversorMoeda();
                    break;
                case "3":
                    valor = valor / 6.40;
                    Console.WriteLine("Valor em Euro: {0:0.0}", valor);
                    Console.ReadKey();
                    ConversorMoeda();
                    break;
                case "4": Menu();
                    break;
                default : Menu();
                    break;
            }

        }

    }
}
