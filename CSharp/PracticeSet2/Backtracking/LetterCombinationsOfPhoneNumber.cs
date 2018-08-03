/*
Example:

Input: "23"
Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
*/
public class Solution {
    public IList<string> LetterCombinations(string digits) {
        Dictionary<char,string> map = new Dictionary<char,string>();
        map.Add('0',"");
     	map.Add('1',"");
        map.Add('2',"abc");
        map.Add('3',"def");
        map.Add('4',"ghi");
        map.Add('5',"jkl");
        map.Add('6',"mno");
        map.Add('7',"pqrs");
        map.Add('8',"tuv");
        map.Add('9',"wxyz");
        IList<string> result = new List<string>();
        if(digits.Length==0)
        {
        	return result;
        }
        Helper(digits,0,result,map,"");
        return result;
    }
    private void Helper(string digits,int index, IList<string> result, Dictionary<char,string> map, string resultStr)
    {
    	if(index==digits.Length)
    	{
    		result.Add(resultStr);
    	}
    	else
    	{
    		char c = digits[index];
	    	string str = map[c];
	    	for(int i=0;i<str.Length;i++)
	    	{
	    		Helper(digits,index+1,result,map,resultStr+str[i].ToString());
	    	}
    	}
    }
}