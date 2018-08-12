/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 1->2->3->4->5

 */
class Solution {
    public ListNode removeNthFromEnd(ListNode head, int n) {
    	if(head==null)
    	{
    		return head;
    	}
        ListNode right = head;//1
        ListNode left = head;//1
        int i=0;
        while(i<n)//1
        {
			right = right.next;//null
			i++;//1
        }
        if(right==null)
        {
        	head = head.next;
        	return head;
        }
        while(right.next!=null)
        {
        	right = right.next;
        	left = left.next;
        }
        left.next = left.next.next;
        return head;
    }
}