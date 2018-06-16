/*
A queue of people are waiting to buy ice cream from you. 
Each person buys one ice cream, which sells for $5. 
Each customer is holding a bill of $5, $10 or $20. 
Your initial balance is 0. 
Find whether you will be able to make change for every customer in the queue. 
You must serve customers in the order they come in. 

For example 
5, 5, 5, 10, 20 -> true, 
5, 5, 10 -> true, 
10, 10 -> false
*/

public class Main {
    public static void main(String[] args) {
    	Main mn = new Main();
        int[] customers1 = new int[]{5, 5, 5, 10, 20};
        int[] customers2 = new int[]{5, 5, 10};
        int[] customers3 = new int[]{10, 10};
        System.out.println(mn.buyIceCream(customers1));
        System.out.println(mn.buyIceCream(customers2));
        System.out.println(mn.buyIceCream(customers3));
    }

    public boolean buyIceCream(int[] customers)
    {
    	HashMap<Integer,Integer> currencyCount = new HashMap<Integer,Integer>();
    	currencyCount.put(5,0);
    	currencyCount.put(10,0);
    	currencyCount.put(20,0);
    	for(int i=0;i<customers.length;i++)
    	{
    		int returnVal =customers[i]-5;
    		currencyCount.put(customers[i],currencyCount.get(customers[i])+1);
    		while(returnVal!=0)
    				{
    					if(returnVal>=20)
    					{
    						if(currencyCount.get(20)==0)
    						{
    							return false;
    						}
    						else
    						{
    							currencyCount.put(20,currencyCount.get(20)-1);
    							returnVal = returnVal-20;
    						}
    					}
    					else if(returnVal>=10)
    					{
    						if(currencyCount.get(10)==0)
    						{
    							return false;
    						}
    						else
    						{
    							currencyCount.put(10,currencyCount.get(10)-1);
    							returnVal = returnVal-10;
    						}
    					}
    					else if(returnVal>=5)
    					{
    						if(currencyCount.get(5)==0)
    						{
    							return false;
    						}
    						else
    						{
    							currencyCount.put(5,currencyCount.get(5)-1);
    							returnVal = returnVal-5;
    						}
    					}
    				}
    	}
    	return true;
    }
}