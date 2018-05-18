class Solution {
    public String longestCommonPrefix(String[] strs) {
        if(strs.length==0)
        {
            return "";
        }
        String longestCommonPrefix = strs[0];
        int i=1;
        while(i<strs.length)
        {
        	if(strs[i].length()<longestCommonPrefix.length())
        	{
        		longestCommonPrefix = longestCommonPrefix.substring(0,strs[i].length());
        	}
            if(!strs[i].substring(0,longestCommonPrefix.length()).equals(longestCommonPrefix))
            {
               while(!strs[i].substring(0,longestCommonPrefix.length()).equals(longestCommonPrefix) && longestCommonPrefix.length()>0)
               {
                   longestCommonPrefix = longestCommonPrefix.substring(0,longestCommonPrefix.length()-1);
               }
                if(longestCommonPrefix.length()==0)
                {
                    return "";
                }
            }
            i++;
        }
        return longestCommonPrefix;
    }
}