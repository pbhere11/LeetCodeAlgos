/*
Example 1: 

Given buf = "abc"
read("abc", 1) // returns "a"
read("abc", 2); // returns "bc"
read("abc", 1); // returns ""
Example 2: 

Given buf = "abc"
read("abc", 4) // returns "abc"
read("abc", 1); // returns ""
*/
/* The Read4 API is defined in the parent class Reader4.
      int Read4(char[] buf); */

public class Solution : Reader4 {
    /**
     * @param buf Destination buffer
     * @param n   Maximum number of characters to read
     * @return    The number of characters read
     */
    private Queue<char> storage = new Queue<char>(); 
    public int Read(char[] buf, int n) {
    	char[] readBuff;
        int index =0;
        int count =0;
        while(index<n&&storage.Count>0)
        {
        	buf[index] = storage.Dequeue();
        	index++;
        }
        if(index==n)
        {
        	return index;
        }
        while(count<n)
        {
        	readBuff = new char[4];
        	int readChars = base.Read4(readBuff);
        	for(int i=0;i<readChars;i++)
        	{
        		if(index<n)
        		{
        			buf[index] = readBuff[i];
        			index++;
        		}
        		else
        		{
        			storage.Enqueue(readBuff[i]);
        		}
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