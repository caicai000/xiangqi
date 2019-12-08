using System;
using static chinesechree.Classchess;

namespace chinesechree
{
    public class movefunction
    {
        public static void ShowBoard(Chess[,] Board)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < 9; j++)
                {
                    Console.Write("  " + Board[i, j].getname() + "  ");
                }
            }
        }
        public static void Boardequal(Chess[,] Board, Chess[,] Boardshow)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Boardshow[i, j] = Board[i, j];
                }
            }
        }
        public static Boolean FOE(Chess chess1, Chess chess2)
        {
            Boolean a = true;
            if (chess1.getcolor() == chess2.getcolor())
            {
                a = false;
            }
            return a;
        }

        public static void Kill(Chess chess1)
        {
            chess1.killstate();

        }
        public static void Move(string str1, string str2, Chess[,] Board,Chess[,] Boardshow)
        {
            int a = 0;
            int b = 0;
            

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Board[i, j].getname().Contains(str1))
                    {
                        a = i;
                        b = j;
                        break;
                    }
                }
            }
            string[] sArray = str2.Split(',');
            int c = Convert.ToInt32(sArray[0]);
            int d = Convert.ToInt32(sArray[1]);

            Chess exchange = new wu("  +   ", "null", 0, 0, true);

            exchange = Board[c, d];
            
            Board[c, d] = Board[a, b];
            
            Board[a, b] = exchange;

            Boardequal(Board, Boardshow);

        }

        public static void chemovefunction(Chess[,] Boardshow,Chess[,] Board,string str1,Chess go)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Board[i, j].getname().Contains(str1))
                    {
                        a = i;
                        b = j;
                        break;
                    }
                }
            }
            Console.Write("You can go : ");

            for (d = b + 1; d < 9; d++)
            {
                if (Board[a, d].getname().Contains("+") != true)
                {
                    if (FOE(Board[a, b], Board[a, d]))
                    {
                        Console.Write("(" + a + "," + d + ")");
                    }

                    break;
                }
                if (Board[a, d].getname().Contains("+"))
                {
                    Console.Write("(" + a + "," + d + ")");
                    Boardshow[a, d] = go;

                }


            }
            for (d = b - 1; d >= 0; d--)
            {
                if (Board[a, d].getname().Contains("+") != true)
                {
                    if (FOE(Board[a, b], Board[a, d]))
                    {
                        Console.Write("(" + a + "," + d + ")");
                    }
                    break;
                }
                if (Board[a, d].getname().Contains("+"))
                {
                    Console.Write("(" + a + "," + d + ")");
                    Boardshow[a, d] = go;
                }
            }
            for (c = a + 1; c < 10; c++)
            {
                if (Board[c, b].getname().Contains("+") != true)
                {
                    if (FOE(Board[a, b], Board[c, b]))
                    {
                        Console.Write("(" + c + "," + b + ")");
                    }
                    break;
                }
                if (Board[c, b].getname().Contains("+"))
                {
                    Console.Write("(" + c + "," + b + ")");
                    Boardshow[c, b] = go;
                }
            }
            for (c = a - 1; c >= 0; c--)
            {

                if (Board[c, b].getname().Contains("+") != true)
                {
                    if (FOE(Board[a, b], Board[c, b]))
                    {
                        Console.Write("(" + c + "," + b + ")");
                    }
                    break;
                }
                if (Board[c, b].getname().Contains("+"))
                {
                    Console.Write("(" + c + "," + b + ")");
                    Boardshow[c, b] = go;
                }
            }
        }

        public static void mamovefunction(Chess[,] Boardshow, Chess[,] Board, string str1, Chess go)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Board[i, j].getname().Contains(str1))
                    {
                        a = i;
                        b = j;
                        break;
                    }
                }
            }
            Console.Write("You can go : ");

            //down

            if (a + 1 >= 0 && a + 1 <= 9 && b >= 0 && b <= 8)
            {
                if (Board[a + 1, b].getname().Contains("+"))
                {
                    if (a + 2 >= 0 && a + 2 <= 9 && b - 1 >= 0 && b - 1 <= 8)
                    {
                        c = a + 2;
                        d = b - 1;

                        if (Board[c, d].getname().Contains("+") != true)
                        {
                            if (FOE(Board[a, b], Board[c, d]))
                            {

                                Console.Write("(" + c + "," + d + ")");
                            }

                        }
                        if (Board[c, d].getname().Contains("+"))
                        {

                            Console.Write("(" + c + "," + d + ")");
                            Boardshow[c, d] = go;
                        }
                    }
                    if (a + 2 >= 0 && a + 2 <= 9 && b + 1 >= 0 && b + 1 <= 8)
                    {
                        c = a + 2;
                        d = b + 1;
                        if (Board[c, d].getname().Contains("+") != true)
                        {
                            if (FOE(Board[a, b], Board[c, d]))
                            {


                                Console.Write("(" + c + "," + d + ")");
                            }

                        }
                        if (Board[c, d].getname().Contains("+"))
                        {

                            Console.Write("(" + c + "," + d + ")");
                            Boardshow[c, d] = go;
                        }
                    }


                }
            }
            

            //up

            if (a - 1 >= 0 && a - 1 <= 9 && b >= 0 && b <= 8)
            {
                if (Board[a - 1, b].getname().Contains("+"))
                {
                    if (a - 2 >= 0 && a - 2 <= 9 && b - 1 >= 0 && b - 1 <= 8)
                    {
                        c = a - 2;
                        d = b - 1;

                        if (Board[c, d].getname().Contains("+") != true)
                        {
                            if (FOE(Board[a, b], Board[c, d]))
                            {

                                Console.Write("(" + c + "," + d + ")");
                                
                            }

                        }
                        if (Board[c, d].getname().Contains("+"))
                        {

                            Console.Write("(" + c + "," + d + ")");
                            Boardshow[c, d] = go;

                        }
                    }
                    if (a - 2 >= 0 && a - 2 <= 9 && b + 1 >= 0 && b + 1 <= 8)
                    {
                        c = a - 2;
                        d = b + 1;
                        if (Board[c, d].getname().Contains("+") != true)
                        {
                            if (FOE(Board[a, b], Board[c, d]))
                            {


                                Console.Write("(" + c + "," + d + ")");

                            }

                        }
                        if (Board[c, d].getname().Contains("+"))
                        {

                            Console.Write("(" + c + "," + d + ")");
                            Boardshow[c, d] = go;

                        }
                    }


                }
            }



            //right

            if (a >= 0 && a <= 9 && b + 1 >= 0 && b + 1 <= 8)
            {
                if (Board[a, b + 1].getname().Contains("+"))
                {
                    if (a + 1 >= 0 && a + 1 <= 9 && b + 2 >= 0 && b + 2 <= 8)
                    {
                        c = a + 1;
                        d = b + 2;

                        if (Board[c, d].getname().Contains("+") != true)
                        {
                            if (FOE(Board[a, b], Board[c, d]))
                            {

                                Console.Write("(" + c + "," + d + ")");
                            }

                        }
                        if (Board[c, d].getname().Contains("+"))
                        {

                            Console.Write("(" + c + "," + d + ")");
                            Boardshow[c, d] = go;

                        }
                    }
                    if (a - 1 >= 0 && a - 1 <= 9 && b + 2 >= 0 && b + 2 <= 8)
                    {
                        c = a - 1;
                        d = b + 2;
                        if (Board[c, d].getname().Contains("+") != true)
                        {
                            if (FOE(Board[a, b], Board[c, d]))
                            {


                                Console.Write("(" + c + "," + d + ")");
                            }

                        }
                        if (Board[c, d].getname().Contains("+"))
                        {

                            Console.Write("(" + c + "," + d + ")");
                            Boardshow[c, d] = go;

                        }
                    }


                }
            }


            // left

            if (a >= 0 && a <= 9 && b + 1 >= 0 && b + 1 <= 8)
            {
                if (Board[a, b - 1].getname().Contains("+"))
                {
                    if (a + 1 >= 0 && a + 1 <= 9 && b - 2 >= 0 && b - 2 <= 8)
                    {
                        c = a + 1;
                        d = b - 2;

                        if (Board[c, d].getname().Contains("+") != true)
                        {
                            if (FOE(Board[a, b], Board[c, d]))
                            {

                                Console.Write("(" + c + "," + d + ")");
                            }

                        }
                        if (Board[c, d].getname().Contains("+"))
                        {

                            Console.Write("(" + c + "," + d + ")");
                            Boardshow[c, d] = go;

                        }
                    }
                    if (a - 1 >= 0 && a - 1 <= 9 && b - 2 >= 0 && b - 2 <= 8)
                    {
                        c = a - 1;
                        d = b - 2;
                        if (Board[c, d].getname().Contains("+") != true)
                        {
                            if (FOE(Board[a, b], Board[c, d]))
                            {


                                Console.Write("(" + c + "," + d + ")");
                            }

                        }
                        if (Board[c, d].getname().Contains("+"))
                        {

                            Console.Write("(" + c + "," + d + ")");
                            Boardshow[c, d] = go;

                        }
                    }


                }
            }
            
        }

        public static void xiangmovefunction(Chess[,] Boardshow, Chess[,] Board, string str1, Chess go)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Board[i, j].getname().Contains(str1))
                    {
                        a = i;
                        b = j;
                        break;
                    }
                }
            }
            Console.Write("You can go : ");

            if (Board[a, b].getcolor() == "red")
            {
                if (a + 2 >= 0 && a + 2 <= 4 && b + 2 >= 0 && b + 2 <= 8)
                {
                    c = a + 2;
                    d = b + 2;
                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {
                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }

                }
            }
            if (Board[a, b].getcolor() == "red")
            {
                if (a + 2 >= 0 && a + 2 <= 4 && b - 2 >= 0 && b - 2 <= 8)
                {
                    c = a + 2;
                    d = b - 2;
                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {
                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }

                }
            }
            if (Board[a, b].getcolor() == "red")
            {
                if (a - 2 >= 0 && a - 2 <= 4 && b + 2 >= 0 && b + 2 <= 8)
                {
                    c = a - 2;
                    d = b + 2;
                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {
                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }

                }
            }
            if (Board[a, b].getcolor() == "red")
            {
                if (a - 2 >= 0 && a - 2 <= 4 && b - 2 >= 0 && b - 2 <= 8)
                {
                    c = a - 2;
                    d = b - 2;
                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {
                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }

                }
            }



            if (Board[a, b].getcolor() == "black")
            {
                if (a + 2 >= 5 && a + 2 <= 9 && b + 2 >= 0 && b + 2 <= 8)
                {
                    c = a + 2;
                    d = b + 2;
                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {
                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }

                }
            }
            if (Board[a, b].getcolor() == "black")
            {
                if (a + 2 >= 5 && a + 2 <= 9 && b - 2 >= 0 && b - 2 <= 8)
                {
                    c = a + 2;
                    d = b - 2;
                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {
                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }

                }
            }
            if (Board[a, b].getcolor() == "black")
            {
                if (a - 2 >= 5 && a - 2 <= 9 && b + 2 >= 0 && b + 2 <= 8)
                {
                    c = a - 2;
                    d = b + 2;
                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {
                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }

                }
            }
            if (Board[a, b].getcolor() == "black")
            {
                if (a - 2 >= 5 && a - 2 <= 9 && b - 2 >= 0 && b - 2 <= 8)
                {
                    c = a - 2;
                    d = b - 2;
                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }

                }
            }
        }


        public static void shimovefunction(Chess[,] Boardshow, Chess[,] Board, string str1, Chess go)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Board[i, j].getname().Contains(str1))
                    {
                        a = i;
                        b = j;
                        break;
                    }
                }
            }
            Console.Write("You can go : ");

            if (Board[a, b].getcolor() == "red")
            {
                if (a + 1 >= 0 && a + 1 <= 2 && b + 1 >= 3 && b + 1 <= 5)
                {
                    c = a + 1;
                    d = b + 1;
                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }

                }
                if (a + 1 >= 0 && a + 1 <= 2 && b - 1 >= 3 && b - 1 <= 5)
                {
                    c = a + 1;
                    d = b - 1;
                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }

                }
                if (a - 1 >= 0 && a - 1 <= 2 && b + 1 >= 3 && b + 1 <= 5)
                {
                    c = a - 1;
                    d = b + 1;
                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }

                }
                if (a - 1 >= 0 && a - 1 <= 2 && b - 1 >= 3 && b - 1 <= 5)
                {
                    c = a - 1;
                    d = b - 1;
                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }

                }

            }

            if (Board[a, b].getcolor() == "black")
            {
                if (a + 1 >= 7 && a + 1 <= 9 && b + 1 >= 3 && b + 1 <= 5)
                {
                    c = a + 1;
                    d = b + 1;
                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }

                }
                if (a + 1 >= 7 && a + 1 <= 9 && b - 1 >= 3 && b - 1 <= 5)
                {
                    c = a + 1;
                    d = b - 1;
                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }

                }
                if (a - 1 >= 7 && a - 1 <= 9 && b + 1 >= 3 && b + 1 <= 5)
                {
                    c = a - 1;
                    d = b + 1;
                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }

                }
                if (a - 1 >= 7 && a - 1 <= 9 && b - 1 >= 3 && b - 1 <= 5)
                {
                    c = a - 1;
                    d = b - 1;
                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }

                }

            }
        }

        public static void shuaimovefunction(Chess[,] Boardshow, Chess[,] Board, string str1, Chess go)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Board[i, j].getname().Contains(str1))
                    {
                        a = i;
                        b = j;
                        break;
                    }
                }
            }
            Console.Write("You can go : ");

            if (a + 1 >= 0 && a + 1 <= 2 && b >= 3 && b <= 5)
            {
                c = a + 1;
                d = b;

                if (Board[c, d].getname().Contains("+") != true)
                {
                    if (FOE(Board[a, b], Board[c, d]))
                    {
                        Console.Write("(" + c + "," + d + ")");
                    }

                }
                if (Board[c, d].getname().Contains("+"))
                {

                    Console.Write("(" + c + "," + d + ")");
                    Boardshow[c, d] = go;
                }

            }
            if (a - 1 >= 0 && a - 1 <= 2 && b >= 3 && b <= 5)
            {
                c = a - 1;
                d = b;

                if (Board[c, d].getname().Contains("+") != true)
                {
                    if (FOE(Board[a, b], Board[c, d]))
                    {
                        Console.Write("(" + c + "," + d + ")");
                    }

                }
                if (Board[c, d].getname().Contains("+"))
                {

                    Console.Write("(" + c + "," + d + ")");
                    Boardshow[c, d] = go;
                }

            }
            if (a >= 0 && a <= 2 && b + 1 >= 3 && b + 1 <= 5)
            {
                c = a;
                d = b + 1;

                if (Board[c, d].getname().Contains("+") != true)
                {
                    if (FOE(Board[a, b], Board[c, d]))
                    {
                        Console.Write("(" + c + "," + d + ")");
                    }

                }
                if (Board[c, d].getname().Contains("+"))
                {

                    Console.Write("(" + c + "," + d + ")");
                    Boardshow[c, d] = go;
                }

            }
            if (a >= 0 && a <= 2 && b - 1 >= 3 && b - 1 <= 5)
            {
                c = a;
                d = b - 1;

                if (Board[c, d].getname().Contains("+") != true)
                {
                    if (FOE(Board[a, b], Board[c, d]))
                    {
                        Console.Write("(" + c + "," + d + ")");
                    }

                }
                if (Board[c, d].getname().Contains("+"))
                {

                    Console.Write("(" + c + "," + d + ")");
                    Boardshow[c, d] = go;
                }

            }
        }

        public static void jiangmovefunction(Chess[,] Boardshow, Chess[,] Board, string str1, Chess go)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Board[i, j].getname().Contains(str1))
                    {
                        a = i;
                        b = j;
                        break;
                    }
                }
            }
            Console.Write("You can go : ");

            if (a + 1 >= 7 && a + 1 <= 9 && b >= 3 && b <= 5)
            {
                c = a + 1;
                d = b;

                if (Board[c, d].getname().Contains("+") != true)
                {
                    if (FOE(Board[a, b], Board[c, d]))
                    {
                        Console.Write("(" + c + "," + d + ")");
                    }

                }
                if (Board[c, d].getname().Contains("+"))
                {

                    Console.Write("(" + c + "," + d + ")");
                    Boardshow[c, d] = go;
                }

            }
            if (a - 1 >= 7 && a - 1 <= 9 && b >= 3 && b <= 5)
            {
                c = a - 1;
                d = b;

                if (Board[c, d].getname().Contains("+") != true)
                {
                    if (FOE(Board[a, b], Board[c, d]))
                    {
                        Console.Write("(" + c + "," + d + ")");
                    }

                }
                if (Board[c, d].getname().Contains("+"))
                {

                    Console.Write("(" + c + "," + d + ")");
                    Boardshow[c, d] = go;
                }

            }
            if (a >= 7 && a <= 9 && b + 1 >= 3 && b + 1 <= 5)
            {
                c = a;
                d = b + 1;

                if (Board[c, d].getname().Contains("+") != true)
                {
                    if (FOE(Board[a, b], Board[c, d]))
                    {
                        Console.Write("(" + c + "," + d + ")");
                    }

                }
                if (Board[c, d].getname().Contains("+"))
                {

                    Console.Write("(" + c + "," + d + ")");
                    Boardshow[c, d] = go;
                }

            }
            if (a >= 7 && a <= 9 && b - 1 >= 3 && b - 1 <= 5)
            {
                c = a;
                d = b - 1;

                if (Board[c, d].getname().Contains("+") != true)
                {
                    if (FOE(Board[a, b], Board[c, d]))
                    {
                        Console.Write("(" + c + "," + d + ")");
                    }

                }
                if (Board[c, d].getname().Contains("+"))
                {

                    Console.Write("(" + c + "," + d + ")");
                    Boardshow[c, d] = go;
                }

            }
        }

        public static void bingmovefunction(Chess[,] Boardshow, Chess[,] Board, string str1, Chess go)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Board[i, j].getname().Contains(str1))
                    {
                        a = i;
                        b = j;
                        break;
                    }
                }
            }

            Console.Write("You can go : ");
            if (Board[a, b].getcolor() == "red")
            {

                if (a >= 3 && a <= 4 && b >= 0 && b <= 8)
                {
                    c = a + 1;
                    d = b;

                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }
                }
                if (a >= 5 && a <= 9 && b >= 0 && b <= 8)
                {
                    c = a + 1;
                    d = b;

                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }
                }
                if (a >= 5 && a <= 9 && b + 1 >= 0 && b + 1 <= 8)
                {
                    c = a;
                    d = b + 1;

                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }
                }

                if (a >= 5 && a <= 9 && b - 1 >= 0 && b - 1 <= 8)
                {
                    c = a;
                    d = b - 1;

                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }
                }
            }
            if (Board[a, b].getcolor() == "black")
            {

                if (a >= 5 && a <= 6 && b >= 0 && b <= 8)
                {
                    c = a - 1;
                    d = b;

                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }
                }
                if (a >= 0 && a <= 4 && b >= 0 && b <= 8)
                {
                    c = a - 1;
                    d = b;

                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }
                }
                if (a >= 0 && a <= 4 && b + 1 >= 0 && b + 1 <= 8)
                {
                    c = a;
                    d = b + 1;

                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }
                }

                if (a >= 0 && a <= 4 && b - 1 >= 0 && b - 1 <= 8)
                {
                    c = a;
                    d = b - 1;

                    if (Board[c, d].getname().Contains("+") != true)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            Console.Write("(" + c + "," + d + ")");
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        Console.Write("(" + c + "," + d + ")");
                        Boardshow[c, d] = go;
                    }
                }
            }
        }

        public static void paomovefunction(Chess[,] Boardshow, Chess[,] Board, string str1, Chess go)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Board[i, j].getname().Contains(str1))
                    {
                        a = i;
                        b = j;
                        break;
                    }
                }
            }
            Console.Write("You can go : ");
            for (d = b + 1; d < 9; d++)
            {
                if (Board[a, d].getname().Contains("+") != true)
                {

                    for (int i = d + 1; i <= 8; d = i++)
                    {
                        if (Board[a, i].getname().Contains("+") != true)
                        {
                            if (FOE(Board[a, b], Board[a, i]))
                            {
                                Console.Write("(" + a + "," + i + ")");
                            }
                            break;
                        }

                    }

                    break;
                }
                if (Board[a, d].getname().Contains("+"))
                {
                    Console.Write("(" + a + "," + d + ")");
                    Boardshow[a, d] = go;

                }


            }
            for (d = b - 1; d >= 0; d--)
            {
                if (Board[a, d].getname().Contains("+") != true)
                {
                    
                    for (int i = d - 1; i >= 0; i--)
                    {
                        
                        if (Board[a, i].getname().Contains("+") != true)
                        {
                            if (FOE(Board[a, b], Board[a, i]))
                            {
                                Console.Write("(" + a + "," + i + ")");
                            }
                            break;
                        }


                    }

                    break;
                }
                if (Board[a, d].getname().Contains("+"))
                {
                    Console.Write("(" + a + "," + d + ")");
                    Boardshow[a, d] = go;
                }
            }
            for (c = a + 1; c < 10; c++)
            {
                if (Board[c, b].getname().Contains("+") != true)
                {

                    for (int i = c + 1; i <= 9; i++)
                    {

                        if (Board[i, b].getname().Contains("+") != true)
                        {
                            if (FOE(Board[a, b], Board[i, b]))
                            {
                                Console.Write("(" + i + "," + b + ")");
                            }
                            break;
                        }

                    }

                    break;
                }
                if (Board[c, b].getname().Contains("+"))
                {
                    Console.Write("(" + c + "," + b + ")");
                    Boardshow[c, b] = go;
                }
            }
            for (c = a - 1; c >= 0; c--)
            {

                if (Board[c, b].getname().Contains("+") != true)
                {

                    for (int i = c - 1; i >= 0; i--)
                    {
                        if (Board[i, b].getname().Contains("+") != true)
                        {
                            if (FOE(Board[a, b], Board[i, b]))
                            {
                                Console.Write("(" + i + "," + b + ")");
                            }
                            break;
                        }

                    }

                    break;
                }
                if (Board[c, b].getname().Contains("+"))
                {
                    Console.Write("(" + c + "," + b + ")");
                    Boardshow[c, b] = go;
                }
            }

        }

        public static void canmove(string str1, Chess[,] Board, Chess[,] Boardshow)
        {
            Chess go = new wu("  -   ", "null", 0, 0, true);


            //che
            if (str1.Contains("che"))
            {
                chemovefunction(Boardshow, Board, str1,go);
                ShowBoard(Boardshow);
                Boardequal(Board, Boardshow);

            }

            // ma
            if (str1.Contains("ma"))
            {

                mamovefunction(Boardshow, Board, str1, go);
                ShowBoard(Boardshow);
                Boardequal(Board, Boardshow);


            }

            // xiang
            if (str1.Contains("xiang"))
            {
                xiangmovefunction(Boardshow, Board, str1, go);
                ShowBoard(Boardshow);
                Boardequal(Board, Boardshow);

            }

            // shi


            if (str1.Contains("shi"))
            {
                shimovefunction(Boardshow, Board, str1, go);
                ShowBoard(Boardshow);
                Boardequal(Board, Boardshow);

            }


            if (str1.Contains("shuai"))
            {

                shuaimovefunction(Boardshow, Board, str1, go);
                ShowBoard(Boardshow);
                Boardequal(Board, Boardshow);

            }

            if (str1.Contains("jiang"))
            {
                jiangmovefunction(Boardshow, Board, str1, go);
                ShowBoard(Boardshow);
                Boardequal(Board, Boardshow);


            }



            if (str1.Contains("bing"))
            {
                bingmovefunction(Boardshow, Board, str1, go);
                ShowBoard(Boardshow);
                Boardequal(Board, Boardshow);


            }
            if (str1.Contains("pao"))
            {
                paomovefunction(Boardshow, Board, str1, go);
                ShowBoard(Boardshow);
                Boardequal(Board, Boardshow);


            }

        
        }
    }
}
