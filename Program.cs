using System;

namespace maiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, total, media, maiorValor = 0;
            int n = 0;
            char continuar = 's';
            total = 0;
            while (continuar != 'n')
            {
                Console.Write("Insira um valor:");
                valor = double.Parse(Console.ReadLine());
                if (maiorValor < valor)
                {
                    maiorValor = valor;
                }
                n++;
                total += valor;
                Console.WriteLine("Deseja continuar ?(s/n)");
                continuar = char.Parse(Console.ReadLine());
            }
            media = total / n;
            Console.WriteLine("total = {0}", total);
            Console.WriteLine("media = {0}", media);
            Console.WriteLine("maior valor:"+ maiorValor);
        }
    }
}
