/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 Example:

Input: 1->2->4, 1->3->4
Output: 1->1->2->3->4->4
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode l3 = new ListNode(0);
        ListNode head = l3;
        while(l1!=null||l2!=null)
        {
        	if(l2==null)
        	{
        		l3.next = l1;
        		l1 = l1.next;
        		l3 = l3.next;
        	}
        	else if(l1==null)
        	{
        		l3.next = l2;
        		l2 = l2.next;
        		l3 = l3.next;
        	}
        	else
        	{
        		if(l1.val<=l2.val)
        		{
        			l3.next = l1;
        			l1 = l1.next;
        			l3 = l3.next;
        		}
        		else
        		{
        			l3.next = l2;
        			l2 = l2.next;
        			l3 = l3.next;
        		}
        	}
        }
        return head.next;
    }
}