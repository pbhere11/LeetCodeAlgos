using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class IteratorA
    {
        int row = 0;
        int col = 0;
        IList<IList<int>> vector;
        public IteratorA(IList<IList<int>> vec) {
            vector = vec;
        }
        public bool hasNext()
        {
            int tempRow = row;
            int tempCol = col;
            while (tempRow < vector.Count)
            {
                if (tempCol < vector[tempRow].Count)
                {
                    return true;
                }
                else
                {
                    tempRow++;
                    tempCol = 0;
                }
            }
            return false;
        }

        public int next()
        {
            while (row < vector.Count)
            {
                if (col < vector[row].Count)
                {
                    int val = vector[row][col];
                    col++;
                    return val;
                }
                else
                {
                    row++;
                    col = 0;
                }
            }
            return -1;
        }
    }
}
