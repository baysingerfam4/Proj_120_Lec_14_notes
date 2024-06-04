using System.ComponentModel.DataAnnotations;

namespace Proj_120_Lec_14_notes
{
    internal class Program
    {
        public static Movie[] movies = new Movie[3];
        //2d Array - Matrix
        // 1 2 3 4 5
        // 6 7 8 9 10
        // datatype[,] name = new datatype[sizeX,sizeY];

        static int[,] intMatrix = new int[3, 3];
        static int[,] randomMatrix;
        static void Main(string[] args)
        {
            Movies();
            MatrixExample2();
            char[,] board = {
            {'X','O',' '}, //row 1
            {' ','X','O'}, //row 2
            {'O',' ','X'}, //row 3
            };

            char[,] board2 =
            {
                {'x',' ','o' },
                {'o',' ','o' },
                {'x',' ','o' },
            };
            if (CheckForWin(board2))
            {
                Console.WriteLine("This board has a winner");
                //if (X is the winner) Console.WriteLine (X Won)
            }
            else
            {
                Console.WriteLine("This is a loosing board");
            }
            //intMatrix[0, 0] = 1;
            //intMatrix[0, 1] = 2;
            //intMatrix[1, 0] = 3;
            //intMatrix[1, 1] = 4;

        } // Main

        public static bool CheckForWin(char[,] board)
        {
            // Write the code to check the board to see if it is a winning board.
            // check to see if either player won on the diagnol
            //Extra credit 10 points check to see if any player won on the vertical or horizontal
            //
            return false;
        }

        // Create a program, method, than when you pass in a 2d array of char
        //char[3,3]
        //check to see if 2d array is a winning game of tic tac toe

        public static void MatrixExample2()
        {
            randomMatrix = PopulateIntMatrix(5, 5);
            DisplayMatrix(randomMatrix);
            Console.WriteLine();

            Console.Write("Diagonal: ");
            for (int x = 0; x < randomMatrix.GetLength(0); x++)
            {
                Console.Write(randomMatrix[x, x] + " ");
            }
        }
        public static int[,] PopulateIntMatrix(int xSize, int ySize)
        {
            int[,] temp = new int[xSize, ySize];
            Random rand = new Random();

            for (int x = 0; x < temp.GetLength(0); x++)
            {
                for (int y = 0; y < temp.GetLength(1); y++)
                {
                    temp[x, y] = rand.Next(1, 100);
                }
            }
            return temp;
        }// Populateintmatrix

        public static void DisplayMatrix(int[,] matrix) // Display the matrix
        {
            int xAxisLength = matrix.GetLength(0);
            int yAxisLength = matrix.GetLength(1);


            for (int x = 0; x < xAxisLength; x++)
            {
                for (int y = 0; y < yAxisLength; y++)
                {
                    Console.Write(matrix[x, y] + " ");
                }
                Console.WriteLine();
            }
        }//DisplayMatrix

        public static void FirstMatrixExample()
        { // Array.GetLength(dimension)
            Console.WriteLine(intMatrix.GetLongLength(1));

            int xAxisLength = intMatrix.GetLength(0);
            int yAxisLength = intMatrix.GetLength(1);

            intMatrix[0, 0] = 876;
            intMatrix[1, 0] = 123;

            for (int x = 0; x < xAxisLength; x++)
            {
                for (int y = 0; y < yAxisLength; y++)
                {
                    Console.WriteLine(intMatrix[x, y]);
                }
            }
        }
        public static void NestedLoopsExample()
        {
            // Nested Loops and Matricies

            // Nested Loops
            for (int i = 0; i < 7; i++)
            {
                Console.Write(i + ":");
                // Place another loop INSIDE of our first loop
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Movies()
        {
            
            
            movies[0] = new Movie("The Sandlot", 1993);
            movies[1] = new Movie("Matilda", 1996);
            movies[2] = new Movie("The Fall Guy", 2024);
            for (int i = 0; i < movies.Length; i++)
            {
                Movie movie1 = movies[i];
                Console.WriteLine(movie1.Display());
            }
        }
       
    }// Class

    

    public class Movie
    {
        public string Title;
        public int Year;

        public Movie(string title, int year)
        {
            Title = title;
            Year = year;
        }
        public string Display()
        {
            return $"{Title} and {Year}";
        }
    }// movie class
}// Namespace
