/*
Example 1:

Input: 1->2->3->4->5->NULL
Output: 1->3->5->2->4->NULL
Example 2:

Input: 2->1->3->5->6->4->7->NULL
Output: 2->3->6->7->1->5->4->NULL
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
    public ListNode OddEvenList(ListNode head) {
       ListNode oddHead = null;
       ListNode evenHead = null;
       ListNode oddNode = null;
       ListNode evenNode = null;
       bool isOdd = true;
       while(head!=null)
       {
       		if(isOdd)
       		{
       			if(oddNode==null)
       			{
       				oddNode = head;
       				oddHead = oddNode;
       			}
       			else
       			{
       				oddNode.next = head;
       				oddNode = oddNode.next;
       			}
       		}
       		else
       		{
       			if(evenNode==null)
       			{
       				evenNode = head;
       				evenHead = evenNode;
       			}
       			else
       			{
       				evenNode.next = head;
       				evenNode = evenNode.next;
       			}
       		}
       		head = head.next;
       		isOdd = !isOdd;
       }
       if(oddNode!=null)
       {
       		oddNode.next = evenHead;
       }
       if(evenNode!=null)
       {
       		evenNode.next = null;
       }
       
       return oddHead;
    }
}