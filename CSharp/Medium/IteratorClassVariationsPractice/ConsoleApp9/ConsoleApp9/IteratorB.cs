using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class IteratorB
    {
        IList<IList<int>> vector;
        int row = 0;
        int col = 0;
        int maxCol = 0;
        public IteratorB(IList<IList<int>> vec)
        {
            vector = vec;
            for (int i = 0; i < vector.Count; i++)
            {
                if (vec[i].Count > maxCol)
                {
                    maxCol = vec[i].Count;
                }
            }
        }

        public bool hasNext()
        {
            int tempRow = row;
            int tempCol = col;
            while (tempCol < maxCol)
            {
                if (tempRow < vector.Count)
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
                else
                {
                    tempRow = 0;
                    tempCol++;
                }
            }
            return false;
        }

        public int next()
        {
            while (col < maxCol)
            {
                if (row < vector.Count)
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
                else
                {
                    row = 0;
                    col++;
                }
            }
            return -1;
        }
    }
}
