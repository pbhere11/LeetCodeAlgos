/*
Example 1:

Input: ["abcd","dcba","lls","s","sssll"]
Output: [[0,1],[1,0],[3,2],[2,4]] 
Explanation: The palindromes are ["dcbaabcd","abcddcba","slls","llssssll"]
Example 2:

Input: ["bat","tab","cat"]
Output: [[0,1],[1,0]] 
Explanation: The palindromes are ["battab","tabbat"]
*/
public class Solution {
    public IList<IList<int>> PalindromePairs(string[] words) {
        Dictionary<string,int> map = new Dictionary<string,int>();
        IList<IList<int>> result = new List<IList<int>>();
        for(int i=0;i<words.Length;i++)
        {
        	if(!map.ContainsKey(words[i]))
        	{
        		map.Add(words[i],i);
        	}
        }
        for(int i=0;i<words.Length;i++)
        {
        	string word = words[i];
        	if(IsPalindrome(word))
        	{
        		if(map.ContainsKey(""))
        		{
        			if(map[""]!=i)
        			{
        				IList<int> innerList = new List<int>();
        				innerList.Add(map[""]);
        				innerList.Add(i);
        				result.Add(innerList);
        				innerList = new List<int>();
        				innerList.Add(i);
        				innerList.Add(map[""]);
        				result.Add(innerList);
        			}
        		}
        	}
        	string reversed = Reverse(word);
        	if(map.ContainsKey(reversed))
        	{
				if(map[reversed]!=i)
				{
        			IList<int> innerList = new List<int>();
        			innerList.Add(i);
        			innerList.Add(map[reversed]);
        			result.Add(innerList);
				}
			}
			for(int k=1;k<word.Length;k++)
			{
				string left = word.Substring(0,k);
				string right = word.Substring(k);
				if(IsPalindrome(left))
				{
					string reversedRight = Reverse(right);
					if(map.ContainsKey(reversedRight))
		        	{
						if(map[reversedRight]!=i)
						{
		        			IList<int> innerList = new List<int>();
		        			innerList.Add(map[reversedRight]);
		        			innerList.Add(i);
		        			result.Add(innerList);
						}
					}
				}
				if(IsPalindrome(right))
				{
					string reversedLeft = Reverse(left);
					if(map.ContainsKey(reversedLeft))
		        	{
						if(map[reversedLeft]!=i)
						{
		        			IList<int> innerList = new List<int>();
		        			innerList.Add(i);
		        			innerList.Add(map[reversedLeft]);
		        			result.Add(innerList);
						}
					}
				}
			}
        }
        return result;
    }

    private string Reverse(string str)
    {
    	char[] charArr = str.ToCharArray();
    	Array.Reverse(charArr);
    	return new string(charArr);
    }
    private bool IsPalindrome(string str)
    {
    	int i=0;
    	int j = str.Length-1;
    	while(i<j)
    	{
    		if(str[i]!=str[j])
    		{
    			return false;
    		}
    		i++;
    		j--;
    	}
    	return true;
    }
}