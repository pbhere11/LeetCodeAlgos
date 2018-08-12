/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 A:          a1 → a2
                   ↘
                     c1 → c2 → c3
                   ↗            
B:     b1 → b2 → b3
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        int n1 =0;
        int n2 = 0;
        ListNode node = headA;
        while(node!=null)
        {
        	node = node.next;
        	n1++;
        }
        node = headB;
        while(node!=null)
        {
        	node = node.next;
        	n2++;
        }
        int diff =0;
        if(n2>n1)
        {
        	diff = n2-n1;
        	while(diff>0)
        	{
        		headB = headB.next;
        		diff--;
        	}
        }
        else
        {
        	diff = n1-n2;
        	while(diff>0)
        	{
        		headA = headA.next;
        		diff--;
        	}
        }
        while(headA!=null&&headB!=null)
        {
        	if(headA.val==headB.val)
        	{
        		return headA;
        	}
        	headA=headA.next;
        	headB=headB.next;
        }
        return null;
    }
}