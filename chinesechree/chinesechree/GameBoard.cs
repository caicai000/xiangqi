using System;
using System.Collections;
using static chinesechree.Classchess;

namespace chinesechree
{
    public class gameBoard
    {


        private string[,] GameBoard = new string[19, 17];
        private string[,] ShowGameBoard = new string[19, 17];

        public void restart(Chess chess)
        {
            int i = chess.geti()*2;
            int j = chess.getj()*2;
            string Name = chess.getname();
            SetShowGameBoard(i, j, Name);
        }

        public void Showmove(ArrayList position)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" 0   1   2   3   4   5   6   7   8 ");

            for (int i = 0; i < 19; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;

                if (i % 2 == 0)
                {
                    Console.Write(i / 2);
                }
                else
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 17; j++)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    

                    for (int k = 0; k < position.Count; k++)
                    {
                        string str = position[k].ToString();
                        string[] sArray = str.Split(',');
                        int a = Convert.ToInt32(sArray[0])*2;
                        int b = Convert.ToInt32(sArray[1])*2;

                        if(a == i && b == j)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }
                    }
                    
                    Console.Write(ShowGameBoard[i, j]);
                    if (j == 16)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("\n");
                    }
                    
                }
            }
            
               
        }

        public void print()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" 0   1   2   3   4   5   6   7   8 ");

            for (int i = 0; i < 19; i++)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                
                if (i % 2 == 0)
                {
                    Console.Write(i / 2);
                }
                else
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 17; j++)
                {
                    Console.Write(ShowGameBoard[i, j]);
                    if (j == 16)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write("\n");
                    }
                }
            }
        }


        public void move(Chess[,] Board)
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    ShowGameBoard[i, j] = GameBoard[i, j];
                }
            }

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                   
                    if (Board[i, j] != null)
                    {
                        ShowGameBoard[i * 2, j * 2] = Board[i, j].getname();
                    }
                
                }
            }
        }

        public gameBoard()
        {
           
            GameBoard[0, 0] = "┌─";
            GameBoard[0, 1] = "──";
            GameBoard[0, 2] = "┬─";
            GameBoard[0, 3] = "──";
            GameBoard[0, 4] = "┬─";
            GameBoard[0, 5] = "──";
            GameBoard[0, 6] = "┬─";
            GameBoard[0, 7] = "──";
            GameBoard[0, 8] = "┬─";
            GameBoard[0, 9] = "──";
            GameBoard[0, 10] = "┬─";
            GameBoard[0, 11] = "──";
            GameBoard[0, 12] = "┬─";
            GameBoard[0, 13] = "──";
            GameBoard[0, 14] = "┬─";
            GameBoard[0, 15] = "──";
            GameBoard[0, 16] = "┐ ";

            GameBoard[1, 0] = "│ ";
            GameBoard[1, 1] = "  ";
            GameBoard[1, 2] = "│ ";
            GameBoard[1, 3] = "  ";
            GameBoard[1, 4] = "│ ";
            GameBoard[1, 5] = "  ";
            GameBoard[1, 6] = "│ ";
            GameBoard[1, 7] = " ╲";
            GameBoard[1, 8] = "│";
            GameBoard[1, 9] = "╱  ";
            GameBoard[1, 10] = "│ ";
            GameBoard[1, 11] = "  ";
            GameBoard[1, 12] = "│ ";
            GameBoard[1, 13] = "  ";
            GameBoard[1, 14] = "│ ";
            GameBoard[1, 15] = "  ";
            GameBoard[1, 16] = "│ ";

            GameBoard[2, 0] = "├─";
            GameBoard[2, 1] = "──";
            GameBoard[2, 2] = "┼─";
            GameBoard[2, 3] = "──";
            GameBoard[2, 4] = "┼─";
            GameBoard[2, 5] = "──";
            GameBoard[2, 6] = "┼─";
            GameBoard[2, 7] = "──";
            GameBoard[2, 8] = "┼─";
            GameBoard[2, 9] = "──";
            GameBoard[2, 10] = "┼─";
            GameBoard[2, 11] = "──";
            GameBoard[2, 12] = "┼─";
            GameBoard[2, 13] = "──";
            GameBoard[2, 14] = "┼─";
            GameBoard[2, 15] = "──";
            GameBoard[2, 16] = "┤ ";

            GameBoard[3, 0] = "│ ";
            GameBoard[3, 1] = "  ";
            GameBoard[3, 2] = "│ ";
            GameBoard[3, 3] = "  ";
            GameBoard[3, 4] = "│ ";
            GameBoard[3, 5] = "  ";
            GameBoard[3, 6] = "│ ";
            GameBoard[3, 7] = " ╱";
            GameBoard[3, 8] = "│";
            GameBoard[3, 9] = "╲  ";
            GameBoard[3, 10] = "│ ";
            GameBoard[3, 11] = "  ";
            GameBoard[3, 12] = "│ ";
            GameBoard[3, 13] = "  ";
            GameBoard[3, 14] = "│ ";
            GameBoard[3, 15] = "  ";
            GameBoard[3, 16] = "│ ";

            GameBoard[4, 0] = "├─";
            GameBoard[4, 1] = "──";
            GameBoard[4, 2] = "┼─";
            GameBoard[4, 3] = "──";
            GameBoard[4, 4] = "┼─";
            GameBoard[4, 5] = "──";
            GameBoard[4, 6] = "┼─";
            GameBoard[4, 7] = "──";
            GameBoard[4, 8] = "┼─";
            GameBoard[4, 9] = "──";
            GameBoard[4, 10] = "┼─";
            GameBoard[4, 11] = "──";
            GameBoard[4, 12] = "┼─";
            GameBoard[4, 13] = "──";
            GameBoard[4, 14] = "┼─";
            GameBoard[4, 15] = "──";
            GameBoard[4, 16] = "┤ ";

            GameBoard[5, 0] = "│ ";
            GameBoard[5, 1] = "  ";
            GameBoard[5, 2] = "│ ";
            GameBoard[5, 3] = "  ";
            GameBoard[5, 4] = "│ ";
            GameBoard[5, 5] = "  ";
            GameBoard[5, 6] = "│ ";
            GameBoard[5, 7] = "  ";
            GameBoard[5, 8] = "│ ";
            GameBoard[5, 9] = "  ";
            GameBoard[5, 10] = "│ ";
            GameBoard[5, 11] = "  ";
            GameBoard[5, 12] = "│ ";
            GameBoard[5, 13] = "  ";
            GameBoard[5, 14] = "│ ";
            GameBoard[5, 15] = "  ";
            GameBoard[5, 16] = "│ ";

            GameBoard[6, 0] = "├─";
            GameBoard[6, 1] = "──";
            GameBoard[6, 2] = "┼─";
            GameBoard[6, 3] = "──";
            GameBoard[6, 4] = "┼─";
            GameBoard[6, 5] = "──";
            GameBoard[6, 6] = "┼─";
            GameBoard[6, 7] = "──";
            GameBoard[6, 8] = "┼─";
            GameBoard[6, 9] = "──";
            GameBoard[6, 10] = "┼─";
            GameBoard[6, 11] = "──";
            GameBoard[6, 12] = "┼─";
            GameBoard[6, 13] = "──";
            GameBoard[6, 14] = "┼─";
            GameBoard[6, 15] = "──";
            GameBoard[6, 16] = "┤ ";

            GameBoard[7, 0] = "│ ";
            GameBoard[7, 1] = "  ";
            GameBoard[7, 2] = "│ ";
            GameBoard[7, 3] = "  ";
            GameBoard[7, 4] = "│ ";
            GameBoard[7, 5] = "  ";
            GameBoard[7, 6] = "│ ";
            GameBoard[7, 7] = "  ";
            GameBoard[7, 8] = "│ ";
            GameBoard[7, 9] = "  ";
            GameBoard[7, 10] = "│ ";
            GameBoard[7, 11] = "  ";
            GameBoard[7, 12] = "│ ";
            GameBoard[7, 13] = "  ";
            GameBoard[7, 14] = "│ ";
            GameBoard[7, 15] = "  ";
            GameBoard[7, 16] = "│ ";

            GameBoard[8, 0] = "├─";
            GameBoard[8, 1] = "──";
            GameBoard[8, 2] = "┴─";
            GameBoard[8, 3] = "──";
            GameBoard[8, 4] = "┴─";
            GameBoard[8, 5] = "──";
            GameBoard[8, 6] = "┴─";
            GameBoard[8, 7] = "──";
            GameBoard[8, 8] = "┴─";
            GameBoard[8, 9] = "──";
            GameBoard[8, 10] = "┴─";
            GameBoard[8, 11] = "──";
            GameBoard[8, 12] = "┴─";
            GameBoard[8, 13] = "──";
            GameBoard[8, 14] = "┴─";
            GameBoard[8, 15] = "──";
            GameBoard[8, 16] = "┤ ";

            GameBoard[9, 0] = "│ ";
            GameBoard[9, 1] = "  ";
            GameBoard[9, 2] = "  ";
            GameBoard[9, 3] = "   楚河";
            GameBoard[9, 4] = " ";
            GameBoard[9, 5] = " ";
            GameBoard[9, 6] = " ";
            GameBoard[9, 7] = "  ";
            GameBoard[9, 8] = "  ";
            GameBoard[9, 9] = "  ";
            GameBoard[9, 10] = "汉界";
            GameBoard[9, 11] = " ";
            GameBoard[9, 12] = " ";
            GameBoard[9, 13] = "";
            GameBoard[9, 14] = "  ";
            GameBoard[9, 15] = "  ";
            GameBoard[9, 16] = "│ ";

            GameBoard[10, 0] = "├─";
            GameBoard[10, 1] = "──";
            GameBoard[10, 2] = "┬─";
            GameBoard[10, 3] = "──";
            GameBoard[10, 4] = "┬─";
            GameBoard[10, 5] = "──";
            GameBoard[10, 6] = "┬─";
            GameBoard[10, 7] = "──";
            GameBoard[10, 8] = "┬─";
            GameBoard[10, 9] = "──";
            GameBoard[10, 10] = "┬─";
            GameBoard[10, 11] = "──";
            GameBoard[10, 12] = "┬─";
            GameBoard[10, 13] = "──";
            GameBoard[10, 14] = "┬─";
            GameBoard[10, 15] = "──";
            GameBoard[10, 16] = "┤ ";

            GameBoard[11, 0] = "│ ";
            GameBoard[11, 1] = "  ";
            GameBoard[11, 2] = "│ ";
            GameBoard[11, 3] = "  ";
            GameBoard[11, 4] = "│ ";
            GameBoard[11, 5] = "  ";
            GameBoard[11, 6] = "│ ";
            GameBoard[11, 7] = "  ";
            GameBoard[11, 8] = "│ ";
            GameBoard[11, 9] = "  ";
            GameBoard[11, 10] = "│ ";
            GameBoard[11, 11] = "  ";
            GameBoard[11, 12] = "│ ";
            GameBoard[11, 13] = "  ";
            GameBoard[11, 14] = "│ ";
            GameBoard[11, 15] = "  ";
            GameBoard[11, 16] = "│ ";

            GameBoard[12, 0] = "├─";
            GameBoard[12, 1] = "──";
            GameBoard[12, 2] = "┼─";
            GameBoard[12, 3] = "──";
            GameBoard[12, 4] = "┼─";
            GameBoard[12, 5] = "──";
            GameBoard[12, 6] = "┼─";
            GameBoard[12, 7] = "──";
            GameBoard[12, 8] = "┼─";
            GameBoard[12, 9] = "──";
            GameBoard[12, 10] = "┼─";
            GameBoard[12, 11] = "──";
            GameBoard[12, 12] = "┼─";
            GameBoard[12, 13] = "──";
            GameBoard[12, 14] = "┼─";
            GameBoard[12, 15] = "──";
            GameBoard[12, 16] = "┤ ";

            GameBoard[13, 0] = "│ ";
            GameBoard[13, 1] = "  ";
            GameBoard[13, 2] = "│ ";
            GameBoard[13, 3] = "  ";
            GameBoard[13, 4] = "│ ";
            GameBoard[13, 5] = "  ";
            GameBoard[13, 6] = "│ ";
            GameBoard[13, 7] = "  ";
            GameBoard[13, 8] = "│ ";
            GameBoard[13, 9] = "  ";
            GameBoard[13, 10] = "│ ";
            GameBoard[13, 11] = "  ";
            GameBoard[13, 12] = "│ ";
            GameBoard[13, 13] = "  ";
            GameBoard[13, 14] = "│ ";
            GameBoard[13, 15] = "  ";
            GameBoard[13, 16] = "│ ";

            GameBoard[14, 0] = "├─";
            GameBoard[14, 1] = "──";
            GameBoard[14, 2] = "┼─";
            GameBoard[14, 3] = "──";
            GameBoard[14, 4] = "┼─";
            GameBoard[14, 5] = "──";
            GameBoard[14, 6] = "┼─";
            GameBoard[14, 7] = "──";
            GameBoard[14, 8] = "┼─";
            GameBoard[14, 9] = "──";
            GameBoard[14, 10] = "┼─";
            GameBoard[14, 11] = "──";
            GameBoard[14, 12] = "┼─";
            GameBoard[14, 13] = "──";
            GameBoard[14, 14] = "┼─";
            GameBoard[14, 15] = "──";
            GameBoard[14, 16] = "┤ ";

            GameBoard[15, 0] = "│ ";
            GameBoard[15, 1] = "  ";
            GameBoard[15, 2] = "│ ";
            GameBoard[15, 3] = "  ";
            GameBoard[15, 4] = "│ ";
            GameBoard[15, 5] = "  ";
            GameBoard[15, 6] = "│ ";
            GameBoard[15, 7] = " ╲";
            GameBoard[15, 8] = "│";
            GameBoard[15, 9] = "╱ ";
            GameBoard[15, 10] = " │ ";
            GameBoard[15, 11] = "  ";
            GameBoard[15, 12] = "│ ";
            GameBoard[15, 13] = "  ";
            GameBoard[15, 14] = "│ ";
            GameBoard[15, 15] = "  ";
            GameBoard[15, 16] = "│ ";

            GameBoard[16, 0] = "├─";
            GameBoard[16, 1] = "──";
            GameBoard[16, 2] = "┼─";
            GameBoard[16, 3] = "──";
            GameBoard[16, 4] = "┼─";
            GameBoard[16, 5] = "──";
            GameBoard[16, 6] = "┼─";
            GameBoard[16, 7] = "──";
            GameBoard[16, 8] = "┼─";
            GameBoard[16, 9] = "──";
            GameBoard[16, 10] = "┼─";
            GameBoard[16, 11] = "──";
            GameBoard[16, 12] = "┼─";
            GameBoard[16, 13] = "──";
            GameBoard[16, 14] = "┼─";
            GameBoard[16, 15] = "──";
            GameBoard[16, 16] = "┤ ";

            GameBoard[17, 0] = "│ ";
            GameBoard[17, 1] = "  ";
            GameBoard[17, 2] = "│ ";
            GameBoard[17, 3] = "  ";
            GameBoard[17, 4] = "│ ";
            GameBoard[17, 5] = "  ";
            GameBoard[17, 6] = "│ ";
            GameBoard[17, 7] = " ╱";
            GameBoard[17, 8] = "│";
            GameBoard[17, 9] = "╲ ";
            GameBoard[17, 10] = " │ ";
            GameBoard[17, 11] = "  ";
            GameBoard[17, 12] = "│ ";
            GameBoard[17, 13] = "  ";
            GameBoard[17, 14] = "│ ";
            GameBoard[17, 15] = "  ";
            GameBoard[17, 16] = "│ ";

            GameBoard[18, 0] = "└─";
            GameBoard[18, 1] = "──";
            GameBoard[18, 2] = "┴─";
            GameBoard[18, 3] = "──";
            GameBoard[18, 4] = "┴─";
            GameBoard[18, 5] = "──";
            GameBoard[18, 6] = "┴─";
            GameBoard[18, 7] = "──";
            GameBoard[18, 8] = "┴─";
            GameBoard[18, 9] = "──";
            GameBoard[18, 10] = "┴─";
            GameBoard[18, 11] = "──";
            GameBoard[18, 12] = "┴─";
            GameBoard[18, 13] = "──";
            GameBoard[18, 14] = "┴─";
            GameBoard[18, 15] = "──";
            GameBoard[18, 16] = "┘ ";


            for(int i = 0; i < 19; i++)
            {
                for(int j = 0; j < 17; j++)
                {
                    ShowGameBoard[i, j] = GameBoard[i, j];
                }
            }


            
        }
        public string GetGameBoard(int a,int b)
        {
            return GameBoard[a, b];
        }
        public void SetGameBoard(int a, int b,string name)
        {
            GameBoard[a, b] = name;
        }
        public void SetShowGameBoard(int a, int b, string name)
        {
            ShowGameBoard[a, b] = name;
        }

        


    }
}
