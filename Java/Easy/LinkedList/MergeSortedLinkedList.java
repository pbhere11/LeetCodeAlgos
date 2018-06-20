/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
Input: 1->2->4, 1->3->4
Output: 1->1->2->3->4->4
 */
class Solution {
    public ListNode mergeTwoLists(ListNode l1, ListNode l2) {
        ListNode head = new ListNode(0);
        ListNode node = head;
        while(l1!=null || l2!=null)
        {
        	if(l1==null)
        	{
        		node.next = l2;
        		break;
        	}
        	else if(l2==null)
        	{
        		node.next = l1;
        		break;
        	}
        	else
        	{
        		if(l1.val<=l2.val)
        		{
        			node.next = l1;
        			l1 = l1.next;
        		}
        		else
        		{
        			node.next = l2;
        			l2 = l2.next;
        		}
        	}
        	node = node.next;
        }
        return head.next;
    }
}