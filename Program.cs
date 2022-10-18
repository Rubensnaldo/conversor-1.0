using System;

namespace conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            var condicao = 0;
            do
            {
                Console.WriteLine("conversor 1.0");
                Console.WriteLine("Selecione a opçao 1, 2, ou 3 ");

                int opçao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira o valor em graus");

                double graus = Convert.ToDouble(Console.ReadLine());

                double resultado = graus - 32 / 1.8;
                double resultado2 = graus * 1.8 + 32;

                do
                {
                    switch (opçao)
                    {
                        case 1:
                            Console.WriteLine(resultado);
                            condicao = 1;
                            break;

                        case 2:
                            Console.WriteLine(resultado2);
                            condicao = 2;
                            break;
                    }
                    if (opçao == 3)
                    {
                        Console.WriteLine("Presione enter para voltar ao menu");
                        Console.ReadLine();
                        condicao = 0;
                        Console.Clear();
                    }


                } while (condicao == 3);

            } while (condicao ==0);
        }
    }
}








