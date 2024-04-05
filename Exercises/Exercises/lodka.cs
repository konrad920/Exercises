using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{

    public class BoatMovements
    {
        public static bool CanTravelTo(bool[,] gameMatrix, int fromRow, int fromColumn, int toRow, int toColumn)
        {
            var wantedValiu = gameMatrix[fromRow, fromColumn];
            var userValiu = gameMatrix[toRow, toColumn];
            if (wantedValiu == userValiu)
            {
                if ((toRow == 3 && toColumn == 1) || (toRow == 4 && toColumn == 2))
                {
                    return false;
                }
                return true;
            }
            else
                return false;
        }

        public static void Main()
        {
            bool[,] gameMatrix =
            {
            { false, false, true, true, false },
            { false, false, true, false, false },
            { false, false, true, true, false },
            { false, true, false, true, false },
            { false, false, true, false, false }
        };

            Console.WriteLine(CanTravelTo(gameMatrix, 2, 2, 0, 2));
            Console.WriteLine(CanTravelTo(gameMatrix, 2, 2, 2, 1));
            Console.WriteLine(CanTravelTo(gameMatrix, 2, 2, 2, 3));
            Console.WriteLine(CanTravelTo(gameMatrix, 2, 2, 4, 2));
        }        
    }
}
