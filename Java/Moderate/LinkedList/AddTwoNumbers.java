/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 */
class Solution {
    public ListNode addTwoNumbers(ListNode l1, ListNode l2) {
        int carry = 0;
        ListNode l3 = null;
        ListNode head = null;
        while(l1!=null || l2!=null)
        {
        	int first = 0;
        	if(l1!=null)
        	{
        		first = l1.val;
        		l1 = l1.next;
        	}
        	int second = 0;
        	if(l2!=null)
        	{
        		second = l2.val;
        		l2 = l2.next;
        	}
        	int value = first + second + carry;
        	if(value>=10)
        	{
        		carry =1;
        		value = value%10;
        	}
        	else
        	{
        		carry = 0;
        	}
        	if(l3==null)
        	{
        		l3 = new ListNode(value);
        		head = l3;
        	}
        	else
        	{
        		l3.next = new ListNode(value);
        		l3 = l3.next;
        	}
        }
        if(carry>0)
        {
        	l3.next = new ListNode(carry);
        }
        return head;
    }
}