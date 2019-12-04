using System;
using static Chinesechess.MainClass.Chess;

namespace Chinesechess
{
    class MainClass
    {
        public abstract class Chess
        {
            public string Name;
            public string Color;
            public int i;
            public int j;
            public Boolean state;
            public string Job;

            public Chess(string Name, string Color, int i, int j, bool state, string Job)
            {
                this.Name = Name;
                this.Color = Color;
                this.i = i;
                this.j = j;
                this.state = state;

            }
            public class shuai : Chess
            {
                public shuai(string Name, string Color, int i, int j, bool state)
                    : base(Name, Color, i, j, true, "shuai") { }

            }
            public class shi : Chess
            {
                public shi(string Name, string Color, int i, int j, bool state)
                    : base(Name, Color, i, j, true, "shi") { }
            }
            public class xiang : Chess
            {
                public xiang(string Name, string Color, int i, int j, bool state)
                    : base(Name, Color, i, j, true, "xiang") { }
            }
            public class ma : Chess
            {
                public ma(string Name, string Color, int i, int j, bool state)
                    : base(Name, Color, i, j, true, "ma") { }
            }
            public class che : Chess
            {
                public che(string Name, string Color, int i, int j, bool state)
                    : base(Name, Color, i, j, true, "che") { }
            }
            public class pao : Chess
            {
                public pao(string Name, string Color, int i, int j, bool state)
                    : base(Name, Color, i, j, true, "pao") { }
            }
            public class bing : Chess
            {
                public bing(string Name, string Color, int i, int j, bool state)
                    : base(Name, Color, i, j, true, "bing") { }
            }
            public class jiang : Chess
            {
                public jiang(string Name, string Color, int i, int j, bool state)
                    : base(Name, Color, i, j, true, "jiang") { }

            }

            public int geti()
            {
                return i;
            }
            public int getj()
            {
                return j;
            }
            public string getname()
            {
                return Name;
            }
            public bool getstate()
            {
                return state;
            }

            public void Introduciton()
            {
                Console.WriteLine($"Hi,I'm {Name}, {Color},live in ({i},{j}),{state}");

            }

        }

