using System;

namespace CadFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Func;

            Funcionario[] CadFunc = new Funcionario[50];

            int Indice = 0;

            string Depto;       //Departamento a ser listado
            do
            {
                Console.Clear();

                Func = new Funcionario();

                Console.Write("Matricula do Funcionario: ");
                Func.Matricula = Console.ReadLine();

                Console.Write("Nome..............: ");
                Func.Nome = Console.ReadLine();

                Console.Write("Departtamento........: ");
                Func.Departamento = Console.ReadLine();

                Console.Write("Salario ($)........: ");
                Func.Salario = double.Parse(Console.ReadLine());
                Func.DataAdmissão = new Data();

                Console.Write("Data de Admissão.......   Dia: ");
                Func.DataAdmissão.Dia = Console.ReadLine();

                Console.Write("          Mês: ");
                Func.DataAdmissão.Mes = Console.ReadLine();

                Console.Write("           Ano: ");
                Func.DataAdmissão.Ano = Console.ReadLine();

                CadFunc[Indice] = Func;
                Indice++;

                Console.WriteLine("\nDeseja cadastrar outro Funcionario? (ESC cancela...)");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Clear();

            Console.Write("Deseja listar funcionarios de qual departamento? ");
            Depto = Console.ReadLine();

            Console.WriteLine("\n");

            foreach (Funcionario x in CadFunc)
            {
                if(x.Departamento == Depto) 
                {
                Console.WriteLine("{0} - {1}", x.Matricula, x.Nome);
                Console.WriteLine("Salario: R$ {0:F2}\n", x.Salario);    
                }  
           }
            Console.ReadLine();
        }
    }
}
