using System;

class Program
{
	public static void Main(string[] args)
    {
        bool endApp = false;

        // Imprime o título na tela 

        Console.WriteLine("Minha Calculadora");
        Console.WriteLine("--------------------");

        while(!endApp)
        {
            string numInput1 = " ";
            string numInput2 = " ";
            double result = 0;

            // pede ao usuário para inserir o primeiro valor 

            Console.WriteLine("Escreva um número e pressione Enter ");
            numInput1 = Console.ReadLine();

            //tratamento de entrada do primeiro valor 
            double cleanNum1 = 0; 
            while(!double.TryParse(numInput1, out cleanNum1))
            {
                Console.WriteLine("por favor, insira um valor válido para continuar");
                numInput1 = Console.ReadLine();
            }

            //adicionar o segundo valor 
            Console.WriteLine("Escreva outro número e pressione Enter");
            numInput2 = Console.ReadLine();

            //tratamento de entrada no segundo valor 
            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.WriteLine("por favor, insira um valor válido para continuar");
                numInput2 = Console.ReadLine();
            }

            // selecionar a operação que o usuário deseja realizar 

            Console.WriteLine("Selecione uma operação para realizar");
            Console.WriteLine("\ta - Adição ");
            Console.WriteLine("\ts - Subtração ");
            Console.WriteLine("\tm - Multiplicação ");
            Console.WriteLine("\td - Divisão ");
            Console.WriteLine("Qual a Operação?");

            string op = Console.ReadLine();

            try
            {
                result = Program.DoOperation(cleanNum1, cleanNum2, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("Essa Operação resultou em um erro.");
                }
                else Console.WriteLine("Seu resultado é: {0:0.##}", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Desculpe! ocorreu uma excessão, tente novamente. - Detalhes" + e.Message);
            }
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Pressione 'n' ou Enter para fechar a calculadora ou pressione outra tecla + Enter para continuar: ");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n");
        }
        return;
    }
}
