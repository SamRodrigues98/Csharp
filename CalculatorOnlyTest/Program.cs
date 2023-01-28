using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOnlyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            // Mensagem inicial da calculadora 
            Console.WriteLine("Calculadora de console no C#");
            Console.WriteLine("------------------------------");

            while (!endApp)
            {
                //declarar as variáveis sem setar valores 

                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                //pede ao usuário para inserir o primeiro valor 

                Console.WriteLine("digite um valor e pressione enter.");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0; 
                while(!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.WriteLine("O valor que você digitou é inválido, por favor, digite um valor inteiro.");
                    numInput1 = Console.ReadLine();

                }

                //requisição do segundo numero de entrada 

                Console.WriteLine("Digite um segundo valor e pressione enter");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.WriteLine("O valor que você digitou é inválido, por favor, digite um valor inteiro.");
                    numInput2 = Console.ReadLine();
                }

                // escrevendo as operações 
                Console.WriteLine("Escolha uma operação da Lista:");
                Console.WriteLine("\ta - Adição");
                Console.WriteLine("\ts - Subtração");
                Console.WriteLine("\tm - Multiplicação");
                Console.WriteLine("\td - Divisão");
                Console.WriteLine("Sua opção foi: ");

                string op = Console.ReadLine(); 

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Essa operação resultou em um erro :( ");
                    }
                    else Console.WriteLine("Seu resultado é: {0:0.##}\n", result);

                    }
                catch(Exception e)
                {
                    Console.WriteLine("Ocorreu uma excessão, tente novamente mais tarde \n - Detalhes:" + e.Message);

                }

                Console.WriteLine("----------------------- \n");

                Console.WriteLine("Pressione 'n' ou Enter para fechar o app. Pressione outra tecla e Enter para continuar :) ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
                }
            } 

        }
    }

