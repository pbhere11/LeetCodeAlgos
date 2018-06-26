/*
Input: 1->2->4, 1->3->4
Output: 1->1->2->3->4->4
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
	public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        //return MergeTwoListsIterative(l1,l2);
        return MergeTwoListRecursively(l1,l2);
    }

    private ListNode MergeTwoListRecursively(ListNode l1, ListNode l2)
    {
    	ListNode ans = null;
    	if(l1==null) return l2;
    	if(l2==null) return l1;
    	if(l1.val<=l2.val)
    	{
    		ans = MergeTwoListRecursively(l1.next,l2);
    		l1.next = ans;
    		return l1;
    	}
    	else
    	{
    		ans = MergeTwoListRecursively(l1,l2.next);
    		l2.next = ans;
    		return l2;
    	}

    }

    private ListNode MergeTwoListsIterative(ListNode l1, ListNode l2) {
    	ListNode returnHead = new ListNode(0);
    	ListNode head = returnHead;
        while(l1!=null||l2!=null)
        {
        	if(l1==null)
        	{
        		head.next = l2;
        		return returnHead.next;
        	}
        	else if(l2==null)
        	{
        		head.next = l1;
        		return returnHead.next;
        	}
        	else
        	{
        		if(l1.val<l2.val)
        		{
        			head.next = l1;
        			l1 = l1.next;
        			head = head.next;
        		}
        		else
        		{
        			head.next = l2;
        			l2 = l2.next;
        			head = head.next;
        		}
        	}
        }
        return returnHead.next;
    }
}