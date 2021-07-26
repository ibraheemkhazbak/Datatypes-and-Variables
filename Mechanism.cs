using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes_and_Variables
{
    class Mechanism
    {
        private string[,] array2D;
        public bool player1 {
            get;
            set;
        }
        int selection;
        SelectionYX selectionYX;

        public Mechanism(string[,] array2D)
        {
            this.array2D = array2D;
            this.player1 = true;
        }

        public void ChangePlayer()
        {
            player1 = !player1;
        }

        public  string CurrentPlayer()
        {
            return player1 ? "player1" : "player2";
        }



        public  bool ProcessPlacement()
        {
            bool success;
            int garbage;
            string selectedSlot = array2D[selectionYX.y, selectionYX.x];
            if (int.TryParse(selectedSlot, out garbage))
            {
                if (player1)
                {
                    array2D[selectionYX.y, selectionYX.x] = "x";
                }
                else
                {
                    array2D[selectionYX.y, selectionYX.x] = "o";
                }
                success = true;
            }
            else
            {
                Console.WriteLine("this slot is taken please pick another");
                success = false;
            }
            return success;
        }

        public  void GetInput()
        {

            bool success = int.TryParse(((char)Console.Read()).ToString(), out selection);
            Console.ReadLine();
            if (!success)
            {

                Console.WriteLine("please enter a number from 1 to 9");
                GetInput();
            }
            ConvertToMatrix();
        }

        private  void ConvertToMatrix()
        {
            int x, y;
            y = (selection - 1) / 3;

            //if x<1 in this formula set x to 2
            x = (selection - 1) % 3;

            selectionYX = new SelectionYX(y, x);

        }
    }
}
