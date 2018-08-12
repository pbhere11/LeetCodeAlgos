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
        Helper(nums,0,result);
        return result;
    }
    private void Helper(int[] nums, int index,IList<IList<int>> result)
    {
    	if(index<nums.Length)
    	{
    		for(int i=index;i<nums.Length;i++)
    		{
    			Swap(nums,i,index);
    			Helper(nums,index+1,result);
    			Swap(nums,i,index);
    		}
    	}
    	else
    	{
    		result.Add(new List<int>(nums));
    	}
    }
    private void Swap(int[] nums, int i, int j)
    {
    	int temp = nums[i];
    	nums[i] = nums[j];
    	nums[j] = temp;
    }
}