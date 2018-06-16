/*
2.1 Remove Dups: Write code to remove duplicates from an unsorted linked list.
FOLLOW UP
How would you solve this problem if a temporary buffer is not allowed?
Hints: #9, #40
*/

// "static void main" must be defined in a public class.
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
        String line;//1,2,1,2
        ListNode head = null;
        while ((line = in.readLine()) != null) {
            ListNode node = Wrapper.stringToListNode(line);
            head = node;
            Wrapper.prettyPrintLinkedList(node);
        }

        MainClass mn = new MainClass();
        //mn.deleteDuplicateNode(head);
        mn.deleteDuplicateNodeSet(head);
        Wrapper.prettyPrintLinkedList(head);
    }

    public void deleteDuplicateNode(ListNode head)
    {
    	if(head!=null && head.next!=null)
    	{
    		ListNode currentNode = head;
    		while(currentNode!=null)
    		{
    			ListNode runnerNode = currentNode.next;
    			ListNode prevNode = currentNode;
    			while(runnerNode!=null)
    			{
    				if(runnerNode.val==currentNode.val)
    				{
    					prevNode.next=runnerNode.next;
    				}
    				prevNode = runnerNode;
    				runnerNode = runnerNode.next;
    			}
    			currentNode = currentNode.next;
    		}
    	}
    }

    public void deleteDuplicateNodeSet(ListNode head)
    {
    	HashSet<Integer> set = new HashSet<Integer>();
    	ListNode prevNode = null;
    	while(head!=null)
    	{
    		if(set.contains(head.val))
    		{
    			prevNode.next = head.next;
    		}
    		else
    		{
    			set.add(head.val);
    			prevNode = head;
    		}
    		head = head.next;
    	}
    }
}