using System;
using static chinesechree.Classchess;
using static chinesechree.movefunction;
using chinesechree;

namespace Chinesechess
{
    class MainClass
    {

        public static void restart(Chess chess, Chess[,] GameBoard)
        {
            int i = chess.geti();
            int j = chess.getj();
            string Name = chess.getname();
            GameBoard[i, j] = chess;
        }

        public static void Main(string[] args)
        {
            Chess[,] Board = new Chess[10, 9];

            Chess che1 = new che("车", "red", 0, 0, true);
            Chess ma1 = new ma("马", "red", 0, 1, true);
            Chess xiang1 = new xiang("相", "red", 0,2, true);
            Chess shi1 = new shi("仕", "red", 0, 3, true);
            Chess shuai = new shuai("帅", "red", 0, 4, true);
            Chess shi2 = new shi("仕", "red", 0, 5, true);
            Chess xiang2 = new xiang("相", "red", 0, 6, true);
            Chess ma2 = new ma("马", "red", 0, 7, true);
            Chess che2 = new che("车", "red", 0, 8, true);
            Chess pao1 = new pao("炮", "red", 2, 1, true);
            Chess pao2 = new che("炮", "red", 2, 7, true);
            Chess bing1 = new bing("兵", "red", 3, 0, true);
            Chess bing2 = new bing("兵", "red", 3, 2, true);
            Chess bing3 = new bing("兵", "red", 3, 4, true);
            Chess bing4 = new bing("兵", "red", 3, 6, true);
            Chess bing5 = new bing("兵", "red", 3, 8, true);

            Chess che3 = new che("车", "black", 9, 0, true);
            Chess ma3 = new ma("马", "black", 9, 1, true);
            Chess xiang3 = new xiang("像", "black", 9, 2, true);
            Chess shi3 = new shi("士", "black", 9, 3, true);
            Chess jiang = new shuai("将", "black", 9, 4, true);
            Chess shi4 = new shi("士", "black", 9, 5, true);
            Chess xiang4 = new xiang("像", "black", 9, 6, true);
            Chess ma4 = new ma("马", "black", 9, 7, true);
            Chess che4 = new che("车", "black", 9, 8, true);
            Chess pao3 = new pao("炮", "black", 7, 1, true);
            Chess pao4 = new che("炮", "black", 7, 7, true);
            Chess bing6 = new bing("卒", "black", 6, 0, true);
            Chess bing7 = new bing("卒", "black", 6, 2, true);
            Chess bing8 = new bing("卒", "black", 6, 4, true);
            Chess bing9 = new bing("卒", "black", 6, 6, true);
            Chess bing10 = new bing("卒", "black", 6, 8, true);

            restart(che1, Board);
            restart(ma1, Board);
            restart(xiang1, Board);
            restart(shi1, Board);
            restart(shuai, Board);
            restart(shi2, Board);
            restart(xiang2, Board);
            restart(ma2, Board);
            restart(che2, Board);
            restart(bing1, Board);
            restart(bing2, Board);
            restart(bing3, Board);
            restart(bing4, Board);
            restart(bing5, Board);
            restart(pao1, Board);
            restart(pao2, Board);

            restart(che3, Board);
            restart(ma3, Board);
            restart(xiang3, Board);
            restart(shi3, Board);
            restart(jiang, Board);
            restart(shi4, Board);
            restart(xiang4, Board);
            restart(ma4, Board);
            restart(che4, Board);
            restart(bing6, Board);
            restart(bing7, Board);
            restart(bing8, Board);
            restart(bing9, Board);
            restart(bing10, Board);
            restart(pao3, Board);
            restart(pao4, Board);

            gameBoard GameBoard = new gameBoard();

            GameBoard.restart(che1);
            GameBoard.restart(ma1);
            GameBoard.restart(xiang1);
            GameBoard.restart(shi1);
            GameBoard.restart(shuai);
            GameBoard.restart(shi2);
            GameBoard.restart(xiang2);
            GameBoard.restart(ma2);
            GameBoard.restart(che2);
            GameBoard.restart(pao1);
            GameBoard.restart(pao2);
            GameBoard.restart(bing1);
            GameBoard.restart(bing2);
            GameBoard.restart(bing3);
            GameBoard.restart(bing4);
            GameBoard.restart(bing5);

            GameBoard.restart(che3);
            GameBoard.restart(ma3);
            GameBoard.restart(xiang3);
            GameBoard.restart(shi3);
            GameBoard.restart(jiang);
            GameBoard.restart(shi4);
            GameBoard.restart(xiang4);
            GameBoard.restart(ma4);
            GameBoard.restart(che4);
            GameBoard.restart(pao3);
            GameBoard.restart(pao4);
            GameBoard.restart(bing6);
            GameBoard.restart(bing7);
            GameBoard.restart(bing8);
            GameBoard.restart(bing9);
            GameBoard.restart(bing10);

            GameBoard.print();

            while (jiang.getstate() == true && shuai.getstate() == true)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nPlayer 1 Choose chress you want to move [a,b]");
                string str1 = Console.ReadLine();
                canmove(str1, Board,GameBoard);

              

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nPlayer 1 Choose position you want to move [a,b]");
                string str2 = Console.ReadLine();
                Move(str1, str2,Board);

              

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nPlayer 2 Choose chress you want to move [a,b]");
                string str3 = Console.ReadLine();
                //canmove(str3, Board);

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nPlayer 2 Choose position you want to move [a,b])");
                string str4 = Console.ReadLine();
                Move(str3, str4, Board);
               

                // break;
            }





        }

       

       

       
    }
}

