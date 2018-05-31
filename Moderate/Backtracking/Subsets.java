/*
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

1 2 3 4**
1
2
1 2
3
1 2 3
4
1 2 3 4

2 1 3 4
2
*/
class Solution {
    public List<List<Integer>> subsets(int[] nums) {
		List<List<Integer>> result = new ArrayList<List<Integer>>();
		ArrayList<Integer> innerList = new ArrayList<Integer>();
		if(nums.length==0)
		{
			return result;
		}        
		subsets(nums,0,nums.length-1,result,innerList);
		return result;
    }
    
    private void subsets(int[] nums, int start, int end, List<List<Integer>> result, ArrayList<Integer> innerList)
    {
    	if(start<=end)
    	{
    		ArrayList tempList = (ArrayList<Integer>)innerList.clone();
			innerList.add(nums[start]);
			result.add(tempList);
			subsets(nums,start+1,end,result,innerList);
			innerList = tempList;
    	}
    }
}