/*
Example:

Input: 1->2->3->4->5->NULL
Output: 5->4->3->2->1->NULL
*/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
	private ListNode returnHead = null;
    public ListNode ReverseList(ListNode head) {
    	if(head==null || head.next==null)
    	{
    		return head;	
    	}
        //return ReverseListIteratively(head);
        ListNode node = ReverseListRecursively(head);
        node.next = null;
        return returnHead;
    }

    private ListNode ReverseListIteratively(ListNode head)
    {
    	ListNode prevNode = null;
    	ListNode currentNode = head;
    	while(currentNode!=null)
    	{
    		ListNode nextNode = currentNode.next;
    		currentNode.next = prevNode;
    		prevNode = currentNode;
    		currentNode = nextNode;
    	}
    	return prevNode;
    }

    private ListNode ReverseListRecursively(ListNode head)
    {
    	if(head.next ==null)
    	{
    		returnHead = head;
    		return head;
    	}
    	ListNode node = ReverseListRecursively(head.next);
    	node.next = head;
    	return head;
    }
}