        public static void GameBoard(string[,] Board)
        {


            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Board[i, j] = "+";
                }
            }

        }

        public static void ShowBoard(string[,] Board)
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("  " + Board[i, j] + "  ");
                }
            }
        }

        public static void Main(string[] args)
        {
            string[,] Board = new string[9, 10];

            GameBoard(Board);

            Chess che1 = new che(" che1 ", "red", 0, 0, true);
            Chess ma1 = new ma(" ma1  ", "red", 1, 0, true);
            Chess xiang1 = new xiang("xiang1", "red", 2, 0, true);
            Chess shi1 = new shi(" she1 ", "red", 3, 0, true);
            Chess shuai = new shuai("shuai ", "red", 4, 0, true);
            Chess shi2 = new shi(" she2 ", "red", 5, 0, true);
            Chess xiang2 = new xiang("xiang2", "red", 6, 0, true);
            Chess ma2 = new ma(" ma2  ", "red", 7, 0, true);
            Chess che2 = new che(" che2 ", "red", 8, 0, true);
            Chess pao1 = new pao(" pao1 ", "red", 1, 2, true);
            Chess pao2 = new che(" pao2 ", "red", 7, 2, true);
            Chess bing1 = new bing("bing1 ", "red", 0, 3, true);
            Chess bing2 = new bing("bing2 ", "red", 2, 3, true);
            Chess bing3 = new bing("bing3 ", "red", 4, 3, true);
            Chess bing4 = new bing("bing4 ", "red", 6, 3, true);
            Chess bing5 = new bing("bing5 ", "red", 8, 3, true);

            Chess che3 = new che(" che3 ", "black", 0, 9, true);
            Chess ma3 = new ma(" ma3  ", "black", 1, 9, true);
            Chess xiang3 = new xiang("xiang3 ", "black", 2, 9, true);
            Chess shi3 = new shi(" she3 ", "black", 3, 9, true);
            Chess jiang = new shuai("jiang ", "black", 4, 9, true);
            Chess shi4 = new shi(" she4 ", "black", 5, 9, true);
            Chess xiang4 = new xiang("xiang4 ", "black", 6, 9, true);
            Chess ma4 = new ma(" ma4  ", "black", 7, 9, true);
            Chess che4 = new che(" che4 ", "black", 8, 9, true);
            Chess pao3 = new pao(" pao3 ", "black", 1, 7, true);
            Chess pao4 = new che(" pao4 ", "black", 7, 7, true);
            Chess bing6 = new bing("bing6 ", "black", 0, 6, true);
            Chess bing7 = new bing("bing7 ", "black", 2, 6, true);
            Chess bing8 = new bing("bing8 ", "black", 4, 6, true);
            Chess bing9 = new bing("bing9 ", "black", 6, 6, true);
            Chess bing10 = new bing("bing10", "black", 8, 6, true);

            restart(che1, Board);
            restart(ma1, Board);
            restart(xiang1, Board);
            restart(shi1, Board);
            restart(shuai, Board);
            restart(shi2, Board);
            restart(xiang2, Board);
            restart(ma2, Board);
            restart(che2, Board);
            restart(pao1, Board);
            restart(pao2, Board);
            restart(bing1, Board);
            restart(bing2, Board);
            restart(bing3, Board);
            restart(bing4, Board);
            restart(bing5, Board);

            restart(che3, Board);
            restart(ma3, Board);
            restart(xiang3, Board);
            restart(shi3, Board);
            restart(jiang, Board);
            restart(shi4, Board);
            restart(xiang4, Board);
            restart(ma4, Board);
            restart(che4, Board);
            restart(pao3, Board);
            restart(pao4, Board);
            restart(bing6, Board);
            restart(bing7, Board);
            restart(bing8, Board);
            restart(bing9, Board);
            restart(bing10, Board);


            ShowBoard(Board);



            while (jiang.getstate() == true || shuai.getstate() == true)
            {
                Console.WriteLine("\nPlayer 1 Choose chress you want to move");
                string str1 = Console.ReadLine();

                if (str1.Contains("che"))
                {
                    int a = 0;
                    int b = 0;
                    int c = 0;
                    int d = 0;

                    for(int i = 0; i < 9; i++)
                    {
                        for(int j = 0; j < 10; j++)
                        {
                            if(Board[i,j] == str1) {
                                a = i;
                                b = j;
                                break; }
                        }
                    }
                    Console.Write("You can go : ");
                        
                        for (d = b+1; d < 10; d++)
                        {
                        if (Board[a, d].Contains("+") != true)
                        {
                            break;
                        }
                        if (Board[a, d].Contains("+"))
                        {
                            Console.Write("(" + a + "," + d + ")");
                            Board[a, d] = "-";

                        }
                        
                        
                        }
                        for (d = b-1; d >= 0; d--)
                        {
                            if (Board[a,d].Contains("+"))
                            {
                                Console.Write("(" + a + "," + d+")");
                                Board[a, d] = "-";
                            } 
                        }
                        for (c = a+1; c < 9; c++)
                        {
                            if (Board[c,b].Contains("+"))
                            {
                                Console.Write("(" + c + "," + b+")");
                            } 
                        }
                        for (c = a-1; c >= 0; c--)
                        {
                        
                            if (Board[c,b].Contains("+"))
                            {
                                Console.Write("(" + c + "," + b+")");
                            } 
                        }
                        
                        ShowBoard(Board);
                     
                }


                Console.WriteLine("\nPlayer 2 Choose chress you want to move");
                string str2 = Console.ReadLine();

                break;
            }



        }

        private static void restart(Chess chess, string[,] Board)
        {
            int i = chess.geti();
            int j = chess.getj();
            string Name = chess.getname();
            Board[i, j] = Name;
        }
    }
}
