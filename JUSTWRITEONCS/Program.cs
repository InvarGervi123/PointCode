using JUSTWRITEONCS;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUSTWRITEONCS
{
    public class Point
    {
        public SingleCoordinate XX { get; set; }
        public SingleCoordinate YY { get; set; }
        public SingleCoordinate ZZ { get; set; }
    }       
}

public class Controll : Point
    {
        public Controll()
        {
        
            XX = new SingleCoordinate();
            YY = new SingleCoordinate();
            ZZ = new SingleCoordinate();
            Image = "*";
        }

        public string Image { get; internal set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Controll singlePoint = new Controll();
            List<BoxOfMoves> allButtons = InitUniversalPointMove(singlePoint);
            StartUniversalPointMove(allButtons, singlePoint);
            Console.ReadKey();
        }

        private static void StartUniversalPointMove(List<BoxOfMoves> allButtons, Controll singlePoint)
        {
            while (true)
            {
                //string showMe = $"X:{singlePoint.XX.Value} Y:{singlePoint.YY.Value} Z:{singlePoint.ZZ.Value} ";
                //Console.WriteLine(showMe);
                ShowOnScreen(singlePoint);

                ConsoleKeyInfo MoveTo = Console.ReadKey();
                foreach (var buttLogic in allButtons)
                {
                    buttLogic.PressKey(MoveTo);
                }
                if (MoveTo.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }

            Console.WriteLine("Exit pressed!!!");
        }

        private static List<BoxOfMoves> InitUniversalPointMove(Controll singlePoint)
        {
            List<BoxOfMoves> result = new List<BoxOfMoves>();


            result.Add(new MoveDown(new ConsoleKeyInfo(' ', ConsoleKey.A, true, false, false), singlePoint.XX));
            result.Add(new MoveUp(new ConsoleKeyInfo(' ', ConsoleKey.D, true, false, false), singlePoint.XX));
            result.Add(new MoveDown(new ConsoleKeyInfo(' ', ConsoleKey.S, true, false, false), singlePoint.YY));
            result.Add(new MoveUp(new ConsoleKeyInfo(' ', ConsoleKey.W, true, false, false), singlePoint.YY));


            result.Add(new MoveDown(new ConsoleKeyInfo(' ', ConsoleKey.LeftArrow, true, false, false), singlePoint.XX));
            result.Add(new MoveUp(new ConsoleKeyInfo(' ', ConsoleKey.RightArrow, true, false, false), singlePoint.XX));
            result.Add(new MoveDown(new ConsoleKeyInfo(' ', ConsoleKey.DownArrow, true, false, false), singlePoint.YY));
            result.Add(new MoveUp(new ConsoleKeyInfo(' ', ConsoleKey.UpArrow, true, false, false), singlePoint.YY));

            return result;

        }       

        private static void ShowOnScreen(Controll singlePoint)
        {
            RemoveOld(singlePoint);
            DrawNew(singlePoint);           
        }

        private static void DrawNew(Controll singlePoint)
        {
            int Xpoint = 30 + singlePoint.XX.Value;
            int Ypoint = 30 + singlePoint.YY.Value;
            Debug.WriteLine($"New {Xpoint}:{Ypoint}");
            Console.CursorTop = Ypoint;
            Console.CursorLeft = Xpoint;
            Console.Write(singlePoint.Image);
        }

        private static void RemoveOld(Controll singlePoint)
        {
            int Xpoint = 30 + singlePoint.XX.PastValue - 2;
            int Ypoint = 30 + singlePoint.YY.PastValue - 2;
            Debug.WriteLine($"Old {Xpoint}:{Ypoint}");
            Console.CursorTop = Ypoint;
            Console.CursorLeft = Xpoint;
            Console.Write("     ");
            Console.CursorTop = Ypoint +1;
            Console.CursorLeft = Xpoint +1;
            Console.Write("     ");
            Console.CursorTop = Ypoint + 1;
            Console.CursorLeft = Xpoint + 1;
            Console.Write("     ");
        }
    }
}
