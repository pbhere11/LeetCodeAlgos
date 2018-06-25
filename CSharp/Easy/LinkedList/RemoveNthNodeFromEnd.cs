/*
Example:

Given linked list: 1->2->3->4->5, and n = 2.

After removing the second node from the end, the linked list becomes 1->2->3->5.
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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode slow = head;
        ListNode fast = head;

       for(int i=0;i<n;i++)
       {
       		fast = fast.next;
       }
       if(fast==null)
       {
       		return head.next;
       }
       while(fast.next!=null)
       {
       		fast = fast.next;
       		slow = slow.next;
       }
       
       slow.next = slow.next.next;
       return head;
    }
}