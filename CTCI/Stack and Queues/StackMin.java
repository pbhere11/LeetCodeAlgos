/*
3.2 Stack Min: How would you design a stack which, in addition to push and pop, has a function min
which returns the minimum element? Push, pop and min should all operate in 0(1) time.
Hints: #27, #59, #78
*/

// "static void main" must be defined in a public class.
public class StackMin {
	class LinkNode{
		int val;
		LinkNode next;
		int min;
		LinkNode(int val, int min)
		{
			this.val = val;
			this.min = min;
		}
	}
	
	LinkNode head = null;
    public static void main(String[] args) {
        StackMin stck = new StackMin();
        stck.push(10);
        stck.push(2);
        stck.push(3);
        stck.push(4);
        stck.push(1);
        stck.push(5);
        System.out.println("min = "+stck.getMin());
        System.out.println("pop = "+stck.pop());
        System.out.println("min = "+stck.getMin());
        System.out.println("pop = "+stck.pop());
        System.out.println("min = "+stck.getMin());
        System.out.println("pop = "+stck.pop());
    }

    public void push(int number)
    {
    	if(head==null)
    	{
    		head = new LinkNode(number,number);
    	}
    	else
    	{
    		LinkNode node = new LinkNode(number,Math.min(number,head.min));
    		node.next = head;
    		head = node;
    	}
    }
    public int pop()
    {
    	int number = head.val;
    	head = head.next;
    	return number;
    }
    public boolean isEmpty()
    {
    	return head==null;
    }

    public int getMin()
    {
    	return head.min;
    }
}