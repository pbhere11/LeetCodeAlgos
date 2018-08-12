public class Solution {
	private Dictionary<int,string> map ;
    public string NumberToWords(int num) {
    	if(num==0)
    	{
    		return "Zero";
    	}
        map=new Dictionary<int,string>();
		map.Add(1,"One");
		map.Add(2,"Two");
		map.Add(3,"Three");
		map.Add(4,"Four");
		map.Add(5,"Five");
		map.Add(6,"Six");
		map.Add(7,"Seven");
		map.Add(8,"Eight");
		map.Add(9,"Nine");
		map.Add(10,"Ten");
		map.Add(11,"Eleven");
		map.Add(12,"Twelve");
		map.Add(13,"Thirteen");
		map.Add(14,"Fourteen");
		map.Add(15,"Fifteen");
		map.Add(16,"Sixteen");
		map.Add(17,"Seventeen");
		map.Add(18,"Eighteen");
		map.Add(19,"Nineteen");
		map.Add(20,"Twenty");
		map.Add(30,"Thirty");
		map.Add(40,"Forty");
		map.Add(50,"Fifty");
		map.Add(60,"Sixty");
		map.Add(70,"Seventy");
		map.Add(80,"Eighty");
		map.Add(90,"Ninety");
        StringBuilder sb = new StringBuilder();
        while(num>0)
        {
        	int val =0;
        	int rem =0;
        	string str = "";
        	if(num>=1000000000)
        	{
        		val = num/1000000000;
        		rem = num%1000000000;
        		str = ConvertHundered(val);
        		sb.Append(str);
        		sb.Append("Billion ");
        		num = rem;
        	}
        	else if(num>=1000000)
        	{
        		val = num/1000000;
        		rem = num%1000000;
        		str = ConvertHundered(val);
        		sb.Append(str);
        		sb.Append("Million ");
        		num = rem;
        	}
        	else if(num>=1000)
        	{
        		val = num/1000;
        		rem = num%1000;
        		str = ConvertHundered(val);
        		sb.Append(str);
        		sb.Append("Thousand ");
        		num = rem;
        	}
        	else if(num>=100)
        	{
        		str = ConvertHundered(num);
        		sb.Append(str);
        		num = 0;
        	}
        	else
        	{
        		str = Convert(num);
        		sb.Append(str);
        		num =0;
        	}
        }
        if(sb.Length>1)
        {
        	sb.Length--;
        }
        return sb.ToString();
    }
    private string ConvertHundered(int num)
    {
    	StringBuilder sb = new StringBuilder();
    	while(num>0)
    	{
    		if(num>=100)
	    	{
	    		int val = num/100;
	    		string str = Convert(val);
	    		sb.Append(str);
	    		sb.Append("Hundred ");
	    		num = num%100;
	    	}
	    	else
	    	{
	    		string str = Convert(num);
	    		sb.Append(str);
	    		num =0;
	    	}
    	}
    	return sb.ToString();
    }
    private string Convert(int num)
    {

    	StringBuilder sb = new StringBuilder();
    	while(num>0)
    	{
    		if(num>20)
    		{
    			int val = num/10;
    			string str1 = map[val*10];
    			sb.Append(str1);
    			sb.Append(" ");
    			num = num%10;
    		}
    		else
    		{
    		 	string str = map[num];
    		 	sb.Append(str);
    		 	sb.Append(" ");
    		 	num =0;
    		}
    	}
    	return sb.ToString();
    }
}