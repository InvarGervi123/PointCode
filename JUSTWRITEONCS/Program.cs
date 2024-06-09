using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUSTWRITEONCS
{
    class Point
    {
        

        public  int x = 0;
        public  int y = 0;
        public  int z = 0;    


        public int moveDown(int oneCoord)
        {
            oneCoord = oneCoord - 1;
            return oneCoord;
        }

        public int moveUp(int oneCoord)
        {
            oneCoord = oneCoord + 1;
            return oneCoord;
        }      
    }

    class Controll : Point
    {     

        internal void Move(ConsoleKeyInfo moveTo)
        {
            if (moveTo.Key == ConsoleKey.A)
            {
                x = moveDown(x);
            }
            else if (moveTo.Key == ConsoleKey.D) //else if
            {
                x = moveUp(x);
            }
            else if (moveTo.Key == ConsoleKey.W)
            {
                y = moveDown(y);
            }
            else if (moveTo.Key == ConsoleKey.S)
            {
                y = moveUp(y);
            }
            else if (moveTo.Key == ConsoleKey.Spacebar)
            {
                z = moveUp(z);
            }
            else
            {
                Console.WriteLine($"{Environment.NewLine}Wrong!!!");
            }
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; ; i++)
            //{
            //    Controll[] a = new Controll[i];
            //    Console.WriteLine(i);
            //}

           // BoxOfMoves keyA = new BoxOfMoves(new ConsoleKeyInfo('A', ConsoleKey.A,false,false,false));
            
            Controll controll = new Controll();
            while (true)
            {
                

                string showMe = $"X:{controll.y} Y:{controll.x} Z:{controll.z} ";
                Console.WriteLine(showMe);
                ConsoleKeyInfo MoveTo = Console.ReadKey();
                if (MoveTo.Key == ConsoleKey.Escape)
                {
                    break;
                }
                controll.Move(MoveTo);
            }

            Console.WriteLine("Exit pressed!!!");

            Console.CursorLeft = 40;
            Console.CursorTop = 40;


            Console.WriteLine("Exit pressed!!!");
 Console.ReadKey();
            Console.CursorLeft = 40;
            Console.CursorTop = 40;

            Console.WriteLine("            d!!!");


            Console.ReadKey();
        }
    }
}
