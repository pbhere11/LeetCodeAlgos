/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 A:          a1 → a2
                   ↘
                     c1 → c2 → c3
                   ↗            
B:     b1 → b2 → b3
 */
public class Solution {
    public ListNode getIntersectionNode(ListNode headA, ListNode headB) {
        ListNode node = headA;
        int headACount =0;
        while(node!=null)
        {
        	headACount++;
        	node = node.next;
        }
        node = headB;
        int headBCount =0;
        while(node!=null)
        {
        	headBCount++;
        	node = node.next;
        }
        if(headACount>headBCount)
        {
        	int diff = headACount-headBCount;
        	while(diff!=0)
        	{
        		diff--;
        		headA = headA.next;
        	}
        }
        else
        {
        	int diff = headBCount-headACount;
        	while(diff!=0)
        	{
        		diff--;
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