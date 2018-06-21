/*
1.6 String Compression: Implement a method to perform basic string compression using the counts
of repeated characters. For example, the string aabcccccaaa would become a2b1c5a3. If the
"compressed" string would not become smaller than the original string, your method should return
the original string. You can assume the string has only uppercase and lowercase letters (a - z).
Hints: #92, # 11 0
*/

class Program {
    static void Main() {
        Program p = new Program();
        string str = "aabcccccaaa";
        System.Console.WriteLine(p.compressString(str));
    }

    public string compressString(string str)
    {
    	StringBuilder sb = new StringBuilder();
    	int count =1;
    	for(int i=1;i<str.Length;i++)
    	{
    		if(str[i]==str[i-1])
    		{
    			count++;
    		}
    		else if(str[i]!=str[i-1])
    		{
    			sb.Append(str[i-1]);
    			sb.Append(count);
    			count =1;
    		}
    	}
    	if(count>0)
    	{
    		sb.Append(str[str.Length-1]);
    		sb.Append(count);
    	}
    	return sb.ToString();
    }
}