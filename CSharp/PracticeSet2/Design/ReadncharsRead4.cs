/*
Example 1:

Input: buf = "abc", n = 4
Output: "abc"
Explanation: The actual number of characters read is 3, which is "abc".
Example 2:

Input: buf = "abcde", n = 5 
Output: "abcde"
*/
/* The Read4 API is defined in the parent class Reader4.
      int Read4(char[] buf); */

/* The Read4 API is defined in the parent class Reader4.
      int Read4(char[] buf); */

public class Solution : Reader4 {
    /**
     * @param buf Destination buffer
     * @param n   Maximum number of characters to read
     * @return    The number of characters read
     */
    public int Read(char[] buf, int n) {
        char[] readBuff;
        int index =0;
        int count =0;
        while(count<n)
        {
        	readBuff = new char[4];
        	int readChars = base.Read4(readBuff);
        	for(int i=0;i<readChars && index<n;i++)
        	{
        		buf[index] = readBuff[i];
        		index++;
        	}
        	if(readChars<4)
        	{
        		break;
        	}
        	count+=readChars;
        }
        return index;
    }
}