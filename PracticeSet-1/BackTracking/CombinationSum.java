/*

Example 1:

Input: candidates = [2,3,6,7], target = 7,
A solution set is:
[
  [7],
  [2,2,3]
]
Example 2:

Input: candidates = [2,3,5], target = 8,
A solution set is:
[
  [2,2,2,2],
  [2,3,3],
  [3,5]
]
*/
class Solution {
    public List<List<Integer>> combinationSum(int[] candidates, int target) {
        List<List<Integer>> result = new ArrayList<List<Integer>>();
        List<Integer>innerList = new ArrayList<Integer>();
        helper(candidates,target,result,innerList,0,0);
        return result;
    }
    private void helper(int[] candidates, int target,List<List<Integer>> result, List<Integer>innerList ,int sum, int index)
    {
    	if(sum == target)
    	{
    		List<Integer> list = new ArrayList<Integer>(innerList);
    		result.add(list);
    	}
    	else if(sum<target)
    	{
    		for(int i=index;i<candidates.length;i++)
    		{
    			innerList.add(candidates[i]);
    			helper(candidates,target,result,innerList,sum+candidates[i],i);
    			innerList.remove(innerList.size()-1);
    		}
    	}
    }
}