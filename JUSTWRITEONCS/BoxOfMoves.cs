using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUSTWRITEONCS
{
    public abstract class BoxOfMoves
    {
        //private ConsoleKeyInfo _Key;

        public BoxOfMoves(ConsoleKeyInfo setInitialKey)
        {
            Key = setInitialKey;
        }


        public virtual int PressKey(ConsoleKeyInfo KeyPreesdNow, int whatToMove)
        {
            return whatToMove;
        }
       
        public ConsoleKeyInfo Key { get; set; }
       
        protected bool IsThisKey(ConsoleKeyInfo preesdNow)
        {
            return preesdNow.Key == Key.Key;
        }
    }
}
