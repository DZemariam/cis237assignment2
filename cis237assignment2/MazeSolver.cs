using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment2
{
    /// <summary>
    /// This class is used for solving a char array maze.
    /// You might want to add other methods to help you out.
    /// A print maze method would be very useful, and probably neccessary to print the solution.
    /// If you are real ambitious, you could make a seperate class to handle that.
    /// </summary>
    class MazeSolver
    {

        //Some Constants
        private int XTILES = 25; //Number of X tiles
        private int YTILES = 25; //Number of Y tiles
        private int TILESIZE = 10; //Size of the tiles (pixles)
        /// <summary>
        /// Class level memeber variable for the mazesolver class
        /// </summary>
        char[,] maze;
        int xStart;
        int yStart;

        /// <summary>
        /// Default Constuctor to setup a new maze solver.
        /// </summary>
        public MazeSolver()
        { }


        /// <summary>
        /// This is the public method that will allow someone to use this class to solve the maze.
        /// Feel free to change the return type, or add more parameters if you like, but it can be done
        /// exactly as it is here without adding anything other than code in the body.
        /// </summary>
        public void SolveMaze(char[,] maze, int xStart, int yStart)
        {
            //Assign passed in variables to the class level ones. It was not done in the constuctor so that
            //a new maze could be passed in to this solve method without having to create a new instance.
            //The variables are assigned so they can be used anywhere they are needed within this class. 
            this.maze = maze;
            this.xStart = xStart;
            this.yStart = yStart;

            //Do work needed to use mazeTraversal recursive call and solve the maze.
            Solve(maze, xStart, yStart);
        }


        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// </summary>
        private void Solve(char[,] maze, int x, int y)

            //Recursion in Psuedo Code considering I can't figure out code
            if (maze[x, y] == /*Outside of maze*/ || maze[x, y] == X);
            {
            return //to current location;
    }
            else
    {
             //check right
             if (x+1, y == ",");
            {
                //Step In and Change , to X
                 PrintMaze();
                return Solve;
            }
            //checks down
            if (x, y+1 == ",");
            {
                //Step In and Change , to X
                 PrintMaze();
                return Solve;
            }
            //checks left
            if (x-1, y == ",");
            {
                //Step In and Change , to X
                 PrintMaze();
                return Solve;
            }
            //checks up 
            if (x, y+1 == ",");
            {
                //Step In and Change , to X
                 PrintMaze();
                return Solve;
            }
           }
        }
    }
}
