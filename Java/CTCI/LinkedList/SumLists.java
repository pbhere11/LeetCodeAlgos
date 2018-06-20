/*
2.S Sum Lists: You have two numbers represented by a linked list, where each node contains a single
digit. The digits are stored in reverse order, such that the 1 's digit is at the head of the list. Write a
function that adds the two numbers and returns the sum as a linked list.
EXAMPLE
Input: (7-) 1 -) 6) + (5 -) 9 -) 2) .Thatis,617 + 295.
Output: 2 -) 1 -) 9. That is, 912.
FOLLOW UP
Suppose the digits are stored in forward order. Repeat the above problem.
EXAMPLE
Input: (6 -) 1 -) 7) + (2 -) 9 -) 5).Thatis,617 + 295.
Output: 9 -) 1 -) 2. That is, 912.
Hints: #7, #30, #71, #95, #109
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
        ListNode head1 = new ListNode(7);
        ListNode node = head1;
        node.next = new ListNode(1);
        node = node.next;
     	node.next = new ListNode(6);
     	ListNode head2 = new ListNode(5);
        node = head2;
        node.next = new ListNode(9);
        node = node.next;
     	node.next = new ListNode(2);

     	ListNode result = mn.add(head1,head2);
     	Wrapper.prettyPrintLinkedList(head1);
        Wrapper.prettyPrintLinkedList(head2);
        Wrapper.prettyPrintLinkedList(result);
    }

    public ListNode add(ListNode left, ListNode right)
    {
    	int carry =0;
    	ListNode head = null;
    	ListNode node = null;
    	while(left!=null||right!=null)
    	{
    		int num1 = 0;
    		if(left!=null)
    		{
    			num1 = left.val;
    			left = left.next;
    		}
    		int num2 = 0;
    		if(right!=null)
    		{
    			num2 = right.val;
    			right = right.next;
    		}
    		int sum = num1 + num2 + carry;
    		if(sum>=10)
    		{
    			carry = 1;
    			if(head==null)
    			{
    				head = new ListNode(sum%10);
    				node = head;
    			}
    			else
    			{
    				node.next = new ListNode(sum%10);
    				node = node.next;
    			}
    		}
    		else
    		{
    			carry =0;
    			if(head==null)
    			{
    				head = new ListNode(sum);
    				node = head;
    			}
    			else
    			{
    				node.next = new ListNode(sum);
    				node = node.next;
    			}
    		}
    	}
    	if(carry>0)
    	{
    		node.next = new ListNode(carry);
    	}
    	return head;
    }
}