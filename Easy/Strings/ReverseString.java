class Solution {
    public String reverseString(String s) {
        char[] charArr = s.toCharArray();
        int i =0;
        int j = charArr.length-1;
        while(i<j)
        {
        	char temp = charArr[i];
        	charArr[i] = charArr[j];
        	charArr[j] = temp;
        	i++;
        	j--;
        }
        return new String(charArr);
    }
}