using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes_and_Variables
{
    class WinnerCalculator
    {
        private string[,] array2D;

        public WinnerCalculator(string[,] array2D)
        {
            this.array2D = array2D;
        }
        public bool CalculateDraw() {
            bool draw = true;
            int garbage;
            foreach (string item in array2D) {
                if (int.TryParse(item,out garbage)) {
                    draw = false;
                    break;
                }

            }
            return draw;
        }
        public bool CalculateWin()
        {
            return CheckRows() || CheckColumns() || CheckDiagLTR() || CheckDiagRTL();
        }

        private  bool CheckDiagRTL()
        {
            bool win = true;
            string selected = array2D[0, array2D.GetLength(1) - 1];
            for (int y = 0, x = array2D.GetLength(1) - 1; y < array2D.GetLength(0); y++, x--)
            {
                if (!selected.Equals(array2D[y, x]))
                {
                    win = false;
                    break;
                }
            }
            return win;
        }

        private bool CheckDiagLTR()
        {
            bool win = true;
            string selected = array2D[0, 0];
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                if (!array2D[i, i].Equals(selected))
                {
                    win = false;
                    break;
                }
            }
            return win;
        }

        private bool CheckColumns()
        {
            bool win = true;
            string selected;
            for (int x = 0; x < array2D.GetLength(0); x++)
            {
                win = true;
                selected = array2D[0, x];
                for (int y = 0; y < array2D.GetLength(1); y++)
                {
                    if (!selected.Equals(array2D[y, x]))
                    {
                        win = false;
                        break;
                    }
                }
                if (win == true)
                {
                    break;
                }
            }
            return win;
        }

        private bool CheckRows()
        {
            bool win = true; ;
            string selected;
            for (int y = 0; y < array2D.GetLength(0); y++)
            {
                win = true;
                selected = array2D[y, 0];
                for (int x = 0; x < array2D.GetLength(1); x++)
                {
                    if (!selected.Equals(array2D[y, x]))
                    {
                        win = false;
                        break;
                    }
                }
                if (win == true)
                {
                    break;
                }
            }
            return win;
        }
    }
}
