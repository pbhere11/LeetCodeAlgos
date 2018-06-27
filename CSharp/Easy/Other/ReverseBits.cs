/*
Example:

Input: 43261596
Output: 964176192
Explanation: 43261596 represented in binary as 00000010100101000001111010011100, 
             return 964176192 represented in binary as 00111001011110000010100101000000.
*/
public class Solution {
    public uint reverseBits(uint n) {
        uint result = 0;
        uint index=31;
        while(n!=0)
        {
        	result = result + ((n%2)*( (uint)Math.Pow(2,index) ));
        	n = n/2;
        	index--;
        }
        
        return result;
    }
}