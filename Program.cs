using System;

namespace Datatypes_and_Variables
{
    class Program
    {
        static string[,] array2D = new string[3, 3] {
            { "1","2","3" },
            { "4","5","6" },
            { "7","8","9" }
            };
        public static Mechanism mechanism;
        public static WinnerCalculator winCalc;
        public static Renderer renderer ;
        public static bool win = false;
        public static bool draw =false;
        static void Main(string[] args)
        {
            StartGame();
            
            
        }

        public static void StartGame() {
            Setup();
            bool placementSucceess;

            while (true)
            {
                placementSucceess = false;
                renderer.Render();

                while (!placementSucceess)
                {
                    mechanism.GetInput();
                    placementSucceess = mechanism.ProcessPlacement();
                }
                win = winCalc.CalculateWin();
                draw = winCalc.CalculateDraw();
                if (win)
                {
                    renderer.Render();

                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("{0} has won the game!", mechanism.CurrentPlayer());
                    break;
                } else if (draw) {
                    renderer.Render();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("It was a draw...");
                    break;
                }


                mechanism.ChangePlayer();
            }

            Console.Read();
        }

        private static void Setup()
        {
            Console.ForegroundColor = ConsoleColor.White;
            mechanism = new Mechanism(array2D);
            winCalc = new WinnerCalculator(array2D);
            renderer = new Renderer(array2D);
        }
    }
}



