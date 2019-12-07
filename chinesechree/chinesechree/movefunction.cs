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
        public static Boolean FOE(Chess chess1, Chess chess2)
        {
            Boolean a = true;
            if (chess1.getcolor() == chess2.getcolor())
            {
                a = false;
            }
            return a;
        }

        public static void kill(Chess chess1)
        {
            chess1.killstate();

        }
        public static void move(int a, int b, int c, int d, Chess[,] Board)
        {
            Chess exchange = new wu("  +   ", "null", 0, 0, true);

            exchange = Board[c, d];
            Board[c, d] = Board[a, b];
            Board[c, d] = exchange;
        }

        public static void canmove(string str1, Chess[,] Board, Chess[,] Boardshow)
        {
            Chess go = new wu("  -   ", "null", 0, 0, true);
            if (str1.Contains("che"))
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

                ShowBoard(Boardshow);
                Boardshow = Board;

            }

            if (str1.Contains("ma"))
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
                if (a >= 0 && a <= 9 && b >= 0 && b <= 8)
                {
                    if(a+1 >= 0 && a+1 <= 9 && b >= 0 && b <= 8)
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

                                }
                            }
                            if (a + 2 >= 0 && a + 2 <= 9 && b+1 >= 0 && b+1 <= 8)
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
                      
                                }
                            }
                                
                            
                        }
                    }
                    
                }
                //up
                if (a >= 0 && a <= 9 && b >= 0 && b <= 8)
                {
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

                                }
                            }


                        }
                    }

                }

                //right
                if (a >= 0 && a <= 9 && b >= 0 && b <= 8)
                {
                    if (a  >= 0 && a <= 9 && b +1 >= 0 && b+1 <= 8)
                    {
                        if (Board[a , b+1].getname().Contains("+"))
                        {
                            if (a + 1 >= 0 && a + 1 <= 9 && b + 2 >= 0 && b + 2 <= 8)
                            {
                                c = a + 1;
                                d = b + 2;

                                if (Board[c, d ].getname().Contains("+") != true)
                                {
                                    if (FOE(Board[a, b], Board[c, d]))
                                    {

                                        Console.Write("(" + c + "," + d + ")");
                                    }

                                }
                                if (Board[c, d].getname().Contains("+"))
                                {

                                    Console.Write("(" + c + "," + d + ")");

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

                                }
                            }


                        }
                    }

                }

                // left
                if (a >= 0 && a <= 9 && b >= 0 && b <= 8)
                {
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

                                }
                            }


                        }
                    }

                }
                
            }
        }
    }
}
