/*
For example, the following two linked lists:

A:          a1 → a2
                   ↘
                     c1 → c2 → c3
                   ↗            
B:     b1 → b2 → b3
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
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        ListNode node = headA;
        if(headA==null || headB==null)
        {
        	return null;
        }
        int l1 =0;
        while(node!=null)
        {	
        	l1++;
        	node = node.next;
        }
        node = headB;
        int l2 = 0;
        while(node!=null)
        {
        	l2++;
        	node = node.next;
        }
        if(l1>l2)
        {
        	for(int i=0;i<l1-l2;i++)
        	{
        		headA = headA.next;
        	}
        }
        else
        {
        	for(int i=0;i<l2-l1;i++)
        	{
        		headB = headB.next;
        	}
        }
        while(headA!=null&&headB!=null)
        {
        	if(headA.val==headB.val)
        	{
        		return headA;
        	}
        	headA = headA.next;
        	headB = headB.next;
        }
        return null;
    }
}