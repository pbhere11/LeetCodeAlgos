/*
Input: [0,1,0,2,1,0,1,3,2,1,2,1]
left:   0,1,1,2,2,2,2,3,3,3,3,3
right:  3,3,3,3,3,3,3,3,2,2,2,1 
ans:      ,
Output: 6
*/
public class Solution {
    public int Trap(int[] height) {
    	if(height.Length==0)
    	{
    		return 0;
    	}
        int[] left = new int[height.Length];
        int[] right = new int[height.Length];
        left[0]=height[0];
        right[height.Length-1] =height[height.Length-1];
        int result =0;
        for(int i=1;i<height.Length-1;i++)
        {
        	left[i] = Math.Max(left[i-1],height[i]);
        }
        for(int i=height.Length-2;i>=0;i--)
        {
        	right[i] = Math.Max(right[i+1],height[i]);
        }
        for(int i=1;i<height.Length-1;i++)
        {
        	int maxHeight = Math.Min(left[i],right[i]);
        	result+=maxHeight-height[i];
        }
        return result;
    }
}