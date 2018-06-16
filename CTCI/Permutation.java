/*
Given two strings, write a method to decide if one is a permutation of the other.
*/

// "static void main" must be defined in a public class.
public class Main {
    public static void main(String[] args) {
        String[][] pairs = {{"apple", "papel"}, {"carrot", "tarroc"}, {"hello", "llloh"}};
        Main mn = new Main();
        for(int i=0;i<pairs.length;i++)
        {
        	System.out.println(mn.isPermutation(pairs[i][0],pairs[i][1]));
        }
    }

    public boolean isPermutation(String str1, String str2)
    {
    	char[] charArr1 = str1.toCharArray();
    	char[] charArr2 = str2.toCharArray();
    	sort(charArr1,0,str1.length()-1);
    	sort(charArr2,0,str2.length()-1);
    	str1 = new String(charArr1);
    	str2 = new String(charArr2);
    	return str1.equals(str2);
    }

    private void sort(char[] charArr, int start, int end)
    {
    	if(start<end)
    	{
    		int mid = (start+end)/2;
    		sort(charArr,start,mid);
    		sort(charArr,mid+1,end);
    		merge(charArr,start,mid,end);
    	}
    }

    private void merge(char[] charArr, int start, int mid, int end)
    {
    	int n1 = mid-start+1;
    	int n2 = end-mid;

    	char[] charArr1 = new char[n1];
    	char[] charArr2 = new char[n2];
    	
    	int x = start;
    	for(int i=0;i<n1;i++)
    	{
    		charArr1[i] = charArr[x];
    		x++;
    	}
    	x = mid+1;
    	for(int i=0;i<n2;i++)
    	{
    		charArr2[i] = charArr[x];
    		x++;
    	}	
    	int i=0;
    	int j=0;

    	for(int k=start;k<=end;k++)
    	{
    		if(j>=n2 || (i<n1 && charArr1[i]<charArr2[j]))
    		{
    			charArr[k] = charArr1[i];
    			i++;
    		}
    		else
    		{
    			charArr[k] = charArr2[j];
    			j++;
    		}
    	}
    }

}