class Solution {
    public List<List<Integer>> generate(int numRows) {
        List<List<Integer>> result = new ArrayList<List<Integer>>();
        if(numRows==0)
        {
        	return result;
        }
        List<Integer> firstList = new ArrayList<Integer>();
        firstList.add(1);
        result.add(firstList);
        for(int i=1;i<numRows;i++)
        {
        	List<Integer> innerList = new ArrayList<Integer>();
        	for(int j=0;j<=i;j++)
        	{
        		List<Integer> prevList = result.get(i-1);
        		if(j==0)
        		{
        			innerList.add(prevList.get(0));
        		}
        		else if(j==prevList.size())
        		{
        			innerList.add(prevList.get(prevList.size()-1));
        		}
        		else if(j<prevList.size()&&j>0)
        		{
        			innerList.add(prevList.get(j)+prevList.get(j-1));
        		}
        	}
        	result.add(innerList);
        }
        return result;
    }
}