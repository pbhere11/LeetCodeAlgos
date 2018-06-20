// "static void main" must be defined in a public class.
/*
The input to the function/method consists of two arguments - 

logFileSize: an integer representing the number of lines in the log file, 
logLines: a list of strings representing the log file. 

Output: 
Return a list of strings representing the reordered log file data. 

Note: 
Identifier consists of only English letters and numbers. The lines with words are not required to match case and the sort needs to be case insensitive. 

Example: 
Input: 
logFileSize = 5 
logLines = 
[al 9 2 3 1] 
[g1 Act car] 
[zo4 4 7] 
[abl off KEY dog] 
[a8 act zoo] 

Output: 
[gl Act car] 
[a8 act zoo] 
[ab1 off KEY dog] 
[al 9 2 3 1] 
[zo4 4 7] 
*/
public class Main {
	private int HeapSize =0;
    public static void main(String[] args) {
        Main mn = new Main();
        int logFileSize = 9;
        List<String> logLines = new ArrayList<String>();
        logLines.add("al 9 2 3 1");
        logLines.add("g1 Act car");
        logLines.add("zo4 4 7");
        logLines.add("abl off KEY dog");
        logLines.add("a8 act zoo");
        logLines.add("a8 aaa bbb");
        logLines.add("a9 aaa bbb");
        logLines.add("b8 aaa bbb");
        logLines.add("c8 aaa bbb");
        List<String> result = mn.reorderlogFile(logFileSize,logLines);
        for(int i=0;i<result.size();i++)
        {
        	System.out.println(result.get(i));
        }
    }

    public List<String> reorderlogFile(int logFileSize, List<String>logLines)
    {
    	HeapSize = logFileSize;
    	buildHeap(logLines);
    	for(int i=0;i<logLines.size();i++)
    	{
    		Collections.swap(logLines,0,HeapSize-1);
    		HeapSize--;
    		maxHeapify(logLines,0);
    	}
    	return logLines;
    }
    private void buildHeap(List<String> logLines)
    {
    	for(int i=logLines.size()/2;i>=0;i--)
    	{
    		maxHeapify(logLines,i);
    	}
    }
    private void maxHeapify(List<String> logLines, int index)
    {
    	int left = index*2+1;
    	int right = index*2+2;
    	int max = index;
    	if(left<HeapSize && isRankGreaterThan(logLines.get(left),logLines.get(index)))
    	{
    		max = left;
    	}
    	if(right<HeapSize && isRankGreaterThan(logLines.get(right),logLines.get(max)))
    	{
    		max = right;
    	}
    	if(max!=index)
    	{
    		Collections.swap(logLines,index,max);
    		maxHeapify(logLines,max);
    	}
    }
    private boolean isRankGreaterThan(String leftStr, String rightStr)
    {
    	String[] leftArr = leftStr.split(" ");
    	String[] rightArr = rightStr.split(" ");
    	int leftIndex =1;
    	int rightIndex =1;
    	if(isInteger(leftArr[leftIndex])&&isInteger(rightArr[rightIndex]))
    	{
    		return true;
    	}
    	if(isInteger(leftArr[leftIndex])&&!isInteger(rightArr[rightIndex]))
    	{
    		return true;
    	}
    	if(!isInteger(leftArr[leftIndex])&&isInteger(rightArr[rightIndex]))
    	{
    		return false;
    	}
    	while(leftIndex<leftArr.length||rightIndex<rightArr.length)
    	{
    		if(leftIndex>=leftArr.length && rightIndex<rightArr.length)
    		{
    			return false;
    		}
    		if(rightIndex>rightArr.length && leftIndex<leftArr.length)
    		{
    			return true;
    		}
    		String left = leftArr[leftIndex];
    		String right = rightArr[rightIndex];
    		if(left.toLowerCase().charAt(0)>right.toLowerCase().charAt(0))
    		{
    			return true;
    		}
    		if(left.toLowerCase().charAt(0)<right.toLowerCase().charAt(0))
    		{
    			return false;
    		}
    		leftIndex++;
    		rightIndex++;
    	}
    	if(isIdentifierGreaterThan(leftArr[0],rightArr[0]))
    	{
    		return true;
    	}
    	else
    	{
    		return false;
    	}
    }
    private boolean isIdentifierGreaterThan(String leftStr, String rightStr)
    {
    	char[] leftArr = leftStr.toLowerCase().toCharArray();
    	char[] rightArr = rightStr.toLowerCase().toCharArray();
    	int leftIndex =0;
    	int rightIndex =0;
    	while(leftIndex<leftArr.length||rightIndex<rightArr.length)
    	{
    		if(leftIndex>=leftArr.length&&rightIndex<rightArr.length)
    		{
    			return false;
    		}
    		if(rightIndex>rightArr.length&&leftIndex<leftArr.length)
    		{
    			return true;
    		}
    		char left = leftArr[leftIndex];
    		char right = rightArr[rightIndex];
    		if(left>right)
    		{
    			return true;
    		}
    		if(left<right)
    		{
    			return false;
    		}
    		leftIndex++;
    		rightIndex++;
    	}
    	return true;
    }
    private boolean isInteger(String str)
    {
    	try{
    		Integer.parseInt(str);
    		return true;
    	}
    	catch(Exception ex)
    	{
    		return false;
    	}
    }
}