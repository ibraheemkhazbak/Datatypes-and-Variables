using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes_and_Variables
{
    class Renderer
    {
        private string[,] array2D;
        

        public Renderer(string[,] array2D)
        {
            this.array2D = array2D;
        }

        public void Render()
        {
            Console.Clear();
            for (int y = 0; y < array2D.GetLength(0); y++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine();

                Console.Write("|  ");

                for (int x = 0; x < array2D.GetLength(1); x++)
                {
                    Console.Write(array2D[y, x] + "  |  ");
                }


            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.Write("{0}'s turn type where you want to play: ", Program.mechanism.CurrentPlayer());
        }
    }
}
