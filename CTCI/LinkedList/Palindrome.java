/*
2.6 Palindrome: Implement a function to check if a linked list is a palindrome.
Hints: #5, #13, #29, #61, #101
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
	ListNode head = null;
    public static void main(String[] args) throws IOException {
    	MainClass mn = new MainClass();

        mn.head = new ListNode(1);
        ListNode node = mn.head;
        node.next = new ListNode(2);
        node = node.next;
        node.next = new ListNode(3);
        node = node.next;
        node.next = new ListNode(3);
        node = node.next;
        node.next = new ListNode(2);
        node = node.next;
        node.next = new ListNode(1);
        node = node.next;
        System.out.println(mn.isPalindrome(mn.head));
    }

    public boolean isPalindrome(ListNode node)
    {
    	if(node==null)
    	{
    		return true;
    	}
    	if(isPalindrome(node.next))
    	{
    		if(node.val == head.val)
    		{
    			head = head.next;
    			return true;
    		}
    		else
    		{
    			return false;
    		}
    	}
    	else
    	{
    		return false;
    	}
    }
}