using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
           // Declara as variáveis e inicializa com o valor 0 
            double num1 = 0;
            double num2 = 0;

            // Imprime o título na tela 

            Console.WriteLine("Minha Calculadora");
            Console.WriteLine("--------------------");

            // pede ao usuário para inserir o primeiro valor 

            Console.WriteLine("Escreva um número e pressione Enter ");
            num1 = Convert.ToDouble(Console.ReadLine());

            // pede ao usuário para inserir o segundo valor 

            Console.WriteLine("Escreva outro número e pressione Enter ");
            num2 = Convert.ToDouble(Console.ReadLine());

            // selecionar a operação que o usuário deseja realizar 

            Console.WriteLine("Selecione uma operação para realizar");
            Console.WriteLine("\ta - Adição ");
            Console.WriteLine("\ts - Subtração ");
            Console.WriteLine("\tm - Multiplicação ");
            Console.WriteLine("\td - Divisão ");
            Console.WriteLine("Qual a Operação?");

            // switch para filtrar as operações

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("Seu Resultado é: {num1} + {num2} = " + (num1 + num2));
                    break;

                case "s":
                    Console.WriteLine("Seu Resultado é: {num1} - {num2} = " + (num1 - num2));
                    break;

                case "m":
                    Console.WriteLine("Seu Resultado é: {num1} * {num2} = " + (num1 * num2));
                    break;

                case "d":
                   //tratamento para divisão por zero
                    while(num2 == 0)
                    {
                        Console.WriteLine("Digite um valor diferente de zero para continuar ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                    }
                    Console.WriteLine("Seu Resultado é: {num1} / {num2} = " + (num1 / num2));
                    break;

            }

                    //Comando para encerrar a calculadora 

                    Console.WriteLine("Pressione Enter para Fechar a Calculadora");
                    Console.ReadLine();

            

        }
    }
}
