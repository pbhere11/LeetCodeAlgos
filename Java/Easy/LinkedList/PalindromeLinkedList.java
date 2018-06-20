/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode(int x) { val = x; }
 * }
 Input: 1->2->2->1
Output: true
 */
class Solution {
	private ListNode mainHead; 
    public boolean isPalindrome(ListNode head) {
    	if(head==null)
    	{
    		return true;
    	}
    	mainHead = head;
        return isPalindromrRecursive(head);
    }
    private boolean isPalindromrRecursive(ListNode node)
    {
    	if(node.next==null)
    	{
    		if(node.val == mainHead.val)
    		{
    			mainHead = mainHead.next;
    			return true;
    		}
    		else
    		{
    			mainHead = mainHead.next;
    			return false;
    		}
    	}
    	boolean flag = isPalindromrRecursive(node.next);
    	if(flag && mainHead.val == node.val)
    	{
    		mainHead = mainHead.next;
    		return true; 
    	}
    	else
    	{
			mainHead = mainHead.next;
			return false;
		}
    }
}