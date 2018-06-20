/*
raceacar
01234567
*/
class Solution {
    public boolean isPalindrome(String s) {
        List<Character> charList = new ArrayList<Character>();
        String str = s.toLowerCase();
        for(int i=0;i<str.length();i++)
        {
        	if(((int)str.charAt(i)-97>=0 &&((int)str.charAt(i)-97<27))||((int)str.charAt(i)-48>=0 &&((int)str.charAt(i)-48<10)))
        	{
        		charList.add(str.charAt(i));
        	}
        }
        int i =0;
        int j = charList.size()-1;
        while(i<j)
        {
        	if(charList.get(i)!=charList.get(j))
        	{
        		return false;
        	}
        	i++;
        	j--;
        }
        return true;
    }
}