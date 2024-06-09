using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUSTWRITEONCS
{
    public class MoveUp : BoxOfMoves
    {
        public MoveUp(ConsoleKeyInfo setInitialKey) : base(setInitialKey)
        {
        }
        public override int PressKey(ConsoleKeyInfo KeyPreesdNow, int whatToMove)
        {
            if (IsThisKey(KeyPreesdNow))
            {                
                return ++whatToMove;
            }
            else
            {
                return base.PressKey(KeyPreesdNow, whatToMove);
            }
        }
    }
}
