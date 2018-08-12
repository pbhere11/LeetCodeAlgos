/*
Example:

Input: nums = [1,2,3]
Output:
[
  [3],
  [1],
  [2],
  [1,2,3],
  [1,3],
  [2,3],
  [1,2],
  []
]
*/
public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
 		IList<IList<int>> result = new List<IList<int>>();
 		if(nums.Length==0)
 		{
 			return result;
 		}
 		IList<int> innerList = new List<int>();
 		Helper(nums,0,innerList,result);
 		return result;
    }
    private void Helper(int[] nums, int index, IList<int> innerList, IList<IList<int>> result)
    {
    	if(index<nums.Length)
    	{
    		Helper(nums,index+1,innerList,result);
    		IList<int>tempList = new List<int>();
    		for(int i=0;i<innerList.Count;i++)
    		{
    			tempList.Add(innerList[i]);
    		}
    		tempList.Add(nums[index]);
    		Helper(nums,index+1,tempList,result);
    	}
    	else
    	{
    		result.Add(innerList);
    	}
    }
}