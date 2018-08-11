public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] counter = new int[26];
        for(int i=0;i<tasks.Length;i++)
        {
        	counter[(int)tasks[i]-'A']++;
        }
        Array.Sort(counter);
        int maxVal = counter[25]-1;
        int idealSlot = maxVal*n;
        for(int i=24;i>=0&&counter[i]>0;i--)
        {
        	idealSlot-=Math.Min(maxVal,counter[i]);
        }
        return idealSlot>0?idealSlot+tasks.Length:tasks.Length;
    }
}