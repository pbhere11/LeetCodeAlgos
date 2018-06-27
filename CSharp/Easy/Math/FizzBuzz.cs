/*
n = 15,

Return:
[
    "1",
    "2",
    "Fizz",
    "4",
    "Buzz",
    "Fizz",
    "7",
    "8",
    "Fizz",
    "Buzz",
    "11",
    "Fizz",
    "13",
    "14",
    "FizzBuzz"
]
*/
public class Solution {
    public IList<string> FizzBuzz(int n) {
        IList<string> fizzBuzzList = new List<string>();
        for(int i=1;i<=n;i++)
        {
        	if(i%3==0&&i%5==0)
        	{
        		fizzBuzzList.Add("FizzBuzz");
        	}
        	else if(i%3==0&&i%5!=0)
        	{
        		fizzBuzzList.Add("Fizz");
        	}
        	else if(i%3!=0&&i%5==0)
        	{
        		fizzBuzzList.Add("Buzz");
        	}
        	else
        	{
        		fizzBuzzList.Add(i.ToString());
        	}
        }
        return fizzBuzzList;
    }
}