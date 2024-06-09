using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUSTWRITEONCS
{
    public class BoxOfMoves
    {
        //private ConsoleKeyInfo _Key;

        public BoxOfMoves(ConsoleKeyInfo setInitialKey)
        {
            Key = setInitialKey;
        }


        //public int PressKey(ConsoleKeyInfo KeyPreesdNow, int coord)
        //{
        //    if (KeyPreesdNow == Key)
        //    {
        //        int res = MoveMe(coord);
        //    }
        //}
        public ConsoleKeyInfo Key { get; set; }

        //public delegate int MoveMe(int anyCoord);
        //public MoveMe WhenKeyChange(int aCoord)
        //{
        //    return new MoveMe()
        //}

    }
}
