using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUSTWRITEONCS
{
    public class MoveDown : BoxOfMoves
    {
        public MoveDown(ConsoleKeyInfo setInitialKey, SingleCoordinate whatToMove) : base(setInitialKey, whatToMove)
        {
        }  
        public override void PressKey(ConsoleKeyInfo KeyPreesdNow)
        {
            if (IsThisKey(KeyPreesdNow))
            {
                --_coord.Value;
            }           
        }

    }
}
