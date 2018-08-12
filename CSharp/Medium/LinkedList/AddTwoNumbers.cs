/*
Example

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807.
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode l3 = null;
        ListNode head = null;
        int carry =0;
        while(l1!=null||l2!=null)
        {
        	int num1 = 0;
        	int num2 = 0;
        	if(l2==null)
        	{
        		num1 = l1.val;
        		l1 = l1.next;
        	}
        	else if(l1==null)
        	{
        		num2 = l2.val;
        		l2 = l2.next;
        	}
        	else
        	{
        		num1 = l1.val;
        		num2 = l2.val;
        		l1 = l1.next;
        		l2 = l2.next;
        	}
        	int val = num1 + num2 + carry;
        	if(val>=10)
        	{
        		carry = 1;
        	}
        	else
        	{
        		carry = 0;
        	}
        	ListNode node = new ListNode(val%10);
        	if(l3 == null)
        	{
        		l3 = node;
        		head = l3;
        	}
        	else
        	{
        		l3.next = node;
        		l3 = l3.next;
        	}
        }
        if(carry ==1)
        {
        	l3.next = new ListNode(carry);
        }
        return head;
    }
}