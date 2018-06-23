/*
Example 1:

Input: s = "anagram", t = "nagaram"
Output: true
Example 2:

Input: s = "rat", t = "car"
Output: false
*/

public class Solution {
	private int HeapSize = 0;
    public bool IsAnagram(string s, string t) {
        string str1 = Sort(s.ToCharArray());
        string str2 = Sort(t.ToCharArray());
        return str1.Equals(str2);
    }

    private string Sort(char[] charArray)
    {
    	BuildHeap(charArray);
    	for(int i=0;i<charArray.Length;i++)
    	{
    		Swap(charArray,0,HeapSize-1);
    		HeapSize--;
    		MaxHeapify(charArray,0);
    	}
    	return new string(charArray);
    }

    private void BuildHeap(char[] charArray)
    {
    	HeapSize = charArray.Length;
    	for(int i=charArray.Length/2;i>=0;i--)
    	{
    		MaxHeapify(charArray,i);
    	}
    }

    private void MaxHeapify(char[] charArray, int index)
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
    		Swap(charArray,index,max);
    		MaxHeapify(charArray,max);
    	}
    }

    private void Swap(char[] charArray,int i, int j)
    {
    	char c = charArray[i];
    	charArray[i] = charArray[j];
    	charArray[j] = c;
    }
}