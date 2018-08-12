/*
Example:

Input: "23"
Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
*/
public class Solution {
    public IList<string> LetterCombinations(string digits) {
        Dictionary<int,string> map = new Dictionary<int,string>();
        map.Add(0,"");
        map.Add(1,"");
        map.Add(2,"abc");
        map.Add(3,"def");
        map.Add(4,"ghi");
        map.Add(5,"jkl");
        map.Add(6,"mno");
        map.Add(7,"pqrs");
        map.Add(8,"tuv");
        map.Add(9,"wxyz");
        IList<string> result = new List<string>();
        if(digits.Length==0)
        {
        	return result;
        }
        string resultStr = "";
        LetterCombinations(digits,0,result,resultStr,map);
        return result;
    }

    private void LetterCombinations(string digits,int index,IList<string> result, string resultStr, Dictionary<int,string> map)
    {
    	if(resultStr.Length==digits.Length)
    	{
    		result.Add(resultStr);
    	}
    	else if(index<digits.Length)
    	{
    		int digit = (int)(digits[index]-'0');
	    	string letters = map[digit];
	    	StringBuilder sb = new StringBuilder();
	    	sb.Append(resultStr);
	    	for(int i=0;i<letters.Length;i++)
	    	{
	    		LetterCombinations(digits,index+1,result,sb.Append(letters[i]).ToString(),map);
	    		sb = new StringBuilder();
	    		sb.Append(resultStr);
	    	}
    	}
    }
}