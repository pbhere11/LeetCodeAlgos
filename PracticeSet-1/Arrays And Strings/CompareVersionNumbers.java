/*
Example 1:

Input: version1 = "0.1", version2 = "1.1"
Output: -1
Example 2:

Input: version1 = "1.0.1", version2 = "1"
Output: 1
Example 3:

Input: version1 = "7.5.2.4", version2 = "7.5.3"
Output: -1
*/
class Solution {
    public int compareVersion(String version1, String version2) {
        String[] version1Arr = version1.split("\\.");
        if(version1Arr.length==0)
        {
        	version1Arr = new String[1];
        	version1Arr[0] = version1;
        }
        String[] version2Arr = version2.split("\\.");
        if(version2Arr.length==0)
        {
        	version2Arr = new String[1];
        	version2Arr[0] = version2;
        }
        int version1Index =0;
        int version2Index =0;
        while(version1Index<version1Arr.length || version2Index<version2Arr.length)
        {
        	int version1Num = version1Index<version1Arr.length?Integer.parseInt(version1Arr[version1Index]):0;
        	int version2Num = version2Index<version2Arr.length?Integer.parseInt(version2Arr[version2Index]):0;
        	if(version1Num>version2Num)
        	{
        		return 1;
        	}
        	else if(version1Num<version2Num)
        	{
        		return -1;
        	}
        	version1Index++;
        	version2Index++;
        }
        return 0;
    }
}