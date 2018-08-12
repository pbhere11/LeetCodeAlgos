/*
Input: 2d vector =
[
  [1,2],
  [3],
  [4,5,6]
]
Output: [1,2,3,4,5,6]
Explanation: By calling next repeatedly until hasNext returns false, 
             the order of elements returned by next should be: [1,2,3,4,5,6].
*/
public class Vector2D {
	private int row =0;
	private int column =0;
	private IList<IList<int>> vectorList;
    public Vector2D(IList<IList<int>> vec2d) {
        vectorList = vec2d;
    }

    public bool HasNext() {
    	if(row>=vectorList.Count)
    	{
    		return false;
    	}
        while(row<vectorList.Count&&vectorList[row].Count==0)
        {
        	row++;
        }
        if(row<vectorList.Count&&column<vectorList[row].Count)
        {
        	return true;
        }
        else
        {
        	return false;
        }
    }

    public int Next() {
        while(row<vectorList.Count&&vectorList[row].Count==0)
        {
        	row++;
        }
        int result =-1;
         if(row<vectorList.Count&&column<vectorList[row].Count)
         {
         	result = vectorList[row][column];
         	column++;
         	if(column==vectorList[row].Count)
         	{
         		row++;
         		column=0;
         	}
         }
         return result;
    }
}

/**
 * Your Vector2D will be called like this:
 * Vector2D i = new Vector2D(vec2d);
 * while (i.HasNext()) v[f()] = i.Next();
 */