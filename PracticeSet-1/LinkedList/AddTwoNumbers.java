/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807.
 */
class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        int carry =0;
        ListNode head = new ListNode(0);
        ListNode node = head;
        while(l1!=null||l2!=null)
        {
        	int l1Val =0;
        	if(l1!=null)
        	{
        		l1Val = l1.val;
        		l1 = l1.next;
        	}
        	int l2Val =0;
        	if(l2!=null)
        	{
        		l2Val = l2.val;
        		l2 = l2.next;
        	}
        	int val = l1Val + l2Val + carry;
        	ListNode l3 = new ListNode((val%10));
        	node.next = l3;
        	node = node.next;
        	if(val>=10)
        	{
        		carry = 1;
        	}
        	else
        	{
        		carry = 0;
        	}
        }
        if(carry>0)
        {
        	node.next = new ListNode(carry);
        }
        return head.next;
    }
}