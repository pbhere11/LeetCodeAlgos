/*
Given s = "hello", return "olleh".
*/
class Solution {
    public String reverseString(String s) {
        int i=0;
        int j=s.length()-1;
        char[] strArray = new char[s.length()];
        strArray = s.toCharArray();
        while(i<j)
        {
        	char temp = strArray[i];
        	strArray[i] = strArray[j];
        	strArray[j] = temp;
        	i++;
        	j--;
        }
        return new String(strArray);
    }
}