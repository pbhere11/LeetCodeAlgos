using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class IteratorC
    {
        int row = 0;
        int col = 0;
        IList<IList<int>> vector;
        int maxCol = 0;
        bool down = true;
        public IteratorC(IList<IList<int>> vec)
        {
            vector = vec;
            for (int i = 0; i < vector.Count; i++)
            {
                if (vector[i].Count > maxCol)
                {
                    maxCol = vector[i].Count;
                }
            }
        }

        public bool hasNext()
        {
            int tempRow = row;
            int tempCol = col;
            bool tempDown = down;
            while (tempCol < maxCol)
            {
                if (tempDown)
                {
                    while (tempRow < vector.Count)
                    {
                        if (tempCol < vector[tempRow].Count)
                        {
                            return true;
                        }
                        else
                        {
                            tempRow++;
                        }
                    }
                    tempRow--;
                    tempCol++;
                    tempDown = !tempDown;
                }
                else
                {
                    while (tempRow >=0)
                    {
                        if (tempCol < vector[tempRow].Count)
                        {
                            return true;
                        }
                        else
                        {
                            tempRow--;
                        }
                    }
                    tempRow++;
                    tempCol++;
                    tempDown = !tempDown;
                }
            }
            return false;
        }

        public int next()
        {
            while (col<maxCol)
            {
                if (down)
                {
                    while (row < vector.Count)
                    {
                        if (col < vector[row].Count)
                        {
                            int val = vector[row][col];
                            row++;
                            return val;
                        }
                        else
                        {
                            row++;
                        }
                    }
                    row--;
                    col++;
                    down = !down;
                }
                else
                {
                    while (row >= 0)
                    {
                        if (col < vector[row].Count)
                        {
                            int val = vector[row][col];
                            row--;
                            return val;
                        }
                        else
                        {
                            row--;
                        }
                    }
                    row++;
                    col++;
                    down = !down;
                } 
            }
            return -1;
        }
    }
}
