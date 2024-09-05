/* 2) Escreva um programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula ou minúscula, além de informar a quantidade de vezes em que ela ocorre.
   IMPORTANTE: Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código; */

using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra = Console.ReadLine();

            int cont = 0;
            for (int i = 0; i < palavra.Length; i++)
            {
                if (palavra[i] == 'A' || palavra[i] == 'a')
                {
                    cont++;
                }
            }
            Console.WriteLine("Tem a letra A " + cont + " vezes na palavra " + palavra);
        }
    }
}
