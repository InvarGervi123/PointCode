using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUSTWRITEONCS
{
    public abstract class BoxOfMoves
    {
        protected SingleCoordinate _coord;

        public BoxOfMoves(ConsoleKeyInfo setInitialKey, SingleCoordinate whatToMove)
        {
            Key = setInitialKey;
            _coord = whatToMove;
        }

        

        public virtual int PressKey(ConsoleKeyInfo KeyPreesdNow, int whatToMove)
        {
            return whatToMove;
        }

        public virtual void PressKey(ConsoleKeyInfo KeyPreesdNow)
        {
            
        }

        public ConsoleKeyInfo Key { get; set; }
       
        protected bool IsThisKey(ConsoleKeyInfo preesdNow)
        {
            return preesdNow.Key == Key.Key;
        }
    }
}
