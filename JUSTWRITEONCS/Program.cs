﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUSTWRITEONCS
{
    class Point
    {
        public static int x =0 ;
        public static int y =0 ;
        public static int z =0 ;

        //public int _x = x;
        //public int _y = y;
        //public int _z = z;

        public int keyA()
        {
            x = x -1 ;
            return x ;
        }
        public int keyD()
        {
            x = x + 1;
            return x ;
        }
        public int keyW()
        {
            y = y + 1;
            return y ;
        }
        public int keyS()
        {
            y = y - 1;
            return y ;
        }
        public int keySpace()
        {
            z =z + 1;
            return z ;
        }
    }

    class Controll : Point
    {
        public int PressKey()
        {
            string Key = Console.ReadLine();

            int NumKey = 0;

            if (Key == "a")
            {
                NumKey = keyA();
            }
            else if (Key == "d") //else if
            {
                NumKey = keyD();
            }
            else if (Key == "w")
            {
                NumKey = keyW();
            }
            else if (Key == "s")
            {
                NumKey = keyS();
            }
            else if (Key == " ")
            {
                NumKey = keySpace();
            }
            else
            {
                Console.WriteLine("Wrong");
            }
            //if (Key == null)
            //{
            //    Console.WriteLine("Wrong");
            //}

            while (true)
            {

                Console.WriteLine("X:" + x);
                Console.WriteLine("Y:" + y);
                Console.WriteLine("Z:" + z);
                    
                    
                    
                PressKey();
            }
            //return NumKey;

        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; ; i++)
            {
                Controll[] a = new Controll[i];
                Console.WriteLine(i);
            }

            Controll controll = new Controll();
            Console.WriteLine(controll.PressKey());
            Console.ReadKey();
        }
    }
}
