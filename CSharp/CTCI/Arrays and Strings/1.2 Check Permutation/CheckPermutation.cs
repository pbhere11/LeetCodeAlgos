/*
1.2 Check Permutation: Given two strings, write a method to decide if one is a permutation of the
other.
Hints: #7, #84, #722, #737
*/
class Program {
	private int HeapSize =0;
    static void Main() {
        Program p = new Program();
        System.Console.WriteLine(p.isPermutation("",""));
        System.Console.ReadLine();
    }

    public bool isPermutation(string str1, string str2)
    {
    	if(str1.Length!=str2.Length)
    	{
    		return false;
    	}
    	String sortedStr1 = sort(str1);
    	String sortedStr2 = sort(str2);

    	return sortedStr1.Equals(sortedStr2);
    }

    private string sort(String str)
    {
    	char[] charArray = str.ToCharArray();
    	buildHeap(charArray);
    	for(int i=0;i<charArray.Length;i++)
    	{
    		char c = charArray[0];
    		charArray[0] = charArray[HeapSize-1];
    		charArray[HeapSize-1] = c;
    		HeapSize--;
    		maxHeapify(charArray,0);
    	}
    	return new string(charArray);
    }

    private void buildHeap(char[] charArray)
    {
    	HeapSize = charArray.Length;
    	for(int i=0;i<charArray.Length;i++)
    	{
    		maxHeapify(charArray,i);
    	}
    }

    private void maxHeapify(char[] charArray, int index)
    {
    	int left = index*2+1;
    	int right = index*2+2;
    	int max = index;
    	if(left<HeapSize && charArray[left]>charArray[index])
    	{
    		max = left;
    	}
    	if(right<HeapSize && charArray[right]>charArray[max])
    	{
    		max = right;
    	}
    	if(max!=index)
    	{
    		char c = charArray[index];
    		charArray[index] = charArray[max];
    		charArray[max] = c;
    		maxHeapify(charArray,max);
    	}
    }
}