/*
Example:
MinStack minStack = new MinStack();
minStack.push(-2);
minStack.push(0);
minStack.push(-3);
minStack.getMin();   --> Returns -3.
minStack.pop();
minStack.top();      --> Returns 0.
minStack.getMin();   --> Returns -2.
*/
public class MinStack {
    public class Node{
        public int val;
        public Node next;
        public int min;
        public Node(int val)
        {
            this.val = val;
            next = null;
            min = 0;
        }
    }
    private Node TopNode;
    
    /** initialize your data structure here. */
    public MinStack() {
        TopNode = null;
    }
    
    public void Push(int x) {
        if(TopNode==null)
        {
            TopNode = new Node(x);
            TopNode.min = x;
        }
        else
        {
            Node node = new Node(x);
            node.next = TopNode;
            node.min = Math.Min(TopNode.min,x);
            TopNode = node;
        }
    }
    
    public void Pop() {
        TopNode = TopNode.next;
    }
    
    public int Top() {
        return TopNode.val;
    }
    
    public int GetMin() {
        return TopNode.min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */