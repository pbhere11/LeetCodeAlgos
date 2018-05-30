class Solution {
    public List<List<Integer>> permute(int[] nums) {
        List<List<Integer>> result = new ArrayList<List<Integer>>();
        if(nums.length ==0)
        {
        	return result;
        }
        List<Integer> innerList = new ArrayList<Integer>();
        permute(nums,0,nums.length-1,result,innerList);
        return result;
    }

    private void permute(int[] nums, int start, int end, List<List<Integer>> result, List<Integer> innerList)
    {
    	if(innerList.size()==nums.length)
    	{
    		result.add(innerList);
    	}
    	
    	if(start<=end)
    	{
    		innerList.add(nums[start]);
    		permute(nums,start+1,end,result,innerList);
    	}
    }
    private void swap(int nums, int i, int j)
    {
    	int temp = nums[i];
    	nums[i] = nums[j];
    	nums[j] = temp;
    }
}