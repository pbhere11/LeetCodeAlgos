/*
Input: "23"
Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"]
*/
class Solution {
    public List<String> letterCombinations(String digits) {
        HashMap<Integer,String> map = new HashMap<Integer,String>();
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
        letterCombination(digits,result,map,"");
        return result;
    }

    private void letterCombination(String digits,List<String> result,HashMap<Integer,String> map,String constructedString)
    {
    	if(digits.length()==0)
    	{
    		result.add(constructedString);
    	}
    	else
    	{
    		int digit = Integer.parseInt(digits.substring(0,1));
	 		String letters = map.get(digit);
	 		for(int i=0;i<letters.length();i++)
	 		{
	 			letterCombination(digits.substring(1),result,map,constructedString+letters.charAt(i));
	 		}
    	}
    	
    }
}