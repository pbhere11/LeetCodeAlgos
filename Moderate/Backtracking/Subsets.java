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
*/
class Solution {
    public List<List<Integer>> subsets(int[] nums) {
        List<List<Integer>> result = new ArrayList<List<Integer>>();
        if(nums.length==0)
        {
        	return result;
        }
        
        for(int i=0;i<nums.length;i++)
        {
          List<List<Integer>> temp = new ArrayList<List<Integer>>();
          for(int j=0;j<result.size();j++)
          {
            temp.add(new ArrayList<Integer>(result.get(j)));
          }

          for(int j=0;j<temp.size();j++)
          {
            temp.get(j).add(nums[i]);
          }

          List<Integer> singleList = new ArrayList<Integer>();
          singleList.add(nums[i]);
          result.add(singleList);
          result.addAll(temp);
        }
        result.add(new ArrayList<Integer>());
        return result;
    }
}