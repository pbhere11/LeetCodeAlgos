/*
2.4 Partition: Write code to partition a linked list around a value x, such that all nodes less than x come
before all nodes greater than or equal to x. lf x is contained within the list, the values of x only need
to be after the elements less than x (see below). The partition element x can appear anywhere in the
"right partition"; it does not need to appear between the left and right partitions.
EXAMPLE
Input: 3 -> 5 -> 8 -> 5 -> 10 -> 2 -> 1 [partition = 5)
Output: 3 -> 1 -> 2 -> 10 -> 5 -> 5 -> 8
Hints: #3, #24
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
        BufferedReader in = new BufferedReader(new InputStreamReader(System.in));
        String line;
        ListNode head = null;
        while ((line = in.readLine()) != null) {
            ListNode node = Wrapper.stringToListNode(line);
            head = node;
            Wrapper.prettyPrintLinkedList(node);
        }

        MainClass mn = new MainClass();
        ListNode node = mn.partition(head,5);
        Wrapper.prettyPrintLinkedList(node);
    }

    public ListNode partition(ListNode head, int k)
    {
    	ListNode left = null;
    	ListNode right = null;
    	ListNode leftHead = null;
    	ListNode rightHead = null;
    	while(head!=null)
    	{
    		if(head.val<k)
    		{
    			if(left==null)
    			{
    				left = new ListNode(head.val);
    				leftHead = left;
    			}
    			else
    			{
    				left.next = new ListNode(head.val);
    				left = left.next; 
    			}
    		}
    		else
    		{
    			if(right==null)
    			{
    				right = new ListNode(head.val);
    				rightHead = right;
    			}
    			else
    			{
    				right.next = new ListNode(head.val);
    				right = right.next; 
    			}
    		}
    		head = head.next;
    	}
    	left.next = rightHead;
    	return leftHead;
    }
}