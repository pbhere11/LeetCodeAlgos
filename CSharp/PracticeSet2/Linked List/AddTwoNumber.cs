/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
Example:

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807.
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode l3 = new ListNode(0);
        ListNode head = l3;
        int carry =0;
        while(l1!=null||l2!=null)
        {
        	int num1 =0;
        	int num2 =0;
        	if(l2==null)
        	{
        		num1=l1.val;
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
        	int ans = num1+num2+carry;
        	if(ans>=10)
        	{
        		carry=1;
        	}
        	else
        	{
        		carry=0;
        	}
        	l3.next = new ListNode(ans%10);
        	l3 = l3.next;
        }
        if(carry==1)
        {
        	l3.next = new ListNode(1);
        }
        return head.next;
    }
}