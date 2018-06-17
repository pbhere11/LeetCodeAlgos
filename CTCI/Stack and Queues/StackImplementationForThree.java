/*
3.1 Three in One: Describe how you could use a single array to implement three stacks.
Hints: #2, #72, #38, #58
*/
// "static void main" must be defined in a public class.

    
    public class StackCls{
    	int[][] values;
    	int[] sizes = new int[3];
    	int stackSize;

        public static void main(String[] args) {
            StackCls stck = new StackCls(5);
            stck.push(0,1);
            stck.push(0,2);
            stck.push(0,3);
            stck.push(1,4);
            stck.push(1,5);
            stck.push(1,6);
            stck.push(2,7);
            stck.push(2,8);
            stck.push(2,9);
            System.out.println(stck.pop(0));
            System.out.println(stck.pop(1));
            System.out.println(stck.pop(2));
            System.out.println(stck.pop(0));
            System.out.println(stck.pop(1));
            System.out.println(stck.pop(2));
            System.out.println(stck.pop(0));
            System.out.println(stck.pop(1));
            System.out.println(stck.pop(2));
        }
    	public StackCls(int size)
    	{
    		stackSize = size;
    		values = new int[3][stackSize*3];
    		for(int i=0;i<sizes.length;i++)
    		{
    			sizes[i] = -1;
    		}
    	}

    	public void push(int stackNumber, int number)
    	{
    		if(!isFull(stackNumber))
    		{
    			sizes[stackNumber]++;
    			values[stackNumber][sizes[stackNumber]] = number;
    		}
    	}
    	public int pop(int stackNumber)
    	{
    		int number =0;
    		if(!isEmpty(stackNumber))
    		{
    			number = values[stackNumber][sizes[stackNumber]];
    			sizes[stackNumber]--;
    		}
    		return number;
    	}
    	public boolean isEmpty(int stackNumber)
    	{
    		return sizes[stackNumber]==-1;
    	}
    	public boolean isFull(int stackNumber)
    	{
    		return sizes[stackNumber]==stackSize;
    	}
    }