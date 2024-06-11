using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUSTWRITEONCS
{
    public class Point
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

    public class Controll : Point
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
                y = moveUp(y);
            }
            else if (moveTo.Key == ConsoleKey.S)
            {
                y = moveDown(y);
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
            //InitAndStartUniversalPointMove();
            //Console.ReadKey();

            //for (int i = 0; ; i++)
            //{
            //    Controll[] a = new Controll[i];
            //    Console.WriteLine(i);
            //}

            // BoxOfMoves keyA = new BoxOfMoves(new ConsoleKeyInfo('A', ConsoleKey.A,false,false,false));

            Controll controll = new Controll();
            while (true)
            {
                

                string showMe = $"X:{controll.x} Y:{controll.y} Z:{controll.z} ";
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

            Console.WriteLine(" Now Go as Professionals!!!!");


            Console.ReadKey();

            InitAndStartUniversalPointMove();
            Console.ReadKey();
        }

        private static void InitAndStartUniversalPointMove()
        {
            Controll singlePoint = new Controll();

            List<BoxOfMoves> allButtons = new List<BoxOfMoves>();

            allButtons.Add(new MoveDown(new ConsoleKeyInfo(' ', ConsoleKey.A, true, false, false)));
            allButtons.Add(new MoveUp(new ConsoleKeyInfo(' ', ConsoleKey.D, true, false, false)));



            while (true)
            {


                string showMe = $"X:{singlePoint.x} Y:{singlePoint.y} Z:{singlePoint.z} ";
                Console.WriteLine(showMe);
                ConsoleKeyInfo MoveTo = Console.ReadKey();

                foreach (var buttLogic in allButtons)
                {
                    singlePoint.x = buttLogic.PressKey(MoveTo, singlePoint.x);

                    
                }

                if (MoveTo.Key == ConsoleKey.Escape)
                {
                    break;
                }                
            }

            Console.WriteLine("Exit pressed!!!");
        }
    }
}
