using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //robô de atendimento 
            int opcao;
            Console.WriteLine("                                Digite a Opção desejada                                   ");
            Console.WriteLine("                                ========================                                  ");
            Console.WriteLine("                               1 - Desbloqueio de Cartão"                                  );
            Console.WriteLine("                                ========================                                  ");
            Console.WriteLine("                                 2 - Bloqueio de Cartão"                                     );
            Console.WriteLine("                                ========================                                  ");
            Console.WriteLine("                               3 - Falar com o Atendente"                                   );
            Console.WriteLine("                                ========================                                  ");
            Console.WriteLine("                                   4 - Sair do Sistema"                                     );
            Console.WriteLine("                                ========================                                  ");
            Console.ReadLine();
        }
    }
}
