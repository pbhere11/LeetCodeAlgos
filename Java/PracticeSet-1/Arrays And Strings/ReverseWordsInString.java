class Solution {
    public void reverseWords(char[] str) {
    	boolean wordStarted = false;
    	int start =0;
    	int end =0;
        for(int i=0;i<str.length;i++)
        {
        	if(!wordStarted)
        	{
        		if(str[i]!=' ')
        		{
        			start = i;
        			wordStarted = true;
        		}
        	}
        	else if(wordStarted)
        	{
        		if((str[i]==' ' && i!=0))
        		{
        			end = i-1;
        			wordStarted = false;
        			reverseWord(str,start,end);
        		}
        	}
        }
        if(wordStarted)
        {
			reverseWord(str,start,str.length-1);
        }
        reverseWord(str,0,str.length-1);
    }
    private void reverseWord(char[] str, int start, int end)
    {
    	while(start<end)
    	{
    		char temp = str[start];
    		str[start] = str[end];
    		str[end] = temp;
    		start++;
    		end--;
    	}
    }
}