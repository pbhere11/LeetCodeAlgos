/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
Input: 1->2->3->4->5->NULL
Output: 5->4->3->2->1->NULL
 */
public class Solution {
    ListNode returnHead = null;
    public ListNode ReverseList(ListNode head) {
        //return ReverseListIterative(head);
        if(head==null)
        {
            return null;
        }
        ListNode node = ReverseListRecursive(head);
        node.next = null;
        return returnHead;
    }
    private ListNode ReverseListRecursive(ListNode head)
    {
        if(head.next==null)
        {
            returnHead = head;
            return head;
        }
        ListNode node = ReverseListRecursive(head.next);
        node.next = head;
        return head;
    }
    private ListNode ReverseListIterative(ListNode node)
    {
        ListNode prevNode = null;
        ListNode currNode = node;//1
        while(currNode!=null)
        {
            ListNode nextNode = currNode.next;//2
            currNode.next = prevNode;//1-null
            
            prevNode = currNode;//2
            currNode = nextNode;//
        }
        return prevNode;
    }
}