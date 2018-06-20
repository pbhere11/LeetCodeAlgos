/*
1.1 Is Unique: Implement an algorithm to determine if a string has all unique characters. What if you
cannot use additional data structures?
*/

public class Program{
	public int HeapSize =0;
	public static void Main(string[] args)	
	{
		Program p = new Program();
		System.Console.WriteLine(p.isUnique("abcde"));
		System.Console.WriteLine(p.isUnique("abcdbsb"));
		System.Console.WriteLine(p.isUnique("bb"));
		System.Console.WriteLine(p.isUnique("bb"));
		System.Console.ReadLine();
	}
	
	public bool isUnique(string str)
	{
		if(str.Length==0)
		{
			return false;
		}
		char[] charArray = str.ToCharArray();
		sort(charArray);
		for(int i=1;i<charArray.Length;i++)
		{
			if(charArray[i]==charArray[i-1])
			{
				return false;
			}
		}
		return true;
	}

	private void sort(char[] charArray)
	{
		buildHeap(charArray);
		for(int i=0;i<charArray.Length;i++)
		{
			char c = charArray[0];
			charArray[0] = charArray[HeapSize-1];
			charArray[HeapSize-1] = c;
			HeapSize--;
			maxHeapify(charArray,0);
		}
	}

	private void buildHeap(char[] charArray)
	{
		HeapSize = charArray.Length;
		for(int i=charArray.Length/2;i>=0;i--)
		{
			maxHeapify(charArray,i);
		}
	}

	private void maxHeapify(char[] charArray, int index)
	{
		int left = index*2+1;
		int right = index*2+2;
		int max = index;
		if(left<HeapSize && charArray[left]>charArray[index] )
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

