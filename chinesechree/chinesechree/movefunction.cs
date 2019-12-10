using System;
using System.Collections;
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
        public static void Move(string str1, string str2, Chess[,] Board)
        {
            string[] sArray = str1.Split(',');
            int a = Convert.ToInt32(sArray[0]);
            int b = Convert.ToInt32(sArray[1]);

            string[] ssArray = str2.Split(',');
            int c = Convert.ToInt32(ssArray[0]);
            int d = Convert.ToInt32(ssArray[1]);

            

            if (Board[c, d] == null )
            {
                Board[c, d] = Board[a, b];

                Board[a, b] = null;
            }

            else
            {
                Kill(Board[c, d]);

                Board[c, d] = Board[a, b];

                Board[a, b] = null;

            }

        }

        public static ArrayList chemovefunction(int a, int b, Chess[,] Board, ArrayList position)
        {

            //Console.Write("You can go : ");
            int c;
            int d;
            for (d = b + 1; d < 9; d++)
            {
                if (Board[a, d] != null)
                {
                    if (FOE(Board[a, b], Board[a, d]))
                    {
                        Console.Write("(" + a + "," + d + ")");
                        position.Add(a + "," + d);
                    }

                    break;
                }
                if (Board[a, d] == null)
                {
                    Console.Write("(" + a + "," + d + ")");
                    position.Add(a + "," + d);

                }


            }
            for (d = b - 1; d >= 0; d--)
            {
                if (Board[a, d] != null)
                {
                    if (FOE(Board[a, b], Board[a, d]))
                    {
                        Console.Write("(" + a + "," + d + ")");
                        position.Add(a + "," + d);
                    }
                    break;
                }
                if (Board[a, d] == null)
                {
                    Console.Write("(" + a + "," + d + ")");
                    position.Add(a + "," + d);
                }
            }
                for (c = a + 1; c < 10; c++)
                {
                    if (Board[c, b] != null)
                    {
                        if (FOE(Board[a, b], Board[c, b]))
                        {
                            Console.Write("(" + c + "," + b + ")");
                            position.Add(c + "," + b);

                        }
                        break;
                    }
                    if (Board[c, b] == null)
                    {
                        Console.Write("(" + c + "," + b + ")");
                        position.Add(c + "," + b);
                    }
                }
                for (c = a - 1; c >= 0; c--)
                {

                    if (Board[c, b] != null)
                    {
                        if (FOE(Board[a, b], Board[c, b]))
                        {
                            Console.Write("(" + c + "," + b + ")");
                            position.Add(c + "," + b);

                        }
                        break;
                    }
                    if (Board[c, b] == null)
                    {
                        Console.Write("(" + c + "," + b + ")");
                        position.Add(c + "," + b);
                    }
                }
            for (int i = 0; i < position.Count; i++)
            {
                Console.Write(position[i]);
            }

            return position;
        }
            
        
        public static void mamovefunction(Chess[,] Board, string str1, ArrayList position)
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
            //Console.Write("You can go : ");

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

                                //Console.Write("(" + c + "," + d + ")");
                                position.Add(c + "," + d);
                            }

                        }
                        if (Board[c, d].getname().Contains("+"))
                        {

                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }
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


                                //Console.Write("(" + c + "," + d + ")");
                                position.Add(c + "," + d);
                            }

                        }
                        if (Board[c, d].getname().Contains("+"))
                        {

                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
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

                                    //Console.Write("(" + c + "," + d + ")");
                                    position.Add(c + "," + d);
                                }

                            }
                            if (Board[c, d].getname().Contains("+"))
                            {

                                //Console.Write("(" + c + "," + d + ")");
                                position.Add(c + "," + d);
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


                                    //Console.Write("(" + c + "," + d + ")");
                                    position.Add(c + "," + d);
                                }

                            }
                            if (Board[c, d].getname().Contains("+"))
                            {

                                //Console.Write("(" + c + "," + d + ")");
                                position.Add(c + "," + d);
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

                                    //Console.Write("(" + c + "," + d + ")");
                                    position.Add(c + "," + d);
                                }

                            }
                            if (Board[c, d].getname().Contains("+"))
                            {

                                //Console.Write("(" + c + "," + d + ")");
                                position.Add(c + "," + d);

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

                                    position.Add(c + "," + d);
                                    //Console.Write("(" + c + "," + d + ")");
                                }

                            }
                            if (Board[c, d].getname().Contains("+"))
                            {

                                //Console.Write("(" + c + "," + d + ")");
                                position.Add(c + "," + d);

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
                                    position.Add(c + "," + d);
                                    //Console.Write("(" + c + "," + d + ")");
                                }

                            }
                            if (Board[c, d].getname().Contains("+"))
                            {
                                position.Add(c + "," + d);
                                //Console.Write("(" + c + "," + d + ")");


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
                                    //Console.Write("(" + c + "," + d + ")");
                                    position.Add(c + "," + d);
                                }

                            }
                            if (Board[c, d].getname().Contains("+"))
                            {

                                //Console.Write("(" + c + "," + d + ")");
                                position.Add(c + "," + d);

                            }
                        } 


                    }
                }

            }
        

        public static void xiangmovefunction(Chess[,] Board, string str1, ArrayList position)
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                        
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                      
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                        
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                      
                    }

                }
            }
        }


        public static void shimovefunction(Chess[,] Board, string str1, ArrayList position)
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                        
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                        
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                        
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                        
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }

            }
        }

        public static void shuaimovefunction(Chess[,] Board, string str1, ArrayList position)
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
            //Console.Write("You can go : ");

            if (a + 1 >= 0 && a + 1 <= 2 && b >= 3 && b <= 5)
            {
                c = a + 1;
                d = b;

                if (Board[c, d].getname().Contains("+") != true)
                {
                    if (FOE(Board[a, b], Board[c, d]))
                    {
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (Board[c, d].getname().Contains("+"))
                {

                    //Console.Write("(" + c + "," + d + ")");
                    position.Add(c + "," + d);
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
                        // Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (Board[c, d].getname().Contains("+"))
                {

                    //Console.Write("(" + c + "," + d + ")");
                    position.Add(c + "," + d);
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
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (Board[c, d].getname().Contains("+"))
                {

                    //Console.Write("(" + c + "," + d + ")");
                    position.Add(c + "," + d);
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
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (Board[c, d].getname().Contains("+"))
                {

                    //Console.Write("(" + c + "," + d + ")");
                    position.Add(c + "," + d);
                
                }

            }
        }

        public static void jiangmovefunction(Chess[,] Board, string str1, ArrayList position)
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
            //Console.Write("You can go : ");

            if (a + 1 >= 7 && a + 1 <= 9 && b >= 3 && b <= 5)
            {
                c = a + 1;
                d = b;

                if (Board[c, d].getname().Contains("+") != true)
                {
                    if (FOE(Board[a, b], Board[c, d]))
                    {
                        // Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (Board[c, d].getname().Contains("+"))
                {

                    //Console.Write("(" + c + "," + d + ")");
                    position.Add(c + "," + d);
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
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (Board[c, d].getname().Contains("+"))
                {

                    //Console.Write("(" + c + "," + d + ")");
                    position.Add(c + "," + d);
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
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (Board[c, d].getname().Contains("+"))
                {

                    //Console.Write("(" + c + "," + d + ")");
                    position.Add(c + "," + d);
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
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (Board[c, d].getname().Contains("+"))
                {

                    //Console.Write("(" + c + "," + d + ")");
                    position.Add(c + "," + d);
                   
                }

            }
        }

        public static void bingmovefunction(Chess[,] Board, string str1, ArrayList position)
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

            //Console.Write("You can go : ");
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                        
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                       // Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        // Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                        
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        //  Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
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
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d].getname().Contains("+"))
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }
                }
            }
        }

        public static void paomovefunction(Chess[,] Board, string str1, ArrayList position)
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
            //Console.Write("You can go : ");
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
                                //Console.Write("(" + a + "," + i + ")");
                                position.Add(c + "," + d);
                            }
                            break;
                        }

                    }

                    break;
                }
                if (Board[a, d].getname().Contains("+"))
                {
                    //Console.Write("(" + a + "," + d + ")");
                    position.Add(c + "," + d);

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
                                //Console.Write("(" + a + "," + i + ")");
                                position.Add(c + "," + d);
                            }
                            break;
                        }


                    }

                    break;
                }
                if (Board[a, d].getname().Contains("+"))
                {
                    //Console.Write("(" + a + "," + d + ")");
                    position.Add(c + "," + d);
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
                                //Console.Write("(" + i + "," + b + ")");
                                position.Add(c + "," + d);
                            }
                            break;
                        }

                    }

                    break;
                }
                if (Board[c, b].getname().Contains("+"))
                {
                    //Console.Write("(" + c + "," + b + ")");
                    position.Add(c + "," + d); ;
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
                                //Console.Write("(" + i + "," + b + ")");
                                position.Add(c + "," + d);
                            }
                            break;
                        }

                    }

                    break;
                }
                if (Board[c, b].getname().Contains("+"))
                {
                    //Console.Write("(" + c + "," + b + ")");
                    position.Add(c + "," + d);
                }
            }

        }

        public static void canmove(string str, Chess[,] Board,gameBoard Gameboard)
        {
            string[] sArray = str.Split(',');
            int a = Convert.ToInt32(sArray[0]);
            int b = Convert.ToInt32(sArray[1]);

            string str1 = Board[a, b].getname();

            ArrayList position = new ArrayList();

            //che
            if (str1.Contains("车"))
            {
                
                chemovefunction(a,b,Board,position);
                Gameboard.Showmove(position);
               

            
            }

            // ma
            if (str1.Contains("马"))
            {

                mamovefunction(Board, str1, position);

            }

            // xiang
            if (str1.Contains("像") || str1.Contains("相"))
            {
                xiangmovefunction(Board, str1, position);

            }

            // shi


            if (str1.Contains("仕") || str1.Contains("士"))
            {
                shimovefunction(Board, str1, position);
             

            }


            if (str1.Contains("帅"))
            {

                shuaimovefunction(Board, str1, position);
     

            }

            if (str1.Contains("将"))
            {
                jiangmovefunction(Board, str1, position);
 
            }



            if (str1.Contains("兵") || str1.Contains("卒"))
            {
                bingmovefunction(Board, str1, position);

            }
            if (str1.Contains("炮"))
            {
                paomovefunction(Board, str1, position);

            }

        
        }
    }
}
