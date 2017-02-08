﻿using System;
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
        /// <summary>
        /// Class level memeber variable for the mazesolver class
        /// </summary>
        char[,] maze;
        int xStart;
        int yStart;
        bool mazeSolved = false;
        /// <summary>
        /// Default Constuctor to setup a new maze solver.
        /// </summary>
        public MazeSolver()
        {}


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
            mazeSolved = false;
            mazeTraversal(xStart, yStart);
            
        }


        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// </summary>
        public bool mazeTraversal(int xPos, int yPos)
        {
            //Implement maze traversal recursive call
            //Make sure that index is still in range with try/catch
            
                int left = xPos - 1;
                int right = xPos + 1;
                int up = yPos - 1;
                int down = yPos + 1;


            //Base case
            if (xPos == maze.GetLength(1)-1 || yPos == maze.GetLength(0)-1)
            {
                
                Console.WriteLine(maze[yPos, xPos]);
                return true;
            }                

                    //recursive call
                    if (maze[xPos, down] == '.' && !mazeSolved)
                    {
                        mazeTraversal(xPos, down);
                        if (!mazeSolved)
                        {
                            maze[xPos, down] = 'X';
                            return true;
                        }


                    }

                    if (maze[xPos, up] == '.' && !mazeSolved)
                    {
                        mazeTraversal(xPos, up);
                        if (!mazeSolved)
                        {
                            maze[xPos, up] = 'X';
                            return true;
                        }
                    }

                    if (maze[yPos, left] == '.' && !mazeSolved)
                    {
                        mazeTraversal(yPos, left);
                        if (!mazeSolved)
                        {
                            maze[yPos, left] = 'X';
                            return true;
                        }
                    }

                    if (maze[yPos, right] == '.' && !mazeSolved)
                    {
                        mazeTraversal(yPos, right);
                        if (!mazeSolved)
                        {
                        maze[yPos, right] = 'X';
                        return true;

                        }
                    }
                
                return false;           
        }
    }
}
