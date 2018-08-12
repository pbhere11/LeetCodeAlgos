/*
3.S Sort Stack: Write a program to sort a stack such that the smallest items are on the top. You can use
an additional temporary stack, but you may not copy the elements into any other data structure
(such as an array). The stack supports the following operations: push, pop, peek, and isEmpty.
Hints: # 75, #32, #43
*/
// "static void main" must be defined in a public class.
public class Main {
    public static void main(String[] args) {
        Stack<Integer> s = new Stack<>();
        s.push(30);
        s.push(-5);
        s.push(18);
        s.push(14);
        s.push(-3);
        Main mn = new Main();
        mn.sortStack(s);
        System.out.println(s.pop());
        System.out.println(s.pop());
        System.out.println(s.pop());
        System.out.println(s.pop());
        System.out.println(s.pop());
    }

    public void sortStack(Stack<Integer> s)
    {
    	if(!s.isEmpty())
    	{
    		//take off the integer
    		int num = s.pop();
    		//sort remaining stack
    		sortStack(s);
    		//insert this number
    		sortedInsert(s,num);
    	}
    }

    public void sortedInsert(Stack<Integer> s, int num)
    {
    	if(s.isEmpty() || num<s.peek())
    	{
    		s.push(num);
    	}
    	else
    	{
    		int temp = s.pop();
    		sortedInsert(s,num);
    		s.push(temp);
    	}
    }
}