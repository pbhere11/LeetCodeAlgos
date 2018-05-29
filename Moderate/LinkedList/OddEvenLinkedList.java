/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 Input: 1->2->3->4->5->NULL

Output: 1->3->5->2->4->NULL
 */
class Solution {
    public ListNode oddEvenList(ListNode head) {
        if(head==null || head.next ==null)
        {
        	return head;
        }
        ListNode oddHeadNode = head;
        ListNode evenHeadNode = head.next;//2
        ListNode oddNode = head;//1
        ListNode evenNode = head.next;//2
        head = head.next.next;//3
        boolean isEvenNode = false;
        while(head!=null)
        {
        	if(isEvenNode)
        	{
        		evenNode.next = head;//4
        		evenNode = evenNode.next;//4
        	}
        	else
        	{
        		oddNode.next = head;//5
        		oddNode = oddNode.next;//5
        	}
        	isEvenNode = !isEvenNode;
        	head = head.next;//5
        }
        evenNode.next = null;
        oddNode.next = evenHeadNode;
        return oddHeadNode;
    }
}