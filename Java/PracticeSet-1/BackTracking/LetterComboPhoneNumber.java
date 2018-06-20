/*
Input: "23"
Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
*/
class Solution {
    public List<String> letterCombinations(String digits) {
        HashMap<Integer,String> map = new HashMap<Integer,String>();
        map.put(0,"");
        map.put(1,"");
        map.put(2,"abc");
        map.put(3,"def");
        map.put(4,"ghi");
        map.put(5,"jkl");
        map.put(6,"mno");
        map.put(7,"pqrs");
        map.put(8,"tuv");
        map.put(9,"wxyz");
        List<String> result = new ArrayList<String>();
        if(digits.length()==0)
        {
        	return result;
        }
        helper(digits,map,result,"");
        return result;
    }
    private void helper(String digits, HashMap<Integer,String> map, List<String> result, String constructedString)
    {
    	if(digits.length()==0)
    	{
    		result.add(constructedString);
    	}
    	else
    	{
    		int digit = Integer.parseInt(digits.substring(0,1));
	    	String str = map.get(digit);
	    	for(int i=0;i<str.length();i++)
	    	{
	    		helper(digits.substring(1),map,result,constructedString+str.charAt(i));
	    	}
    	}
    }
}