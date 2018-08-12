/*
Example:
Input: [1,2,1,2,6,7,5,1], 2
Output: [0, 3, 5]
Explanation: Subarrays [1, 2], [2, 6], [7, 5] correspond to the starting indices [0, 3, 5].
We could have also taken [2, 1], but an answer of [1, 3, 5] would be lexicographically larger.
Input: [1,2,1,2,6,7,5,1]
windows: [3,3,3,8,13,12,6]
left: [3,3,3,8,13,13,6]
right:[13,13,13,13,13,12,6]

*/
public class Solution {
    public int[] MaxSumOfThreeSubarrays(int[] nums, int k) {
        int[] windows = new int[nums.Length-k+1];
        int sum = 0;
        for(int i=0;i<nums.Length;i++)
        {
        	sum = sum + nums[i];
        	
        	if(i>=k)
        	{
        		sum = sum - nums[i-k];
        	}
        	if(i>=k-1)
        	{
        		windows[i-k+1] = sum;
        	}
        }
        int[] left = new int[windows.Length];
        int[] right = new int[windows.Length];
        int max = 0;
        for(int i=0;i<windows.Length;i++)
        {
        	if(windows[i]>windows[max])
        	{
        		max = i;
        	}
        	left[i] = max;
        }
        max = windows.Length-1;
        for(int i=windows.Length-1;i>=0;i--)
        {
        	if(windows[i]>windows[max])
        	{
        		max = i;
        	}
        	right[i] = max;
        }
        int[] ans = new int[3];
        ans[0] = -1;
        ans[1] = -1;
        ans[2] = -1;
        for(int y = k;y<windows.Length-k;y++)
        {
        	int x = left[y-k];
        	int z = right[y+k];
        	if(ans[0]==-1 || windows[x]+windows[y]+windows[z]>windows[ans[0]]+windows[ans[1]]+windows[ans[2]])
        	{
        		ans[0] = x;
        		ans[1] = y;
        		ans[2] = z;
        	}
        }
        return ans;
    }
}