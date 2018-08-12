/*
Example:

Input: 5
Output:
[
     [1],
    [1,1],
   [1,2,1],
  [1,3,3,1],
 [1,4,6,4,1]
]
*/
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> result = new List<IList<int>>();
        if(numRows==0)
        {
        	return result;
        }
        for(int i=0;i<numRows;i++)
        {
        	IList<int> innerList = new List<int>();
        	int j=0;
        	while(j<=i)
        	{
        		if(j==0||j==i)
        		{
        			innerList.Add(1);
        		}
        		else
        		{
        			innerList.Add(result[i-1][j-1]+result[i-1][j]);
        		}
        		j++;
        	}
        	result.Add(innerList);
        }
        return result;
    }
}