/*
Let’s say you have two input arrays with sorted elements. Find the union. 

a[] = {2, 10, 14, 19, 51, 71} 
b[] = {2, 9, 19, 40, 51} 

Union = {2, 9, 10, 14, 19, 40, 51}
*/

public class Main {
    public static void main(String[] args) {
        Main mn = new Main();
        int[] arr1 = new int[]{2, 10, 14, 19, 51, 71};
        int[] arr2 = new int[]{2, 9, 19, 40, 51};
        List<Integer> result = mn.unionOfArrays(arr1,arr2);
        for(int i=0;i<result.size();i++)
        {
        	System.out.println(result.get(i));
        }
    }

    public List<Integer> unionOfArrays(int[] arr1, int[] arr2)
    {
    	int i=0;
    	int j=0;
    	List<Integer> result = new ArrayList<Integer>();
    	while(i<arr1.length&&j<arr2.length)
    	{
    		if(arr1[i]==arr2[j])
    		{
    			result.add(arr1[i]);
    			i++;
    			j++;
    		}
    		else if(arr1[i]<arr2[j])
    		{
    			result.add(arr1[i]);
    			i++;
    		}
    		else
    		{
    			result.add(arr2[j]);
    			j++;
    		}
    	}
    	return result;
    }
}