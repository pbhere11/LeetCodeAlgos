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
 			a1 → a2
                   ↘
                     c1 → c2 → c3
                   ↗            
B:     b1 → b2 → b3
 */
public class Solution {
    public ListNode getIntersectionNode(ListNode headA, ListNode headB) {

        int listALength = 0;
        int listBLength =0;
        ListNode node = headA;
        while(node!=null)
        {
        	listALength++;
        	node =node.next;
        }
        node = headB;
        while(node!=null)
        {
        	listBLength++;
        	node = node.next;
        }
        if(listALength>listBLength)
        {
        	int diff = listALength-listBLength;
        	while(diff!=0)
        	{
        		diff--;
        		headA = headA.next;
        	}
        }
        else
        {
        	int diff = listBLength-listALength;
        	while(diff!=0)
        	{
        		diff--;
        		headB = headB.next;
        	}
        }
        while(headA!=null || headB!=null)
        {
        	if(headA.val==headB.val)
        	{
        		return headA;
        	}
        	headA=headA.next;
        	headB = headB.next;
        }
        return null;
    }
}