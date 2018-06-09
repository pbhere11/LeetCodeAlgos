/*
Given k, and a binary string, determine if this contains all permutations of length k. 
For example, 11001 contains all possible binary sequences with k=2 (00,01,10,11)
*/
public class Main {
    public static void main(String[] args) {
        String str = "11001";
        int n = 2;
        Main mn = new Main();
        System.out.println(mn.isValid(n,str));
    }

    public boolean isValid(int n, String binaryStr)
    {
    	return isValid(n,binaryStr,"");
    }

    private boolean isValid(int n, String binaryStr, String constructedStr)
    {
    	if(constructedStr.length()==n)
    	{
    		if(binaryStr.contains(constructedStr))
    		{
    			return true;
    		}
    		else
    		{
    			return false;
    		}
    	}
    	boolean flagNot =  isValid(n,binaryStr,constructedStr+"0");
    	boolean flag =  isValid(n,binaryStr,constructedStr+"1");
    	return flag&&flagNot;
    }

}