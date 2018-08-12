/*
Example 1:

Input: 1->2
Output: false
Example 2:

Input: 1->2->2->1
Output: true
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
    private ListNode mainHead = null;
    public bool IsPalindrome(ListNode head) {
    	if(head==null)
    	{
    		return true;
    	}
        mainHead = head;
        return isPalindromicList(head);
    }
    private bool isPalindromicList(ListNode head)
    {
    	if(head.next ==null)
    	{
    		if(head.val == mainHead.val)
    		{
    			mainHead = mainHead.next;
    			return true;
    		}
    		else
    		{
    			return false;
    		}
    	}
    	bool isNextNodePalindrome = isPalindromicList(head.next);
    	bool result = isNextNodePalindrome && head.val == mainHead.val;
    	mainHead = mainHead.next;
    	return result;
    }
}