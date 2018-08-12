/*
1.4 Palindrome Permutation: Given a string, write a function to check if it is a permutation of a palindrome.
A palindrome is a word or phrase that is the same forwards and backwards. A permutation
is a rea rrangement of letters. The palindrome does not need to be limited to just dictionary words.
EXAMPLE
Input: Tact Coa
Output: True (permutations: "taco cat". "atco cta". etc.)
Hints: #106, #121, #134, #136
*/
class Program {
    static void Main() {
        Program p = new Program();
        /*System.Console.WriteLine(p.isPalindromicPermutation("taco cat"));
        System.Console.WriteLine(p.isPalindromicPermutation("atco cta"));
        System.Console.WriteLine(p.isPalindromicPermutation("atc o ct a"));
        System.Console.WriteLine(p.isPalindromicPermutation(""));
        System.Console.WriteLine(p.isPalindromicPermutation("aa"));
        System.Console.WriteLine(p.isPalindromicPermutation("ab"));*/
        String[] strings = {"Rats live on no evil star",
                            "A man, a plan, a canal, panama",
                            "Lleve",
                            "Tacotac",
                            "asda"};
        for(int i=0;i<strings.Length;i++)
        {
        	System.Console.WriteLine(strings[i]);
        	System.Console.WriteLine(p.isPalindromicPermutation(strings[i]));
        }
    }

    public bool isPalindromicPermutation(String str)
    {
    	int[] charCount = new int[26];
    	for(int i=0;i<str.Length;i++)
    	{
    		int index = char.ToLower(str[i])-'a';
    		if(index>=0&&index<26)
    		{
    			charCount[index]++;
    		}
    	}
    	bool oddFound = false;
    	for(int i=0;i<charCount.Length;i++)
    	{
    		if(charCount[i]%2==1)
    		{
    			if(oddFound)
    			{
    				return false;
    			}
    			oddFound = true;
    		}
    	}
    	return true;
    }
}