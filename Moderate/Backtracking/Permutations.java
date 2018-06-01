
/*
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
class Solution {
    public List<List<Integer>> permute(int[] nums) {
        List<List<Integer>> result = new ArrayList<List<Integer>>();
        ArrayList<Integer> innerList = new ArrayList<Integer>();
        if(nums.length==0)
        {
        	return result;
        }
        permute(nums,0,nums.length-1,result,innerList);
        return result;
    }
    private void permute(int[] nums, int start, int end, List<List<Integer>> result, ArrayList<Integer> innerList)
    {
    	if(innerList.size()==nums.length)
    	{
    		result.add(innerList);
    	}
    	if(start<=end)
    	{
    		
    		for(int i=start;i<=end;i++)
    		{
    			swap(nums,start,i);
    			ArrayList<Integer> refInnerList = (ArrayList<Integer>)innerList.clone();
	    		innerList.add(nums[start]);
	    		permute(nums,start+1,end,result,innerList);
                innerList = refInnerList;
                swap(nums,start,i);
    		}
    	}
    }
    private void swap(int[] nums, int i, int j)
    {
    	int temp = nums[i];
    	nums[i] = nums[j];
    	nums[j] = temp;
    }
}