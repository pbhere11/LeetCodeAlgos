/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
Input: 1->2->3->4->5->NULL
Output: 5->4->3->2->1->NULL

 */
class Solution {
	ListNode newHead = null;
    public ListNode reverseList(ListNode head) {
    	if(head==null || head.next ==null)
    	{
    		return head;
    	}
        //return iterativeReverseList(head);
    	ListNode node =  RecursiveReverseList(head);
    	head.next = null;
    	return newHead;
    }

    private ListNode iterativeReverseList(ListNode head)
    {
    	ListNode prevNode = head;//1
    	ListNode currentNode = head.next;//2
    	ListNode nextNode = head.next.next;//3
    	head.next = null;
    	while(currentNode!=null)//5
    	{
    		currentNode.next = prevNode;// 5 - 4 - 3 - 2 - 1
    		prevNode = currentNode;//5
    		currentNode = nextNode;//null
    		if(currentNode!=null)
    			nextNode = currentNode.next;//null
    	}
    	return prevNode;
    }

    private ListNode RecursiveReverseList(ListNode head)//5
    {
    	if(head.next == null)
    	{
    		newHead = head;
    		return head;
    	}
    	ListNode node = RecursiveReverseList(head.next);//5 - 4 - 3 - 2 - 1
    	node.next = head;//5 - 4 - 3 - 2 - 1
    	return head;//1
    }
}