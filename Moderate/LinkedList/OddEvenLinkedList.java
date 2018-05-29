/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 Input: 1->2->3->4->5->NULL
 Output: 1->3->5->2->4->NULL
 */
class Solution {
    public ListNode oddEvenList(ListNode head) {
        boolean evenNode = false;
        ListNode prevNode = null;
        ListNode currentNode = head;
        ListNode nextNode = currentNode.next;
        while(currentNode!=null && nextNode!=null)
        {
        	if(evenNode)
        	{
        		prevNode.next = nextNode;
        		currentNode.next = nextNode.next;
        		nextNode.next = currentNode;
        	}
        	if(prevNode!=null)
        	{
        		prevNode = prevNode.next;
        	}
        	else
        	{
        		prevNode = currentNode;
        	}
			currentNode = prevNode.next;
			nextNode = currentNode.next;
        	evenNode = !evenNode;
		}
		return head;
    }
}