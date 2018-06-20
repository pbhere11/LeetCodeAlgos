/*
2.8 Loop Detection: Given a circular linked list, implement an algorithm that returns the node at the
beginning of the loop.
DEFINITION
Circular linked list: A (corrupt) linked list in which a node's next pointer points to an earlier node, so
as to make a loop in the linked list.
EXAMPLE
Input: A -) B -) C -) 0 -) E - ) C[thesameCasearlierl
Output: C
Hints: #50, #69, #83, #90
*/
class Wrapper {
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     int val;
     *     ListNode next;
     *     ListNode(int x) { val = x; }
     * }
     */
    
    public static int[] stringToIntegerArray(String input) {
        input = input.trim();
        input = input.substring(1, input.length() - 1);
        if (input.length() == 0) {
          return new int[0];
        }
    
        String[] parts = input.split(",");
        int[] output = new int[parts.length];
        for(int index = 0; index < parts.length; index++) {
            String part = parts[index].trim();
            output[index] = Integer.parseInt(part);
        }
        return output;
    }
    
    public static ListNode stringToListNode(String input) {
        // Generate array from the input
        int[] nodeValues = stringToIntegerArray(input);
    
        // Now convert that list into linked list
        ListNode dummyRoot = new ListNode(0);
        ListNode ptr = dummyRoot;
        for(int item : nodeValues) {
            ptr.next = new ListNode(item);
            ptr = ptr.next;
        }
        return dummyRoot.next;
    }
    
    public static void prettyPrintLinkedList(ListNode node) {
      while (node != null && node.next != null) {
          System.out.print(node.val + "->");
          node = node.next;
      }
    
      if (node != null) {
        System.out.println(node.val);
      } else {
        System.out.println("Empty LinkedList");
      }
    }
}

public class MainClass {
    public static void main(String[] args) throws IOException {
        MainClass mn = new MainClass();
        ListNode node1 = new ListNode(1);
        
        ListNode node2 = new ListNode(2);
        node1.next = node2;
        
        ListNode node3 = new ListNode(3);
        node2.next = node3;
        
        ListNode node4 = new ListNode(4);
        node3.next = node4;

        ListNode node5 = new ListNode(5);
        node4.next = node5;

        ListNode node6 = new ListNode(6);
        node5.next = node6;

        ListNode node7 = new ListNode(7);
        node6.next = node7;

        ListNode node8 = new ListNode(8);
        node7.next = node5;

        System.out.println(mn.isCyclic(node1));
    }

    public boolean isCyclic(ListNode head)
    {
    	ListNode slower = head;
    	ListNode faster = head.next;

    	while(faster!=null && faster.next!=null)
    	{
    		if(faster==slower)
    		{
    			return true;
    		}
    		faster = faster.next.next;
    		slower = slower.next;
    	}
    	return false;
    }
}