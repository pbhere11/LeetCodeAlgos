/*
2.2 Return Kth to Last: Implement an algorithm to find the kth to last element of a singly linked list.
Hints: #8, #25, #47, #67, # 726
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
        String line;//1,2,3,4,5,6, 2
        ListNode head = null;
        while ((line = in.readLine()) != null) {
            ListNode node = Wrapper.stringToListNode(line);
            head = node;
            Wrapper.prettyPrintLinkedList(node);
        }
        MainClass mn = new MainClass();
        ListNode node = mn.kthToLast(head,2);
        System.out.println(node.val);

    }

    public ListNode kthToLast(ListNode head, int k)
    {
    	if(head ==null)
    	{
    		return null;
    	}
    	ListNode currentNode = head;
    	ListNode runnerNode = head;

    	for(int i=0;i<k;i++)
    	{
    		runnerNode = runnerNode.next;
    	}

    	if(runnerNode==null)
    	{
    		return head;
    	}
    	while(runnerNode!=null)
    	{
    		currentNode = currentNode.next;
    		runnerNode = runnerNode.next;
    	}
    	return currentNode;
    }
}