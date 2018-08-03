/*
Example:

Input: [1,1,2]
Output:
[
  [1,1,2],
  [1,2,1],
  [2,1,1]
]
*/
public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        if(nums.Length==0)
        {
        	return result;
        }
        Array.Sort(nums);
        IList<int> innerList = new List<int>();
        bool[] visited = new bool[nums.Length];
        Helper(nums,innerList,visited,result);
        return result;
    }
    private void Helper(int[] nums, IList<int> innerList,bool[] visited ,IList<IList<int>> result)
    {
    	if(innerList.Count==nums.Length)
    	{
    		result.Add(new List<int>(innerList));
    	}
    	else
    	{
    		for(int i=0;i<nums.Length;i++)
	    	{
	    		if(i>0 &&nums[i]==nums[i-1] && !visited[i-1])
	    		{
	    			continue;
	    		}
	    		if(!visited[i])
	    		{
	    			innerList.Add(nums[i]);
	    			visited[i] = true;
	    			Helper(nums,innerList,visited,result);
	    			visited[i] = false;
	    			innerList.RemoveAt(innerList.Count-1);
	    		}
	    	}
    	}
    }
}