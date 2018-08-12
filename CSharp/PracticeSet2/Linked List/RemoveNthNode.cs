/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 Given linked list: 1->2->3->4->5, and n = 2.
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
    	ListNode start = head;
    	ListNode end = head;
        while(n>0)
        {
        	end = end.next;
        	n--;
        }
        if(end == null)
        {
        	return head.next;
        }
        while(end.next!=null)
        {
        	start = start.next;
        	end = end.next;
        }
        start.next = start.next.next;
        return head;
    }
}