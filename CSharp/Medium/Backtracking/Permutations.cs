/*
Example:

Input: [1,2,3]
Output:
[
  [1,2,3],
  [1,3,2],
  [2,1,3],
  [2,3,1],
  [3,1,2],
  [3,2,1]
]
*/
public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        if(nums.Length==0)
        {
        	return result;
        }
        Permute(nums,0,result);
        return result;
    }

    private void Permute(int[] nums, int start, IList<IList<int>> result)
    {
    	if(start<=nums.Length)
    	{
    		if(start==nums.Length)
    		{
    			IList<int> innerList = new List<int>();
    			for(int i=0;i<nums.Length;i++)
    			{
    				innerList.Add(nums[i]);
    			}
    			result.Add(innerList);
    		}
    		else
    		{
    			for(int i=start;i<nums.Length;i++)
		    	{
		    		Swap(nums,start,i);
		    		Permute(nums,start+1,result);
		    		Swap(nums,start,i);
		    	}
    		}
    	}
    }

    private void Swap(int[] nums, int i, int j)
    {
    	int temp = nums[i];
    	nums[i] = nums[j];
    	nums[j] = temp;
    }
}