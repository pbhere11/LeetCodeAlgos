class Solution {
    public int[] intersect(int[] nums1, int[] nums2) {
        HashMap<Integer,Integer> counterMap = new HashMap<Integer,Integer>();
        List<Integer> result = new ArrayList<Integer>();
        for(int i=0;i<nums1.length;i++)
        {
        	if(counterMap.containsKey(nums1[i]))
        	{
        		counterMap.put(nums1[i],counterMap.get(nums1[i])+1);
        	}
        	else
        	{
        		counterMap.put(nums1[i],1);
        	}
        }
        for(int i =0;i<nums2.length;i++)
        {
        	if(counterMap.containsKey(nums2[i])&& counterMap.get(nums2[i])>0)
        	{
        		result.add(nums2[i]);
        		counterMap.put(nums2[i],counterMap.get(nums2[i])-1);
        	}
        }
        int[] rslt = new int[result.size()];
        for(int i=0;i<result.size();i++)
        {
        	rslt[i] = result.get(i);
        }
        return rslt;
    }
}