public class Solution {
    // you need treat n as an unsigned value
    public int reverseBits(int n) {
        int[] bitArr = new int[32];
        Arrays.fill(bitArr,0);
        int i = bitArr.length-1;
        while(n!=0)
        {
        	bitArr[i] = n%2;
        	n = n/2;
        	i--;
        }
        int result = 0;
        for(int j=0;j<bitArr.length;j++)
        {
        	result = result + bitArr[j]*(int)Math.pow(2,j);
        }
        return result;
    }
}