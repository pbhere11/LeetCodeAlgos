/*
2.7 Intersection: Given two (singly) linked lists, determine if the two lists intersect. Return the intersecting
node. Note that the intersection is defined based on reference, not value. That is, if the kth
node of the first linked list is the exact same node (by reference) as the jth node of the second
linked list, then they are intersecting.
Hints: #20, #45, #55, #65, #76, #93, #111, #120, #129
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
        ListNode node8 = new ListNode(8);
        node7.next = node8;
        node8.next = node4;

        ListNode result = mn.getInteraction(node1,node7);
        if(result!=null)
        {
        	System.out.println(result.val);
        }
        else
        {
        	System.out.println("no interaction");
        }
        
    }

    public ListNode getInteraction(ListNode node1, ListNode node2)
    {
    	int count1 =0;
    	ListNode head1 = node1;
    	while(node1!=null)
    	{
    		count1++;
    		node1 = node1.next;
    	}
    	int count2 =0;
    	ListNode head2 = node2;
    	while(node2!=null)
    	{
    		count2++;
    		node2 = node2.next;
    	}

    	if(count1>count2)
    	{
    		int count = count1-count2;
    		int i=0;
    		while(i<count)
    		{
    			i++;
    			head1 = head1.next;
    		}
    	}
    	else
    	{
    		int count = count2-count1;
    		int i=0;
    		while(i<count)
    		{
    			i++;
    			head2 = head2.next;
    		}
    	}
    	while(head1!=null&&head2!=null)
    	{
    		if(head1==head2)
    		{
    			return head1;
    		}
    		head1 = head1.next;
    		head2 = head2.next;
    	}
    	return null;
    }
}