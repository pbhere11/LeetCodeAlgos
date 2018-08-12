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

1,2,3

{}
{3}
{2}
{2,3}
{1}
{1,2}
{1,2,3}
*/
public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        if(nums.Length==0)
        {
        	return result;
        }
        IList<int> innerList = new List<int>();
        Subset(nums,0,innerList,result);
        return result;
    }

    private void Subset(int[] nums, int index, IList<int> innerList, IList<IList<int>> result)
    {
    	if(index<nums.Length)
    	{
    		
    		IList<int> tempList = new List<int>();
    		for(int i=0;i<innerList.Count;i++)
    		{
    			tempList.Add(innerList[i]);
    		}
    		tempList.Add(nums[index]);
        Subset(nums,index+1,innerList,result);
    		Subset(nums,index+1,tempList,result);
    	}
    	else
    	{
    		result.Add(innerList);
    	}
    }
}