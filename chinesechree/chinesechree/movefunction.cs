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
        public static void Move(string str1, string str2, Chess[,] Board,gameBoard GameBoard)
        {


                string[] sArray = str1.Split(',');
                int a = Convert.ToInt32(sArray[0]);
                int b = Convert.ToInt32(sArray[1]);

                string[] ssArray = str2.Split(',');
                int c = Convert.ToInt32(ssArray[0]);
                int d = Convert.ToInt32(ssArray[1]);



                if (Board[c, d] == null)
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
                GameBoard.move(Board);
                GameBoard.print(Board);

                
                jiangjun(Board);

        }

        public static void jiangjun(Chess[,] Board)
        {
            
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j <9; j++)
                {
                    if(Board[i,j] != null)
                    {
                        if(Board[i,j].getcolor() == "red")
                        {
                            string str = i + "," + j;
                            ArrayList position = canmovejiangjun(str, Board);
                            for (int k = 0; k < position.Count; k++)
                            {
                                string str1 = position[k].ToString();
                                string[] sArray = str1.Split(',');
                                int a = Convert.ToInt32(sArray[0]);
                                int b = Convert.ToInt32(sArray[1]);
                                
                                if (Board[a, b] != null)
                                {
                                    if (Board[a, b].getname() == "将")
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("将军");
                                    }
                                }

                            }
                        }
                        if (Board[i, j].getcolor() == "Black")
                        {
                            string str = i + "," + j;
                            ArrayList position = canmovejiangjun(str, Board);
                            for (int k = 0; k < position.Count; k++)
                            {
                                string str1 = position[k].ToString();
                                string[] sArray = str1.Split(',');
                                int a = Convert.ToInt32(sArray[0]) * 2;
                                int b = Convert.ToInt32(sArray[1]) * 2;

                                if (Board[a, b] != null)
                                {
                                    if (Board[a, b].getname() == "将")
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("将军");
                                    }
                                }
                            }
                        }
                    }
                }
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
                        //Console.Write("(" + a + "," + d + ")");
                        position.Add(a + "," + d);
                    }

                    break;
                }
                if (Board[a, d] == null)
                {
                    //Console.Write("(" + a + "," + d + ")");
                    position.Add(a + "," + d);

                }


            }
            for (d = b - 1; d >= 0; d--)
            {
                if (Board[a, d] != null)
                {
                    if (FOE(Board[a, b], Board[a, d]))
                    {
                        //Console.Write("(" + a + "," + d + ")");
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
                            //Console.Write("(" + c + "," + b + ")");
                            position.Add(c + "," + b);

                        }
                        break;
                    }
                    if (Board[c, b] == null)
                    {
                        //Console.Write("(" + c + "," + b + ")");
                        position.Add(c + "," + b);
                    }
                }
                for (c = a - 1; c >= 0; c--)
                {

                    if (Board[c, b] != null)
                    {
                        if (FOE(Board[a, b], Board[c, b]))
                        {
                            //Console.Write("(" + c + "," + b + ")");
                            position.Add(c + "," + b);

                        }
                        break;
                    }
                    if (Board[c, b] == null)
                    {
                        //Console.Write("(" + c + "," + b + ")");
                        position.Add(c + "," + b);
                    }
                }
           

            return position;
        }
            
        
        public static ArrayList mamovefunction(int a, int b, Chess[,] Board, ArrayList position)
        {
            
            int c ;
            int d ;

            
            //Console.Write("You can go : ");

            //down

            if (a + 1 >= 0 && a + 1 <= 9 && b >= 0 && b <= 8)
            {
                if (Board[a + 1, b] == null)
                {
                    if (a + 2 >= 0 && a + 2 <= 9 && b - 1 >= 0 && b - 1 <= 8)
                    {
                        c = a + 2;
                        d = b - 1;

                        if (Board[c, d] != null)
                        {
                            if (FOE(Board[a, b], Board[c, d]))
                            {

                                //Console.Write("(" + c + "," + d + ")");
                                position.Add(c + "," + d);
                            }

                        }
                        if (Board[c, d] == null)
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
                        if (Board[c, d] != null)
                        {
                            if (FOE(Board[a, b], Board[c, d]))
                            {


                                //Console.Write("(" + c + "," + d + ")");
                                position.Add(c + "," + d);
                            }

                        }
                        if (Board[c, d] == null)
                        {

                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }


                    }
                }


                //up

                if (a - 1 >= 0 && a - 1 <= 9 && b >= 0 && b <= 8)
                {
                    if (Board[a - 1, b] == null)
                    {
                        if (a - 2 >= 0 && a - 2 <= 9 && b - 1 >= 0 && b - 1 <= 8)
                        {
                            c = a - 2;
                            d = b - 1;

                            if (Board[c, d] != null)
                            {
                                if (FOE(Board[a, b], Board[c, d]))
                                {

                                    //Console.Write("(" + c + "," + d + ")");
                                    position.Add(c + "," + d);
                                }

                            }
                            if (Board[c, d] == null)
                            {

                                //Console.Write("(" + c + "," + d + ")");
                                position.Add(c + "," + d);
                            }
                        }
                        if (a - 2 >= 0 && a - 2 <= 9 && b + 1 >= 0 && b + 1 <= 8)
                        {
                            c = a - 2;
                            d = b + 1;
                            if (Board[c, d] != null)
                            {
                                if (FOE(Board[a, b], Board[c, d]))
                                {


                                    //Console.Write("(" + c + "," + d + ")");
                                    position.Add(c + "," + d);
                                }

                            }
                            if (Board[c, d] == null)
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
                    if (Board[a, b + 1] == null)
                    {
                        if (a + 1 >= 0 && a + 1 <= 9 && b + 2 >= 0 && b + 2 <= 8)
                        {
                            c = a + 1;
                            d = b + 2;

                            if (Board[c, d] != null)
                            {
                                if (FOE(Board[a, b], Board[c, d]))
                                {

                                    //Console.Write("(" + c + "," + d + ")");
                                    position.Add(c + "," + d);
                                }

                            }
                            if (Board[c, d] == null)
                            {

                                //Console.Write("(" + c + "," + d + ")");
                                position.Add(c + "," + d);

                            }
                        }
                        if (a - 1 >= 0 && a - 1 <= 9 && b + 2 >= 0 && b + 2 <= 8)
                        {
                            c = a - 1;
                            d = b + 2;
                            if (Board[c, d] != null)
                            {
                                if (FOE(Board[a, b], Board[c, d]))
                                {

                                    position.Add(c + "," + d);
                                    //Console.Write("(" + c + "," + d + ")");
                                }

                            }
                            if (Board[c, d] == null)
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
                    if (Board[a, b - 1] == null)
                    {
                        if (a + 1 >= 0 && a + 1 <= 9 && b - 2 >= 0 && b - 2 <= 8)
                        {
                            c = a + 1;
                            d = b - 2;

                            if (Board[c, d] != null)
                            {
                                if (FOE(Board[a, b], Board[c, d]))
                                {
                                    position.Add(c + "," + d);
                                    //Console.Write("(" + c + "," + d + ")");
                                }

                            }
                            if (Board[c, d] == null)
                            {
                                position.Add(c + "," + d);
                                //Console.Write("(" + c + "," + d + ")");


                            }
                        }
                        if (a - 1 >= 0 && a - 1 <= 9 && b - 2 >= 0 && b - 2 <= 8)
                        {
                            c = a - 1;
                            d = b - 2;
                            if (Board[c, d] != null)
                            {
                                if (FOE(Board[a, b], Board[c, d]))
                                {
                                    //Console.Write("(" + c + "," + d + ")");
                                    position.Add(c + "," + d);
                                }

                            }
                            if (Board[c, d] == null)
                            {

                                //Console.Write("(" + c + "," + d + ")");
                                position.Add(c + "," + d);

                            }
                        } 


                    }
                }
            return position;

        }
        

        public static ArrayList xiangmovefunction(int a, int b, Chess[,] Board, ArrayList position)
        {
        
            int c ;
            int d ;

       
            //Console.Write("You can go : ");

            if (Board[a, b].getcolor() == "red")
            {
                if (a + 2 >= 0 && a + 2 <= 4 && b + 2 >= 0 && b + 2 <= 8)
                {
                    c = a + 2;
                    d = b + 2;
                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
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
                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
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
                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
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
                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
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
                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
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
                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
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
                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
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
                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                      
                    }

                }
            }
            return position;
        }


        public static ArrayList shimovefunction(int a, int b, Chess[,] Board, ArrayList position)
        {
      
            int c ;
            int d ;

          
            //Console.Write("You can go : ");

            if (Board[a, b].getcolor() == "red")
            {
                if (a + 1 >= 0 && a + 1 <= 2 && b + 1 >= 3 && b + 1 <= 5)
                {
                    c = a + 1;
                    d = b + 1;
                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                        
                    }

                }
                if (a + 1 >= 0 && a + 1 <= 2 && b - 1 >= 3 && b - 1 <= 5)
                {
                    c = a + 1;
                    d = b - 1;
                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (a - 1 >= 0 && a - 1 <= 2 && b + 1 >= 3 && b + 1 <= 5)
                {
                    c = a - 1;
                    d = b + 1;
                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (a - 1 >= 0 && a - 1 <= 2 && b - 1 >= 3 && b - 1 <= 5)
                {
                    c = a - 1;
                    d = b - 1;
                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
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
                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (a + 1 >= 7 && a + 1 <= 9 && b - 1 >= 3 && b - 1 <= 5)
                {
                    c = a + 1;
                    d = b - 1;
                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                        
                    }

                }
                if (a - 1 >= 7 && a - 1 <= 9 && b + 1 >= 3 && b + 1 <= 5)
                {
                    c = a - 1;
                    d = b + 1;
                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                        
                    }

                }
                if (a - 1 >= 7 && a - 1 <= 9 && b - 1 >= 3 && b - 1 <= 5)
                {
                    c = a - 1;
                    d = b - 1;
                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }

            }

            return position;
        }

        public static ArrayList shuaimovefunction(int a, int b, Chess[,] Board, ArrayList position)
        {
       
            int c ;
            int d ;


            //Console.Write("You can go : ");

            if (a + 1 >= 0 && a + 1 <= 2 && b >= 3 && b <= 5)
            {
                c = a + 1;
                d = b;

                if (Board[c, d] != null)
                {
                    if (FOE(Board[a, b], Board[c, d]))
                    {
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (Board[c, d] == null)
                {

                    //Console.Write("(" + c + "," + d + ")");
                    position.Add(c + "," + d);
                }

            }
            if (a - 1 >= 0 && a - 1 <= 2 && b >= 3 && b <= 5)
            {
                c = a - 1;
                d = b;

                if (Board[c, d] != null)
                {
                    if (FOE(Board[a, b], Board[c, d]))
                    {
                        // Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (Board[c, d] == null)
                {

                    //Console.Write("(" + c + "," + d + ")");
                    position.Add(c + "," + d);
                }

            }
            if (a >= 0 && a <= 2 && b + 1 >= 3 && b + 1 <= 5)
            {
                c = a;
                d = b + 1;

                if (Board[c, d] != null)
                {
                    if (FOE(Board[a, b], Board[c, d]))
                    {
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (Board[c, d] == null)
                {

                    //Console.Write("(" + c + "," + d + ")");
                    position.Add(c + "," + d);
                }

            }
            if (a >= 0 && a <= 2 && b - 1 >= 3 && b - 1 <= 5)
            {
                c = a;
                d = b - 1;

                if (Board[c, d] != null)
                {
                    if (FOE(Board[a, b], Board[c, d]))
                    {
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (Board[c, d] == null)
                {

                    //Console.Write("(" + c + "," + d + ")");
                    position.Add(c + "," + d);
                
                }

            }
            return position;
        }

        public static ArrayList jiangmovefunction(int a, int b, Chess[,] Board, ArrayList position)
        {
    
            int c ;
            int d ;

            //Console.Write("You can go : ");

            if (a + 1 >= 7 && a + 1 <= 9 && b >= 3 && b <= 5)
            {
                c = a + 1;
                d = b;

                if (Board[c, d] != null)
                {
                    if (FOE(Board[a, b], Board[c, d]))
                    {
                        // Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (Board[c, d] == null)
                {

                    //Console.Write("(" + c + "," + d + ")");
                    position.Add(c + "," + d);
                }

             }
            if (a - 1 >= 7 && a - 1 <= 9 && b >= 3 && b <= 5)
            {
                c = a - 1;
                d = b;

                if (Board[c, d] != null)
                {
                    if (FOE(Board[a, b], Board[c, d]))
                    {
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (Board[c, d] == null)
                {

                    //Console.Write("(" + c + "," + d + ")");
                    position.Add(c + "," + d);
                }

            }
            if (a >= 7 && a <= 9 && b + 1 >= 3 && b + 1 <= 5)
            {
                c = a;
                d = b + 1;

                if (Board[c, d] != null)
                {
                    if (FOE(Board[a, b], Board[c, d]))
                    {
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (Board[c, d] == null)
                {

                    //Console.Write("(" + c + "," + d + ")");
                    position.Add(c + "," + d);
                }

            }
            if (a >= 7 && a <= 9 && b - 1 >= 3 && b - 1 <= 5)
            {
                c = a;
                d = b - 1;

                if (Board[c, d] != null)
                {
                    if (FOE(Board[a, b], Board[c, d]))
                    {
                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }

                }
                if (Board[c, d] == null)
                {

                    //Console.Write("(" + c + "," + d + ")");
                    position.Add(c + "," + d);
                   
                }

            }
            return position;
        }

        public static ArrayList bingmovefunction(int a, int b, Chess[,] Board, ArrayList position)
        {

            int c ;
            int d ;

      

            //Console.Write("You can go : ");
            if (Board[a, b].getcolor() == "red")
            {

                if (a >= 3 && a <= 4 && b >= 0 && b <= 8)
                {
                    c = a + 1;
                    d = b;

                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }
                }
                if (a >= 5 && a <= 9 && b >= 0 && b <= 8)
                {
                    c = a + 1;
                    d = b;

                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                        
                    }
                }
                if (a >= 5 && a <= 9 && b + 1 >= 0 && b + 1 <= 8)
                {
                    c = a;
                    d = b + 1;

                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
                    {

                       // Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                
                    }
                }

                if (a >= 5 && a <= 9 && b - 1 >= 0 && b - 1 <= 8)
                {
                    c = a;
                    d = b - 1;

                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
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

                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
                    {

                        //  Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }
                }
                if (a >= 0 && a <= 4 && b >= 0 && b <= 8)
                {
                    c = a - 1;
                    d = b;

                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }
                }
                if (a >= 0 && a <= 4 && b + 1 >= 0 && b + 1 <= 8)
                {
                    c = a;
                    d = b + 1;

                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }
                }

                if (a >= 0 && a <= 4 && b - 1 >= 0 && b - 1 <= 8)
                {
                    c = a;
                    d = b - 1;

                    if (Board[c, d] != null)
                    {
                        if (FOE(Board[a, b], Board[c, d]))
                        {
                            //Console.Write("(" + c + "," + d + ")");
                            position.Add(c + "," + d);
                        }

                    }
                    if (Board[c, d] == null)
                    {

                        //Console.Write("(" + c + "," + d + ")");
                        position.Add(c + "," + d);
                    }
                }
            }
            return position;
        }

        public static ArrayList paomovefunction(int a, int b, Chess[,] Board, ArrayList position)
        {

            int c ;
            int d ;

   
            //Console.Write("You can go : ");
            for (d = b + 1; d < 9; d++)
            {
                if (Board[a, d] != null)
                {

                    for (int i = d + 1; i <= 8; d = i++)
                    {
                        if (Board[a, i] != null)
                        {
                            if (FOE(Board[a, b], Board[a, i]))
                            {
                                //Console.Write("(" + a + "," + i + ")");
                                position.Add(a + "," + i);
                            }
                            break;
                        }

                    }

                    break;
                }
                if (Board[a, d] == null)
                {
                    //Console.Write("(" + a + "," + d + ")");
                    position.Add(a + "," + d);

                }


            }
            for (d = b - 1; d >= 0; d--)
            {
                if (Board[a, d] != null)
                {
                    
                    for (int i = d - 1; i >= 0; i--)
                    {
                        
                        if (Board[a, i] != null)
                        {
                            if (FOE(Board[a, b], Board[a, i]))
                            {
                                //Console.Write("(" + a + "," + i + ")");
                                position.Add(a + "," + i);
                            }
                            break;
                        }


                    }

                    break;
                }
                if (Board[a, d] == null)
                {
                    //Console.Write("(" + a + "," + d + ")");
                    position.Add(a + "," + d);
                }
            }
            for (c = a + 1; c < 10; c++)
            {
                if (Board[c, b] != null)
                {

                    for (int i = c + 1; i <= 9; i++)
                    {

                        if (Board[i, b] != null)
                        {
                            if (FOE(Board[a, b], Board[i, b]))
                            {
                                //Console.Write("(" + i + "," + b + ")");
                                position.Add(i + "," + b);
                            }
                            break;
                        }

                    }

                    break;
                }
                if (Board[c, b] == null)
                {
                    //Console.Write("(" + c + "," + b + ")");
                    position.Add(c + "," + b); 
                }
            }
            for (c = a - 1; c >= 0; c--)
            {

                if (Board[c, b] != null)
                {

                    for (int i = c - 1; i >= 0; i--)
                    {
                        if (Board[i, b] != null)
                        {
                            if (FOE(Board[a, b], Board[i, b]))
                            {
                                //Console.Write("(" + i + "," + b + ")");
                                position.Add(i + "," + b);
                            }
                            break;
                        }

                    }

                    break;
                }
                if (Board[c, b] == null)
                {
                    //Console.Write("(" + c + "," + b + ")");
                    position.Add(c + "," + b);
                }
            }
            return position;
        }

        public static ArrayList canmove(string str, Chess[,] Board,gameBoard Gameboard)
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

                mamovefunction(a, b, Board, position);
                Gameboard.Showmove(position);
            }

            // xiang
            if (str1.Contains("像") || str1.Contains("相"))
            {
                xiangmovefunction(a, b, Board, position);
                Gameboard.Showmove(position);
            }

            // shi


            if (str1.Contains("仕") || str1.Contains("士"))
            {
                shimovefunction(a, b, Board, position);
                Gameboard.Showmove(position);

            }


            if (str1.Contains("帅"))
            {

                shuaimovefunction(a, b, Board, position);

                Gameboard.Showmove(position);
            }

            if (str1.Contains("将"))
            {
                jiangmovefunction(a, b, Board, position);
                Gameboard.Showmove(position);
            }



            if (str1.Contains("兵") || str1.Contains("卒"))
            {
                bingmovefunction(a, b, Board, position);
                Gameboard.Showmove(position);

            }
            if (str1.Contains("炮"))
            {
                paomovefunction(a, b, Board, position);
                Gameboard.Showmove(position);

            }

            return position;
        }
        public static ArrayList canmovejiangjun(string str, Chess[,] Board)
        {
            string[] sArray = str.Split(',');
            int a = Convert.ToInt32(sArray[0]);
            int b = Convert.ToInt32(sArray[1]);

            string str1 = Board[a, b].getname();

            ArrayList position = new ArrayList();

            //che
            if (str1.Contains("车"))
            {

                chemovefunction(a, b, Board, position);
         
            }

            // ma
            if (str1.Contains("马"))
            {

                mamovefunction(a, b, Board, position);
     
            }

            // xiang
            if (str1.Contains("像") || str1.Contains("相"))
            {
                xiangmovefunction(a, b, Board, position);

            }

            // shi


            if (str1.Contains("仕") || str1.Contains("士"))
            {
                shimovefunction(a, b, Board, position);
                

            }


            if (str1.Contains("帅"))
            {

                shuaimovefunction(a, b, Board, position);

                
            }

            if (str1.Contains("将"))
            {
                jiangmovefunction(a, b, Board, position);
                
            }



            if (str1.Contains("兵") || str1.Contains("卒"))
            {
                bingmovefunction(a, b, Board, position);
               

            }
            if (str1.Contains("炮"))
            {
                paomovefunction(a, b, Board, position);
          

            }

            return position;
        }
    }
}
