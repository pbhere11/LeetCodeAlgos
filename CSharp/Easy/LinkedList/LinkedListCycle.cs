/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
    	if(head==null)
    	{
    		return false;
    	}
       ListNode slow = head;
       ListNode fast = head.next;
       while(fast!=null && fast.next!=null)
       {
       		if(fast.val==slow.val)
       		{
       			return true;
       		}
       		fast = fast.next.next;
       		slow = slow.next;
       } 
       return false;
    }
}