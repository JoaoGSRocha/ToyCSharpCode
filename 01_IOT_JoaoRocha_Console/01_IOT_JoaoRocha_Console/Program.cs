using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_IOT_JoaoRocha_Console
{
    public class Program
    {

        private string nome;
        private string sobrenome;

        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }

        /// <summary>
        /// Concatenates your Forename and Surname returning  
        /// in a Console.Writeline() your full name with a space in between
        /// </summary>
        /// <param name="Nome">Your Forename</param>
        /// <param name="Sobrenome">Your Surname</param>
        public void ConcatFullNameDisplay(string Nome, string Sobrenome)
        {
            Console.WriteLine("Indique o seu nome: ");
            Nome = Console.ReadLine();

            Console.WriteLine("Indique o seu sobrenome: ");
            Sobrenome = Console.ReadLine();

            Console.WriteLine("\nO seu nome completo é: {0} {1} .", Nome,
                Sobrenome);
            Console.WriteLine("\n Press any key to exit program...");
            Console.ReadKey();
        }

        /// <summary>
        /// Concatenates your Forename and Surname returning in a String
        /// your full name with a space in between
        /// </summary>
        /// <param name="Nome">Your Forename</param>
        /// <param name="Sobrenome">Your Surname</param>
        public String ConcatFullNameNoDisplay(string Nome, string Sobrenome)
        {
            return (Nome+" "+Sobrenome);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.ConcatFullNameDisplay(program.Nome, program.Sobrenome);
        }
    }
}
