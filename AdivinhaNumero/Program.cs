using System;

namespace AdivinhaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_gerado, numero_palpite;
            string continuar = "s";

            numero_gerado = new Random().Next(1, 9);
            
            while (true)
            {
                Console.WriteLine("Informe seu palpite: ");
                numero_palpite = int.Parse(Console.ReadLine());
                if (numero_palpite == numero_gerado)
                {
                    Console.WriteLine("Parabéns!!! Você acertou!");
                    Console.WriteLine("Informe [n] para parar ou [s] para continuar");
                    continuar = Console.ReadLine();
                    numero_gerado = new Random().Next(1, 9);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Você errou! You lose");
                }
                if (continuar == "n" || continuar == "N" )
                {
                    break;
                }
                else
                {
                    if (numero_gerado < numero_palpite)
                    {
                        Console.WriteLine("Informe um número menor");
                    }
                    else
                    {
                        Console.WriteLine("Informe um número maior");
                    }
                }
            }
        }
    }
}
