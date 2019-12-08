using System;
using static chinesechree.Classchess;
using static chinesechree.movefunction;

namespace Chinesechess
{
    class MainClass
    {



        public static void GameBoard(Chess wu,Chess[,] Board)
        {


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Board[i, j] = wu;
                }
            }

        }

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
                    Boardshow[i, j] = Board[i,j];
                }
            }
        } 

        public static void Main(string[] args)
        {
            Chess[,] Board = new Chess[10, 9];
            Chess[,] Boardshow = new Chess[10, 9];

            

            Chess che1 = new che(" che1 ", "red", 0, 0, true);
            Chess ma1 = new ma(" ma1  ", "red", 0, 1, true);
            Chess xiang1 = new xiang("xiang1", "red", 0,2, true);
            Chess shi1 = new shi(" shi1 ", "red", 0, 3, true);
            Chess shuai = new shuai("shuai ", "red", 0, 4, true);
            Chess shi2 = new shi(" shi2 ", "red", 0, 5, true);
            Chess xiang2 = new xiang("xiang2", "red", 0, 6, true);
            Chess ma2 = new ma(" ma2  ", "red", 0, 7, true);
            Chess che2 = new che(" che2 ", "red", 0, 8, true);
            Chess pao1 = new pao(" pao1 ", "red", 2, 1, true);
            Chess pao2 = new che(" pao2 ", "red", 2, 7, true);
            Chess bing1 = new bing("bing1 ", "red", 3, 0, true);
            Chess bing2 = new bing("bing2 ", "red", 3, 2, true);
            Chess bing3 = new bing("bing3 ", "red", 3, 4, true);
            Chess bing4 = new bing("bing4 ", "red", 3, 6, true);
            Chess bing5 = new bing("bing5 ", "red", 3, 8, true);

            Chess che3 = new che(" che3 ", "black", 9, 0, true);
            Chess ma3 = new ma(" ma3  ", "black", 9, 1, true);
            Chess xiang3 = new xiang("xiang3 ", "black", 9, 2, true);
            Chess shi3 = new shi(" shi3 ", "black", 9, 3, true);
            Chess jiang = new shuai("jiang ", "black", 9, 4, true);
            Chess shi4 = new shi(" shi4 ", "black", 9, 5, true);
            Chess xiang4 = new xiang("xiang4 ", "black", 9, 6, true);
            Chess ma4 = new ma(" ma4  ", "black", 9, 7, true);
            Chess che4 = new che(" che4 ", "black", 9, 8, true);
            Chess pao3 = new pao(" pao3 ", "black", 7, 1, true);
            Chess pao4 = new che(" pao4 ", "black", 7, 7, true);
            Chess bing6 = new bing("bing6 ", "black", 6, 0, true);
            Chess bing7 = new bing("bing7 ", "black", 6, 2, true);
            Chess bing8 = new bing("bing8 ", "black", 6, 4, true);
            Chess bing9 = new bing("bing9 ", "black", 6, 6, true);
            Chess bing10 = new bing("bing0", "black", 6, 8, true);

            Chess wu = new wu("  +   ", "null", 0, 0, true);
            

            GameBoard(wu,Board);

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

            Boardequal(Board, Boardshow);

            




            while (jiang.getstate() == true || shuai.getstate() == true)
            {
                Console.WriteLine("\nPlayer 1 Choose chress you want to move");
                string str1 = Console.ReadLine();
                canmove(str1, Board, Boardshow);


                Console.WriteLine("\nPlayer 1 Choose position you want to move [a,b]");
                string str2 = Console.ReadLine();
                Move(str1, str2, Board,Boardshow);

                ShowBoard(Board);
                


                Console.WriteLine("\nPlayer 2 Choose chress you want to move");
                string str3 = Console.ReadLine();
                canmove(str3, Board, Boardshow);

                Console.WriteLine("\nPlayer 2 Choose position you want to move [a,b])");
                string str4 = Console.ReadLine();
                Move(str3, str4, Board,Boardshow);
                ShowBoard(Board);

                // break;
            }



        }

       

        private static void restart(Chess chess, Chess[,] Board)
        {
            int i = chess.geti();
            int j = chess.getj();
            string Name = chess.getname();
            Board[i, j] = chess;
        }

       
    }
}

